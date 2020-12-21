﻿using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;

namespace keep.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

            // logged in so, redirect to main issues list
            Response.Redirect("/App/Issues");

        }
    }
}
