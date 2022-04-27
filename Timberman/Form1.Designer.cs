namespace Timberman
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highscoreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(400, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 680);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Cyan;
            this.playerBox.Location = new System.Drawing.Point(284, 570);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(97, 81);
            this.playerBox.TabIndex = 2;
            this.playerBox.TabStop = false;
            // 
            // scoreLbl
            // 
            this.scoreLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLbl.ForeColor = System.Drawing.Color.White;
            this.scoreLbl.Location = new System.Drawing.Point(400, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(116, 124);
            this.scoreLbl.TabIndex = 3;
            this.scoreLbl.Text = "0";
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Money:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyLbl
            // 
            this.moneyLbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.moneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyLbl.ForeColor = System.Drawing.Color.White;
            this.moneyLbl.Location = new System.Drawing.Point(119, 0);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(134, 53);
            this.moneyLbl.TabIndex = 5;
            this.moneyLbl.Text = "0";
            this.moneyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 53);
            this.label2.TabIndex = 6;
            this.label2.Text = "Highscore:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreLbl
            // 
            this.highscoreLbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.highscoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highscoreLbl.ForeColor = System.Drawing.Color.White;
            this.highscoreLbl.Location = new System.Drawing.Point(171, 48);
            this.highscoreLbl.Name = "highscoreLbl";
            this.highscoreLbl.Size = new System.Drawing.Size(82, 53);
            this.highscoreLbl.TabIndex = 7;
            this.highscoreLbl.Text = "0";
            this.highscoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(923, 663);
            this.Controls.Add(this.highscoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highscoreLbl;
    }
}

