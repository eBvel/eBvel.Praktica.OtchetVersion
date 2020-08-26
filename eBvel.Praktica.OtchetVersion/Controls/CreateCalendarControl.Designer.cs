namespace eBvel.Praktica.OtchetVersion.Controls
{
    partial class CreateCalendarControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Holiday_Button = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarFullDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 44;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numDayDataGridViewTextBoxColumn,
            this.nameMonthDataGridViewTextBoxColumn,
            this.numYearDataGridViewTextBoxColumn,
            this.calendarFullDateDataGridViewTextBoxColumn,
            this.typeofdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calendarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 363);
            this.dataGridView1.TabIndex = 3;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataSource = typeof(Library.Calendar);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1238, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Create_Button
            // 
            this.Create_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Button.Location = new System.Drawing.Point(6, 439);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(140, 44);
            this.Create_Button.TabIndex = 4;
            this.Create_Button.Text = "Создать";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Holiday_Button
            // 
            this.Holiday_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Holiday_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Holiday_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Holiday_Button.ForeColor = System.Drawing.Color.White;
            this.Holiday_Button.Location = new System.Drawing.Point(223, 439);
            this.Holiday_Button.Name = "Holiday_Button";
            this.Holiday_Button.Size = new System.Drawing.Size(148, 44);
            this.Holiday_Button.TabIndex = 4;
            this.Holiday_Button.Text = "Изменить тип";
            this.Holiday_Button.UseVisualStyleBackColor = false;
            this.Holiday_Button.Click += new System.EventHandler(this.Holiday_Button_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numDayDataGridViewTextBoxColumn
            // 
            this.numDayDataGridViewTextBoxColumn.DataPropertyName = "NumDay";
            this.numDayDataGridViewTextBoxColumn.HeaderText = "Число";
            this.numDayDataGridViewTextBoxColumn.Name = "numDayDataGridViewTextBoxColumn";
            // 
            // nameMonthDataGridViewTextBoxColumn
            // 
            this.nameMonthDataGridViewTextBoxColumn.DataPropertyName = "NameMonth";
            this.nameMonthDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.nameMonthDataGridViewTextBoxColumn.Name = "nameMonthDataGridViewTextBoxColumn";
            // 
            // numYearDataGridViewTextBoxColumn
            // 
            this.numYearDataGridViewTextBoxColumn.DataPropertyName = "NumYear";
            this.numYearDataGridViewTextBoxColumn.HeaderText = "Год";
            this.numYearDataGridViewTextBoxColumn.Name = "numYearDataGridViewTextBoxColumn";
            // 
            // calendarFullDateDataGridViewTextBoxColumn
            // 
            this.calendarFullDateDataGridViewTextBoxColumn.DataPropertyName = "CalendarFullDate";
            this.calendarFullDateDataGridViewTextBoxColumn.HeaderText = "Полная дата";
            this.calendarFullDateDataGridViewTextBoxColumn.Name = "calendarFullDateDataGridViewTextBoxColumn";
            this.calendarFullDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeofdayDataGridViewTextBoxColumn
            // 
            this.typeofdayDataGridViewTextBoxColumn.DataPropertyName = "Typeofday";
            this.typeofdayDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeofdayDataGridViewTextBoxColumn.Name = "typeofdayDataGridViewTextBoxColumn";
            // 
            // CreateCalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Holiday_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CreateCalendarControl";
            this.Size = new System.Drawing.Size(1238, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Holiday_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarFullDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofdayDataGridViewTextBoxColumn;
    }
}
