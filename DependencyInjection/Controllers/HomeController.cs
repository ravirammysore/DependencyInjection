using MyApp.Models;
using MyApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyApp.Controllers;

public class HomeController : Controller
{
    private readonly IPaymentService _paymentService;

    public HomeController(IPaymentService paymentService)
    {
       _paymentService= paymentService;
    }

    public IActionResult Index()
    {
        var vm = _paymentService.Pay();
        return View(vm);
    }

}