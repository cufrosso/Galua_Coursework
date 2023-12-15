using System;
using System.Collections.Generic;
using System.Linq;

namespace GaluaLibrary
{
    public class GaluaField
    {
        private int q;
        private int m;
        private int[] irreducible_poly;
        public int[][] field;
        public GaluaField(int qq, int mm, int[] a)
        {
            try
            {
                q = qq;
                if (!is_prime(q))
                    throw new ArgumentException("Введите простое q");
                m = mm;
                if (!is_irreducible(a))
                    throw new ArgumentException("Введите неприводимый многочлен");
                irreducible_poly = a;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void building_field(int[] g)
        {
            int qm = (int)Math.Pow(q, m) - 1;

            int[] mass = { 1 };
            int[] x = { 0, 1 };
            field = new int[qm][];
            field[0] = mass;
            for (int i = 1; i < qm; i++)
            {
                mass = multiply(mass, x);
                mass = divide_r(mass, g);
                mass = fit(mass);
                if ((mass[0] == 1) && (mass.Length == 1))
                {
                    Array.Clear(field, 0, field.Length);
                    return;
                }
                field[i] = mass;
            }
        }

        public bool is_irreducible(int[] a)
        {
            int n = a.Length - 1;
            int[] tmp = (int[])a.Clone();
            for (int i = 1; i <= n / 2; i++)
            {
                int[] factor = { 1, i };

                int[] remainder = divide_r(tmp, factor);

                if (Array.TrueForAll(remainder, x => x == 0))
                {
                    return false; // Многочлен приводим
                }
            }

            return true;
        }

        public bool is_prime(int n)
        {
            if (n == 2 || n == 3)
            {
                return true;
            }
            if (n < 2 || n % 2 == 0)
            {
                return false;
            }


            // Малая теорема Ферма a^(p-1) ≡ 1 (mod p) 
            // Выбираем случайное a и проверяем условие для него
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(2, n - 1);
                if (mod_pow(a, n - 1, n) != 1)
                {
                    return false;
                }
            }
            return true;
        }
        /*возведение числа a в степень b по модулю n*/
        public static int mod_pow(int a, int b, int n)
        {
            int res = 1;
            while (b > 0)
            {
                if ((b & 1) != 0)
                {
                    res = (res * a) % n;
                }
                a = (a * a) % n;
                b >>= 1;
            }
            return res;
        }
        public int[] add(int[] p1, int[] p2)
        {
            int deg_1 = p1.Length - 1;
            int deg_2 = p2.Length - 1;
            int m = Math.Max(deg_1, deg_2);
            int[] p = new int[m + 1];
            for (int i = m; i >= 0; i--)
            {
                if (deg_1 > deg_2)
                {
                    if (i > deg_2)
                        p[i] = p1[i];
                    else
                    {
                        p[i] = (p1[i] + p2[i] + q) % q;
                    }
                }
                if (deg_1 < deg_2)
                {
                    if (i > deg_1)
                        p[i] = p2[i];
                    else
                    {
                        p[i] = (p1[i] + p2[i]) % q;
                    }
                }
                if (deg_1 == deg_2)
                {
                    p[i] = (p1[i] + p2[i]) % q;
                }
            }
            return p;
        }
        public int[] subtract(int[] p1, int[] p2)
        {
            int deg_1 = p1.Length - 1;
            int deg_2 = p2.Length - 1;
            int m = Math.Max(deg_1, deg_2);
            int[] p = new int[m + 1];
            for (int i = m; i >= 0; i--)
            {
                if (deg_1 > deg_2)
                {
                    if (i > deg_2)
                        p[i] = p1[i];
                    else
                    {
                        p[i] = (p1[i] - p2[i] + q) % q;
                    }
                }
                if (deg_1 < deg_2)
                {
                    if (i > deg_1)
                        p[i] = (0 - p2[i] + q ) % q;
                    else
                    {
                        p[i] = (p1[i] - p2[i] + q) % q;
                    }
                }
                if (deg_1 == deg_2)
                {
                    p[i] = (p1[i] - p2[i] + q) % q;
                }
            }
            return p;
        }

        public int[] multiply(int[] p1, int[] p2)
        {
            int deg_1 = p1.Length - 1;
            int deg_2 = p2.Length - 1;
            int m = deg_1 + deg_2;
            int[] p = new int[m + 1];

            for (int j = deg_1; j >= 0; j--)
            {
                for (int k = deg_2; k >= 0; k--)
                {
                    p[j + k] = (p[j + k] + p1[j] * p2[k]) % q;
                }
            }
            return p;
        }
        public int[][] divide(int[] p1, int[] p2)
        {
            p2 = fit(p2);
            int deg_1 = p1.Length - 1;
            int deg_2 = p2.Length - 1;

            int m = deg_1 + deg_2;
            int[][] q_r = new int[2][];
            q_r[0] = new int[deg_1 + 1];
            q_r[1] = new int[deg_1 + 1];

            if (deg_2 > deg_1)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        q_r[i][0] = 0;
                    }
                    else
                    {
                        q_r[i] = p1;
                    }
                }
                return q_r;
            }

