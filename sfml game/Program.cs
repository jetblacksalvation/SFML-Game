using System;

using SFML.System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace sfml_game
{
    class Program
    {
        static bool[] keys;
        static VideoMode mode = new VideoMode(800, 800);
        static RenderWindow window = new RenderWindow(mode, "Window");

        static RectangleShape shape = new RectangleShape(new Vector2f(10, 10));
        static bool[,] CellGrid = new bool[800,800];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            window.KeyPressed += (args, eve) => 
            {
                if (eve.Code == Keyboard.Key.Escape)
                {
                    window.Close();
                }

            };
            //window.KeyPressed += OnKeyPressed() => Console.WriteLine("hello");



            shape.FillColor = Color.Black;
            shape.OutlineThickness = 1;
            shape.OutlineColor = Color.White;

            bool[,] CellGrid = new bool[800,800];


            while (window.IsOpen)
            {
                PositionChecker();
                window.Display();

                window.Clear();
               
            }   


        }
        static private void PositionChecker()
        {
            for (int x = 0; x < 800; x += 10)
            {
                for (int y = 0; y < 800; y += 10)
                {
                    if (CellGrid[x, y])
                    {
                        if ((x > 0 && x<800) && (y>0 && y<800))
                        {
                            //must have a neighbor left or right
                        }

                    }
                        shape.Position = new(x, y);
                    window.Draw(shape);

                }
            }
        }

    }
}
