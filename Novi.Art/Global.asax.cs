using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Novi.Art
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() // This methode fires when the application first starts up. 
        {
            AreaRegistration.RegisterAllAreas(); // areas are another way to organize related functionality in an MVC5 application into groups for routing and file organization purposes 
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); //Is running code that's defined in this project by a file located in the app start folder: FilterConfig.cs. FilterConfig.cs adds filters that we want added globally to all controller actions on our project.
            RouteConfig.RegisterRoutes(RouteTable.Routes); // The RouteConfig-class is code that points to App_Start/RouteConfig.cs
            BundleConfig.RegisterBundles(BundleTable.Bundles); //Bundles are a way to combine static resources, such as Java Script and CSS files into a single download for performance reasons. There are both script and style bundles and when you define either, you give it a path that it will respond to
        }
    }
}

// Application and session events:
// Application_Init
// Application_start
// Application_End
// Application_Error
// Application_BeginRequest
// Application_EndRequest
// Application_PreRequestHandlerExecute
// Application_PostRequestHandlerExecute
// Application_AuthenticateRequest
// Application_AutorizeRequest
// Session_PreSendRequestHeaders
// Session_PreSendContent
// Session_AcquireRequestState
// Session_ReleaseRequestState
// Session_ResolveRequestCache
// Session_UpdateRequestCache
// Session_Start
// Session_End

// Add a methode with one of these names to the global.asax file
// But it is rarely needed to use these
