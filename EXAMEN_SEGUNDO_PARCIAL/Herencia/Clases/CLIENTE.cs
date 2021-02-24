using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class CLIENTE : PERSONA
    {
        //ATRIBUTOS
        private string categoria;
        private string codigodepedido;
        private string cedula;
        //PROPIEDADES
        public string Categoria 
        { 
            get => categoria;
            set => categoria = value;
        }
        public string Codigodepedido 
        { 
            get => codigodepedido;
            set => codigodepedido = value; 
        }
        public string Cedula 
        { 
            get => cedula;
            set => cedula = value;
        }

        //PROCEDIMIENTO,OPERACIONES,METODOS
        public void GenerarCodigoDePedido ()
        {
            this.Codigodepedido = "C" + this.ApellidoPaterno1.Substring(0, 3);
        }
    }
}
