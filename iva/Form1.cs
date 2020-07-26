using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iva
{
    public partial class IvaProducto : Form
    {
        public IvaProducto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(txtPrecio.Text);
            double iva = 0;
            double total = 0;

            iva = precio * 19 / 100;
          

            lblIva.Text = Convert.ToString(String.Format("{0:n}", iva));

            total = iva + precio;
            lblPrecioFinal.Text = Convert.ToString(String.Format("{0:n}",total));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = String.Empty;
            lblIva.Text = "0";
            lblPrecioFinal.Text = "0";
            txtPrecio.Focus();
        }
    }
}
