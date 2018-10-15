using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ShopFloor.Data.Helpers
{
    public class DalHelper
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ShopFloorData"].ConnectionString;

    }
}
