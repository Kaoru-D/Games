using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace snakewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dp = new DispatcherTimer();
        public static readonly int espacio = 10;
        Cola cabeza;
        Comida comida;

        int xdir = 0, ydir = 0;
        Boolean ejex = true, ejey = true;
        int puntos = 0;
        public MainWindow()
        {
            dp.Interval = new TimeSpan(0, 0, 0, 0, 50);
            dp.IsEnabled = true;
            dp.Tick += new EventHandler(dp_tick);
            InitializeComponent();
            cabeza = new Cola(10, 10, canvas);
            comida = new Comida(canvas);
            bordeCanvas.BorderThickness = new Thickness(1);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if(e.Key == Key.Left)
                {
                    ydir = 0;
                    xdir = -espacio;
                    ejex = false;
                    ejey = true;
                }
                if(e.Key == Key.Right)
                {
                    ydir = 0;
                    xdir = espacio;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if(e.Key == Key.Up)
                {
                    xdir = 0;
                    ydir = -espacio;
                    ejey = false;
                    ejex = true;
                }
                if(e.Key == Key.Down)
                {
                    xdir = 0;
                    ydir = espacio;
                    ejey = false;
                    ejex = true;
                }
            }
        }
        public void findeJuego()
        {
            xdir = 0;
            ydir = 0;
            ejex = true;
            ejey = true;
            puntos = 0;
            puntaje.Content = "0";
            canvas.Children.RemoveRange(0, canvas.Children.Capacity);
            cabeza = new Cola(10, 10, canvas);
            comida = new Comida(canvas);
            MessageBox.Show("Perdiste");
        }

        public void choquePared()
        {
            if(cabeza.getX() < 0 || cabeza.getY() < 0 || cabeza.getX() > 940 || cabeza.getY() > 420)
            {
                findeJuego();
            }
        }
        public void choquecuerpo()
        {
            Cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }catch(Exception e)
            {
                temp = null;
            }
            while(temp != null)
            {
                if (cabeza.choque(temp))
                {
                    findeJuego();
                    break;
                } else
                {
                    temp = temp.verSiguiente();
                }
            }
        }

        private void playpause_Click(object sender, RoutedEventArgs e)
        {
            if (dp.IsEnabled)
            {
                playpause.Content = "Reanudar";
                dp.IsEnabled = false;
            } else
            {
                playpause.Content = "Pausar";
                dp.IsEnabled = true;
            }
        }

        public void movimiento()
        {
            cabeza.setxy(cabeza.getX() + xdir, cabeza.getY() + ydir);
        }
        public void dp_tick(object sender, EventArgs e)
        {
            movimiento();
            choquecuerpo();
            choquePared();
            if (cabeza.comer(comida))
            {
                comida.colocar();
                cabeza.meter(canvas);
                puntos++;
                puntaje.Content = puntos.ToString();
            }
        }
    }
}
