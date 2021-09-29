using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Umbraco.Databases.Entities
{
    [TableName("Employees")]
    [PrimaryKey("Id", AutoIncrement = true)]
    [ExplicitColumns]
    public class Employee
    {
        [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        //[System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; }

        [Column("DoB")]
        public DateTime DoB { get; set; }

        public int DepartmentId { get; set; }
        //public virtual Department department { get; set; }
    }
}