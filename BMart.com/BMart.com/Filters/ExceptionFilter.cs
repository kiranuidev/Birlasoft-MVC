using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMart.com.Filters
{
    public class ExceptionFilterCustom :FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Controller.ViewBag.ErroMessage = "Error occured and Filter called";
            filterContext.HttpContext.Response.Write("Exception Handled In Filter");
        }
    }
}