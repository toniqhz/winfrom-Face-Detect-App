namespace winform_faceDetection
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
            this.components = new System.ComponentModel.Container();
            this.imgCam = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.imgOut = new Emgu.CV.UI.ImageBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOut)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCam
            // 
            this.imgCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCam.Location = new System.Drawing.Point(12, 52);
            this.imgCam.Name = "imgCam";
            this.imgCam.Size = new System.Drawing.Size(494, 489);
            this.imgCam.TabIndex = 2;
            this.imgCam.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 31);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnTakePic
            // 
            this.btnTakePic.Location = new System.Drawing.Point(132, 11);
            this.btnTakePic.Name = "btnTakePic";
            this.btnTakePic.Size = new System.Drawing.Size(92, 30);
            this.btnTakePic.TabIndex = 4;
            this.btnTakePic.Text = "Take picture";
            this.btnTakePic.UseVisualStyleBackColor = true;
            this.btnTakePic.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // imgOut
            // 
            this.imgOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgOut.Location = new System.Drawing.Point(516, 53);
            this.imgOut.Name = "imgOut";
            this.imgOut.Size = new System.Drawing.Size(494, 488);
            this.imgOut.TabIndex = 2;
            this.imgOut.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(256, 10);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(110, 30);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload a Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(394, 11);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(299, 24);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Take a selfie or upload your image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 554);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.imgOut);
            this.Controls.Add(this.btnTakePic);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgCam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgCam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTakePic;
        private Emgu.CV.UI.ImageBox imgOut;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblFileName;

    }
}

