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

        public void Draw(){
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        
    }

    
}