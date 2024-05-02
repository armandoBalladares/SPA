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
    public class ManagePerson
    {

        PersonService? personService = null;
        public ManagePerson()
        {
            if (this.personService == null)
                this.personService = new PersonService();

        }
        public int add(Collection<Object> data)
        {
            return personService.add(data.ToList());
        }
        public List<Person> list(IDictionary<string, string> paramsQuery)
        {
            return personService.list(paramsQuery);
        }
        public System.ComponentModel.BindingList<Person> bindingList()
        {
            return this.personService.bindingList();
        }
        public int delete(int id)
        {
            return this.personService.delete(id);
        }
        public void saveChange()
        {
            this.personService.saveChange();
        }
        public int update(Collection<Object> data)
        {
            return personService.update(data.ToList());
        }
        public Person show(int identifier)
        {
            return personService.show(identifier);
        }
    }
}
