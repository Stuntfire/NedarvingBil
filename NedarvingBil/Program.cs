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

            DieselBil dbBil1 = new DieselBil("Volvo", 100000, 2014, "C50010", 10, false, 20);
            DieselBil dbBil2 = new DieselBil("Renault", 80000, 2014, "AC50010", 50, false, 30);
            DieselBil dbBil3 = new DieselBil("Ford", 10000000, 2010, "XO20010", 60, true, 50);

            DieselBil dbBil4 = new DieselBil("Mercedes", 10000000, 2016, "YO90010", 70, 20);
            DieselBil dbBil5 = new DieselBil("Volkswagen", 500000, 2016, "DO80010", 90, 30);

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
                Console.WriteLine($"Den halvårige ejer afgift er: {db.HalvÅrligEjerafgift()} og afgiften er: {db.GetRegistreringsAfgift()} kr og rækkevidden er: {db.GetRækkeVidde()}");
            }

            List<BenzinBil> bbList = new List<BenzinBil>();

            BenzinBil bbBil1 = new BenzinBil("Peugot", 100000, 1990, "FK40010", 10,50);
            BenzinBil bbBil2 = new BenzinBil("Ford", 70000, 1999, "FN40060", 30, 40);
            BenzinBil bbBil3 = new BenzinBil("KIA", 50000, 2015, "HN80030", 5, 30);
            BenzinBil bbBil4 = new BenzinBil("Nero", 1000000, 2014, "SD50020", 70, 60);
            BenzinBil bbBil5 = new BenzinBil("Paganie", 7000000, 2010, "AS10010", 25, 15);

            bbList.Add(bbBil1);
            bbList.Add(bbBil2);
            bbList.Add(bbBil3);
            bbList.Add(bbBil4);
            bbList.Add(bbBil5);

            foreach (BenzinBil bb in bbList)
            {
                Console.WriteLine(bb);
            }

            foreach (BenzinBil bb in bbList)
            {
                Console.WriteLine($"Den halvårige ejer afgift er: {bb.HalvÅrligEjerafgift()} og afgiften er: {bb.GetRegistreringsAfgift()} kr og rækkevidden er: {bb.GetRækkeVidde()}");
            }

            List<ElBil> ebList = new List<ElBil>();

            ElBil ebBil1 = new ElBil("Tesla", 1000000, 2016, "HD30010", 5, 30);
            ElBil ebBil2 = new ElBil("Tesla", 1000000, 2010, "FD60010", 3, 30);
            ElBil ebBil3 = new ElBil("Nissan", 500000, 2011, "PK90010", 2, 20);
            ElBil ebBil4 = new ElBil("Ford", 1000000, 2014, "KG20010", 6, 40);
            ElBil ebBil5 = new ElBil("Tesla", 5000000, 2015, "LL90010", 8, 40);

            ebList.Add(ebBil1);
            ebList.Add(ebBil2);
            ebList.Add(ebBil3);
            ebList.Add(ebBil4);
            ebList.Add(ebBil5);

            foreach (ElBil eb in ebList)
            {
                Console.WriteLine(eb);
            }

            foreach (ElBil eb in ebList)
            {
                Console.WriteLine($"Den halvårige ejer afgift er: {eb.HalvÅrligEjerafgift()} og afgiften er: {eb.GetRegistreringsAfgift()} kr og rækkevidden er: {eb.GetRækkeVidde()}");
            }

            List<IBil> bilListePol = new List<IBil>();

            bilListePol.Add(dbBil1);
            bilListePol.Add(dbBil2);
            bilListePol.Add(dbBil3);
            bilListePol.Add(dbBil4);
            bilListePol.Add(dbBil5);

            bilListePol.Add(bbBil1);
            bilListePol.Add(bbBil2);
            bilListePol.Add(bbBil3);
            bilListePol.Add(bbBil4);
            bilListePol.Add(bbBil5);

            bilListePol.Add(ebBil1);
            bilListePol.Add(ebBil2);
            bilListePol.Add(ebBil3);
            bilListePol.Add(ebBil4);
            bilListePol.Add(ebBil5);

            //polymorfisme, is and as

            foreach (Bil bil in bilListePol)
            {
                if (bil is IelMotor)
                {
                    IelMotor biltestI = bil as IelMotor;
                    Console.WriteLine("IelMotor Interface test");
                    Console.WriteLine(biltestI.GetLadeTid());
                }


                if (bil is DieselBil)
                {
                    //Her castes bil objekt 
                    DieselBil dieselbil1 = bil as DieselBil;
                    Console.WriteLine(dieselbil1.HvilkenBilErJeg());
                    Console.WriteLine(dieselbil1);
                    Console.WriteLine($"Den halvårige ejer afgift er: {dieselbil1.HalvÅrligEjerafgift()} og afgiften er: {dieselbil1.GetRegistreringsAfgift()} kr og rækkevidden er: {dieselbil1.GetRækkeVidde()}");
                }

                else if (bil is BenzinBil)
                {
                    //Her castes bill objektet til at være en benzinbil og derfor kan vi nu se properties.
                    BenzinBil benzinbil1 = bil as BenzinBil;
                    Console.WriteLine(benzinbil1.HvilkenBilErJeg());
                    Console.WriteLine(benzinbil1);
                    Console.WriteLine($"Den halvårige ejer afgift er: {benzinbil1.HalvÅrligEjerafgift()} og afgiften er: {benzinbil1.GetRegistreringsAfgift()} kr og rækkevidden er: {benzinbil1.GetRækkeVidde()}");
                }

                else if (bil is ElBil)
                {
                    ElBil elbil1 = bil as ElBil;
                    Console.WriteLine(elbil1.HvilkenBilErJeg());
                    Console.WriteLine(elbil1);   
                    Console.WriteLine($"Den halvårige ejer afgift er: {elbil1.HalvÅrligEjerafgift()} og afgiften er: {elbil1.GetRegistreringsAfgift()} kr. Rækkevidden er: {elbil1.GetRækkeVidde()} og dens elmoter har en ladetid på {elbil1.GetLadeTid()} min.");
                }
            }

           

            Console.ReadLine();

        }
    }
}
