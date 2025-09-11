using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Weather.Commons
{
    public class DatabaseProvider
    {

        // static contructor of this class
        static DatabaseProvider()
        {
            ADF_Db = new SqlDatabase("Server=tcp:sqlserv-poc-us-001.database.windows.net,1433;Initial Catalog=ADF;Persist Security Info=False;User ID=adminuser;Password=Pa55word#;");
        }

        /// <summary>
        /// Provider to {ADF_Db} database 
        /// </summary>
        public static Database ADF_Db { get; private set; } = null;

    }
}
