namespace eBvel.Praktica.OtchetVersion
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateCalendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Holidays_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Calendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Event_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Archive_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CasesList_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.EventList_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateCalendar_Menu,
            this.Event_Menu,
            this.Archive_Menu,
            this.Setting_Menu,
            this.Help_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateCalendar_Menu
            // 
            this.CreateCalendar_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Holidays_Menu,
            this.Calendar_Menu});
            this.CreateCalendar_Menu.Name = "CreateCalendar_Menu";
            this.CreateCalendar_Menu.Size = new System.Drawing.Size(116, 25);
            this.CreateCalendar_Menu.Text = "Календарь";
            // 
            // Holidays_Menu
            // 
            this.Holidays_Menu.Name = "Holidays_Menu";
            this.Holidays_Menu.Size = new System.Drawing.Size(235, 26);
            this.Holidays_Menu.Text = "Праздничные дни";
            this.Holidays_Menu.Click += new System.EventHandler(this.Holidays_Menu_Click);
            // 
            // Calendar_Menu
            // 
            this.Calendar_Menu.Name = "Calendar_Menu";
            this.Calendar_Menu.Size = new System.Drawing.Size(235, 26);
            this.Calendar_Menu.Text = "Календарь";
            this.Calendar_Menu.Click += new System.EventHandler(this.Calendar_Menu_Click);
            // 
            // Event_Menu
            // 
            this.Event_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CasesList_Menu,
            this.EventList_Menu});
            this.Event_Menu.Name = "Event_Menu";
            this.Event_Menu.Size = new System.Drawing.Size(138, 25);
            this.Event_Menu.Text = "Мероприятия";
            // 
            // Archive_Menu
            // 
            this.Archive_Menu.Name = "Archive_Menu";
            this.Archive_Menu.Size = new System.Drawing.Size(73, 25);
            this.Archive_Menu.Text = "Архив";
            this.Archive_Menu.Click += new System.EventHandler(this.Archive_Menu_Click);
            // 
            // Setting_Menu
            // 
            this.Setting_Menu.Name = "Setting_Menu";
            this.Setting_Menu.Size = new System.Drawing.Size(126, 25);
            this.Setting_Menu.Text = "Параметры";
            this.Setting_Menu.Click += new System.EventHandler(this.Setting_Menu_Click);
            // 
            // Help_Menu
            // 
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(99, 25);
            this.Help_Menu.Text = "Справка";
            this.Help_Menu.Click += new System.EventHandler(this.Help_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 1;
            // 
            // CasesList_Menu
            // 
            this.CasesList_Menu.Name = "CasesList_Menu";
            this.CasesList_Menu.Size = new System.Drawing.Size(272, 26);
            this.CasesList_Menu.Text = "Список дел";
            this.CasesList_Menu.Click += new System.EventHandler(this.CasesList_Menu_Click);
            // 
            // EventList_Menu
            // 
            this.EventList_Menu.Name = "EventList_Menu";
            this.EventList_Menu.Size = new System.Drawing.Size(272, 26);
            this.EventList_Menu.Text = "Список мероприятий";
            this.EventList_Menu.Click += new System.EventHandler(this.EventList_Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Производственный календарь";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateCalendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem Holidays_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem Event_Menu;
        private System.Windows.Forms.ToolStripMenuItem Calendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem Archive_Menu;
        private System.Windows.Forms.ToolStripMenuItem Setting_Menu;
        private System.Windows.Forms.ToolStripMenuItem Help_Menu;
        private System.Windows.Forms.ToolStripMenuItem CasesList_Menu;
        private System.Windows.Forms.ToolStripMenuItem EventList_Menu;
    }
}

