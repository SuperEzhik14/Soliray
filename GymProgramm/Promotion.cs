using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GymProgramm
{
    class Promotion
    {
        static Promotion CreatePromotion()
        {
            return new Promotion();
        }
        private List<ICertificate> certificates = new List<ICertificate>();
        public Promotion()
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[S сертификаты] [D скидка] [F количество дней] [G создать] [Esc выйти]");
                Console.WriteLine("Создание Акции");
                Console.WriteLine($"Количество сертификатов: {certificates}");
                Console.WriteLine($"Стоимость со скидкой: {price}");
                Console.WriteLine($"Скидка: {sale}");
                int temp = 0;
                foreach (ICertificate cert in queue)
                {
                    if (temp == 0)
                    {
                        temp = 1;
                        Console.WriteLine();
                        Console.WriteLine(cert.ToString());
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine(cert.name);

                }

                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.S:
                        ChooseCertificate();
                        break;
                    case ConsoleKey.D:
                        ChangeSale();
                        break;
                    case ConsoleKey.F:
                        
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
            }

        }

        private DateTime endtime;
        public bool temp { get; protected set; } = true;

        public int sale { get; }
        public int price { get; }
        private void ChangeSale()
        {
            
        }
        private void ChooseCertificate()
        {
            Console.Clear();
            Queue<ICertificate> queue = new Queue<ICertificate>();
            foreach (ICertificate cert in Shop.allcertificates.ToArray())
            {
                if (!certificates.Contains(cert))
                {
                    queue.Enqueue(cert);
                }

            }
            
            
            List<ICertificate> list = new List<ICertificate>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"[S скип] [D выбрать] [ESC выйти] [F добавить, {list.Count}x]");
                Console.WriteLine("Выберите сертификат");
                Console.WriteLine($"Выбрано: {list.Count}");
                int temp = 0;
                foreach (ICertificate cert in queue)
                {
                    if (temp == 0)
                    {
                        temp = 1;
                        Console.WriteLine();
                        Console.WriteLine(cert.ToString());
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine(cert.name);
                    
                }

                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.S:
                        if (queue.Count >= 1)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                        break;
                    case ConsoleKey.D:
                        if (queue.Count >= 1)
                        {
                            list.Add(queue.Dequeue());
                        }
                        break;
                    case ConsoleKey.F:
                        if (list.Count >= 1)
                        {
                            certificates.AddRange(list);
                            Console.WriteLine("Успешно добавлено в акцию!");
                            Thread.Sleep(100);
                            return;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
            }
            


        }

    }
}
