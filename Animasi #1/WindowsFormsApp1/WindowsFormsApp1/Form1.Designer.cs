namespace WindowsFormsApp1
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawBtn = new System.Windows.Forms.Button();
            this.hippoBtn = new System.Windows.Forms.Button();
            this.rabbitBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(437, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouseStatus
            // 
            this.mouseStatus.Name = "mouseStatus";
            this.mouseStatus.Size = new System.Drawing.Size(40, 17);
            this.mouseStatus.Text = "X:- Y:-";
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(177, 41);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "Animate";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.animateClick);
            // 
            // hippoBtn
            // 
            this.hippoBtn.Location = new System.Drawing.Point(134, 12);
            this.hippoBtn.Name = "hippoBtn";
            this.hippoBtn.Size = new System.Drawing.Size(75, 23);
            this.hippoBtn.TabIndex = 2;
            this.hippoBtn.Text = "Hippo";
            this.hippoBtn.UseVisualStyleBackColor = true;
            this.hippoBtn.Click += new System.EventHandler(this.drawHippo);
            // 
            // rabbitBtn
            // 
            this.rabbitBtn.Location = new System.Drawing.Point(226, 12);
            this.rabbitBtn.Name = "rabbitBtn";
            this.rabbitBtn.Size = new System.Drawing.Size(75, 23);
            this.rabbitBtn.TabIndex = 3;
            this.rabbitBtn.Text = "Rabbit";
            this.rabbitBtn.UseVisualStyleBackColor = true;
            this.rabbitBtn.Click += new System.EventHandler(this.drawRabbit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(437, 445);
            this.Controls.Add(this.rabbitBtn);
            this.Controls.Add(this.hippoBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseStatus;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button hippoBtn;
        private System.Windows.Forms.Button rabbitBtn;
    }
}

