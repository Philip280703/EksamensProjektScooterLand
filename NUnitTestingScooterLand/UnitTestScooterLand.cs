using NUnit.Framework;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace NUnitTestingScooterLand
{
    public class Tests
    {
       
        private string connectionString;
        [SetUp]
        public void Setup()
        {
            // connectionstring til server databasen
            connectionString = "Server=ucl2024.database.windows.net; Database=ScooterLandDB; User Id=Camacho; Password=sologsommer2022+";
		}

        [Test]
        public void TestDatabaseConn()
        {
            //Arrange
            bool connSucces = false;

            //Act
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connSucces = true;
                }
                catch (Exception ex) 
                { 
                    Assert.Fail(ex.Message);
                }
            }

            //Assert
            Assert.IsTrue(connSucces, "Database connection is succesful.");
        }





    }
}