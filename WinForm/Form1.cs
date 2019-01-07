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
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace WinForm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
        DataSet ds= new DataSet();
        DataTable dt;
        SqlDataAdapter adap= new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             dt = new DataTable("Customer");
            ds.Tables.Add(dt);

            dt = new DataTable("Product");
            ds.Tables.Add(dt);
            dt = new DataTable("Employe");
            ds.Tables.Add(dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void xmlOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Musteri Bilgileri Kayıt";
            saveFileDialog1.Filter = "*.xml|*.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ds.WriteXml(saveFileDialog1.FileName);
            }

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Customers";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
       
            adap.Fill(ds.Tables["Customer"]);
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Products";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
           
            adap.Fill(ds.Tables["Product"]);
            dataGridView1.DataSource = ds.Tables["Product"];

        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Employees";
            cmd.Connection = con;
            adap.SelectCommand = cmd;

            adap.Fill(ds.Tables["Employe"]);
            dataGridView1.DataSource = ds.Tables["Employe"];
        }

        private void jsonOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Musteri Bilgileri Kayıt";
            saveFileDialog1.Filter = "*.json|*.json";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
             string json= JsonConvert.SerializeObject(ds);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }

        private void soapOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Musteri Bilgileri Kayıt";
            saveFileDialog1.Filter = "*.json|*.json";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(ds);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }
    }
}
