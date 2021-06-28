using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UNLZ_Consulting_ABM
{
    class ConexionDB
    { 
        public static SqlConnection Conection()
        {
            SqlConnection Conn = new SqlConnection("SERVER=DESKTOP-B2CNAUR\SQL2014;DATABASE=UNLZ-consulting-AMB;integrated security=true;");
            Conn.Open();
            return Conn;

        }
    
    }

}
