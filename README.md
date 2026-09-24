# Game-10033-Assigment-2-nick// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

// Your game code goes inside this class!
public class Game
{
    // Setup runs once before the game loop begins.
    public void Setup()
    {
        Window.SetTitle("Draw Simple Shapes");
        Window.SetSize(400, 400);
    }

    // Update runs every frame.
    public void Update()
    {
        // Clear background to offwhite color
        Window.ClearBackground(240);

        // Yellow circle, purple outline
        Draw.SetFillColor(255, 255, 0);
        Draw.SetLineColor(64, 0, 128);
        Draw.SetLineSize(10);
        Draw.Circle(200, 200, 100);

        // Semi-transparent red rectangle, no outline
        Draw.SetFillColor(255, 32, 0, 128);
        Draw.SetLineSize(0);
        Draw.Rectangle(10, 200, 190, 190);

        // Black line, 1px thick
        Draw.SetLineColor(0);
        Draw.SetLineSize(1);
        Draw.Line(0, 400, 400, 0);
    }
}