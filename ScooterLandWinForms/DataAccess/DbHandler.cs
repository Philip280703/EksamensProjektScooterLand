using Microsoft.Data.SqlClient;
using ScooterLandWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterLandWinForms.DataAccess
{
    public class DbHandler
    {
        string ConnectionString;
        public DbHandler() 
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ToString();
        }

        

        internal List<UsbClass> GetUsbList()
        {
            List<UsbClass> UsbList = new List<UsbClass>();

            string command = "select * from UsbTable";

            using SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(command, conn);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["nameOfUsb"];
                    bool LastUsed = (bool)reader["LastUsed"];

                    UsbClass usbObjekt = new UsbClass
                    {
                        id = id,
                        Name = name,
                        LastUsed = LastUsed
                    };

                    UsbList.Add(usbObjekt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return UsbList;

        }
    }
}
