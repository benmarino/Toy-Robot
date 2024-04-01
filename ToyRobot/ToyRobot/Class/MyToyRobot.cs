using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Class
{
      class MyToyRobot
    {
        public string Facing { get; set; }
        
        public int X { get; set; }
        public int Y { get; set; }

        public bool Place(int x,int y,string sFacing)
        {
            
            if (x>5 || y>5) return false;
            if (x<0 || y<0) return false;
            X = x;
            Y = y;
            Facing = sFacing;
            return true;
        }
        public bool Move()
        {
            if (Facing == "NORTH")
            {
                if (Y == 5)
                return false;
                else
                {
                    Y = Y + 1;
                    return true;
                }
            }
            else if(Facing == "EAST") { 
                if (X == 5)
                    return false;
                else
                {
                    X = X + 1;
                    return true;
                }
            }
            else if (Facing == "WEST")
            {
                if (X==0)
                    return false;
                else
                {
                    X = X - 1; return true;
                }
            }
            else if (Facing == "SOUTH")
            {
                if (Y==0) return false;
                else
                {
                    Y=Y-1; return true;
                }
            }
            return false;
        }
        public bool Left()
        {
            if (Facing == "NORTH")
            {
                Facing = "WEST";
                return true;
            }
            if (Facing == "WEST")
            {
                Facing = "SOUTH";
                return true;
            }
            if (Facing == "SOUTH")
            {
                Facing = "EAST";
                return true;
            }
            if (Facing == "EAST")
            {
                Facing = "NORTH";
                return true;
            }
            else
            return false;
        }
        public bool Right()
        {
            if (Facing == "NORTH")
            {
                Facing = "EAST";
                return true;
            }
            if (Facing == "WEST")
            {
                Facing = "NORTH";
                return true;
            }
            if (Facing == "SOUTH")
            {
                Facing = "WEST";
                return true;
            }
            if (Facing == "EAST")
            {
                Facing = "SOUTH";
                return true;
            }
            else
                return false;
        }
        public string Report()
        {
            return " " + X.ToString() + " " + Y.ToString() + " " + Facing.ToString();
        }

    }
}
