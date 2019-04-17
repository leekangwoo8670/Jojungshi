namespace Jojungshi190326
{
    partial class Form2
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
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.platform_cmb = new System.Windows.Forms.ComboBox();
            this.genre_cmb = new System.Windows.Forms.ComboBox();
            this.age_cmb = new System.Windows.Forms.ComboBox();
            this.developer_cmb = new System.Windows.Forms.ComboBox();
            this.people_cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.year_txb1 = new System.Windows.Forms.TextBox();
            this.year_txb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(257, 329);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(212, 42);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLATFORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(84, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "GENRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(84, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "AGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(84, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "DEVELOPER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(84, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "FOR N PEOPLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(84, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "RELEASED YEAR";
            // 
            // platform_cmb
            // 
            this.platform_cmb.FormattingEnabled = true;
            this.platform_cmb.Items.AddRange(new object[] {
            "Nintendo64",
            "Play Station 1",
            "Play Station 2",
            "Play Station 3",
            "Play Station 4",
            "DreamCast ",
            "XBOX 360",
            "XBOX ONE",
            "Wii",
            "Switch",
            "GameCube",
            "PC",
            "GameBoyAdvance",
            "Nintendo 3DS",
            "PSP",
            "PSP VITA"});
            this.platform_cmb.Location = new System.Drawing.Point(226, 58);
            this.platform_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platform_cmb.Name = "platform_cmb";
            this.platform_cmb.Size = new System.Drawing.Size(386, 20);
            this.platform_cmb.TabIndex = 2;
            // 
            // genre_cmb
            // 
            this.genre_cmb.FormattingEnabled = true;
            this.genre_cmb.Items.AddRange(new object[] {
            "RPG",
            "FPS",
            "AOS",
            "Puzzle",
            "Horror"});
            this.genre_cmb.Location = new System.Drawing.Point(226, 100);
            this.genre_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genre_cmb.Name = "genre_cmb";
            this.genre_cmb.Size = new System.Drawing.Size(386, 20);
            this.genre_cmb.TabIndex = 2;
            // 
            // age_cmb
            // 
            this.age_cmb.FormattingEnabled = true;
            this.age_cmb.Items.AddRange(new object[] {
            "For ALL",
            "+7",
            "+12",
            "+15",
            "+19"});
            this.age_cmb.Location = new System.Drawing.Point(226, 142);
            this.age_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.age_cmb.Name = "age_cmb";
            this.age_cmb.Size = new System.Drawing.Size(386, 20);
            this.age_cmb.TabIndex = 2;
            // 
            // developer_cmb
            // 
            this.developer_cmb.FormattingEnabled = true;
            this.developer_cmb.Items.AddRange(new object[] {
            "Sega",
            "BANDAI ",
            "Nintendo",
            "Gameloft",
            "Gamebill",
            "Netmarble",
            "Dimps",
            "Namco"});
            this.developer_cmb.Location = new System.Drawing.Point(226, 186);
            this.developer_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.developer_cmb.Name = "developer_cmb";
            this.developer_cmb.Size = new System.Drawing.Size(386, 20);
            this.developer_cmb.TabIndex = 2;
            // 
            // people_cmb
            // 
            this.people_cmb.FormattingEnabled = true;
            this.people_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4 or More"});
            this.people_cmb.Location = new System.Drawing.Point(226, 235);
            this.people_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.people_cmb.Name = "people_cmb";
            this.people_cmb.Size = new System.Drawing.Size(386, 20);
            this.people_cmb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(405, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "~";
            // 
            // year_txb1
            // 
            this.year_txb1.Location = new System.Drawing.Point(226, 282);
            this.year_txb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.year_txb1.Name = "year_txb1";
            this.year_txb1.Size = new System.Drawing.Size(175, 21);
            this.year_txb1.TabIndex = 4;
            // 
            // year_txb2
            // 
            this.year_txb2.Location = new System.Drawing.Point(428, 282);
            this.year_txb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.year_txb2.Name = "year_txb2";
            this.year_txb2.Size = new System.Drawing.Size(183, 21);
            this.year_txb2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 396);
            this.Controls.Add(this.year_txb2);
            this.Controls.Add(this.year_txb1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.people_cmb);
            this.Controls.Add(this.developer_cmb);
            this.Controls.Add(this.age_cmb);
            this.Controls.Add(this.genre_cmb);
            this.Controls.Add(this.platform_cmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "The Game Recommender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genre_cmb;
        private System.Windows.Forms.ComboBox age_cmb;
        private System.Windows.Forms.ComboBox developer_cmb;
        private System.Windows.Forms.ComboBox people_cmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox year_txb1;
        private System.Windows.Forms.TextBox year_txb2;
        private System.Windows.Forms.ComboBox platform_cmb;
    }
}