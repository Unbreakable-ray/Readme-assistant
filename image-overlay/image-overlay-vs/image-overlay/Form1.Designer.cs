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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.labelimageWidth = new System.Windows.Forms.Label();
            this.labelImageHight = new System.Windows.Forms.Label();
            this.richTextBox_compileOutput = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblTrackBarValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMathmid = new System.Windows.Forms.Label();
            this.lblimageWmod = new System.Windows.Forms.Label();
            this.lblimageHmod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 461);
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
            this.richTextBox_compileOutput.Location = new System.Drawing.Point(27, 47);
            this.richTextBox_compileOutput.Name = "richTextBox_compileOutput";
            this.richTextBox_compileOutput.Size = new System.Drawing.Size(218, 213);
            this.richTextBox_compileOutput.TabIndex = 4;
            this.richTextBox_compileOutput.Text = "";
            this.richTextBox_compileOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(135, 431);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(645, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(410, 489);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(762, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "@xMarayx @Unbreakable-ray";
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(27, 489);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(38, 15);
            this.lblMath.TabIndex = 8;
            this.lblMath.Text = "Math:";
            // 
            // lblTrackBarValue
            // 
            this.lblTrackBarValue.AutoSize = true;
            this.lblTrackBarValue.Location = new System.Drawing.Point(9, 461);
            this.lblTrackBarValue.Name = "lblTrackBarValue";
            this.lblTrackBarValue.Size = new System.Drawing.Size(85, 15);
            this.lblTrackBarValue.TabIndex = 9;
            this.lblTrackBarValue.Text = "Trackbar value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblMathmid
            // 
            this.lblMathmid.AutoSize = true;
            this.lblMathmid.Location = new System.Drawing.Point(710, 245);
            this.lblMathmid.Name = "lblMathmid";
            this.lblMathmid.Size = new System.Drawing.Size(38, 15);
            this.lblMathmid.TabIndex = 12;
            this.lblMathmid.Text = "label3";
            this.lblMathmid.Click += new System.EventHandler(this.lblMathmid_Click);
            // 
            // lblimageWmod
            // 
            this.lblimageWmod.AutoSize = true;
            this.lblimageWmod.Location = new System.Drawing.Point(156, 290);
            this.lblimageWmod.Name = "lblimageWmod";
            this.lblimageWmod.Size = new System.Drawing.Size(87, 15);
            this.lblimageWmod.TabIndex = 13;
            this.lblimageWmod.Text = "Width modfied";
            // 
            // lblimageHmod
            // 
            this.lblimageHmod.AutoSize = true;
            this.lblimageHmod.Location = new System.Drawing.Point(156, 322);
            this.lblimageHmod.Name = "lblimageHmod";
            this.lblimageHmod.Size = new System.Drawing.Size(85, 15);
            this.lblimageHmod.TabIndex = 14;
            this.lblimageHmod.Text = "Hight modfied";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 524);
            this.Controls.Add(this.lblimageHmod);
            this.Controls.Add(this.lblimageWmod);
            this.Controls.Add(this.lblMathmid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrackBarValue);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox_compileOutput);
            this.Controls.Add(this.labelImageHight);
            this.Controls.Add(this.labelimageWidth);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private BindingSource bindingSource1;
        private Button btnUpdate;
        private Label label1;
        private Label lblMath;
        private Label lblTrackBarValue;
        private Label label2;
        private Button button2;
        private Label lblMathmid;
        private Label lblimageWmod;
        private Label lblimageHmod;
    }
}