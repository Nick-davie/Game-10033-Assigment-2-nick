// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.ComponentModel.Design;
using System.Net;
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
            if (Input.GetMouseY() < 130 && Input.GetMouseX() < 130)
            {
                // box 1
                Window.ClearBackground(255, 100, 100);
            }
            else if (Input.GetMouseY() < 130 && Input.GetMouseX() < 260)
            {
                // box 2
                Window.ClearBackground(255, 150, 100);

            }
            else if (Input.GetMouseY() < 130 && Input.GetMouseX() < 400)
            {
                // box 3
                Window.ClearBackground(255, 255, 100);
            }

            else if (Input.GetMouseY() < 260 && Input.GetMouseX() < 130)
            {
                // box 4
                Window.ClearBackground(255, 200, 255);
            }
            else if (Input.GetMouseY() < 260 && Input.GetMouseX() < 260)
            {
                // box 5
                Window.ClearBackground(255, 255, 255);
            }
            else if (Input.GetMouseY() < 260 && Input.GetMouseX() < 400)
            {
                // box 6
                Window.ClearBackground(100, 255, 100);
            }
            else if (Input.GetMouseY() < 400 && Input.GetMouseX() < 130)
            {
                // box 7
                Window.ClearBackground(255, 100, 255);
            }
            else if (Input.GetMouseY() < 400 && Input.GetMouseX() < 260)
            {
                // box 8
                Window.ClearBackground(100, 100, 255);
            }
            else if (Input.GetMouseY() < 400 && Input.GetMouseX() < 400)
            {
                // box 9
                Window.ClearBackground(200, 200, 255);
            }
            else
            {
                // Off-white
                Window.ClearBackground(240);
            }

            // Clear previous image with off-white color
            //Window.ClearBackground(240);

            Draw.Line(260, 0, 260, 400);
            Draw.Line(130, 0, 130, 400);
            Draw.Line(400, 260, 0, 260);
            Draw.Line(400, 130, 0, 130);



            if (Input.IsKeyboardKeyDown(KeyboardKey.One) == true)
            {
                Draw.SetFillColor(255, 0, 0);
                Draw.SetLineSize(0);
                Draw.Capsule(40, 50, 40, 50, 22);
                Draw.Capsule(80, 50, 80, 50, 22);
                Draw.Triangle(60, 110, 20, 60, 100, 60);
                Draw.SetLineSize(1);

            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Two) == true)
            {
                Draw.SetFillColor(255, 150, 0);
                Draw.SetLineSize(0);
                Draw.Capsule(170, 50, 170, 50, 22);
                Draw.Capsule(210, 50, 210, 50, 22);
                Draw.Triangle(190, 110, 150, 60, 230, 60);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Three) == true)
            {
                Draw.SetFillColor(255, 255, 0);
                Draw.SetLineSize(0);
                Draw.Capsule(310, 50, 310, 50, 22);
                Draw.Capsule(350, 50, 350, 50, 22);
                Draw.Triangle(330, 110, 290, 60, 370, 60);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Four) == true)
            {
                Draw.SetFillColor(255, 100, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(40, 180, 40, 180, 22);
                Draw.Capsule(80, 180, 80, 180, 22);
                Draw.Triangle(60, 240, 20, 190, 100, 190);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Zero) == true)
            {
                //chnage to be upside down
                Draw.SetFillColor(255, 255, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(170, 180, 170, 180, 22);
                Draw.Capsule(210, 180, 210, 180, 22);
                Draw.Triangle(190, 240, 150, 190, 230, 190);
                Draw.SetLineSize(1);


            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Five) == true)
            {
                //chnage to be upside down
                Draw.SetFillColor(255, 255, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(170, 220, 170, 220, 22);
                Draw.Capsule(210, 220, 210, 220, 22);
                Draw.Triangle(190, 160, 150, 210, 230, 210);
                Draw.SetLineSize(1);
            }

            else if (Input.IsKeyboardKeyDown(KeyboardKey.Six) == true)
            {
                Draw.SetFillColor(0, 255, 0);
                Draw.SetLineSize(0);
                Draw.Capsule(310, 180, 310, 180, 22);
                Draw.Capsule(350, 180, 350, 180, 22);
                Draw.Triangle(330, 240, 290, 190, 370, 190);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Seven) == true)
            {
                Draw.SetFillColor(255, 0, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(40, 310, 40, 310, 22);
                Draw.Capsule(80, 310, 80, 310, 22);
                Draw.Triangle(60, 370, 20, 320, 100, 320);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Eight) == true)
            {
                Draw.SetFillColor(0, 0, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(170, 310, 170, 310, 22);
                Draw.Capsule(210, 310, 210, 310, 22);
                Draw.Triangle(190, 370, 150, 320, 230, 320);
                Draw.SetLineSize(1);
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Nine) == true)
            {
                Draw.SetFillColor(0, 255, 255);
                Draw.SetLineSize(0);
                Draw.Capsule(310, 310, 310, 310, 22);
                Draw.Capsule(350, 310, 350, 310, 22);
                Draw.Triangle(330, 370, 290, 320, 370, 320);
                Draw.SetLineSize(1);
            }

            // Draw a circle at mouse position
            Draw.SetFillColor(0, 0, 0);
            Draw.SetLineColor(0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

        }

        //old code
        // square 1 filled
        // Draw.SetFillColor(255, 100, 100);
        // Draw.Quad(0, 0, 130, 0, 130, 130, 0, 130);
        // square 2 filled
        // Draw.SetFillColor(255, 150, 100);
        // Draw.Quad(260, 0, 260, 130, 130, 130, 130, 0);
        // square 3 filled
        //  Draw.SetFillColor(255, 255, 100);
        //  Draw.Quad(260, 0, 400, 0, 400, 130, 260, 130);
        // square 4 filled
        //  Draw.SetFillColor(255, 200, 255);
        //  Draw.Quad(0, 130, 130, 130, 130, 260, 0, 260);
        // square 5 filled
        //  Draw.SetFillColor(255, 255, 255);
        // Draw.Quad(260, 130, 260, 260, 130, 260, 130, 130);
        // square 6 filled
        // Draw.SetFillColor(100, 255, 100);
        // Draw.Quad(400, 130, 400, 260, 260, 260, 260, 130);
        // square 7 filled
        // Draw.SetFillColor(255, 100, 255);
        //  Draw.Quad(0, 260, 130, 260, 130, 400, 0, 400);
        // square 8 filled
        //  Draw.SetFillColor(100, 100, 255);
        //  Draw.Quad(130, 260, 260, 260, 260, 400, 130, 400);
        // square 9 filled
        //  Draw.SetFillColor(200, 200, 255);
        //  Draw.Quad(260, 260, 260, 400, 400, 400, 400, 260);

    }
}