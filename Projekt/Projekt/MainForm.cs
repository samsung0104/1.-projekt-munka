using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt
{
	public partial class MainForm : Form
	{
		        struct mtszka
        {
            public string ev,nap,honap,helyszin,esemeny,esemenytipus,ora,perc;
        }
		public MainForm()
		{
			
			InitializeComponent();
			
			for (int i = 1999; i <= 2021; i++)
				{
				   string[] numbers = { i.ToString() };
				   comboBox1.Items.AddRange(numbers);
				}
			for (int i = 1; i <= 24; i++)
				{
				   string[] numbers = { i.ToString() };
				   comboBox5.Items.AddRange(numbers);
				}
			for (int i = 1; i <= 60; i++)
				{
				   string[] numbers = { i.ToString() };
				   comboBox7.Items.AddRange(numbers);
				}

			for (int i = 1; i <= 31; i++)
				{
				   string[] numbers = { i.ToString() };
				   comboBox3.Items.AddRange(numbers);
				}
						for (int i = 1; i <= 12; i++)
				{
				   string[] numbers = { i.ToString() };
				   comboBox2.Items.AddRange(numbers);
				}
						comboBox4.Items.Add("Mátészalka"); 
						comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
						comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
						comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
						comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
						comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
						comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
						

		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			bool tovabb=false;
			int fajlsor=0;

			if(comboBox1.Text=="" || comboBox2.Text==""|| comboBox3.Text==""||comboBox4.Text==""||textBox1.Text==""||textBox2.Text==""||textBox3.Text==""){MessageBox.Show("Nem töltöttél ki minden mezőt!");tovabb=false;}
			else tovabb = true;

			if(tovabb==true)
			{
				string[] adat = new string[10];
				adat[0] = comboBox1.Text;
				adat[1] = comboBox2.Text;
				adat[2] = comboBox3.Text;
				adat[3] = comboBox4.Text;
				adat[4] = textBox1.Text;
				adat[5] = textBox2.Text;
				adat[6] = textBox3.Text;
				adat[7] = comboBox5.Text;
				adat[8] = comboBox7.Text;
				List <mtszka> kiir = new List<mtszka>();
				StreamReader sr = new StreamReader(@"D:\\names.txt");
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                mtszka m = new mtszka();
                m.ev = darabok[0];
                m.nap = darabok[1];
                m.honap = darabok[2];
                m.helyszin = darabok[3];
                m.esemeny = darabok[4];
                m.esemenytipus = darabok[5];
                m.ora = darabok[6];
                m.perc = darabok[7];
                kiir.Add(m);
                fajlsor++;
            }
				sr.Close();
				StreamWriter sw = new StreamWriter(@"D:\\names.txt");
				for (int i = 0; i < fajlsor; i++) {
					sw.WriteLine(kiir[i].ev+";"+kiir[i].honap+";"+kiir[i].nap+";"+kiir[i].helyszin+";"+kiir[i].esemeny+";"+kiir[i].esemenytipus+";"+kiir[i].ora+";"+kiir[i].perc);
				}
				sw.WriteLine(adat[0]+";"+adat[1]+";"+adat[2]+";"+adat[3]+";"+adat[4]+";"+adat[5]+";"+adat[7]+";"+adat[8]);
				sw.Close();
			}
			tovabb = false;
			
		}
		
	}
}
