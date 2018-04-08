using System;

namespace FP.MdDevDays2018.BuildOutside.Modules
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Magdeburger Developer Days - {DateTime.Now}");
        }
    }
}
