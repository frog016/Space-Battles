using System.Drawing;
using System.Windows.Forms;

namespace Space_Battles
{
    class Player
    {
        public int Health { get; set; }
        readonly Bitmap SkinHP = Resource.HP;

        public Player()
        {
            Health = 3;
        }

        public void DrawHP(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            for(var i = 0; i < Health; i++)
            {
                var HPRect = new Rectangle(10 + 10*i, 10, 20, 20);
                graphics.DrawImage(SkinHP, HPRect);
            }
        }
    }

}
