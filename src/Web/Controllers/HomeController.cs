﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImplantChoice.Business.Contracts;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        internal readonly ISomeRuleFactory _ruleFactory;

        public HomeController(ISomeRuleFactory ruleFactory)
        {
            _ruleFactory = ruleFactory;
        }

        public IActionResult Index()
        {
            var ruleA = _ruleFactory.GetRule("RuleA");
            var ruleB = _ruleFactory.GetRule("RuleB");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}