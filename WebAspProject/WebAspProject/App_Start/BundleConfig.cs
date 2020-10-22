using System.Web;
using System.Web.Optimization;

namespace WebAspProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Assets/css").Include(
                       "~/Assets/css/bootstrap.min.css",
                       "~/Assets/css/animate.css",
                       "~/Assets/css/owl.carousel.min.css",
                       "~/Assets/css/all.css",
                       "~/Assets/css/flaticon.css",
                       "~/Assets/css/themify-icons.css",
                       "~/Assets/css/magnific-popup.css",
                       "~/Assets/css/slick.css",
                       "~/Assets/css/style.css"));
            bundles.Add(new ScriptBundle("~/Assets/js").Include(
                       "~/Assets/js/jquery.magnific-popup.js",
                       "~/Assets/js/swiper.min.js",
                       "~/Assets/js/mixitup.min.js",
                       "~/Assets/js/owl.carousel.min.js",
                       "~/Assets/js/slick.min.js",
                       "~/Assets/js/jquery.counterup.min.js",
                       "~/Assets/js/waypoints.min.js",
                       "~/Assets/js/contact.js",
                       "~/Assets/js/jquery.ajaxchimp.min.js",
                       "~/Assets/js/jquery.form.js",
                       "~/Assets/js/mail-script.js",
                       "~/Assets/js/custom.js"));
        }
    }
}
