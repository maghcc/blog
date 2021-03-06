﻿using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace SC81.Sandbox.CustomProcessors
{
    public class RegisterCustomRoute : Sitecore.Mvc.Pipelines.Loader.InitializeRoutes
    {

        public override void Process(PipelineArgs args)
        {

            RouteTable.Routes.MapRoute("ExternalRoute",
                "external/{controller}/{action}/{id}", // URL with parameters
                 new { id = UrlParameter.Optional });

            RouteTable.Routes.MapRoute("CommunityRoute",
                "community/{controller}/{action}/{id}", // URL with parameters
                 new { id = UrlParameter.Optional });

        }
        
    }
}