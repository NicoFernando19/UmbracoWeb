using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Migrations;
using Umbraco.Core.Migrations.Upgrade;
using Umbraco.Core.Scoping;
using Umbraco.Core.Services;

namespace Umbraco.Databases
{
    public class EmployeeComponents : IComponent
    {
        private IScopeProvider _scopeProvider;
        private IMigrationBuilder _migrationBuilder;
        private IKeyValueService _keyValueService;
        private ILogger _logger;

        public EmployeeComponents(IScopeProvider scopeProvider, IMigrationBuilder migrationBuilder, IKeyValueService keyValueService, ILogger logger)
        {
            _scopeProvider = scopeProvider;
            _migrationBuilder = migrationBuilder;
            _keyValueService = keyValueService;
            _logger = logger;
        }

        public void Initialize()
        {
            // Create a migration plan for a specific project/feature
            // We can then track that latest migration state/step for this project/feature
            //var migrationPlanDepartment = new MigrationPlan("Department");
            var migrationPlan = new MigrationPlan("Employees");

            // This is the steps we need to take
            // Each step in the migration adds a unique value
            //migrationPlanDepartment.From(string.Empty)
            //    .To<AddDepartmentTable>("department-db");
            migrationPlan.From(string.Empty)
                .To<AddEmployeeTable>("employee-db");

            // Go and upgrade our site (Will check if it needs to do the work or not)
            // Based on the current/latest step
            //var upgraderForDepartment = new Upgrader(migrationPlanDepartment);
            //upgraderForDepartment.Execute(_scopeProvider, _migrationBuilder, _keyValueService, _logger);
            var upgrader = new Upgrader(migrationPlan);
            upgrader.Execute(_scopeProvider, _migrationBuilder, _keyValueService, _logger);
        }

        public void Terminate()
        {
        }
    }
}