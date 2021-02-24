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
    public partial class FMREMPLEADOS : Form
    {
        public FMREMPLEADOS()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.EMPLEADO eMPLEADO = new Clases.EMPLEADO();
            eMPLEADO.ApellidoPaterno1 = txtApPaterno.Text;
            eMPLEADO.ApellidoMaterno1 = txtApMaterno.Text;
            eMPLEADO.Nombres1 = txtNombre.Text;
            eMPLEADO.Sexo = CombSexo.Text;
            eMPLEADO.NumeroSeguroSocial1 = txtNunSegSoc.Text;
            eMPLEADO.Tipoempleado = CombTipoEmpleado.Text;
            eMPLEADO.Cedula = txtCedula.Text;
            eMPLEADO.Tipodecontrato = CnboTipoContrato.Text;
            eMPLEADO.CalcularSueldo(1250);
            DGVEmpleado.Rows.Insert(0, eMPLEADO.ApellidoPaterno1, eMPLEADO.ApellidoMaterno1, eMPLEADO.Nombres1,eMPLEADO.Sexo, eMPLEADO.NumeroSeguroSocial1, eMPLEADO.Tipoempleado, eMPLEADO.Tipodecontrato,eMPLEADO.Sueldo,eMPLEADO.Cedula);
        }

        private void GboEmpleados_Enter(object sender, EventArgs e)
        {

        }

        private void FMREMPLEADOS_Load(object sender, EventArgs e)
        {

        }
    }
}
