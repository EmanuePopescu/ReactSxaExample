using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using Foundation.SitecoreExtensions.Extensions;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Feature.ContactUs.Constants;
using Feature.ContactUs.Models.ContentTypes;
using Feature.ContactUs.Models.ViewModels;
using Feature.ContactUs.Models.Renderings;

namespace Feature.ContactUs.Repository
{
    public class ContactUsRepository : ModelRepository, IContactUsRepository
    {
        private readonly ISitecoreContext _sitecoreContext;

        public ContactUsRepository(ISitecoreContext sitecoreContext)
        {
            _sitecoreContext = sitecoreContext;
        }

        public override IRenderingModelBase GetModel()
        {
            var model = new ContactUsRenderings();
            FillBaseProperties(model);
            var item = RenderingContext.Current?.Rendering?.Item;
            if (item != null && item.IsDerived(ContactUsConstants.TemplateId))
            {
                model.DataSource = _sitecoreContext.GetItem<ContactUsDataModel>(item.ID.Guid);
                model.ReactViewModel = CreateReactModel(model.DataSource);
                return model;
            }
            return null;
        }

        private ContactUsViewModel CreateReactModel(ContactUsDataModel contactus)
        {
            var contactEnquiries = new List<ContactEnquiryViewModel>();
            var ctaSection = new CtaSectionViewModel();

            if (contactus.ContactEnquiries != null && contactus.ContactEnquiries.Any())
            {
                foreach (var enquiry in contactus.ContactEnquiries)
                {
                    var openings = new List<OpeningTimesViewModel>();

                    foreach (var opening in enquiry.OpeningTimes)
                    {
                        var thisOpenings = new OpeningTimesViewModel
                        {
                            Days = opening.Key,
                            Times = opening.Value
                        };

                        openings.Add(thisOpenings);
                    }

                    var thisEnquiry = new ContactEnquiryViewModel
                    {
                        Title = enquiry.Title,
                        Phone = enquiry.PhoneNumber,
                        OpeningTimes = openings
                    };

                    contactEnquiries.Add(thisEnquiry);
                }
                
                var thisCtaSection = new CtaSectionViewModel
                {
                    IconClass = contactus.Icon != null ? contactus.Icon.Value : string.Empty,
                    Text = contactus.Text,
                    CTALink = contactus.CTALink != null && (contactus.CTALink != null || !string.IsNullOrEmpty(contactus.CTALink.Url))
                        ? contactus.CTALink.Url : string.Empty,
                    CTAText = contactus.CTALink != null && (contactus.CTALink != null || !string.IsNullOrEmpty(contactus.CTALink.Text))
                        ? contactus.CTALink.Text : string.Empty
                };

                ctaSection = thisCtaSection;
            }

            return new ContactUsViewModel
            {
                WhiteTheme = contactus.WhiteTheme.Equals("1"),
                VerticalDisplay = contactus.VerticalDisplay.Equals("1"),
                ContactEnquiries = contactEnquiries,
                CTASection = ctaSection
            };
        }
    }
}