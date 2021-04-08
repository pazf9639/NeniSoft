
namespace SimiSoft
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcVenta = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipoEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 548);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(SimiSoft.BML.Venta);
            // 
            // gcVenta
            // 
            this.gcVenta.DataSource = this.ventaBindingSource;
            this.gcVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVenta.Location = new System.Drawing.Point(0, 20);
            this.gcVenta.MainView = this.gvVenta;
            this.gcVenta.MenuManager = this.barManager1;
            this.gcVenta.Name = "gcVenta";
            this.gcVenta.Size = new System.Drawing.Size(798, 548);
            this.gcVenta.TabIndex = 9;
            this.gcVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVenta});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(SimiSoft.BML.Venta);
            // 
            // gvVenta
            // 
            this.gvVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colfecha,
            this.coltotal,
            this.coltipoEnvio,
            this.colactivo});
            this.gvVenta.GridControl = this.gcVenta;
            this.gvVenta.Name = "gvVenta";
            this.gvVenta.OptionsBehavior.Editable = false;
            this.gvVenta.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVenta.OptionsView.ShowAutoFilterRow = true;
            this.gvVenta.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 2;
            // 
            // coltipoEnvio
            // 
            this.coltipoEnvio.Caption = "Tipo de envio";
            this.coltipoEnvio.FieldName = "tipoEnvio";
            this.coltipoEnvio.Name = "coltipoEnvio";
            this.coltipoEnvio.Visible = true;
            this.coltipoEnvio.VisibleIndex = 3;
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gcVenta);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DevExpress.XtraGrid.GridControl gcVenta;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coltipoEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}