using System.Web.Mvc;
using Sitecore.Mvc.Controllers;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Feature.ContactUs.Repository;

namespace Feature.ContactUs.Controllers
{
    public class ContactUsController : StandardController
    {
        private readonly IContactUsRepository _repository;

        public ContactUsController(IContactUsRepository repository)
        {
            _repository = repository;
        }

        public override ActionResult Index()
        {
            var model = _repository.GetModel();
            if (IsEdit)
            {
                return View("Index.Edit", model);
            }
            return View(model);
        }
    }
}