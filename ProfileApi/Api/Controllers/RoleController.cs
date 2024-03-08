using Microsoft.AspNetCore.Mvc;

namespace ProfileApi.Controllers;

/// <summary>
/// Работа с ролями
/// </summary>
[Route("public/role")]
public class RoleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

