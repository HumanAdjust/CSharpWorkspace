using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14
{
    interface ITransactions
    {
        string ProductName { get; set; }
        DateTime TransactionDate { get; set; }
        int TransactionAmount { get; set; }
        void showTransaction();
    }
    class Transaction : ITransactions
    {
        private string productName;
        private DateTime transactionDate = DateTime.Now;
        private int transactionAmount;

        public string ProductName { get { return productName; } set { productName = value; } }
        public DateTime TransactionDate { get { return transactionDate; } set { transactionDate = value; } }
        public int TransactionAmount { get { return transactionAmount; } set { transactionAmount = value; } }
        public void showTransaction()
        {
            Console.WriteLine("*************** 거래정보 ***************");
            Console.WriteLine($"ProductName: {productName}");
            Console.WriteLine($"TransactionDate: {transactionDate}");
            Console.WriteLine($"TransactionAmount: {transactionAmount}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction()
            {
                ProductName = "노트북",
                TransactionAmount = 240
            };
            t1.showTransaction();

            Transaction t2 = new Transaction()
            {
                ProductName = "데스크탑",
                TransactionDate = new DateTime(2020, 3, 1),
                TransactionAmount = 80
            };
            t2.showTransaction();
        }
    }
}
