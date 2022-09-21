using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitoring
{
    public partial class Form1 : Form
    {
        // DB 연결
        string Conn = "Server=localhost;" +
                              "Database=yeonoodb;" +
                              "Uid=root;" +
                              "Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * FROM tbl_sj1_temp  where equipmentCode = 'dc_350_to_06' ORDER BY currentTime DESC LIMIT 100";
                MySqlDataAdapter msda = new MySqlDataAdapter(sql, conn);
                msda.Fill(ds, "tbl_sj1_temp");

                label1.Text = ds.Tables[0].Rows[0]["moltenTempA"].ToString() + "°C";
                aGauge1.Value = float.Parse(ds.Tables[0].Rows[0]["moltenTempA"].ToString());
            }
        }
    }
}
