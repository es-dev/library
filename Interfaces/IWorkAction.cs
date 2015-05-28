﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Interfaces
{
    public interface IWorkAction
    {
        string Name { get; }
        TimeSpan Interval { get; }
        HttpContext Context { get; set; }
        void Start();
    }
}
