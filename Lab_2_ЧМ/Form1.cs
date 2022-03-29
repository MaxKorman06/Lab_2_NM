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

            label_a11l.Text = "a11";
            label_a12l.Text = "a12";
            label_a13l.Text = "a13";
            label_a21l.Text = "a21";
            label_a22l.Text = "a22";
            label_a23l.Text = "a23";
            label_a31l.Text = "a31";
            label_a32l.Text = "a32";
            label_a33l.Text = "a33";

            label_a11u.Text = "a11";
            label_a12u.Text = "a12";
            label_a13u.Text = "a13";
            label_a21u.Text = "a21";
            label_a22u.Text = "a22";
            label_a23u.Text = "a23";
            label_a31u.Text = "a31";
            label_a32u.Text = "a32";
            label_a33u.Text = "a33";

            label_x1lu.Text = "X1";
            label_x2lu.Text = "X2";
            label_x3lu.Text = "X3";

            label_a11j.Text = "a11";
            label_a12j.Text = "a12";
            label_a13j.Text = "a13";
            label_a21j.Text = "a21";
            label_a22j.Text = "a22";
            label_a23j.Text = "a23";
            label_a31j.Text = "a31";
            label_a32j.Text = "a32";
            label_a33j.Text = "a33";
            
            label_x1j.Text = "X1";
            label_x2j.Text = "X2";
            label_x3j.Text = "X3";

            label_b1j.Text = "B1";
            label_b2j.Text = "B2";
            label_b3j.Text = "B3";

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 4];
            double[] vector = new double[3];
            double precision = Convert.ToDouble(textBox_error.Text);

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

                double a1;
                double[] a = new double[2];

                a1 = 1 / clone_matrix_gaus[0, 0];
                a[0] = -clone_matrix_gaus[1, 0];
                a[1] = -clone_matrix_gaus[2, 0];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[0, i] = a1 * clone_matrix_gaus[0, i];
                }

                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        clone_matrix_gaus[j + 1, i] = clone_matrix_gaus[j + 1, i] + clone_matrix_gaus[0, i] * a[j];
                    }
                }

                double b1;
                double[] b = new double[2];

                b1 = 1 / clone_matrix_gaus[1, 1];
                b[0] = -clone_matrix_gaus[0, 1];
                b[1] = -clone_matrix_gaus[2, 1];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[1, i] = b1 * clone_matrix_gaus[1, i];
                }

                for (int j = 0, l = 0; l < 2; j += 2, l++)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        clone_matrix_gaus[j, i] = clone_matrix_gaus[j, i] + clone_matrix_gaus[1, i] * b[l];
                    }
                }

                double c1;
                double[] c = new double[2];

                c1 = 1 / clone_matrix_gaus[2, 2];
                c[0] = -clone_matrix_gaus[0, 2];
                c[1] = -clone_matrix_gaus[1, 2];

                for (int i = 0; i < 4; i++)
                {
                    clone_matrix_gaus[2, i] = c1 * clone_matrix_gaus[2, i];
                }

                for (int j = 0; j < 2; j++)
                {
                    for (int i = 2; i < 4; i++)
                    {
                        clone_matrix_gaus[j, i] = clone_matrix_gaus[j, i] + clone_matrix_gaus[2, i] * c[j];
                    }
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
                double[,] matrix_l = new double[3, 3]
                {
                    {1, 0, 0},
                    {0, 1, 0},
                    {0, 0, 1}
                };

                double[,] matrix_u = new double[3, 3];
                double[,] clone_matrix_lu = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_lu[i, j] = matrix[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrix_u[i, j] = clone_matrix_lu[i, j];
                    }
                }
                double[] clone_vector = new double[3];

                for (int i = 0; i < vector.Length; i++)
                {
                    clone_vector[i] = vector[i];
                }
                
                double[] a = new double[2];
                double[] a_l = new double[2];

                a[0] = -matrix_u[1, 0] / matrix_u[0, 0];
                a[1] = -matrix_u[2, 0] / matrix_u[0, 0];
                a_l[0] = -a[0];
                a_l[1] = -a[1];


                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        matrix_u[j + 1, i] = matrix_u[j + 1, i] + matrix_u[0, i] * a[j];
                    }
                }

                double[] b = new double[2];
                double[] b_l = new double[2];

                b[1] = -matrix_u[2, 1] / matrix_u[1, 1];
                b_l[1] = -b[1];

                for (int i = 0; i < 3; i++)
                {
                    matrix_u[2, i] = matrix_u[2, i] + matrix_u[1, i] * b[1];
                }

                matrix_l[1, 0] = a_l[0];
                matrix_l[2, 0] = a_l[1];     
                matrix_l[2, 1] = b_l[1];

                double[] y = new double[3];

                y[0] = matrix_l[0, 0] * clone_vector[0];
                y[1] = clone_vector[1] - matrix_l[1, 0] * y[0];
                y[2] = clone_vector[2] - (matrix_l[2, 0] * y[0]) - (matrix_l[2, 1] * y[1]);

                double[] x = new double[3];
                x[2] = y[2] / matrix_u[2, 2];
                x[1] = (y[1] - matrix_u[1, 2] * x[2]) / matrix_u[1, 1];
                x[0] = ((y[0] - matrix_u[0, 1] * x[1]) - (matrix_u[0, 2] * x[2])) / matrix_u[0, 0];

                label_a11l.Text = Convert.ToString(matrix_l[0, 0]);
                label_a12l.Text = Convert.ToString(matrix_l[0, 1]);
                label_a13l.Text = Convert.ToString(matrix_l[0, 2]);
                label_a21l.Text = Convert.ToString(matrix_l[1, 0]);
                label_a22l.Text = Convert.ToString(matrix_l[1, 1]);
                label_a23l.Text = Convert.ToString(matrix_l[1, 2]);
                label_a31l.Text = Convert.ToString(matrix_l[2, 0]);
                label_a32l.Text = Convert.ToString(matrix_l[2, 1]);
                label_a33l.Text = Convert.ToString(matrix_l[2, 2]);
                
                label_a11u.Text = Convert.ToString(matrix_u[0, 0]);
                label_a12u.Text = Convert.ToString(matrix_u[0, 1]);
                label_a13u.Text = Convert.ToString(matrix_u[0, 2]);
                label_a21u.Text = Convert.ToString(matrix_u[1, 0]);
                label_a22u.Text = Convert.ToString(matrix_u[1, 1]);
                label_a23u.Text = Convert.ToString(matrix_u[1, 2]);
                label_a31u.Text = Convert.ToString(matrix_u[2, 0]);
                label_a32u.Text = Convert.ToString(matrix_u[2, 1]);
                label_a33u.Text = Convert.ToString(matrix_u[2, 2]);
                
                label_x1lu.Text = Convert.ToString(x[0]);
                label_x2lu.Text = Convert.ToString(x[1]);
                label_x3lu.Text = Convert.ToString(x[2]);
            }
            //Метод Якобі
            {
                double[,] clone_matrix_j = new double[3, 3];
                double[] clone_vector = new double[3];

                // копія вектора + його приведення до потрібного виду
                for (int i = 0; i < 3; i++)
                {
                    clone_vector[i] = vector[i];
                    clone_vector[i] = clone_vector[i] / matrix[i, i];
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_j[i, j] = matrix[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        clone_matrix_j[i, j] = -(clone_matrix_j[i, j] / matrix[i, i]);
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == j)
                        {
                            clone_matrix_j[i, j] = 0;
                        }
                    }
                }

                label_a11j.Text = Convert.ToString(clone_matrix_j[0, 0]);
                label_a12j.Text = Convert.ToString(clone_matrix_j[0, 1]);
                label_a13j.Text = Convert.ToString(clone_matrix_j[0, 2]);
                label_a21j.Text = Convert.ToString(clone_matrix_j[1, 0]);
                label_a22j.Text = Convert.ToString(clone_matrix_j[1, 1]);
                label_a23j.Text = Convert.ToString(clone_matrix_j[1, 2]);
                label_a31j.Text = Convert.ToString(clone_matrix_j[2, 0]);
                label_a32j.Text = Convert.ToString(clone_matrix_j[2, 1]);
                label_a33j.Text = Convert.ToString(clone_matrix_j[2, 2]);

                double[] x = new double[3] { 0, 0, 0 };
                double[] xs = new double[3] { 0, 0, 0 };
                double[] max = new double[3];

                double[] del_a1 = new double[4] { 0, 0, 0 ,0};
                double[] del_a2 = new double[4] { 0, 0, 0 ,0};
                double del_a3 = 0;
                double[] del_ah = new double[2] { 0, 0 };

                //Знаходження першої канонічної норми по рядкам
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        del_a1[i+1] += Math.Abs(clone_matrix_j[i, j]);
                    }
                    if (del_a1[i+1] > del_ah[0])
                    {
                        del_ah[0] = del_a1[i+1];
                    }
                }

                // Знаходження 2 канонічної норми по стовпцям
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        del_a2[i + 1] += Math.Abs(clone_matrix_j[j, i]);
                    }
                    if (del_a2[i + 1] > del_ah[1])
                    {
                        del_ah[1] = del_a2[i + 1];
                    }
                }

                // Знаходження 3 канонічної норми
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        del_a3 += Math.Pow(clone_matrix_j[i, j], 2);
                    }
                }

                del_a3 = Math.Sqrt(del_a3);

                label_del1_aj.Text = Convert.ToString(del_ah[0]);
                label_del2_aj.Text = Convert.ToString(del_ah[1]);
                label_del3_aj.Text = Convert.ToString(del_a3);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        xs[j] = x[j];
                    }

                    x[0] = clone_vector[0] + clone_matrix_j[0, 1] * x[1] + clone_matrix_j[0, 2] * x[2];
                    x[1] = clone_vector[1] + clone_matrix_j[1, 0] * x[0] + clone_matrix_j[1, 2] * x[2];
                    x[2] = clone_vector[2] + clone_matrix_j[2, 0] * x[0] + clone_matrix_j[2, 1] * x[1];

                    for (int j = 0; j < 3; j++)
                    {
                        max[j] = Math.Abs(x[j] - xs[j]);
                    }
                    if ((max[0] < precision) && (max[1] < precision) && (max[2] < precision))
                    {
                        break;
                    }
                }


                label_x1j.Text = Convert.ToString(x[0]);
                label_x2j.Text = Convert.ToString(x[1]);
                label_x3j.Text = Convert.ToString(x[2]);

                label_b1j.Text = Convert.ToString(clone_vector[0]);
                label_b2j.Text = Convert.ToString(clone_vector[1]);
                label_b3j.Text = Convert.ToString(clone_vector[2]);
            }
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