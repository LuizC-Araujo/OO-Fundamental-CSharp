using OO_Fundamentals.SharedContext;
using System.Collections.Generic;

namespace OO_Fundamentals.ContentContext
{
    public class Module : BaseContent
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }
}
