using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            string licensePlate;
            Console.WriteLine("Input licensePlate : ");
            licensePlate = Console.ReadLine();
            licensePlate.ToLower();

            for (int i = 0; i < licensePlate.Length; i++)
            {
                int val = licensePlate[i];
                if (val >= 97 && val <= 122)
                {
                    if (ht.Contains(licensePlate[i]))
                    {
                        int tmp = Convert.ToInt32(ht[licensePlate[i]]);
                        ht[licensePlate[i]] = tmp+1;
                    }
                    else
                    {
                        ht.Add(licensePlate[i], 1);
                    }
                }
            }

            string[] words = new string[10];
            Console.WriteLine("Input words : ");
            string wordInput = Console.ReadLine();
            int idx = 0;
            for (int i = 0; i < wordInput.Length; i++)
            {
                if (wordInput[i] == ' ')
                {
                    idx++;
                }
                else
                {
                    words[idx] += wordInput[i];
                }
            }

            string phrase = wordInput;
            for(int i = 0;i < words.Length; i++)
            {
                bool same = true;
                foreach(DictionaryEntry entry in ht)
                {
                    char k = Convert.ToChar(entry.Key);
                    int v = Convert.ToInt32(entry.Value);
                    int cnt = words[i].Count(x=>x==k);
                    if (cnt != v)
                    {
                        same = false;
                        break;
                    }
                }
                if(same && phrase.Length > words[i].Length)
                {
                    phrase = words[i];
                }
            }

            if (phrase == wordInput)
                Console.WriteLine("EOF");
            else
                Console.WriteLine(phrase);
            Console.Read();
        }
    }
}
