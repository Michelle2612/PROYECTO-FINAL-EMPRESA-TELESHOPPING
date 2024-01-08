namespace PROYECTO_TELESHOPPING
{
    partial class FormMenuAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BtnEmpresa);
            this.panel1.Controls.Add(this.BtnProveedor);
            this.panel1.Controls.Add(this.BtnCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 47);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 415);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.logo_admin;
            this.pictureBox1.Location = new System.Drawing.Point(249, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.producto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(446, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(215, 47);
            this.btnProductos.TabIndex = 11;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.cierre;
            this.pictureBox2.Location = new System.Drawing.Point(758, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresa.ForeColor = System.Drawing.Color.Black;
            this.BtnEmpresa.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.camion;
            this.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpresa.Location = new System.Drawing.Point(231, 0);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(215, 47);
            this.BtnEmpresa.TabIndex = 2;
            this.BtnEmpresa.Text = "EMPRESA DE TRANSPORTE";
            this.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmpresa.UseVisualStyleBackColor = false;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.ForeColor = System.Drawing.Color.Black;
            this.BtnProveedor.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.icon_proveedor;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(101, 0);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(130, 47);
            this.BtnProveedor.TabIndex = 1;
            this.BtnProveedor.Text = "PROVEEDOR";
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnCliente.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.icon_user;
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(0, 0);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(101, 47);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "CLIENTE";
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProductos;
    }
}