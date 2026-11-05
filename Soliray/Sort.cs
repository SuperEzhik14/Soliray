using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliray
{
    internal interface SortDefers<T>
    {
        public static T[] ISetRandom(T[] masiv)
        {
            Random r = new Random();
            char[] indexplace = new char[masiv.Length];
            for (int i = 0; i < masiv.Length; i++)
            {
                indexplace[i] = ' ';
            }
            T[] masiv2 = new T[masiv.Length];

            for (int i = 0; i < masiv.Length; i++)
            {
                while (true)
                {
                    int index = r.Next(0, masiv.Length);
                    if (indexplace[index] == ' ')
                    {
                        indexplace[index] = '#';
                        masiv2[index] = masiv[i];
                        break;
                    }
                }
            }

            return masiv2;
        }

        T[] SetRandom(T[] masiv)
        {
            Random r = new Random();
            char[] indexplace = new char[masiv.Length];
            for (int i = 0; i < masiv.Length; i++)
            {
                indexplace[i] = ' ';
            }
            T[] masiv2 = new T[masiv.Length];

            for (int i = 0; i < masiv.Length; i++)
            {
                while (true)
                {
                    int index = r.Next(0, masiv.Length);
                    if (indexplace[index] == ' ')
                    {
                        indexplace[index] = '#';
                        masiv2[index] = masiv[i];
                        break;
                    }
                }
            }

            return masiv2;
        }
    }

    class Sort<T> : SortDefers<T>
    {
        public Sort()
        {
            
        }

        
    }

}
