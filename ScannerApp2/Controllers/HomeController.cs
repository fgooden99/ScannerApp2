﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.Models;
using static DataLibrary.BusinessLogic.ScannerProcessor;

namespace ScannerApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ScannerLog()
        {
            ViewBag.Message = "View a list of Scanned ID's.";

            return View();
        }
        public ActionResult LocationSelection()
        {
            ViewBag.Message = "A selection of your current location.";

            return View();
        }
        public ActionResult EmployeeList()
        {
            ViewBag.Message = "View a list of Employee's.";

            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    IdentifictionCardID = row.IdentifictionCardID,
                    Name = row.Name,
                    CourtAccessRequired = row.CourtAccessRequired,
                    IDCardNumber = row.IDCardNumber
                });
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}