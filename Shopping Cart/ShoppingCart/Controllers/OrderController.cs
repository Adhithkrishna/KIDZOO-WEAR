using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart_DataAccess.Repository.IRepository;
using ShoppingCart_Models.ViewModels;
using ShoppingCart_Utility.BrainTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailsRepository _orderDRepo;
        private readonly IBrainTreeGate _brain;


        public OrderController(
            IOrderHeaderRepository orderHRepo, IOrderDetailsRepository orderDRepo, IBrainTreeGate brain)
        {
            _brain = brain;
            _orderHRepo = orderHRepo;
            _orderDRepo = orderDRepo;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
