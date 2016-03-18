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
            var res = AuroraDb.Main.ExecuteCommand((ConnectionTypes)cmbDatabase.SelectedIndex, "cards", (ReturnTypes)cmbReturnType.SelectedIndex, new List<DbParam>());

            switch ((ReturnTypes)cmbReturnType.SelectedIndex)
            {
                case ReturnTypes.DataTable:
                    tbl.DataSource = res;
                    break;
                case ReturnTypes.JsonString:
                    txtResultText.Text = res.ToString();
                    break;
                case ReturnTypes.List:
                    lblTotal.Text = ((List<Dictionary<string, object>>)res).Count.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReturnType.SelectedIndex = 0;
            cmbDatabase.SelectedIndex = 2;

            AuroraDb.Main.AddConnection((ConnectionTypes)cmbDatabase.SelectedIndex, "Server = DESKTOP-2OBTFN2\\SQLEXPRESS; Database = ipss_tes; User Id = sertac;Password = exitexit1;");
            AuroraDb.Main.AddQuery((ConnectionTypes)cmbDatabase.SelectedIndex, "cards", "SELECT [TOTAL_CARD],[TOTAL_SOLD] ,[TOTAL_LEFT] FROM[ipss_tes].[dbo].[v_card_stock]");
        }
    }
}
