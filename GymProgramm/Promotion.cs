using System;
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
            Console.WriteLine("Создание Акции");

        }

        private DateTime endtime;
        public bool temp { get; protected set; } = true;
        private void ChooseCertificate()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Выберите сертификат");
            Console.WriteLine();
        }
    }
}
