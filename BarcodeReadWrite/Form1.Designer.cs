namespace BarcodeReadWrite
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
            this.BarcodePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncodeTxt = new System.Windows.Forms.TextBox();
            this.DecodeTxt = new System.Windows.Forms.TextBox();
            this.Encodebtn = new System.Windows.Forms.Button();
            this.Decodebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodePic
            // 
            this.BarcodePic.Location = new System.Drawing.Point(59, 52);
            this.BarcodePic.Name = "BarcodePic";
            this.BarcodePic.Size = new System.Drawing.Size(376, 120);
            this.BarcodePic.TabIndex = 0;
            this.BarcodePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encode Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Decode barcode";
            // 
            // EncodeTxt
            // 
            this.EncodeTxt.Location = new System.Drawing.Point(155, 225);
            this.EncodeTxt.Name = "EncodeTxt";
            this.EncodeTxt.Size = new System.Drawing.Size(280, 20);
            this.EncodeTxt.TabIndex = 4;
            // 
            // DecodeTxt
            // 
            this.DecodeTxt.Location = new System.Drawing.Point(155, 270);
            this.DecodeTxt.Name = "DecodeTxt";
            this.DecodeTxt.Size = new System.Drawing.Size(280, 20);
            this.DecodeTxt.TabIndex = 5;
            // 
            // Encodebtn
            // 
            this.Encodebtn.Location = new System.Drawing.Point(192, 336);
            this.Encodebtn.Name = "Encodebtn";
            this.Encodebtn.Size = new System.Drawing.Size(75, 23);
            this.Encodebtn.TabIndex = 6;
            this.Encodebtn.Text = "Encode";
            this.Encodebtn.UseVisualStyleBackColor = true;
            this.Encodebtn.Click += new System.EventHandler(this.Encodebtn_Click);
            // 
            // Decodebtn
            // 
            this.Decodebtn.Location = new System.Drawing.Point(300, 336);
            this.Decodebtn.Name = "Decodebtn";
            this.Decodebtn.Size = new System.Drawing.Size(75, 23);
            this.Decodebtn.TabIndex = 7;
            this.Decodebtn.Text = "Decode";
            this.Decodebtn.UseVisualStyleBackColor = true;
            this.Decodebtn.Click += new System.EventHandler(this.Decodebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.Decodebtn);
            this.Controls.Add(this.Encodebtn);
            this.Controls.Add(this.DecodeTxt);
            this.Controls.Add(this.EncodeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarcodePic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BarcodePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncodeTxt;
        private System.Windows.Forms.TextBox DecodeTxt;
        private System.Windows.Forms.Button Encodebtn;
        private System.Windows.Forms.Button Decodebtn;
    }
}

