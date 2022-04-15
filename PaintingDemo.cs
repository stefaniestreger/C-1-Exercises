using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class roomDemo
{
  static void Main()
  {
    Room[] room = new Room[8];
    int len = 3;
    int wid = 3;
    int high = 3;
    for (int x = 0; x < room.Length; ++x)
    {
      room[x] = new Room(len, wid, high);
      len += 2;
      wid += 1;
      if (x % 2 == 1) {
        high += 1;
      }
    }

    for (int x = 0; x < room.Length; ++x) 
    {
      WriteLine("Area = {0}, Paint = {1} gallon(s).", room[x].Area, room[x].Gallons);
     }
  }
}

class Room
{
    private int length, width, height, area, gallons;
    
    public Room(int len, int wid, int high)
    {
        length = len;
        width = wid;
        height = high;
        CalcArea();
        CalcGallons();
    }
    public int Length
    {
        get
        {
            return length;
        }
    }
    public int Width
    {
        get
        {
            return width;
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
    }
    public int Area
    {
        get
        {
            return area;
        }
    }
    public int Gallons
    {
        get
        {
            return gallons;
        }
    }
    private void CalcArea()
    {
       area = (2 * (length + width)) * height;
    }
    private void CalcGallons()
    {
        if (Area <= 350) {
          gallons = 1;
        }
        if (Area > 350 && Area <= 706) {
          gallons = 2;
        }
        if (Area > 706 && Area <=1056) {
          gallons = 3;
        }
    }
}

