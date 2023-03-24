namespace SmartJsonGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RootNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddNewRootElement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButtoncolumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddMoreBtn = new System.Windows.Forms.Button();
            this.ValueTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AttributeTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.levelNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.JsonString = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RootName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RootNameTxtBox
            // 
            this.RootNameTxtBox.Location = new System.Drawing.Point(106, 31);
            this.RootNameTxtBox.Name = "RootNameTxtBox";
            this.RootNameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.RootNameTxtBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RootNameTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AccessibleName = "AddNewBtn";
            this.button1.Location = new System.Drawing.Point(395, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Root";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddNewRootElement);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.AddMoreBtn);
            this.groupBox2.Controls.Add(this.ValueTxtbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AttributeTxtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.levelNameTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 367);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AddNewRootElement
            // 
            this.AddNewRootElement.AccessibleName = "AddNewRootElement";
            this.AddNewRootElement.Location = new System.Drawing.Point(380, 25);
            this.AddNewRootElement.Name = "AddNewRootElement";
            this.AddNewRootElement.Size = new System.Drawing.Size(118, 23);
            this.AddNewRootElement.TabIndex = 13;
            this.AddNewRootElement.Text = "Add New Object";
            this.AddNewRootElement.UseVisualStyleBackColor = true;
            this.AddNewRootElement.Click += new System.EventHandler(this.AddNewRootElement_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditButtonColumn,
            this.DeleteButtoncolumn});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(485, 194);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EditButtonColumn
            // 
            this.EditButtonColumn.HeaderText = "Edit";
            this.EditButtonColumn.Name = "EditButtonColumn";
            this.EditButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditButtonColumn.Text = "Edit";
            this.EditButtonColumn.ToolTipText = "Edit";
            // 
            // DeleteButtoncolumn
            // 
            this.DeleteButtoncolumn.HeaderText = "Delete";
            this.DeleteButtoncolumn.Name = "DeleteButtoncolumn";
            this.DeleteButtoncolumn.Text = "Delete";
            // 
            // AddMoreBtn
            // 
            this.AddMoreBtn.Location = new System.Drawing.Point(225, 85);
            this.AddMoreBtn.Name = "AddMoreBtn";
            this.AddMoreBtn.Size = new System.Drawing.Size(90, 62);
            this.AddMoreBtn.TabIndex = 7;
            this.AddMoreBtn.Text = "Add more";
            this.AddMoreBtn.UseVisualStyleBackColor = true;
            this.AddMoreBtn.Click += new System.EventHandler(this.AddMoreBtn_Click);
            // 
            // ValueTxtbox
            // 
            this.ValueTxtbox.Location = new System.Drawing.Point(88, 124);
            this.ValueTxtbox.Name = "ValueTxtbox";
            this.ValueTxtbox.Size = new System.Drawing.Size(100, 23);
            this.ValueTxtbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Value";
            // 
            // AttributeTxtbox
            // 
            this.AttributeTxtbox.Location = new System.Drawing.Point(88, 70);
            this.AttributeTxtbox.Name = "AttributeTxtbox";
            this.AttributeTxtbox.Size = new System.Drawing.Size(100, 23);
            this.AttributeTxtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attribute";
            // 
            // levelNameTxtBox
            // 
            this.levelNameTxtBox.Location = new System.Drawing.Point(88, 22);
            this.levelNameTxtBox.Name = "levelNameTxtBox";
            this.levelNameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.levelNameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "level name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.JsonString);
            this.groupBox3.Location = new System.Drawing.Point(537, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 463);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // JsonString
            // 
            this.JsonString.AutoSize = true;
            this.JsonString.Location = new System.Drawing.Point(6, 19);
            this.JsonString.Name = "JsonString";
            this.JsonString.Size = new System.Drawing.Size(61, 15);
            this.JsonString.TabIndex = 0;
            this.JsonString.Text = "JsonString";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 519);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox RootNameTxtBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox levelNameTxtBox;
        private Label label2;
        private Button button1;
        private TextBox ValueTxtbox;
        private Label label4;
        private TextBox AttributeTxtbox;
        private Label label3;
        private Button AddMoreBtn;
        private GroupBox groupBox3;
        private Label JsonString;
        private Button button4;
        private DataGridView dataGridView1;
        private Button AddNewRootElement;
        private DataGridViewButtonColumn EditButtonColumn;
        private DataGridViewButtonColumn DeleteButtoncolumn;
    }
}