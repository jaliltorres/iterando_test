using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_iterando.Models;

namespace web_iterando.Servicios
{
    public class PersonService
    {

        public List<Person> ListPeople()
        {
            using (var context_db = new PersonEntity())
            {
                return context_db.Persons.ToList();
            }
        }

        internal void Crear(Person person)
        {
            using (var context_db = new PersonEntity())
            {
                context_db.Persons.Add(person);
                context_db.SaveChanges();
            }
        }
    }
}