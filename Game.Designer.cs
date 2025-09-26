namespace Rock_Paper_Scissor_Project
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdrock = new System.Windows.Forms.RadioButton();
            this.rdpaper = new System.Windows.Forms.RadioButton();
            this.rdscissor = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.winnerlb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Roundlb = new System.Windows.Forms.Label();
            this.spintimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compwins = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.playerwins = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drawlb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FRlb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Computer";
            // 
            // rdrock
            // 
            this.rdrock.AutoSize = true;
            this.rdrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrock.Location = new System.Drawing.Point(400, 423);
            this.rdrock.Name = "rdrock";
            this.rdrock.Size = new System.Drawing.Size(89, 33);
            this.rdrock.TabIndex = 5;
            this.rdrock.TabStop = true;
            this.rdrock.Tag = "Rock";
            this.rdrock.Text = "Rock";
            this.rdrock.UseVisualStyleBackColor = true;
            this.rdrock.CheckedChanged += new System.EventHandler(this.rdrock_CheckedChanged);
            // 
            // rdpaper
            // 
            this.rdpaper.AutoSize = true;
            this.rdpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpaper.Location = new System.Drawing.Point(548, 423);
            this.rdpaper.Name = "rdpaper";
            this.rdpaper.Size = new System.Drawing.Size(99, 33);
            this.rdpaper.TabIndex = 6;
            this.rdpaper.TabStop = true;
            this.rdpaper.Tag = "paper";
            this.rdpaper.Text = "Paper";
            this.rdpaper.UseVisualStyleBackColor = true;
            this.rdpaper.CheckedChanged += new System.EventHandler(this.rdpaper_CheckedChanged);
            // 
            // rdscissor
            // 
            this.rdscissor.AutoSize = true;
            this.rdscissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdscissor.Location = new System.Drawing.Point(706, 420);
            this.rdscissor.Name = "rdscissor";
            this.rdscissor.Size = new System.Drawing.Size(114, 33);
            this.rdscissor.TabIndex = 7;
            this.rdscissor.TabStop = true;
            this.rdscissor.Tag = "Scissor";
            this.rdscissor.Text = "Scissor";
            this.rdscissor.UseVisualStyleBackColor = true;
            this.rdscissor.CheckedChanged += new System.EventHandler(this.rdscissor_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Rock_Paper_Scissor_Project.Properties.Resources.question_mark_96;
            this.pictureBox2.ImageLocation = "Center";
            this.pictureBox2.Location = new System.Drawing.Point(664, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 247);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Rock_Paper_Scissor_Project.Properties.Resources.question_mark_96;
            this.pictureBox1.ImageLocation = "zoom";
            this.pictureBox1.Location = new System.Drawing.Point(307, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(266, 433);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Round Winner:";
            // 
            // winnerlb
            // 
            this.winnerlb.AutoSize = true;
            this.winnerlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerlb.Location = new System.Drawing.Point(12, 257);
            this.winnerlb.Name = "winnerlb";
            this.winnerlb.Size = new System.Drawing.Size(0, 32);
            this.winnerlb.TabIndex = 10;
            this.winnerlb.Click += new System.EventHandler(this.winnerlb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rounds(3):";
            // 
            // Roundlb
            // 
            this.Roundlb.AutoSize = true;
            this.Roundlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roundlb.Location = new System.Drawing.Point(12, 154);
            this.Roundlb.Name = "Roundlb";
            this.Roundlb.Size = new System.Drawing.Size(32, 36);
            this.Roundlb.TabIndex = 12;
            this.Roundlb.Text = "1";
            // 
            // spintimer
            // 
            this.spintimer.Tick += new System.EventHandler(this.spintimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(939, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Computer wins:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(963, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stats:";
            // 
            // compwins
            // 
            this.compwins.AutoSize = true;
            this.compwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compwins.Location = new System.Drawing.Point(1166, 174);
            this.compwins.Name = "compwins";
            this.compwins.Size = new System.Drawing.Size(0, 29);
            this.compwins.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(939, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Player Wins:";
            // 
            // playerwins
            // 
            this.playerwins.AutoSize = true;
            this.playerwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerwins.Location = new System.Drawing.Point(1108, 216);
            this.playerwins.Name = "playerwins";
            this.playerwins.Size = new System.Drawing.Size(0, 29);
            this.playerwins.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(939, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Draw:";
            // 
            // drawlb
            // 
            this.drawlb.AutoSize = true;
            this.drawlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawlb.Location = new System.Drawing.Point(1051, 265);
            this.drawlb.Name = "drawlb";
            this.drawlb.Size = new System.Drawing.Size(0, 29);
            this.drawlb.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(476, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(939, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 38);
            this.label10.TabIndex = 21;
            this.label10.Text = "Final Result:";
            // 
            // FRlb
            // 
            this.FRlb.AutoSize = true;
            this.FRlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRlb.Location = new System.Drawing.Point(1152, 304);
            this.FRlb.Name = "FRlb";
            this.FRlb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FRlb.Size = new System.Drawing.Size(92, 29);
            this.FRlb.TabIndex = 22;
            this.FRlb.Text = "label11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(360, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(440, 39);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rock Paper Scissor Game";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(60, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 36);
            this.label13.TabIndex = 25;
            this.label13.Text = "3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1295, 545);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FRlb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawlb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.playerwins);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.compwins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Roundlb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.winnerlb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdscissor);
            this.Controls.Add(this.rdpaper);
            this.Controls.Add(this.rdrock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.Text = "Rock-Paper-Scissor game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdrock;
        private System.Windows.Forms.RadioButton rdpaper;
        private System.Windows.Forms.RadioButton rdscissor;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label winnerlb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Roundlb;
        private System.Windows.Forms.Timer spintimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label compwins;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label playerwins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label drawlb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FRlb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

