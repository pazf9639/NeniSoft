using DevExpress.XtraEditors;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private Producto producto;
        // cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();         
        }
        // cuando es modificar producto
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Producto
            {
                idProducto = idProducto
            }.GetById();
            txtId.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            txtUnidadMedida.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Producto
                    {
                        descripcion = txtDescripcion.Text,
                        unidadMedida = txtUnidadMedida.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Producto Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = txtUnidadMedida.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update()>0)
                    {
                        XtraMessageBox.Show("Producto Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa la descripción";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtUnidadMedida.Text))
            {
                txtUnidadMedida.ErrorText = "Ingresa la unidad de medida";
                if (!ban)
                {
                    txtUnidadMedida.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresa el código";
                if (!ban)
                {
                    txtCodigo.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresa el precio";
                if (!ban)
                {
                    txtPrecio.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresa el stock";
                if (!ban)
                {
                    txtStock.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingresa la marca";
                if (!ban)
                {
                    txtMarca.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void frmNMProducto_Load_1(object sender, EventArgs e)
        {

        }
    }
}