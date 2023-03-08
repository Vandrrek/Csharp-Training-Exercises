using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Override
{
    public class Account
    {
        private string _name;
        private double _balance;
        private List<Account> _checkingAccounts;
        private List<Account> _savingAccounts;

        public Account()
        {
            _checkingAccounts = new List<Account>();
            _savingAccounts = new List<Account>();
            //this.Name = "Default Name";
            //this._balance = 0.01;
        }

        public Account(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public Account(string name, double balance, List<Account> checkingAccounts, List<Account> savingAccounts)
        {
            _name = name;
            _balance = balance;
            _checkingAccounts = checkingAccounts;
            _savingAccounts = savingAccounts;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public List<Account> CheckingAccounts
        {
            get => _checkingAccounts;
            set => _checkingAccounts = value;
        }

        public List<Account> SavingAccounts
        {
            get => _savingAccounts;
            set => _savingAccounts = value;
        }

        public void AddCheckingAccount(Account account)
        {
            _checkingAccounts.Add(account);
        }

        public void AddSavingAccount(Account account)
        {
            _savingAccounts.Add(account);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{Name} has a balance of {Balance}");

            builder.AppendLine("Checking Accounts:");

            foreach (var checkingAccount in _checkingAccounts)
            {
                builder.AppendLine($"{checkingAccount.Name} {checkingAccount.Balance}");
            }

            builder.AppendLine("Saving Accounts:");

            foreach (var savingAccount in _savingAccounts)
            {
                builder.AppendLine($"{savingAccount.Name} {savingAccount.Balance}");
            }

            return builder.ToString();
        }
    }
}
