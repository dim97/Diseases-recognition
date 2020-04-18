namespace DictUi
{
    partial class Dictoinary
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
            this.UMLSToEngGroup = new System.Windows.Forms.GroupBox();
            this.EngToUMLSGroup = new System.Windows.Forms.GroupBox();
            this.EngResult = new System.Windows.Forms.TextBox();
            this.UMLSResult = new System.Windows.Forms.TextBox();
            this.labelEngResult = new System.Windows.Forms.Label();
            this.labelUMLSResult = new System.Windows.Forms.Label();
            this.DiseasesUmlsComboBox = new System.Windows.Forms.ComboBox();
            this.SymptomsUmlsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiseasesEngComboBox = new System.Windows.Forms.ComboBox();
            this.SymptomsEngComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UMLSToEngGroup.SuspendLayout();
            this.EngToUMLSGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UMLSToEngGroup
            // 
            this.UMLSToEngGroup.Controls.Add(this.label2);
            this.UMLSToEngGroup.Controls.Add(this.label1);
            this.UMLSToEngGroup.Controls.Add(this.SymptomsUmlsComboBox);
            this.UMLSToEngGroup.Controls.Add(this.DiseasesUmlsComboBox);
            this.UMLSToEngGroup.Controls.Add(this.labelEngResult);
            this.UMLSToEngGroup.Controls.Add(this.EngResult);
            this.UMLSToEngGroup.Location = new System.Drawing.Point(12, 12);
            this.UMLSToEngGroup.Name = "UMLSToEngGroup";
            this.UMLSToEngGroup.Size = new System.Drawing.Size(316, 100);
            this.UMLSToEngGroup.TabIndex = 0;
            this.UMLSToEngGroup.TabStop = false;
            this.UMLSToEngGroup.Text = "UMLS -> English";
            // 
            // EngToUMLSGroup
            // 
            this.EngToUMLSGroup.Controls.Add(this.label4);
            this.EngToUMLSGroup.Controls.Add(this.labelUMLSResult);
            this.EngToUMLSGroup.Controls.Add(this.label3);
            this.EngToUMLSGroup.Controls.Add(this.UMLSResult);
            this.EngToUMLSGroup.Controls.Add(this.SymptomsEngComboBox);
            this.EngToUMLSGroup.Controls.Add(this.DiseasesEngComboBox);
            this.EngToUMLSGroup.Location = new System.Drawing.Point(343, 12);
            this.EngToUMLSGroup.Name = "EngToUMLSGroup";
            this.EngToUMLSGroup.Size = new System.Drawing.Size(316, 100);
            this.EngToUMLSGroup.TabIndex = 1;
            this.EngToUMLSGroup.TabStop = false;
            this.EngToUMLSGroup.Text = "English -> UMLS";
            // 
            // EngResult
            // 
            this.EngResult.Location = new System.Drawing.Point(56, 74);
            this.EngResult.Name = "EngResult";
            this.EngResult.ReadOnly = true;
            this.EngResult.Size = new System.Drawing.Size(254, 20);
            this.EngResult.TabIndex = 0;
            // 
            // UMLSResult
            // 
            this.UMLSResult.Location = new System.Drawing.Point(56, 74);
            this.UMLSResult.Name = "UMLSResult";
            this.UMLSResult.ReadOnly = true;
            this.UMLSResult.Size = new System.Drawing.Size(254, 20);
            this.UMLSResult.TabIndex = 0;
            // 
            // labelEngResult
            // 
            this.labelEngResult.AutoSize = true;
            this.labelEngResult.Location = new System.Drawing.Point(6, 77);
            this.labelEngResult.Name = "labelEngResult";
            this.labelEngResult.Size = new System.Drawing.Size(44, 13);
            this.labelEngResult.TabIndex = 1;
            this.labelEngResult.Text = "English:";
            // 
            // labelUMLSResult
            // 
            this.labelUMLSResult.AutoSize = true;
            this.labelUMLSResult.Location = new System.Drawing.Point(10, 77);
            this.labelUMLSResult.Name = "labelUMLSResult";
            this.labelUMLSResult.Size = new System.Drawing.Size(40, 13);
            this.labelUMLSResult.TabIndex = 1;
            this.labelUMLSResult.Text = "UMLS:";
            // 
            // DiseasesUmlsComboBox
            // 
            this.DiseasesUmlsComboBox.FormattingEnabled = true;
            this.DiseasesUmlsComboBox.Location = new System.Drawing.Point(56, 38);
            this.DiseasesUmlsComboBox.Name = "DiseasesUmlsComboBox";
            this.DiseasesUmlsComboBox.Size = new System.Drawing.Size(121, 21);
            this.DiseasesUmlsComboBox.TabIndex = 2;
            this.DiseasesUmlsComboBox.TextChanged += new System.EventHandler(this.DiseasesUmlsComboBox_TextChanged);
            // 
            // SymptomsUmlsComboBox
            // 
            this.SymptomsUmlsComboBox.FormattingEnabled = true;
            this.SymptomsUmlsComboBox.Location = new System.Drawing.Point(189, 38);
            this.SymptomsUmlsComboBox.Name = "SymptomsUmlsComboBox";
            this.SymptomsUmlsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SymptomsUmlsComboBox.TabIndex = 2;
            this.SymptomsUmlsComboBox.TextChanged += new System.EventHandler(this.SymptomsUmlsComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Disease:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Symptom:";
            // 
            // DiseasesEngComboBox
            // 
            this.DiseasesEngComboBox.FormattingEnabled = true;
            this.DiseasesEngComboBox.Location = new System.Drawing.Point(56, 38);
            this.DiseasesEngComboBox.Name = "DiseasesEngComboBox";
            this.DiseasesEngComboBox.Size = new System.Drawing.Size(121, 21);
            this.DiseasesEngComboBox.TabIndex = 2;
            this.DiseasesEngComboBox.TextChanged += new System.EventHandler(this.DiseasesEngComboBox_TextChanged);
            // 
            // SymptomsEngComboBox
            // 
            this.SymptomsEngComboBox.FormattingEnabled = true;
            this.SymptomsEngComboBox.Location = new System.Drawing.Point(189, 38);
            this.SymptomsEngComboBox.Name = "SymptomsEngComboBox";
            this.SymptomsEngComboBox.Size = new System.Drawing.Size(121, 21);
            this.SymptomsEngComboBox.TabIndex = 2;
            this.SymptomsEngComboBox.TextChanged += new System.EventHandler(this.SymptomsEngComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disease:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Symptom:";
            // 
            // Dictoinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 131);
            this.Controls.Add(this.EngToUMLSGroup);
            this.Controls.Add(this.UMLSToEngGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dictoinary";
            this.Text = "UMLS translate";
            this.UMLSToEngGroup.ResumeLayout(false);
            this.UMLSToEngGroup.PerformLayout();
            this.EngToUMLSGroup.ResumeLayout(false);
            this.EngToUMLSGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UMLSToEngGroup;
        private System.Windows.Forms.TextBox EngResult;
        private System.Windows.Forms.GroupBox EngToUMLSGroup;
        private System.Windows.Forms.TextBox UMLSResult;
        private System.Windows.Forms.Label labelEngResult;
        private System.Windows.Forms.Label labelUMLSResult;
        private System.Windows.Forms.ComboBox DiseasesUmlsComboBox;
        private System.Windows.Forms.ComboBox SymptomsUmlsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DiseasesEngComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SymptomsEngComboBox;
    }
}

