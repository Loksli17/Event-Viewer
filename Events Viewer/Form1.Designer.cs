
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
            this.eventsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsView = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventJournalName = new System.Windows.Forms.ComboBox();
            this.newEventBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PageNum = new System.Windows.Forms.Label();
            this.TakeView = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartView = new System.Windows.Forms.Label();
            this.EndView = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.eventsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsCount
            // 
            this.eventsCount.AutoSize = true;
            this.eventsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventsCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsCount.Location = new System.Drawing.Point(161, 101);
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(61, 27);
            this.eventsCount.TabIndex = 1;
            this.eventsCount.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total amount: ";
            // 
            // eventsView
            // 
            this.eventsView.AllowUserToAddRows = false;
            this.eventsView.AllowUserToDeleteRows = false;
            this.eventsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view});
            this.eventsView.Location = new System.Drawing.Point(32, 147);
            this.eventsView.Name = "eventsView";
            this.eventsView.ReadOnly = true;
            this.eventsView.RowTemplate.Height = 25;
            this.eventsView.Size = new System.Drawing.Size(561, 442);
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
            this.EventJournalName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EventJournalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventJournalName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventJournalName.FormattingEnabled = true;
            this.EventJournalName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EventJournalName.Location = new System.Drawing.Point(488, 101);
            this.EventJournalName.Name = "EventJournalName";
            this.EventJournalName.Size = new System.Drawing.Size(105, 28);
            this.EventJournalName.TabIndex = 5;
            this.EventJournalName.SelectedIndexChanged += new System.EventHandler(this.EventJournalName_SelectedIndexChanged);
            // 
            // newEventBtn
            // 
            this.newEventBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.newEventBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEventBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newEventBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newEventBtn.Location = new System.Drawing.Point(409, 22);
            this.newEventBtn.Name = "newEventBtn";
            this.newEventBtn.Size = new System.Drawing.Size(184, 45);
            this.newEventBtn.TabIndex = 6;
            this.newEventBtn.Text = "New Event";
            this.newEventBtn.UseVisualStyleBackColor = false;
            this.newEventBtn.Click += new System.EventHandler(this.newEventBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(440, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log:";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevBtn.Location = new System.Drawing.Point(233, 614);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(95, 35);
            this.PrevBtn.TabIndex = 9;
            this.PrevBtn.Text = "<< Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextBtn.Location = new System.Drawing.Point(334, 614);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(95, 35);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = "Next >>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(435, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current page:";
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageNum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageNum.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.PageNum.Location = new System.Drawing.Point(568, 618);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(25, 27);
            this.PageNum.TabIndex = 12;
            this.PageNum.Text = "1";
            // 
            // TakeView
            // 
            this.TakeView.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakeView.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TakeView.Location = new System.Drawing.Point(298, 99);
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
            this.TakeView.Size = new System.Drawing.Size(86, 31);
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
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(242, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Take:";
            // 
            // StartView
            // 
            this.StartView.AutoSize = true;
            this.StartView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartView.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.StartView.Location = new System.Drawing.Point(98, 0);
            this.StartView.Name = "StartView";
            this.StartView.Size = new System.Drawing.Size(52, 21);
            this.StartView.TabIndex = 15;
            this.StartView.Text = "label7";
            this.StartView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndView
            // 
            this.EndView.AutoSize = true;
            this.EndView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndView.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.EndView.Location = new System.Drawing.Point(3, 0);
            this.EndView.Name = "EndView";
            this.EndView.Size = new System.Drawing.Size(61, 21);
            this.EndView.TabIndex = 18;
            this.EndView.Text = "label10";
            this.EndView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(70, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "--";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "All Events";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.EndView);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.StartView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 621);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 25);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 686);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TakeView);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newEventBtn);
            this.Controls.Add(this.EventJournalName);
            this.Controls.Add(this.eventsView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventsCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Event Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.eventsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eventsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView eventsView;
        private System.Windows.Forms.ComboBox EventJournalName;
        private System.Windows.Forms.Button newEventBtn;
        private System.Windows.Forms.DataGridViewButtonColumn view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.NumericUpDown TakeView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StartView;
        private System.Windows.Forms.Label EndView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

