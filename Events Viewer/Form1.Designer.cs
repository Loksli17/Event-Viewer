
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
            this.eventsCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsCount.Location = new System.Drawing.Point(240, 28);
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(71, 30);
            this.eventsCount.TabIndex = 1;
            this.eventsCount.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amout of events: ";
            // 
            // eventsView
            // 
            this.eventsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view});
            this.eventsView.Location = new System.Drawing.Point(50, 70);
            this.eventsView.Name = "eventsView";
            this.eventsView.RowTemplate.Height = 25;
            this.eventsView.Size = new System.Drawing.Size(798, 460);
            this.eventsView.TabIndex = 4;
            this.eventsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsView_CellContentClick);
            // 
            // view
            // 
            this.view.HeaderText = "View";
            this.view.Name = "view";
            // 
            // EventJournalName
            // 
            this.EventJournalName.FormattingEnabled = true;
            this.EventJournalName.Location = new System.Drawing.Point(907, 70);
            this.EventJournalName.Name = "EventJournalName";
            this.EventJournalName.Size = new System.Drawing.Size(121, 23);
            this.EventJournalName.TabIndex = 5;
            this.EventJournalName.SelectedIndexChanged += new System.EventHandler(this.EventJournalName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 605);
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
        private System.Windows.Forms.DataGridViewButtonColumn view;
        private System.Windows.Forms.ComboBox EventJournalName;
    }
}

