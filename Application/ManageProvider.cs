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
    }
}
