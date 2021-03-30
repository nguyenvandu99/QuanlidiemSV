using Microsoft.Data.Tools.Schema.Sql.UnitTesting;

namespace Quanlidiemsinhvien
{

    public class SqlDatabaseSetup
    {

  
        public static void InitializeAssembly(TestContext ctx)
        {
            // Setup the test database based on setting in the
            // configuration file
            SqlDatabaseTestClass.TestService.DeployDatabaseProject();
            SqlDatabaseTestClass.TestService.GenerateData();
        }

    }
}
