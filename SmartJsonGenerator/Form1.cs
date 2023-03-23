using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SmartJsonGenerator
{
    public partial class Form1 : Form
    {
        dynamic root;
        JObject json = new JObject();
        int level = -1;
        int rootLevel = -1;
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Fill;
            panel1.AutoScroll = true;
            groupBox3.AutoSize = true;
            groupBox3.Parent = panel1;
            this.Controls.Add(panel1);

            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Level", typeof(string));
            dt.Columns.Add("Attr", typeof(string));
            dt.Columns.Add("Val", typeof(string));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            JsonString.Text = jsonString;
            string path = Directory.GetCurrentDirectory();
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var file = projectPath + "\\myJson.txt";
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(jsonString);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rootLevel++;
            root = new JArray();
            root.Add(new JObject());
            level++;
            json.Add(RootNameTxtBox.Text, root);
            MessageBox.Show("root added successfully");
            button1.Enabled = false;

        }

        private void AddNewLevelBtn_Click(object sender, EventArgs e)
        {
            
                
            MessageBox.Show("level added successfully");
        }

        private void AddMoreBtn_Click(object sender, EventArgs e)
        {
            if (levelNameTxtBox.Text == "")
            {
                root[level].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
            }
            else
            {
                if (root[level].Property(levelNameTxtBox.Text) != null)
                {
                    var jsonPath = "$." + RootNameTxtBox.Text + "["+level+"]." + levelNameTxtBox.Text;
                    dynamic retrievedObj = (JArray)json.SelectToken(jsonPath);
                    retrievedObj[0].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                }
                else
                {
                    root[level].Add(levelNameTxtBox.Text, new JArray(){
                        new JObject(){
                            {AttributeTxtbox.Text, ValueTxtbox.Text }
                        }
                    });
                }
            }

            
            
            DataRow dr = dt.NewRow();
            dr["No"] = level;
            dr["Level"] = (levelNameTxtBox.Text != "")? levelNameTxtBox.Text : "";
            dr["Attr"] = (AttributeTxtbox.Text !="") ? AttributeTxtbox.Text : "";
            dr["Val"] = (ValueTxtbox.Text != "") ? ValueTxtbox.Text : "";
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Attribute added successfully");
            levelNameTxtBox.Text = "";
            AttributeTxtbox.Text = "";
            ValueTxtbox.Text = "";
        }

        private void AddNewRootElement_Click(object sender, EventArgs e)
        {
            if (json.Property(RootNameTxtBox.Text) != null)
            {
                root.Add(new JObject());
                level++;
                MessageBox.Show("Object added successfully");
            }
                
            
        }
    }
}