using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult Index()
        {
            string message = "This is a message to show how we can use View Models.";
            return View("Index", message);
        }

        [HttpGet("IntPage")]
        
        public ViewResult IntPage()
        {
            int[] myArray = new int[]{1,2,3,4,5};

            return View("IntPage", myArray);
        }

        [HttpGet("SingleUser")]

        public ViewResult SingleUser()
        {
            User toDisplay = new User("Billy", "Gates");
            return View("SingleUser", toDisplay);
        }

        [HttpGet("MultUser")]

        public ViewResult MultUser()
        {
            List<User> ListOfUsers = new List<User>
            {
            new User("Billy", "Gates"),
            new User("Jeff", "Gates"),
            new User("Jeff", "Gates"),
            new User("Jeff", "Gates"),
            };
            return View(ListOfUsers);

        }
    }

}