using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sude = 0;
        int liche = 0;
        int celkem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader ctenar = new StreamReader("cislo.txt");
            while (!ctenar.EndOfStream)
            {
                int cislo = int.Parse(ctenar.ReadLine());
                listBox1.Items.Add(cislo);
                celkem += cislo;
                if ((cislo) % 2 == 0)
                {
                    sude++;
                }
                else
                {
                    liche++;
                }
            }
            ctenar.Close();
            StreamWriter zapis = new StreamWriter("cislo.txt", true);
            zapis.WriteLine(celkem);
            zapis.WriteLine(sude);
            zapis.WriteLine(liche);
            zapis.Close();
            StreamReader protoze_listbox = new StreamReader("cislo.txt");
            while (!protoze_listbox.EndOfStream)
            {
                listBox2.Items.Add(protoze_listbox.ReadLine());
            }
            protoze_listbox.Close();
        }
    }
}
