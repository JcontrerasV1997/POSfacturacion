namespace Sistema.Presentacion
{
    partial class ConsultaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datapickerFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datapickerInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.botonComprobante = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardMostrar = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvMostrarDetalle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.textoTotalDetalle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoTotalImpuestoDetalle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textoSubtotalDetalle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.botonBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DgvListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cardMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(-1, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1291, 799);
            this.TabGeneral.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datapickerFinal);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.datapickerInicio);
            this.tabPage1.Controls.Add(this.botonComprobante);
            this.tabPage1.Controls.Add(this.cardMostrar);
            this.tabPage1.Controls.Add(this.botonBuscar);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1283, 761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datapickerFinal
            // 
            this.datapickerFinal.BackColor = System.Drawing.Color.Indigo;
            this.datapickerFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.datapickerFinal.BorderRadius = 9;
            this.datapickerFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapickerFinal.ForeColor = System.Drawing.Color.White;
            this.datapickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerFinal.FormatCustom = "                   dd/mm/yyyy";
            this.datapickerFinal.Location = new System.Drawing.Point(490, 560);
            this.datapickerFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datapickerFinal.Name = "datapickerFinal";
            this.datapickerFinal.Size = new System.Drawing.Size(469, 59);
            this.datapickerFinal.TabIndex = 42;
            this.datapickerFinal.Value = new System.DateTime(2020, 5, 16, 20, 14, 0, 0);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(505, 531);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 25);
            this.bunifuCustomLabel2.TabIndex = 41;
            this.bunifuCustomLabel2.Text = "Hasta";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 530);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 25);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Desde";
            // 
            // datapickerInicio
            // 
            this.datapickerInicio.BackColor = System.Drawing.Color.Indigo;
            this.datapickerInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.datapickerInicio.BorderRadius = 9;
            this.datapickerInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapickerInicio.ForeColor = System.Drawing.Color.White;
            this.datapickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerInicio.FormatCustom = "                   dd/mm/yyyy";
            this.datapickerInicio.Location = new System.Drawing.Point(10, 560);
            this.datapickerInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datapickerInicio.Name = "datapickerInicio";
            this.datapickerInicio.Size = new System.Drawing.Size(455, 59);
            this.datapickerInicio.TabIndex = 38;
            this.datapickerInicio.Value = new System.DateTime(2020, 5, 16, 20, 14, 0, 0);
            // 
            // botonComprobante
            // 
            this.botonComprobante.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonComprobante.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonComprobante.BorderRadius = 5;
            this.botonComprobante.ButtonText = "Comprobante";
            this.botonComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonComprobante.DisabledColor = System.Drawing.Color.Gray;
            this.botonComprobante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComprobante.ForeColor = System.Drawing.Color.White;
            this.botonComprobante.Iconcolor = System.Drawing.Color.Transparent;
            this.botonComprobante.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonComprobante.Iconimage")));
            this.botonComprobante.Iconimage_right = null;
            this.botonComprobante.Iconimage_right_Selected = null;
            this.botonComprobante.Iconimage_Selected = null;
            this.botonComprobante.IconMarginLeft = 0;
            this.botonComprobante.IconMarginRight = 0;
            this.botonComprobante.IconRightVisible = false;
            this.botonComprobante.IconRightZoom = 0D;
            this.botonComprobante.IconVisible = false;
            this.botonComprobante.IconZoom = 90D;
            this.botonComprobante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonComprobante.IsTab = false;
            this.botonComprobante.Location = new System.Drawing.Point(519, 663);
            this.botonComprobante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonComprobante.Name = "botonComprobante";
            this.botonComprobante.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.botonComprobante.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.botonComprobante.OnHoverTextColor = System.Drawing.Color.White;
            this.botonComprobante.selected = false;
            this.botonComprobante.Size = new System.Drawing.Size(129, 42);
            this.botonComprobante.TabIndex = 37;
            this.botonComprobante.Text = "Comprobante";
            this.botonComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonComprobante.Textcolor = System.Drawing.Color.White;
            this.botonComprobante.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cardMostrar
            // 
            this.cardMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cardMostrar.BorderRadius = 15;
            this.cardMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardMostrar.BottomSahddow = false;
            this.cardMostrar.color = System.Drawing.Color.Crimson;
            this.cardMostrar.Controls.Add(this.bunifuCustomLabel14);
            this.cardMostrar.Controls.Add(this.dgvMostrarDetalle);
            this.cardMostrar.Controls.Add(this.textoTotalDetalle);
            this.cardMostrar.Controls.Add(this.textoTotalImpuestoDetalle);
            this.cardMostrar.Controls.Add(this.textoSubtotalDetalle);
            this.cardMostrar.Controls.Add(this.bunifuCustomLabel16);
            this.cardMostrar.Controls.Add(this.bunifuCustomLabel17);
            this.cardMostrar.Controls.Add(this.bunifuCustomLabel18);
            this.cardMostrar.Controls.Add(this.pictureBox3);
            this.cardMostrar.LeftSahddow = false;
            this.cardMostrar.Location = new System.Drawing.Point(10, 34);
            this.cardMostrar.Name = "cardMostrar";
            this.cardMostrar.RightSahddow = false;
            this.cardMostrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cardMostrar.ShadowDepth = 60;
            this.cardMostrar.Size = new System.Drawing.Size(1121, 453);
            this.cardMostrar.TabIndex = 36;
            this.cardMostrar.Visible = false;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(21, 28);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(309, 25);
            this.bunifuCustomLabel14.TabIndex = 46;
            this.bunifuCustomLabel14.Text = "Articulos Relacionados a la Compra";
            // 
            // dgvMostrarDetalle
            // 
            this.dgvMostrarDetalle.AllowUserToAddRows = false;
            this.dgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.dgvMostrarDetalle.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMostrarDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarDetalle.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMostrarDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDetalle.DoubleBuffered = true;
            this.dgvMostrarDetalle.EnableHeadersVisualStyles = false;
            this.dgvMostrarDetalle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMostrarDetalle.HeaderBgColor = System.Drawing.Color.Black;
            this.dgvMostrarDetalle.HeaderForeColor = System.Drawing.Color.Azure;
            this.dgvMostrarDetalle.Location = new System.Drawing.Point(8, 68);
            this.dgvMostrarDetalle.Name = "dgvMostrarDetalle";
            this.dgvMostrarDetalle.ReadOnly = true;
            this.dgvMostrarDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarDetalle.Size = new System.Drawing.Size(697, 308);
            this.dgvMostrarDetalle.TabIndex = 37;
            // 
            // textoTotalDetalle
            // 
            this.textoTotalDetalle.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoTotalDetalle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoTotalDetalle.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoTotalDetalle.BorderThickness = 2;
            this.textoTotalDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoTotalDetalle.Enabled = false;
            this.textoTotalDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoTotalDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoTotalDetalle.isPassword = false;
            this.textoTotalDetalle.Location = new System.Drawing.Point(840, 258);
            this.textoTotalDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.textoTotalDetalle.Name = "textoTotalDetalle";
            this.textoTotalDetalle.Size = new System.Drawing.Size(224, 44);
            this.textoTotalDetalle.TabIndex = 45;
            this.textoTotalDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoTotalImpuestoDetalle
            // 
            this.textoTotalImpuestoDetalle.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoTotalImpuestoDetalle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoTotalImpuestoDetalle.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoTotalImpuestoDetalle.BorderThickness = 2;
            this.textoTotalImpuestoDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoTotalImpuestoDetalle.Enabled = false;
            this.textoTotalImpuestoDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoTotalImpuestoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoTotalImpuestoDetalle.isPassword = false;
            this.textoTotalImpuestoDetalle.Location = new System.Drawing.Point(840, 183);
            this.textoTotalImpuestoDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.textoTotalImpuestoDetalle.Name = "textoTotalImpuestoDetalle";
            this.textoTotalImpuestoDetalle.Size = new System.Drawing.Size(224, 44);
            this.textoTotalImpuestoDetalle.TabIndex = 44;
            this.textoTotalImpuestoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoSubtotalDetalle
            // 
            this.textoSubtotalDetalle.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textoSubtotalDetalle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoSubtotalDetalle.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.textoSubtotalDetalle.BorderThickness = 2;
            this.textoSubtotalDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoSubtotalDetalle.Enabled = false;
            this.textoSubtotalDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textoSubtotalDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoSubtotalDetalle.isPassword = false;
            this.textoSubtotalDetalle.Location = new System.Drawing.Point(839, 108);
            this.textoSubtotalDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.textoSubtotalDetalle.Name = "textoSubtotalDetalle";
            this.textoSubtotalDetalle.Size = new System.Drawing.Size(224, 44);
            this.textoSubtotalDetalle.TabIndex = 43;
            this.textoSubtotalDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(728, 270);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(44, 21);
            this.bunifuCustomLabel16.TabIndex = 42;
            this.bunifuCustomLabel16.Text = "Total";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(726, 196);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel17.TabIndex = 41;
            this.bunifuCustomLabel17.Text = "Total Impuesto";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(726, 121);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(75, 21);
            this.bunifuCustomLabel18.TabIndex = 40;
            this.bunifuCustomLabel18.Text = "Sub Total";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Sistema.Presentacion.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(1070, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.BorderRadius = 5;
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
            this.botonBuscar.Location = new System.Drawing.Point(349, 663);
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
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(986, 517);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvListado.DoubleBuffered = true;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.White;
            this.DgvListado.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DgvListado.HeaderForeColor = System.Drawing.Color.White;
            this.DgvListado.Location = new System.Drawing.Point(0, 0);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvListado.RowHeadersWidth = 5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListado.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.DgvListado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1283, 514);
            this.DgvListado.StandardTab = true;
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // ConsultaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 812);
            this.Controls.Add(this.TabGeneral);
            this.Name = "ConsultaVenta";
            this.Text = "Consulta venta entre fechas";
            this.Load += new System.EventHandler(this.ConsultaVenta_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cardMostrar.ResumeLayout(false);
            this.cardMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker datapickerInicio;
        private Bunifu.Framework.UI.BunifuFlatButton botonComprobante;
        private Bunifu.Framework.UI.BunifuCards cardMostrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMostrarDetalle;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoTotalDetalle;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoTotalImpuestoDetalle;
        private Bunifu.Framework.UI.BunifuMetroTextbox textoSubtotalDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton botonBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private Bunifu.Framework.UI.BunifuDatepicker datapickerFinal;
    }
}