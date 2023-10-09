using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace JuegoCoches
{
    public partial class Form1 : Form
    {
        List<PictureBox> ListaObstaculos = new List<PictureBox>();
        Random RnObstaculo = new Random();
        
        int velocidad = 3;
        //int aceleracioCarro = 0;

        public Form1()
        {
            InitializeComponent();
            CrearObstaculo(ListaObstaculos, this, 10, 120);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /*pcCarro.Image = (aceleracioCarro == 0) ? Properties.Resources.Carro : Properties.Resources.Carro;
            *aceleracioCarro = (aceleracioCarro == 0) ? 1 : 0;*/
        }
        public void CrearObstaculo(List<PictureBox>ListaElementos, Form panelJuego,int distanciaUno, int distanciaDos)
        {
            int NumeroCarro = 1;
            int TipoObtaculo = RnObstaculo.Next(1, 2);
            int UbicacionObstaculo = RnObstaculo.Next(1, 3);

            int DistanciaUbicacionObstaculo = (UbicacionObstaculo == 1) ? distanciaUno : distanciaDos;

            PictureBox prueba = new PictureBox();
            prueba.Location = new Point(DistanciaUbicacionObstaculo, 0);
            prueba.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Obstaculo" + NumeroCarro + TipoObtaculo);
            prueba.BackColor = Color.Transparent;
            prueba.Tag = NumeroCarro + "_" + TipoObtaculo;
            prueba.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaElementos.Add(prueba);
            panelJuego.Controls.Add(prueba);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaObstaculos.Add(Obstaculo);
            ListaObstaculos.Add(Obstaculo1);           
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int moviendoCarro = (pcCarro.Location.X == 120) ? 10 : 120;
            pcCarro.Location = new Point(moviendoCarro, pcCarro.Location.Y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox ImagenCarro in ListaObstaculos)
            {
                int movimientoY;
                movimientoY = ImagenCarro.Location.Y;
                movimientoY = movimientoY + velocidad;
                ImagenCarro.Location = new Point(ImagenCarro.Location.X, movimientoY);
            }

            if (ListaObstaculos.Count>0)
            {
                if (ListaObstaculos[(ListaObstaculos.Count)-1].Location.Y>350)
                {
                    CrearObstaculo(ListaObstaculos, this, 10, 120);
                }
            }

            if (ListaObstaculos.Count>0)
            {
                for (int i = 0; i < ListaObstaculos.Count; i++)
                {
                    if (ListaObstaculos[i].Location.Y>500)
                    {
                        if (ListaObstaculos[i].Tag.ToString()=="1_1")
                        {
                            ReiniciarJuego();
                        }
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);
                    }
                    if (ListaObstaculos[i].Bounds.IntersectsWith(pcCarro.Bounds))
                    {
                        if (ListaObstaculos[i].Tag.ToString()=="1_1")
                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            int totalPoints = Convert.ToInt32(lblPoints.Text) + 1;
                            if (totalPoints%2==0)
                            {
                                velocidad++;
                            }
                            lblPoints.Text = totalPoints.ToString();

                            ListaObstaculos.Remove(ListaObstaculos[i]);
                        }
                        else
                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            ListaObstaculos.Remove(ListaObstaculos[i]);
                            ReiniciarJuego();
                        }
                    }
                }
            }
        }
        public void ReiniciarJuego()
        {
            lblPoints.Text = "0";
            velocidad = 3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
