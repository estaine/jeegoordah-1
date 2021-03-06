﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeegoordah.Core.DL;

namespace Jeegoordah.Web.Controllers
{
    public abstract class DbController : Controller
    {
        protected DbFactory DbFactory;

        public void SetDbFactory(DbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }
    }
}