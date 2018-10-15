using System.Linq;
using System.Web.Mvc;

namespace FlixPlay.Episerver.ViewEngines
{
    public class FeatureViewEngine : RazorViewEngine
    {
        public FeatureViewEngine()
        {
            var featureFolderViewLocationFormats = new[]
                {
                    "~/Feature/{0}.cshtml",
                    "~/Feature/{1}/{0}.cshtml",
                    "~/Feature/{1}/{1}.cshtml",
                    "~/Feature/{1}/Views/{0}.cshtml",
                    "~/Feature/{1}/Views/{1}.cshtml",
                    "~/Feature/Shared/{0}.cshtml",
                    "~/Feature/Shared/Views/{0}.cshtml"
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