
namespace Formulario
{
    partial class FMREMPLEADOS
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
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CombTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.CnboTipoContrato = new System.Windows.Forms.ComboBox();
            this.CombSexo = new System.Windows.Forms.ComboBox();
            this.txtNunSegSoc = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.LblTipodeContrato = new System.Windows.Forms.Label();
            this.LblTipodeEmpleado = new System.Windows.Forms.Label();
            this.LblNumSecSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.DGVEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GboEmpleados.Controls.Add(this.txtCedula);
            this.GboEmpleados.Controls.Add(this.label1);
            this.GboEmpleados.Controls.Add(this.btnGuardar);
            this.GboEmpleados.Controls.Add(this.CombTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.CnboTipoContrato);
            this.GboEmpleados.Controls.Add(this.CombSexo);
            this.GboEmpleados.Controls.Add(this.txtNunSegSoc);
            this.GboEmpleados.Controls.Add(this.txtApMaterno);
            this.GboEmpleados.Controls.Add(this.txtNombre);
            this.GboEmpleados.Controls.Add(this.txtApPaterno);
            this.GboEmpleados.Controls.Add(this.LblTipodeContrato);
            this.GboEmpleados.Controls.Add(this.LblTipodeEmpleado);
            this.GboEmpleados.Controls.Add(this.LblNumSecSoc);
            this.GboEmpleados.Controls.Add(this.LblSexo);
            this.GboEmpleados.Controls.Add(this.LblNombre);
            this.GboEmpleados.Controls.Add(this.LblApMaterno);
            this.GboEmpleados.Controls.Add(this.LblApPaterno);
            this.GboEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboEmpleados.Location = new System.Drawing.Point(28, 33);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Size = new System.Drawing.Size(1317, 219);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "Empleado";
            this.GboEmpleados.Enter += new System.EventHandler(this.GboEmpleados_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(990, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CombTipoEmpleado
            // 
            this.CombTipoEmpleado.FormattingEnabled = true;
            this.CombTipoEmpleado.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.CombTipoEmpleado.Location = new System.Drawing.Point(309, 160);
            this.CombTipoEmpleado.Name = "CombTipoEmpleado";
            this.CombTipoEmpleado.Size = new System.Drawing.Size(173, 32);
            this.CombTipoEmpleado.TabIndex = 17;
            this.CombTipoEmpleado.Text = "GERENTE";
            // 
            // CnboTipoContrato
            // 
            this.CnboTipoContrato.FormattingEnabled = true;
            this.CnboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CnboTipoContrato.Location = new System.Drawing.Point(564, 160);
            this.CnboTipoContrato.Name = "CnboTipoContrato";
            this.CnboTipoContrato.Size = new System.Drawing.Size(198, 32);
            this.CnboTipoContrato.TabIndex = 16;
            this.CnboTipoContrato.Text = "NUEVO";
            // 
            // CombSexo
            // 
            this.CombSexo.FormattingEnabled = true;
            this.CombSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CombSexo.Location = new System.Drawing.Point(641, 90);
            this.CombSexo.Name = "CombSexo";
            this.CombSexo.Size = new System.Drawing.Size(173, 32);
            this.CombSexo.TabIndex = 15;
            this.CombSexo.Text = "FEMENINO";
            // 
            // txtNunSegSoc
            // 
            this.txtNunSegSoc.Location = new System.Drawing.Point(32, 169);
            this.txtNunSegSoc.Name = "txtNunSegSoc";
            this.txtNunSegSoc.Size = new System.Drawing.Size(174, 29);
            this.txtNunSegSoc.TabIndex = 14;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(230, 88);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(174, 29);
            this.txtApMaterno.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(434, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 29);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(18, 88);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(174, 29);
            this.txtApPaterno.TabIndex = 11;
            // 
            // LblTipodeContrato
            // 
            this.LblTipodeContrato.AutoSize = true;
            this.LblTipodeContrato.Location = new System.Drawing.Point(588, 133);
            this.LblTipodeContrato.Name = "LblTipodeContrato";
            this.LblTipodeContrato.Size = new System.Drawing.Size(150, 24);
            this.LblTipodeContrato.TabIndex = 10;
            this.LblTipodeContrato.Text = "Tipo de Contrato";
            // 
            // LblTipodeEmpleado
            // 
            this.LblTipodeEmpleado.AutoSize = true;
            this.LblTipodeEmpleado.Location = new System.Drawing.Point(315, 133);
            this.LblTipodeEmpleado.Name = "LblTipodeEmpleado";
            this.LblTipodeEmpleado.Size = new System.Drawing.Size(167, 24);
            this.LblTipodeEmpleado.TabIndex = 9;
            this.LblTipodeEmpleado.Text = "Tipo de Empleado";
            // 
            // LblNumSecSoc
            // 
            this.LblNumSecSoc.AutoSize = true;
            this.LblNumSecSoc.Location = new System.Drawing.Point(14, 133);
            this.LblNumSecSoc.Name = "LblNumSecSoc";
            this.LblNumSecSoc.Size = new System.Drawing.Size(229, 24);
            this.LblNumSecSoc.TabIndex = 8;
            this.LblNumSecSoc.Text = "Numero de Seguro Social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(684, 45);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(54, 24);
            this.LblSexo.TabIndex = 7;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(464, 45);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(79, 24);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(241, 45);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(153, 24);
            this.LblApMaterno.TabIndex = 5;
            this.LblApMaterno.Text = "Apellido Materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(28, 45);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(149, 24);
            this.LblApPaterno.TabIndex = 4;
            this.LblApPaterno.Text = "Apellido Paterno";
            // 
            // DGVEmpleado
            // 
            this.DGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.TIPOEMPLEADO,
            this.TIPOCONTRATO,
            this.SUELDO,
            this.CEDULA});
            this.DGVEmpleado.Location = new System.Drawing.Point(28, 258);
            this.DGVEmpleado.Name = "DGVEmpleado";
            this.DGVEmpleado.Size = new System.Drawing.Size(1315, 166);
            this.DGVEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(810, 160);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(174, 29);
            this.txtCedula.TabIndex = 20;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 150;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 150;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 150;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 150;
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 150;
            // 
            // TIPOEMPLEADO
            // 
            this.TIPOEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPOEMPLEADO.Name = "TIPOEMPLEADO";
            this.TIPOEMPLEADO.Width = 150;
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            this.TIPOCONTRATO.Width = 130;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 110;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 130;
            // 
            // FMREMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.DGVEmpleado);
            this.Controls.Add(this.GboEmpleados);
            this.Name = "FMREMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMREMPLEADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMREMPLEADOS_Load);
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox CombTipoEmpleado;
        private System.Windows.Forms.ComboBox CnboTipoContrato;
        private System.Windows.Forms.ComboBox CombSexo;
        private System.Windows.Forms.TextBox txtNunSegSoc;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label LblTipodeContrato;
        private System.Windows.Forms.Label LblTipodeEmpleado;
        private System.Windows.Forms.Label LblNumSecSoc;
        private System.Windows.Forms.DataGridView DGVEmpleado;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
    }
}