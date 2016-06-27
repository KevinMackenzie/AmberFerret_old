using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core.Shader
{
    public class ProgrammablePipelineObject : ContextDependent
    {
        #region Properties

        public int PPOId { get; private set; } = 0;
        public List<Program> Programs { get; private set; } = new List<Program>();
        
        public ProgramStageMask ActiveStage { get { return _activeStage; } set { SetActiveStage(value); } }
        private ProgramStageMask _activeStage = ProgramStageMask.AllShaderBits;

        #endregion

        #region OpenGL Stuff

        private ProgrammablePipelineObject(ContextInfo ctxtInfo) : base(ctxtInfo)
        { }

        public static ProgrammablePipelineObject CreateInstance(List<Program> programs)
        {
            if (programs.Count == 0)
                throw new ArgumentException("Blank List Of Programs");

            ProgrammablePipelineObject ret = new ProgrammablePipelineObject(programs[0].CtxtInfo);
            ret.PPOId = GL.GenProgramPipeline();

            if(ret.PPOId == 0)
            {
                //log this somehow?
                return null;
            }

            GL.BindProgramPipeline(ret.PPOId);
            foreach (var program in programs)
            {
                if(null != program)
                {
                    if(0 != program.ProgramId)
                    {
                        ret.Programs.Add(program);
                        GL.UseProgramStages(ret.PPOId, program.Stages, program.ProgramId);
                    }
                }
            }

            return ret;
        }

        #endregion

        #region Setters

        private void SetActiveStage(ProgramStageMask stage)
        {
            if (_activeStage == stage)
                return;

            foreach(var program in Programs)
            {
                if (((int)program.Stages & (int)stage) != 0)
                {
                    GL.ActiveShaderProgram(PPOId, program.ProgramId);
                    ActiveStage = stage;
                    return;
                }
            }

            //this is the default (doesn't make sense, but is something we can test against)
            _activeStage = ProgramStageMask.AllShaderBits;
        }

        #endregion
    }
}
