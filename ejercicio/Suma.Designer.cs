namespace ejercicio
{
    partial class Suma
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
            this.BtnSuma = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(30, 96);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(111, 23);
            this.BtnSuma.TabIndex = 0;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(66, 12);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 1;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(66, 35);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(66, 61);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(100, 20);
            this.TxtResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 131);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.BtnSuma);
            this.Name = "Suma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label3;
    }
}