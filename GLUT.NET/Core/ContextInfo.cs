using Pencil.Gaming.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GLUT.NET.Core
{
    public class ContextInfo
    {
        public static ContextInfo Instance { get; set; } = new ContextInfo();

        public int VersionMajor { get; private set; } = 0;
        public int VersionMinor { get; private set; } = 0;

        public int GLSLVersionMajor { get; private set; } = 0;
        public int GLSLVersionMinor { get; private set; } = 0;

        public string[] Extensions { get; private set; } = null;
        
        /// <summary>
        /// This must be called AFTER context creation
        /// </summary>
        public void Init()
        {
            //get the opengl version
            string versionString = GL.GetString(StringName.Version);

            var versionStringSplit = versionString.Split('.');
            if (2 != versionStringSplit.Length)
                throw new OpenGLException("Failed to Get OpenGL Version String");

            string versionStringMajor = versionStringSplit[0];
            string versionStringMinor = versionStringSplit[1];

            try
            {
                VersionMajor = int.Parse(versionStringMajor);
                VersionMinor = int.Parse(versionStringMinor);
            }
            catch
            {
                throw new OpenGLException("Failed to Parse OpenGL Version String");
            }

            //get the glsl version
            versionString = GL.GetString(StringName.ShadingLanguageVersion);

            versionStringSplit = versionString.Split('.');
            if (2 != versionStringSplit.Length)
                throw new OpenGLException("Failed to Get GLSL Version String");

            versionStringMajor = versionStringSplit[0];
            versionStringMinor = versionStringSplit[1];

            try
            {
                GLSLVersionMajor = int.Parse(versionStringMajor);
                GLSLVersionMinor = int.Parse(versionStringMinor);
            }
            catch
            {
                throw new OpenGLException("Failed to Parse GLSL Version String");
            }

            //get the extensions
            string extensions = GL.GetString(StringName.Extensions);

            Extensions = extensions.Split(' ');
        }
    }
}
