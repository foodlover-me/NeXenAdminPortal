using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NeXenAdminPortal.Data;
using NeXenAdminPortal.Models;

namespace NeXenAdminPortal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        IEnumerable<string> emailList = new List<string> { "a", "b" };
        var sequence = emailList
            .Where(s => s != "a")
            .Select(s => s.ToUpper())
            .ToList();

        var output = new List<string>();
        foreach (var email in emailList)
        {
            if (email == "a")
            {
                continue;
            }
            output.Add(email.ToUpper());
        }
        
        var whatIsThis = sequence.ToList();
        
        var emails = _dbContext.Users.Select(u => u.Email).ToList();
        return View(emails);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}