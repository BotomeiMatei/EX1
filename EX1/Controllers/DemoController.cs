using Microsoft.AspNetCore.Mvc;

namespace EX1.Controllers
{
    public class DemoController : Controller
    {
        [Route("hello")]
        public string Hello() => "Salut!";

        [HttpGet("hello/{name}")]
        public string HelloByName(string name) => $"Salut, {name}!";

        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b) => $"Suma este: {a + b}";

        // TODO: /carti/{an} doar pentru numere întregi

        [HttpGet("carti/{an:int}")]
        public string CartiDupaAn(int an)
        {
            return $"Cărți apărute în {an}";
        }
    }

}
