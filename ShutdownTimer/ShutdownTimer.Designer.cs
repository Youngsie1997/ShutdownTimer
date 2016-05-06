namespace ShutdownTimer
{
    partial class ShutdownTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTimer));
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.TextBox();
            this.shutdownIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.shutdownTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1, 1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(82, 1);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // timerText
            // 
            this.timerText.Location = new System.Drawing.Point(1, 30);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(156, 20);
            this.timerText.TabIndex = 2;
            this.timerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerText_KeyPress);
            // 
            // shutdownIcon
            // 
            this.shutdownIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("shutdownIcon.Icon")));
            this.shutdownIcon.Text = "notifyIcon1";
            this.shutdownIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.shutdownIcon_MouseDoubleClick);
            // 
            // shutdownTime
            // 
            this.shutdownTime.Interval = 1000;
            this.shutdownTime.Tick += new System.EventHandler(this.shutdownTime_Tick);
            // 
            // ShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShutdownTimer";
            this.Text = "ShutdownTimer";
            this.Resize += new System.EventHandler(this.ShutdownTimer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.NotifyIcon shutdownIcon;
        private System.Windows.Forms.Timer shutdownTime;
    }
}

