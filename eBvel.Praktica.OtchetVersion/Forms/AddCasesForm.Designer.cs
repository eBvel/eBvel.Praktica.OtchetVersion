namespace eBvel.Praktica.OtchetVersion.Forms
{
    partial class AddCasesForm
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
            this.NameEvent_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaceEvent_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameEvent_TextBox
            // 
            this.NameEvent_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameEvent_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameEvent_TextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameEvent_TextBox.Location = new System.Drawing.Point(3, 77);
            this.NameEvent_TextBox.Multiline = true;
            this.NameEvent_TextBox.Name = "NameEvent_TextBox";
            this.NameEvent_TextBox.Size = new System.Drawing.Size(720, 104);
            this.NameEvent_TextBox.TabIndex = 0;
            this.NameEvent_TextBox.Enter += new System.EventHandler(this.NameEventTextBox_Enter);
            this.NameEvent_TextBox.Leave += new System.EventHandler(this.NameEventTextBox_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите запланированное дело";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlaceEvent_TextBox
            // 
            this.PlaceEvent_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PlaceEvent_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlaceEvent_TextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceEvent_TextBox.Location = new System.Drawing.Point(3, 189);
            this.PlaceEvent_TextBox.Name = "PlaceEvent_TextBox";
            this.PlaceEvent_TextBox.Size = new System.Drawing.Size(720, 28);
            this.PlaceEvent_TextBox.TabIndex = 2;
            this.PlaceEvent_TextBox.Enter += new System.EventHandler(this.PlaceEventTextBox_Enter);
            this.PlaceEvent_TextBox.Leave += new System.EventHandler(this.PlaceEventTextBox_Leave);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Add_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(570, 256);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(140, 44);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Ок";
            this.Add_Button.UseVisualStyleBackColor = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(378, 256);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(140, 44);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите мероприятие:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите место проведения:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.PlaceEvent_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameEvent_TextBox);
            this.Name = "AddCasesForm";
            this.Text = "AddCasesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox NameEvent_TextBox;
        protected internal System.Windows.Forms.TextBox PlaceEvent_TextBox;
    }
}