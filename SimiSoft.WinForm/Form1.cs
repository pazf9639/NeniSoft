using System;
using SimiSoft.BML;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.codigo = txtCodigo.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.unidadMedida = txtUnidadMedida.Text;
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.marca = txtMarca.Text;
            if (producto.Add()>0)
            {
                MessageBox.Show("Registro Exitoso",Application.ProductName,
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                grid.DataSource = new Producto().GetAll();
            }
            
        }
    }
}
