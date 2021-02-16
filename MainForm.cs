using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Battles
{
    public partial class MainForm : Form
    {
        private readonly Player _player;
        private Point cursorClick;
        private List<Asteroid> Meteorites;

        private int _score;

        public MainForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
            _player = new Player();
            Meteorites = new List<Asteroid>();
            cursorClick = new Point();
            _score = 0;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            DrawAllAsteroids(e);
            _player.DrawHP(e);
            Scores.Text = _score.ToString();
            for (var i = 0; i < Meteorites.Count; i++)
            {
                if (Math.Abs(cursorClick.X - Meteorites[i].PositionAsteroid.X) <= 70 &&
                    Math.Abs(cursorClick.Y - Meteorites[i].PositionAsteroid.Y) <= 70)
                {
                    _score += 5 + Asteroid.Speed/2;
                    Meteorites.Remove(Meteorites[i]);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveAllAsteroids();
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Meteorites.Add(new Asteroid());
        }

        public void MoveAllAsteroids()
        {
            foreach (var meteorite in Meteorites)
                meteorite.MoveAsteroid();
        }

        public void DrawAllAsteroids(PaintEventArgs e)
        {
            for (var i = 0; i < Meteorites.Count; i++)
            {
                if (Meteorites[i].PositionAsteroid.Y >= 600 - Asteroid.Radius)
                {
                    Meteorites[i] = new Asteroid();
                    _player.Health--;
                    if (_player.Health < 1)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        RefreshClick.Stop();
                        this.Hide();
                        var general = new GeneralMenu();
                        general.Show();
                        MessageBox.Show("You Lose!!!");
                    }
                }
                Meteorites[i].DrawAsteroid(e);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            cursorClick = (e.Location);
        }

        private void RefreshClicks(object sender, EventArgs e)
        {
            cursorClick = new Point(-5, -5);
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var general = new GeneralMenu();
            general.Show();
        }

        private void GameAcceleration_Tick(object sender, EventArgs e)
        {
            Asteroid.Speed++;
        }
    }
}
