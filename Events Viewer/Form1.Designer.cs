
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
            ((System.ComponentModel.ISupportInitialize)(this.eventsView)).BeginInit();
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
            this.eventsCount.Location = new System.Drawing.Point(779, 191);
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
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event\'s amout: ";
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
            this.eventsView.Size = new System.Drawing.Size(559, 460);
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
            this.EventJournalName.Size = new System.Drawing.Size(129, 31);
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
            this.newEventBtn.Size = new System.Drawing.Size(187, 50);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 605);
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
    }
}

