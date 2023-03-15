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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            keys = new bool[4] { false, false, false, false };

            VideoMode mode = new VideoMode(800, 800);
            RenderWindow window = new RenderWindow(mode, "Window");


            //KeyEvent keyEvent += Keyboard.IsKeyPressed(Keyboard.Key.A) => window.Close();
            //window.KeyPressed += OnKeyPressed() => Console.WriteLine("hello");

            RectangleShape shape = new RectangleShape(new Vector2f(1, 1));

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Blue);
                window.Draw(shape);

                window.Display();
            }   


        }

        private static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
