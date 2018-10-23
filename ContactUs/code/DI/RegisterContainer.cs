using Glass.Mapper.Sc;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Feature.ContactUs.Repository;

namespace Feature.ContactUs.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISitecoreContext, SitecoreContext>();
            serviceCollection.AddTransient<IContactUsRepository, ContactUsRepository>();
        }
    }
}