namespace ExCoresRGB
{
    partial class FrnCores
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
            this.lblVermelho = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.hsbScrollVermelho = new System.Windows.Forms.HScrollBar();
            this.hsbScrollVerde = new System.Windows.Forms.HScrollBar();
            this.hsbScrollAzul = new System.Windows.Forms.HScrollBar();
            this.txtValVermelho = new System.Windows.Forms.TextBox();
            this.txtValVerde = new System.Windows.Forms.TextBox();
            this.txtValAzul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVermelho
            // 
            this.lblVermelho.AutoSize = true;
            this.lblVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermelho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVermelho.Location = new System.Drawing.Point(399, 68);
            this.lblVermelho.Name = "lblVermelho";
            this.lblVermelho.Size = new System.Drawing.Size(101, 24);
            this.lblVermelho.TabIndex = 0;
            this.lblVermelho.Text = "Vermelho";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(82, 68);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(41, 291);
            this.txtColor.TabIndex = 1;
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVerde.Location = new System.Drawing.Point(412, 145);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(67, 24);
            this.lblVerde.TabIndex = 2;
            this.lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAzul.Location = new System.Drawing.Point(412, 229);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(51, 24);
            this.lblAzul.TabIndex = 3;
            this.lblAzul.Text = "Azul";
            // 
            // hsbScrollVermelho
            // 
            this.hsbScrollVermelho.LargeChange = 1;
            this.hsbScrollVermelho.Location = new System.Drawing.Point(307, 107);
            this.hsbScrollVermelho.Maximum = 255;
            this.hsbScrollVermelho.Name = "hsbScrollVermelho";
            this.hsbScrollVermelho.Size = new System.Drawing.Size(266, 20);
            this.hsbScrollVermelho.TabIndex = 4;
            this.hsbScrollVermelho.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScrollVermelho_Scroll);
            // 
            // hsbScrollVerde
            // 
            this.hsbScrollVerde.LargeChange = 1;
            this.hsbScrollVerde.Location = new System.Drawing.Point(307, 178);
            this.hsbScrollVerde.Maximum = 255;
            this.hsbScrollVerde.Name = "hsbScrollVerde";
            this.hsbScrollVerde.Size = new System.Drawing.Size(266, 20);
            this.hsbScrollVerde.TabIndex = 5;
            this.hsbScrollVerde.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScrollVerde_Scroll);
            // 
            // hsbScrollAzul
            // 
            this.hsbScrollAzul.LargeChange = 1;
            this.hsbScrollAzul.Location = new System.Drawing.Point(307, 274);
            this.hsbScrollAzul.Maximum = 255;
            this.hsbScrollAzul.Name = "hsbScrollAzul";
            this.hsbScrollAzul.Size = new System.Drawing.Size(266, 20);
            this.hsbScrollAzul.TabIndex = 6;
            this.hsbScrollAzul.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScrollAzul_Scroll);
            // 
            // txtValVermelho
            // 
            this.txtValVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValVermelho.Location = new System.Drawing.Point(182, 85);
            this.txtValVermelho.Multiline = true;
            this.txtValVermelho.Name = "txtValVermelho";
            this.txtValVermelho.Size = new System.Drawing.Size(61, 42);
            this.txtValVermelho.TabIndex = 7;
            this.txtValVermelho.Text = "0";
            this.txtValVermelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValVermelho.TextChanged += new System.EventHandler(this.txtValVermelho_TextChanged);
            // 
            // txtValVerde
            // 
            this.txtValVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValVerde.Location = new System.Drawing.Point(182, 169);
            this.txtValVerde.Multiline = true;
            this.txtValVerde.Name = "txtValVerde";
            this.txtValVerde.Size = new System.Drawing.Size(61, 42);
            this.txtValVerde.TabIndex = 8;
            this.txtValVerde.Text = "0";
            this.txtValVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValVerde.TextChanged += new System.EventHandler(this.txtValVerde_TextChanged);
            // 
            // txtValAzul
            // 
            this.txtValAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValAzul.Location = new System.Drawing.Point(182, 261);
            this.txtValAzul.Multiline = true;
            this.txtValAzul.Name = "txtValAzul";
            this.txtValAzul.Size = new System.Drawing.Size(61, 42);
            this.txtValAzul.TabIndex = 6;
            this.txtValAzul.Text = "0";
            this.txtValAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValAzul.TextChanged += new System.EventHandler(this.txtValAzul_TextChanged);
            // 
            // FrnCores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 424);
            this.Controls.Add(this.txtValAzul);
            this.Controls.Add(this.txtValVerde);
            this.Controls.Add(this.txtValVermelho);
            this.Controls.Add(this.hsbScrollAzul);
            this.Controls.Add(this.hsbScrollVerde);
            this.Controls.Add(this.hsbScrollVermelho);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblVermelho);
            this.Name = "FrnCores";
            this.Text = "Cores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVermelho;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.HScrollBar hsbScrollVermelho;
        private System.Windows.Forms.HScrollBar hsbScrollVerde;
        private System.Windows.Forms.HScrollBar hsbScrollAzul;
        private System.Windows.Forms.TextBox txtValVermelho;
        private System.Windows.Forms.TextBox txtValVerde;
        private System.Windows.Forms.TextBox txtValAzul;
    }
}

