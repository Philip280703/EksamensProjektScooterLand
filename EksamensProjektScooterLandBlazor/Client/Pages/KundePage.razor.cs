using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components;
namespace EksamensProjektScooterLandBlazor.Client.Pages
{
	public partial class KundePage
	{
		private List<Kunde> kundeListe = new List<Kunde>();
		public int ErrorCode { get; set; }

		[Inject]
		public IKundeService Service { get; set; }

		protected override async Task OnInitializedAsync()
		{
			kundeListe = (await Service.GetAllKunder()).ToList();
		}

		public async void Seeddata()
		{
			var kunder = new List<Kunde>
			{
				new Kunde
				{
					Fornavn = "Anders",
					Efternavn = "Hansen",
					ScooterBrandID = 1,
					TelefonNummer = "12345678",
					Email = "anders.hansen@example.com",
					PostNummer = 8000,
					VejNavn = "Hovedgaden",
					HusNummer = "1A",
					PreferetMekanikerCprNummer = "2904881243"
				},
				new Kunde
				{
					Fornavn = "Birgitte",
					Efternavn = "Jensen",
					ScooterBrandID = 2,
					TelefonNummer = "87654321",
					Email = "birgitte.jensen@example.com",
					PostNummer = 2100,
					VejNavn = "Strandvejen",
					HusNummer = "10",
					PreferetMekanikerCprNummer = "1210939857"
				},
				new Kunde
				{
					Fornavn = "Christian",
					Efternavn = "Nielsen",
					ScooterBrandID = 3,
					TelefonNummer = "45678912",
					Email = "christian.nielsen@example.com",
					PostNummer = 5000,
					VejNavn = "Bakkegade",
					HusNummer = "15B",
					PreferetMekanikerCprNummer = "1602650329"
				},
				new Kunde
				{
					Fornavn = "Ditte",
					Efternavn = "Larsen",
					ScooterBrandID = 1,
					TelefonNummer = "56789123",
					Email = "ditte.larsen@example.com",
					PostNummer = 9000,
					VejNavn = "Engvej",
					HusNummer = "22",
					PreferetMekanikerCprNummer = "2904881243"
				},
				new Kunde
				{
					Fornavn = "Emil",
					Efternavn = "Poulsen",
					ScooterBrandID = 2,
					TelefonNummer = "78912345",
					Email = "emil.poulsen@example.com",
					PostNummer = 8700,
					VejNavn = "Skovvej",
					HusNummer = "4",
					PreferetMekanikerCprNummer = "1210939857"
				},
				new Kunde
				{
					Fornavn = "Freja",
					Efternavn = "Christensen",
					ScooterBrandID = 3,
					TelefonNummer = "89123456",
					Email = "freja.christensen@example.com",
					PostNummer = 8000,
					VejNavn = "Søndergade",
					HusNummer = "18",
					PreferetMekanikerCprNummer = "3007006845"
				},
				new Kunde
				{
					Fornavn = "Gustav",
					Efternavn = "Mortensen",
					ScooterBrandID = 1,
					TelefonNummer = "91234567",
					Email = "gustav.mortensen@example.com",
					PostNummer = 5000,
					VejNavn = "Vestergade",
					HusNummer = "7C",
					PreferetMekanikerCprNummer = "2904881243"
				},
				new Kunde
				{
					Fornavn = "Hanne",
					Efternavn = "Olsen",
					ScooterBrandID = 2,
					TelefonNummer = "23456789",
					Email = "hanne.olsen@example.com",
					PostNummer = 4000,
					VejNavn = "Østergade",
					HusNummer = "5",
					PreferetMekanikerCprNummer = "1210939857"
				},
				new Kunde
				{
					Fornavn = "Ida",
					Efternavn = "Jørgensen",
					ScooterBrandID = 3,
					TelefonNummer = "34567891",
					Email = "ida.joergensen@example.com",
					PostNummer = 6000,
					VejNavn = "Møllevej",
					HusNummer = "12A",
					PreferetMekanikerCprNummer = "1602650329"
				},
				new Kunde
				{
					Fornavn = "Jakob",
					Efternavn = "Thomsen",
					ScooterBrandID = 1,
					TelefonNummer = "45678912",
					Email = "jakob.thomsen@example.com",
					PostNummer = 2200,
					VejNavn = "Bygaden",
					HusNummer = "3B",
					PreferetMekanikerCprNummer = "2904881243"
				},
				new Kunde
				{
					Fornavn = "Karen",
					Efternavn = "Knudsen",
					ScooterBrandID = 2,
					TelefonNummer = "56789123",
					Email = "karen.knudsen@example.com",
					PostNummer = 2300,
					VejNavn = "Lindevangen",
					HusNummer = "8",
					PreferetMekanikerCprNummer = "1210939857"
				},
				new Kunde
				{
					Fornavn = "Lars",
					Efternavn = "Vestergaard",
					ScooterBrandID = 3,
					TelefonNummer = "67891234",
					Email = "lars.vestergaard@example.com",
					PostNummer = 7100,
					VejNavn = "Nørregade",
					HusNummer = "24",
					PreferetMekanikerCprNummer = "3007006845"
				},
				new Kunde
				{
					Fornavn = "Marie",
					Efternavn = "Petersen",
					ScooterBrandID = 1,
					TelefonNummer = "78912345",
					Email = "marie.petersen@example.com",
					PostNummer = 8000,
					VejNavn = "Lyngvej",
					HusNummer = "30",
					PreferetMekanikerCprNummer = "2904881243"
				},
				new Kunde
				{
					Fornavn = "Niels",
					Efternavn = "Andersen",
					ScooterBrandID = 2,
					TelefonNummer = "89123456",
					Email = "niels.andersen@example.com",
					PostNummer = 4000,
					VejNavn = "Kirkegade",
					HusNummer = "1",
					PreferetMekanikerCprNummer = "1210939857"
				},
				new Kunde
				{
					Fornavn = "Olivia",
					Efternavn = "Frederiksen",
					ScooterBrandID = 3,
					TelefonNummer = "91234567",
					Email = "olivia.frederiksen@example.com",
					PostNummer = 5000,
					VejNavn = "Rosenvej",
					HusNummer = "6",
					PreferetMekanikerCprNummer = "1602650329"
				}
			};

			foreach(var kunde in kunder)
			{
				ErrorCode = await Service.AddKunde(kunde);
                Console.WriteLine("Kunde tilføjet: return code: " + ErrorCode);
			}
		}
	}
}
