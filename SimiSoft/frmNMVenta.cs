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
    public partial class frmNMVenta : DevExpress.XtraEditors.XtraForm
    {
        private Venta venta;
        public frmNMVenta()
        {
           
            InitializeComponent();
        }

        public frmNMVenta(int idVenta)
        {
            InitializeComponent();
            venta = new Venta
            {
                idVenta = idVenta
            }.GetById();
            txtId.Text = venta.idVenta.ToString();
            txtFecha.Text = venta.fecha.ToString();
            txtTotal.Text = venta.total.ToString();
            txtTipo.Text = venta.tipoEnvio;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtFecha.Text))
            {
                txtFecha.ErrorText = "Ingresa la fecha";
                txtFecha.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.ErrorText = "Ingresa el total";
                if (!ban)
                {
                    txtTotal.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                txtTipo.ErrorText = "Ingresa un tipo de envio";
                if (!ban)
                {
                    txtTipo.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //txtFecha.Text =
          //dtFecha.Value.ToString("MM/dd/yyyy");
            if (Validar())
            {
                if (venta == null)
                {
                    if (new Venta
                    {

                        fecha = Convert.ToDateTime(txtFecha.Text),
                        total = Convert.ToDecimal(txtTotal.Text),
                        tipoEnvio =txtTipo.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    venta.fecha = Convert.ToDateTime(txtFecha.Text);
                    venta.total = Convert.ToDecimal(txtTotal.Text);
                    venta.tipoEnvio = txtTipo.Text;

                    if (venta.Update() > 0)
                    {
                        XtraMessageBox.Show("Venta Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

            }
            
        }

     

      

        private void dtFecha_CloseUp(object sender, EventArgs e)
        {
            txtFecha.Text =
       dtFecha.Value.ToString("MM/dd/yyyy");
        }
    }
}