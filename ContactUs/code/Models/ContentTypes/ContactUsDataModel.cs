using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Foundation.GlassMapper.Models;
using Foundation.Lists.Models;

namespace Feature.ContactUs.Models.ContentTypes
{
    [SitecoreType(TemplateId = "{5924CA7B-EE3D-40BB-BC77-D26190F87B38}")]
    public class ContactUsDataModel : SitecoreItemBase
    {
        [SitecoreField(FieldId = "{F962389B-71ED-4741-9264-EF0750FC8D37}")]
        public virtual ListValueItem Icon { get; set; }

        [SitecoreField(FieldId = "{3ED81FD1-91F9-49A9-A045-96D56F1D3CBB}")]
        public virtual string Text { get; set; }

        [SitecoreField(FieldId = "{A9BD1EED-2F49-47AB-9C37-BF72535BCB48}")]
        public virtual Link CTALink { get; set; }

        public string CTALinkLabel => CTALink != null && !string.IsNullOrWhiteSpace(CTALink.Text)
            ? CTALink.Text
            : string.Empty;

        public string CTALinkUrl => CTALink != null && !string.IsNullOrWhiteSpace(CTALink.Url)
            ? CTALink.Url
            : string.Empty;

        public string CTALinkTarget => CTALink != null ? CTALink.Target : string.Empty;

        [SitecoreField(FieldId = "{72964A16-3399-4443-A627-F14809B048AD}")]
        public virtual string VerticalDisplay { get; set; }

        [SitecoreField(FieldId = "{AE678EFF-488C-475F-9B0A-90A62D70E988}")]
        public virtual string WhiteTheme { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<ContactEnquiryDataModel> ContactEnquiries { get; set; }
    }
}