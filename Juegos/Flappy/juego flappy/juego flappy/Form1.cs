using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace juego_flappy
{
    public partial class frmjuegoflappy : Form
    {
        int ContadorMovimientos = 1;
        bool VolarArriba = false;
        int Distancia = 0;
        Random PosicionRandom = new Random();

        public frmjuegoflappy()
        {
            InitializeComponent();
            this.KeyPreview = true;
            IniciarJuego();

        }
        public void IniciarJuego()
        {
            player.Location = new Point (19, 225);
            Distancia = PosicionRandom.Next (-160, 118);
            tuboarriba.Location = new Point(270, -173 - Distancia);
            tuboabajo.Location = new Point(270, 319 - Distancia);
            puntaje.Text = "0";
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimientos = 10;
            if (ContadorMovimientos <= CantidadMovimientos)
            {
                player.Image = Properties.Resources.mop2;
                ContadorMovimientos++;
            }
            if((ContadorMovimientos > CantidadMovimientos / 2) && (ContadorMovimientos <= CantidadMovimientos * 2))
            {
                player.Image = Properties.Resources.mop3;
                ContadorMovimientos++;
            }

            ContadorMovimientos = (ContadorMovimientos > CantidadMovimientos * 2) ? 0 : ContadorMovimientos;

            int ly = player.Location.Y;
            int lx = player.Location.X;

            if (VolarArriba)
            {
                ly = ly - 15;
                VolarArriba = false;

            }
            else
            {
                ly++;
            }

            player.Location = new Point(player.Location.X, ly);


            if ((player.Bounds.IntersectsWith(piso.Bounds)) || ( player.Bounds.IntersectsWith(tuboarriba.Bounds)) || (player.Bounds.IntersectsWith(tuboabajo.Bounds)))
            {
                IniciarJuego();
            }
            puntaje.Location = new Point(player.Location.X + 30, player.Location.Y - 25);
            puntaje.Text = (tuboarriba.Location.X == player.Location.X) ? Convert .ToString((Convert.ToInt32(puntaje.Text)+1)).ToString() : puntaje.Text; 
        }

        private void frmjuegoflappy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                VolarArriba = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tuboabajo.Location.X > -140)
            {
                tuboabajo.Location = new Point((tuboabajo.Location.X) - 1, tuboabajo.Location.Y);
                tuboarriba.Location = new Point((tuboabajo.Location.X) - 1, tuboarriba.Location.Y);


            }
            else
            { 
                Distancia = PosicionRandom.Next (-170,118);
                tuboabajo.Location = new Point(400, 319 + Distancia);
                tuboarriba.Location = new Point(400, -173 + Distancia);

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            piso.Location = (piso.Location.X > -480) ? new Point((piso.Location.X) - 1, piso.Location.Y) : piso.Location = new Point(-9, piso.Location.Y);
        }

        private void frmjuegoflappy_Load(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
