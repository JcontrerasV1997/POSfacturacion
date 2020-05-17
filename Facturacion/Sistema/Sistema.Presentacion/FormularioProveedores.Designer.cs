namespace Sistema.Presentacion
{
    partial class FormularioProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.botoEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkSeleccion = new Bunifu.Framework.UI.BunifuCheckbox();
            this.botonResetear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DgvListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboTipoDocumento = new Bunifu.Framework.UI.BunifuDropdown();
            this.textoEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoTelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoDireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoNumeroDocumento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.botonInsertar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.botonCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.botonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(0, 2);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1139, 661);
            this.TabGeneral.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.bunifuSeparator1);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.botoEliminar);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage1.Controls.Add(this.chkSeleccion);
            this.tabPage1.Controls.Add(this.botonResetear);
            this.tabPage1.Controls.Add(this.botonBuscar);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 395);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1120, 10);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.Indigo;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(17, 460);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(338, 43);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.text = "";
            // 
            // botoEliminar
            // 
            this.botoEliminar.Activecolor = System.Drawing.Color.Firebrick;
            this.botoEliminar.BackColor = System.Drawing.Color.Crimson;
            this.botoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoEliminar.BorderRadius = 0;
            this.botoEliminar.ButtonText = "Eliminar";
            this.botoEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.botoEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoEliminar.ForeColor = System.Drawing.Color.White;
            this.botoEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.botoEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("botoEliminar.Iconimage")));
            this.botoEliminar.Iconimage_right = null;
            this.botoEliminar.Iconimage_right_Selected = null;
            this.botoEliminar.Iconimage_Selected = null;
            this.botoEliminar.IconMarginLeft = 0;
            this.botoEliminar.IconMarginRight = 0;
            this.botoEliminar.IconRightVisible = false;
            this.botoEliminar.IconRightZoom = 0D;
            this.botoEliminar.IconVisible = false;
            this.botoEliminar.IconZoom = 90D;
            this.botoEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botoEliminar.IsTab = false;
            this.botoEliminar.Location = new System.Drawing.Point(745, 460);
            this.botoEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botoEliminar.Name = "botoEliminar";
            this.botoEliminar.Normalcolor = System.Drawing.Color.Crimson;
            this.botoEliminar.OnHovercolor = System.Drawing.Color.Firebrick;
            this.botoEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.botoEliminar.selected = false;
            this.botoEliminar.Size = new System.Drawing.Size(129, 42);
            this.botoEliminar.TabIndex = 11;
            this.botoEliminar.Text = "Eliminar";
            this.botoEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botoEliminar.Textcolor = System.Drawing.Color.White;
            this.botoEliminar.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoEliminar.Click += new System.EventHandler(this.botoEliminar_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(56, 419);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Seleccionar";
            // 
            // chkSeleccion
            // 
            this.chkSeleccion.BackColor = System.Drawing.Color.SlateBlue;
            this.chkSeleccion.ChechedOffColor = System.Drawing.Color.DarkRed;
            this.chkSeleccion.Checked = true;
            this.chkSeleccion.CheckedOnColor = System.Drawing.Color.SlateBlue;
            this.chkSeleccion.ForeColor = System.Drawing.Color.White;
            this.chkSeleccion.Location = new System.Drawing.Point(30, 420);
            this.chkSeleccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSeleccion.Name = "chkSeleccion";
            this.chkSeleccion.Size = new System.Drawing.Size(20, 20);
            this.chkSeleccion.TabIndex = 7;
            this.chkSeleccion.OnChange += new System.EventHandler(this.chkSeleccion_OnChange);
            // 
            // botonResetear
            // 
            this.botonResetear.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonResetear.BackColor = System.Drawing.Color.Indigo;
            this.botonResetear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonResetear.BorderRadius = 0;
            this.botonResetear.ButtonText = "Refrescar";
            this.botonResetear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonResetear.DisabledColor = System.Drawing.Color.Gray;
            this.botonResetear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResetear.ForeColor = System.Drawing.Color.White;
            this.botonResetear.Iconcolor = System.Drawing.Color.Transparent;
            this.botonResetear.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonResetear.Iconimage")));
            this.botonResetear.Iconimage_right = null;
            this.botonResetear.Iconimage_right_Selected = null;
            this.botonResetear.Iconimage_Selected = null;
            this.botonResetear.IconMarginLeft = 0;
            this.botonResetear.IconMarginRight = 0;
            this.botonResetear.IconRightVisible = false;
            this.botonResetear.IconRightZoom = 0D;
            this.botonResetear.IconVisible = false;
            this.botonResetear.IconZoom = 90D;
            this.botonResetear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonResetear.IsTab = false;
            this.botonResetear.Location = new System.Drawing.Point(567, 460);
            this.botonResetear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonResetear.Name = "botonResetear";
            this.botonResetear.Normalcolor = System.Drawing.Color.Indigo;
            this.botonResetear.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.botonResetear.OnHoverTextColor = System.Drawing.Color.White;
            this.botonResetear.selected = false;
            this.botonResetear.Size = new System.Drawing.Size(129, 42);
            this.botonResetear.TabIndex = 5;
            this.botonResetear.Text = "Refrescar";
            this.botonResetear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonResetear.Textcolor = System.Drawing.Color.White;
            this.botonResetear.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // botonBuscar
            // 
            this.botonBuscar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonBuscar.BackColor = System.Drawing.Color.Indigo;
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.BorderRadius = 0;
            this.botonBuscar.ButtonText = "Buscar";
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.botonBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.ForeColor = System.Drawing.Color.White;
            this.botonBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.botonBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.Iconimage")));
            this.botonBuscar.Iconimage_right = null;
            this.botonBuscar.Iconimage_right_Selected = null;
            this.botonBuscar.Iconimage_Selected = null;
            this.botonBuscar.IconMarginLeft = 0;
            this.botonBuscar.IconMarginRight = 0;
            this.botonBuscar.IconRightVisible = false;
            this.botonBuscar.IconRightZoom = 0D;
            this.botonBuscar.IconVisible = false;
            this.botonBuscar.IconZoom = 90D;
            this.botonBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonBuscar.IsTab = false;
            this.botonBuscar.Location = new System.Drawing.Point(395, 460);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Normalcolor = System.Drawing.Color.Indigo;
            this.botonBuscar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.botonBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.botonBuscar.selected = false;
            this.botonBuscar.Size = new System.Drawing.Size(129, 42);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonBuscar.Textcolor = System.Drawing.Color.White;
            this.botonBuscar.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(815, 407);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(272, 37);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "TOTAL DE REGISTROS";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.DoubleBuffered = true;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.DimGray;
            this.DgvListado.HeaderBgColor = System.Drawing.Color.Black;
            this.DgvListado.HeaderForeColor = System.Drawing.Color.White;
            this.DgvListado.Location = new System.Drawing.Point(3, 4);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvListado.RowHeadersWidth = 5;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListado.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.DgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1125, 384);
            this.DgvListado.StandardTab = true;
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.comboTipoDocumento);
            this.tabPage2.Controls.Add(this.textoEmail);
            this.tabPage2.Controls.Add(this.textoTelefono);
            this.tabPage2.Controls.Add(this.textoDireccion);
            this.tabPage2.Controls.Add(this.textoNumeroDocumento);
            this.tabPage2.Controls.Add(this.textoNombre);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel10);
            this.tabPage2.Controls.Add(this.botonInsertar);
            this.tabPage2.Controls.Add(this.botonCancelar);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel8);
            this.tabPage2.Controls.Add(this.botonActualizar);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel7);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            this.txtID.TabIndex = 33;
            this.txtID.Visible = false;
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.comboTipoDocumento.BorderRadius = 3;
            this.comboTipoDocumento.DisabledColor = System.Drawing.Color.Gray;
            this.comboTipoDocumento.ForeColor = System.Drawing.Color.White;
            this.comboTipoDocumento.Items = new string[] {
        "RUT",
        "NIT",
        "CEDULA"};
            this.comboTipoDocumento.Location = new System.Drawing.Point(524, 190);
            this.comboTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.NomalColor = System.Drawing.Color.Teal;
            this.comboTipoDocumento.onHoverColor = System.Drawing.Color.DodgerBlue;
            this.comboTipoDocumento.selectedIndex = -1;
            this.comboTipoDocumento.Size = new System.Drawing.Size(199, 46);
            this.comboTipoDocumento.TabIndex = 25;
            // 
            // textoEmail
            // 
            this.textoEmail.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoEmail.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoEmail.BorderThickness = 2;
            this.textoEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoEmail.ForeColor = System.Drawing.Color.Black;
            this.textoEmail.isPassword = false;
            this.textoEmail.Location = new System.Drawing.Point(524, 420);
            this.textoEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(199, 44);
            this.textoEmail.TabIndex = 32;
            this.textoEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoTelefono
            // 
            this.textoTelefono.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoTelefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoTelefono.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoTelefono.BorderThickness = 2;
            this.textoTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoTelefono.ForeColor = System.Drawing.Color.Black;
            this.textoTelefono.isPassword = false;
            this.textoTelefono.Location = new System.Drawing.Point(524, 368);
            this.textoTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(199, 44);
            this.textoTelefono.TabIndex = 31;
            this.textoTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoDireccion
            // 
            this.textoDireccion.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoDireccion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoDireccion.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoDireccion.BorderThickness = 2;
            this.textoDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoDireccion.ForeColor = System.Drawing.Color.Black;
            this.textoDireccion.isPassword = false;
            this.textoDireccion.Location = new System.Drawing.Point(524, 309);
            this.textoDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(199, 44);
            this.textoDireccion.TabIndex = 30;
            this.textoDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoNumeroDocumento
            // 
            this.textoNumeroDocumento.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoNumeroDocumento.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoNumeroDocumento.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoNumeroDocumento.BorderThickness = 2;
            this.textoNumeroDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoNumeroDocumento.ForeColor = System.Drawing.Color.Black;
            this.textoNumeroDocumento.isPassword = false;
            this.textoNumeroDocumento.Location = new System.Drawing.Point(524, 244);
            this.textoNumeroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.textoNumeroDocumento.Name = "textoNumeroDocumento";
            this.textoNumeroDocumento.Size = new System.Drawing.Size(199, 44);
            this.textoNumeroDocumento.TabIndex = 29;
            this.textoNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoNombre
            // 
            this.textoNombre.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoNombre.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoNombre.BorderThickness = 2;
            this.textoNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoNombre.ForeColor = System.Drawing.Color.Black;
            this.textoNombre.isPassword = false;
            this.textoNombre.Location = new System.Drawing.Point(524, 135);
            this.textoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(199, 44);
            this.textoNombre.TabIndex = 28;
            this.textoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(258, 262);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(184, 26);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Numero Documento";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(258, 438);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(135, 26);
            this.bunifuCustomLabel10.TabIndex = 25;
            this.bunifuCustomLabel10.Text = "Usuario /Email";
            // 
            // botonInsertar
            // 
            this.botonInsertar.ActiveBorderThickness = 1;
            this.botonInsertar.ActiveCornerRadius = 20;
            this.botonInsertar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.botonInsertar.ActiveForecolor = System.Drawing.Color.White;
            this.botonInsertar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.botonInsertar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.botonInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertar.BackgroundImage")));
            this.botonInsertar.ButtonText = "Registrar";
            this.botonInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInsertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.botonInsertar.IdleBorderThickness = 1;
            this.botonInsertar.IdleCornerRadius = 20;
            this.botonInsertar.IdleFillColor = System.Drawing.Color.White;
            this.botonInsertar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.botonInsertar.IdleLineColor = System.Drawing.Color.MediumBlue;
            this.botonInsertar.Location = new System.Drawing.Point(344, 525);
            this.botonInsertar.Margin = new System.Windows.Forms.Padding(5);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(190, 55);
            this.botonInsertar.TabIndex = 5;
            this.botonInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.AccessibleDescription = "";
            this.botonCancelar.ActiveBorderThickness = 1;
            this.botonCancelar.ActiveCornerRadius = 20;
            this.botonCancelar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.botonCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.botonCancelar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.botonCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.botonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCancelar.BackgroundImage")));
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonCancelar.ButtonText = "Cancelar";
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.botonCancelar.IdleBorderThickness = 1;
            this.botonCancelar.IdleCornerRadius = 20;
            this.botonCancelar.IdleFillColor = System.Drawing.Color.White;
            this.botonCancelar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.botonCancelar.IdleLineColor = System.Drawing.Color.MediumBlue;
            this.botonCancelar.Location = new System.Drawing.Point(561, 525);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(190, 55);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(376, 20);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(401, 36);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Registrar/Actualizar Proveedores";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(257, 386);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(86, 26);
            this.bunifuCustomLabel8.TabIndex = 18;
            this.bunifuCustomLabel8.Text = "Telefono";
            // 
            // botonActualizar
            // 
            this.botonActualizar.ActiveBorderThickness = 1;
            this.botonActualizar.ActiveCornerRadius = 20;
            this.botonActualizar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.botonActualizar.ActiveForecolor = System.Drawing.Color.White;
            this.botonActualizar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.botonActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.botonActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonActualizar.BackgroundImage")));
            this.botonActualizar.ButtonText = "Actualizar";
            this.botonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActualizar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.botonActualizar.IdleBorderThickness = 1;
            this.botonActualizar.IdleCornerRadius = 20;
            this.botonActualizar.IdleFillColor = System.Drawing.Color.White;
            this.botonActualizar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.botonActualizar.IdleLineColor = System.Drawing.Color.MediumBlue;
            this.botonActualizar.Location = new System.Drawing.Point(344, 525);
            this.botonActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(190, 55);
            this.botonActualizar.TabIndex = 12;
            this.botonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(258, 318);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(92, 26);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Direccion";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(257, 154);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 26);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Nombre";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(257, 210);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(178, 26);
            this.bunifuCustomLabel6.TabIndex = 16;
            this.bunifuCustomLabel6.Text = "Tipo de Documento";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FormularioProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 667);
            this.Controls.Add(this.TabGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRAR PROVEEDORES";
            this.Load += new System.EventHandler(this.FormularioProveedores_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton botoEliminar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox chkSeleccion;
        private Bunifu.Framework.UI.BunifuFlatButton botonResetear;
        private Bunifu.Framework.UI.BunifuFlatButton botonBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 botonActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 botonCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 botonInsertar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoTelefono;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoDireccion;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoNumeroDocumento;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoNombre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDropdown comboTipoDocumento;
        private System.Windows.Forms.TextBox txtID;
    }
}