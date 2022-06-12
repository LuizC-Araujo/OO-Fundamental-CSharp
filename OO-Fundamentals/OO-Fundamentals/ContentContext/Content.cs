using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Fundamentals.ContentContext
{
    public abstract class Content : BaseContent
    {
        public Content(string url, string title)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
