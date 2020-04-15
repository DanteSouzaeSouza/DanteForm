namespace TestApplication
{
    partial class FrmDante
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
            this.btnDante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDante
            // 
            this.btnDante.Location = new System.Drawing.Point(99, 43);
            this.btnDante.Name = "btnDante";
            this.btnDante.Size = new System.Drawing.Size(75, 23);
            this.btnDante.TabIndex = 0;
            this.btnDante.Text = "Dante!";
            this.btnDante.UseVisualStyleBackColor = true;
            // 
            // FrmDante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 87);
            this.Controls.Add(this.btnDante);
            this.Name = "FrmDante";
            this.Text = "Dante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDante;
    }
}

