using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Migrations;
using Umbraco.Databases.Entities;
using Umbraco.Core.Logging;

namespace Umbraco.Databases
{
    public class AddEmployeeTable : MigrationBase
    {
        public AddEmployeeTable(IMigrationContext context) : base(context)
        {
        }

        public override void Migrate()
        {

            Logger.Debug<AddEmployeeTable>("Running migration {MigrationStep}", "AddEmployeeTable");

            // Lots of methods available in the MigrationBase class - discover with this.
            if (TableExists("Employees") == false)
            {
                Create.Table<Employee>().Do();
            }
            else
            {
                Logger.Debug<AddEmployeeTable>("The database table {DbTable} already exists, skipping", "Employee");
            }
        }
    }
}