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
            this.Cases_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Calendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Event_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Archive_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Setting_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateCalendar_Menu,
            this.Event_Menu,
            this.Archive_Menu,
            this.Setting_Menu,
            this.Help_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateCalendar_Menu
            // 
            this.CreateCalendar_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Holidays_Menu,
            this.Cases_Menu,
            this.Calendar_Menu});
            this.CreateCalendar_Menu.Name = "CreateCalendar_Menu";
            this.CreateCalendar_Menu.Size = new System.Drawing.Size(96, 24);
            this.CreateCalendar_Menu.Text = "Календарь";
            // 
            // Holidays_Menu
            // 
            this.Holidays_Menu.Name = "Holidays_Menu";
            this.Holidays_Menu.Size = new System.Drawing.Size(210, 26);
            this.Holidays_Menu.Text = "Празднечные дни";
            this.Holidays_Menu.Click += new System.EventHandler(this.Holidays_Menu_Click);
            // 
            // Cases_Menu
            // 
            this.Cases_Menu.Name = "Cases_Menu";
            this.Cases_Menu.Size = new System.Drawing.Size(210, 26);
            this.Cases_Menu.Text = "Список дел";
            this.Cases_Menu.Click += new System.EventHandler(this.Cases_Menu_Click);
            // 
            // Calendar_Menu
            // 
            this.Calendar_Menu.Name = "Calendar_Menu";
            this.Calendar_Menu.Size = new System.Drawing.Size(210, 26);
            this.Calendar_Menu.Text = "Календарь";
            this.Calendar_Menu.Click += new System.EventHandler(this.Calendar_Menu_Click);
            // 
            // Event_Menu
            // 
            this.Event_Menu.Name = "Event_Menu";
            this.Event_Menu.Size = new System.Drawing.Size(171, 24);
            this.Event_Menu.Text = "Список мероприятий";
            this.Event_Menu.Click += new System.EventHandler(this.Event_Menu_Click);
            // 
            // Archive_Menu
            // 
            this.Archive_Menu.Name = "Archive_Menu";
            this.Archive_Menu.Size = new System.Drawing.Size(64, 24);
            this.Archive_Menu.Text = "Архив";
            this.Archive_Menu.Click += new System.EventHandler(this.Archive_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 1;
            // 
            // Setting_Menu
            // 
            this.Setting_Menu.Name = "Setting_Menu";
            this.Setting_Menu.Size = new System.Drawing.Size(102, 24);
            this.Setting_Menu.Text = "Параметры";
            this.Setting_Menu.Click += new System.EventHandler(this.Setting_Menu_Click);
            // 
            // Help_Menu
            // 
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(79, 24);
            this.Help_Menu.Text = "Справка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem Cases_Menu;
        private System.Windows.Forms.ToolStripMenuItem Event_Menu;
        private System.Windows.Forms.ToolStripMenuItem Calendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem Archive_Menu;
        private System.Windows.Forms.ToolStripMenuItem Setting_Menu;
        private System.Windows.Forms.ToolStripMenuItem Help_Menu;
    }
}

