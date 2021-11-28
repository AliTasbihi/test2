using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydro_Berger
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            string length = textBox_length.Text;
            string simpson = textBox_simson.Text;
            string y = textBox_y.Text;
            string i = textBox_i.Text;
            if (Check_numbers(length, simpson, y,i)) MessageBox.Show("تمام فیلدها را پر نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Check_asiment(length, simpson, y,i)) MessageBox.Show("مقادیر اشتباه وارد شده هست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Meta_Center meta_Center = new Meta_Center(simpson, y, length,i);
                label_calculate_S.Text = meta_Center.S_Ship.ToString();
                label_calculate_moman.Text = meta_Center.Moman_ship.ToString();
                label_calculate_meta.Text = meta_Center.Mete_ceter.ToString();
            }
        }

        private bool Check_asiment(string length, string simpson, string y,string i)
        {
            List<string> list_numbers_simpson = new List<string>(simpson.Split(" "));
            List<string> list_numbers_y = new List<string>(y.Split(" "));
            if (list_numbers_simpson.Count == list_numbers_y.Count ) return false;
            return true;
        }

        private bool Check_numbers(string lenght,string simpson,string y,string i)
        {
            if (string.IsNullOrEmpty(lenght) || string.IsNullOrEmpty(y) || string.IsNullOrEmpty(simpson)||string.IsNullOrEmpty(i)) return true;
            return false;

        }
    }
}
