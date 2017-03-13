using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_EjemploJuego.Figuras
{
    abstract class FiguraGeometrica
    {
        public string nombre { get; set; }
        public Color color { get; set; }
        public int px { get; set; }
        public int py { get; set; }

        public FiguraGeometrica(String nombre, Color color, int px, int py)
        {
            this.nombre = nombre;
            this.px = px;
            this.py = py;
            this.color = color;
        }

        public FiguraGeometrica(String nombre, Color color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public FiguraGeometrica() { }

        public abstract double calcularArea();
        public abstract double calcularPerimetro();

        public abstract void pintar(System.Drawing.Graphics formGraphics);
        public void setPosicion(int px, int py)
        {
            this.px = px;
            this.py = py;
        }

        public void mover(int pasoX, int pasoY)
        {
            this.px += pasoX;
            this.py += pasoY;
        }
    }
}
