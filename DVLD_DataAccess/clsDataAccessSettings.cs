using System;
using System.Configuration;

namespace DVLD_DataAccess
{
    static class clsDataAccessSettings
    {
        //public static string ConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=123456;";
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];


    }
}
