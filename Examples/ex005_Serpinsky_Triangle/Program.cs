﻿//построение треугольника Серпинского

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

Console.SetCursorPosition (xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition (xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition (xc, yc);
Console.WriteLine("+");

int count = 0;

int x = xa;
int y = yb;

while (count <10000) 
{
    int what = new Random().Next(0,3); 
    if (what == 0) 
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
        Console.SetCursorPosition (x, y);
        Console.WriteLine("+");
    }
      if (what == 1) 
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
        Console.SetCursorPosition (x, y);
        Console.WriteLine("+");
    }
    if (what == 2) 
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
        Console.SetCursorPosition (x, y);
        Console.WriteLine("+");
    }
    count ++;
}