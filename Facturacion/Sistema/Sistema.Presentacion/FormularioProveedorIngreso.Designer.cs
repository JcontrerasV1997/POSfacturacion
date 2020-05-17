namespace Sistema.Presentacion
{
    partial class FormularioProveedorIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProveedorIngreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.botonResetear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DgvListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.botonResetear);
            this.tabPage1.Controls.Add(this.botonBuscar);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.Indigo;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(20, 375);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(299, 43);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.text = "";
            // 
            // botonResetear
            // 
            this.botonResetear.Activecolor = System.Drawing.Color.DodgerBlue;
            this.botonResetear.BackColor = System.Drawing.Color.Indigo;
            this.botonResetear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonResetear.BorderRadius = 0;
            this.botonResetear.ButtonText = "Resetear";
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
            this.botonResetear.Location = new System.Drawing.Point(532, 375);
            this.botonResetear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonResetear.Name = "botonResetear";
            this.botonResetear.Normalcolor = System.Drawing.Color.Indigo;
            this.botonResetear.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.botonResetear.OnHoverTextColor = System.Drawing.Color.White;
            this.botonResetear.selected = false;
            this.botonResetear.Size = new System.Drawing.Size(129, 42);
            this.botonResetear.TabIndex = 5;
            this.botonResetear.Text = "Resetear";
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
            this.botonBuscar.Location = new System.Drawing.Point(380, 375);
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
            this.labelTotal.Location = new System.Drawing.Point(826, 359);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(285, 37);
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
            this.DgvListado.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
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
            this.DgvListado.GridColor = System.Drawing.Color.DimGray;
            this.DgvListado.HeaderBgColor = System.Drawing.Color.Black;
            this.DgvListado.HeaderForeColor = System.Drawing.Color.White;
            this.DgvListado.Location = new System.Drawing.Point(3, 3);
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
            this.DgvListado.Size = new System.Drawing.Size(1116, 353);
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
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(2, 3);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1127, 548);
            this.TabGeneral.TabIndex = 3;
            // 
            // FormularioProveedorIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 544);
            this.Controls.Add(this.TabGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioProveedorIngreso";
            this.Text = "Seleccion de Proveedor";
            this.Load += new System.EventHandler(this.FormularioProveedorIngreso_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton botonResetear;
        private Bunifu.Framework.UI.BunifuFlatButton botonBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabControl TabGeneral;
    }
}