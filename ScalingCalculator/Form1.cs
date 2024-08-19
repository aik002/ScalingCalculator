using System.Resources;

namespace ScalingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            int xres = resolution.Width;
            int yres = resolution.Height;
            textBox1.Text = Convert.ToString(xres);
            textBox2.Text = Convert.ToString(yres);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Text = ("Quality");
            radioButton4.Text = ("Balanced");
            radioButton5.Text = ("Performance");
            radioButton6.Text = ("Ultra Performance");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Text = ("Ultra Quality");
            radioButton4.Text = ("Quality");
            radioButton5.Text = ("Balanced");
            radioButton6.Text = ("Performance");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xoutput = Convert.ToInt32(textBox1.Text);
            int youtput = Convert.ToInt32(textBox2.Text);

            double xinput = 0;
            double yinput = 0;
            if (radioButton1.Checked)
            { /*FSR1*/
                if (radioButton3.Checked)
                { /*UQ*/
                    xinput = xoutput / 1.3;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 1.3;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton4.Checked)
                { /*Q*/
                    xinput = xoutput / 1.5;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 1.5;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton5.Checked)
                { /*B*/
                    xinput = xoutput / 1.7;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 1.7;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton6.Checked)
                { /*P*/
                    xinput = xoutput / 2;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 2;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }
            }
            if (radioButton2.Checked)
            { /*FSR2*/
                if (radioButton3.Checked)
                { /*Q*/
                    xinput = xoutput / 1.5;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 1.5;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton4.Checked)
                { /*B*/
                    xinput = xoutput / 1.7;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 1.7;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton5.Checked)
                { /*P*/
                    xinput = xoutput / 2;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 2;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }

                if (radioButton6.Checked)
                { /*UP*/
                    xinput = xoutput / 3;
                    xinput = Math.Round(xinput, 0);

                    yinput = youtput / 3;
                    yinput = Math.Round(yinput, 0);

                    textBox3.Text = Convert.ToString(xinput);
                    textBox4.Text = Convert.ToString(yinput);
                }
            }
        }
    }
}
