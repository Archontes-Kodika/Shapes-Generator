using System;

namespace Shapes
{
    // public class Dog : Animal
    public class Square : Shape
    {
        public Square() : base()
        {
            Name = "Square";
        }

        public override string Draw()
        {
            string drawing = "";

            int numberx = 0;
            int numbery = 0;
            // -> Dimension 0

            while (numbery < 4)
            {
                // -> Dimension 1 (y)
                numbery = numbery + 1;
                // numbery++;
                // numbery += 1;

                while (numberx < 10)
                {
                    // -> Dimension 2 (x)
                    numberx = numberx + 1;
                    drawing += ch;
                }

                if (numberx == 10) // tautologia -> siempre es cierto
                {
                    numberx = numberx - 10;
                    drawing += Environment.NewLine;
                }
            }

            return drawing;
        }
    }
}