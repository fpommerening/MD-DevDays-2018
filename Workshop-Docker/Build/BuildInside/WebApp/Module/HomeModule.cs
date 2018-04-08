using System;

namespace FP.MdDevDays2018.BuildInside.Module
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Magdeburger Developer Days - {DateTime.Now}");
        }
    }
}
