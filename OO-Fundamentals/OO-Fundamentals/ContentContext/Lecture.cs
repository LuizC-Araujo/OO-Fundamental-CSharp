﻿using OO_Fundamentals.ContentContext.Enums;
using OO_Fundamentals.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Fundamentals.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Order { get; set; }
        public string Title { get; set; }
    }
}
