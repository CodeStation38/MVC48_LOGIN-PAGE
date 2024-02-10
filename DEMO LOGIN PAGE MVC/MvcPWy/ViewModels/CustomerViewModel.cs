using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPWy.Models;
using System.Web.Mvc;
using MvcPWy.BusinessLogic.CustomerBL;
using System.Collections;

namespace MvcPWy.ViewModels
{
    public class CustomerViewModel : Customer
    {
        public IEnumerable<SelectListItem> HobbyList { get; set; }

        public IEnumerable<SelectListItem> PreferredColorList { get; set; }

    }
}