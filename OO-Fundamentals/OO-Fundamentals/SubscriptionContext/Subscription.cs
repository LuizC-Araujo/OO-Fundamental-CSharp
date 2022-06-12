using OO_Fundamentals.SharedContext;
using System;

namespace OO_Fundamentals.SubscriptionContext
{
    public class Subscription : BaseContent
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }

}
