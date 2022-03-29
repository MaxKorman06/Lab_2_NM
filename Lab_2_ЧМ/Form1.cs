using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_ЧМ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка виходу
        private void button_exit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        // Кнопка очищення textbox та label
        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_a11.Clear();
            textBox_a12.Clear();
            textBox_a13.Clear();
            textBox_a21.Clear();
            textBox_a22.Clear(); 
            textBox_a23.Clear();
            textBox_a31.Clear();
            textBox_a32.Clear();
            textBox_a33.Clear();
            textBox_x1.Clear();
            textBox_x2.Clear();
            textBox_x3.Clear();
            textBox_error.Clear();

            label_a11.Text = "a11";
            label_a12.Text = "a12";
            label_a13.Text = "a13";
            label_a21.Text = "a21";
            label_a22.Text = "a22";
            label_a23.Text = "a23";
            label_a31.Text = "a31";
            label_a32.Text = "a32";
            label_a33.Text = "a33";
            label_x1.Text = "X1"; 
            label_x2.Text = "X2"; 
            label_x3.Text = "X3";

            label_x1k.Text = "X1";
            label_x2k.Text = "X2";
            label_x3k.Text = "X3";

            label_a11k1.Text = "a11";
            label_a12k1.Text = "a12";
            label_a13k1.Text = "a13";
            label_a21k1.Text = "a21";
            label_a22k1.Text = "a22";
            label_a23k1.Text = "a23";
            label_a31k1.Text = "a31";
            label_a32k1.Text = "a32";
            label_a33k1.Text = "a33";

            label_a11k2.Text = "a11";
            label_a12k2.Text = "a12";
            label_a13k2.Text = "a13";
            label_a21k2.Text = "a21";
            label_a22k2.Text = "a22";
            label_a23k2.Text = "a23";
            label_a31k2.Text = "a31";
            label_a32k2.Text = "a32";
            label_a33k2.Text = "a33";

            label_a11k3.Text = "a11";
            label_a12k3.Text = "a12";
            label_a13k3.Text = "a13";
            label_a21k3.Text = "a21";
            label_a22k3.Text = "a22";
            label_a23k3.Text = "a23";
            label_a31k3.Text = "a31";
            label_a32k3.Text = "a32";
            label_a33k3.Text = "a33";

            label_a11k4.Text = "a11";
            label_a12k4.Text = "a12";
            label_a13k4.Text = "a13";
            label_a21k4.Text = "a21";
            label_a22k4.Text = "a22";
            label_a23k4.Text = "a23";
            label_a31k4.Text = "a31";
            label_a32k4.Text = "a32";
            label_a33k4.Text = "a33";

            label_a11r.Text = "a11";
            label_a12r.Text = "a12";
            label_a13r.Text = "a13";
            label_a21r.Text = "a21";
            label_a22r.Text = "a22";
            label_a23r.Text = "a23";
            label_a31r.Text = "a31";
            label_a32r.Text = "a32";
            label_a33r.Text = "a33";

            label_a11rt.Text = "a11";
            label_a12rt.Text = "a12";
            label_a13rt.Text = "a13";
            label_a21rt.Text = "a21";
            label_a22rt.Text = "a22";
            label_a23rt.Text = "a23";
            label_a31rt.Text = "a31";
            label_a32rt.Text = "a32";
            label_a33rt.Text = "a33";

            label_x1r.Text = "X1";
            label_x2r.Text = "X2";
            label_x3r.Text = "X3";
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 4];
            double[] vector = new double[3];

            matrix[0, 0] = Convert.ToDouble(textBox_a11.Text);
            matrix[0, 1] = Convert.ToDouble(textBox_a12.Text);
            matrix[0, 2] = Convert.ToDouble(textBox_a13.Text);
            matrix[0, 3] = Convert.ToDouble(textBox_x1.Text);
            matrix[1, 0] = Convert.ToDouble(textBox_a21.Text);
            matrix[1, 1] = Convert.ToDouble(textBox_a22.Text);
            matrix[1, 2] = Convert.ToDouble(textBox_a23.Text);
            matrix[1, 3] = Convert.ToDouble(textBox_x2.Text);
            matrix[2, 0] = Convert.ToDouble(textBox_a31.Text);
            matrix[2, 1] = Convert.ToDouble(textBox_a32.Text);
            matrix[2, 2] = Convert.ToDouble(textBox_a33.Text);
            matrix[2, 3] = Convert.ToDouble(textBox_x3.Text);

            vector[0] = Convert.ToDouble(textBox_x1.Text);
            vector[1] = Convert.ToDouble(textBox_x2.Text);
            vector[2] = Convert.ToDouble(textBox_x3.Text);
            
            //Метод Гауса 
            {
                double[,] clone_matrix_gaus = new double[3, 4];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        clone_matrix_gaus[i, j] = matrix[i, j];
                    }
                }

                double a1, a2, a3;

                a1 = 1 / clone_matrix_gaus[0, 0];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[0, i] = a1 * clone_matrix_gaus[0, i];
                }

                a2 = -clone_matrix_gaus[1, 0];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[1, i] = clone_matrix_gaus[1, i] + clone_matrix_gaus[0, i] * a2;
                }

                a3 = -clone_matrix_gaus[2, 0];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[2, i] = clone_matrix_gaus[2, i] + clone_matrix_gaus[0, i] * a3;
                }
                
                double b1, b2, b3, b4;

                b1 = 1 / clone_matrix_gaus[1, 1];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[1, i] = b1 * clone_matrix_gaus[1, i];
                }
                
                b4 = -clone_matrix_gaus[0, 1];

                for (int i = 1; i < 4; i++)
                {
                    clone_matrix_gaus[0, i] = clone_matrix_gaus[0, i] + clone_matrix_gaus[1, i] * b4;
                }
                
                b2 = -clone_matrix_gaus[2, 1];

                for (int i = 1; i < 4; i++)
                {
                    clone_matrix_gaus[2, i] = clone_matrix_gaus[2, i] + clone_matrix_gaus[1, i] * b2;
                }

                b3 = 1 / clone_matrix_gaus[2, 2];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[2, i] = b3 * clone_matrix_gaus[2, i];
                }

                double c1, c2;

                c1 = -clone_matrix_gaus[1, 2];
                c2 = -clone_matrix_gaus[0, 2];

                for (int i = 2; i < 4; i++)
                {
                    clone_matrix_gaus[1, i] = clone_matrix_gaus[1, i] + clone_matrix_gaus[2, i] * c1;
                }

                for (int i = 2; i < 4; i++)
                {
                    clone_matrix_gaus[0, i] = clone_matrix_gaus[0, i] + clone_matrix_gaus[2, i] * c2;
                }


                label_a11.Text = Convert.ToString(clone_matrix_gaus[0, 0]);
                label_a12.Text = Convert.ToString(clone_matrix_gaus[0, 1]);
                label_a13.Text = Convert.ToString(clone_matrix_gaus[0, 2]);
                label_x1.Text = Convert.ToString(clone_matrix_gaus[0, 3]);
                label_a21.Text = Convert.ToString(clone_matrix_gaus[1, 0]);
                label_a22.Text = Convert.ToString(clone_matrix_gaus[1, 1]);
                label_a23.Text = Convert.ToString(clone_matrix_gaus[1, 2]);
                label_x2.Text = Convert.ToString(clone_matrix_gaus[1, 3]);
                label_a31.Text = Convert.ToString(clone_matrix_gaus[2, 0]);
                label_a32.Text = Convert.ToString(clone_matrix_gaus[2, 1]);
                label_a33.Text = Convert.ToString(clone_matrix_gaus[2, 2]);
                label_x3.Text = Convert.ToString(clone_matrix_gaus[2, 3]);
            }
            
            //Метод крамера
            {
                double del, del1, del2, del3;
                double[,] clone_matrix_kramer = new double[3, 3];
                double[,] clone_matrix_kramer1 = new double[3, 3];
                double[,] clone_matrix_kramer2 = new double[3, 3];
                double[,] clone_matrix_kramer3 = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_kramer[i, j] = matrix[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_kramer1[i, j] = clone_matrix_kramer[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_kramer2[i, j] = clone_matrix_kramer[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_kramer3[i, j] = clone_matrix_kramer[i, j];
                    }
                }

                del = del_func(clone_matrix_kramer);

                label_a11k1.Text = Convert.ToString(clone_matrix_kramer[0, 0]);
                label_a12k1.Text = Convert.ToString(clone_matrix_kramer[0, 1]);
                label_a13k1.Text = Convert.ToString(clone_matrix_kramer[0, 2]);
                label_a21k1.Text = Convert.ToString(clone_matrix_kramer[1, 0]);
                label_a22k1.Text = Convert.ToString(clone_matrix_kramer[1, 1]);
                label_a23k1.Text = Convert.ToString(clone_matrix_kramer[1, 2]);
                label_a31k1.Text = Convert.ToString(clone_matrix_kramer[2, 0]);
                label_a32k1.Text = Convert.ToString(clone_matrix_kramer[2, 1]);
                label_a33k1.Text = Convert.ToString(clone_matrix_kramer[2, 2]);

                clone_matrix_kramer1[0, 0] = vector[0];
                clone_matrix_kramer1[1, 0] = vector[1];
                clone_matrix_kramer1[2, 0] = vector[2];

                del1 = del_func(clone_matrix_kramer1);

                label_a11k2.Text = Convert.ToString(clone_matrix_kramer1[0, 0]);
                label_a12k2.Text = Convert.ToString(clone_matrix_kramer1[0, 1]);
                label_a13k2.Text = Convert.ToString(clone_matrix_kramer1[0, 2]);
                label_a21k2.Text = Convert.ToString(clone_matrix_kramer1[1, 0]);
                label_a22k2.Text = Convert.ToString(clone_matrix_kramer1[1, 1]);
                label_a23k2.Text = Convert.ToString(clone_matrix_kramer1[1, 2]);
                label_a31k2.Text = Convert.ToString(clone_matrix_kramer1[2, 0]);
                label_a32k2.Text = Convert.ToString(clone_matrix_kramer1[2, 1]);
                label_a33k2.Text = Convert.ToString(clone_matrix_kramer1[2, 2]);

                clone_matrix_kramer2[0, 1] = vector[0];
                clone_matrix_kramer2[1, 1] = vector[1];
                clone_matrix_kramer2[2, 1] = vector[2];

                del2 = del_func(clone_matrix_kramer2);

                label_a11k3.Text = Convert.ToString(clone_matrix_kramer2[0, 0]);
                label_a12k3.Text = Convert.ToString(clone_matrix_kramer2[0, 1]);
                label_a13k3.Text = Convert.ToString(clone_matrix_kramer2[0, 2]);
                label_a21k3.Text = Convert.ToString(clone_matrix_kramer2[1, 0]);
                label_a22k3.Text = Convert.ToString(clone_matrix_kramer2[1, 1]);
                label_a23k3.Text = Convert.ToString(clone_matrix_kramer2[1, 2]);
                label_a31k3.Text = Convert.ToString(clone_matrix_kramer2[2, 0]);
                label_a32k3.Text = Convert.ToString(clone_matrix_kramer2[2, 1]);
                label_a33k3.Text = Convert.ToString(clone_matrix_kramer2[2, 2]);
              
                clone_matrix_kramer3[0, 2] = vector[0];
                clone_matrix_kramer3[1, 2] = vector[1];
                clone_matrix_kramer3[2, 2] = vector[2];

                del3 = del_func(clone_matrix_kramer3);

                label_a11k4.Text = Convert.ToString(clone_matrix_kramer3[0, 0]);
                label_a12k4.Text = Convert.ToString(clone_matrix_kramer3[0, 1]);
                label_a13k4.Text = Convert.ToString(clone_matrix_kramer3[0, 2]);
                label_a21k4.Text = Convert.ToString(clone_matrix_kramer3[1, 0]);
                label_a22k4.Text = Convert.ToString(clone_matrix_kramer3[1, 1]);
                label_a23k4.Text = Convert.ToString(clone_matrix_kramer3[1, 2]);
                label_a31k4.Text = Convert.ToString(clone_matrix_kramer3[2, 0]);
                label_a32k4.Text = Convert.ToString(clone_matrix_kramer3[2, 1]);
                label_a33k4.Text = Convert.ToString(clone_matrix_kramer3[2, 2]);

                double x1, x2, x3;

                x1 = div_func(del1, del);
                x2 = div_func(del2, del);
                x3 = div_func(del3, del);

                label_x1k.Text = Convert.ToString(x1);
                label_x2k.Text = Convert.ToString(x2);
                label_x3k.Text = Convert.ToString(x3);
            }

            //Метод оберненої матриці--
            {
                double[,] clone_matrix_revers = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_revers[i, j] = matrix[i, j];
                    }
                }

                double m11, m12, m13, m21, m22, m23, m31, m32, m33,
                       a11, a12, a13, a21, a22, a23, a31, a32, a33,
                       del;

                m11 = (clone_matrix_revers[1, 1] * clone_matrix_revers[2, 2]) - (clone_matrix_revers[2, 1] * clone_matrix_revers[1, 2]);
                a11 = 1 * m11;

                m12 = (clone_matrix_revers[1, 0] * clone_matrix_revers[2, 2]) - (clone_matrix_revers[2, 0] * clone_matrix_revers[1, 2]);
                a12 = -1 * m12;

                m13 = (clone_matrix_revers[1, 0] * clone_matrix_revers[2, 1]) - (clone_matrix_revers[2, 0] * clone_matrix_revers[1, 1]);
                a13 = 1 * m13;

                m21 = (clone_matrix_revers[0, 1] * clone_matrix_revers[2, 2]) - (clone_matrix_revers[2, 1] * clone_matrix_revers[0, 2]);
                a21 = -1 * m21;

                m22 = (clone_matrix_revers[0, 0] * clone_matrix_revers[2, 2]) - (clone_matrix_revers[2, 0] * clone_matrix_revers[0, 2]);
                a22 = 1 * m22;

                m23 = (clone_matrix_revers[0, 0] * clone_matrix_revers[2, 1]) - (clone_matrix_revers[2, 0] * clone_matrix_revers[0, 1]);
                a23 = -1 * m23;

                m31 = (clone_matrix_revers[0, 1] * clone_matrix_revers[1, 2]) - (clone_matrix_revers[1, 1] * clone_matrix_revers[0, 2]);
                a31 = 1 * m31;
                
                m32 = (clone_matrix_revers[0, 0] * clone_matrix_revers[1, 2]) - (clone_matrix_revers[1, 0] * clone_matrix_revers[0, 2]);
                a32 = -1 * m32;

                m33 = (clone_matrix_revers[0, 0] * clone_matrix_revers[1, 1]) - (clone_matrix_revers[1, 0] * clone_matrix_revers[0, 1]);
                a33 = 1 * m33;

                double[,] ally_matrix = new double[3, 3]
                {
                    {a11, a12, a13},
                    {a21, a22, a23},
                    {a31, a32, a33},
                };

                double[,] t_ally_matrix = new double[3, 3]
                {
                    {a11, a21, a31},
                    {a12, a22, a32},
                    {a13, a23, a33},
                };

                double[,] inver_matrix = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        inver_matrix[i, j] = t_ally_matrix[i, j];
                    }
                }

                del = del_func(clone_matrix_revers);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        inver_matrix[i, j] = inver_matrix[i, j] / del;
                    }
                }

                double[] sol = new double[3];

                for (int i = 0; i < 3; i++)
                {
                    sol[i] = inver_matrix[i, 0] * vector[0] + inver_matrix[i, 1] * vector[1] + inver_matrix[i, 2] * vector[2];
                }

                label_a11r.Text = Convert.ToString(ally_matrix[0, 0]);
                label_a12r.Text = Convert.ToString(ally_matrix[0, 1]);
                label_a13r.Text = Convert.ToString(ally_matrix[0, 2]);
                label_a21r.Text = Convert.ToString(ally_matrix[1, 0]);
                label_a22r.Text = Convert.ToString(ally_matrix[1, 1]);
                label_a23r.Text = Convert.ToString(ally_matrix[1, 2]);
                label_a31r.Text = Convert.ToString(ally_matrix[2, 0]);
                label_a32r.Text = Convert.ToString(ally_matrix[2, 1]);
                label_a33r.Text = Convert.ToString(ally_matrix[2, 2]);

                label_a11rt.Text = Convert.ToString(t_ally_matrix[0, 0]);
                label_a12rt.Text = Convert.ToString(t_ally_matrix[0, 1]);
                label_a13rt.Text = Convert.ToString(t_ally_matrix[0, 2]);
                label_a21rt.Text = Convert.ToString(t_ally_matrix[1, 0]);
                label_a22rt.Text = Convert.ToString(t_ally_matrix[1, 1]);
                label_a23rt.Text = Convert.ToString(t_ally_matrix[1, 2]);
                label_a31rt.Text = Convert.ToString(t_ally_matrix[2, 0]);
                label_a32rt.Text = Convert.ToString(t_ally_matrix[2, 1]);
                label_a33rt.Text = Convert.ToString(t_ally_matrix[2, 2]);

                label_x1r.Text = Convert.ToString(sol[0]);
                label_x2r.Text = Convert.ToString(sol[1]);
                label_x3r.Text = Convert.ToString(sol[2]);
            }
            //Метод LU розкладу
            {
                double[,] clone_matrix_lu = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_lu[i, j] = matrix[i, j];
                    }
                }

                double[] clone_vector = new double[3];

                for (int i = 0; i < vector.Length; i++)
                {
                    clone_vector[i] = vector[i];
                }

                double[,] C1;

                clone_matrix_lu = recMatB(clone_matrix_lu, out C1);

            }

        }

        private static double[,] recMatB(double[,] matrix, out double[,] C)
        {
            double[,] B = new double[matrix.GetLength(0), matrix.GetLength(1)];

            C = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                for (int l = 0; l < i + 1; l++)
                {
                    B[l, 0] = matrix[l, 0];
                    if (i > 0)
                    {
                        double sum = 0;
                        //B[i, l];
                        for (int k = 0; k < l; k++)
                        {
                            sum = B[i, k] * C[k, l] + sum;
                        }
                        B[i, l] = matrix[i, l] - sum;
                        sum = 0;
                    }
                }

                for (int l = 0; l < j + 1; l++)
                {
                    C[0, l] = matrix[0, l] / B[0, 0];
                    if (j < 2)
                    {
                        for (int m = 2; m > i - 1; m--)
                        {
                            //c[j,l]
                            double sum = 0;
                            for (int k = 0; k < i; k++)
                            {
                                sum = B[i, k] * C[k, m] + sum;
                            }
                            C[i, m] = (1 / B[i, i]) * (matrix[i, m] - sum);
                            sum = 0;
                        }
                    }
                }
            }
            return B;
        }

        // Знаходження визначника матриці
        static public double del_func(double[,] matrix) 
        {
            double del;

            del = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                  (matrix[0, 1] * matrix[2, 0] * matrix[1, 2]) +
                  (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) -
                  (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) -
                  (matrix[1, 0] * matrix[0, 1] * matrix[2, 2]) -
                  (matrix[0, 0] * matrix[2, 1] * matrix[1, 2]);

            return del;
        }

        // Функція ділення
        public static double div_func(double divd, double divr) 
        {
            double sum;

            sum = divd / divr;

            return sum;
        }
    }
}