using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizzeria
{
    public partial class Form_Menuvalasztek : Form
    {
         static List<Pizzak> pizzak = new List<Pizzak>();
        public Form_Menuvalasztek()
        {
            InitializeComponent();
        }

        private void button4_Adat_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==openFileDialog1.ShowDialog())
            {
                using (StreamReader olvas=new StreamReader(openFileDialog1.FileName))
                {
                    while (!olvas.EndOfStream)
                    {
                        Pizzak pi = new Pizzak(olvas.ReadLine());
                        pizzak.Add(pi);
                    }
                    olvas.Close();
                }
            }
            for (int i = 0; i < pizzak.Count; i++)
            {
                checkBox1_Vege.Text = pizzak[0].Nev;
                checkBox2_Magyaros.Text = pizzak[1].Nev;
                checkBox3_Sonkas.Text = pizzak[2].Nev;
                checkBox4_Mediterran.Text = pizzak[3].Nev;
                checkBox5_Tonhal.Text = pizzak[4].Nev;
                radioButton1_Kicsi1.Text = pizzak[0].Kicsi.ToString()+"Ft";
                radioButton2_Kicsi2.Text = pizzak[1].Kicsi.ToString()+"Ft";
                radioButton3_Kicsi3.Text = pizzak[2].Kicsi.ToString()+"Ft";
                radioButton4_Kicsi4.Text = pizzak[3].Kicsi.ToString()+"Ft";
                radioButton5_Kicsi5.Text = pizzak[4].Kicsi.ToString()+"Ft";
                radioButton6_Nagy1.Text = pizzak[0].Nagy.ToString()+"Ft";
                radioButton7_Nagy2.Text = pizzak[1].Nagy.ToString()+"Ft";
                radioButton8_Nagy3.Text = pizzak[2].Nagy.ToString()+"Ft";
                radioButton9_Nagy4.Text = pizzak[3].Nagy.ToString()+"Ft";
                radioButton10_Nagy5.Text = pizzak[4].Nagy.ToString()+"Ft";
            }
        }

        private void button1_Szamol_Click(object sender, EventArgs e)
        {
            if (checkBox1_Vege.Checked==true && radioButton1_Kicsi1.Checked==true && String.IsNullOrEmpty(textBox2_Vege.Text))
            {
                
            }
            else if (checkBox2_Magyaros.Checked==true && radioButton2_Kicsi2.Checked==true && String.IsNullOrEmpty(textBox2_Vege.Text))
            {
                
            }
            else if (checkBox3_Sonkas.Checked==true && radioButton3_Kicsi3.Checked==true && String.IsNullOrEmpty(textBox4_Sonkas.Text))
            {

            }
            else if (checkBox4_Mediterran.Checked==true && radioButton4_Kicsi4.Checked==true && String.IsNullOrEmpty(textBox5_Mediterran.Text))
            {

            }
            else if (checkBox5_Tonhal.Checked==true && radioButton5_Kicsi5.Checked==true && String.IsNullOrEmpty(textBox6_Tonhal.Text))
            {

            }
            else if (checkBox1_Vege.Checked==true && radioButton6_Nagy1.Checked==true && String.IsNullOrEmpty(textBox2_Vege.Text))
            {

            }
            else if (checkBox2_Magyaros.Checked==true && radioButton7_Nagy2.Checked==true && String.IsNullOrEmpty(textBox3_Magyar.Text))
            {

            }
            else if (checkBox3_Sonkas.Checked==true && radioButton8_Nagy3.Checked==true && String.IsNullOrEmpty(textBox4_Sonkas.Text)) 
            {

            }
            else if (checkBox4_Mediterran.Checked==true && radioButton9_Nagy4.Checked==true && String.IsNullOrEmpty(textBox5_Mediterran.Text)) 
            {

            }
            else if (checkBox5_Tonhal.Checked==true && radioButton10_Nagy5.Checked==true && String.IsNullOrEmpty(textBox6_Tonhal.Text))
            {

            }
            else
            {

            }
        }

        private void button2_Torol_Click(object sender, EventArgs e)
        {
            checkBox1_Vege.Checked = false;
            checkBox2_Magyaros.Checked = false;
            checkBox3_Sonkas.Checked = false;
            checkBox4_Mediterran.Checked = false;
            checkBox5_Tonhal.Checked = false;
            radioButton1_Kicsi1.Checked = false;
            radioButton2_Kicsi2.Checked = false;
            radioButton3_Kicsi3.Checked = false;
            radioButton4_Kicsi4.Checked = false;
            radioButton5_Kicsi5.Checked = false;
            radioButton6_Nagy1.Checked = false;
            radioButton7_Nagy2.Checked = false;
            radioButton8_Nagy3.Checked = false;
            radioButton9_Nagy4.Checked = false;
            radioButton10_Nagy5.Checked = false;
            textBox2_Vege.Text = "";
            textBox3_Magyar.Text = "";
            textBox4_Sonkas.Text = "";
            textBox5_Mediterran.Text = "";
            textBox6_Tonhal.Text = "";
            textBox1_Fizetendo.Text = "";
        }

        private void button3_Bezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
