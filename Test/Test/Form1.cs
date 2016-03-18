using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuroraDb.DataClasses;
using AuroraDb.enums;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuroraDb.Main.AddConnection(ConnectionTypes.SQL_SERVER, " Server = DESKTOP-serv\\SQLEXPRESS; Database =test_db; User Id = sertac;Password = 12345;");
            AuroraDb.Main.AddQuery(ConnectionTypes.SQL_SERVER, "cards", "SELECT [TOTAL_CARD],[TOTAL_SOLD] ,[TOTAL_LEFT] FROM[example_table].[dbo].[v_card_stock]");

            var res = AuroraDb.Main.ExecuteCommand(ConnectionTypes.SQL_SERVER, "cards", ReturnTypes.DataTable, new List<DbParam>());

            tbl.DataSource = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
