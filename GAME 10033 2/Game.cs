// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("test");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear previous image with off-white color
            Window.ClearBackground(240);


            Draw.Line(260, 0, 260, 400);
            Draw.Line(130, 0, 130, 400);
            Draw.Line(400, 260, 0, 260);
            Draw.Line(400, 130, 0, 130);

            // square 1 filled
            Draw.SetFillColor(255, 100, 100);
            Draw.Quad(0, 0, 130, 0, 130, 130, 0, 130);

            // square 2 filled
            Draw.SetFillColor(255, 150, 100);
            Draw.Quad(260, 0, 260, 130, 130, 130, 130, 0);

            // square 3 filled
            Draw.SetFillColor(255, 255, 100);
            Draw.Quad(260, 0, 400, 0, 400, 130, 260, 130);

            // square 4 filled
            Draw.SetFillColor(255, 200, 255);
            Draw.Quad(0, 130, 130, 130, 130, 260, 0, 260);

            // square 5 filled
            Draw.SetFillColor(255, 255, 255);
            Draw.Quad(260, 130, 260, 260, 130, 260, 130, 130);

            // square 6 filled
            Draw.SetFillColor(100, 255, 100);
            Draw.Quad(400, 130, 400, 260, 260, 260, 260, 130);

            // square 7 filled
            Draw.SetFillColor(255, 100, 255);
            Draw.Quad(0, 260, 130, 260, 130, 400, 0, 400);

            // square 8 filled
            Draw.SetFillColor(100, 100, 255);
            Draw.Quad(130, 260, 260, 260, 260, 400, 130, 400);


            // square 9 filled
            Draw.SetFillColor(200, 200, 255);
            Draw.Quad(260, 260, 260, 400, 400, 400, 400, 260);





            // Draw a circle at mouse position
            // Circle is green with black outline
            Draw.SetFillColor(0, 255, 0);
            Draw.SetLineColor(0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

        }
    }
}