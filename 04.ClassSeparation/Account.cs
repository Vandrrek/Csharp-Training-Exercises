using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.ClassSeparation
{
    public class Account
    {
        private string _name;
        private double _balance;
        private DebitCard _debitcard;
        private Statement _statement;
        private List<Transaction> _transactions;

        public Account()
        {
            
        }
        public Account(string name, double balance, DebitCard debitcard, Statement statement, List<Transaction> transactions)
        {
            Name = name;
            Balance = balance;
            Debitcard = debitcard;
            Statement = statement;
            Transactions = transactions;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public double Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        public DebitCard Debitcard
        {
            get => _debitcard;
            private set => _debitcard = value;
        }

        public Statement Statement
        {
            get => _statement;
            private set => _statement = value;
        }

        public List<Transaction> Transactions
        {
            get => _transactions;
            private set => _transactions = value;
        }
    }
}
