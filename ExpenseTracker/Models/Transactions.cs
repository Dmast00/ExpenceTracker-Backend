using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Transactions
    {
        [Key]
        public int IdTransaction { get; set; }
        public string TransactionName { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionAmount { get; set; }
    }
}
