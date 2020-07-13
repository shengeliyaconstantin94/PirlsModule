using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace PISA_TEST
{
    class SQL_Controller
    {
        public static string GetSqlConnectionPath ()
        {

            return ConfigurationSettings.AppSettings["sqlConnectionToPisaDb"];

        }
    }
}
