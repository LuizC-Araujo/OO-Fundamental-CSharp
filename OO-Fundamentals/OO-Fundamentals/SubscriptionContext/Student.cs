using OO_Fundamentals.SharedContext;

namespace OO_Fundamentals.SubscriptionContext
{
    public class Student : BaseContent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}
