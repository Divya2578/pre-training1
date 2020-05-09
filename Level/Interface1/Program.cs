
using System;

namespace InterfaceApplication
{

    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    class Tester
    {

        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("10", "8/10/2020", 98900.00);
            Transaction t2 = new Transaction("20", "9/10/2020", 651900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}

