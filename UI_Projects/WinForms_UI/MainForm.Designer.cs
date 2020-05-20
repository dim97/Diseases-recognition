namespace WinForms_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.PredictBtn = new System.Windows.Forms.Button();
            this.SymptomsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfidenceBar1 = new System.Windows.Forms.Panel();
            this.ConfidenceBar2 = new System.Windows.Forms.Panel();
            this.ConfidenceBar3 = new System.Windows.Forms.Panel();
            this.ConfidenceBar4 = new System.Windows.Forms.Panel();
            this.ConfidenceBar5 = new System.Windows.Forms.Panel();
            this.ConfidenceBarBackground1 = new System.Windows.Forms.Panel();
            this.ConfidenceBarBackground2 = new System.Windows.Forms.Panel();
            this.ConfidenceBarBackground3 = new System.Windows.Forms.Panel();
            this.ConfidenceBarBackground4 = new System.Windows.Forms.Panel();
            this.ConfidenceBarBackground5 = new System.Windows.Forms.Panel();
            this.Disease1Text = new System.Windows.Forms.TextBox();
            this.Disease2Text = new System.Windows.Forms.TextBox();
            this.Disease3Text = new System.Windows.Forms.TextBox();
            this.Disease4Text = new System.Windows.Forms.TextBox();
            this.Disease5Text = new System.Windows.Forms.TextBox();
            this.ConfidenceBarBackground6 = new System.Windows.Forms.Panel();
            this.ConfidenceBar6 = new System.Windows.Forms.Panel();
            this.Disease6Text = new System.Windows.Forms.TextBox();
            this.ConfidenceBarBackground7 = new System.Windows.Forms.Panel();
            this.ConfidenceBar7 = new System.Windows.Forms.Panel();
            this.Disease7Text = new System.Windows.Forms.TextBox();
            this.ConfidenceBarBackground8 = new System.Windows.Forms.Panel();
            this.ConfidenceBar8 = new System.Windows.Forms.Panel();
            this.Disease8Text = new System.Windows.Forms.TextBox();
            this.ConfidenceBarBackground9 = new System.Windows.Forms.Panel();
            this.ConfidenceBar9 = new System.Windows.Forms.Panel();
            this.Disease9Text = new System.Windows.Forms.TextBox();
            this.ConfidenceBarBackground10 = new System.Windows.Forms.Panel();
            this.ConfidenceBar10 = new System.Windows.Forms.Panel();
            this.Disease10Text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateSympBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most likely diseases:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select symptoms:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextBox.Location = new System.Drawing.Point(12, 337);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(229, 68);
            this.InputTextBox.TabIndex = 3;
            // 
            // PredictBtn
            // 
            this.PredictBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.PredictBtn.FlatAppearance.BorderSize = 0;
            this.PredictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredictBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredictBtn.Location = new System.Drawing.Point(12, 420);
            this.PredictBtn.Name = "PredictBtn";
            this.PredictBtn.Size = new System.Drawing.Size(229, 66);
            this.PredictBtn.TabIndex = 4;
            this.PredictBtn.Text = "Request prediction";
            this.PredictBtn.UseVisualStyleBackColor = false;
            this.PredictBtn.Click += new System.EventHandler(this.PredictBtn_Click);
            // 
            // SymptomsListBox
            // 
            this.SymptomsListBox.BackColor = System.Drawing.SystemColors.Control;
            this.SymptomsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SymptomsListBox.FormattingEnabled = true;
            this.SymptomsListBox.Location = new System.Drawing.Point(12, 68);
            this.SymptomsListBox.Name = "SymptomsListBox";
            this.SymptomsListBox.Size = new System.Drawing.Size(229, 221);
            this.SymptomsListBox.TabIndex = 5;
            this.SymptomsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SymptomsListBox_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Summary:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Location = new System.Drawing.Point(66, 43);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(175, 19);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search:";
            // 
            // ConfidenceBar1
            // 
            this.ConfidenceBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar1.Location = new System.Drawing.Point(260, 54);
            this.ConfidenceBar1.Name = "ConfidenceBar1";
            this.ConfidenceBar1.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar1.TabIndex = 11;
            this.ConfidenceBar1.Visible = false;
            // 
            // ConfidenceBar2
            // 
            this.ConfidenceBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar2.Location = new System.Drawing.Point(260, 98);
            this.ConfidenceBar2.Name = "ConfidenceBar2";
            this.ConfidenceBar2.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar2.TabIndex = 11;
            this.ConfidenceBar2.Visible = false;
            // 
            // ConfidenceBar3
            // 
            this.ConfidenceBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar3.Location = new System.Drawing.Point(260, 144);
            this.ConfidenceBar3.Name = "ConfidenceBar3";
            this.ConfidenceBar3.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar3.TabIndex = 11;
            this.ConfidenceBar3.Visible = false;
            // 
            // ConfidenceBar4
            // 
            this.ConfidenceBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar4.Location = new System.Drawing.Point(260, 190);
            this.ConfidenceBar4.Name = "ConfidenceBar4";
            this.ConfidenceBar4.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar4.TabIndex = 11;
            this.ConfidenceBar4.Visible = false;
            // 
            // ConfidenceBar5
            // 
            this.ConfidenceBar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar5.Location = new System.Drawing.Point(260, 236);
            this.ConfidenceBar5.Name = "ConfidenceBar5";
            this.ConfidenceBar5.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar5.TabIndex = 11;
            this.ConfidenceBar5.Visible = false;
            // 
            // ConfidenceBarBackground1
            // 
            this.ConfidenceBarBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground1.Location = new System.Drawing.Point(260, 54);
            this.ConfidenceBarBackground1.Name = "ConfidenceBarBackground1";
            this.ConfidenceBarBackground1.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground1.TabIndex = 12;
            this.ConfidenceBarBackground1.Visible = false;
            // 
            // ConfidenceBarBackground2
            // 
            this.ConfidenceBarBackground2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground2.Location = new System.Drawing.Point(260, 98);
            this.ConfidenceBarBackground2.Name = "ConfidenceBarBackground2";
            this.ConfidenceBarBackground2.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground2.TabIndex = 12;
            this.ConfidenceBarBackground2.Visible = false;
            // 
            // ConfidenceBarBackground3
            // 
            this.ConfidenceBarBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground3.Location = new System.Drawing.Point(260, 144);
            this.ConfidenceBarBackground3.Name = "ConfidenceBarBackground3";
            this.ConfidenceBarBackground3.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground3.TabIndex = 12;
            this.ConfidenceBarBackground3.Visible = false;
            // 
            // ConfidenceBarBackground4
            // 
            this.ConfidenceBarBackground4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground4.Location = new System.Drawing.Point(260, 190);
            this.ConfidenceBarBackground4.Name = "ConfidenceBarBackground4";
            this.ConfidenceBarBackground4.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground4.TabIndex = 12;
            this.ConfidenceBarBackground4.Visible = false;
            // 
            // ConfidenceBarBackground5
            // 
            this.ConfidenceBarBackground5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground5.Location = new System.Drawing.Point(260, 236);
            this.ConfidenceBarBackground5.Name = "ConfidenceBarBackground5";
            this.ConfidenceBarBackground5.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground5.TabIndex = 12;
            this.ConfidenceBarBackground5.Visible = false;
            // 
            // Disease1Text
            // 
            this.Disease1Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease1Text.Location = new System.Drawing.Point(260, 37);
            this.Disease1Text.Name = "Disease1Text";
            this.Disease1Text.ReadOnly = true;
            this.Disease1Text.Size = new System.Drawing.Size(457, 14);
            this.Disease1Text.TabIndex = 13;
            this.Disease1Text.Text = "1:";
            this.Disease1Text.Visible = false;
            // 
            // Disease2Text
            // 
            this.Disease2Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease2Text.Location = new System.Drawing.Point(260, 80);
            this.Disease2Text.Name = "Disease2Text";
            this.Disease2Text.ReadOnly = true;
            this.Disease2Text.Size = new System.Drawing.Size(457, 14);
            this.Disease2Text.TabIndex = 13;
            this.Disease2Text.Text = "2:";
            this.Disease2Text.Visible = false;
            // 
            // Disease3Text
            // 
            this.Disease3Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease3Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease3Text.Location = new System.Drawing.Point(260, 124);
            this.Disease3Text.Name = "Disease3Text";
            this.Disease3Text.ReadOnly = true;
            this.Disease3Text.Size = new System.Drawing.Size(457, 14);
            this.Disease3Text.TabIndex = 13;
            this.Disease3Text.Text = "3:";
            this.Disease3Text.Visible = false;
            // 
            // Disease4Text
            // 
            this.Disease4Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease4Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease4Text.Location = new System.Drawing.Point(260, 170);
            this.Disease4Text.Name = "Disease4Text";
            this.Disease4Text.ReadOnly = true;
            this.Disease4Text.Size = new System.Drawing.Size(457, 14);
            this.Disease4Text.TabIndex = 13;
            this.Disease4Text.Text = "4:";
            this.Disease4Text.Visible = false;
            // 
            // Disease5Text
            // 
            this.Disease5Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease5Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease5Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease5Text.Location = new System.Drawing.Point(260, 216);
            this.Disease5Text.Name = "Disease5Text";
            this.Disease5Text.ReadOnly = true;
            this.Disease5Text.Size = new System.Drawing.Size(457, 14);
            this.Disease5Text.TabIndex = 13;
            this.Disease5Text.Text = "5:";
            this.Disease5Text.Visible = false;
            // 
            // ConfidenceBarBackground6
            // 
            this.ConfidenceBarBackground6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground6.Location = new System.Drawing.Point(260, 282);
            this.ConfidenceBarBackground6.Name = "ConfidenceBarBackground6";
            this.ConfidenceBarBackground6.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground6.TabIndex = 12;
            this.ConfidenceBarBackground6.Visible = false;
            // 
            // ConfidenceBar6
            // 
            this.ConfidenceBar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar6.Location = new System.Drawing.Point(260, 282);
            this.ConfidenceBar6.Name = "ConfidenceBar6";
            this.ConfidenceBar6.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar6.TabIndex = 11;
            this.ConfidenceBar6.Visible = false;
            // 
            // Disease6Text
            // 
            this.Disease6Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease6Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease6Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease6Text.Location = new System.Drawing.Point(260, 262);
            this.Disease6Text.Name = "Disease6Text";
            this.Disease6Text.ReadOnly = true;
            this.Disease6Text.Size = new System.Drawing.Size(457, 14);
            this.Disease6Text.TabIndex = 13;
            this.Disease6Text.Text = "6:";
            this.Disease6Text.Visible = false;
            // 
            // ConfidenceBarBackground7
            // 
            this.ConfidenceBarBackground7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground7.Location = new System.Drawing.Point(260, 328);
            this.ConfidenceBarBackground7.Name = "ConfidenceBarBackground7";
            this.ConfidenceBarBackground7.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground7.TabIndex = 12;
            this.ConfidenceBarBackground7.Visible = false;
            // 
            // ConfidenceBar7
            // 
            this.ConfidenceBar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar7.Location = new System.Drawing.Point(260, 328);
            this.ConfidenceBar7.Name = "ConfidenceBar7";
            this.ConfidenceBar7.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar7.TabIndex = 11;
            this.ConfidenceBar7.Visible = false;
            // 
            // Disease7Text
            // 
            this.Disease7Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease7Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease7Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease7Text.Location = new System.Drawing.Point(260, 308);
            this.Disease7Text.Name = "Disease7Text";
            this.Disease7Text.ReadOnly = true;
            this.Disease7Text.Size = new System.Drawing.Size(457, 14);
            this.Disease7Text.TabIndex = 13;
            this.Disease7Text.Text = "7:";
            this.Disease7Text.Visible = false;
            // 
            // ConfidenceBarBackground8
            // 
            this.ConfidenceBarBackground8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground8.Location = new System.Drawing.Point(259, 374);
            this.ConfidenceBarBackground8.Name = "ConfidenceBarBackground8";
            this.ConfidenceBarBackground8.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground8.TabIndex = 12;
            this.ConfidenceBarBackground8.Visible = false;
            // 
            // ConfidenceBar8
            // 
            this.ConfidenceBar8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar8.Location = new System.Drawing.Point(259, 374);
            this.ConfidenceBar8.Name = "ConfidenceBar8";
            this.ConfidenceBar8.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar8.TabIndex = 11;
            this.ConfidenceBar8.Visible = false;
            // 
            // Disease8Text
            // 
            this.Disease8Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease8Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease8Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease8Text.Location = new System.Drawing.Point(259, 354);
            this.Disease8Text.Name = "Disease8Text";
            this.Disease8Text.ReadOnly = true;
            this.Disease8Text.Size = new System.Drawing.Size(457, 14);
            this.Disease8Text.TabIndex = 13;
            this.Disease8Text.Text = "8:";
            this.Disease8Text.Visible = false;
            // 
            // ConfidenceBarBackground9
            // 
            this.ConfidenceBarBackground9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground9.Location = new System.Drawing.Point(259, 420);
            this.ConfidenceBarBackground9.Name = "ConfidenceBarBackground9";
            this.ConfidenceBarBackground9.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground9.TabIndex = 12;
            this.ConfidenceBarBackground9.Visible = false;
            // 
            // ConfidenceBar9
            // 
            this.ConfidenceBar9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar9.Location = new System.Drawing.Point(259, 420);
            this.ConfidenceBar9.Name = "ConfidenceBar9";
            this.ConfidenceBar9.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar9.TabIndex = 11;
            this.ConfidenceBar9.Visible = false;
            // 
            // Disease9Text
            // 
            this.Disease9Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease9Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease9Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease9Text.Location = new System.Drawing.Point(259, 400);
            this.Disease9Text.Name = "Disease9Text";
            this.Disease9Text.ReadOnly = true;
            this.Disease9Text.Size = new System.Drawing.Size(457, 14);
            this.Disease9Text.TabIndex = 13;
            this.Disease9Text.Text = "9:";
            this.Disease9Text.Visible = false;
            // 
            // ConfidenceBarBackground10
            // 
            this.ConfidenceBarBackground10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.ConfidenceBarBackground10.Location = new System.Drawing.Point(259, 466);
            this.ConfidenceBarBackground10.Name = "ConfidenceBarBackground10";
            this.ConfidenceBarBackground10.Size = new System.Drawing.Size(457, 20);
            this.ConfidenceBarBackground10.TabIndex = 12;
            this.ConfidenceBarBackground10.Visible = false;
            // 
            // ConfidenceBar10
            // 
            this.ConfidenceBar10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.ConfidenceBar10.Location = new System.Drawing.Point(259, 466);
            this.ConfidenceBar10.Name = "ConfidenceBar10";
            this.ConfidenceBar10.Size = new System.Drawing.Size(18, 20);
            this.ConfidenceBar10.TabIndex = 11;
            this.ConfidenceBar10.Visible = false;
            // 
            // Disease10Text
            // 
            this.Disease10Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.Disease10Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disease10Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disease10Text.Location = new System.Drawing.Point(259, 446);
            this.Disease10Text.Name = "Disease10Text";
            this.Disease10Text.ReadOnly = true;
            this.Disease10Text.Size = new System.Drawing.Size(457, 14);
            this.Disease10Text.TabIndex = 13;
            this.Disease10Text.Text = "10:";
            this.Disease10Text.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(259, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 455);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateSympBtn
            // 
            this.UpdateSympBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(64)))));
            this.UpdateSympBtn.FlatAppearance.BorderSize = 0;
            this.UpdateSympBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSympBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateSympBtn.Location = new System.Drawing.Point(12, 292);
            this.UpdateSympBtn.Name = "UpdateSympBtn";
            this.UpdateSympBtn.Size = new System.Drawing.Size(229, 23);
            this.UpdateSympBtn.TabIndex = 15;
            this.UpdateSympBtn.Text = "Update symptom list";
            this.UpdateSympBtn.UseVisualStyleBackColor = false;
            this.UpdateSympBtn.Visible = false;
            this.UpdateSympBtn.Click += new System.EventHandler(this.UpdateSympBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(725, 500);
            this.Controls.Add(this.UpdateSympBtn);
            this.Controls.Add(this.Disease10Text);
            this.Controls.Add(this.Disease9Text);
            this.Controls.Add(this.Disease8Text);
            this.Controls.Add(this.Disease7Text);
            this.Controls.Add(this.Disease6Text);
            this.Controls.Add(this.Disease5Text);
            this.Controls.Add(this.Disease4Text);
            this.Controls.Add(this.Disease3Text);
            this.Controls.Add(this.Disease2Text);
            this.Controls.Add(this.Disease1Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfidenceBar10);
            this.Controls.Add(this.SymptomsListBox);
            this.Controls.Add(this.ConfidenceBar9);
            this.Controls.Add(this.PredictBtn);
            this.Controls.Add(this.ConfidenceBar8);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ConfidenceBar7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfidenceBar6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfidenceBar5);
            this.Controls.Add(this.ConfidenceBar4);
            this.Controls.Add(this.ConfidenceBar3);
            this.Controls.Add(this.ConfidenceBarBackground10);
            this.Controls.Add(this.ConfidenceBar2);
            this.Controls.Add(this.ConfidenceBarBackground9);
            this.Controls.Add(this.ConfidenceBar1);
            this.Controls.Add(this.ConfidenceBarBackground8);
            this.Controls.Add(this.ConfidenceBarBackground2);
            this.Controls.Add(this.ConfidenceBarBackground7);
            this.Controls.Add(this.ConfidenceBarBackground1);
            this.Controls.Add(this.ConfidenceBarBackground6);
            this.Controls.Add(this.ConfidenceBarBackground3);
            this.Controls.Add(this.ConfidenceBarBackground5);
            this.Controls.Add(this.ConfidenceBarBackground4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button PredictBtn;
        private System.Windows.Forms.ListBox SymptomsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ConfidenceBar1;
        private System.Windows.Forms.Panel ConfidenceBar2;
        private System.Windows.Forms.Panel ConfidenceBar3;
        private System.Windows.Forms.Panel ConfidenceBar4;
        private System.Windows.Forms.Panel ConfidenceBar5;
        private System.Windows.Forms.Panel ConfidenceBarBackground1;
        private System.Windows.Forms.Panel ConfidenceBarBackground2;
        private System.Windows.Forms.Panel ConfidenceBarBackground3;
        private System.Windows.Forms.Panel ConfidenceBarBackground4;
        private System.Windows.Forms.Panel ConfidenceBarBackground5;
        private System.Windows.Forms.TextBox Disease1Text;
        private System.Windows.Forms.TextBox Disease2Text;
        private System.Windows.Forms.TextBox Disease3Text;
        private System.Windows.Forms.TextBox Disease4Text;
        private System.Windows.Forms.TextBox Disease5Text;
        private System.Windows.Forms.Panel ConfidenceBarBackground6;
        private System.Windows.Forms.Panel ConfidenceBar6;
        private System.Windows.Forms.TextBox Disease6Text;
        private System.Windows.Forms.Panel ConfidenceBarBackground7;
        private System.Windows.Forms.Panel ConfidenceBar7;
        private System.Windows.Forms.TextBox Disease7Text;
        private System.Windows.Forms.Panel ConfidenceBarBackground8;
        private System.Windows.Forms.Panel ConfidenceBar8;
        private System.Windows.Forms.TextBox Disease8Text;
        private System.Windows.Forms.Panel ConfidenceBarBackground9;
        private System.Windows.Forms.Panel ConfidenceBar9;
        private System.Windows.Forms.TextBox Disease9Text;
        private System.Windows.Forms.Panel ConfidenceBarBackground10;
        private System.Windows.Forms.Panel ConfidenceBar10;
        private System.Windows.Forms.TextBox Disease10Text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdateSympBtn;
    }
}

