﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.Requests
{
    public abstract class Request
    {
        public string UserId { get; set; }
    }
}
