using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pencil.Gaming;

namespace GLUT.NET.Core
{
    public class Window
    {
        public GlfwWindowPtr GlfwWindow { get; private set; }
        public ContextInfo contextInfo = new ContextInfo();

        public Window(GlfwWindowPtr window)
        {
            GlfwWindow = window;
        }
    }
}
