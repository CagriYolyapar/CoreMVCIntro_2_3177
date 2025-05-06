using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro_2.Controllers
{

    //MVC olay güdümlü degil metot güdümlü calısan bir mimari patterndir...

    //MVC'deki Controller icindeki metotlara Action deriz...
    public class DenemeController : Controller
    {

        //Actionlar ya size bir sayfa döndürür ya da sizi baska bir sayfaya yönlendirir...Eger return View(); ile bir Action sonlanıyorsa bu size bir sayfa döndürüyor demektir...return RedirectToAction() ile sonlanıyorsa sizi baska bir Action'a(Dolayısıyla baska bir sayfaya) yonlendiriyor demektir...Ama sakın karıstırmayın View ile Action aynı şeyler asla degildir...

        //Eger bir Action bir sayfayı return View() kodu ile döndürüyorsa Views klasorunde kendisiyle aynı isme denk gelen bir View döndürmeye calısır... Bu View sayfasının isminin Index olması lazım (cünkü Action'imizin ismi Index) ve aynı zamanda bu View sayfasının Views klasorunde ilgili Controller ismindeki bir klasorde bulunması lazım...
        public IActionResult Index()
        {
            //View() metodu eger ona bir string argüman vermezseniz icinde bulundugu Action isminde bir View döndürmeye calısır...
            return View();
        }
    }
}
