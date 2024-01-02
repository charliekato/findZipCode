using System;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace findZipCode
{
    public partial class Form1 : Form
    {
        private const string magicWord = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        private const string magicTail = ";Extended Properties='Excel 12.0; HDR=Yes'";
        public const string excelFile = "zipcode.xlsx";
        public string city;
        public string pref;
        public string street;
         public Form1()
        {
            InitializeComponent();
            get_pref_list();
            myinit();
        }

        private void myinit()
        {
            lbxCity.SelectionMode = SelectionMode.One;
            lbxPref.SelectionMode = SelectionMode.One;
            lbxStreet.SelectionMode = SelectionMode.One;
            lblPostalCode.Text = string.Empty;
            this.Width = 800;
        }
        public void get_pref_list()
        {
            String connectionString = magicWord + excelFile + magicTail;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT prefNo, pref from [pref$] order by prefNo;";
                OleDbCommand comm = new OleDbCommand(query, conn);
                conn.Open();
                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        this.lbxPref.Items.Add(Convert.ToString(dr["pref"]));
                    }
                }
            }
        }

        private void lbxPref_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = magicWord + excelFile + magicTail;
            this.lbxCity.Items.Clear();
            pref = Convert.ToString(lbxPref.SelectedItem);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT DISTINCT city from [zipcode$] where pref = \"" + pref + "\";";
                OleDbCommand comm = new OleDbCommand(query, conn);
                conn.Open();
                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        this.lbxCity.Items.Add(Convert.ToString(dr["city"]));
                    }
                }
            }
        }



        private void lbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = magicWord + excelFile + magicTail;
            const string others = "以下に掲載がない場合";
            this.lbxStreet.Items.Clear();
            city = Convert.ToString(lbxCity.SelectedItem);
            this.lbxStreet.Items.Add(others);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT DISTINCT street from [zipcode$] where pref = \""+
                    pref + "\" AND city = \"" + city + "\";";
                OleDbCommand comm = new OleDbCommand(query, conn);
                conn.Open();
                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        street = Convert.ToString(dr["street"]);
                        if (street != others)
                        this.lbxStreet.Items.Add(street);
                    }
                }
            }

        }

        private void lbxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = magicWord + excelFile + magicTail;
            street = Convert.ToString(lbxStreet.SelectedItem);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT zipcode from [zipcode$] where pref = \"" + 
                    pref+ "\" AND city = \"" + city + 
                    "\" AND street = \"" + street + "\";";
                OleDbCommand comm = new OleDbCommand(query, conn);
                conn.Open();
                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string postalNumber = Convert.ToString(dr["zipcode"]);
                        string postalCode = postalNumber.Insert(3, "-");
                        this.lblPostalCode.Text = pref+city+street+ "の郵便番号は " + postalCode;
                    }
                }
            }
        }

    }

}

