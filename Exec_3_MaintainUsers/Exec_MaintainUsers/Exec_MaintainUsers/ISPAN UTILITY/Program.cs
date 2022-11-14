using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISPAN_UTILITY
{


    public class sqlparameterHelper 
    { 
    
        private List<SqlParameter>sqlParameters = new List<SqlParameter>();

        public sqlparameterHelper AddNvarchar(string name , string account , string password , int height)
        {
            var param = new SqlParameter(name, SqlDbType.NVarChar, lengt) { Value = value };
            parameters.Add(param);
            return this;

        }


    }



}
