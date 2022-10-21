using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Herencia_Y_Objetos
{
    class Moto : Vehiculo
    {
        private bool tieneSidecar;

        public Moto(string matricula, string marca, string modelo, bool tieneSidecar) 
            : base(matricula, marca, modelo)
        {
            this.tieneSidecar = tieneSidecar;
        }

        public Moto(string matricula, string marca, string modelo, int kilometros, bool tieneSidecar) 
            : base(matricula, marca, modelo, kilometros)
        {
            this.tieneSidecar = tieneSidecar;
        }

        public override void CambiaMatricula(string nuevaMatricula)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Sidecar: " + tieneSidecar;
        }
    }
}
