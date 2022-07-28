namespace ExHScrollBar
{
    partial class frnTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnTemperatura));
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblGraus = new System.Windows.Forms.Label();
            this.hsbScroll = new System.Windows.Forms.HScrollBar();
            this.picCalor = new System.Windows.Forms.PictureBox();
            this.picFrio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(246, 109);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(186, 40);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperatura";
            // 
            // lblGraus
            // 
            this.lblGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraus.Location = new System.Drawing.Point(298, 181);
            this.lblGraus.Name = "lblGraus";
            this.lblGraus.Size = new System.Drawing.Size(81, 21);
            this.lblGraus.TabIndex = 1;
            this.lblGraus.Text = "23 Graus";
            // 
            // hsbScroll
            // 
            this.hsbScroll.LargeChange = 1;
            this.hsbScroll.Location = new System.Drawing.Point(206, 221);
            this.hsbScroll.Maximum = 50;
            this.hsbScroll.Minimum = -5;
            this.hsbScroll.Name = "hsbScroll";
            this.hsbScroll.Size = new System.Drawing.Size(260, 26);
            this.hsbScroll.TabIndex = 2;
            this.hsbScroll.Value = 23;
            this.hsbScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScroll_Scroll);
            // 
            // picCalor
            // 
            this.picCalor.Image = ((System.Drawing.Image)(resources.GetObject("picCalor.Image")));
            this.picCalor.Location = new System.Drawing.Point(416, 271);
            this.picCalor.Name = "picCalor";
            this.picCalor.Size = new System.Drawing.Size(50, 50);
            this.picCalor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalor.TabIndex = 3;
            this.picCalor.TabStop = false;
            this.picCalor.Visible = false;
            // 
            // picFrio
            // 
            this.picFrio.Image = ((System.Drawing.Image)(resources.GetObject("picFrio.Image")));
            this.picFrio.Location = new System.Drawing.Point(206, 271);
            this.picFrio.Name = "picFrio";
            this.picFrio.Size = new System.Drawing.Size(52, 50);
            this.picFrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrio.TabIndex = 4;
            this.picFrio.TabStop = false;
            this.picFrio.Visible = false;
            // 
            // frnTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 333);
            this.Controls.Add(this.picFrio);
            this.Controls.Add(this.picCalor);
            this.Controls.Add(this.hsbScroll);
            this.Controls.Add(this.lblGraus);
            this.Controls.Add(this.lblTemp);
            this.Name = "frnTemperatura";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.picCalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGraus;
        private System.Windows.Forms.HScrollBar hsbScroll;
        private System.Windows.Forms.PictureBox picCalor;
        private System.Windows.Forms.PictureBox picFrio;
    }
}

