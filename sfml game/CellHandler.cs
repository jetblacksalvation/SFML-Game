using SFML.Window;
using SFML.Graphics;
using System;

namespace sfml_game
{
    class CellHandler
    {
        public delegate void Eventhandler(object sender, EventArgs args);
        CellHandler(RenderWindow Window)
        {
            CellsArray = new bool[Window.Size.X, Window.Size.Y];
            //events --------------
            Window.Closed += (sender, args) => Window.Close();

            Window.KeyPressed += (sender, args) =>
            {
                if (args.Code == Keyboard.Key.A)
                {
                    Console.WriteLine("A is pressed");
                }
                else if (args.Code == Keyboard.Key.D)
                {
                    Console.WriteLine("D is pressed");
                }
                else if (args.Code == Keyboard.Key.W)
                {
                    Console.WriteLine("W is pressed");
                }
                else if (args.Code == Keyboard.Key.S)
                {
                    Console.WriteLine("S is pressed");
                }
            };
        }
        private void SetCells()
        {
            

        }
        private RenderWindow Window;
        private bool[,] CellsArray;

    }
}
