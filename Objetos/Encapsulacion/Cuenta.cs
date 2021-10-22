using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Encapsulacion
{
    class Cuenta
    {
        //public float balance;
        private float balance;

        public float Balance { 
            get => balance; 
            ///set { if (balance > 0) balance = value; } 
        }

        public void Depositar(float monto)
        {
            if (monto > 0)
            {
                //this.balance = balance + monto;
                this.balance += monto;
            }
        }
        public void Retirar(float monto)
        {
            if (monto > 0)
            {
                this.balance -= monto;
            }
        }
    }
}
