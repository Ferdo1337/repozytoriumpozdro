using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozdro;
    internal class Class1
    {
        public string Zadanie1(string data, int indexToCut)
        {
            if (data.Length > indexToCut)
            {
                return data.Substring(indexToCut);
            }
            else
            {
                return data;
            }
        }
    }
