using Microsoft.IdentityModel.Tokens;
using SPA.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA.Domain.Services
{
    public class ProviderService
    {
        private readonly SPA.Domain.ApplicationDbContext _context;

        public ProviderService() {
            if ( this._context == null )
            this._context = new SPA.Domain.ApplicationDbContext();
        }

        public  void show(int id)
        {
           
        }

        public int add(List<Object> data )
        {
            if (data.IsNullOrEmpty()) return -1;
            // Convert the collection to an array
            object[] dataSource = data.ToArray();;
            Provider provider = new Provider {
                Name = dataSource[0].ToString(),
                Phone = dataSource[1].ToString()
            };
            this._context.Providers.Add(provider);
            return this._context.SaveChanges();

        }

        void delete(int id)
        {
            
        }

        void update(Array data, int id)
        {
           
        }
    }
}
