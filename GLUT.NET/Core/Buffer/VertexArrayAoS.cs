using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core.Buffer
{
    public interface IVertexData
    {
        /// <summary>
        /// Vertex Data has a size per vertex including all attributes
        /// </summary>
        /// <returns>the sum of the size of all attributes</returns>
        int Size();
    }


    public class VertexArrayAoS : VertexArrayBase
    {
        #region Properties

        public int DataBufferId { get; private set; } = 0;
        public int CopyBufferId { get; private set; } = 0;

        #endregion

        #region Construction

        private VertexArrayAoS(ContextInfo info) : base(info)
        { }

        public static VertexArrayAoS CreateInstance(ContextInfo info, Dictionary<int, VertexAttribInfo> attribInfos, BeginMode primativeType, BufferUsageHint usageMode, bool isIndexed)
        {
            VertexArrayAoS instance = new VertexArrayAoS(info);
            instance.PrepInstance(attribInfos, primativeType, usageMode, isIndexed);

            //gen the buffers
            instance.DataBufferId = GL.GenBuffer();
            instance.CopyBufferId = GL.GenBuffer();

            if (0 == instance.DataBufferId || 0 == instance.CopyBufferId)
                throw new BufferCreateException();

            return instance;
        }

        #endregion

        #region OpenGL

        public void BufferData<T>(T[] data) where T : struct,IVertexData
        {
            //logical first step
            if (data.Length == 0)
                return;

            int vertexSize = GetVertexSize();

            if(data[0].Size() != vertexSize)
            {
                throw new ArgumentException("(VertexArrayAoS.BufferData): data vertex size is not compatible");
            }

            BindVertexArray();
            GL.BindBuffer(BufferTarget.ArrayBuffer, DataBufferId);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(data.Length * vertexSize), data, UsageMode);

            VertexCount = data.Length;
        }

        #endregion

        #region Helper Methods

        protected static uint RoundNearestMultiple(uint num, uint multiple)
        {
            return (num / multiple + 1) * multiple;
        }

        public int GetVertexSize()
        {
            int stride = 0;
            foreach(var info in VertexAttribInfos)
            {
                stride += info.Value.ElementsPerValue * (int)RoundNearestMultiple(info.Value.BytesPerElement, 4);
            }

            return stride;
        }

        #endregion

        #region Overriden Methods

        protected override void RefreshDataBufferAttribute()
        {
            if(CtxtInfo.Version >= 30)
            {
                BindVertexArray();

                GL.BindBuffer(BufferTarget.ArrayBuffer, DataBufferId);

                int stride = GetVertexSize();
                foreach(var info in VertexAttribInfos)
                {
                    GL.VertexAttribPointer(info.Value.VertexAttribLocation, info.Value.ElementsPerValue, info.Value.Type, false, stride, (int)info.Value.Offset);
                }
            }
        }

        protected override void EnableVertexAttributes()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, DataBufferId);
            int stride = GetVertexSize();
            foreach (var info in VertexAttribInfos)
            {
                GL.EnableVertexAttribArray(info.Key);
                GL.VertexAttribPointer(info.Value.VertexAttribLocation, info.Value.ElementsPerValue, info.Value.Type, false, stride, (int)info.Value.Offset);
            }
        }

        #endregion 
        
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {

                        base.Dispose(disposing);
                    }
                    catch { }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                GL.DeleteBuffer(DataBufferId);
                GL.DeleteBuffer(CopyBufferId);

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~FontService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }
        #endregion
    }
}
