using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProgramm
{
    class Shop
    {
        public static List<ICertificate> allcertificates = new List<ICertificate>();
        private List<ICertificate> certificates = new List<ICertificate>();

        private void AddSertificate(ICertificate cer)
        {
            allcertificates.Add(cer);
            certificates.Add(cer);
        }
        private void RemoveSertificate(ICertificate cer)
        {
            if (certificates.Contains(cer))
            {
                allcertificates.Remove(cer);
                certificates.Remove(cer);
            }
        }
    }
}
