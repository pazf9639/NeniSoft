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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
            {
                Text = "Modificar Producto " + (int)gvProductos.GetFocusedRowCellValue("idProducto")
            }.ShowDialog();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Producto
            {
                idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto")
            }.Delete();
            productoBindingSource.DataSource = new Producto().GetAll();
            gvProductos.BestFitColumns();
        }
    }
}