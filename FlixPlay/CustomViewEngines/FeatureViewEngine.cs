using System.Linq;
using System.Web.Mvc;

namespace FlixPlay.CustomViewEngines
{
    public class FeatureViewEngine : RazorViewEngine
    {
        public FeatureViewEngine()
        {
            var featureFolderViewLocationFormats = new[]
                {
                    "~/Features/{0}.cshtml",
                    "~/Features/{1}/{0}.cshtml",
                    "~/Features/{1}/{1}.cshtml",
                    "~/Features/{1}/Views/{0}.cshtml",
                    "~/Features/{1}/Views/{1}.cshtml",
                    "~/Features/Shared/{0}.cshtml",
                    "~/Features/Shared/Views/{0}.cshtml"
                }
                .ToArray();

            ViewLocationFormats =
                ViewLocationFormats.Union(featureFolderViewLocationFormats).ToArray();
            MasterLocationFormats =
                MasterLocationFormats.Union(featureFolderViewLocationFormats).ToArray();
            PartialViewLocationFormats =
                PartialViewLocationFormats.Union(featureFolderViewLocationFormats).ToArray();
        }
    }
}