namespace MokhatabMan
{
    partial class formAddOrEdit
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
            groupBox1 = new GroupBox();
            numAge = new NumericUpDown();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtMobile = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtFamily = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numAge);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFamily);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فرد";
            // 
            // numAge
            // 
            numAge.Location = new Point(6, 81);
            numAge.Name = "numAge";
            numAge.Size = new Size(168, 26);
            numAge.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 161);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 10;
            label6.Text = "آدرس:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(6, 158);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(473, 141);
            txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 124);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 8;
            label5.Text = "ایمیل:";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(240, 81);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(239, 26);
            txtMobile.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 84);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 6;
            label4.Text = "موبایل:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(473, 26);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 84);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 4;
            label3.Text = "سن:";
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(5, 39);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(239, 26);
            txtFamily.TabIndex = 3;
            txtFamily.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 39);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی:";
            // 
            // txtName
            // 
            txtName.Location = new Point(349, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(130, 26);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 42);
            label1.Name = "label1";
            label1.Size = new Size(30, 18);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(442, 323);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 31);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // formAddOrEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 366);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formAddOrEdit";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Load += formAddOrEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label1;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtMobile;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtFamily;
        private Label label2;
        private NumericUpDown numAge;
        private Button btnSubmit;
    }
}