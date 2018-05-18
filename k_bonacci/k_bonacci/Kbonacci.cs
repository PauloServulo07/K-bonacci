using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_bonacci
{
    public class Kbonacci
    {
        //Este método retorna a soma dos elementos de um vetor
        public long soma_vet(long[] vet, int tam)
        {
            int i;
            long soma = 0;
            for (i = 0; i < tam; i++)
            {
                soma = soma + vet[i];
            }
            return soma;
        }

        //Calcula o k-bonacci dado o n e o k
        public long k_bonacci(int k, int n)
        {
            if (n < k)
            {
                return 1;
            }
            else
            {
                int i, j = k - 1;
                long[] vet = new long[k];
                for (i = 0; i < k; i++)
                {
                    vet[i] = 1;
                }
                for (i = k; i <= n; i++)
                {
                    if (j < 0)
                    {
                        j = k - 1;
                    }
                    vet[j] = soma_vet(vet, k);
                    j--;
                }
                return vet[j + 1];
            }
        }
    }
}
