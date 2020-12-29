using System;
using System.Drawing;

namespace GraphColoring
{
    class Points
    {
        private string name;
        private Color c;

        private int grau;

        public Color C { get => c; set => c = value; }
        public int Grau { get => grau; set => grau = value; }
        public string Name { get => name; set => name = value; }

        public Points(string text)
        {
            this.Name = text;
            this.C = Color.White;
        }
        public override bool Equals(object obj)
        {
            return ((Points) obj).name == this.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, c, grau, C, Grau, Name);
        }
    }
}
