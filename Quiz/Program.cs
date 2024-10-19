namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Weapon weapon = null;


            Console.WriteLine("Silah Yaradin: ");
            Console.Write("Silahin adi: ");
            string Name = Console.ReadLine();

            int capacity;
            int bullet;
            string firemode;

            bool Iscapacity;
            do
            {
                Console.Write("Umumi Gulle: ");
                Iscapacity = int.TryParse(Console.ReadLine(), out capacity);

                if (capacity > 0)
                {
                    Iscapacity = true;
                }
                else
                {
                    Console.WriteLine("Das atassan? Gulle qoy da!!");
                    Iscapacity = false;
                }
            } while (!Iscapacity);

            bool Isbullet;
            do
            {
                Console.Write("Silahdaki gulle: ");
                Isbullet = int.TryParse(Console.ReadLine(), out bullet);

                if (capacity >= bullet)
                {
                    Isbullet = true;
                }
                else
                {
                    Console.WriteLine("Mermi sayini duz daxil edin");
                    Isbullet = false;
                }

            }
            while (!Isbullet);




            Console.Write("Silah Modu (Tekli/Auto): ");
            string mod = Console.ReadLine();

            weapon = new Weapon(Name, capacity, bullet, mod);


            int secim;

            do
            {
                Console.WriteLine("Seçim edin:");
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("3 - Reload metodu üçün");
                Console.WriteLine("4 - ChangeFireMode metodu üçün");
                Console.WriteLine("5 - Proqramdan dayandırmaq üçün");
                Console.WriteLine("6 - Edit");

                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 0:

                        Console.WriteLine($"Capacity: {capacity}, Bullets: {bullet}, Mode: {mod}");
                        break;
          

                    case 1:
                        weapon.Shoot();
                        break;

                    case 2:
                        weapon.GetRemainBulletCount();
                        break;

                    case 3:
                        weapon.Reload();
                        break;

                    case 4:
                        weapon.ChangeFireMode();
                        break;

                    case 5:
                        Console.WriteLine("Proqram dayandırıldı.");
                        return;
                    case 6:
                        int editSecim;
                        do
                        {
                            Console.WriteLine("Edit Menu:");
                            Console.WriteLine("7 - Capacityi deyisin");
                            Console.WriteLine("8 - Gulle sayini deyisin");
                            Console.WriteLine("9 - Esas menyuya geri qayidin");

                            editSecim = int.Parse(Console.ReadLine());

                            switch (editSecim)
                            {
                                case 7:
                                    Console.Write("Capacityi daxil edin: ");
                                    int newCapacity = int.Parse(Console.ReadLine());
                                    if (newCapacity < weapon.Bullet)
                                    {
                                        Console.WriteLine("Capacity gulle sayindan az ola bilmez.");
                                    }
                                    else
                                    {
                                        weapon.Capacity = newCapacity;
                                        Console.WriteLine("Capacity deyisdi: " + weapon.Capacity);
                                    }
                                    break;
                                     
                                case 8:
                                    Console.Write("Yeni gulle sayini daxil edin: ");
                                    int newBullet = int.Parse(Console.ReadLine());
                                    if (newBullet > weapon.Capacity)
                                    {
                                        Console.WriteLine("Gulle sayi capacityden cox ola bilmez.");
                                    }
                                    else
                                    {
                                        weapon.Bullet = newBullet;
                                        Console.WriteLine("Yeni gulle sayi: " + weapon.Bullet);
                                    }
                                    break;
                                case 9:
                                    break;
                                default:
                                    Console.WriteLine("Sehvdir. Yeniden yoxlayin");
                                    break;
                            }
                        } while (editSecim != 9);

                        break;
                    default:

                        Console.WriteLine("Yanlış seçim!");
                        break;

                }
            } while (secim != 5);
        }
    }
}