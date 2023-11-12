using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello, World!");
      // Console.ReadLine();
      // int x1 = 1;
      // int y1 = 3;
      // char sym1 = '*';
      // Draw(x1, y1, sym1);

      // Point p1 = new Point();
      // p1.x = 1;
      // p1.y = 3;
      // p1.sym = '*';
      // Draw(p1.x, p1.y, p1.sym);
      Point p1 = new Point(1, 3, '*');
      p1.Draw();

      // int x2 = 4;
      // int y2 = 5;
      // char sym2 = '#';
      // // Console.SetCursorPosition(x2, y2);
      // // Console.Write(sym2);
      // // Console.ReadLine();
      // Draw(x2, y2, sym2);

      // Point p2 = new Point();
      // p2.x = 4;
      // p2.y = 5;
      // p2.sym = '#';
      // Draw(p2.x, p2.y, p2.sym);
      Point p2 = new Point(4, 5, '#');
      p2.Draw();

      // int x3 = 7;
      // int y3 = 8;
      // char sym3 = '*';
      // Draw(x3, y3, sym3);

      // Point p3 = new Point();
      // p3.x = 7;
      // p3.y = 8;
      // p3.sym = '*';
      // Draw(p3.x, p3.y, p3.sym);
      Point p3 = new Point(7, 8, '*');
      p3.Draw();



      // static void Draw(int x, int y, char sym)
      // {
      //   Console.SetCursorPosition(x, y);
      //   Console.Write(sym);
      // };
    }
}
}