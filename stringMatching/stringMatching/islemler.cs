using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace stringMatching
{
    
    public class islemler
        
    {
     public Stopwatch sw = new Stopwatch();


        
        public int adet;
        public int boslukSayisi;
        public int alt,alt2,alt3;
        public string pat,txt;
        public int sayac=1;
        private int arrayCmp(char[] a, int aIdx, char[] b, int bIdx, int length)
        {
            sw.Start();
            int i = 0;

            for (i = 0; i < length && aIdx + i < a.Length && bIdx + i < b.Length; i++)
            {
               
                if (a[aIdx + i] == b[bIdx + i]) ;
                else if (a[aIdx + i] > b[bIdx + i])
                    return 1;
                else
                    return 2;
                
            }

            if (i < length)
                if (a.Length - aIdx == b.Length - bIdx)
                    return 0;
                else if (a.Length - aIdx > b.Length - bIdx)
                    return 1;
                else
                    return 2;
            else
                sw.Stop();
                return 0;
            

        }

        /* Compute the next maximal suffix. */
        private void nextMaximalSuffix(char[] y, int yIdx, int m, int[] i, int[] j, int[] k, int[] p)
        {
            sw.Start();
            char a, b;
            int c = y.Length;

            while (j[0] + k[0] < m && yIdx + i[0] + k[0] < c && yIdx + j[0] + k[0] < c)
            {
                a = y[yIdx + i[0] + k[0]];
                b = y[yIdx + j[0] + k[0]];
                if (a == b)
                    if (k[0] == p[0])
                    {
                        (j[0]) += p[0];
                        k[0] = 1;
                    }
                    else
                        ++(k[0]);
                else if (a > b)
                {
                    (j[0]) += k[0];
                    k[0] = 1;
                    p[0] = j[0] - i[0];
                }
                else
                {
                    i[0] = j[0];
                    ++(j[0]);
                    k[0] = p[0] = 1;
                }
            }
            sw.Stop();
        }

        /* String matching on ordered alphabets algorithm. */
        public ArrayList findAll(string pattern, string source) {
            sw.Start();
		char[] x = pattern.ToCharArray(), y = source.ToCharArray();
		int i, j, n = x.Length, m = y.Length;
		int[] ip = new int[1], jp = new int[1], k = new int[1], p = new int[1];
		ArrayList result = new ArrayList();

		/* Searching */
		ip[0] = -1;
		i = j = jp[0] = 0;
		k[0] = p[0] = 1;
		while (j <= n - m) {
			while (i + j < n && i < m && x[i + j] == y[i]){
                
                sayac += 1;
                
                ++i;
               
                
                if (i == y.Length) 
                { 
                    adet += 1;
                    alt3 = x.Length;
                  
                
                }


                pat = new string(x);
                txt = new string(y);

                boslukSayisi = i + j;
                alt2 = i+1;
                
                
			
            }
			
			if (i == 0) {

				++j;
            
				ip[0] = -1;
				jp[0] = 0;
				k[0] = p[0] = 1;
			} else {
                if (i >= m)
                    alt = i;
					result.Add(j);
				nextMaximalSuffix(y, j, i + 1, ip, jp, k, p);
				if (ip[0] < 0|| (ip[0] < p[0] && arrayCmp(y, j, y, j + p[0],ip[0] + 1) == 0)) {
					j += p[0];
					i -= p[0];
					if (i < 0)
						i = 0;
					if (jp[0] - ip[0] > p[0])
						jp[0] -= p[0];
					else {
						ip[0] = -1;
						jp[0] = 0;
						k[0] = p[0] = 1;
					}
				} else {
					j += (Math.Max(ip[0] + 1, Math.Min(i - ip[0] - 1, jp[0] + 1)) + 1);
                 
					i = jp[0] = 0;
					ip[0] = -1;
					k[0] = p[0] = 1;
				}
			}
			
		}
        sw.Stop();
		return result;
		
	}
       
    }
    
}

 

