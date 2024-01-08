namespace MyServer.App.Controllers
{
    using MyServer.Controllers;
    using MyServer.Http;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            :base(request)
        {
        }

        public HttpResponse Index()
            => Text("Hello from Ivo!");

        public HttpResponse LocalRedirect() => Redirect("/Cats");

        public HttpResponse ToSoftUni() => Redirect("https://softuni.bg");

    }
}
