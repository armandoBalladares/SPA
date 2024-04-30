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

        public Provider show(int id)
        {
            return this._context.Providers.FirstOrDefault(record => record.Id == id);
        }

        public List<Provider> list( IDictionary<string, string> paramsQuery )
        {
            if (paramsQuery.Count == 0)
            {
                return this._context.Providers.ToList();
            }
            else {
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

        public int update( List<Object> data )
        {
            if (data.IsNullOrEmpty()) return -1;
            // Convert the collection to an array
            object[] dataSource = data.ToArray();
            var foundSupplier = this._context.Providers.FirstOrDefault( e => e.Id == int.Parse(dataSource[0].ToString()) );
            if (foundSupplier == null) return -1;
            foundSupplier.Name = dataSource[1].ToString();
            foundSupplier.Phone = dataSource[2].ToString();
            return this._context.SaveChanges();
        }
        public void saveChange()
        {
            this._context.SaveChanges();
        }
        
    }
}
