using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BaseConstructors
{
    public class Account
    {
        private string _name;
        private double _balance;
        private DebitCard _debitCard;
        private bool _isPaperless;
        private DateTime _dateOpened;

        public Account(string name, double balance, DebitCard debitcard)
        {
            this.Name = name;
            this.Balance = balance;
            this.DebitCard = debitcard;
        }
        
        public Account(string name, double balance, DebitCard debitcard, bool ispaperless)
            : this(name, balance, debitcard)
        {
            this.IsPaperless = ispaperless;
        }
        public Account(string name, double balance, DebitCard debitcard, DateTime dateopened) 
            :this (name, balance, debitcard)
        {
            this.DateOpened = dateopened;
        }
        public Account(string name, double balance, DebitCard debitcard, bool ispaperless, DateTime dateopened)
        :this(name, balance, debitcard)
        {
            this.IsPaperless = ispaperless;
            this.DateOpened = dateopened;
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

        public bool IsPaperless
        {
            get => _isPaperless;
            private set => _isPaperless = value;
        }

        public DebitCard DebitCard
        {
            get => _debitCard;
            private set => _debitCard = value;
        }

        public DateTime DateOpened
        {
            get => _dateOpened;
            private set => _dateOpened = value;
        }
    }
}
