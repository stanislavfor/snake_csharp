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
     
      Point p1 = new Point(1, 3, '*');
      p1.Draw();
      
      Point p2 = new Point(4, 5, '*');
      p2.Draw();
      
      Point p3 = new Point(7, 8, '*');
      p3.Draw();


      List<int> numList = new List<int>();
      numList.Add(0);
      numList.Add(1);
      numList.Add(2);
      numList.Add(3);
      numList.Add(4);

      // int x = numList[0];
      // int y = numList[1];
      // int z = numList[2];
      // numList.RemoveAt(0);
      // foreach (int i in numList)
      // {
      //   Console.Write("\n");
      //   Console.Write(i);
      // }

      foreach (int i in numList)
      {
        Console.Write("\n");
        Console.Write(i);
      }
      

      List<Point> pList = new List<Point>();
      pList.Add(p1);
      pList.Add(p2);
      pList.Add(p3);

      foreach (Point p in pList)
      {
        Console.Write("\n");
        p.Draw();
      }

      List<char> charList = new List<char>();
      charList.Add('#');
      charList.Add('@');
      charList.Add('+');

      foreach (char item in charList)
      {
        Console.Write("\n");
        Console.WriteLine(item);
      }


      Point point1 = new Point(numList[0], numList[0], charList[0]);
      Point point2 = new Point(numList[0], numList[1], charList[0]);
      Point point3 = new Point(numList[0], numList[2], charList[0]);
      Point point4 = new Point(numList[1], numList[0], charList[1]);
      Point point5 = new Point(numList[1], numList[1], charList[1]);
      Point point6 = new Point(numList[1], numList[2], charList[1]);
      Point point7 = new Point(numList[2], numList[0], charList[2]);

      List<Point> pointList = new List<Point>();
      pointList.Add(point1);
      pointList.Add(point2);
      pointList.Add(point3);
      pointList.Add(point4);
      pointList.Add(point5);
      pointList.Add(point6);
      pointList.Add(point7);

      foreach (Point point in pointList)
      {
        // Console.Write("\nPoint point in pointList");
        point.Draw();
      }

      Console.ReadLine();

    }

    
  }
}