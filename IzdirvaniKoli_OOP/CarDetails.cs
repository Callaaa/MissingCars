using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzdirvaniKoli_OOP
{
    public class CarDetails:Car,IPrint
    {
        private int nomerShasi;
        private int nomerDvigatel;
        private string addressSobstvenik;

        public int NomerShasi
        {
            get { return nomerShasi; }
            set { nomerShasi = value; }
        }
        public int NomerDvigatel
        {
            get { return nomerDvigatel; }
            set 
            {
                nomerDvigatel = value;
            }
        }

        public string AddressSobstvenik
        {
            get { return addressSobstvenik; }
            set { addressSobstvenik = value; }
        }

        public CarDetails(string registracionenNomer, string marka, string cvqt, string imeSobstvenik, int nomerShasi, int nomerDvigatel, string addressSobstvenik) : base(registracionenNomer, marka, cvqt, imeSobstvenik)
        {
            this.nomerDvigatel = nomerDvigatel;
            this.nomerShasi = nomerShasi;
            this.addressSobstvenik = addressSobstvenik;
        }

        public override int CountOfIzdirvaniKoli(List<CarDetails> cars, string izborMarka)
        {
            return cars.Count(x => x.Marka == izborMarka);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"dvigatel:{this.nomerDvigatel}\nshahsi:{this.nomerShasi}\naddress:{this.addressSobstvenik}\n\n");
        }
    }
}
