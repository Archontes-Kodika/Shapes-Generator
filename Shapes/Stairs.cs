namespace Shapes{
    public class Stairs : Shape
    {
        public Stairs() : base()
        {
            Name = "Stairs";
        }

        public override string Draw()
        {

            int x = 0;
            int y = 0;
            string drawing = "";

            while (x < 10)
            {
                x = x + 1;
                Console.WriteLine(drawing);

                while (y < 10)
                {
                    y = y + 1;
                    Console.Writeline(drawing);
                }


            }








        }
    }
}


//**********
//         *
//         **********
//                  *
//                  **********
//                           *
//                            **********
//                                     *
//                                     **********
//                                              *
//                                              **********
//                                                       *
//                                                       **********
//                                                                *