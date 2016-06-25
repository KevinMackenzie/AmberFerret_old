using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET
{
    public class VertexArrayNullException : Exception
    {
        public VertexArrayNullException() : base("Attempt to Bind Null Vertex Array")
        {}
    }

    public class BufferNullException : Exception
    {
        public BufferNullException() : base("Attempt to Bind Null Buffer")
        { }
    }

    public class ProgramNullException : Exception
    {
        public ProgramNullException() : base("Attempt to Use Null Program")
        { }
    }

    public class OpenGLException : Exception
    {
        public OpenGLException(string msg) : base(String.Format("Failed to Parse OpenGL Output: \"{0}\"", msg))
        { }
    }
}
