using OO_Fundamentals.NotificationContext;
using System;

namespace OO_Fundamentals.SharedContext
{
    public abstract class BaseContent : Notifiable
    {
        public BaseContent()
        {
            Id = Guid.NewGuid(); // SPOF - Single Point of Failure
        }
        public Guid Id { get; set; }
    }
}
