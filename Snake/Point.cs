using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;
        // public int a;
        // public int b;
        // public char c;

        public Point() {
            // Console.WriteLine("Создается новая точка");

        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // public Point(int _a, int _b, char _c)
        // {
        //     a = _a;
        //     b = _b;
        //     c = _c;
        // }

        public void Draw(){
            Console.Write("\n");
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        // public void DrawPoint()
        // {
        //     Console.SetCursorPosition(a, b);
        //     Console.Write(c);
        // }




    }

    
}