namespace Simulate_Game
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
            this.btnRed3 = new System.Windows.Forms.Button();
            this.btnGreen4 = new System.Windows.Forms.Button();
            this.btnBlue2 = new System.Windows.Forms.Button();
            this.btnOrange1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRed3
            // 
            this.btnRed3.BackColor = System.Drawing.Color.DarkRed;
            this.btnRed3.Location = new System.Drawing.Point(215, 268);
            this.btnRed3.Name = "btnRed3";
            this.btnRed3.Size = new System.Drawing.Size(224, 195);
            this.btnRed3.TabIndex = 2;
            this.btnRed3.UseVisualStyleBackColor = false;
            // 
            // btnGreen4
            // 
            this.btnGreen4.BackColor = System.Drawing.Color.Green;
            this.btnGreen4.Location = new System.Drawing.Point(484, 268);
            this.btnGreen4.Name = "btnGreen4";
            this.btnGreen4.Size = new System.Drawing.Size(224, 195);
            this.btnGreen4.TabIndex = 3;
            this.btnGreen4.UseVisualStyleBackColor = false;
            // 
            // btnBlue2
            // 
            this.btnBlue2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBlue2.Location = new System.Drawing.Point(484, 54);
            this.btnBlue2.Name = "btnBlue2";
            this.btnBlue2.Size = new System.Drawing.Size(224, 195);
            this.btnBlue2.TabIndex = 4;
            this.btnBlue2.UseVisualStyleBackColor = false;
            this.btnBlue2.Click += new System.EventHandler(this.btnBlue2_Click);
            // 
            // btnOrange1
            // 
            this.btnOrange1.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrange1.Location = new System.Drawing.Point(215, 54);
            this.btnOrange1.Name = "btnOrange1";
            this.btnOrange1.Size = new System.Drawing.Size(224, 195);
            this.btnOrange1.TabIndex = 5;
            this.btnOrange1.UseVisualStyleBackColor = false;
            this.btnOrange1.Click += new System.EventHandler(this.btnOrange1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "asd"});
            this.listBox1.Location = new System.Drawing.Point(26, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 519);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrange1);
            this.Controls.Add(this.btnBlue2);
            this.Controls.Add(this.btnGreen4);
            this.Controls.Add(this.btnRed3);

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 132);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 132);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 132);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 132);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);

            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnRed3;
        private System.Windows.Forms.Button btnGreen4;
        private System.Windows.Forms.Button btnBlue2;
        private System.Windows.Forms.Button btnOrange1;
        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

