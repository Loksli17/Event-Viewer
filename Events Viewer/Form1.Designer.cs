
namespace Events_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.eventsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsView = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventJournalName = new System.Windows.Forms.ComboBox();
            this.newEventBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PageNum = new System.Windows.Forms.Label();
            this.TakeView = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartView = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EndView = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // eventsCount
            // 
            this.eventsCount.AutoSize = true;
            this.eventsCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsCount.Location = new System.Drawing.Point(860, 191);
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(59, 25);
            this.eventsCount.TabIndex = 1;
            this.eventsCount.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total amount of events: ";
            // 
            // eventsView
            // 
            this.eventsView.AllowUserToAddRows = false;
            this.eventsView.AllowUserToDeleteRows = false;
            this.eventsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view});
            this.eventsView.Location = new System.Drawing.Point(50, 70);
            this.eventsView.Name = "eventsView";
            this.eventsView.ReadOnly = true;
            this.eventsView.RowTemplate.Height = 25;
            this.eventsView.Size = new System.Drawing.Size(561, 460);
            this.eventsView.TabIndex = 4;
            this.eventsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsView_CellContentClick);
            // 
            // view
            // 
            this.view.HeaderText = "View";
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Text = "View";
            this.view.ToolTipText = "View";
            this.view.UseColumnTextForButtonValue = true;
            // 
            // EventJournalName
            // 
            this.EventJournalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventJournalName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventJournalName.FormattingEnabled = true;
            this.EventJournalName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EventJournalName.Location = new System.Drawing.Point(709, 70);
            this.EventJournalName.Name = "EventJournalName";
            this.EventJournalName.Size = new System.Drawing.Size(210, 31);
            this.EventJournalName.TabIndex = 5;
            this.EventJournalName.SelectedIndexChanged += new System.EventHandler(this.EventJournalName_SelectedIndexChanged);
            // 
            // newEventBtn
            // 
            this.newEventBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.newEventBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newEventBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newEventBtn.Location = new System.Drawing.Point(651, 125);
            this.newEventBtn.Name = "newEventBtn";
            this.newEventBtn.Size = new System.Drawing.Size(268, 50);
            this.newEventBtn.TabIndex = 6;
            this.newEventBtn.Text = "New Event";
            this.newEventBtn.UseVisualStyleBackColor = false;
            this.newEventBtn.Click += new System.EventHandler(this.newEventBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(651, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(50, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Event Viewer";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(762, 287);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevBtn.TabIndex = 9;
            this.PrevBtn.Text = "<< Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(843, 287);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = "Next >>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current page:";
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.Location = new System.Drawing.Point(739, 291);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(13, 15);
            this.PageNum.TabIndex = 12;
            this.PageNum.Text = "1";
            // 
            // TakeView
            // 
            this.TakeView.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TakeView.Location = new System.Drawing.Point(732, 338);
            this.TakeView.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.TakeView.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TakeView.Name = "TakeView";
            this.TakeView.Size = new System.Drawing.Size(186, 23);
            this.TakeView.TabIndex = 13;
            this.TakeView.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TakeView.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Take";
            // 
            // StartView
            // 
            this.StartView.AutoSize = true;
            this.StartView.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.StartView.Location = new System.Drawing.Point(695, 393);
            this.StartView.Name = "StartView";
            this.StartView.Size = new System.Drawing.Size(38, 15);
            this.StartView.TabIndex = 15;
            this.StartView.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(798, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "To:";
            // 
            // EndView
            // 
            this.EndView.AutoSize = true;
            this.EndView.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.EndView.Location = new System.Drawing.Point(826, 393);
            this.EndView.Name = "EndView";
            this.EndView.Size = new System.Drawing.Size(44, 15);
            this.EndView.TabIndex = 18;
            this.EndView.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(762, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 687);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EndView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TakeView);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newEventBtn);
            this.Controls.Add(this.EventJournalName);
            this.Controls.Add(this.eventsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventsCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eventsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView eventsView;
        private System.Windows.Forms.ComboBox EventJournalName;
        private System.Windows.Forms.Button newEventBtn;
        private System.Windows.Forms.DataGridViewButtonColumn view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.NumericUpDown TakeView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StartView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label EndView;
        private System.Windows.Forms.Label label11;
    }
}

