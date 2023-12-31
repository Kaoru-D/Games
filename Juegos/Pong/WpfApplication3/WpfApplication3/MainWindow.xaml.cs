﻿using System;
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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bola bola ;
        Paleta jug1, jug2;
        DispatcherTimer dp;
        int pj1 = 0, pj2 = 0;
        public MainWindow()
        {
            InitializeComponent();
            dp = new DispatcherTimer();
            dp.Interval = new TimeSpan(0,0,0,0,25);
            dp.Tick += new EventHandler(dp_tick);
            bola = new Bola(canvas);
            jug1 = new Paleta(canvas, 15);
            jug2 = new Paleta(canvas, 679);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Down)
            {
                jug1.bajar();
            }
            if(e.Key == Key.Up)
            {
                jug1.subir();
            }
            if(e.Key == Key.W)
            {
                jug2.subir();
            }
            if(e.Key == Key.S)
            {
                jug2.bajar();
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                jug1.parar();
            }
            if (e.Key == Key.Up)
            {
                jug1.parar();
            }
            if (e.Key == Key.W)
            {
                jug2.parar();
            }
            if (e.Key == Key.S)
            {
                jug2.parar();
            }

        }

        public void dp_tick(object sender, EventArgs e)
        {
            bola.movimiento();
            jug1.movimiento();
            jug2.movimiento();
            if(bola.x <= 0)
            {
                bola.rebotex();
                pj2++;
                j2.Content = pj2;
            }
            if(bola.x >= 694)
            {
                bola.rebotex();
                pj1++;
                j1.Content = pj1;

            }
            if(bola.y <= 0 || bola.y >= 276)
            {
                bola.rebotey();
            }

            if (bola.x <= (jug1.x + jug1.w) && bola.y >= jug1.y && bola.y <= (jug1.y + jug1.h))
            {
                bola.rebotex();
            }
            if ((bola.x + bola.t) >= jug2.x && bola.y >= jug2.y && bola.y <= (jug2.y + jug2.h))
            {
                bola.rebotex();
            }

        }

        private void playpause_Click(object sender, RoutedEventArgs e)
        {
            if (dp.IsEnabled)
            {
                dp.IsEnabled = false;
                playpause.Content = "Continuar";

            } else
            {
                dp.IsEnabled = true;
                playpause.Content = "Pausar";
            }
        }
    }
}
