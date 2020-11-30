using System;
using System.Drawing;

namespace WinEquation
{
    public class EquationColor
    {
        private String equation;
        private Color color;
        public String Equation
        {
            get
            {
                return equation;
            }
            set
            {
                equation = value;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public EquationColor()
        {

        }

        public EquationColor(String equation, Color color)
        {
            this.equation = equation;
            this.color = color;
        }

        public override string ToString()
        {
            return equation;
        }

    }
}
