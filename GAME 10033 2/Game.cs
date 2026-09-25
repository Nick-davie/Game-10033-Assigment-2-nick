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


            Draw.Line(280, 0, 280, 400);
            Draw.Line(140, 0, 140, 400);
            Draw.Line(400, 280, 0, 280);
            Draw.Line(400, 140, 0, 140);

            // Draw a circle at mouse position
            // Circle is green with black outline
            Draw.SetFillColor(0, 255, 0);
            Draw.SetLineColor(0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

        }
    }
}