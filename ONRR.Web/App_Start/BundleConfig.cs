using System.Web.Optimization;

namespace QEP.ONRR.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // The following line will force bundling even when < compilation debug = "true" />.
            //BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery.cookie.js",
                "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            // The Kendo JavaScript bundle
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/2015.3.930/kendo.all.min.js", // or kendo.all.* if you want to use Kendo UI Web and Kendo UI DataViz
                "~/Scripts/kendo/2015.3.930/kendo.aspnetmvc.min.js"));

            // Using non minified version below for now to make debugging easier
            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //    "~/Content/kendo/2015.3.930/kendo.common.min.css",
            //    "~/Content/kendo/2015.3.930/kendo.default.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                "~/Content/kendo.common.css",
                "~/Content/kendo.default.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

        }
    }
}
