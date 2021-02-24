using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class PERSONA
    {
        //ATRIBUTOS
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private string Nombres;
        private string NumeroSeguroSocial;
        private string sexo;
        // PROPIEDADES 
        public string ApellidoPaterno1
        {
            get => ApellidoPaterno;
            set => ApellidoPaterno = value;
        }
        public string ApellidoMaterno1
        { 
            get => ApellidoMaterno;
            set => ApellidoMaterno = value;
        }
        public string Nombres1
        {
            get => Nombres;
            set => Nombres = value;
        }
        public string NumeroSeguroSocial1
        { 
            get => NumeroSeguroSocial; 
            set => NumeroSeguroSocial = value;
        }
        public string Sexo
        { 
            get => sexo; 
            set => sexo = value; 
        }
    }
}
