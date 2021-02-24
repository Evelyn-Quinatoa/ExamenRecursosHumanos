using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FRMCLIENTE : Form
    {
        public FRMCLIENTE()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CLIENTE cLIENTE = new Clases.CLIENTE();
            cLIENTE.ApellidoPaterno1 = txtApPaterno.Text;
            cLIENTE.ApellidoMaterno1 = txtApMaterno.Text;
            cLIENTE.Nombres1 = txtNombre.Text;
            cLIENTE.Sexo = CmbSexo.Text;
            cLIENTE.NumeroSeguroSocial1 = txtSegSoc.Text;
            cLIENTE.Categoria = CmbCategoria.Text;
            cLIENTE.Cedula = txtCedula.Text;
            cLIENTE.GenerarCodigoDePedido();
            txtCodigoPostal.Text = cLIENTE.Codigodepedido;
            DAGCliente.Rows.Insert(0, cLIENTE.ApellidoPaterno1, cLIENTE.ApellidoMaterno1, cLIENTE.Nombres1, cLIENTE.Sexo, cLIENTE.NumeroSeguroSocial1, cLIENTE.Categoria, cLIENTE.Codigodepedido,cLIENTE.Cedula);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DAGCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
