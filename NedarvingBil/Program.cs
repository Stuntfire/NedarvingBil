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

            DieselBil dbBil1 = new DieselBil("Volvo", 500000, 2014, 70, true);
            DieselBil dbBil2 = new DieselBil("Renault", 100000, 2016, 50, false);
            DieselBil dbBil3 = new DieselBil("Ford", 100000, 2010, 60, true);

            DieselBil dbBil4 = new DieselBil("Mercedes", 700000, 2014, 70);
            DieselBil dbBil5 = new DieselBil("Volkswagen", 500000, 2010, 90);

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
                Console.WriteLine($"{db.GetHalvÅrigeAfgift()} og {db.RegistreringAfgift()}");
            }

          
           
            Console.ReadLine();

        }
    }
}
