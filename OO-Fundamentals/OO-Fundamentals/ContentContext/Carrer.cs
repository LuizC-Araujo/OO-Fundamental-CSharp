using System.Collections.Generic;

namespace OO_Fundamentals.ContentContext
{
    public class Carrer : Content 
    {
        public Carrer()
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

    }
}
