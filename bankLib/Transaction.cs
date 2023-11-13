using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace bankLib
{
    public class Transaction
    {
        public decimal Amount { get; }
        public string AmountInWord { get 
            {
                return $"{((int)Amount).ToWords()} only";
            } }
        public DateTime Date { get; }
        public string Note { get;}
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }
    }
}
