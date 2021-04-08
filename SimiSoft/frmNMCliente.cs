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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private Cliente cliente;
        public frmNMCliente()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                idCliente = idCliente
            }.GetById();
            txtId.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
       //     txtRazonSocial.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();
        }

        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa el teléfono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa el descuento";
                if (!ban)
                {
                    txtDescuento.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(cliente == null) 
                { 
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                     //   razonSocial = txtRazonSocial.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text)
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    cliente.nombre = txtNombre.Text;
                    //cliente.razonSocial = txtRazonSocial.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);
                    if(cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}