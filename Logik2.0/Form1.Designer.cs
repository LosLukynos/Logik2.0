namespace Logik2._0
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Cursor = System.Windows.Forms.Cursors.No;
            this.pBox.Location = new System.Drawing.Point(12, 12);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(315, 394);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEvaluate.Location = new System.Drawing.Point(12, 415);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(144, 23);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Vyhodnotit";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Location = new System.Drawing.Point(183, 415);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(144, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Nová hra";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnNewGame;
    }
}

