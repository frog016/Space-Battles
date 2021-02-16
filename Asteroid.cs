using System;
using System.Drawing;
using System.Windows.Forms;

namespace Space_Battles
{
    public class Asteroid
    {
        readonly Bitmap Skin = Resource.Meteorite;
        public Point PositionAsteroid { get; set; }


        public static int Speed { get; set; }
        public static int Radius { get; private set; }

        static Asteroid()
        {
            Speed = 2;
        }

        public Asteroid()
        {
            var rnd = new Random();
            Radius = 40;
            PositionAsteroid = new Point(rnd.Next(2*Radius, 801 - 2*Radius), -2*Radius);
        }

        public void DrawAsteroid(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var meteoriteRect = new Rectangle(this.PositionAsteroid.X, this.PositionAsteroid.Y, 2 * Radius, 2 * Radius);
            graphics.DrawImage(Skin, meteoriteRect);
        }

        public void MoveAsteroid()
        {
            PositionAsteroid = new Point(this.PositionAsteroid.X, this.PositionAsteroid.Y + Speed);
        }
    }
}
