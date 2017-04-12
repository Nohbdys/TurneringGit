namespace None_game_Project_Mock_up
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
            this.components = new System.ComponentModel.Container();
            this.hold = new System.Windows.Forms.Button();
            this.TidligTurn = new System.Windows.Forms.Button();
            this.NyTurn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.holdNy = new System.Windows.Forms.Button();
            this.holdInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tilbage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.turnNavn = new System.Windows.Forms.Label();
            this.turnType = new System.Windows.Forms.Label();
            this.antalHold = new System.Windows.Forms.Label();
            this.sportsgren = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AddTeam = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // hold
            // 
            this.hold.Location = new System.Drawing.Point(407, 295);
            this.hold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(223, 75);
            this.hold.TabIndex = 0;
            this.hold.Text = "Hold";
            this.hold.UseVisualStyleBackColor = true;
            this.hold.Click += new System.EventHandler(this.button1_Click);
            // 
            // TidligTurn
            // 
            this.TidligTurn.Location = new System.Drawing.Point(407, 202);
            this.TidligTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TidligTurn.Name = "TidligTurn";
            this.TidligTurn.Size = new System.Drawing.Size(223, 75);
            this.TidligTurn.TabIndex = 1;
            this.TidligTurn.Text = "Tidligere turneringer";
            this.TidligTurn.UseVisualStyleBackColor = true;
            this.TidligTurn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NyTurn
            // 
            this.NyTurn.Location = new System.Drawing.Point(407, 110);
            this.NyTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NyTurn.Name = "NyTurn";
            this.NyTurn.Size = new System.Drawing.Size(223, 75);
            this.NyTurn.TabIndex = 2;
            this.NyTurn.Text = "Ny Turnering";
            this.NyTurn.UseVisualStyleBackColor = true;
            this.NyTurn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 458);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(84, 39);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // holdNy
            // 
            this.holdNy.Location = new System.Drawing.Point(373, 222);
            this.holdNy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdNy.Name = "holdNy";
            this.holdNy.Size = new System.Drawing.Size(101, 78);
            this.holdNy.TabIndex = 4;
            this.holdNy.Text = "Nyt hold";
            this.holdNy.UseVisualStyleBackColor = true;
            this.holdNy.Click += new System.EventHandler(this.nySpiller_Click);
            // 
            // holdInfo
            // 
            this.holdInfo.Location = new System.Drawing.Point(565, 222);
            this.holdInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdInfo.Name = "holdInfo";
            this.holdInfo.Size = new System.Drawing.Size(101, 78);
            this.holdInfo.TabIndex = 5;
            this.holdInfo.Text = "Hold info";
            this.holdInfo.UseVisualStyleBackColor = true;
            this.holdInfo.Click += new System.EventHandler(this.spillerInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 436);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tilbage
            // 
            this.tilbage.Location = new System.Drawing.Point(12, 457);
            this.tilbage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tilbage.Name = "tilbage";
            this.tilbage.Size = new System.Drawing.Size(84, 39);
            this.tilbage.TabIndex = 10;
            this.tilbage.Text = "Tilbage";
            this.tilbage.UseVisualStyleBackColor = true;
            this.tilbage.Click += new System.EventHandler(this.spillerTilbage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 129);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 185);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(31, 241);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(31, 297);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(31, 353);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(31, 409);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 20;
            // 
            // turnNavn
            // 
            this.turnNavn.AutoSize = true;
            this.turnNavn.Location = new System.Drawing.Point(137, 20);
            this.turnNavn.Name = "turnNavn";
            this.turnNavn.Size = new System.Drawing.Size(139, 17);
            this.turnNavn.TabIndex = 22;
            this.turnNavn.Text = "Navnet på Turnering";
            // 
            // turnType
            // 
            this.turnType.AutoSize = true;
            this.turnType.Location = new System.Drawing.Point(137, 76);
            this.turnType.Name = "turnType";
            this.turnType.Size = new System.Drawing.Size(104, 17);
            this.turnType.TabIndex = 23;
            this.turnType.Text = "Turneringstype";
            this.turnType.Click += new System.EventHandler(this.label2_Click);
            // 
            // antalHold
            // 
            this.antalHold.AutoSize = true;
            this.antalHold.Location = new System.Drawing.Point(137, 132);
            this.antalHold.Name = "antalHold";
            this.antalHold.Size = new System.Drawing.Size(73, 17);
            this.antalHold.TabIndex = 24;
            this.antalHold.Text = "Antal Hold";
            // 
            // sportsgren
            // 
            this.sportsgren.AutoSize = true;
            this.sportsgren.Location = new System.Drawing.Point(137, 188);
            this.sportsgren.Name = "sportsgren";
            this.sportsgren.Size = new System.Drawing.Size(78, 17);
            this.sportsgren.TabIndex = 25;
            this.sportsgren.Text = "Sportsgren";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(137, 244);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(72, 17);
            this.startDate.TabIndex = 26;
            this.startDate.Text = "Start Dato";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(137, 300);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(66, 17);
            this.endDate.TabIndex = 27;
            this.endDate.Text = "Slut Dato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(841, 92);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 30;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddTeam
            // 
            this.AddTeam.Location = new System.Drawing.Point(863, 346);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(75, 23);
            this.AddTeam.TabIndex = 31;
            this.AddTeam.Text = "Tilføj Hold";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 510);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.sportsgren);
            this.Controls.Add(this.antalHold);
            this.Controls.Add(this.turnType);
            this.Controls.Add(this.turnNavn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tilbage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.holdInfo);
            this.Controls.Add(this.holdNy);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NyTurn);
            this.Controls.Add(this.TidligTurn);
            this.Controls.Add(this.hold);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hold;
        private System.Windows.Forms.Button TidligTurn;
        private System.Windows.Forms.Button NyTurn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button holdNy;
        private System.Windows.Forms.Button holdInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button tilbage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label turnNavn;
        private System.Windows.Forms.Label turnType;
        private System.Windows.Forms.Label antalHold;
        private System.Windows.Forms.Label sportsgren;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

