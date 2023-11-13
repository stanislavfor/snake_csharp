using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {

        protected List<Point> pList = new List<Point>();
        public void Drow()        
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}