namespace Density_To_MinWidth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transparentLabel1 = new DarkControls.Controls.TransparentLabel();
            this.closeBtn = new DarkControls.Controls.WindowsDefaultTitleBarButton();
            this.appIcon1 = new DarkControls.Controls.AppIcon();
            this.densityBar = new System.Windows.Forms.TrackBar();
            this.minWidthValueLbl = new System.Windows.Forms.Label();
            this.densityLbl = new System.Windows.Forms.Label();
            this.widthBox = new DarkControls.Controls.DarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new DarkControls.Controls.DarkTextBox();
            this.minWidthBar = new System.Windows.Forms.TrackBar();
            this.resBox = new DarkControls.Controls.FlatComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setBtn = new DarkControls.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWidthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.Location = new System.Drawing.Point(32, 4);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(310, 20);
            this.transparentLabel1.TabIndex = 8;
            this.transparentLabel1.Text = "Android Minimum Width To Screen Density";
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Close;
            this.closeBtn.ClickColor = System.Drawing.Color.Red;
            this.closeBtn.ClickIconColor = System.Drawing.Color.Black;
            this.closeBtn.HoverColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.HoverIconColor = System.Drawing.Color.Black;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconLineThickness = 2;
            this.closeBtn.Location = new System.Drawing.Point(776, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "windowsDefaultTitleBarButton1";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // appIcon1
            // 
            this.appIcon1.AppIconImage = ((System.Drawing.Image)(resources.GetObject("appIcon1.AppIconImage")));
            this.appIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.appIcon1.DragForm = null;
            this.appIcon1.Image = ((System.Drawing.Image)(resources.GetObject("appIcon1.Image")));
            this.appIcon1.Location = new System.Drawing.Point(0, 1);
            this.appIcon1.Name = "appIcon1";
            this.appIcon1.Scale = 3.5F;
            this.appIcon1.Size = new System.Drawing.Size(28, 28);
            this.appIcon1.TabIndex = 9;
            this.appIcon1.TabStop = false;
            // 
            // densityBar
            // 
            this.densityBar.Location = new System.Drawing.Point(21, 224);
            this.densityBar.Maximum = 3200;
            this.densityBar.Minimum = 1;
            this.densityBar.Name = "densityBar";
            this.densityBar.Size = new System.Drawing.Size(792, 45);
            this.densityBar.TabIndex = 10;
            this.densityBar.Value = 1;
            this.densityBar.Scroll += new System.EventHandler(this.densityBar_Scroll);
            // 
            // minWidthValueLbl
            // 
            this.minWidthValueLbl.AutoSize = true;
            this.minWidthValueLbl.Location = new System.Drawing.Point(30, 127);
            this.minWidthValueLbl.Name = "minWidthValueLbl";
            this.minWidthValueLbl.Size = new System.Drawing.Size(85, 13);
            this.minWidthValueLbl.TabIndex = 11;
            this.minWidthValueLbl.Text = "Minimum Width: ";
            // 
            // densityLbl
            // 
            this.densityLbl.AutoSize = true;
            this.densityLbl.Location = new System.Drawing.Point(33, 208);
            this.densityLbl.Name = "densityLbl";
            this.densityLbl.Size = new System.Drawing.Size(78, 13);
            this.densityLbl.TabIndex = 12;
            this.densityLbl.Text = "Density Value: ";
            // 
            // widthBox
            // 
            this.widthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.widthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthBox.ForeColor = System.Drawing.Color.Silver;
            this.widthBox.Location = new System.Drawing.Point(179, 81);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 13;
            this.widthBox.Text = "1440";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Screen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Screen Height";
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.heightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightBox.ForeColor = System.Drawing.Color.Silver;
            this.heightBox.Location = new System.Drawing.Point(288, 81);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 15;
            this.heightBox.Text = "3088";
            // 
            // minWidthBar
            // 
            this.minWidthBar.Location = new System.Drawing.Point(21, 143);
            this.minWidthBar.Maximum = 3200;
            this.minWidthBar.Minimum = 1;
            this.minWidthBar.Name = "minWidthBar";
            this.minWidthBar.Size = new System.Drawing.Size(792, 45);
            this.minWidthBar.TabIndex = 17;
            this.minWidthBar.Value = 1;
            this.minWidthBar.Scroll += new System.EventHandler(this.minWidthBar_Scroll);
            // 
            // resBox
            // 
            this.resBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.resBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.resBox.ForeColor = System.Drawing.Color.Silver;
            this.resBox.FormattingEnabled = true;
            this.resBox.Items.AddRange(new object[] {
            "1440x3088",
            "1080x2316",
            "720x1544"});
            this.resBox.Location = new System.Drawing.Point(36, 80);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(121, 21);
            this.resBox.TabIndex = 18;
            this.resBox.SelectedIndexChanged += new System.EventHandler(this.resBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Screen Resolution";
            // 
            // setBtn
            // 
            this.setBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBtn.ForeColor = System.Drawing.Color.Silver;
            this.setBtn.Location = new System.Drawing.Point(12, 262);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 20;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(816, 300);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.minWidthBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.densityLbl);
            this.Controls.Add(this.minWidthValueLbl);
            this.Controls.Add(this.densityBar);
            this.Controls.Add(this.appIcon1);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.closeBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWidthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkControls.Controls.WindowsDefaultTitleBarButton closeBtn;
        private DarkControls.Controls.TransparentLabel transparentLabel1;
        private DarkControls.Controls.AppIcon appIcon1;
        private System.Windows.Forms.TrackBar densityBar;
        private System.Windows.Forms.Label minWidthValueLbl;
        private System.Windows.Forms.Label densityLbl;
        private DarkControls.Controls.DarkTextBox widthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DarkControls.Controls.DarkTextBox heightBox;
        private System.Windows.Forms.TrackBar minWidthBar;
        private DarkControls.Controls.FlatComboBox resBox;
        private System.Windows.Forms.Label label3;
        private DarkControls.Controls.DarkButton setBtn;
    }
}

