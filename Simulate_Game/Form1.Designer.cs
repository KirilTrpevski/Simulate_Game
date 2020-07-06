namespace Simulate_Game
{
    partial class timerLabel
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.startTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerResult = new System.Windows.Forms.Label();
            this.Poeni = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "asd"});
            this.listBox1.Location = new System.Drawing.Point(26, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 6;
            // 
            // startTimer
            // 
            this.startTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimer.Location = new System.Drawing.Point(723, 250);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(175, 45);
            this.startTimer.TabIndex = 7;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerResult
            // 
            this.timerResult.AutoSize = true;
            this.timerResult.Location = new System.Drawing.Point(819, 120);
            this.timerResult.Name = "timerResult";
            this.timerResult.Size = new System.Drawing.Size(0, 13);
            this.timerResult.TabIndex = 8;
            // 
            // Poeni
            // 
            this.Poeni.AutoSize = true;
            this.Poeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poeni.Location = new System.Drawing.Point(723, 82);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(149, 37);
            this.Poeni.TabIndex = 9;
            this.Poeni.Text = "Поени: 0";
            // 
            // timeElapsed
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsed.Location = new System.Drawing.Point(864, 9);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(0, 20);
            this.timeElapsed.TabIndex = 10;
            // 
            // timerLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 476);
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.Poeni);
            this.Controls.Add(this.timerResult);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.listBox1);
            this.Name = "timerLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerResult;
        private System.Windows.Forms.Label Poeni;
        private System.Windows.Forms.Label timeElapsed;
    }
}

