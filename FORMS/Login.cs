using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;


namespace MusicPlaylistManagementDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Data Source = DESKTOP - AGRMJ4O\SQLEXPRESS;Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False
        // string connectionString = "Data Source = DESKTOP-AGRMJ4O\\SQLEXPRESS;Initial Catalog = MusicPlaylistDB; Integrated Security = True";
        // SqlConnection connection = new SqlConnection("connectionString");
        readonly SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog = MusicPlaylistDB; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
            {
                MessageBox.Show("Login Success");
            }
                else
            {
                MessageBox.Show("Login Failed");
            }
        }
            //MessageBox.Show("opening");
            /*openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                {
                listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());
            }*/
        }
    

       

      /*  private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();*/
        }

      /*  private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("closing");
        }
    }*/

