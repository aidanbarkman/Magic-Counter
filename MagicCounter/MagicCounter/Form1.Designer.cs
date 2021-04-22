namespace MagicCounter
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
            this.counterTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.playersLife = new System.Windows.Forms.Label();
            this.playerNum = new System.Windows.Forms.Label();
            this.playersLifeLbl = new System.Windows.Forms.Label();
            this.playersLbl = new System.Windows.Forms.Label();
            this.playNumLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fourty = new System.Windows.Forms.Button();
            this.thirty = new System.Windows.Forms.Button();
            this.twenty = new System.Windows.Forms.Button();
            this.playerRemove = new System.Windows.Forms.Button();
            this.playerAdd = new System.Windows.Forms.Button();
            this.counterTabs = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playtb3 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Button();
            this.sub1 = new System.Windows.Forms.Button();
            this.play1 = new System.Windows.Forms.RichTextBox();
            this.play2 = new System.Windows.Forms.RichTextBox();
            this.play4 = new System.Windows.Forms.RichTextBox();
            this.play3 = new System.Windows.Forms.RichTextBox();
            this.sub3 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.sub2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.sub4 = new System.Windows.Forms.Button();
            this.add4 = new System.Windows.Forms.Button();
            this.counterTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.counterTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterTab
            // 
            this.counterTab.Controls.Add(this.tabPage1);
            this.counterTab.Controls.Add(this.counterTabs);
            this.counterTab.Location = new System.Drawing.Point(12, 1);
            this.counterTab.Name = "counterTab";
            this.counterTab.SelectedIndex = 0;
            this.counterTab.Size = new System.Drawing.Size(1465, 925);
            this.counterTab.TabIndex = 7;
            this.counterTab.Click += new System.EventHandler(this.counterTab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.playersLife);
            this.tabPage1.Controls.Add(this.playerNum);
            this.tabPage1.Controls.Add(this.playersLifeLbl);
            this.tabPage1.Controls.Add(this.playersLbl);
            this.tabPage1.Controls.Add(this.playNumLbl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.fourty);
            this.tabPage1.Controls.Add(this.thirty);
            this.tabPage1.Controls.Add(this.twenty);
            this.tabPage1.Controls.Add(this.playerRemove);
            this.tabPage1.Controls.Add(this.playerAdd);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1449, 878);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Set Up";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // playersLife
            // 
            this.playersLife.AutoSize = true;
            this.playersLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playersLife.Location = new System.Drawing.Point(759, 369);
            this.playersLife.Name = "playersLife";
            this.playersLife.Size = new System.Drawing.Size(64, 46);
            this.playersLife.TabIndex = 17;
            this.playersLife.Text = "20";
            // 
            // playerNum
            // 
            this.playerNum.AutoSize = true;
            this.playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playerNum.Location = new System.Drawing.Point(759, 678);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(42, 46);
            this.playerNum.TabIndex = 16;
            this.playerNum.Text = "4";
            // 
            // playersLifeLbl
            // 
            this.playersLifeLbl.AutoSize = true;
            this.playersLifeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playersLifeLbl.Location = new System.Drawing.Point(501, 369);
            this.playersLifeLbl.Name = "playersLifeLbl";
            this.playersLifeLbl.Size = new System.Drawing.Size(239, 46);
            this.playersLifeLbl.TabIndex = 15;
            this.playersLifeLbl.Text = "Players Life:";
            this.playersLifeLbl.Click += new System.EventHandler(this.playersLife_Click);
            // 
            // playersLbl
            // 
            this.playersLbl.AutoSize = true;
            this.playersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playersLbl.Location = new System.Drawing.Point(586, 678);
            this.playersLbl.Name = "playersLbl";
            this.playersLbl.Size = new System.Drawing.Size(164, 46);
            this.playersLbl.TabIndex = 14;
            this.playersLbl.Text = "Players:";
            // 
            // playNumLbl
            // 
            this.playNumLbl.AutoSize = true;
            this.playNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playNumLbl.Location = new System.Drawing.Point(469, 480);
            this.playNumLbl.Name = "playNumLbl";
            this.playNumLbl.Size = new System.Drawing.Size(506, 63);
            this.playNumLbl.TabIndex = 13;
            this.playNumLbl.Text = "How Many Players?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(414, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 63);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set a Life Total Amount";
            // 
            // fourty
            // 
            this.fourty.Location = new System.Drawing.Point(1014, 182);
            this.fourty.Name = "fourty";
            this.fourty.Size = new System.Drawing.Size(176, 157);
            this.fourty.TabIndex = 11;
            this.fourty.Text = "40 Life";
            this.fourty.UseVisualStyleBackColor = true;
            this.fourty.Click += new System.EventHandler(this.fourty_Click);
            // 
            // thirty
            // 
            this.thirty.Location = new System.Drawing.Point(638, 182);
            this.thirty.Name = "thirty";
            this.thirty.Size = new System.Drawing.Size(176, 157);
            this.thirty.TabIndex = 10;
            this.thirty.Text = "30 Life";
            this.thirty.UseVisualStyleBackColor = true;
            this.thirty.Click += new System.EventHandler(this.thirty_Click);
            // 
            // twenty
            // 
            this.twenty.Location = new System.Drawing.Point(258, 182);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(176, 157);
            this.twenty.TabIndex = 9;
            this.twenty.Text = "20 Life";
            this.twenty.UseVisualStyleBackColor = true;
            this.twenty.Click += new System.EventHandler(this.twenty_Click);
            // 
            // playerRemove
            // 
            this.playerRemove.Location = new System.Drawing.Point(891, 601);
            this.playerRemove.Name = "playerRemove";
            this.playerRemove.Size = new System.Drawing.Size(299, 212);
            this.playerRemove.TabIndex = 8;
            this.playerRemove.Text = "Remove Player";
            this.playerRemove.UseVisualStyleBackColor = true;
            this.playerRemove.Click += new System.EventHandler(this.playerRemove_Click);
            // 
            // playerAdd
            // 
            this.playerAdd.Location = new System.Drawing.Point(258, 601);
            this.playerAdd.Name = "playerAdd";
            this.playerAdd.Size = new System.Drawing.Size(299, 212);
            this.playerAdd.TabIndex = 7;
            this.playerAdd.Text = "Add Player";
            this.playerAdd.UseVisualStyleBackColor = true;
            this.playerAdd.Click += new System.EventHandler(this.playerAdd_Click);
            // 
            // counterTabs
            // 
            this.counterTabs.Controls.Add(this.sub4);
            this.counterTabs.Controls.Add(this.add4);
            this.counterTabs.Controls.Add(this.sub2);
            this.counterTabs.Controls.Add(this.add2);
            this.counterTabs.Controls.Add(this.sub3);
            this.counterTabs.Controls.Add(this.add3);
            this.counterTabs.Controls.Add(this.play3);
            this.counterTabs.Controls.Add(this.play4);
            this.counterTabs.Controls.Add(this.play2);
            this.counterTabs.Controls.Add(this.play1);
            this.counterTabs.Controls.Add(this.sub1);
            this.counterTabs.Controls.Add(this.add1);
            this.counterTabs.Controls.Add(this.textBox4);
            this.counterTabs.Controls.Add(this.textBox3);
            this.counterTabs.Controls.Add(this.playtb3);
            this.counterTabs.Controls.Add(this.textBox1);
            this.counterTabs.Location = new System.Drawing.Point(8, 39);
            this.counterTabs.Name = "counterTabs";
            this.counterTabs.Padding = new System.Windows.Forms.Padding(3);
            this.counterTabs.Size = new System.Drawing.Size(1449, 878);
            this.counterTabs.TabIndex = 1;
            this.counterTabs.Text = "Counter";
            this.counterTabs.UseVisualStyleBackColor = true;
            this.counterTabs.Click += new System.EventHandler(this.counterTabs_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(70, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 82);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Player 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playtb3
            // 
            this.playtb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.playtb3.Location = new System.Drawing.Point(70, 629);
            this.playtb3.Multiline = true;
            this.playtb3.Name = "playtb3";
            this.playtb3.Size = new System.Drawing.Size(272, 82);
            this.playtb3.TabIndex = 1;
            this.playtb3.Text = "Player 3";
            this.playtb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox3.Location = new System.Drawing.Point(898, 92);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 82);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Player 2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox4.Location = new System.Drawing.Point(898, 629);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 82);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Player 4";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(365, 92);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(79, 42);
            this.add1.TabIndex = 4;
            this.add1.Text = "Add";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // sub1
            // 
            this.sub1.Location = new System.Drawing.Point(365, 140);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(79, 46);
            this.sub1.TabIndex = 5;
            this.sub1.Text = "Sub";
            this.sub1.UseVisualStyleBackColor = true;
            this.sub1.Click += new System.EventHandler(this.sub1_Click);
            // 
            // play1
            // 
            this.play1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.play1.Location = new System.Drawing.Point(474, 78);
            this.play1.Name = "play1";
            this.play1.ReadOnly = true;
            this.play1.Size = new System.Drawing.Size(100, 96);
            this.play1.TabIndex = 12;
            this.play1.Text = "";
            // 
            // play2
            // 
            this.play2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.play2.Location = new System.Drawing.Point(1315, 78);
            this.play2.Name = "play2";
            this.play2.ReadOnly = true;
            this.play2.Size = new System.Drawing.Size(100, 96);
            this.play2.TabIndex = 13;
            this.play2.Text = "";
            // 
            // play4
            // 
            this.play4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.play4.Location = new System.Drawing.Point(1315, 615);
            this.play4.Name = "play4";
            this.play4.ReadOnly = true;
            this.play4.Size = new System.Drawing.Size(100, 96);
            this.play4.TabIndex = 14;
            this.play4.Text = "";
            // 
            // play3
            // 
            this.play3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.play3.Location = new System.Drawing.Point(474, 615);
            this.play3.Name = "play3";
            this.play3.ReadOnly = true;
            this.play3.Size = new System.Drawing.Size(100, 96);
            this.play3.TabIndex = 15;
            this.play3.Text = "";
            // 
            // sub3
            // 
            this.sub3.Location = new System.Drawing.Point(375, 677);
            this.sub3.Name = "sub3";
            this.sub3.Size = new System.Drawing.Size(79, 42);
            this.sub3.TabIndex = 17;
            this.sub3.Text = "Sub";
            this.sub3.UseVisualStyleBackColor = true;
            this.sub3.Click += new System.EventHandler(this.sub3_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(375, 629);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(79, 42);
            this.add3.TabIndex = 16;
            this.add3.Text = "Add";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // sub2
            // 
            this.sub2.Location = new System.Drawing.Point(1208, 140);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(79, 46);
            this.sub2.TabIndex = 19;
            this.sub2.Text = "Sub";
            this.sub2.UseVisualStyleBackColor = true;
            this.sub2.Click += new System.EventHandler(this.sub2_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(1208, 92);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(79, 42);
            this.add2.TabIndex = 18;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // sub4
            // 
            this.sub4.Location = new System.Drawing.Point(1208, 677);
            this.sub4.Name = "sub4";
            this.sub4.Size = new System.Drawing.Size(79, 42);
            this.sub4.TabIndex = 21;
            this.sub4.Text = "Sub";
            this.sub4.UseVisualStyleBackColor = true;
            this.sub4.Click += new System.EventHandler(this.sub4_Click);
            // 
            // add4
            // 
            this.add4.Location = new System.Drawing.Point(1208, 629);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(79, 42);
            this.add4.TabIndex = 20;
            this.add4.Text = "Add";
            this.add4.UseVisualStyleBackColor = true;
            this.add4.Click += new System.EventHandler(this.add4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 925);
            this.Controls.Add(this.counterTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Magic Life Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.counterTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.counterTabs.ResumeLayout(false);
            this.counterTabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl counterTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label playersLbl;
        private System.Windows.Forms.Label playNumLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fourty;
        private System.Windows.Forms.Button thirty;
        private System.Windows.Forms.Button twenty;
        private System.Windows.Forms.Button playerRemove;
        private System.Windows.Forms.Button playerAdd;
        private System.Windows.Forms.TabPage counterTabs;
        private System.Windows.Forms.Label playerNum;
        private System.Windows.Forms.Label playersLifeLbl;
        private System.Windows.Forms.Label playersLife;
        private System.Windows.Forms.Button sub1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox playtb3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sub4;
        private System.Windows.Forms.Button add4;
        private System.Windows.Forms.Button sub2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button sub3;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.RichTextBox play3;
        private System.Windows.Forms.RichTextBox play4;
        private System.Windows.Forms.RichTextBox play2;
        private System.Windows.Forms.RichTextBox play1;
    }
}

