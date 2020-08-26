namespace eBvel.Praktica.OtchetVersion.Forms
{
    partial class AddCalendarForm
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Sunday = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Saturday = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Friday = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Thursday = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Wednesday = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tuesday = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Monday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(297, 271);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(108, 41);
            this.Cancel_Button.TabIndex = 46;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            // 
            // Next_Button
            // 
            this.Next_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Next_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Next_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Next_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Next_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next_Button.ForeColor = System.Drawing.Color.White;
            this.Next_Button.Location = new System.Drawing.Point(449, 271);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(108, 41);
            this.Next_Button.TabIndex = 47;
            this.Next_Button.Text = "Далее";
            this.Next_Button.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(28, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "Выберите выходные дни";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.Sunday);
            this.panel7.Location = new System.Drawing.Point(487, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(70, 60);
            this.panel7.TabIndex = 38;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel7_Down);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sunday.ForeColor = System.Drawing.Color.White;
            this.Sunday.Location = new System.Drawing.Point(19, 21);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(36, 21);
            this.Sunday.TabIndex = 5;
            this.Sunday.Text = "Вс.";
            this.Sunday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lSunday_Down);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.Saturday);
            this.panel6.Location = new System.Drawing.Point(411, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 60);
            this.panel6.TabIndex = 39;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel6_Down);
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saturday.ForeColor = System.Drawing.Color.White;
            this.Saturday.Location = new System.Drawing.Point(16, 21);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(40, 21);
            this.Saturday.TabIndex = 5;
            this.Saturday.Text = "Сб.";
            this.Saturday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lSaturday_Down);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.Friday);
            this.panel5.Location = new System.Drawing.Point(335, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 60);
            this.panel5.TabIndex = 40;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel5_Down);
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friday.ForeColor = System.Drawing.Color.White;
            this.Friday.Location = new System.Drawing.Point(20, 21);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(34, 21);
            this.Friday.TabIndex = 5;
            this.Friday.Text = "Пт.";
            this.Friday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lFriday_Down);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Thursday);
            this.panel4.Location = new System.Drawing.Point(259, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 60);
            this.panel4.TabIndex = 41;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_Down);
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Thursday.ForeColor = System.Drawing.Color.White;
            this.Thursday.Location = new System.Drawing.Point(19, 21);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(31, 21);
            this.Thursday.TabIndex = 5;
            this.Thursday.Text = "Чт.";
            this.Thursday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lThursday_Down);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Wednesday);
            this.panel3.Location = new System.Drawing.Point(183, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 60);
            this.panel3.TabIndex = 42;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_Down);
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wednesday.ForeColor = System.Drawing.Color.White;
            this.Wednesday.Location = new System.Drawing.Point(17, 21);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(41, 21);
            this.Wednesday.TabIndex = 5;
            this.Wednesday.Text = "Ср.";
            this.Wednesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lWednesday_Down);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Tuesday);
            this.panel2.Location = new System.Drawing.Point(107, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 60);
            this.panel2.TabIndex = 43;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_Down);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tuesday.ForeColor = System.Drawing.Color.White;
            this.Tuesday.Location = new System.Drawing.Point(18, 21);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(32, 21);
            this.Tuesday.TabIndex = 5;
            this.Tuesday.Text = "Вт.";
            this.Tuesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lTuesday_Down);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Monday);
            this.panel1.Location = new System.Drawing.Point(31, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 60);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_Down);
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Monday.ForeColor = System.Drawing.Color.White;
            this.Monday.Location = new System.Drawing.Point(18, 21);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(37, 21);
            this.Monday.TabIndex = 5;
            this.Monday.Text = "Пн.";
            this.Monday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lMonday_Down);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 55);
            this.label2.TabIndex = 37;
            this.label2.Text = "Введите начальные данные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Дата начала";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // AddCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 338);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddCalendarForm";
            this.Text = "AddCalendarForm";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}