using System;

namespace Mars_Rover
{
    public class SpaceCar
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Route Position { get; set; }

        //public enum Position { N, E, S, W };

        public SpaceCar(int x, int y, Route position)
        {
            this.X = x;
            this.Y = y;
            this.Position = position;
        }

        public void Move(string command)
        { 
            foreach (char item in command)
            {
                if (item == 'M')
                    Position.Move(this);
                else
                    Position.Change(this, item);
            }
        }

        public void GetCarLocation()
        {
            Console.WriteLine(X + " " + Y + " " + Position.GetType().Name);
        }
    }

    //abstract

    public abstract class Route
    {
        public abstract void Change(SpaceCar spaceCar, char route);
        public abstract void Move(SpaceCar spaceCar);
    }

    public class N : Route
    {
        public override void Change(SpaceCar spaceCar, char route)
        {
            if (route == 'L')
                spaceCar.Position = new W();
            else
                spaceCar.Position = new E();
        }

        public override void Move(SpaceCar spaceCar)
        {
            spaceCar.Y += 1;
        }
    }

    public class E : Route
    {
        public override void Change(SpaceCar spaceCar, char route)
        {
            if (route == 'L')
                spaceCar.Position = new N();
            else
                spaceCar.Position = new S();

        }

        public override void Move(SpaceCar spaceCar)
        {
            spaceCar.X += 1;
        }
    }

    public class S : Route
    {
        public override void Change(SpaceCar spaceCar, char route)
        {
            if (route == 'L')
                spaceCar.Position = new E();
            else
                spaceCar.Position = new W();
        }

        public override void Move(SpaceCar spaceCar)
        {
            spaceCar.Y -= 1;
        }
    }

    public class W : Route
    {
        public override void Change(SpaceCar spaceCar, char route)
        {
            if (route == 'L')
                spaceCar.Position = new S();
            else
                spaceCar.Position = new N();
        }

        public override void Move(SpaceCar spaceCar)
        {
            spaceCar.X -= 1;
        }
    }

}
