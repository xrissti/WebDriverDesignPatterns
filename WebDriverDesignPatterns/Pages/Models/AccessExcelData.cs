using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WebDriverDesignPatterns.Pages.Models;

namespace SeleniumDesignPatterns.Models
{
    public class AccessExcelData
    {
        public static string TestDataFileConnection()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = "UserData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + filename);
            return con;
        }

        public static SoftUniUser GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<SoftUniUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

        public static RegistrationExcelUser GetTestDataReg(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [Data$] where key = '{0}'", keyName);
                var value = connection.Query<RegistrationExcelUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
