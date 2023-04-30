using System;

namespace Csharp_HW_modul_03_part_01
{
    class Website
    {
        public Website(string namesite, string pathtosite, string descript, string ipaddress)
        {
            nameSite = namesite;
            pathToSite = pathtosite;
            description = descript;
            ipAddress = ipaddress;
        }

        public string nameSite { get; set; }
        public string pathToSite { get; set; }
        public string description { get; set; }
        public string ipAddress { get; set; }

        public void print()
        {
            Console.WriteLine(nameSite + "\n" + description + "\n" + pathToSite + "\n" + ipAddress);
        }
    }

    class Magazine
    {
        public Magazine(string nameMagazine, string yearOfFoundation, string description, string phone, string email)
        {
            _nameMagazine = nameMagazine;
            _yearOfFoundation = yearOfFoundation;
            _description = description;
            _phone = phone;
            _email = email;
        }

        public string _nameMagazine { get; set; }
        public string _yearOfFoundation { get; set; }
        public string _description { get; set; }
        public string _phone { get; set; }
        public string _email { get; set; }
        public void print()
        {
            Console.WriteLine(_nameMagazine + "\n" + _yearOfFoundation + "\n" + _description + "\n" + _phone+"\n"+_email);
        }
        
    }
    
    class Shop
    {
        public Shop(string nameMagazine, string adress, string description, string phone, string email)
        {
            _nameMagazine = nameMagazine;
            _adress = adress;
            _description = description;
            _phone = phone;
            _email = email;
        }

        public string _nameMagazine { get; set; }
        public string _adress { get; set; }
        public string _description { get; set; }
        public string _phone { get; set; }
        public string _email { get; set; }
        public void print()
        {
            Console.WriteLine(_nameMagazine + "\n" + _adress + "\n" + _description + "\n" + _phone+"\n"+_email);
        }
        
    }

    internal class Program
    {
        void task_1(uint sides, char symbol)
        {
            for (int i = 0; i < sides; i++)
            {
                for (int j = 0; j < sides; j++)
                {
                    Console.Write(symbol + " ");
                }

                Console.WriteLine();
            }
        }

        bool task_2(uint number)
        {
            string num = Convert.ToString(number);
            if (num.Length % 2 == 0)
            {
                int b = num.Length - 1;
                for (int i = 0; i <= b; i++)
                {
                    if (num[i] != num[b])
                    {
                        return false;
                    }

                    b--;
                }

                return true;
            }

            return false;
        }

        char[] task_3(char[] array, char[] ar)
        {
            int count = 0;
            char[] symbol = new char[Math.Min(array.Length, ar.Length)];
            for (int i = 0; i < array.Length; i++)
            {
                bool isThere = false;
                for (int j = 0; j < ar.Length; j++)
                {
                    if (array[i] == ar[j])
                    {
                        isThere = true;
                    }
                }

                if (!isThere)
                {
                    symbol[count] = array[i];
                    count++;
                }
            }

            Array.Resize(ref symbol, count);
            return symbol;
        }


        public static void Main(string[] args)
        {
            Program pro = new Program();
            //pro.task_1(23,'#');
            //Console.WriteLine(pro.task_2(453254));
            // Console.WriteLine(pro.task_3(new char[]{'4','6','9','7','1','0','2','3'}, new char[]{'6','4','2','3'}));
            // Website ws = new Website("GitHub", "github.com",
            //     "GitHub — это сервис для совместной разработки и хостинга проектов.", "217:56.446.56");
            // ws.print();
            // Magazine mg = new Magazine("Game World","23.11.1995","журнал об играх","8(495)78945123","gameworld@mail.ru");
            // mg.print();

            Shop shop = new Shop("Magnit","g.Chelny 56/12","product","8(822)456132","magnit@mail.ru");
            shop.print();
        }
    }
}