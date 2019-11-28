using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    static class Program
    {
        public static MySqlConnection con = null;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "localhost"; //--host megnevezése
                sb.UserID = "root";
                sb.Password = "";
                sb.Database = "latvanyossagokdb";
                sb.CharacterSet = "utf8"; //--karakterkódolás
                con = new MySqlConnection(sb.ToString());
            try
            {
                con.Open(); //--ha nem ad hibaüzenetet, elérhető

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
                
                MySqlCommand command = con.CreateCommand();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
