﻿using System;
using Microsoft.Extensions.Configuration;

namespace FP.MdDevDays2018.Configs.Module
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule(IConfiguration cfg)
        {
            Get("/", _ => $" Config-Sample {DateTime.Now:G} \n {cfg["greeting"]}");
        }
    }
}
