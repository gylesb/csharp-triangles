using Microsoft.AspNetCore.Mvc;
using Triangle.Models;

namespace Triangle.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/Result")]
    public ActionResult Result()
    {
      TriangleVariable myTriangle = new TriangleVariable();
      myTriangle.SetTriangle(Request.Query["length1"],Request.Query["length2"],Request.Query["length3"]);
      return View("Index", myTriangle);
    }

  }
}
