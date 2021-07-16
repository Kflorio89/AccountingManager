using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager
{
    public class BillData
    {
        public string Name;
        public double Amount;
        private enum _type
        {
            Electric,
            Gas,
            Water,
            Trash,
            VehiclePayment,
            Insurance,
            Health,
            HealthInsurance,
            CreditCard,
            Rent,
        }

        public BillData (string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
