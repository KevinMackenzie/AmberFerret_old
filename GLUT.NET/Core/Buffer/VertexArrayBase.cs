using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pencil.Gaming.Graphics;

namespace GLUT.NET.Core.Buffer
{
    public struct VertexAttribInfo
    {
        public ushort BytesPerElement;//int would be 4
        public ushort ElementsPerValue;//vec4 would be 4
        public int VertexAttribLocation;
        public DataType Type;//float would be DataType.Float
        public uint Offset;//will be 0 in SoA
    }

    public abstract class VertexArrayBase
    {
        #region Properties
        
        public int VertexArrayId { get; private set; } = 0;
        public int VertexCount { get; protected set; } = 0;

        public int IndexBufferId { get; private set; } = 0;
        public int IndexCount { get; protected set; } = 0;
        public bool Indexed { get; private set; } = false;

        public Dictionary<int, VertexAttribInfo> VertexAttribInfos { get; private set; } = new Dictionary<int, VertexAttribInfo>();

        public BeginMode PrimativeType { get; protected set; } = BeginMode.Triangles;
        public BufferUsageHint UsageMode { get; protected set; } = BufferUsageHint.StaticDraw;

        #endregion

        #region Construction

        protected VertexArrayBase()
        {
        }

        //this is non-static here, but will be static in children
        protected void CreateBase(Dictionary<int, VertexAttribInfo> attribInfos, BeginMode primativeType, BufferUsageHint usageMode, bool isIndexed)
        {
            VertexAttribInfos = attribInfos;
            PrimativeType = primativeType;
            UsageMode = usageMode;
            Indexed = isIndexed;

            if (ContextInfo.Instance.Version >= 30)
            {
                VertexArrayId = GL.GenVertexArray();
            }
            if (Indexed)
            {
                IndexBufferId = GL.GenBuffer();
            }

        }

        #endregion

        #region OpenGL Stuff

        public void BindVertexArray()
        {
            if (0 == VertexArrayId)
                throw new VertexArrayNullException();
            GL.BindVertexArray(VertexArrayId);
        }
        
        public void Draw()
        {
            BindVertexArray();

            if(ContextInfo.Instance.Version < 30)
            {
                EnableVertexAttributes();
            }

            //TODO: Make these openGL calls have some safety!!!
            if (Indexed)
            {
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, IndexBufferId);
                GL.DrawElements(PrimativeType, IndexCount, DrawElementsType.UnsignedInt, IntPtr.Zero);
            }
            else
            {
                GL.DrawArrays(PrimativeType, 0, VertexCount);
            }

            if(ContextInfo.Instance.Version < 30)
            {
                DisableVertexAttributes();
            }
        }

        public void DrawRange(uint start, uint count)
        {
            BindVertexArray();

            if(ContextInfo.Instance.Version < 30)
            {
                EnableVertexAttributes();
            }

            //TODO: Make these openGL calls have some safety!!!
            if(Indexed)
            {
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, IndexBufferId);
                GL.DrawElements(PrimativeType, (int)count, DrawElementsType.UnsignedInt, (int)start);
            }
            else
            {
                GL.DrawArrays(PrimativeType, (int)start, (int)count);
            }

            if (ContextInfo.Instance.Version < 30)
            {
                DisableVertexAttributes();
            }
        }

        public void DrawInstanced(uint instances)
        {

            BindVertexArray();

            if (ContextInfo.Instance.Version < 30)
            {
                EnableVertexAttributes();
            }

            //TODO: Make these openGL calls have some safety!!!
            if (Indexed)
            {
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, IndexBufferId);
                GL.DrawElementsInstanced(PrimativeType, IndexCount, DrawElementsType.UnsignedInt, IntPtr.Zero, (int)instances);
            }
            else
            {
                GL.DrawArraysInstanced(PrimativeType, 0, VertexCount, (int)instances);
            }

            if (ContextInfo.Instance.Version < 30)
            {
                DisableVertexAttributes();
            }
        }

        protected void EnableVertexAttributes()
        {
            foreach(var info in VertexAttribInfos)
            {
                GL.EnableVertexAttribArray(info.Key);
            }
        }

        protected void DisableVertexAttributes()
        {
            foreach (var info in VertexAttribInfos)
            {
                GL.DisableVertexAttribArray(info.Key);
            }
        }

        public void BufferIndices(uint[] indices)
        {
            BindVertexArray();
            IndexCount = indices.Length;
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, IndexBufferId);
            GL.BufferData<uint>(BufferTarget.ElementArrayBuffer, (IntPtr)(4 * IndexCount), indices, UsageMode);
        }

        #endregion

        #region Abstract Methods
        /// <summary>
        /// This should be overriden to reset the data layout in the openGL vertex Array
        /// </summary>
        protected abstract void RefreshDataBufferAttribute();

        #endregion  

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {
                        GL.DeleteBuffer(IndexBufferId);

                        if (ContextInfo.Instance.Version >= 30)
                        {
                            GL.DeleteVertexArray(VertexArrayId);
                        }
                    }
                    catch { }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~FontService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
