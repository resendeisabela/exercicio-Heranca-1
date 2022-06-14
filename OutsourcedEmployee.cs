using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca1
{
    class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valueperhour, double aditionalCharge)
            : base(name, hours, valueperhour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }
    }
}
