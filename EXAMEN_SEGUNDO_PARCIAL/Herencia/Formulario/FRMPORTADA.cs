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
    public partial class FRMPORTADA : Form
    {
        public FRMPORTADA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void Main()
        {
            Formulario.FRMPORTADA PORTADA = new Formulario.FRMPORTADA();
            PORTADA.ShowDialog();
        }
        private void FRMPORTADA_Load(object sender, EventArgs e)
        {

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Formulario.FRMCLIENTE CLIENTE = new Formulario.FRMCLIENTE();
            CLIENTE.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Formulario.FMREMPLEADOS EMPLEADOS = new Formulario.FMREMPLEADOS();
            EMPLEADOS.Show();
        }
    }
}
