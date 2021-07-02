using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class Login : Form
    {
        //ket noi den database
        OracleConnection connection;
        //SqlConnection connection = new SqlConnection("Data Source=ZDEP;Initial Catalog=EcommerceWebsite;Integrated Security=True");
        //Data Source=ZDEP;Initial Catalog=Ecommerce;Integrated Security=True
        string str = "";
        OracleDataAdapter adapter;
        OracleCommand command;
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void blogin_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                connection = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.100.1)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = orcl2))); User Id =" + txtUserNam.Text + "; Password = " + txtUserPassword.Text + ";");
                str = "set role all";
                command = new OracleCommand(str, connection);
                connection.Open();
                command.ExecuteNonQuery();
                str = "select * from session_roles";
                command = new OracleCommand(str, connection);
                //MessageBox.Show(result);select * from session_roles
                result = command.ExecuteScalar().ToString();
                //MessageBox.Show(result);
                connection.Close();
                switch(result)
                {
                    case "BACSI":
                        BACSI cus = new BACSI(connection);
                        this.Hide();
                        cus.ShowDialog();
                        this.Show();
                        break;
                    case "QUANLYNHANSU":
                        QuanlyNhansu qlns = new QuanlyNhansu(connection);
                        this.Hide();
                        qlns.ShowDialog();
                        this.Show();
                        break;
                    case "QUANLYTAIVU":
                        QuanlyTaivu qltv = new QuanlyTaivu(connection);
                        this.Hide();
                        qltv.ShowDialog();
                        this.Show();
                        break;
                    case "TIEPTAN":
                        Tiep_tan tt = new Tiep_tan(connection);
                        this.Hide();
                        tt.ShowDialog();
                        this.Show();
                        break;
                    case "NHANVIENTAIVU":
                        NhanvienTaivu nvtv = new NhanvienTaivu(connection);
                        this.Hide();
                        nvtv.ShowDialog();
                        this.Show();
                        break;
                    case "NHANVIENBANTHUOC":
                        NhanvienBanthuoc nvbt = new NhanvienBanthuoc(connection);
                        this.Hide();
                        nvbt.ShowDialog();
                        this.Show();
                        break;
                    case "KETOAN":
                        Ketoan kt = new Ketoan(connection);
                        this.Hide();
                        kt.ShowDialog();
                        this.Show();
                        break;
                }    
            }
            catch
            {
                MessageBox.Show("Dang nhap khong thanh cong");
            }
            /*if (isSuccessLogin(txtUserNam.Text, txtUserPassword.Text))                   //kiem tra login có thành công.
            {
                str = "SELECT typeUser FROM dbo.[User] WHERE userID = @userID";
                command = new OracleCommand(str, connection);
                command.Parameters.Add("@userID", SqlDbType.Int).Value = userId;
                connection.Open();
                string result = command.ExecuteScalar().ToString();
                connection.Close();

                if (result == "C")
                {
                    Form1 cus = new Form1();
                    this.Hide();
                    cus.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }*/
        }
        /*bool isSuccessLogin(string username, string pass)
        {
            command = new OracleCommand("uspLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@userID", SqlDbType.Int).Direction = ParameterDirection.Output;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            userId = (int)command.Parameters["@userID"].Value;
            if (userId == -1) return false;
            return true;            
        }*/

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
