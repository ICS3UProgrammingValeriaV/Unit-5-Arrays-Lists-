namespace StringsAreEqualVV
{
    partial class frmStrings
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
            this.lblString1 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.ForeColor = System.Drawing.Color.Maroon;
            this.lblString1.Location = new System.Drawing.Point(42, 103);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(72, 25);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "String 1";
            // 
            // txtString1
            // 
            this.txtString1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString1.Location = new System.Drawing.Point(150, 108);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(125, 22);
            this.txtString1.TabIndex = 1;
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.ForeColor = System.Drawing.Color.Maroon;
            this.lblString2.Location = new System.Drawing.Point(42, 150);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(74, 25);
            this.lblString2.TabIndex = 2;
            this.lblString2.Text = "String 2";
            // 
            // txtString2
            // 
            this.txtString2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString2.Location = new System.Drawing.Point(150, 155);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(125, 22);
            this.txtString2.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Maroon;
            this.lblInstructions.Location = new System.Drawing.Point(12, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(333, 25);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Enter two strings to see if they are equal";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSide.Location = new System.Drawing.Point(14, 49);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(169, 21);
            this.lblSide.TabIndex = 5;
            this.lblSide.Text = "(Check doesn\'t matter)";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Maroon;
            this.btnCheck.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.Location = new System.Drawing.Point(110, 205);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 28);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(346, 302);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString1);
            this.Name = "frmStrings";
            this.Text = "\"Strings are equal\" by Valeria V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Button btnCheck;
    }
}

