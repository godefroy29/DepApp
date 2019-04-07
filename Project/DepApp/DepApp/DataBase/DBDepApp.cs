using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepApp.DataBase
{
    class DBDepApp
    {
        SqlConnection conn = new SqlConnection("Data Source=PC;Initial Catalog=DepApp;Integrated Security=SSPI;");
        //public void Init()
        //{
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Data Source=PC;Initial Catalog=DepApp;User id=sa;Password=Adm1n@29;");
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Data Source=PC;Initial Catalog=DepApp;Integrated Security=SSPI;");
        //}
    }
}
