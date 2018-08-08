using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flap
{
    public partial class Form1 : Form
    {
        int contadorMovimientos = 1;
        bool volarArriba = false;
        int distancia = 0;
        Random posicionRandom = new Random();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public void IniciarJuego()
        {
            player.Location = new Point(19, 225);
            distancia = posicionRandom.Next(-160, 118);
            tuboArriba.Location = new Point(270, -173 - distancia);
            tuboAbajo.Location = new Point(270, 319 - distancia);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int cantidadMovimientos = 5;
            if (contadorMovimientos <= cantidadMovimientos)
            {
                player.Image = Properties.Resources.flappy;
                contadorMovimientos++;
            }
            if((contadorMovimientos > cantidadMovimientos /2)&&(contadorMovimientos <= cantidadMovimientos *2))
            {
                player.Image = Properties.Resources.flappy;
                contadorMovimientos++;
            }
            contadorMovimientos = (contadorMovimientos > cantidadMovimientos * 2) ? 0 : contadorMovimientos;
            int ly = player.Location.Y;
            int lx = player.Location.X;

            if(volarArriba)
            {
                ly = ly - 15;
                volarArriba = false;
            }
            else
            {
                ly++;
            }
            player.Location = new Point(player.Location.X, ly);
            if(player.Bounds.IntersectsWith(tuboAbajo.Bounds)|| player.Bounds.IntersectsWith(tuboArriba.Bounds))
            {
                IniciarJuego();
            }
            puntaje.Location = new Point(player.Location.X + 30, player.Location.Y - 25);
            puntaje.Text = (tuboArriba.Location.X == player.Location.X) ? Convert.ToString((Convert.ToInt32(puntaje.Text) + 1)).ToString() : puntaje.Text;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Space))
                volarArriba = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(tuboAbajo.Location.X > -140)
            {
                tuboAbajo.Location = new Point((tuboAbajo.Location.X) - 1, tuboAbajo.Location.Y);
                tuboArriba.Location = new Point((tuboArriba.Location.X) - 1, tuboArriba.Location.Y);
            }
            else
            {
                distancia = posicionRandom.Next(-170, 118);
                tuboAbajo.Location = new Point(400, 319 + distancia);
                tuboArriba.Location = new Point(400, -173 + distancia);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}
