Console.Clear();
//Console.SetCursorPosition(1,30);
//Console.WriteLine("+");
int xa=175, ya=1,
    xb=1, yb=100,
    xc=350, yc=100;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa ,
    y = ya ,
    count = 0;

while (count<100000)
{
    
    int wtf = new Random().Next(0,3);
    if (wtf == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (wtf == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (wtf == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}