namespace Sistema.Presentacion
{
    partial class FormularioCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelActivar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkActivar = new Bunifu.Framework.UI.BunifuSwitch();
            this.botoEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkSeleccion = new Bunifu.Framework.UI.BunifuCheckbox();
            this.botonResetear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.labelTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DgvListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.botonActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtID = new System.Windows.Forms.TextBox();
            this.botonCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.botonInsertar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.TabGeneral.Location = new System.Drawing.Point(1, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1035, 578);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelActivar);
            this.tabPage1.Controls.Add(this.chkActivar);
            this.tabPage1.Controls.Add(this.botoEliminar);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage1.Controls.Add(this.chkSeleccion);
            this.tabPage1.Controls.Add(this.botonResetear);
            this.tabPage1.Controls.Add(this.botonBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelActivar
            // 
            this.labelActivar.AutoSize = true;
            this.labelActivar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivar.Location = new System.Drawing.Point(192, 414);
            this.labelActivar.Name = "labelActivar";
            this.labelActivar.Size = new System.Drawing.Size(136, 21);
            this.labelActivar.TabIndex = 13;
            this.labelActivar.Text = "Activar/Desactivar";
            // 
            // chkActivar
            // 
            this.chkActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkActivar.BorderRadius = 5;
            this.chkActivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkActivar.Location = new System.Drawing.Point(139, 416);
            this.chkActivar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Oncolor = System.Drawing.Color.SlateBlue;
            this.chkActivar.Onoffcolor = System.Drawing.Color.Red;
            this.chkActivar.Size = new System.Drawing.Size(51, 19);
            this.chkActivar.TabIndex = 12;
            this.chkActivar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkActivar.Value = true;
            this.chkActivar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkActivar_MouseClick);
            // 
            // botoEliminar
            // 
            this.botoEliminar.Activecolor = System.Drawing.Color.Firebrick;
            this.botoEliminar.BackColor = System.Drawing.Color.Crimson;
            this.botoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoEliminar.BorderRadius = 7;
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
            this.botoEliminar.Location = new System.Drawing.Point(651, 456);
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
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(35, 414);
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
            this.chkSeleccion.Location = new System.Drawing.Point(9, 414);
            this.chkSeleccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSeleccion.Name = "chkSeleccion";
            this.chkSeleccion.Size = new System.Drawing.Size(20, 20);
            this.chkSeleccion.TabIndex = 7;
            this.chkSeleccion.OnChange += new System.EventHandler(this.chkSeleccion_OnChange);
            // 
            // botonResetear
            // 
            this.botonResetear.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonResetear.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonResetear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonResetear.BorderRadius = 7;
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
            this.botonResetear.Location = new System.Drawing.Point(504, 456);
            this.botonResetear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonResetear.Name = "botonResetear";
            this.botonResetear.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.botonResetear.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.botonResetear.OnHoverTextColor = System.Drawing.Color.White;
            this.botonResetear.selected = false;
            this.botonResetear.Size = new System.Drawing.Size(129, 42);
            this.botonResetear.TabIndex = 5;
            this.botonResetear.Text = "Refrescar";
            this.botonResetear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonResetear.Textcolor = System.Drawing.Color.White;
            this.botonResetear.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResetear.Click += new System.EventHandler(this.botonResetear_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.BorderRadius = 7;
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
            this.botonBuscar.Location = new System.Drawing.Point(354, 456);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Normalcolor = System.Drawing.Color.RoyalBlue;
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
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(9, 452);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(326, 42);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.text = "";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(757, 404);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(227, 30);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "TOTAL DE REGISTROS :";
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
            this.DgvListado.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.DoubleBuffered = true;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.White;
            this.DgvListado.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DgvListado.HeaderForeColor = System.Drawing.Color.White;
            this.DgvListado.Location = new System.Drawing.Point(6, 6);
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
            this.DgvListado.Size = new System.Drawing.Size(1018, 391);
            this.DgvListado.StandardTab = true;
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick_1);
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
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.botonActualizar);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage2.Controls.Add(this.bunifuSeparator3);
            this.tabPage2.Controls.Add(this.bunifuSeparator2);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.botonCancelar);
            this.tabPage2.Controls.Add(this.botonInsertar);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(343, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 44);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.botonActualizar.Location = new System.Drawing.Point(295, 435);
            this.botonActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(169, 55);
            this.botonActualizar.TabIndex = 24;
            this.botonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(294, 25);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(370, 36);
            this.bunifuCustomLabel3.TabIndex = 22;
            this.bunifuCustomLabel3.Text = "Registrar/Actualizar Categoria";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 502);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1027, 35);
            this.bunifuSeparator3.TabIndex = 21;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 189);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1027, 46);
            this.bunifuSeparator2.TabIndex = 20;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(923, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(98, 25);
            this.txtID.TabIndex = 19;
            this.txtID.Visible = false;
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
            this.botonCancelar.Location = new System.Drawing.Point(515, 435);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(169, 55);
            this.botonCancelar.TabIndex = 18;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.botonInsertar.Location = new System.Drawing.Point(295, 435);
            this.botonInsertar.Margin = new System.Windows.Forms.Padding(5);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(169, 55);
            this.botonInsertar.TabIndex = 17;
            this.botonInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(343, 242);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(259, 131);
            this.txtDescripcion.TabIndex = 16;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(137, 290);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(153, 36);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Descripcion";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(137, 148);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 36);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Nombre";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FormularioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 580);
            this.Controls.Add(this.TabGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioCategoria";
            this.Text = "ADMINISTRAR CATEGORIAS";
            this.Load += new System.EventHandler(this.FormularioCategoria_Load);
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
        private Bunifu.Framework.UI.BunifuCustomLabel labelTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvListado;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private Bunifu.Framework.UI.BunifuFlatButton botonBuscar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private Bunifu.Framework.UI.BunifuFlatButton botonResetear;
        private Bunifu.Framework.UI.BunifuCheckbox chkSeleccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton botoEliminar;
        private Bunifu.Framework.UI.BunifuSwitch chkActivar;
        private Bunifu.Framework.UI.BunifuCustomLabel labelActivar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 botonActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox txtID;
        private Bunifu.Framework.UI.BunifuThinButton2 botonCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 botonInsertar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}