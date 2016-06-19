using System.Collections.Generic;
using Pencil.Gaming.MathUtils;

namespace GLUT.NET.Core
{
    /// <summary>
    /// MatrixStack is a convenient matrix stack which can easily combine
    /// transformations of a hierarchal scene while only computing
    /// each matrix multiplication once
    /// </summary>
    public class MatrixStack
    {
        Stack<Matrix> Stack = new Stack<Matrix>();
        public void Push(Matrix mat)
        {
            if (Stack.Count != 0)
            {
                Matrix newMat = mat * Stack.Peek();
                Stack.Push(newMat);
            }
            else
            {
                Stack.Push(mat);
            }
        }
        public void Pop()
        {
            Stack.Pop();
        }
        public void Peek()
        {
            Stack.Peek();
        }
        public int Count()
        {
            return Stack.Count;
        }
        bool Empty()
        {
            return Stack.Count == 0;
        }
    }
}
