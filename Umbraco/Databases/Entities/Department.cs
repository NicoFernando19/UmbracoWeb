using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Umbraco.Databases.Entities
{
    [TableName("Department")]
    [PrimaryKey("Id", AutoIncrement = true)]
    [ExplicitColumns]
    public class Department
    {
        [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }
}