//1-46
    //No code
//47
public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Description = "Gibson Les Paul";
        ViewBag.Price = 699.99;
        return View();
    }
}

//48
<p>Description: @ViewBag.Description</p>
//49-50
    //No Code