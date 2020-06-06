using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Testing.Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;

        public int Length { get => this.length; set => this.length = value; }
        public int Width { get => this.width; set => this.width = value; }

        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength()
        {
            return this.Length;
        }

        public int SetLength(int length)
        {
            this.Length = length;
            return this.Length;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public int SetWidth(int width)
        {
            this.Width = width;
            return this.Width;
        }

        public int GetPerimeter()
        {
            return (2 * (this.Length + this.Width));
        }

        public int GetArea()
        {
            return (this.Length * this.Width);
        }
    }
}
