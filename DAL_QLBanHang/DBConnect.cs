﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=MinhhKunn\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //protected SqlConnection _conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //static string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
        //protected  SqlConnection _conn = new SqlConnection(@"Data Source=MinhhKunn\SQLEXPRESS; AttachDbFilename=QLBanHang; Integrated Security=True");
        //protected SqlConnection _conn = new SqlConnection(strConnection);
    } 
}
