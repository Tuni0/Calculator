namespace Kalkulator
{
    partial class Form3
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
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(153, 54);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(13, 15);
            this.a.TabIndex = 0;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(310, 54);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(14, 15);
            this.b.TabIndex = 1;
            this.b.Text = "b";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(472, 54);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(13, 15);
            this.c.TabIndex = 2;
            this.c.Text = "c";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(532, 45);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(204, 46);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 23);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(47, 46);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 23);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(366, 46);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(38, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 325);
            this.panel2.TabIndex = 7;
     //       this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label a;
        private Label b;
        private Label c;
        private Button drawButton;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private TextBox textBoxC;
        private Panel panel2;
    }
}