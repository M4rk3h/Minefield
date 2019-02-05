namespace Minefield
{
    partial class Welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtInstructionText = new System.Windows.Forms.RichTextBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.txtInstructionText);
            this.panel1.Controls.Add(this.txtInstructions);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(30, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Minefield.Properties.Resources.MinefieldGame;
            this.pictureBox1.Location = new System.Drawing.Point(63, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(24, 227);
            this.richTextBox2.MaxLength = 40;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(326, 90);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Keep an eye on your bomb detector (top right) whilst making your way through the " +
    "minefield..when you\'re ready press the Go, go, go! button at the bottom.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 185);
            this.richTextBox1.MaxLength = 40;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(177, 36);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Bomb Detector";
            // 
            // txtInstructionText
            // 
            this.txtInstructionText.BackColor = System.Drawing.Color.ForestGreen;
            this.txtInstructionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructionText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtInstructionText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructionText.Location = new System.Drawing.Point(24, 107);
            this.txtInstructionText.MaxLength = 40;
            this.txtInstructionText.Name = "txtInstructionText";
            this.txtInstructionText.ReadOnly = true;
            this.txtInstructionText.Size = new System.Drawing.Size(326, 72);
            this.txtInstructionText.TabIndex = 3;
            this.txtInstructionText.Text = "Make your way through the minefield with the on screen arrows (bottom right) or u" +
    "se the keyobard keys (WASD). ";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.ForestGreen;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtInstructions.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(24, 65);
            this.txtInstructions.MaxLength = 40;
            this.txtInstructions.Multiline = false;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtInstructions.Size = new System.Drawing.Size(154, 36);
            this.txtInstructions.TabIndex = 2;
            this.txtInstructions.Text = "Instructions: ";
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImage = global::Minefield.Properties.Resources.Camo1;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(24, 323);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(335, 62);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go, go, go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(464, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RichTextBox txtInstructions;
        private System.Windows.Forms.RichTextBox txtInstructionText;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}