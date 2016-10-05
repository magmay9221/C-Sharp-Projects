namespace TieredPlayerSalaryViaIF_Maggie_Chen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mvp_checkbox = new System.Windows.Forms.CheckBox();
            this.all_star_checkbox = new System.Windows.Forms.CheckBox();
            this.num_hits_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calc_tier_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calc_salary_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.leading_tier_label = new System.Windows.Forms.Label();
            this.leading_salary_label = new System.Windows.Forms.Label();
            this.leading_hits_label = new System.Windows.Forms.Label();
            this.leading_name_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baseball Player Salary Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mvp_checkbox);
            this.groupBox1.Controls.Add(this.all_star_checkbox);
            this.groupBox1.Controls.Add(this.num_hits_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Input";
            // 
            // mvp_checkbox
            // 
            this.mvp_checkbox.AutoSize = true;
            this.mvp_checkbox.Location = new System.Drawing.Point(17, 193);
            this.mvp_checkbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mvp_checkbox.Name = "mvp_checkbox";
            this.mvp_checkbox.Size = new System.Drawing.Size(50, 20);
            this.mvp_checkbox.TabIndex = 5;
            this.mvp_checkbox.Text = "MVP";
            this.mvp_checkbox.UseVisualStyleBackColor = true;
            // 
            // all_star_checkbox
            // 
            this.all_star_checkbox.AutoSize = true;
            this.all_star_checkbox.Location = new System.Drawing.Point(17, 149);
            this.all_star_checkbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.all_star_checkbox.Name = "all_star_checkbox";
            this.all_star_checkbox.Size = new System.Drawing.Size(65, 20);
            this.all_star_checkbox.TabIndex = 4;
            this.all_star_checkbox.Text = "All Star";
            this.all_star_checkbox.UseVisualStyleBackColor = true;
            // 
            // num_hits_textbox
            // 
            this.num_hits_textbox.Location = new System.Drawing.Point(104, 95);
            this.num_hits_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_hits_textbox.Name = "num_hits_textbox";
            this.num_hits_textbox.Size = new System.Drawing.Size(116, 22);
            this.num_hits_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Hits:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(104, 43);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(116, 22);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.Validating += new System.ComponentModel.CancelEventHandler(this.name_textbox_Validating);
            this.name_textbox.Validated += new System.EventHandler(this.name_textbox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player\'s Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calc_tier_label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.calc_salary_label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(299, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(260, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Player\'s Information";
            // 
            // calc_tier_label
            // 
            this.calc_tier_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.calc_tier_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calc_tier_label.Location = new System.Drawing.Point(121, 80);
            this.calc_tier_label.Name = "calc_tier_label";
            this.calc_tier_label.Size = new System.Drawing.Size(117, 25);
            this.calc_tier_label.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Calculated Tier:";
            // 
            // calc_salary_label
            // 
            this.calc_salary_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.calc_salary_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calc_salary_label.Location = new System.Drawing.Point(121, 31);
            this.calc_salary_label.Name = "calc_salary_label";
            this.calc_salary_label.Size = new System.Drawing.Size(117, 25);
            this.calc_salary_label.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calculated Salary:\r\n";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(17, 367);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(146, 37);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(218, 367);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(146, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(413, 367);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(146, 37);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.leading_tier_label);
            this.groupBox3.Controls.Add(this.leading_salary_label);
            this.groupBox3.Controls.Add(this.leading_hits_label);
            this.groupBox3.Controls.Add(this.leading_name_label);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(299, 166);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(260, 177);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leading Player\'s Information";
            // 
            // leading_tier_label
            // 
            this.leading_tier_label.BackColor = System.Drawing.Color.LightBlue;
            this.leading_tier_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leading_tier_label.Location = new System.Drawing.Point(121, 138);
            this.leading_tier_label.Name = "leading_tier_label";
            this.leading_tier_label.Size = new System.Drawing.Size(117, 25);
            this.leading_tier_label.TabIndex = 7;
            // 
            // leading_salary_label
            // 
            this.leading_salary_label.BackColor = System.Drawing.Color.LightBlue;
            this.leading_salary_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leading_salary_label.Location = new System.Drawing.Point(121, 103);
            this.leading_salary_label.Name = "leading_salary_label";
            this.leading_salary_label.Size = new System.Drawing.Size(117, 25);
            this.leading_salary_label.TabIndex = 6;
            // 
            // leading_hits_label
            // 
            this.leading_hits_label.BackColor = System.Drawing.Color.LightBlue;
            this.leading_hits_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leading_hits_label.Location = new System.Drawing.Point(121, 66);
            this.leading_hits_label.Name = "leading_hits_label";
            this.leading_hits_label.Size = new System.Drawing.Size(117, 25);
            this.leading_hits_label.TabIndex = 5;
            // 
            // leading_name_label
            // 
            this.leading_name_label.BackColor = System.Drawing.Color.LightBlue;
            this.leading_name_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leading_name_label.Location = new System.Drawing.Point(121, 30);
            this.leading_name_label.Name = "leading_name_label";
            this.leading_name_label.Size = new System.Drawing.Size(117, 25);
            this.leading_name_label.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tier Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Number of Hits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mvp_checkbox;
        private System.Windows.Forms.CheckBox all_star_checkbox;
        private System.Windows.Forms.TextBox num_hits_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label calc_tier_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label calc_salary_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label leading_tier_label;
        private System.Windows.Forms.Label leading_salary_label;
        private System.Windows.Forms.Label leading_hits_label;
        private System.Windows.Forms.Label leading_name_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

