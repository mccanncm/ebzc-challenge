using System;

namespace EBizChargeChallenge.Data.Models
{
    public class CardMemberInfo
    {
        public CreditCard MemberCreditCard { get; set; }
        public string BillingAddress { get; set; }
        public string NameOnCard { get; set; }
        public string ZipCode { get; set; }
        public string CardNickname { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }

    }
}
