namespace Student_System
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.checkBoxJava = new System.Windows.Forms.CheckBox();
            this.checkBoxPython = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFundType = new System.Windows.Forms.ComboBox();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbLocality = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTxtComment = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(103, 43);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(100, 20);
            this.txtFatherName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AccessibleName = "Gender";
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(103, 77);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 9;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AccessibleName = "Gender";
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(157, 77);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 10;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of Birth";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(103, 142);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDOB.TabIndex = 12;
            // 
            // checkBoxJava
            // 
            this.checkBoxJava.AutoSize = true;
            this.checkBoxJava.Location = new System.Drawing.Point(76, 176);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(49, 17);
            this.checkBoxJava.TabIndex = 13;
            this.checkBoxJava.Text = "Java";
            this.checkBoxJava.UseVisualStyleBackColor = true;
            // 
            // checkBoxPython
            // 
            this.checkBoxPython.AutoSize = true;
            this.checkBoxPython.Location = new System.Drawing.Point(177, 176);
            this.checkBoxPython.Name = "checkBoxPython";
            this.checkBoxPython.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPython.TabIndex = 14;
            this.checkBoxPython.Text = "Python";
            this.checkBoxPython.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(131, 176);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(40, 17);
            this.checkBoxCSharp.TabIndex = 15;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fund Type";
            // 
            // cmbFundType
            // 
            this.cmbFundType.FormattingEnabled = true;
            this.cmbFundType.Location = new System.Drawing.Point(112, 27);
            this.cmbFundType.Name = "cmbFundType";
            this.cmbFundType.Size = new System.Drawing.Size(100, 21);
            this.cmbFundType.TabIndex = 18;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.Location = new System.Drawing.Point(112, 54);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(100, 21);
            this.cmbFeeType.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fee Type";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(16, 235);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(252, 167);
            this.tabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbFundType);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbFeeType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(244, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbLocality);
            this.tabPage2.Controls.Add(this.cmbCity);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtPostCode);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Address";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbLocality
            // 
            this.cmbLocality.FormattingEnabled = true;
            this.cmbLocality.Location = new System.Drawing.Point(101, 64);
            this.cmbLocality.Name = "cmbLocality";
            this.cmbLocality.Size = new System.Drawing.Size(100, 21);
            this.cmbLocality.TabIndex = 7;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(101, 41);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(100, 21);
            this.cmbCity.TabIndex = 6;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            this.cmbCity.ValueMemberChanged += new System.EventHandler(this.cmbCity_ValueMemberChanged);
            this.cmbCity.SelectedValueChanged += new System.EventHandler(this.cmbCity_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "PostCode";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(101, 91);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostCode.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 18);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Locality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTxtComment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(244, 141);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTxtComment
            // 
            this.richTxtComment.Location = new System.Drawing.Point(6, 6);
            this.richTxtComment.Name = "richTxtComment";
            this.richTxtComment.Size = new System.Drawing.Size(240, 129);
            this.richTxtComment.TabIndex = 0;
            this.richTxtComment.Text = "";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxJava);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.checkBoxPython);
            this.Controls.Add(this.checkBoxCSharp);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.CheckBox checkBoxPython;
        private System.Windows.Forms.CheckBox checkBoxCSharp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFundType;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbLocality;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTxtComment;
    }
}

