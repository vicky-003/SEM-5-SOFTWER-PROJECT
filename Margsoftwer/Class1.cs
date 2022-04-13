using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Margsoftwer
{
    class Class1
    {
        public static SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\softwer.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    }
}
