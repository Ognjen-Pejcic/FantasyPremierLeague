﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Filters
{
    public class NotLoggedIn : ActionFilterAttribute
    {
    }
}