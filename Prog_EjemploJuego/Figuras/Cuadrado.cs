using Prog_EjemploJuego.Figuras;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_EjemploJuego.Figuras
{
    class Cuadrado : FiguraGeometrica
    {
        double lado;

        public Cuadrado() { }

        /// <summary>
        /// Instancia un cuadrado ubicado en el origen
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="color"></param>
        /// <param name="lado"></param>
        public Cuadrado(string nombre, Color color, double lado) 
            : base(nombre, color)
        {
            this.lado = lado;
        }

        /// <summary>
        /// Instancia un cuadrado ubicado en una posicion inicial
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="color"></param>
        /// <param name="lado"></param>
        /// <param name="px"></param>
        /// <param name="py"></param>
        public Cuadrado(string nombre, Color color, double lado,int px, int py) 
            : base(nombre,color,px,py)
        {
            this.lado = lado;
        }

        /// <summary>
        /// Calcula area del cuadrado
        /// </summary>
        /// <returns></returns>
        public override double calcularArea()
        {
            double area = lado * lado;
            return area;
        }

        /// <summary>
        /// Calcula perimetro del cuadrado
        /// </summary>
        /// <returns></returns>
        public override double calcularPerimetro()
        {
            double per = lado * 4;
            return per;
        }

        //Sobreescribir el metodo ToString de Object
        public override String ToString()
         {
             double perimetro = this.calcularPerimetro();
             return String.Format("Lado: {0}, Perimetro: {1}", this.lado, perimetro);
         }

        /// <summary>
        /// Pinta el cuadrado en la forma indicada por su contexto grafico
        /// </summary>
        /// <param name="formGraphics"></param>
        public override void pintar(Graphics formGraphics)
        {
            SolidBrush myBrush = new SolidBrush(this.color);

            formGraphics.FillRectangle(myBrush,
                new Rectangle(this.px, this.py, (int) this.lado, (int) this.lado));
            myBrush.Dispose();
        }
    }
}
