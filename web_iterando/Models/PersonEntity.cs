using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_iterando.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class PersonEntity: DbContext
    {
        public PersonEntity()
            :base("Conn")
        {

        }
        //<Person> Model
        //Persons Table
        public DbSet<Person> Persons { get; set; } 
    }
}