using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace snakewpf
{
    class Comida
    {
        Rectangle rect = new Rectangle();
        int x, y;
        public Comida(Canvas c)
        {
            this.x = generar(94);
            this.y = generar(41);
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromArgb(255, 255, 0, 0);
            rect.Fill = color;
            rect.Width = MainWindow.espacio;
            rect.Height = MainWindow.espacio;
            c.Children.Add(rect);
            Canvas.SetTop(rect, this.y);
            Canvas.SetLeft(rect, this.x);
            Console.WriteLine(this.x + "--" + this.y);
        }
        public void colocar()
        {
            this.x = generar(94);
            this.y = generar(41);
            Canvas.SetTop(rect, y);
            Canvas.SetLeft(rect, x);
            Console.WriteLine(this.x + "--" + this.y);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
    }
}
