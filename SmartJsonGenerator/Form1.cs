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
        int count = -1;
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
            count++;
            if (RootNameTxtBox.Text != "")
            {
                json = new JObject();
                root = (rootCB.SelectedItem.ToString() == "Array") ? new JArray() : new JObject();
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
            else
            {
                RootNameTxtBox.Focus();
                MessageBox.Show("Enter Root please");
            }

            
        }

        private void AddNewLevelBtn_Click(object sender, EventArgs e)
        {
            count++;
            if(levelNameTxtBox.Text == "")
            {
                var newObject = new JObject();
                if (rootCB.SelectedItem.ToString() == "Array")
                {
                    root.Add(newObject);
                }
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
                        root[count].Add(AttributeTxtbox.Text, ValueTxtbox.Text);
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

                        var jsonPath = "$." + RootNameTxtBox.Text + "["+count+"]." + levelNameTxtBox.Text;
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
                        root[count].Add(ObjectNameTxtBox.Text, new JObject(){
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
                        root[count].Add(ObjectNameTxtBox.Text, new JObject(){
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

        private void GenerateFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
                var projectPath = new Uri(actualPath).LocalPath;
                var jsonFilePath = projectPath + "\\myJson.txt";
                string jsonStr = File.ReadAllText(jsonFilePath);
                json = JsonConvert.DeserializeObject<JObject>(jsonStr);
                MessageBox.Show("Generated successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}