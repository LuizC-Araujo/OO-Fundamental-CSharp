using OO_Fundamentals.NotificationContext;
using OO_Fundamentals.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace OO_Fundamentals.SubscriptionContext
{
    public class Student : BaseContent
    {
        public Student()
        {
            CreateSubscription = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> CreateSubscription { get; set; }
        public bool IsPremium => CreateSubscription.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            CreateSubscription.Add(subscription);
        }
    }
}
