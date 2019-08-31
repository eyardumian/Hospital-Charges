namespace HospitalChargesApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumDays = new System.Windows.Forms.TextBox();
            this.textBoxMedCharges = new System.Windows.Forms.TextBox();
            this.textBoxSurCharges = new System.Windows.Forms.TextBox();
            this.textBoxPhysRehab = new System.Windows.Forms.TextBox();
            this.buttonCalculations = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLabFees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of days spent in the hospital:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of medication charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of surgical charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount of physical rehabilitation charges:";
            // 
            // textBoxNumDays
            // 
            this.textBoxNumDays.Location = new System.Drawing.Point(357, 32);
            this.textBoxNumDays.Name = "textBoxNumDays";
            this.textBoxNumDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumDays.TabIndex = 4;
            // 
            // textBoxMedCharges
            // 
            this.textBoxMedCharges.Location = new System.Drawing.Point(357, 67);
            this.textBoxMedCharges.Name = "textBoxMedCharges";
            this.textBoxMedCharges.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedCharges.TabIndex = 5;
            // 
            // textBoxSurCharges
            // 
            this.textBoxSurCharges.Location = new System.Drawing.Point(357, 103);
            this.textBoxSurCharges.Name = "textBoxSurCharges";
            this.textBoxSurCharges.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurCharges.TabIndex = 6;
            // 
            // textBoxPhysRehab
            // 
            this.textBoxPhysRehab.Location = new System.Drawing.Point(357, 172);
            this.textBoxPhysRehab.Name = "textBoxPhysRehab";
            this.textBoxPhysRehab.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhysRehab.TabIndex = 7;
            // 
            // buttonCalculations
            // 
            this.buttonCalculations.Location = new System.Drawing.Point(253, 228);
            this.buttonCalculations.Name = "buttonCalculations";
            this.buttonCalculations.Size = new System.Drawing.Size(126, 32);
            this.buttonCalculations.TabIndex = 8;
            this.buttonCalculations.Text = "Calculate Charges";
            this.buttonCalculations.UseVisualStyleBackColor = true;
            this.buttonCalculations.Click += new System.EventHandler(this.buttonCalculations_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount of lab fees:";
            // 
            // textBoxLabFees
            // 
            this.textBoxLabFees.Location = new System.Drawing.Point(357, 136);
            this.textBoxLabFees.Name = "textBoxLabFees";
            this.textBoxLabFees.Size = new System.Drawing.Size(100, 20);
            this.textBoxLabFees.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLabFees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalculations);
            this.Controls.Add(this.textBoxPhysRehab);
            this.Controls.Add(this.textBoxSurCharges);
            this.Controls.Add(this.textBoxMedCharges);
            this.Controls.Add(this.textBoxNumDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumDays;
        private System.Windows.Forms.TextBox textBoxMedCharges;
        private System.Windows.Forms.TextBox textBoxSurCharges;
        private System.Windows.Forms.TextBox textBoxPhysRehab;
        private System.Windows.Forms.Button buttonCalculations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLabFees;
    }
}

