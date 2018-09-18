using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Factura Factura = new Factura();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto productoUno = new Producto(1, "Lavarropa Whirpool", 4000);
            Producto productoDos = new Producto(1, "Teclado", 509);
            Factura factura = new Factura();

            factura.Productos.Add(productoUno);
            factura.Productos.Add(productoDos);
            MessageBox.Show(factura.Total.ToString());
        }
    }
}
