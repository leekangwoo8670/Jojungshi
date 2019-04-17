namespace Jojungshi190326
{
    partial class Form4
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
            this.toback_btn = new System.Windows.Forms.Button();
            this.end_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toback_btn
            // 
            this.toback_btn.Location = new System.Drawing.Point(45, 522);
            this.toback_btn.Name = "toback_btn";
            this.toback_btn.Size = new System.Drawing.Size(137, 53);
            this.toback_btn.TabIndex = 0;
            this.toback_btn.Text = "뒤로";
            this.toback_btn.UseVisualStyleBackColor = true;
            this.toback_btn.Click += new System.EventHandler(this.toback_btn_Click);
            // 
            // end_btn
            // 
            this.end_btn.Location = new System.Drawing.Point(840, 522);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(137, 53);
            this.end_btn.TabIndex = 0;
            this.end_btn.Text = "종료";
            this.end_btn.UseVisualStyleBackColor = true;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(233, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "당신에게 이 게임을 추천드립니다";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.toback_btn);
            this.Name = "Form4";
            this.Text = "The Game Recommender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.end_btn_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toback_btn;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Label label1;
    }
}