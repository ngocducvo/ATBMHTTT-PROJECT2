using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class QuanlyChuyenmon : Form
    {
        OracleConnection connection;
        string str = "";
        OracleDataAdapter adapter;
        OracleCommand command;
        public QuanlyChuyenmon(OracleConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }
    }
}
