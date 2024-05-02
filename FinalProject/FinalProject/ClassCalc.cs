using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class ClassCalc
    {
        //private fields
        private decimal operand1;
        private decimal operand2;

        //Constructor
        public ClassCalc() { }

        //Property
        public decimal Operand1
        {
            set { operand1 = value; }
            get { return operand1; }
        }

        public decimal Operand2
        {
            set { operand2 = value; }
            get { return operand2; }
        }
        //Methods
        public decimal Addition()
        {
            return operand1 + operand2;
        }

        public decimal Substraction()
        {
            return operand1 - operand2;
        }

        public decimal Multiplication()
        {
            return operand1 * operand2;
        }

        public decimal Division()
        {
            return operand1 / operand2;
        }
        
        public void Clear()
        {
            Operand1 = 0;
            Operand2 = 0;
        }
    }
}
