

// Sandra Liu
// CIS 3309
// Feb 7, 2018

namespace BingoGame
{
    partial class frmBingoGame
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
            this.lblWelcomeToBingo = new System.Windows.Forms.Label();
            this.lblEnterNameHere = new System.Windows.Forms.Label();
            this.txtEnterNameHere = new System.Windows.Forms.TextBox();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnYesPlay = new System.Windows.Forms.Button();
            this.btnNoPlay = new System.Windows.Forms.Button();
            this.lblInstructionsLine1 = new System.Windows.Forms.Label();
            this.lblInstructionsLine2 = new System.Windows.Forms.Label();
            this.lblInstructionsLine3 = new System.Windows.Forms.Label();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblYourBingoCard = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblCalledNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeToBingo
            // 
            this.lblWelcomeToBingo.AutoSize = true;
            this.lblWelcomeToBingo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToBingo.Location = new System.Drawing.Point(333, 9);
            this.lblWelcomeToBingo.Name = "lblWelcomeToBingo";
            this.lblWelcomeToBingo.Size = new System.Drawing.Size(191, 20);
            this.lblWelcomeToBingo.TabIndex = 0;
            this.lblWelcomeToBingo.Text = "Welcome to Bingo!";
            // 
            // lblEnterNameHere
            // 
            this.lblEnterNameHere.AutoSize = true;
            this.lblEnterNameHere.Location = new System.Drawing.Point(280, 40);
            this.lblEnterNameHere.Name = "lblEnterNameHere";
            this.lblEnterNameHere.Size = new System.Drawing.Size(111, 13);
            this.lblEnterNameHere.TabIndex = 1;
            this.lblEnterNameHere.Text = "Enter your name here:";
            // 
            // txtEnterNameHere
            // 
            this.txtEnterNameHere.Location = new System.Drawing.Point(466, 37);
            this.txtEnterNameHere.Name = "txtEnterNameHere";
            this.txtEnterNameHere.Size = new System.Drawing.Size(100, 20);
            this.txtEnterNameHere.TabIndex = 2;
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Location = new System.Drawing.Point(254, 72);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(79, 13);
            this.lblReadyToPlay.TabIndex = 3;
            this.lblReadyToPlay.Text = "Ready to Play?";
            // 
            // btnYesPlay
            // 
            this.btnYesPlay.Location = new System.Drawing.Point(381, 67);
            this.btnYesPlay.Name = "btnYesPlay";
            this.btnYesPlay.Size = new System.Drawing.Size(75, 23);
            this.btnYesPlay.TabIndex = 4;
            this.btnYesPlay.Text = "Yes!";
            this.btnYesPlay.UseVisualStyleBackColor = true;
            this.btnYesPlay.Click += new System.EventHandler(this.btnYesPlay_Click);
            // 
            // btnNoPlay
            // 
            this.btnNoPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNoPlay.Location = new System.Drawing.Point(515, 67);
            this.btnNoPlay.Name = "btnNoPlay";
            this.btnNoPlay.Size = new System.Drawing.Size(75, 23);
            this.btnNoPlay.TabIndex = 5;
            this.btnNoPlay.Text = "No thanks.";
            this.btnNoPlay.UseVisualStyleBackColor = true;
            this.btnNoPlay.Click += new System.EventHandler(this.btnNoPlay_Click);
            // 
            // lblInstructionsLine1
            // 
            this.lblInstructionsLine1.AutoSize = true;
            this.lblInstructionsLine1.Location = new System.Drawing.Point(173, 113);
            this.lblInstructionsLine1.Name = "lblInstructionsLine1";
            this.lblInstructionsLine1.Size = new System.Drawing.Size(436, 13);
            this.lblInstructionsLine1.TabIndex = 6;
            this.lblInstructionsLine1.Text = "We call one number at a time. Check your card for that number and if found, click" +
    " that cell. ";
            // 
            // lblInstructionsLine2
            // 
            this.lblInstructionsLine2.AutoSize = true;
            this.lblInstructionsLine2.Location = new System.Drawing.Point(173, 126);
            this.lblInstructionsLine2.Name = "lblInstructionsLine2";
            this.lblInstructionsLine2.Size = new System.Drawing.Size(431, 13);
            this.lblInstructionsLine2.TabIndex = 7;
            this.lblInstructionsLine2.Text = "We will do the rest, checking for a Bingo or not. The number called will appear t" +
    "o the right.";
            // 
            // lblInstructionsLine3
            // 
            this.lblInstructionsLine3.AutoSize = true;
            this.lblInstructionsLine3.Location = new System.Drawing.Point(161, 139);
            this.lblInstructionsLine3.Name = "lblInstructionsLine3";
            this.lblInstructionsLine3.Size = new System.Drawing.Size(465, 13);
            this.lblInstructionsLine3.TabIndex = 8;
            this.lblInstructionsLine3.Text = " If you do not have the number called in your card, click the \"Don\'t Have\" button" +
    " also to the right.";
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(655, 145);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(75, 23);
            this.btnDontHave.TabIndex = 9;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblYourBingoCard
            // 
            this.lblYourBingoCard.AutoSize = true;
            this.lblYourBingoCard.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBingoCard.Location = new System.Drawing.Point(333, 175);
            this.lblYourBingoCard.Name = "lblYourBingoCard";
            this.lblYourBingoCard.Size = new System.Drawing.Size(182, 20);
            this.lblYourBingoCard.TabIndex = 10;
            this.lblYourBingoCard.Text = "Your Bingo Card";
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(150, 198);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(550, 550);
            this.pnlCard.TabIndex = 11;
            // 
            // lblCalledNumber
            // 
            this.lblCalledNumber.AutoSize = true;
            this.lblCalledNumber.Location = new System.Drawing.Point(652, 96);
            this.lblCalledNumber.Margin = new System.Windows.Forms.Padding(3);
            this.lblCalledNumber.Name = "lblCalledNumber";
            this.lblCalledNumber.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblCalledNumber.Size = new System.Drawing.Size(79, 43);
            this.lblCalledNumber.TabIndex = 12;
            this.lblCalledNumber.Text = " Called Number";
            this.lblCalledNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBingoGame
            // 
            this.AcceptButton = this.btnYesPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNoPlay;
            this.ClientSize = new System.Drawing.Size(827, 733);
            this.Controls.Add(this.lblCalledNumber);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblYourBingoCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.lblInstructionsLine3);
            this.Controls.Add(this.lblInstructionsLine2);
            this.Controls.Add(this.lblInstructionsLine1);
            this.Controls.Add(this.btnNoPlay);
            this.Controls.Add(this.btnYesPlay);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.txtEnterNameHere);
            this.Controls.Add(this.lblEnterNameHere);
            this.Controls.Add(this.lblWelcomeToBingo);
            this.Name = "frmBingoGame";
            this.Text = "Bingo Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeToBingo;
        private System.Windows.Forms.Label lblEnterNameHere;
        private System.Windows.Forms.TextBox txtEnterNameHere;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnYesPlay;
        private System.Windows.Forms.Button btnNoPlay;
        private System.Windows.Forms.Label lblInstructionsLine1;
        private System.Windows.Forms.Label lblInstructionsLine2;
        private System.Windows.Forms.Label lblInstructionsLine3;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblYourBingoCard;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblCalledNumber;
    }
}

