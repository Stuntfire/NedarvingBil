using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NedarvingBil
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Når bil klassen er abstract kan et nyt objekt ikke kaldes.
            //Bil nyBil = new Bil(200000);

            List<DieselBil> dbList = new List<DieselBil>();

            DieselBil dbBil1 = new DieselBil("Volvo", 500000, 2014, "BC50010", 10, false);
            DieselBil dbBil2 = new DieselBil("Renault", 80000, 2014, "AC50010", 50, false);
            DieselBil dbBil3 = new DieselBil("Ford", 10000000, 2010, "XO20010", 60, true);

            DieselBil dbBil4 = new DieselBil("Mercedes", 10000000, 2016, "YO90010", 70);
            DieselBil dbBil5 = new DieselBil("Volkswagen", 500000, 2016, "DO80010", 90);

            dbList.Add(dbBil1);
            dbList.Add(dbBil2);
            dbList.Add(dbBil3);
            dbList.Add(dbBil4);
            dbList.Add(dbBil5);

            foreach (DieselBil db in dbList)
            {
                Console.WriteLine(db);
            }


            foreach (DieselBil db in dbList)
            {
                Console.WriteLine($"Den halvårige ejer afgift er: {db.HalvÅrligEjerafgift()} og afgiften er: {db.GetRegistreringsAfgift()} kr");
            }

           // DieselBil dieselbil = new DieselBil();
           //// dieselbil.Partikelfilter = true;
           // BenzinBil benzinbil = new BenzinBil();
           // benzinbil.Octan = 98;

           // List<BenzinBil> listeBenzinbiler = new List<BenzinBil>();
           // List<DieselBil> listDieselbiler = new List<DieselBil>();


           // // I denne liste kan man kun se de props som ligger i Bil klassen.
           // List<Bil> bilListePol = new List<Bil>();

           // bilListePol.Add(dieselbil);
           // bilListePol.Add(benzinbil);

           // foreach (Bil bil  in bilListePol)
           // {
           //    //test på hvad de er.
           //     Console.WriteLine(bil.HvilkenBilErJeg());

           //     //Når overrider hvilkenBilErjeg i de specialiserede klasser 
           //     //så gælder det og ikke metoden fra base klassen.

           //     Console.WriteLine(bilitem.HVilkenBilErjeg());

           //     //polymorfisme, is and as

           //     //if (bil is DieselBil)
           //     //{
           //     //    //Her castes bil objekt 
           //     //    DieselBil dieselbil1 = bil as DieselBil;

           //     //    Console.WriteLine(dieselbil1.Partikelfilter);
           //     //}
           //     //else if (bil is BenzinBil)
           //     //{
           //     //    //Her castes bill objektet til at være en benzinbil og derfor kan vi nu se properties.
           //     //    BenzinBil benzinbil1 = bil as BenzinBil;
           //     //    Console.WriteLine(benzinbil1.Octan);
           //     //}
           // }


           // //var bilListe = new List<Bil>();
           // //bilListe.Add(new DieselBil());
           // //bilListe.Add(new BenzinBil());
           // //foreach (var bil in bilListe)
           // //{
           // //    Console.WriteLine(bil.HvilkenbilErJeg());

           // //    if (true)
           // //    {

           // //    }
           // //}


            Console.ReadLine();

        }
    }
}
