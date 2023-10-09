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
    class Cola
    {
        Rectangle rect = new Rectangle();
        int x, y;
        Cola siguiente;
        public Cola(int x, int y, Canvas c)
        {
            this.x = x;
            this.y = y;
            siguiente = null;
            rect.Width = MainWindow.espacio;
            rect.Height = MainWindow.espacio;
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromArgb(255, 0, 0, 255);
            rect.Fill = color;
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            c.Children.Add(rect);    
        }
        public void setxy(int x, int y)
        {
            if(siguiente != null)
            {
                siguiente.setxy(this.x, this.y);
            }
            this.x = x;
            this.y = y;
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
        }

        public void meter(Canvas c)
        {
            if(siguiente == null)
            {
                siguiente = new Cola(this.x, this.y, c);
            }else
            {
                siguiente.meter(c);
            }
        }

        public Boolean comer(Comida c)
        {
            int difx = Math.Abs(this.x - c.getX());
            int dify = Math.Abs(this.y - c.getY());
            if(difx >= 0 && difx < MainWindow.espacio && dify >= 0 && dify < MainWindow.espacio)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public Cola verSiguiente()
        {
            return siguiente;
        }
        public Boolean choque(Cola c)
        {
            int difx = Math.Abs(this.x - c.getX());
            int dify = Math.Abs(this.y - c.getY());
            if (difx >= 0 && difx < MainWindow.espacio && dify >= 0 && dify < MainWindow.espacio)
            {
                return true;
            }
            else
            {
                return false;
            }
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
