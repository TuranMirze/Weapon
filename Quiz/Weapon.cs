using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Quiz
{
    internal class Weapon
    {
        public string Name;
        private int _capacity;
        private int _bullet;
        public string FireMod;



        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
            }

        }
        

        public int Bullet
        {
            get { 

                return _bullet; 

                }

            set {

                if(value>0) {                               
                    _bullet = value;
                }
        }
    }

       


        public Weapon(string name, int capacity, int bullet, string firemod) {

            this.Name= name;
            _bullet = bullet;
            _capacity = capacity;
            this.FireMod = firemod;


        }
        public void Shoot()
        {

            if (Bullet > 0 && FireMod == "Tekli")
            {
                Bullet--;
                Console.WriteLine("1 gulle atildi. Qalan gulle: " + Bullet);
            }
            else if (Bullet >= 0 && FireMod == "Avto")
            {
                Bullet = 0;
                Console.WriteLine("Butun sarsor bosaldildi. Reload edin");
            }
            else {
                Console.WriteLine("Duz olmadi nese");
            }

        }



        public void GetRemainBulletCount()
        {
            if (Capacity>=Bullet)
            {
                int qalan = Capacity - Bullet;
                Console.WriteLine("Mermin" + " " + Bullet + " " + "denedir");
                Console.WriteLine( qalan + "  mermi de qoysan daraq dolacax");
            }
            else
            {
                Console.WriteLine("Mermi sayin duz yazmamisan");
            }
        }


        public void Reload()
        {
            if (Capacity >= Bullet)
            {
                Bullet = Capacity;
                Console.WriteLine("Silahi reload edildi. Qalan gulle: " + Bullet);
            }
            else {
                Console.WriteLine("Nese prob oldu");
            }
        }


        public void ChangeFireMode()
        {
            if (FireMod == "Tekli")
            {
                FireMod = "Auto";
                Console.WriteLine("Silahin avto moddadi. Tara getsin");
            }

            else if(FireMod =="Avto")
            {
                FireMod = "Tekli";
                Console.WriteLine("Silahin tekli moddadi. Kafadan vur");
            }
            else
            {
                Console.WriteLine("Modu daxil edin"); 
            }
        }

    }
}
