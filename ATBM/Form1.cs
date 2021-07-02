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
    public partial class Form1 : Form
    {
        OracleConnection conn = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = xe))); User Id = SYS; Password = 1234; DBA Privilege=SYSDBA;");
        //conn.ConnectionString = @"Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = xe))); User Id = SYS; Password = 1234; DBA Privilege=SYSDBA;";
        string str = "";
        OracleDataAdapter adapter;
        OracleCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("USERS_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_users.DataSource = data;


                command = new OracleCommand("ROLES_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_roles.DataSource = data2;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("DROP_ROLE", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@roleName", OracleDbType.Varchar2).Value = tb_roleName.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Role successful deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("ADD_USER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@userName", OracleDbType.Varchar2).Value = tb_userName_create.Text;
                command.Parameters.Add("@pass", OracleDbType.Varchar2).Value = tb_userPass_Create.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("User successful created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_role_create_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("ADD_ROLE", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@roleName", OracleDbType.Varchar2).Value = tb_roleName.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Role successful created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_user_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("DROP_USER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@userName", OracleDbType.Varchar2).Value = tb_username_del.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("User successful deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            conn.Open();
            try
            {
                command = new OracleCommand("USER_PRIVI_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = dgv_users.Rows[numrow].Cells[0].Value.ToString();
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_user_privi.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void dgv_roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            conn.Open();
            try
            {
                command = new OracleCommand("USER_PRIVI_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = dgv_roles.Rows[numrow].Cells[0].Value.ToString();
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_role_privi.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("USERS_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_users.DataSource = data;


                command = new OracleCommand("ROLES_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_roles.DataSource = data2;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("GRANT_PRIVI", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", OracleDbType.Varchar2).Value = tb_name_pri.Text;
                command.Parameters.Add("@tableName", OracleDbType.Varchar2).Value = cb_name_table.Text;
                command.Parameters.Add("@columnName", OracleDbType.Varchar2).Value = tb_col.Text;
                if(check_select.Checked == true)
                {
                    command.Parameters.Add("@se", OracleDbType.Varchar2).Value = "SELECT";
                }
                else
                {
                    command.Parameters.Add("@se", OracleDbType.Varchar2).Value = "";
                }

                if (check_insert.Checked == true)
                {
                    command.Parameters.Add("@ins", OracleDbType.Varchar2).Value = "INSERT";
                }
                else
                {
                    command.Parameters.Add("@ins", OracleDbType.Varchar2).Value = "";
                }

                if (check_update.Checked == true)
                {
                    command.Parameters.Add("@upd", OracleDbType.Varchar2).Value = "UPDATE";
                }
                else
                {
                    command.Parameters.Add("@upd", OracleDbType.Varchar2).Value = "";
                }

                if (check_delete.Checked == true)
                {
                    command.Parameters.Add("@dele", OracleDbType.Varchar2).Value = "DELETE";
                }
                else
                {
                    command.Parameters.Add("@dele", OracleDbType.Varchar2).Value = "";
                }

                if (check_with.Checked == true)
                {
                    command.Parameters.Add("@withg", OracleDbType.Varchar2).Value = "WITH GRANT OPTION";
                }
                else
                {
                    command.Parameters.Add("@withg", OracleDbType.Varchar2).Value = "";
                }

                command.ExecuteNonQuery();


                command = new OracleCommand("USER_PRIVI_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = tb_name_pri.Text;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_check_pri.DataSource = data2;


                MessageBox.Show("Successful granted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("REVOKE_PRIVI", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", OracleDbType.Varchar2).Value = tb_name_pri.Text;
                command.Parameters.Add("@tableName", OracleDbType.Varchar2).Value = cb_name_table.Text;
                command.Parameters.Add("@columnName", OracleDbType.Varchar2).Value = tb_col.Text;
                if (check_select.Checked == true)
                {
                    command.Parameters.Add("@se", OracleDbType.Varchar2).Value = "SELECT";
                }
                else
                {
                    command.Parameters.Add("@se", OracleDbType.Varchar2).Value = "";
                }

                if (check_insert.Checked == true)
                {
                    command.Parameters.Add("@ins", OracleDbType.Varchar2).Value = "INSERT";
                }
                else
                {
                    command.Parameters.Add("@ins", OracleDbType.Varchar2).Value = "";
                }

                if (check_update.Checked == true)
                {
                    command.Parameters.Add("@upd", OracleDbType.Varchar2).Value = "UPDATE";
                }
                else
                {
                    command.Parameters.Add("@upd", OracleDbType.Varchar2).Value = "";
                }

                if (check_delete.Checked == true)
                {
                    command.Parameters.Add("@dele", OracleDbType.Varchar2).Value = "DELETE";
                }
                else
                {
                    command.Parameters.Add("@dele", OracleDbType.Varchar2).Value = "";
                }


                command.ExecuteNonQuery();


                command = new OracleCommand("USER_PRIVI_SELECT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = tb_name_pri.Text;
                command.Parameters.Add("@V_CUR_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_check_pri.DataSource = data2;


                MessageBox.Show("Successful revoked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("role2user", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", OracleDbType.Varchar2).Value = tb_user.Text;
                command.Parameters.Add("@rolename", OracleDbType.Varchar2).Value = tb_role.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Successful granted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("USER_ALTER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = tb_update_name.Text;
                command.Parameters.Add("@new_pass", OracleDbType.Varchar2).Value = tb_new_pass.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Successful Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
