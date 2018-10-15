using System.Web.Mvc;
using FlixPlay.CustomViewEngines;

namespace FlixPlay
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ViewEngines.Engines.Insert(0, new FeatureViewEngine());
        }
    }
}