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
    public class PersonService
    {
        private readonly SPA.Domain.ApplicationDbContext _context;
        public PersonService()
        {
            if (this._context == null)
                this._context = new SPA.Domain.ApplicationDbContext();
        }

        public Person show(int id)
        {
            return this._context.Persons.FirstOrDefault(record => record.Id == id);
        }

        public List<Person> list(IDictionary<string, string> paramsQuery)
        {
            if (paramsQuery.Count == 0)
            {
                return this._context.Persons.ToList();
            }
            else
            {
                var personsFound = this._context.Persons.Where(
                    p => p.LastName.Contains(paramsQuery["LastName"])
                    ).ToList();
                return personsFound;
            }
        }

        public System.ComponentModel.BindingList<Person> bindingList()
        {
            this._context.Persons.Load();
            return this._context.Persons.Local.ToBindingList();
        }

        public int add(List<Object> data)
        {
            if (data.IsNullOrEmpty()) return -1;
            // Convert the collection to an array
            object[] dataSource = data.ToArray(); ;
            Person person = new Person
            {
                Name = dataSource[0].ToString(),
                LastName = dataSource[1].ToString(),
                DNI = dataSource[2].ToString(),
                Email = dataSource[3].ToString()
            };
            this._context.Persons.Add(person);
            return this._context.SaveChanges();

        }

        public int delete(int id)
        {
            var foundPerson = this._context.Persons.Find(id);
            if (foundPerson != null)
            {
                this._context.Persons.Remove(foundPerson);
                return this._context.SaveChanges();
            }
            else
            {
                return -1;
            }
        }

        public int update(List<Object> data)
        {
            if (data.IsNullOrEmpty()) return -1;
            // Convert the collection to an array
            object[] dataSource = data.ToArray();
            var foundPerson = this._context.Persons.FirstOrDefault(e => e.Id == int.Parse(dataSource[0].ToString()));
            if (foundPerson == null) return -1;
            foundPerson.Name = dataSource[1].ToString();
            foundPerson.LastName = dataSource[2].ToString();
            foundPerson.DNI = dataSource[3].ToString();
            foundPerson.Email = dataSource[4].ToString();
            return this._context.SaveChanges();
        }
        public void saveChange()
        {
            this._context.SaveChanges();
        }

    }
}

