using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8_LISTA_1_Yohan_Aquino
{
    class Comparador
    {
        private double n1;
        private double n2;

        public void setNum1(double x)
        {
            n1 = x;
        }
        public void setNum2(double x)
        {
            n2 = x;
        }
        public string getMaior()
        {
            if (n1 == n2)
            {
                return "os valores são identicos";
            }
            else
            {
                if (n1 > n2)
                {
                    return n1.ToString()+" é o maior";
                }
                else
                {
                    return n2.ToString()+" é o maior";
                }
            }
        }
    }
}
