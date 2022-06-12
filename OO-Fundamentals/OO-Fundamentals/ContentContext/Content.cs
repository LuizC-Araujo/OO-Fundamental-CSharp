using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Fundamentals.ContentContext
{
    public abstract class Content
    {
        public Content(string url, string title)
        {
            Id = Guid.NewGuid(); // SPOF - Single Point of Failure
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}
