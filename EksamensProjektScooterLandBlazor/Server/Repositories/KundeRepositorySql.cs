﻿using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class KundeRepositorySql : IKundeRepository
	{
		MyDbContext db = new MyDbContext();

        public KundeRepositorySql()
        {
            
        }

        private static readonly List<Kunde> Kundeliste;

        public void AddKunde(Kunde kunde)
        {
            db.Kunder.Add(kunde);
            db.SaveChanges();
            Console.WriteLine("saving kunde");
        }

        public bool DeleteKunde(int id)
        {
            var Kunde = db.Kunder.Single(k => k.KundeID == id);

            if (Kunde == null) // hvis kunden ikke eksistere i db så returneres false
            {
                return false;
            }
            db.Kunder.Remove(Kunde);
            db.SaveChanges();
            return true;
        }

        public bool UpdateKunde(Kunde kunde)
        {
            var currentkunde = db.Kunder.Single(k => k.KundeID == kunde.KundeID);
            if (currentkunde == null)
            {
                return false;
            }
            currentkunde.Fornavn = kunde.Fornavn;
            currentkunde.Efternavn = kunde.Efternavn;
            currentkunde.TelefonNummer = kunde.TelefonNummer;
            currentkunde.VejNavn = kunde.VejNavn;
            currentkunde.Email = kunde.Email;
            currentkunde.PreferetMekanikerCprNummer = kunde.PreferetMekanikerCprNummer;
            currentkunde.HusNummer = kunde.HusNummer;
            currentkunde.Etage = kunde.Etage;
            currentkunde.Placering = kunde.Placering;
            currentkunde.PostNummer = kunde.PostNummer;
            currentkunde.ScooterBrandID = kunde.ScooterBrandID;
            db.SaveChanges();
            return true;
        }

        public List<Kunde> GetAllKunder()
        {
            var result = db.Kunder.OrderBy(s=>s.KundeID).Include(i => i.PostNummerOgBy).Include(x=>x.Mekaniker).ThenInclude(l=>l.scooterBrand).ToList();
            return result;
        }

        public Kunde FindKunde(int id)
        {
            var Kunde = db.Kunder.Include(i => i.PostNummerOgBy).Include(x => x.Mekaniker).ThenInclude(y => y.scooterBrand).Single(k => k.KundeID == id);

            if (Kunde != null)
            {
                return Kunde;
            }
            Kunde = new Kunde { KundeID = -1 };
            return new Kunde();
        }

        static KundeRepositorySql()
        {
            Kundeliste = new List<Kunde>();
            Kundeliste.Clear();
        }
    }
}
