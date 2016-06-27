using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core.Buffer
{
    public class VertexArraySoA : VertexArrayBase
    {
        #region Properties

        /// <summary>
        /// A association between vertex attribute locations (key) and buffer id's (value)
        /// </summary>
        public Dictionary<int, int> DataBuffers { get; private set; } = new Dictionary<int, int>();

        #endregion

        #region Construction

        private VertexArraySoA(ContextInfo info) : base(info)
        { }

        public static VertexArraySoA CreateInstance(ContextInfo ctxtInfo, Dictionary<int, VertexAttribInfo> attribInfos, BeginMode primativeType, BufferUsageHint usageMode, bool isIndexed)
        {
            VertexArraySoA instance = new VertexArraySoA(ctxtInfo);
            instance.PrepInstance(attribInfos, primativeType, usageMode, isIndexed);

            //gen the buffers
            foreach(var info in attribInfos)
            {
                instance.DataBuffers.Add(info.Value.VertexAttribLocation, GL.GenBuffer());
            }
            if (instance.DataBuffers.ContainsValue(0))
                throw new BufferCreateException();

            return instance;
        }

        #endregion

        #region OpenGL

        //T must be a vector type
        public void BufferData<T>(int attribLoc, T[] data) where T : struct
        {
            int buffId;
            bool success = DataBuffers.TryGetValue(attribLoc, out buffId);
            //throw an exception?
            if (!success)
                return;

            VertexCount = data.Length;

            VertexAttribInfo info;
            success = VertexAttribInfos.TryGetValue(attribLoc, out info);
            //throw an exception?
            if (!success)
                return;

            GL.BindBuffer(BufferTarget.ArrayBuffer, buffId);
            int bytesPerValue = info.BytesPerElement * info.ElementsPerValue;
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(data.Length * bytesPerValue), data, UsageMode);
        }

        #endregion

        #region Overriden Methods

        protected override void EnableVertexAttributes()
        {
            foreach(var info in VertexAttribInfos)
            {
                GL.BindBuffer(BufferTarget.ArrayBuffer, DataBuffers[info.Value.VertexAttribLocation]);
                GL.EnableVertexAttribArray(info.Value.VertexAttribLocation);
                GL.VertexAttribPointer(info.Value.VertexAttribLocation, info.Value.ElementsPerValue, info.Value.Type, false, 0, 0);
            }
        }

        protected override void RefreshDataBufferAttribute()
        {
            if (CtxtInfo.Version >= 30)
            {
                BindVertexArray();
                foreach (var info in VertexAttribInfos)
                {
                    GL.BindBuffer(BufferTarget.ArrayBuffer, DataBuffers[info.Value.VertexAttribLocation]);
                    GL.VertexAttribPointer(info.Value.VertexAttribLocation, info.Value.ElementsPerValue, info.Value.Type, false, 0, 0);
                }
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

                foreach(var pair in DataBuffers)
                {
                    GL.DeleteBuffer(pair.Value);
                }

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
