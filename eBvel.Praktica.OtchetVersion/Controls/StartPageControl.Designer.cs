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
            this.References_Label = new System.Windows.Forms.Label();
            this.Reports_Label = new System.Windows.Forms.Label();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.Reference_Label1 = new System.Windows.Forms.Label();
            this.Reference_Label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(461, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 488);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "> ОТЧЕТ: о запланированных мероприятиях на будущий день.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(638, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "> ОТЧЕТ: о мероприятиях, проведенных за интересующий период.\r\n";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
