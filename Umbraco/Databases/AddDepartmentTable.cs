using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Migrations;
using Umbraco.Databases.Entities;
using Umbraco.Core.Logging;

namespace Umbraco.Databases
{
    public class AddDepartmentTable : MigrationBase
    {
        public AddDepartmentTable(IMigrationContext context) : base(context)
        {
        }

        public override void Migrate()
        {

            Logger.Debug<AddDepartmentTable>("Running migration {MigrationStep}", "AddDepartmentTable");

            // Lots of methods available in the MigrationBase class - discover with this.
            if (TableExists("Department") == false)
            {
                Create.Table<Department>().Do();
            }
            else
            {
                Logger.Debug<AddDepartmentTable>("The database table {DbTable} already exists, skipping", "Department");
            }
        }

    }
}