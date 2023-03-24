using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartJsonGenerator
{
    public partial class Form1 : Form
    {
        dynamic root;
        JObject json = new JObject();
        int level = -1;
        int rootLevel = -1;
        DataTable dt = new DataTable();
        dynamic[] valuesToUpdate = new dynamic[4];
        int rowIndex;
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
            RootNameTxtBox.Enabled = false;
        }

        private void AddNewLevelBtn_Click(object sender, EventArgs e)
        {
            
                
            MessageBox.Show("level added successfully");
        }

        private void AddMoreBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AttributeTxtbox.Text))
            {
                AttributeTxtbox.Focus();
                MessageBox.Show("Enter Attribute please");
            }
            else
            {
                if (AddMoreBtn.Text == "Update")
                {
                    int lev = Int32.Parse(valuesToUpdate[3]);
                    if (levelNameTxtBox.Text == "")
                    {
                        root[lev].Remove(valuesToUpdate[1]);
                        root[lev].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                    }
                    else
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "[" + lev + "]." + valuesToUpdate[0];
                        dynamic retrievedObj = (JArray)json.SelectToken(jsonPath);
                        dynamic newArray = new JArray();
                        foreach (JObject obj in retrievedObj)
                        {
                            newArray.Add(obj);
                        }
                        root[lev].Remove(valuesToUpdate[0]);
                        newArray[0].Remove(valuesToUpdate[1]);
                        newArray[0].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                        root[lev].Add(levelNameTxtBox.Text, newArray);
                        DataGridViewRow row = dataGridView1.Rows[rowIndex];
                        row.Cells[2].Value = lev;
                        row.Cells[3].Value = levelNameTxtBox.Text;
                        row.Cells[4].Value = AttributeTxtbox.Text;
                        row.Cells[5].Value = ValueTxtbox.Text;
                        dataGridView1.Refresh();
                    }
                    MessageBox.Show("Attribute updated successfully");
                    AddMoreBtn.Text = "Add more";
                }
                else
                {
                    if (levelNameTxtBox.Text == "")
                    {
                        root[level].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                    }
                    else
                    {
                        if (root[level].Property(levelNameTxtBox.Text) != null)
                        {
                            var jsonPath = "$." + RootNameTxtBox.Text + "[" + level + "]." + levelNameTxtBox.Text;
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
                    dr["Level"] = (levelNameTxtBox.Text != "") ? levelNameTxtBox.Text : "";
                    dr["Attr"] = (AttributeTxtbox.Text != "") ? AttributeTxtbox.Text : "";
                    dr["Val"] = (ValueTxtbox.Text != "") ? ValueTxtbox.Text : "";
                    dt.Rows.Add(dr);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Attribute added successfully");
                }
                levelNameTxtBox.Text = "";
                AttributeTxtbox.Text = "";
                ValueTxtbox.Text = "";
            }
           
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Get the data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                var levelName = selectedRow.Cells["Level"].Value.ToString();
                var attributeName = selectedRow.Cells["Attr"].Value.ToString();
                var valueName = selectedRow.Cells["Val"].Value.ToString();
                var level = selectedRow.Cells["No"].Value.ToString();
                levelNameTxtBox.Text = levelName;
                AttributeTxtbox.Text = attributeName;
                ValueTxtbox.Text = valueName;
                valuesToUpdate[0] = levelName;
                valuesToUpdate[1] = attributeName;
                valuesToUpdate[2] = valueName;
                valuesToUpdate[3] = level;
                rowIndex = e.RowIndex;
                AddMoreBtn.Text = "Update";
            }

            if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Get the data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                var levelName = selectedRow.Cells["Level"].Value.ToString();
                var attributeName = selectedRow.Cells["Attr"].Value.ToString();
                int level = Int32.Parse(selectedRow.Cells["No"].Value.ToString());
                rowIndex = e.RowIndex;
                if(levelName == "")
                {
                    root[level].Remove(attributeName);
                }
                else
                {
                    var jsonPath = "$." + RootNameTxtBox.Text + "[" + level + "]." + levelName;
                    dynamic retrievedObj = (JArray)json.SelectToken(jsonPath);
                    JObject count = (JObject) retrievedObj[0];
                    if (count.Count == 1)
                        root[level].Remove(levelName);
                    else
                        retrievedObj[0].Remove(attributeName);

                }
                dataGridView1.Rows.Remove(selectedRow);
                MessageBox.Show("Property deleted!!!");
            }
        }
    }
}