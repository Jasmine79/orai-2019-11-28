using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_UjVaros_Click(object sender, EventArgs e)
        {
 
            string varos = textBox_VarosNev.Text;
            int lakossag = Convert.ToInt32(numericUpDown_Lakossag.Value);
            MySqlCommand insert = Program.con.CreateCommand();
            if (textBox_VarosNev.Text.Length==0)
            {
                MessageBox.Show("Nincs megadva a város neve.");
                return;
            }
            else if(numericUpDown_Lakossag.Value==1)
            {
                MessageBox.Show("Nincs megadva a lakosság száma.");
                return;
            }
            try
            {
                insert.CommandText = "INSERT INTO `varosok`(`id`, `nev`, `lakossag`) VALUES (null, '" + varos + "','" + lakossag + "' )";
                insert.ExecuteNonQuery(); //--az előző sorban megírt parancs végrehajtásához
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Program.con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlCommand sql = Program.con.CreateCommand(); //--hivatkozunk a program osztályban létrehozott publikus objektumra
            sql.CommandText = "SELECT `id`, `nev`, `lakossag` FROM `varosok`";
            MySqlDataReader reader = sql.ExecuteReader(); //-- az előző sorban megírt sql parancs végrehajtásához végrehajtásához
            while (reader.Read())
            {
                listBox_FelvettVarosok.Items.Add(new Varosok(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }
            reader.Close();
        }

        private void textBox_VarosNev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
