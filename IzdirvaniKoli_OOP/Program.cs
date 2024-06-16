using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzdirvaniKoli_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Br koli:");
                int n = int.Parse(Console.ReadLine());

                List<CarDetails> list = new List<CarDetails>();

                using (StreamWriter writer = new StreamWriter("cars.txt", true))//з)
                {

                    for (int i = 0; i < n; i++)
                    {
                        //a)
                        Console.WriteLine("Enter:\nreg. nomer, marka, cvqt, sobstvenik, nomer shasi, nomer dvigatel, adres sobstvenik");
                        var danni = Console.ReadLine().Split(',');
                        CarDetails car = new CarDetails(danni[0], danni[1], danni[2], danni[3], int.Parse(danni[4]), int.Parse(danni[5]), danni[6]);
                        list.Add(car);

                        writer.WriteLine($"{danni[0]} {danni[1]} {danni[2]} {danni[3]} {int.Parse(danni[4])} {int.Parse(danni[5])} {danni[6]}");

                    }
                }
                //б)
                list.ForEach(x => x.Print());

                List<CarDetails> cars = new List<CarDetails>()
                {
                new CarDetails("62821K","BMW","Sin","Ali",74394,992,"Ivan Vazov"),
                new CarDetails("762821K","BMW","Zelen","Stef",74394,992,"Ivan Vazov"),
                new CarDetails("362821K","Audi","Bql","Ani",74394,992,"Ivan Vazov"),
                new CarDetails("A62821K","Mercedes","Siv","Veni",74394,992,"IvanVazov")
                };

                list.AddRange(cars);

                //в)
                Console.WriteLine("\nIskash li da turshish kola po reg. nomer(Da/Ne)");
                string answer = Console.ReadLine();
                if (answer == "Da")
                {
                    Console.Write("Vuvedi nomer: ");
                    string nomer = Console.ReadLine();
                    var matchingCar = list.FirstOrDefault(x => x.RegistracionenNomer == nomer);

                    if (matchingCar != null)
                    {
                        matchingCar.Print();
                    }
                    else
                    {
                        Console.WriteLine("Nqma takava kola!");
                    }
                }
                //г)
                Console.WriteLine("\nVuvedi marka za tursene br izdirvani koli\nBMW/Audi/Mercedes");
                string marka = Console.ReadLine();
                int count = 0;
                list.Sort();
                switch (marka)
                {
                    case "BMW":
                        count = list.First().CountOfIzdirvaniKoli(list, "BMW");
                        break;
                    case "Audi":
                        count = list.First().CountOfIzdirvaniKoli(list, "Audi");
                        break;
                    case "Mercedes":
                        count = list.First().CountOfIzdirvaniKoli(list, "Mercedes");
                        break;
                    default:
                        Console.WriteLine("Ne sushtestvuva!");
                        break;
                }
                if (count > 0)
                {
                    Console.WriteLine($"Br koli s marka-{marka}: {count}");
                }

                //д)
                Console.Write("\n\nKola s nai-maluk reg. nomer:");
                var smallerCar = list.OrderBy(x => x.RegistracionenNomer).First();
                smallerCar.Print();

                //е)
                Console.WriteLine("---Sortirani po nomer---");
                list.OrderBy(x => x.RegistracionenNomer).ThenBy(x => x.ImeSobstvenik);
                list.ForEach(x => x.Print());

                Console.WriteLine("Chetene na kakvo ima vuv cars.txt");
                StreamReader reader = new StreamReader("cars.txt");
                using (reader)
                {
                    string line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            //ж)
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
