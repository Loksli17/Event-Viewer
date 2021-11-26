namespace Events_Viewer
{
    partial class EventView
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
            this.Message = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.InstanceId = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.Label();
            this.GeneratedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(64, 125);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(38, 15);
            this.Message.TabIndex = 0;
            this.Message.Text = "label1";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(64, 159);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(38, 15);
            this.Index.TabIndex = 1;
            this.Index.Text = "label1";
            // 
            // InstanceId
            // 
            this.InstanceId.AutoSize = true;
            this.InstanceId.Location = new System.Drawing.Point(64, 192);
            this.InstanceId.Name = "InstanceId";
            this.InstanceId.Size = new System.Drawing.Size(38, 15);
            this.InstanceId.TabIndex = 2;
            this.InstanceId.Text = "label1";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(64, 220);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(38, 15);
            this.Type.TabIndex = 3;
            this.Type.Text = "label2";
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(64, 280);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(38, 15);
            this.Source.TabIndex = 5;
            this.Source.Text = "label4";
            // 
            // GeneratedTime
            // 
            this.GeneratedTime.AutoSize = true;
            this.GeneratedTime.Location = new System.Drawing.Point(64, 254);
            this.GeneratedTime.Name = "GeneratedTime";
            this.GeneratedTime.Size = new System.Drawing.Size(38, 15);
            this.GeneratedTime.TabIndex = 6;
            this.GeneratedTime.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event View";
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneratedTime);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.InstanceId);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Message);
            this.Name = "EventView";
            this.Text = "EventView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label InstanceId;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label GeneratedTime;
        private System.Windows.Forms.Label label1;
    }
}