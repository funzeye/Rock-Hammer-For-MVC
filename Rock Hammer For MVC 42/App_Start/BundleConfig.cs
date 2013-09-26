using System.Web;
using System.Web.Optimization;

namespace Rock_Hammer_For_MVC_42
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jsnav").Include(
                        "~/js/navigation-manager.js"//,
                //"~/js/nav-patterns/left-nav-flyout.js",
                //"~/js/nav-patterns/nav-toggle.js",
                //"~/js/nav-patterns/responsive-nav.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/selectivizr").Include(
                        "~/js/vendor/selectivizr-min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //these javascript files go in the head section of the html file -
            //modernizr and JQuery need to be in head as selectivizr needs a loaded
            //library to run in IE8.
            bundles.Add(new ScriptBundle("~/bundles/HeadJavaScripts").Include(
                //"~/js/vendor/head.load.min.js", Only use this in conjuntion with _scripts.cshtml, should also comment out BodyJavaScripts bundle if using this
                        "~/Scripts/modernizr-*",
                        "~/Scripts/jquery-{version}.js"));

            //these javascript files go in the body section of the html file
            bundles.Add(new ScriptBundle("~/bundles/BodyJavaScripts").Include(
                // Plugins    
                        "~/js/vendor/jquery/jquery.scrollTo.min.js",
                // Load bootstrap-transition first so that nice glides/fades 
                // etc for the other bootstrap plugins work
                        "~/js/vendor/bootstrap/bootstrap-transition.js",
                        "~/js/vendor/bootstrap/bootstrap-carousel.js",
                        "~/js/vendor/bootstrap/bootstrap-tooltip.js",
                // Popover has a dependency on tooltip, so make sure and include 
                // bootstrap-tooltip regardless in order for popovers to work
                        "~/js/vendor/bootstrap/bootstrap-popover.js",
                        "~/js/vendor/bootstrap/bootstrap-modal.js",
                        "~/js/vendor/bootstrap/bootstrap-collapse.js",
                // Responsive data tables
                        "~/js/rwd-table.js",
                
                // Remove any navigation patterns below that arent used
                        "~/js/nav-patterns/nav-toggle.js",//,
                        //"~/js/nav-patterns/left-nav-flyout.js",
                        //"~/js/nav-patterns/responsive-nav.min.js",
                        //"~/js/nav-patterns/responsive-breadcrumb.js",

                // Functionality only used by Rock Hammer - this should be removed in production projects!
                        "~/js/navigation-manager.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/Scss").Include("~/Content/css/rock-hammer.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}