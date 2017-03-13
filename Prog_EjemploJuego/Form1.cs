using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog_EjemploJuego.Figuras;

namespace Prog_EjemploJuego
{
    public partial class Form1 : Form
    {
        Cuadrado c1 = new Cuadrado("Cuadrin", Color.Aqua, 30);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.c1.pintar(e.Graphics);
        }
    }
}
