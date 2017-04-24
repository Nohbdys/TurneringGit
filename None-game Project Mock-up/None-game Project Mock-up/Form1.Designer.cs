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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.hold = new System.Windows.Forms.Button();
            this.TidligTurn = new System.Windows.Forms.Button();
            this.NyTurn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.holdNy = new System.Windows.Forms.Button();
            this.holdInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tilbage = new System.Windows.Forms.Button();
            this.TournamentName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TeamAmount = new System.Windows.Forms.TextBox();
            this.SportType = new System.Windows.Forms.TextBox();
            this.TourStartDate = new System.Windows.Forms.TextBox();
            this.TourEndDate = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Slet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // hold
            // 
            this.hold.Location = new System.Drawing.Point(305, 240);
            this.hold.Margin = new System.Windows.Forms.Padding(2);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(167, 61);
            this.hold.TabIndex = 0;
            this.hold.Text = "Hold";
            this.hold.UseVisualStyleBackColor = true;
            this.hold.Click += new System.EventHandler(this.button1_Click);
            // 
            // TidligTurn
            // 
            this.TidligTurn.Location = new System.Drawing.Point(305, 164);
            this.TidligTurn.Margin = new System.Windows.Forms.Padding(2);
            this.TidligTurn.Name = "TidligTurn";
            this.TidligTurn.Size = new System.Drawing.Size(167, 61);
            this.TidligTurn.TabIndex = 1;
            this.TidligTurn.Text = "Tidligere turneringer";
            this.TidligTurn.UseVisualStyleBackColor = true;
            this.TidligTurn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NyTurn
            // 
            this.NyTurn.Location = new System.Drawing.Point(305, 89);
            this.NyTurn.Margin = new System.Windows.Forms.Padding(2);
            this.NyTurn.Name = "NyTurn";
            this.NyTurn.Size = new System.Drawing.Size(167, 61);
            this.NyTurn.TabIndex = 2;
            this.NyTurn.Text = "Ny Turnering";
            this.NyTurn.UseVisualStyleBackColor = true;
            this.NyTurn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(9, 372);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(63, 32);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // holdNy
            // 
            this.holdNy.Location = new System.Drawing.Point(280, 180);
            this.holdNy.Margin = new System.Windows.Forms.Padding(2);
            this.holdNy.Name = "holdNy";
            this.holdNy.Size = new System.Drawing.Size(76, 63);
            this.holdNy.TabIndex = 4;
            this.holdNy.Text = "Nyt hold";
            this.holdNy.UseVisualStyleBackColor = true;
            this.holdNy.Click += new System.EventHandler(this.nySpiller_Click);
            // 
            // holdInfo
            // 
            this.holdInfo.Location = new System.Drawing.Point(424, 180);
            this.holdInfo.Margin = new System.Windows.Forms.Padding(2);
            this.holdInfo.Name = "holdInfo";
            this.holdInfo.Size = new System.Drawing.Size(76, 63);
            this.holdInfo.TabIndex = 5;
            this.holdInfo.Text = "Hold info";
            this.holdInfo.UseVisualStyleBackColor = true;
            this.holdInfo.Click += new System.EventHandler(this.spillerInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 355);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tilbage
            // 
            this.tilbage.Location = new System.Drawing.Point(9, 371);
            this.tilbage.Margin = new System.Windows.Forms.Padding(2);
            this.tilbage.Name = "tilbage";
            this.tilbage.Size = new System.Drawing.Size(63, 32);
            this.tilbage.TabIndex = 10;
            this.tilbage.Text = "Tilbage";
            this.tilbage.UseVisualStyleBackColor = true;
            this.tilbage.Click += new System.EventHandler(this.spillerTilbage_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.Location = new System.Drawing.Point(23, 14);
            this.TournamentName.Margin = new System.Windows.Forms.Padding(2);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(76, 20);
            this.TournamentName.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 14;
            // 
            // TeamAmount
            // 
            this.TeamAmount.Location = new System.Drawing.Point(23, 105);
            this.TeamAmount.Margin = new System.Windows.Forms.Padding(2);
            this.TeamAmount.Name = "TeamAmount";
            this.TeamAmount.Size = new System.Drawing.Size(76, 20);
            this.TeamAmount.TabIndex = 15;
            // 
            // SportType
            // 
            this.SportType.Location = new System.Drawing.Point(23, 150);
            this.SportType.Margin = new System.Windows.Forms.Padding(2);
            this.SportType.Name = "SportType";
            this.SportType.Size = new System.Drawing.Size(76, 20);
            this.SportType.TabIndex = 16;
            // 
            // TourStartDate
            // 
            this.TourStartDate.Location = new System.Drawing.Point(23, 196);
            this.TourStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.TourStartDate.Name = "TourStartDate";
            this.TourStartDate.Size = new System.Drawing.Size(76, 20);
            this.TourStartDate.TabIndex = 17;
            // 
            // TourEndDate
            // 
            this.TourEndDate.Location = new System.Drawing.Point(23, 241);
            this.TourEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.TourEndDate.Name = "TourEndDate";
            this.TourEndDate.Size = new System.Drawing.Size(76, 20);
            this.TourEndDate.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(23, 287);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(23, 332);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 20;
            // 
            // turnNavn
            // 
            this.turnNavn.AutoSize = true;
            this.turnNavn.Location = new System.Drawing.Point(103, 16);
            this.turnNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnNavn.Name = "turnNavn";
            this.turnNavn.Size = new System.Drawing.Size(105, 13);
            this.turnNavn.TabIndex = 22;
            this.turnNavn.Text = "Navnet på Turnering";
            // 
            // turnType
            // 
            this.turnType.AutoSize = true;
            this.turnType.Location = new System.Drawing.Point(103, 62);
            this.turnType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnType.Name = "turnType";
            this.turnType.Size = new System.Drawing.Size(77, 13);
            this.turnType.TabIndex = 23;
            this.turnType.Text = "Turneringstype";
            this.turnType.Click += new System.EventHandler(this.label2_Click);
            // 
            // antalHold
            // 
            this.antalHold.AutoSize = true;
            this.antalHold.Location = new System.Drawing.Point(103, 107);
            this.antalHold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.antalHold.Name = "antalHold";
            this.antalHold.Size = new System.Drawing.Size(56, 13);
            this.antalHold.TabIndex = 24;
            this.antalHold.Text = "Antal Hold";
            // 
            // sportsgren
            // 
            this.sportsgren.AutoSize = true;
            this.sportsgren.Location = new System.Drawing.Point(103, 153);
            this.sportsgren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sportsgren.Name = "sportsgren";
            this.sportsgren.Size = new System.Drawing.Size(58, 13);
            this.sportsgren.TabIndex = 25;
            this.sportsgren.Text = "Sportsgren";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(103, 198);
            this.startDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(55, 13);
            this.startDate.TabIndex = 26;
            this.startDate.Text = "Start Dato";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(103, 244);
            this.endDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(51, 13);
            this.endDate.TabIndex = 27;
            this.endDate.Text = "Slut Dato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(346, 14);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 20);
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
            this.AddTeam.Location = new System.Drawing.Point(647, 281);
            this.AddTeam.Margin = new System.Windows.Forms.Padding(2);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(56, 19);
            this.AddTeam.TabIndex = 31;
            this.AddTeam.Text = "Tilføj Hold";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Visible = false;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(346, 44);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 20);
            this.textBox10.TabIndex = 33;
            this.textBox10.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(346, 75);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 34;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(346, 103);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 20);
            this.textBox12.TabIndex = 35;
            this.textBox12.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // holdNavnLabel
            // 
            this.holdNavnLabel.AutoSize = true;
            this.holdNavnLabel.Location = new System.Drawing.Point(286, 16);
            this.holdNavnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.holdNavnLabel.Name = "holdNavnLabel";
            this.holdNavnLabel.Size = new System.Drawing.Size(58, 13);
            this.holdNavnLabel.TabIndex = 39;
            this.holdNavnLabel.Text = "Hold Navn";
            this.holdNavnLabel.Visible = false;
            // 
            // antalSpillerLabel
            // 
            this.antalSpillerLabel.AutoSize = true;
            this.antalSpillerLabel.Location = new System.Drawing.Point(275, 46);
            this.antalSpillerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.antalSpillerLabel.Name = "antalSpillerLabel";
            this.antalSpillerLabel.Size = new System.Drawing.Size(66, 13);
            this.antalSpillerLabel.TabIndex = 40;
            this.antalSpillerLabel.Text = "Antal spillere";
            this.antalSpillerLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(313, 77);
            this.winLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(31, 13);
            this.winLabel.TabIndex = 41;
            this.winLabel.Text = "Wins";
            this.winLabel.Visible = false;
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Location = new System.Drawing.Point(313, 107);
            this.lossLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(29, 13);
            this.lossLabel.TabIndex = 42;
            this.lossLabel.Text = "Loss";
            this.lossLabel.Visible = false;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(289, 150);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Win";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Goal";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(486, 244);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(232, 9);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 368);
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
            this.button1.Location = new System.Drawing.Point(256, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 69);
            this.button1.TabIndex = 46;
            this.button1.Text = "Turneringstype 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 69);
            this.button2.TabIndex = 47;
            this.button2.Text = "Turneringstype 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Slet
            // 
            this.Slet.Location = new System.Drawing.Point(556, 281);
            this.Slet.Name = "Slet";
            this.Slet.Size = new System.Drawing.Size(55, 19);
            this.Slet.TabIndex = 48;
            this.Slet.Text = "Slet";
            this.Slet.UseVisualStyleBackColor = true;
            this.Slet.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 335);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 49;
            this.button3.Text = "Tilføj Hold";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 414);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Slet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.TourEndDate);
            this.Controls.Add(this.TourStartDate);
            this.Controls.Add(this.SportType);
            this.Controls.Add(this.TeamAmount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TournamentName);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox TournamentName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TeamAmount;
        private System.Windows.Forms.TextBox SportType;
        private System.Windows.Forms.TextBox TourStartDate;
        private System.Windows.Forms.TextBox TourEndDate;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Slet;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.ColorDialog colorDialog6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

