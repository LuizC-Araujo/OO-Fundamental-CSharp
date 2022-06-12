using OO_Fundamentals.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace OO_Fundamentals.SubscriptionContext
{
    public class Student : BaseContent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
