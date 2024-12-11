using NUnit.Framework;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Pages;
using EksamensProjektScooterLandBlazor.Server.Repositories;

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


        [Test]
        public void TestMandeTimerSum()
        {
            // Arrange

            // ny instans af klassen med metoden BeregnMandeTimer
            OrdreLinjePage ordreLinjePage = new OrdreLinjePage();

            // her opstilles mock-data til at teste metoden
            List<OrdreLinje> OrdrelinjeListe = new List<OrdreLinje>
            {
                new OrdreLinje { YdelseID = 1, ydelse = new Ydelse { YdelseID = 1, EstimeretTid = 3 }, Antal = 1 },
                new OrdreLinje { YdelseID = 2 ,ydelse = new Ydelse { YdelseID = 2, EstimeretTid = 1 }, Antal = 1 },
                new OrdreLinje { YdelseID = 3, ydelse = new Ydelse { YdelseID = 3, EstimeretTid = 2 }, Antal = 2 }
            };

            double ExpectResult = 8;

            // Act
            double AcutalResult = ordreLinjePage.BeregnMandetimer(OrdrelinjeListe);


            // Assert
            Assert.AreEqual(ExpectResult, AcutalResult, "BeregnMandeTimer skal returnere summen af mandetimer");
        
        }

        [Test]
        public void TestMandeTimerSumInCorrectSum()
        {
            // Arrange

            // ny instans af klassen med metoden BeregnMandeTimer
            OrdreLinjePage ordreLinjePage = new OrdreLinjePage();

            // her opstilles mock-data til at teste metoden
            List<OrdreLinje> OrdrelinjeListe = new List<OrdreLinje>
            {
                new OrdreLinje { YdelseID = 1, ydelse = new Ydelse { YdelseID = 1, EstimeretTid = 3 }, Antal = 1 },
                new OrdreLinje { YdelseID = 2 ,ydelse = new Ydelse { YdelseID = 2, EstimeretTid = 1 }, Antal = 1 },
                new OrdreLinje { YdelseID = 3, ydelse = new Ydelse { YdelseID = 3, EstimeretTid = 2 }, Antal = 2 }
            };

            double ExpectResult = 1;

            // Act
            double AcutalResult = ordreLinjePage.BeregnMandetimer(OrdrelinjeListe);


            // Assert
            Assert.AreNotEqual(ExpectResult, AcutalResult, "BeregnMandeTimer skal returnere summen af mandetimer");

        }

    
        [Test]
        public void TestBeregnCorrectSum()
        {
			// Arrange

			OrdreLinjePage ordreLinjePage = new OrdreLinjePage();

			// her opstilles mock-data til at teste metoden
			List<OrdreLinje> OrdrelinjeListe = new List<OrdreLinje>
            {
              new OrdreLinje { ProduktID = 1, produkt = new Produkt { ProduktPris = 300 }, Antal = 2, RabatProcent = 10 },
              new OrdreLinje { YdelseID = 2, ydelse = new Ydelse { Pris = 200 }, Antal = 1, RabatProcent = 10 },
              new OrdreLinje { ScooterLejeID = 1, scooterLeje = new ScooterLeje {DagsLejePris = 100,ForsikringPrKm = 0.53, SelvRisiko = 1000},
                  Antal = 3,AntalEkstra = 50, SelvrisikoBool = true, RabatProcent = 0}
            };

            //tilføj mock data til OrdrelinjeListen 
            ordreLinjePage.ordreLinjeListe = OrdrelinjeListe;

            double ExpectResult = (300 * 2 * 0.9) + (200 * 1 * 0.9) + ((100 * 3) + (50 * 0.53)+1000);

			// Act
			double AcutalResult = ordreLinjePage.BeregnSum();

			// Assert
			Assert.AreEqual(ExpectResult, AcutalResult, "BeregnSum skal returnere sum baseret på ordrelinjer.");
        }



        [Test]
        public void TestBeregnInCorrectSum()
        {
			// Arrange

			OrdreLinjePage ordreLinjePage = new OrdreLinjePage();

			// her opstilles mock-data til at teste metoden
			List<OrdreLinje> OrdrelinjeListe = new List<OrdreLinje>
			{
			  new OrdreLinje { ProduktID = 1, produkt = new Produkt { ProduktPris = 300 }, Antal = 2, RabatProcent = 10 },
			  new OrdreLinje { YdelseID = 2, ydelse = new Ydelse { Pris = 200 }, Antal = 1, RabatProcent = 10 },
			  new OrdreLinje { ScooterLejeID = 1, scooterLeje = new ScooterLeje {DagsLejePris = 100,ForsikringPrKm = 0.53, SelvRisiko = 1000},Antal = 3,AntalEkstra = 50, SelvrisikoBool = true, RabatProcent = 0}
			};

			//tilføj mock data til OrdrelinjeListen. 
			ordreLinjePage.ordreLinjeListe = OrdrelinjeListe;

            double ExpectResult = 10;


			// Act
			double ActualResult = ordreLinjePage.BeregnSum();
			// Assert
			Assert.AreNotEqual(ExpectResult, ActualResult, "BeregnSum should return the correct sum based on the order lines.");
        }

    }
}