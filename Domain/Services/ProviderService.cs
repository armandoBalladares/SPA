using Microsoft.EntityFrameworkCore;
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

        public List<Provider> list( IDictionary<string, string> paramsQuery )
        {
            if (paramsQuery.Count == 0)
            {
                return this._context.Providers.ToList();
            }
            else {
                MessageBox.Show("tiene que buscar");
                var productsFound = this._context.Providers.Where(
                    p => p.Name.Contains(paramsQuery["Name"])
                    ).ToList();
                return productsFound;
            }
        }
        
        public System.ComponentModel.BindingList<Provider> bindingList( ) {
            this._context.Providers.Load();
            return this._context.Providers.Local.ToBindingList();
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

        public int delete(int id)
        {
            var foundProvider = this._context.Providers.Find(id);
            if (foundProvider != null)
            {
                this._context.Providers.Remove(foundProvider);
                return this._context.SaveChanges();
            }
            else
            {
                return -1;
            }
        }

        void update(Array data, int id)
        {
           
        }
        public void saveChange()
        {
            this._context.SaveChanges();
        }
        
    }
}
