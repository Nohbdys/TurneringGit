﻿namespace None_game_Project_Mock_up
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.holdNavnLabel = new System.Windows.Forms.Label();
            this.antalSpillerLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Slet = new System.Windows.Forms.Button();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.colorDialog6 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.textBox9.Location = new System.Drawing.Point(461, 17);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 30;
            this.textBox9.Visible = false;
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
            this.AddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(75, 23);
            this.AddTeam.TabIndex = 31;
            this.AddTeam.Text = "Tilføj Hold";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Visible = false;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(461, 54);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 33;
            this.textBox10.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(461, 92);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 34;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(461, 127);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 35;
            this.textBox12.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // holdNavnLabel
            // 
            this.holdNavnLabel.AutoSize = true;
            this.holdNavnLabel.Location = new System.Drawing.Point(381, 20);
            this.holdNavnLabel.Name = "holdNavnLabel";
            this.holdNavnLabel.Size = new System.Drawing.Size(74, 17);
            this.holdNavnLabel.TabIndex = 39;
            this.holdNavnLabel.Text = "Hold Navn";
            this.holdNavnLabel.Visible = false;
            // 
            // antalSpillerLabel
            // 
            this.antalSpillerLabel.AutoSize = true;
            this.antalSpillerLabel.Location = new System.Drawing.Point(367, 57);
            this.antalSpillerLabel.Name = "antalSpillerLabel";
            this.antalSpillerLabel.Size = new System.Drawing.Size(89, 17);
            this.antalSpillerLabel.TabIndex = 40;
            this.antalSpillerLabel.Text = "Antal spillere";
            this.antalSpillerLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(417, 95);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(39, 17);
            this.winLabel.TabIndex = 41;
            this.winLabel.Text = "Wins";
            this.winLabel.Visible = false;
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Location = new System.Drawing.Point(417, 132);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(38, 17);
            this.lossLabel.TabIndex = 42;
            this.lossLabel.Text = "Loss";
            this.lossLabel.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(385, 185);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(648, 300);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(309, 11);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(356, 452);
            this.listBox2.TabIndex = 44;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Hold Navn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 85);
            this.button1.TabIndex = 46;
            this.button1.Text = "Turneringstype 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 85);
            this.button2.TabIndex = 47;
            this.button2.Text = "Turneringstype 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Slet
            // 
            this.Slet.Location = new System.Drawing.Point(741, 346);
            this.Slet.Margin = new System.Windows.Forms.Padding(4);
            this.Slet.Name = "Slet";
            this.Slet.Size = new System.Drawing.Size(73, 23);
            this.Slet.TabIndex = 48;
            this.Slet.Text = "Slet";
            this.Slet.UseVisualStyleBackColor = true;
            this.Slet.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 510);
            this.Controls.Add(this.Slet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lossLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.antalSpillerLabel);
            this.Controls.Add(this.holdNavnLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label holdNavnLabel;
        private System.Windows.Forms.Label antalSpillerLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Slet;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.ColorDialog colorDialog6;
    }
}

