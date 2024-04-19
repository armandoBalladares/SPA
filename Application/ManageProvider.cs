using SPA.Domain.Entity;
using SPA.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA.Application
{
    public class ManageProvider
    {
        ProviderService? providerService = null;
        public ManageProvider() {
            if (this.providerService == null)
                this.providerService = new ProviderService();
           
        } 
        public int add(Collection<Object> data )
        {
            return providerService.add( data.ToList() );
        }
        public List<Provider> list(IDictionary<string, object> paramsQuery )
        {
            return providerService.list( paramsQuery);
        }
        public System.ComponentModel.BindingList<Provider> bindingList()
        {
            return this.providerService.bindingList();
        }
    }
}
