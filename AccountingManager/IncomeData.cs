using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager
{
    public class IncomeData
    {
        public class IncomeSource
        {
            public string Name;
            public double Amount;

            public IncomeSource(string name, double amount)
            {
                Name = name;
                Amount = amount;
            }
        }

        private List<IncomeSource> _incomes;

        public IncomeData()
        {
            _incomes = new List<IncomeSource>();
        }

        public void AddIncome(string name, double amount)
        {
            _incomes.Add(new IncomeSource(name, amount));
        }
        
        public List<IncomeSource> GetAllIncomes()
        {
            return _incomes;
        }
    }
}
