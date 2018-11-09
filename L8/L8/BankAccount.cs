using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class BankAccount
    {
        private string SortCode { get; }
        private string AccountNumber { get; }
        private double Overdraft { get; }
        private double Balance;
        private List<double> TransactionHistory;


        public BankAccount(string sc, string acc, double od)
        {
            if (Overdraft >= 0)
            {
                SortCode = sc;
                AccountNumber = acc;
                Overdraft = od;
                Balance = 0;
                TransactionHistory = new List<double>();
            }
            else
            {
                throw new ArgumentException("overdraft limit must be >= 0");
            }

        }

        public String SortCode1 { get { return SortCode; } }
        public string AccNum { get { return AccountNumber; } }
        public double OverDraft { get { return Overdraft; } }
        public double BalanceRead { get { return Balance; } }
        public List<double> TH { get { return TransactionHistory; } }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                TransactionHistory.Add(amount);
            }
            else
            {
                throw new ArgumentException("Amount must be >= 0");
            }

        }
        public void Withdraw(double amount)
        {

            if (amount > 0)
            {
                if (Balance + Overdraft > amount)
                {
                    Balance -= amount;
                    TransactionHistory.Add(amount * -1);
                }
                else
                {
                    throw new ArgumentException("Insufficient Funds");
                }
            }
            else
            {
                throw new ArgumentException("Amount must be greater than >= 0");
            }
        }
        public override String ToString()
        {
            String output = "sort code: " + SortCode1 + " account no: " + AccNum + " overdraft limit: " + OverDraft + " balance: " + BalanceRead;
            output += "Transaction History:";
            foreach (double trans in TransactionHistory)
            {
                output = +trans + " ";
            }
            return output;
        }


    }
}
