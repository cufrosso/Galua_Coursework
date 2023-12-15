using System;
using System.Collections;
using System.Windows.Forms;
using GaluaLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Galua
{
    public partial class Galua_Coursework : Form
    {
        GaluaField gf;
        ArrayList a_boxes = new ArrayList();
        ArrayList a_labels = new ArrayList();
        ArrayList b_boxes = new ArrayList();
        ArrayList b_labels = new ArrayList();
        ArrayList g_boxes = new ArrayList();
        ArrayList g_labels = new ArrayList();
        public Galua_Coursework()
        {
            InitializeComponent();
            a_boxes.Add(a_x0);
            a_boxes.Add(a_x1);
            a_boxes.Add(a_x2);
            a_boxes.Add(a_x3);
            a_boxes.Add(a_x4);
            a_boxes.Add(a_x5);
            a_boxes.Add(a_x6);

            a_labels.Add(label_ax0);
            a_labels.Add(label_ax1);
            a_labels.Add(label_ax2);
            a_labels.Add(label_ax3);
            a_labels.Add(label_ax4);
            a_labels.Add(label_ax5);
            a_labels.Add(label_ax6);

            b_boxes.Add(b_x0);
            b_boxes.Add(b_x1);
            b_boxes.Add(b_x2);
            b_boxes.Add(b_x3);
            b_boxes.Add(b_x4);
            b_boxes.Add(b_x5);
            b_boxes.Add(b_x6);

            b_labels.Add(label_bx0);
            b_labels.Add(label_bx1);
            b_labels.Add(label_bx2);
            b_labels.Add(label_bx3);
            b_labels.Add(label_bx4);
            b_labels.Add(label_bx5);
            b_labels.Add(label_bx6);

            g_boxes.Add(comboBox7);
            g_boxes.Add(comboBox6);
            g_boxes.Add(comboBox5);
            g_boxes.Add(comboBox4);
            g_boxes.Add(comboBox3);
            g_boxes.Add(comboBox2);
            g_boxes.Add(comboBox1);

            g_labels.Add(label10);
            g_labels.Add(label9);
            g_labels.Add(label8);
            g_labels.Add(label7);
            g_labels.Add(label6);
            g_labels.Add(label5);
            g_labels.Add(label4);
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

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                if (deg_b.SelectedItem == null || deg_a.SelectedItem == null)
                                    MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                else
                                {
                                    int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
                                    int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
                                    if (degree_a > m || degree_b > m)
                                        MessageBox.Show("Степени полиномов a(x) и b(x) не должны превышать m");
                                    else
                                    {

                                        int[] a = new int[degree_a + 1];
                                        int[] b = new int[degree_b + 1];
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (((ComboBox)a_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома a(x)");
                                                return;
                                            }
                                            else
                                                a[i] = Convert.ToInt32(((ComboBox)a_boxes[i]).SelectedItem.ToString());
                                        }
                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (((ComboBox)b_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома b(x)");
                                                return;
                                            }
                                            else
                                                b[i] = Convert.ToInt32(((ComboBox)b_boxes[i]).SelectedItem.ToString());
                                        }


                                        int[] result = gf.add(a, b);
                                        richTextBox1.Text += "add result:" + "\r\n" + "a(x) + b(x) = (";
                                        string a_str = "";
                                        string b_str = "";
                                        string res_str = "";
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (i == a.Length - 1)
                                                a_str += a[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                a_str += a[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "a(x)",
                                                Poly_Coefficients = a_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }

                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (i == b.Length - 1)
                                                b_str += b[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                b_str += b[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "b(x)",
                                                Poly_Coefficients = b_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }

                                        for (int i = 0; i < result.Length; i++)
                                        {
                                            if (i == result.Length - 1)
                                                res_str += result[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                res_str += result[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }

                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Galua_Result Result = new Galua_Result
                                            {
                                                Operation_Name = "add",
                                                Result_Coefficients = res_str
                                            };
                                            db.Galua_Result.Add(Result);

                                            db.SaveChanges();

                                        }
                                        richTextBox1.Text += a_str + ") + (" + b_str + ") = " + res_str + "\r\n";
                                    }
                                }
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                if (deg_b.SelectedItem == null || deg_a.SelectedItem == null)
                                    MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                else
                                {
                                    int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
                                    int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
                                    if (degree_a > m || degree_b > m)
                                        MessageBox.Show("Степени полиномов a(x) и b(x) не должны превышать m");
                                    else
                                    {

                                        int[] a = new int[degree_a + 1];
                                        int[] b = new int[degree_b + 1];
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (((ComboBox)a_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома a(x)");
                                                return;
                                            }
                                            else
                                                a[i] = Convert.ToInt32(((ComboBox)a_boxes[i]).SelectedItem.ToString());
                                        }

                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (((ComboBox)b_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома b(x)");
                                                return;
                                            }
                                            else
                                                b[i] = Convert.ToInt32(((ComboBox)b_boxes[i]).SelectedItem.ToString());
                                        }


                                        int[] result = gf.subtract(a, b);
                                        richTextBox1.Text += "subtract result:" + "\r\n" + "a(x) - b(x) = (";
                                        string a_str = "";
                                        string b_str = "";
                                        string res_str = "";
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (i == a.Length - 1)
                                                a_str += a[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                a_str += a[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "a(x)",
                                                Poly_Coefficients = a_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }


                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (i == b.Length - 1)
                                                b_str += b[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                b_str += b[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "b(x)",
                                                Poly_Coefficients = b_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }

                                        for (int i = 0; i < result.Length; i++)
                                        {
                                            if (i == result.Length - 1)
                                                res_str += result[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                res_str += result[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Galua_Result Result = new Galua_Result
                                            {
                                                Operation_Name = "subtract",
                                                Result_Coefficients = res_str
                                            };
                                            db.Galua_Result.Add(Result);

                                            db.SaveChanges();

                                        }
                                        richTextBox1.Text += a_str + ") - (" + b_str + ") = " + res_str + "\r\n";

                                    }
                                }
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                if (deg_b.SelectedItem == null || deg_a.SelectedItem == null)
                                    MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                else
                                {
                                    int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
                                    int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
                                    if (degree_a > m || degree_b > m)
                                        MessageBox.Show("Степени полиномов a(x) и b(x) не должны превышать m");
                                    else
                                    {

                                        int[] a = new int[degree_a + 1];
                                        int[] b = new int[degree_b + 1];
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (((ComboBox)a_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома a(x)");
                                                return;
                                            }
                                            else
                                                a[i] = Convert.ToInt32(((ComboBox)a_boxes[i]).SelectedItem.ToString());
                                        }
                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (((ComboBox)b_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома b(x)");
                                                return;
                                            }
                                            else
                                                b[i] = Convert.ToInt32(((ComboBox)b_boxes[i]).SelectedItem.ToString());
                                        }

                                        int[] result = gf.multiply_karatsuba(a, b);
                                        richTextBox1.Text += "multiply karatsuba result:" + "\r\n" + "a(x) * b(x) = (";
                                        string a_str = "";
                                        string b_str = "";
                                        string res_str = "";
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (i == a.Length - 1)
                                                a_str += a[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                a_str += a[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "a(x)",
                                                Poly_Coefficients = a_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }


                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (i == b.Length - 1)
                                                b_str += b[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                b_str += b[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "b(x)",
                                                Poly_Coefficients = b_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }

                                        for (int i = 0; i < result.Length; i++)
                                        {
                                            if (i == result.Length - 1)
                                                res_str += result[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                res_str += result[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Galua_Result Result = new Galua_Result
                                            {
                                                Operation_Name = "multiply",
                                                Result_Coefficients = res_str
                                            };
                                            db.Galua_Result.Add(Result);

                                            db.SaveChanges();

                                        }
                                        richTextBox1.Text += a_str + ") * (" + b_str + ") = " + res_str + "\r\n";

                                    }
                                }
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                if (deg_b.SelectedItem == null || deg_a.SelectedItem == null)
                                    MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                else
                                {
                                    int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
                                    int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
                                    if (degree_a > m || degree_b > m)
                                        MessageBox.Show("Степени полиномов a(x) и b(x) не должны превышать m");
                                    else
                                    {

                                        int[] a = new int[degree_a + 1];
                                        int[] b = new int[degree_b + 1];
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (((ComboBox)a_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома a(x)");
                                                return;
                                            }
                                            else
                                                a[i] = Convert.ToInt32(((ComboBox)a_boxes[i]).SelectedItem.ToString());
                                        }
                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (((ComboBox)b_boxes[i]).SelectedItem == null)
                                            {
                                                MessageBox.Show($"Введите все элементы полинома b(x)");
                                                return;
                                            }
                                            else
                                                b[i] = Convert.ToInt32(((ComboBox)b_boxes[i]).SelectedItem.ToString());
                                        }


                                        int[][] result = gf.divide(a, b);
                                        richTextBox1.Text += "division result:" + "\r\n" + "a(x) / b(x) = (";
                                        string a_str = "";
                                        string b_str = "";
                                        string res_str = "";
                                        for (int i = 0; i <= degree_a; i++)
                                        {
                                            if (i == a.Length - 1)
                                                a_str += a[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                a_str += a[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "a(x)",
                                                Poly_Coefficients = a_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }

                                        for (int i = 0; i <= degree_b; i++)
                                        {
                                            if (i == b.Length - 1)
                                                b_str += b[i].ToString() + "*x^" + i;
                                            else
                                            {
                                                b_str += b[i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Polynomial Poly = new Polynomial
                                            {
                                                Poly_Name = "b(x)",
                                                Poly_Coefficients = b_str
                                            };
                                            db.Polynomial.Add(Poly);

                                            db.SaveChanges();

                                        }
                                        res_str += "q = ";
                                        for (int i = 0; i < result[0].Length; i++)
                                        {
                                            if (i == result[0].Length - 1)
                                                res_str += result[0][i].ToString() + "*x^" + i + "\r\n";
                                            else
                                            {
                                                res_str += result[0][i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        res_str += "r = ";
                                        for (int i = 0; i < result[1].Length; i++)
                                        {
                                            if (i == result[1].Length - 1)
                                                res_str += result[1][i].ToString() + "*x^" + i;
                                            else
                                            {
                                                res_str += result[1][i].ToString() + "*x^" + i + " + ";
                                            }
                                        }
                                        using (ApplicationContext db = new ApplicationContext())
                                        {
                                            Galua_Result Result = new Galua_Result
                                            {
                                                Operation_Name = "division",
                                                Result_Coefficients = res_str
                                            };
                                            db.Galua_Result.Add(Result);

                                            db.SaveChanges();

                                        }
                                        richTextBox1.Text += a_str + ") / (" + b_str + "):\r\n" + res_str + "\r\n";
                                    }
                                }
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calc_value_polynomial_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                int x = Convert.ToInt32(x_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                if (radioButton1.Checked)
                                {
                                    if (deg_a.SelectedItem == null)
                                        MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                    else
                                    {
                                        int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
                                        if (degree_a > m)
                                            MessageBox.Show("Степень полинома a(x) не должна превышать m");
                                        else
                                        {

                                            int[] a = new int[degree_a + 1];
                                            for (int i = 0; i <= degree_a; i++)
                                            {
                                                if (((ComboBox)a_boxes[i]).SelectedItem == null)
                                                {
                                                    MessageBox.Show($"Введите все элементы полинома a(x)");
                                                    return;
                                                }
                                                else
                                                    a[i] = Convert.ToInt32(((ComboBox)a_boxes[i]).SelectedItem.ToString());
                                            }


                                            int result = gf.calc_value_polynomial(a, x);
                                            richTextBox1.Text += "calc result:" + "\r\n" + "a(" + x + ") = ";
                                            string a_str = "";
                                            string res_str = result.ToString();
                                            for (int i = 0; i <= degree_a; i++)
                                            {
                                                if (i == a.Length - 1)
                                                    a_str += a[i].ToString() + "*x^" + i + " ";
                                                else
                                                {
                                                    a_str += a[i].ToString() + "*x^" + i + " + ";
                                                }
                                            }
                                            using (ApplicationContext db = new ApplicationContext())
                                            {
                                                Polynomial Poly = new Polynomial
                                                {
                                                    Poly_Name = "a(x)",
                                                    Poly_Coefficients = a_str
                                                };
                                                db.Polynomial.Add(Poly);

                                                db.SaveChanges();

                                            }
                                            using (ApplicationContext db = new ApplicationContext())
                                            {
                                                Galua_Result Result = new Galua_Result
                                                {
                                                    Operation_Name = "calc_value",
                                                    Result_Coefficients = res_str
                                                };
                                                db.Galua_Result.Add(Result);

                                                db.SaveChanges();

                                            }
                                            richTextBox1.Text += a_str + " = " + res_str + "\r\n";
                                        }
                                    }
                                }
                                if (radioButton2.Checked)
                                {
                                    if (deg_b.SelectedItem == null)
                                        MessageBox.Show("Введите степени полиномов a(x) и b(x)");
                                    else
                                    {
                                        int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
                                        if (degree_b > m)
                                            MessageBox.Show("Степень полинома a(x) не должна превышать m");
                                        else
                                        {

                                            int[] b = new int[degree_b + 1];
                                            for (int i = 0; i <= degree_b; i++)
                                            {
                                                if (((ComboBox)b_boxes[i]).SelectedItem == null)
                                                {
                                                    MessageBox.Show($"Введите все элементы полинома a(x)");
                                                    return;
                                                }
                                                else
                                                    b[i] = Convert.ToInt32(((ComboBox)b_boxes[i]).SelectedItem.ToString());
                                            }


                                            int result = gf.calc_value_polynomial(b, x);
                                            richTextBox1.Text += "calc result:" + "\r\n" + "b(" + x + ") = ";
                                            string b_str = "";
                                            string res_str = result.ToString();
                                            for (int i = 0; i <= degree_b; i++)
                                            {
                                                if (i == b.Length - 1)
                                                    b_str += b[i].ToString() + "*x^" + i + " ";
                                                else
                                                {
                                                    b_str += b[i].ToString() + "*x^" + i + " + ";
                                                }
                                            }
                                            using (ApplicationContext db = new ApplicationContext())
                                            {
                                                Polynomial Poly = new Polynomial
                                                {
                                                    Poly_Name = "b(x)",
                                                    Poly_Coefficients = b_str
                                                };
                                                db.Polynomial.Add(Poly);

                                                db.SaveChanges();

                                            }
                                            using (ApplicationContext db = new ApplicationContext())
                                            {
                                                Galua_Result Result = new Galua_Result
                                                {
                                                    Operation_Name = "calc_value",
                                                    Result_Coefficients = res_str
                                                };
                                                db.Galua_Result.Add(Result);

                                                db.SaveChanges();

                                            }
                                            richTextBox1.Text += b_str + "= " + result + "\r\n";
                                        }
                                    }
                                }
                                if (radioButton2.Checked == false && radioButton1.Checked == false)
                                    MessageBox.Show("Выберите полином для вычисления в точке");
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enter_polynomial_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);

                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            if (gf != null)
                            {
                                label_a.Visible = true;
                                label_b.Visible = true;
                                label_deg_a.Visible = true;
                                label_deg_b.Visible = true;
                                deg_a.Visible = true;
                                deg_b.Visible = true;
                                deg_a.Enabled = true;
                                deg_b.Enabled = true;
                                if (deg_a.Items != null)
                                {
                                    deg_a.Items.Clear();
                                    deg_b.Items.Clear();
                                }
                                for (int i = 0; i <= m; i++)
                                {
                                    deg_a.Items.Add(i.ToString());
                                    deg_b.Items.Add(i.ToString());
                                }
                            }
                            else MessageBox.Show("Необходимо построить поле");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deg_a_SelectedIndexChanged(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(q_.Value);
            int m = Convert.ToInt32(m_.Value);
            int degree_a = Convert.ToInt32(deg_a.SelectedItem.ToString());
            for (int i = 0; i <= degree_a; i++)
            {
                ((ComboBox)a_boxes[i]).Visible = true;
                ((ComboBox)a_boxes[i]).Enabled = true;
                ((Label)a_labels[i]).Visible = true;
            }
            for (int i = degree_a + 1; i < a_boxes.Count; i++)
            {
                ((ComboBox)a_boxes[i]).Visible = false;
                ((ComboBox)a_boxes[i]).Enabled = false;
                ((Label)a_labels[i]).Visible = false;
            }
            if (a_x0.Items != null)
            {
                for (int i = 0; i < a_boxes.Count; i++)
                {
                    ((ComboBox)a_boxes[i]).Items.Clear();
                    ((ComboBox)b_boxes[i]).Items.Clear();
                }
            }
            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < a_boxes.Count; j++)
                {
                    ((ComboBox)a_boxes[j]).Items.Add(i.ToString());
                    ((ComboBox)b_boxes[j]).Items.Add(i.ToString());
                }
            }
        }

        private void deg_b_SelectedIndexChanged(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(q_.Value);
            int m = Convert.ToInt32(m_.Value);
            int degree_b = Convert.ToInt32(deg_b.SelectedItem.ToString());
            for (int i = 0; i <= degree_b; i++)
            {
                ((ComboBox)b_boxes[i]).Visible = true;
                ((ComboBox)b_boxes[i]).Enabled = true;
                ((Label)b_labels[i]).Visible = true;
            }
            for (int i = degree_b + 1; i < a_boxes.Count; i++)
            {
                ((ComboBox)b_boxes[i]).Visible = false;
                ((ComboBox)b_boxes[i]).Enabled = false;
                ((Label)b_labels[i]).Visible = false;
            }
            if (a_x0.Items != null)
            {
                for (int i = 0; i < a_boxes.Count; i++)
                {
                    ((ComboBox)a_boxes[i]).Items.Clear();
                    ((ComboBox)b_boxes[i]).Items.Clear();
                }
            }
            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < a_boxes.Count; j++)
                {
                    ((ComboBox)a_boxes[j]).Items.Add(i.ToString());
                    ((ComboBox)b_boxes[j]).Items.Add(i.ToString());
                }
            }
        }

        private void записьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("File saved");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);

                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            label11.Visible = true;
                            for (int i = 0; i <= m; i++)
                            {
                                ((ComboBox)g_boxes[i]).Visible = true;
                                ((ComboBox)g_boxes[i]).Enabled = true;
                                ((Label)g_labels[i]).Visible = true;
                            }
                            for (int i = m + 1; i < g_boxes.Count; i++)
                            {
                                ((ComboBox)g_boxes[i]).Visible = false;
                                ((ComboBox)g_boxes[i]).Enabled = false;
                                ((Label)g_labels[i]).Visible = false;
                            }
                            if (comboBox7.Items != null)
                            {
                                for (int i = 0; i < g_boxes.Count; i++)
                                {
                                    ((ComboBox)g_boxes[i]).Items.Clear();
                                }
                            }
                            for (int i = 0; i < q; i++)
                            {
                                for (int j = 0; j < g_boxes.Count; j++)
                                {
                                    ((ComboBox)g_boxes[j]).Items.Add(i.ToString());
                                }
                            }
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int q = Convert.ToInt32(q_.Value);
                int m = Convert.ToInt32(m_.Value);
                if (q > 1)
                {
                    if (m > 0)
                    {
                        //gf = new GaluaField(q, m);
                        if (is_prime(q))
                        {
                            int[] g = new int[m + 1];
                            for (int i = 0; i <= m; i++)
                            {
                                if (((ComboBox)g_boxes[i]).SelectedItem == null)
                                {
                                    MessageBox.Show($"Введите все элементы неприводимого полинома");
                                    return;
                                }
                                else
                                    g[i] = Convert.ToInt32(((ComboBox)g_boxes[i]).SelectedItem.ToString());
                            }
                            gf = new GaluaField(q, m, g);
                            
                            

                            if (gf.is_irreducible(g))
                            {
                                gf.building_field(g);
                                int[][] Galua_field = gf.field;
                                if (Galua_field[0] != null)
                                {
                                    richTextBox1.Text += "Field:" + "\r\n";
                                    for (int i = 0; i < Galua_field.Length; i++)
                                    {
                                        for (int j = 0; j < Galua_field[i].Length; j++)
                                        {
                                            if (j == 0)
                                                richTextBox1.Text += i + ": " + Galua_field[i][j];
                                            else
                                                richTextBox1.Text += " + " + Galua_field[i][j] + "*a^" + i;
                                        }
                                        richTextBox1.Text += "\r\n";
                                    }
                                }
                                else MessageBox.Show("Введите другой неприводимый многочлен. По введенному ранее многочлену не удалось построить поле");
                            }
                            else MessageBox.Show("Введеный вами многочлен приводим");
                        }
                        else MessageBox.Show("Введеный вами q не является простым");
                    }
                    else MessageBox.Show("Введите m > 0");
                }
                else MessageBox.Show("Введедите q > 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Polynomial
    {
        [Key]
        public int Id_Poly { get; set; }
        public string Poly_Name { get; set; }
        public string Poly_Coefficients { get; set; }

    }

    public class Galua_Result
    {
        [Key]
        public int Id_Result { get; set; }
        public string Operation_Name { get; set; }
        public string Result_Coefficients { get; set; }

    }
    public class ApplicationContext : DbContext
    {
        public DbSet<Polynomial> Polynomial { get; set; }
        public DbSet<Galua_Result> Galua_Result { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-LM56M1Q; Database = university; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }

}
