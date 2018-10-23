using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore;
using Sitecore.Data.Fields;
using Foundation.GlassMapper.Models;
using Foundation.Lists.Models;

namespace Feature.ContactUs.Models.ContentTypes
{
    [SitecoreType(TemplateId = "{928F16B2-BA89-4C9F-B688-8C3B7655E3FB}")]
    public class ContactEnquiryDataModel : SitecoreItemBase
    {
        [SitecoreField(FieldId = "{5346F793-6E15-4E81-BEF9-EC8D65C68A5B}")]
        public virtual string Title { get; set; }

        [SitecoreField(FieldId = "{673B39C8-9935-4C1D-8762-9973F01914E5}")]
        public virtual string PhoneNumber { get; set; }

        [SitecoreField(FieldId = "{1662809B-FB20-4984-BFC7-2800C8234954}")]
        public virtual IEnumerable<ListKeyValueItem> OpeningTimes { get; set; }

    }
}