using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core.Shader
{
    public struct ShaderCompileLog
    {
        public string Message;
        public bool Result;
    }

    public class Shader : ContextDependent
    {
        #region Properties

        public int ShaderId { get; private set; } = 0;
        public ShaderType Type { get; private set; }

        #endregion

        #region Constructor

        private Shader(ContextInfo info) : base(info)
        {
        }

        public static Shader CreateInstance(ContextInfo ctxtInfo, string text, ShaderType type, out ShaderCompileLog log)
        {
            Shader ret = new Shader(ctxtInfo);
            ret.Type = type;

            GL.CreateShader(ret.Type);

            log = new ShaderCompileLog();

            if (ret.ShaderId == 0)
            {
                log.Message = "Shader Not Initialized Properly!";
                log.Result = false;
                return null;
            }

            //add the text to the shader
            GL.ShaderSource((uint)ret.ShaderId, text);

            //compile the shader
            GL.CompileShader(ret.ShaderId);

            //get the result and message
            log.Message = GL.GetShaderInfoLog(ret.ShaderId);
            int success;
            GL.GetShader(ret.ShaderId, ShaderParameter.CompileStatus, out success);
            log.Result = success == 1;

            return ret;
        }

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
                        GL.DeleteShader(ShaderId);
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
