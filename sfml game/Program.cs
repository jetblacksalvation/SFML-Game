using System;

using SFML.System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace sfml_game
{
    class Program
    {
        enum DIRECTIONS
        {
            UP, DOWN, LEFT, RIGHT
        };
        static bool[] keys;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            keys = new bool[4] { false, false, false, false };

            VideoMode mode = new VideoMode(800, 800);
            RenderWindow window = new RenderWindow(mode, "Window");
            window.Closed += (sender, args) => window.Close();
            RectangleShape shape = new RectangleShape(new Vector2f(1, 1));
            //shape.Size = new Vector2f(102, 234);

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Blue);
                window.Draw(shape);

                window.Display();
            }   


        }

        public void keyHandler()
        {
            keys[(int)(DIRECTIONS.UP)] = Keyboard.IsKeyPressed(Keyboard.Key.A);
            keys[(int)(DIRECTIONS.DOWN)] = Keyboard.IsKeyPressed(Keyboard.Key.S);
            keys[(int)(DIRECTIONS.RIGHT)] = Keyboard.IsKeyPressed(Keyboard.Key.D);
            keys[(int)(DIRECTIONS.LEFT)] = Keyboard.IsKeyPressed(Keyboard.Key.D);
            bool isMove = keys[(int)(DIRECTIONS.LEFT)] || keys[(int)(DIRECTIONS.RIGHT)] || keys[(int)(DIRECTIONS.DOWN)] || keys[(int)(DIRECTIONS.UP)];

        }
    }
}
