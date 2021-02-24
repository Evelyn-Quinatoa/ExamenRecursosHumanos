
namespace Formulario
{
    partial class FRMCLIENTE
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
            this.GPBCliente = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSegSoc = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNumSecSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.DAGCliente = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.Lblcedula = new System.Windows.Forms.Label();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSECSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DAGCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCliente
            // 
            this.GPBCliente.Controls.Add(this.Lblcedula);
            this.GPBCliente.Controls.Add(this.txtCedula);
            this.GPBCliente.Controls.Add(this.btnGuardar);
            this.GPBCliente.Controls.Add(this.CmbCategoria);
            this.GPBCliente.Controls.Add(this.CmbSexo);
            this.GPBCliente.Controls.Add(this.txtApMaterno);
            this.GPBCliente.Controls.Add(this.txtNombre);
            this.GPBCliente.Controls.Add(this.txtSegSoc);
            this.GPBCliente.Controls.Add(this.txtCodigoPostal);
            this.GPBCliente.Controls.Add(this.txtApPaterno);
            this.GPBCliente.Controls.Add(this.LblCodigoPedido);
            this.GPBCliente.Controls.Add(this.LblCategoria);
            this.GPBCliente.Controls.Add(this.LblNumSecSoc);
            this.GPBCliente.Controls.Add(this.LblSexo);
            this.GPBCliente.Controls.Add(this.LblNombre);
            this.GPBCliente.Controls.Add(this.LblApMaterno);
            this.GPBCliente.Controls.Add(this.LblApPaterno);
            this.GPBCliente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBCliente.Location = new System.Drawing.Point(29, 30);
            this.GPBCliente.Name = "GPBCliente";
            this.GPBCliente.Size = new System.Drawing.Size(1306, 235);
            this.GPBCliente.TabIndex = 0;
            this.GPBCliente.TabStop = false;
            this.GPBCliente.Text = "CLIENTE";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.Location = new System.Drawing.Point(945, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 49);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CmbCategoria.Location = new System.Drawing.Point(261, 152);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(160, 28);
            this.CmbCategoria.TabIndex = 15;
            this.CmbCategoria.Text = "NUEVO";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(628, 67);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(160, 28);
            this.CmbSexo.TabIndex = 14;
            this.CmbSexo.Text = "MASCULINO";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(243, 68);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(152, 27);
            this.txtApMaterno.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(431, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 27);
            this.txtNombre.TabIndex = 12;
            // 
            // txtSegSoc
            // 
            this.txtSegSoc.Location = new System.Drawing.Point(48, 153);
            this.txtSegSoc.Name = "txtSegSoc";
            this.txtSegSoc.Size = new System.Drawing.Size(152, 27);
            this.txtSegSoc.TabIndex = 11;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(484, 153);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(152, 27);
            this.txtCodigoPostal.TabIndex = 9;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(32, 68);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(152, 27);
            this.txtApPaterno.TabIndex = 7;
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Location = new System.Drawing.Point(494, 112);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(142, 20);
            this.LblCodigoPedido.TabIndex = 6;
            this.LblCodigoPedido.Text = "Codigo de Pedido";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(315, 112);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(80, 20);
            this.LblCategoria.TabIndex = 5;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblNumSecSoc
            // 
            this.LblNumSecSoc.AutoSize = true;
            this.LblNumSecSoc.Location = new System.Drawing.Point(28, 112);
            this.LblNumSecSoc.Name = "LblNumSecSoc";
            this.LblNumSecSoc.Size = new System.Drawing.Size(196, 20);
            this.LblNumSecSoc.TabIndex = 4;
            this.LblNumSecSoc.Text = "Numero de Seguro Social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(685, 33);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(45, 20);
            this.LblSexo.TabIndex = 3;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(480, 33);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(70, 20);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(257, 33);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(138, 20);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido Materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(44, 33);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(132, 20);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // DAGCliente
            // 
            this.DAGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSECSOC,
            this.CATEGORIA,
            this.CODIGOPEDIDO,
            this.Cedula});
            this.DAGCliente.Location = new System.Drawing.Point(29, 281);
            this.DAGCliente.Name = "DAGCliente";
            this.DAGCliente.Size = new System.Drawing.Size(1306, 213);
            this.DAGCliente.TabIndex = 1;
            this.DAGCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DAGCliente_CellContentClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(712, 153);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(152, 27);
            this.txtCedula.TabIndex = 17;
            // 
            // Lblcedula
            // 
            this.Lblcedula.AutoSize = true;
            this.Lblcedula.Location = new System.Drawing.Point(754, 112);
            this.Lblcedula.Name = "Lblcedula";
            this.Lblcedula.Size = new System.Drawing.Size(68, 20);
            this.Lblcedula.TabIndex = 18;
            this.Lblcedula.Text = "CEDULA";
            this.Lblcedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 140;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 130;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 180;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 160;
            // 
            // NUMSECSOC
            // 
            this.NUMSECSOC.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSECSOC.Name = "NUMSECSOC";
            this.NUMSECSOC.Width = 170;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 180;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO DE  PEDIDO";
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 200;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CEDULA";
            this.Cedula.Name = "Cedula";
            // 
            // FRMCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.DAGCliente);
            this.Controls.Add(this.GPBCliente);
            this.Name = "FRMCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GPBCliente.ResumeLayout(false);
            this.GPBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DAGCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCliente;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSegSoc;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNumSecSoc;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.DataGridView DAGCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label Lblcedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSECSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
    }
}