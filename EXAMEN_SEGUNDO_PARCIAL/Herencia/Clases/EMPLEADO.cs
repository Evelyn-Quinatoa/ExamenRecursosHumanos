using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class EMPLEADO: PERSONA
    {
        //ATRIBUTO
        private string tipodecontrato;
        private double sueldo;
        private string tipoempleado;
        private string cedula;
        //PROPIEDADES
        public string Tipodecontrato
        {
            get => tipodecontrato; 
            set => tipodecontrato = value;
        }
        public double Sueldo
        {
            get => sueldo; 
            set => sueldo = value; 
        }
        public string Tipoempleado 
        { 
            get => tipoempleado;
            set => tipoempleado = value;
        }
        public string Cedula 
        {
            get => cedula;
            set => cedula = value; 
        }

        //PROCEDIMIENTO,OPERACIONES,METODOS
        
     
        public void CalcularSueldo (double sueldoBase)
        {
            if(this.Tipoempleado == "GERENTE")
            {
                if (this.Tipodecontrato == "NUEVO")
                {
                    Sueldo =  2*sueldoBase + 350;
                }
                else if (this.Tipodecontrato == "LONGEVO")
                {
                    Sueldo = 2*sueldoBase + 750;
                }
            }
             if (this.Tipoempleado == "VENDEDOR")
            {
                if (this.Tipodecontrato == "NUEVO")
                {
                    Sueldo = sueldoBase + 350;
                }
                else if (this.Tipodecontrato == "LONGEVO")
                {
                    Sueldo = sueldoBase + 750;
                }
            }
            else
            {
                this.Sueldo = 0;
            }
            //PROCEDIMIENTO,OPERACIONES,METODOS
            

        }
    }
}
