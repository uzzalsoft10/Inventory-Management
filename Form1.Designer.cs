namespace Inventory_Management
{
    partial class Form1
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
            this.btnOrderItems = new System.Windows.Forms.Button();
            this.btnAddmore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbSix = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkFullSet = new System.Windows.Forms.CheckBox();
            this.chkBean = new System.Windows.Forms.CheckBox();
            this.chkSugar = new System.Windows.Forms.CheckBox();
            this.chkRice = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstBrand = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FirstOutput = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.cmbOrderMade = new System.Windows.Forms.ComboBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderItems
            // 
            this.btnOrderItems.Location = new System.Drawing.Point(172, 613);
            this.btnOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderItems.Name = "btnOrderItems";
            this.btnOrderItems.Size = new System.Drawing.Size(120, 45);
            this.btnOrderItems.TabIndex = 0;
            this.btnOrderItems.Text = "Ordered Items";
            this.btnOrderItems.UseVisualStyleBackColor = true;
            this.btnOrderItems.Click += new System.EventHandler(this.btnOrderItems_Click);
            // 
            // btnAddmore
            // 
            this.btnAddmore.Location = new System.Drawing.Point(454, 613);
            this.btnAddmore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddmore.Name = "btnAddmore";
            this.btnAddmore.Size = new System.Drawing.Size(120, 45);
            this.btnAddmore.TabIndex = 1;
            this.btnAddmore.Text = "Add more";
            this.btnAddmore.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(987, 613);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(373, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 239);
            this.panel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.rbFour);
            this.groupBox3.Controls.Add(this.rbSix);
            this.groupBox3.Controls.Add(this.rbTwo);
            this.groupBox3.Controls.Add(this.rbOne);
            this.groupBox3.Location = new System.Drawing.Point(432, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(149, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "quantity";
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(25, 76);
            this.rbFour.Margin = new System.Windows.Forms.Padding(4);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(33, 19);
            this.rbFour.TabIndex = 3;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbSix
            // 
            this.rbSix.AutoSize = true;
            this.rbSix.Location = new System.Drawing.Point(25, 104);
            this.rbSix.Margin = new System.Windows.Forms.Padding(4);
            this.rbSix.Name = "rbSix";
            this.rbSix.Size = new System.Drawing.Size(33, 19);
            this.rbSix.TabIndex = 2;
            this.rbSix.TabStop = true;
            this.rbSix.Text = "6";
            this.rbSix.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(25, 50);
            this.rbTwo.Margin = new System.Windows.Forms.Padding(4);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(33, 19);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(25, 22);
            this.rbOne.Margin = new System.Windows.Forms.Padding(4);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(33, 19);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.chkMilk);
            this.groupBox2.Controls.Add(this.chkFullSet);
            this.groupBox2.Controls.Add(this.chkBean);
            this.groupBox2.Controls.Add(this.chkSugar);
            this.groupBox2.Controls.Add(this.chkRice);
            this.groupBox2.Location = new System.Drawing.Point(224, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(144, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items ";
            // 
            // chkMilk
            // 
            this.chkMilk.AutoSize = true;
            this.chkMilk.Location = new System.Drawing.Point(9, 103);
            this.chkMilk.Margin = new System.Windows.Forms.Padding(4);
            this.chkMilk.Name = "chkMilk";
            this.chkMilk.Size = new System.Drawing.Size(53, 19);
            this.chkMilk.TabIndex = 4;
            this.chkMilk.Text = "Milk";
            this.chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkFullSet
            // 
            this.chkFullSet.AutoSize = true;
            this.chkFullSet.Location = new System.Drawing.Point(9, 131);
            this.chkFullSet.Margin = new System.Windows.Forms.Padding(4);
            this.chkFullSet.Name = "chkFullSet";
            this.chkFullSet.Size = new System.Drawing.Size(75, 19);
            this.chkFullSet.TabIndex = 3;
            this.chkFullSet.Text = "Full Set";
            this.chkFullSet.UseVisualStyleBackColor = true;
            this.chkFullSet.CheckedChanged += new System.EventHandler(this.chkFullSet_CheckedChanged);
            // 
            // chkBean
            // 
            this.chkBean.AutoSize = true;
            this.chkBean.Location = new System.Drawing.Point(8, 76);
            this.chkBean.Margin = new System.Windows.Forms.Padding(4);
            this.chkBean.Name = "chkBean";
            this.chkBean.Size = new System.Drawing.Size(59, 19);
            this.chkBean.TabIndex = 2;
            this.chkBean.Text = "Bean";
            this.chkBean.UseVisualStyleBackColor = true;
            // 
            // chkSugar
            // 
            this.chkSugar.AutoSize = true;
            this.chkSugar.Location = new System.Drawing.Point(9, 50);
            this.chkSugar.Margin = new System.Windows.Forms.Padding(4);
            this.chkSugar.Name = "chkSugar";
            this.chkSugar.Size = new System.Drawing.Size(68, 19);
            this.chkSugar.TabIndex = 1;
            this.chkSugar.Text = "Sugar ";
            this.chkSugar.UseVisualStyleBackColor = true;
            // 
            // chkRice
            // 
            this.chkRice.AutoSize = true;
            this.chkRice.Location = new System.Drawing.Point(9, 22);
            this.chkRice.Margin = new System.Windows.Forms.Padding(4);
            this.chkRice.Name = "chkRice";
            this.chkRice.Size = new System.Drawing.Size(55, 19);
            this.chkRice.TabIndex = 0;
            this.chkRice.Text = "Rice";
            this.chkRice.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.FirstBrand);
            this.groupBox1.Location = new System.Drawing.Point(4, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(197, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brands";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FirstBrand
            // 
            this.FirstBrand.FormattingEnabled = true;
            this.FirstBrand.ItemHeight = 15;
            this.FirstBrand.Location = new System.Drawing.Point(8, 22);
            this.FirstBrand.Margin = new System.Windows.Forms.Padding(4);
            this.FirstBrand.Name = "FirstBrand";
            this.FirstBrand.Size = new System.Drawing.Size(180, 184);
            this.FirstBrand.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.FirstOutput);
            this.panel2.Location = new System.Drawing.Point(87, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 189);
            this.panel2.TabIndex = 4;
            // 
            // FirstOutput
            // 
            this.FirstOutput.FormattingEnabled = true;
            this.FirstOutput.ItemHeight = 15;
            this.FirstOutput.Location = new System.Drawing.Point(19, 15);
            this.FirstOutput.Margin = new System.Windows.Forms.Padding(4);
            this.FirstOutput.Name = "FirstOutput";
            this.FirstOutput.Size = new System.Drawing.Size(1079, 154);
            this.FirstOutput.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(35, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 95);
            this.panel3.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(205, 19);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(205, 38);
            this.txtCustomerID.TabIndex = 6;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(601, 19);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurName.Multiline = true;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(240, 38);
            this.txtSurName.TabIndex = 7;
            // 
            // cmbOrderMade
            // 
            this.cmbOrderMade.FormattingEnabled = true;
            this.cmbOrderMade.Location = new System.Drawing.Point(601, 76);
            this.cmbOrderMade.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrderMade.Name = "cmbOrderMade";
            this.cmbOrderMade.Size = new System.Drawing.Size(240, 23);
            this.cmbOrderMade.TabIndex = 8;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(1046, 69);
            this.cmbPayment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(265, 23);
            this.cmbPayment.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(205, 69);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 39);
            this.txtFirstName.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1046, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Order Made :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(928, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Ordered : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(900, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Method of Payment :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(717, 613);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 701);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.cmbOrderMade);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddmore);
            this.Controls.Add(this.btnOrderItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderItems;
        private System.Windows.Forms.Button btnAddmore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox FirstOutput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbSix;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.CheckBox chkFullSet;
        private System.Windows.Forms.CheckBox chkBean;
        private System.Windows.Forms.CheckBox chkSugar;
        private System.Windows.Forms.CheckBox chkRice;
        private System.Windows.Forms.ListBox FirstBrand;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.ComboBox cmbOrderMade;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.CheckBox chkMilk;
    }
}

