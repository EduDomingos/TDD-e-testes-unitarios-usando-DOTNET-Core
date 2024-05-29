using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTDD
{
    public class Calculadora
    {
        public List<string> historico;
        public Calculadora()
        {
            historico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            historico.Insert(0, $"{val1} + {val2} = {res}");
            return res;
        }
        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            historico.Insert(0, $"{val1} - {val2} = {res}");
            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            historico.Insert(0, $"{val1} * {val2} = {res}");
            return res;
        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            historico.Insert(0, $"{val1} / {val2} = {res}");
            return res;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