            else
            {
                int deg_q = deg_1 - deg_2;
                int j = deg_q;
                for (; ; )
                {
                    int fact = (int)(p1[deg_1] / p2[deg_2]);
                    int k2 = deg_2;
                    q_r[0][j] = fact;
                    j--;
                    for (int i = deg_1; i >= (deg_1 - deg_2); i--)
                    {
                        p1[i] = (p1[i] - fact * p2[k2] + fact * q) % q;
                        k2--;
                    }
                    deg_1--;
                    if (deg_1 < deg_2)
                        break;
                }
                q_r[1] = p1;
                return q_r;
            }
        }

        public int[] divide_r(int[] p1, int[] p2)
        {
            p2 = fit(p2);
            int deg_1 = p1.Length - 1;
            int deg_2 = p2.Length - 1;

            int m = deg_1 + deg_2;
            int[][] q_r = new int[2][];
            q_r[0] = new int[deg_1 + 1];
            q_r[1] = new int[deg_1 + 1];

            if (deg_2 > deg_1)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        q_r[i][0] = 0;
                    }
                    else
                    {
                        q_r[i] = p1;
                    }
                }
                return q_r[1];
            }

            else
            {
                int deg_q = deg_1 - deg_2;
                int j = deg_q;
                for (; ; )
                {
                    int fact = (int)(p1[deg_1] / p2[deg_2]);
                    int k2 = deg_2;
                    q_r[0][j] = fact;
                    j--;
                    for (int i = deg_1; i >= (deg_1 - deg_2); i--)
                    {
                        p1[i] = (p1[i] - fact * p2[k2] + fact * q) % q;
                        k2--;
                    }
                    deg_1--;
                    if (deg_1 < deg_2)
                        break;
                }
                q_r[1] = p1;
                return q_r[1];
            }
        }
        public int calc_value_polynomial(int[] a, int x)
        {
            int result = a[a.Length - 1];
            for (int i = a.Length - 2; i >= 0; i--)
            {
                result = result * x + a[i];
            }
            return result % q;
        }

        public int[] multiply_karatsuba(int[] a, int[] b)
        {
            int deg_1 = a.Length - 1;
            int deg_2 = b.Length - 1;

            int n = Math.Max(a.Length, b.Length);
            if (n <= 2)
            {
                return multiply(a, b);
            }

            int mid = n / 2;
            int[] a0 = low_half(a, mid);
            int[] a1 = up_half(a, mid);
            int[] b0 = low_half(b, mid);
            int[] b1 = up_half(b, mid);

            int[] p1 = multiply(a0, b0);
            int[] p2 = multiply(a1, b1);
            int[] t = multiply(add(a0, a1), add(b0, b1));

            int[] result = p1;
            result = add(result, multiply_to_x(subtract(t, add(p1, p2)), mid));
            result = add(result, multiply_to_x(p2, 2 * mid));

            return result;
        }
        private static int[] low_half(int[] a, int mid)
        {
            int[] result = new int[mid];
            for (int i = 0; i < mid; i++)
            {
                result[i] = a[i];
            }
            return result;
        }
        private static int[] up_half(int[] a, int mid)
        {
            int n = a.Length;
            int[] result = new int[n - mid];
            for (int i = 0; i < n - mid; i++)
            {
                result[i] = a[mid + i];
            }
            return result;
        }
        private static int[] multiply_to_x(int[] a, int power)
        {
            int[] result = new int[a.Length + power];
            for (int i = 0; i < power; i++)
            {
                result.Append(0);
            }
            for (int i = 0; i < a.Length; i++)
            {
                result[power + i] = (a[i]);
            }
            return result;
        }
        private int[] fit(int[] a)
        {
            while (a.Length > 0 && a[a.Length - 1] == 0)
            {
                Array.Resize(ref a, a.Length - 1);
            }
            return a;
        }

    }
}
