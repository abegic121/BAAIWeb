using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-resource.js")
                .Include("~/Scripts/angular-ui.js")
                .Include("~/Scripts/angular-route.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/BAAIMVCApp")
                .Include("~/App/app.routes.js")
                .Include("~/App/app.module.js")
                .IncludeDirectory("~/App/Shared", "*.js", true)
                .IncludeDirectory("~/App/Factories", "*.js", true)
                .IncludeDirectory("~/App/Services", "*.js", true)
                .IncludeDirectory("~/App/Components", "*.js", true));
          
        }
    }
}
