namespace AplicatieGreutate
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
            this.textBoxCalculeaza = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.btnStergeti = new System.Windows.Forms.Button();
            this.controlerAfisare = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCalculeaza
            // 
            this.textBoxCalculeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCalculeaza.Location = new System.Drawing.Point(226, 166);
            this.textBoxCalculeaza.Multiline = true;
            this.textBoxCalculeaza.Name = "textBoxCalculeaza";
            this.textBoxCalculeaza.Size = new System.Drawing.Size(110, 35);
            this.textBoxCalculeaza.TabIndex = 0;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNume.Location = new System.Drawing.Point(226, 100);
            this.textBoxNume.Multiline = true;
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(285, 35);
            this.textBoxNume.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.controlerAfisare);
            this.panel.Location = new System.Drawing.Point(226, 219);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(460, 47);
            this.panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numele dvs !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Greutatea dvs !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(221, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "CALCULATOR GRAVITATIE LUNA !";
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculeaza.Location = new System.Drawing.Point(530, 290);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(156, 48);
            this.btnCalculeaza.TabIndex = 6;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = false;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // btnStergeti
            // 
            this.btnStergeti.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergeti.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStergeti.Location = new System.Drawing.Point(355, 290);
            this.btnStergeti.Name = "btnStergeti";
            this.btnStergeti.Size = new System.Drawing.Size(156, 48);
            this.btnStergeti.TabIndex = 7;
            this.btnStergeti.Text = "Stergeti";
            this.btnStergeti.UseVisualStyleBackColor = false;
            // 
            // controlerAfisare
            // 
            this.controlerAfisare.AutoSize = true;
            this.controlerAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlerAfisare.Location = new System.Drawing.Point(15, 10);
            this.controlerAfisare.Name = "controlerAfisare";
            this.controlerAfisare.Size = new System.Drawing.Size(0, 29);
            this.controlerAfisare.TabIndex = 0;
            this.controlerAfisare.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 364);
            this.Controls.Add(this.btnStergeti);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.textBoxCalculeaza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCalculeaza;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Button btnStergeti;
        private System.Windows.Forms.Label controlerAfisare;
    }
}

