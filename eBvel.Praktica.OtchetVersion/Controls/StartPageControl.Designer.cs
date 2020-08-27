namespace eBvel.Praktica.OtchetVersion.Controls
{
    partial class StartPageControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.Reports_Label = new System.Windows.Forms.Label();
            this.References_Label = new System.Windows.Forms.Label();
            this.Reference_Label1 = new System.Windows.Forms.Label();
            this.Reference_Label2 = new System.Windows.Forms.Label();
            this.Report_Label1 = new System.Windows.Forms.Label();
            this.Report_Label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Continue_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производственный календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Exit_Label);
            this.panel1.Controls.Add(this.Reports_Label);
            this.panel1.Controls.Add(this.References_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 488);
            this.panel1.TabIndex = 2;
            // 
            // Exit_Label
            // 
            this.Exit_Label.AutoSize = true;
            this.Exit_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Label.ForeColor = System.Drawing.Color.White;
            this.Exit_Label.Location = new System.Drawing.Point(30, 254);
            this.Exit_Label.Name = "Exit_Label";
            this.Exit_Label.Size = new System.Drawing.Size(86, 30);
            this.Exit_Label.TabIndex = 1;
            this.Exit_Label.Text = "Выход";
            this.Exit_Label.Click += new System.EventHandler(this.Exit_Label_Click);
            this.Exit_Label.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit_Label.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Reports_Label
            // 
            this.Reports_Label.AutoSize = true;
            this.Reports_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reports_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reports_Label.ForeColor = System.Drawing.Color.White;
            this.Reports_Label.Location = new System.Drawing.Point(30, 163);
            this.Reports_Label.Name = "Reports_Label";
            this.Reports_Label.Size = new System.Drawing.Size(95, 30);
            this.Reports_Label.TabIndex = 1;
            this.Reports_Label.Text = "Отчеты";
            this.Reports_Label.Click += new System.EventHandler(this.Reports_Label_Click);
            this.Reports_Label.MouseEnter += new System.EventHandler(this.Report_MouseEnter);
            this.Reports_Label.MouseLeave += new System.EventHandler(this.Report_MouseLeave);
            // 
            // References_Label
            // 
            this.References_Label.AutoSize = true;
            this.References_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.References_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.References_Label.ForeColor = System.Drawing.Color.White;
            this.References_Label.Location = new System.Drawing.Point(30, 77);
            this.References_Label.Name = "References_Label";
            this.References_Label.Size = new System.Drawing.Size(117, 30);
            this.References_Label.TabIndex = 0;
            this.References_Label.Text = "Справки";
            this.References_Label.Click += new System.EventHandler(this.References_Label_Click);
            this.References_Label.MouseEnter += new System.EventHandler(this.Reference_MouseEnter);
            this.References_Label.MouseLeave += new System.EventHandler(this.Reference_MouseLeave);
            // 
            // Reference_Label1
            // 
            this.Reference_Label1.AutoSize = true;
            this.Reference_Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reference_Label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reference_Label1.Location = new System.Drawing.Point(239, 160);
            this.Reference_Label1.Name = "Reference_Label1";
            this.Reference_Label1.Size = new System.Drawing.Size(661, 22);
            this.Reference_Label1.TabIndex = 3;
            this.Reference_Label1.Text = "> СПРАВКА: о запланированных мероприятиях на прошедший день.\r\n";
            this.Reference_Label1.Click += new System.EventHandler(this.Reference_Label1_Click);
            // 
            // Reference_Label2
            // 
            this.Reference_Label2.AutoSize = true;
            this.Reference_Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reference_Label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reference_Label2.Location = new System.Drawing.Point(239, 243);
            this.Reference_Label2.Name = "Reference_Label2";
            this.Reference_Label2.Size = new System.Drawing.Size(611, 22);
            this.Reference_Label2.TabIndex = 4;
            this.Reference_Label2.Text = "> СПРАВКА: о запланированных мероприятиях на текущий год.\r\n";
            this.Reference_Label2.Click += new System.EventHandler(this.Reference_Label2_Click);
            // 
            // Report_Label1
            // 
            this.Report_Label1.AutoSize = true;
            this.Report_Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report_Label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Label1.Location = new System.Drawing.Point(48, 90);
            this.Report_Label1.Name = "Report_Label1";
            this.Report_Label1.Size = new System.Drawing.Size(593, 22);
            this.Report_Label1.TabIndex = 0;
            this.Report_Label1.Text = "> ОТЧЕТ: о запланированных мероприятиях на будущий день.\r\n";
            this.Report_Label1.Click += new System.EventHandler(this.Report_Label1_Click);
            // 
            // Report_Label2
            // 
            this.Report_Label2.AutoSize = true;
            this.Report_Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report_Label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Label2.Location = new System.Drawing.Point(48, 173);
            this.Report_Label2.Name = "Report_Label2";
            this.Report_Label2.Size = new System.Drawing.Size(638, 22);
            this.Report_Label2.TabIndex = 1;
            this.Report_Label2.Text = "> ОТЧЕТ: о мероприятиях, проведенных за интересующий период.\r\n";
            this.Report_Label2.Click += new System.EventHandler(this.Report_Label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(441, 254);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Visible = false;
            // 
            // Continue_Button
            // 
            this.Continue_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Continue_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue_Button.ForeColor = System.Drawing.Color.White;
            this.Continue_Button.Location = new System.Drawing.Point(501, 299);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(140, 44);
            this.Continue_Button.TabIndex = 3;
            this.Continue_Button.Text = "Продолжить";
            this.Continue_Button.UseVisualStyleBackColor = false;
            this.Continue_Button.Visible = false;
            this.Continue_Button.Click += new System.EventHandler(this.Continue_Button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Continue_Button);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.Report_Label2);
            this.panel2.Controls.Add(this.Report_Label1);
            this.panel2.Location = new System.Drawing.Point(191, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 491);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // StartPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Reference_Label2);
            this.Controls.Add(this.Reference_Label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "StartPageControl";
            this.Size = new System.Drawing.Size(929, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.Label Reports_Label;
        private System.Windows.Forms.Label References_Label;
        private System.Windows.Forms.Label Reference_Label1;
        private System.Windows.Forms.Label Reference_Label2;
        private System.Windows.Forms.Label Report_Label1;
        private System.Windows.Forms.Label Report_Label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Panel panel2;
    }
}
