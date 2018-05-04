using System.Web.Optimization;

namespace NewParticleArray
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //javascript
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/popupPlayer").Include("~/Scripts/popupPlayer.js"));

            //css
            bundles.Add(new StyleBundle("~/Content/maincss").Include("~/Content/css/main.css", "~/Content/css/nav.css"));
            bundles.Add(new StyleBundle("~/Content/slideshowcss").Include("~/Content/css/slideshow.css"));
            bundles.Add(new StyleBundle("~/Content/videocss").Include("~/Content/css/video.css"));
            bundles.Add(new StyleBundle("~/Content/formcss").Include("~/Content/css/form.css"));
            bundles.Add(new StyleBundle("~/Content/popupplayercss").Include("~/Content/css/popupPlayer.css"));
        }
    }
}
