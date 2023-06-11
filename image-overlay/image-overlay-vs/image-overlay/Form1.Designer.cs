namespace image_overlay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.labelimageWidth = new System.Windows.Forms.Label();
            this.labelImageHight = new System.Windows.Forms.Label();
            this.richTextBox_compileOutput = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Location = new System.Drawing.Point(27, 9);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(126, 15);
            this.labelImagePath.TabIndex = 1;
            this.labelImagePath.Text = "image not selected yet";
            this.labelImagePath.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelimageWidth
            // 
            this.labelimageWidth.AutoSize = true;
            this.labelimageWidth.Location = new System.Drawing.Point(23, 290);
            this.labelimageWidth.Name = "labelimageWidth";
            this.labelimageWidth.Size = new System.Drawing.Size(75, 15);
            this.labelimageWidth.TabIndex = 2;
            this.labelimageWidth.Text = "Image Width";
            this.labelimageWidth.Click += new System.EventHandler(this.labelimageWidth_Click);
            // 
            // labelImageHight
            // 
            this.labelImageHight.AutoSize = true;
            this.labelImageHight.Location = new System.Drawing.Point(23, 322);
            this.labelImageHight.Name = "labelImageHight";
            this.labelImageHight.Size = new System.Drawing.Size(71, 15);
            this.labelImageHight.TabIndex = 3;
            this.labelImageHight.Text = "Image hight";
            this.labelImageHight.UseMnemonic = false;
            this.labelImageHight.Click += new System.EventHandler(this.labelImageHight_Click);
            // 
            // richTextBox_compileOutput
            // 
            this.richTextBox_compileOutput.Location = new System.Drawing.Point(23, 52);
            this.richTextBox_compileOutput.Name = "richTextBox_compileOutput";
            this.richTextBox_compileOutput.Size = new System.Drawing.Size(218, 213);
            this.richTextBox_compileOutput.TabIndex = 4;
            this.richTextBox_compileOutput.Text = "";
            this.richTextBox_compileOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(297, 368);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(315, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 431);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox_compileOutput);
            this.Controls.Add(this.labelImageHight);
            this.Controls.Add(this.labelimageWidth);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label labelImagePath;
        private Label labelimageWidth;
        private Label labelImageHight;
        private RichTextBox richTextBox_compileOutput;
        private TrackBar trackBar1;
    }
}