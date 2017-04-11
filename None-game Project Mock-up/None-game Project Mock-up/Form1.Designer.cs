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
            this.Spiller = new System.Windows.Forms.Button();
            this.TidligTurn = new System.Windows.Forms.Button();
            this.NyTurn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.nySpiller = new System.Windows.Forms.Button();
            this.spillerInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.spillerTilbage = new System.Windows.Forms.Button();
            this.tidligTurnTilbage = new System.Windows.Forms.Button();
            this.nyTurnTilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spiller
            // 
            this.Spiller.Location = new System.Drawing.Point(775, 319);
            this.Spiller.Name = "Spiller";
            this.Spiller.Size = new System.Drawing.Size(102, 77);
            this.Spiller.TabIndex = 0;
            this.Spiller.Text = "Spiller";
            this.Spiller.UseVisualStyleBackColor = true;
            this.Spiller.Click += new System.EventHandler(this.button1_Click);
            // 
            // TidligTurn
            // 
            this.TidligTurn.Location = new System.Drawing.Point(764, 46);
            this.TidligTurn.Name = "TidligTurn";
            this.TidligTurn.Size = new System.Drawing.Size(102, 86);
            this.TidligTurn.TabIndex = 1;
            this.TidligTurn.Text = "Tidligere turneringer";
            this.TidligTurn.UseVisualStyleBackColor = true;
            this.TidligTurn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NyTurn
            // 
            this.NyTurn.Location = new System.Drawing.Point(156, 46);
            this.NyTurn.Name = "NyTurn";
            this.NyTurn.Size = new System.Drawing.Size(104, 86);
            this.NyTurn.TabIndex = 2;
            this.NyTurn.Text = "Ny Turnering";
            this.NyTurn.UseVisualStyleBackColor = true;
            this.NyTurn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(156, 362);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 77);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // nySpiller
            // 
            this.nySpiller.Location = new System.Drawing.Point(775, 402);
            this.nySpiller.Name = "nySpiller";
            this.nySpiller.Size = new System.Drawing.Size(102, 77);
            this.nySpiller.TabIndex = 4;
            this.nySpiller.Text = "Ny spiller";
            this.nySpiller.UseVisualStyleBackColor = true;
            this.nySpiller.Click += new System.EventHandler(this.nySpiller_Click);
            // 
            // spillerInfo
            // 
            this.spillerInfo.Location = new System.Drawing.Point(904, 402);
            this.spillerInfo.Name = "spillerInfo";
            this.spillerInfo.Size = new System.Drawing.Size(102, 77);
            this.spillerInfo.TabIndex = 5;
            this.spillerInfo.Text = "Spiller info";
            this.spillerInfo.UseVisualStyleBackColor = true;
            this.spillerInfo.Click += new System.EventHandler(this.spillerInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(806, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // spillerTilbage
            // 
            this.spillerTilbage.Location = new System.Drawing.Point(639, 402);
            this.spillerTilbage.Name = "spillerTilbage";
            this.spillerTilbage.Size = new System.Drawing.Size(102, 77);
            this.spillerTilbage.TabIndex = 10;
            this.spillerTilbage.Text = "Tilbage";
            this.spillerTilbage.UseVisualStyleBackColor = true;
            this.spillerTilbage.Click += new System.EventHandler(this.spillerTilbage_Click);
            // 
            // tidligTurnTilbage
            // 
            this.tidligTurnTilbage.Location = new System.Drawing.Point(672, 151);
            this.tidligTurnTilbage.Name = "tidligTurnTilbage";
            this.tidligTurnTilbage.Size = new System.Drawing.Size(102, 86);
            this.tidligTurnTilbage.TabIndex = 11;
            this.tidligTurnTilbage.Text = "Tilbage";
            this.tidligTurnTilbage.UseVisualStyleBackColor = true;
            this.tidligTurnTilbage.Click += new System.EventHandler(this.tidligTurnTilbage_Click);
            // 
            // nyTurnTilbage
            // 
            this.nyTurnTilbage.Location = new System.Drawing.Point(46, 141);
            this.nyTurnTilbage.Name = "nyTurnTilbage";
            this.nyTurnTilbage.Size = new System.Drawing.Size(104, 86);
            this.nyTurnTilbage.TabIndex = 12;
            this.nyTurnTilbage.Text = "Tilbage";
            this.nyTurnTilbage.UseVisualStyleBackColor = true;
            this.nyTurnTilbage.Click += new System.EventHandler(this.nyTurnTilbage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 510);
            this.Controls.Add(this.nyTurnTilbage);
            this.Controls.Add(this.tidligTurnTilbage);
            this.Controls.Add(this.spillerTilbage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.spillerInfo);
            this.Controls.Add(this.nySpiller);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NyTurn);
            this.Controls.Add(this.TidligTurn);
            this.Controls.Add(this.Spiller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Spiller;
        private System.Windows.Forms.Button TidligTurn;
        private System.Windows.Forms.Button NyTurn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button nySpiller;
        private System.Windows.Forms.Button spillerInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button spillerTilbage;
        private System.Windows.Forms.Button tidligTurnTilbage;
        private System.Windows.Forms.Button nyTurnTilbage;
    }
}

