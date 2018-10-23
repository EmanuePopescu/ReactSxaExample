using Sitecore.XA.Foundation.Mvc.Models;
using Feature.ContactUs.Models.ContentTypes;
using Feature.ContactUs.Models.ViewModels;


namespace Feature.ContactUs.Models.Renderings
{
    public class ContactUsRenderings : RenderingModelBase
    {
        public ContactUsDataModel DataSource { get; set; }

        public ContactUsViewModel ReactViewModel { get; set; }
    }
}