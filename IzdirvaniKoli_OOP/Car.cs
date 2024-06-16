using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzdirvaniKoli_OOP
{
    public abstract class Car:IPrint, IComparable<Car>
    {
        private string registracionenNomer;
        private string marka;
        private string cvqt;
        private string imeSobstvenik;

        public string RegistracionenNomer
        {
            get { return registracionenNomer; }
            set 
            { 
                registracionenNomer = value; 
            }
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Cvqt
        {
            get { return cvqt; }
            set { cvqt = value; }
        }

        public string ImeSobstvenik
        {
            get { return imeSobstvenik; }
            set { imeSobstvenik = value; }
        }

        public Car(string registracionenNomer, string marka, string cvqt, string imeSobstvenik)
        {
            this.registracionenNomer = registracionenNomer;
            this.marka = marka;
            this.cvqt = cvqt;
            this.imeSobstvenik = imeSobstvenik;
        }
        public abstract int CountOfIzdirvaniKoli(List<CarDetails> cars, string izborMarka);

        public int CompareTo(Car other)
        {
            return this.registracionenNomer.CompareTo(other.registracionenNomer);
        }
        public virtual void Print()
        {
            Console.WriteLine($"\n{this.imeSobstvenik}-{this.registracionenNomer}\n{this.marka}-{this.cvqt}");
        }
    }
}
