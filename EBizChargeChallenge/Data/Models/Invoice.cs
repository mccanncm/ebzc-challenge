using System;

namespace EBizChargeChallenge.Data.Models
{
    public class Invoice
    {    
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal AmountDue { get; set; }
        public string Terms { get; set; }
        public string Description { get; set; }
        public string PONumber { get; set; }
    }
}
