using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace SmartJsonGenerator
{
    public partial class Form1 : Form
    {
        JArray records = new JArray();
        dynamic root;
        JObject json = new JObject();
        JObject attribute = new JObject();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = records;
            rootCB.SelectedIndex = 0;
            attrCB.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            JsonString.Text = jsonString;
            Console.Write(jsonString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            json = new JObject();
            root = (rootCB.SelectedItem.ToString() == "Array")? new JArray() : new JObject();
            if (rootCB.SelectedItem.ToString() == "Array")
            {
                root = new JArray();
                root.Add(new JObject());
                json.Add(RootNameTxtBox.Text, root);
            }
            else
            {
                root = new JObject();
                json.Add(RootNameTxtBox.Text, root);
            }
            MessageBox.Show("root added successfully");
            button1.Enabled = false;
        }

        private void AddNewLevelBtn_Click(object sender, EventArgs e)
        {
            if(levelNameTxtBox.Text == "")
            {
                var newObject = new JObject();
                if (rootCB.SelectedItem.ToString() == "Array")
                {
                    newObject.Merge(root[0]);
                    root.Add(newObject);
                }
            }
            else
            {
                var jsonPath = "$." + RootNameTxtBox.Text + "[0]." + levelNameTxtBox.Text;
                JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                retrievedObj.Add(AttributeTxtbox.Text, ValueTxtbox.Text);
            }
                
            MessageBox.Show("level added successfully");
        }

        private void AddMoreBtn_Click(object sender, EventArgs e)
        {
            
            if(attrCB.SelectedItem.ToString() == "Value")
            {
                if(levelNameTxtBox.Text == "")
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {
                        root[0].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                    }
                    else
                    {
                        root.Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }
                else
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {

                        var jsonPath = "$." + RootNameTxtBox.Text + "[0]." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                    else
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(AttributeTxtbox.Text, ValueTxtbox.Text);
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }
                
            }else if(attrCB.SelectedItem.ToString() == "Object")
            {
                if (levelNameTxtBox.Text == "")
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {
                        root[0].Add(ObjectNameTxtBox.Text, new JObject(){
                            {AttributeTxtbox.Text, ValueTxtbox.Text }
                        });

                    }
                    else
                    {
                        root.Add(ObjectNameTxtBox.Text, new JObject(){
                            {AttributeTxtbox.Text, ValueTxtbox.Text }
                        });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }
                else
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(ObjectNameTxtBox.Text, new JArray(){
                            new JObject(){
                                {AttributeTxtbox.Text, ValueTxtbox.Text }
                            }
                        });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                    else
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(ObjectNameTxtBox.Text,
                            new JObject(){
                                {AttributeTxtbox.Text, ValueTxtbox.Text }
                            });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }

                
            }
            else
            {
                if (levelNameTxtBox.Text == "")
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {
                        root[0].Add(ObjectNameTxtBox.Text, new JObject(){
                            {AttributeTxtbox.Text, ValueTxtbox.Text }
                        });

                    }
                    else
                    {
                        root.Add(ObjectNameTxtBox.Text, new JObject(){
                            {AttributeTxtbox.Text, ValueTxtbox.Text }
                        });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }
                else
                {
                    if (rootCB.SelectedItem.ToString() == "Array")
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(ObjectNameTxtBox.Text, new JArray(){
                            new JObject(){
                                {AttributeTxtbox.Text, ValueTxtbox.Text }
                            }
                        });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                    else
                    {
                        var jsonPath = "$." + RootNameTxtBox.Text + "." + levelNameTxtBox.Text;
                        JObject retrievedObj = (JObject)json.SelectToken(jsonPath);
                        retrievedObj.Add(ObjectNameTxtBox.Text,
                            new JObject(){
                                {AttributeTxtbox.Text, ValueTxtbox.Text }
                            });
                        AttributeTxtbox.Text = "";
                        ValueTxtbox.Text = "";
                    }
                }

            }
            
            MessageBox.Show("Attribute added successfully");
        }
    }
}