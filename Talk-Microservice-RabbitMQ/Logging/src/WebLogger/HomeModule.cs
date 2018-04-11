using Nancy;

namespace FP.MdDevDays2018.Logging.WebLogger
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello Magdeburg");
        }
    }
}
