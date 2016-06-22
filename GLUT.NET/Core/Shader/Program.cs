using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core.Shader
{
    public struct ProgramLinkLog
    {
        public string Message;
        public bool Result;
    }

    public struct ProgramAttributeInfo
    {
        public string Name;
        public int Location;
        public ActiveAttribType Type;
    }

    public struct ProgramUniformInfo
    {
        public string Name;
        public int Location;
        public ActiveUniformType Type;
    }


    public class Program
    {

        #region Properties

        public int ProgramId { get; private set; } = 0;
        public bool IsSeparable { get; private set; } = false;
        public ProgramStageMask Stages { get; private set; } = 0;

        public Dictionary<string, ProgramAttributeInfo> AttributeLocations { get; private set; } = new Dictionary<string, ProgramAttributeInfo>();
        public Dictionary<string, ProgramUniformInfo> UniformLocations { get; private set; } = new Dictionary<string, ProgramUniformInfo>();

        #endregion

        #region Constructor

        private Program()
        { }

        #endregion

        #region OpenGL Stuff

        public static Program CreateProgram(Dictionary<ShaderType, Shader> shaders, bool separable, out ProgramLinkLog log)
        {
            Program ret = new Program();
            ret.ProgramId = (int)GL.CreateProgram();

            log = new ProgramLinkLog();

            if (ret.ProgramId == 0)
            {
                log.Message = "Program Not Initialized Properly!";
                log.Result = false;
                return null;
            }
            
            //validate that each stage corresponds correctly
            foreach(var shader in shaders)
            {
                if (shader.Key != shader.Value.Type)
                {
                    log.Message = "Shader Type Does Not Correspond With Dictionary Value!";
                    log.Result = false;
                    return null;
                }
            }

            //add each of the shaders
            foreach (var shader in shaders)
            {
                GL.AttachShader(ret.ProgramId, shader.Value.ShaderId);
            }

            //handle separate programs specially
            if (separable)
            {
                ret.IsSeparable = true;

                GL.ProgramParameter(ret.ProgramId, AssemblyProgramParameterArb.ProgramSeparable, 1);

                //create a list of stages
                foreach (var shader in shaders)
                {
                    ret.Stages = (ProgramStageMask)((int)ret.Stages | (int)shader.Key);
                }
            }

            //link the program
            GL.LinkProgram(ret.ProgramId);

            //get the link state
            int isLinked = 0;
            GL.GetProgram(ret.ProgramId, ProgramParameter.LinkStatus, out isLinked);
            log.Result = isLinked == 1;

            //get the link log
            log.Message = GL.GetProgramInfoLog(ret.ProgramId);

            //if the program compiled correctly, then load the uniforms/attribute locations
            if(log.Result)
            {

                //get the attributes
                int attribCount;
                GL.GetProgram(ret.ProgramId, ProgramParameter.ActiveAttributes, out attribCount);

                int len;

                for(int i = 0; i < attribCount; ++i)
                {
                    ProgramAttributeInfo attribInfo = new ProgramAttributeInfo();

                    attribInfo.Name = GL.GetActiveAttrib(ret.ProgramId, i, out len, out attribInfo.Type);
                    attribInfo.Location = GL.GetAttribLocation(ret.ProgramId, attribInfo.Name);
                    
                    ret.AttributeLocations.Add(attribInfo.Name, attribInfo);
                }


                //get the uniforms
                int uniformCount;
                GL.GetProgram(ret.ProgramId, ProgramParameter.ActiveUniforms, out uniformCount);
                
                for(int i = 0; i < uniformCount; ++i)
                {
                    ProgramUniformInfo uniformInfo = new ProgramUniformInfo();

                    uniformInfo.Name = GL.GetActiveUniform(ret.ProgramId, i, out len, out uniformInfo.Type);
                    uniformInfo.Location = GL.GetUniformLocation(ret.ProgramId, uniformInfo.Name);

                    ret.UniformLocations.Add(uniformInfo.Name, uniformInfo);
                }
            }

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
                        GL.DeleteShader(ProgramId);
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
