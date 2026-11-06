using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProgramm
{
    interface ICertificate
    {
        int price { get; protected set; }
        int mounts { get; protected set; }
        string name { get; }
        byte sale { get; }

        DateTime datefirstpay { get; protected set; }
        DateTime datelastpay { get; protected set; }
        void Impruve(ref int money)
        {
            Console.Clear();
            Console.WriteLine($"Баланс: {money}");
            Console.WriteLine("Продление абонемента");
            Console.WriteLine(ToString());
            Console.WriteLine($"Стоимость продления: {((price / 100) * (100 - sale))}");
            Console.WriteLine($"Скидка: {sale}%");
            Console.WriteLine($"[S,Продлить] [Esc,Выйти]");
            ConsoleKey key = Console.ReadKey().Key;

            if ( key == ConsoleKey.S )
            {
                if (money >= ((price / 100) * (100 - sale)))
                {
                    money = money - ((price / 100) * (100 - sale));
                    mounts++;
                    datelastpay = DateTime.Now; 
                    Console.WriteLine("Вы успешно продлили абонимент на 1 месяц");
                    
                }
                else
                {
                    Console.WriteLine("Нехватка средств, абонимент не продлен!");
                }
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
        string ToString()
        {
            string str = "";
            str += $"    Абонемет: {name}\n";
            str += $" Куплен: {datefirstpay}\n";
            str += $" Последние продление: {datelastpay}\n";
            str += $" Действует до: {datefirstpay.AddMonths(mounts).AddDays(1).ToString("dd")}";
            return str;
        }
        void Start()
        {
            if (datefirstpay == null)
            {
                datefirstpay = DateTime.Now;
                price = price / mounts;
            }
        }
        bool Cheak()
        {
            if (datefirstpay.AddMonths(mounts) > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void Buy(ref int money)
        {
            Console.WriteLine("Покупка абонемента");
            Console.WriteLine(ToString());
            Console.WriteLine($"Стоимость: {((price / 100) * (100 - sale))}");
            Console.WriteLine($"[S,Купить] [Esc,Выйти]");
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.S)
            {
                if (money >= ((price / 100) * (100 - sale)))
                {
                    money = money - ((price / 100) * (100 - sale));
                    Console.WriteLine("Вы успешно купили абонимент!");
                }
                else
                {
                    Console.WriteLine("Нехватка средств, абонимент не куплен!");
                }
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    class CertificateBrown : ICertificate
    {
        int ICertificate.price { get; set; } = 30000;
        int ICertificate.mounts { get; set; } = 1;
        string ICertificate.name => "Brown";
        byte ICertificate.sale => 0;
        DateTime ICertificate.datefirstpay { get; set; }
        DateTime ICertificate.datelastpay { get; set; }

        public CertificateBrown()
        {

        }

        
    }

    class CertificateIron : ICertificate
    {
        int ICertificate.price { get; set; } = 90000;
        int ICertificate.mounts { get; set; } = 3;
        string ICertificate.name => "Iron";
        byte ICertificate.sale => 5;
        DateTime ICertificate.datefirstpay { get; set; }
        DateTime ICertificate.datelastpay { get; set; }

        public CertificateIron()
        {

        }


    }

    class CertificateGold : ICertificate
    {
        int ICertificate.price { get; set; } = 270000;
        int ICertificate.mounts { get; set; } = 9;
        string ICertificate.name => "Gold";
        byte ICertificate.sale => 10;
        DateTime ICertificate.datefirstpay { get; set; }
        DateTime ICertificate.datelastpay { get; set; }

        public CertificateGold()
        {

        }
    }
}
