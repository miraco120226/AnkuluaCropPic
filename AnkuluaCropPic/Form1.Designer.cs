namespace AnkuluaCropPic
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openImg = new System.Windows.Forms.Button();
            this.inputImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImgName = new System.Windows.Forms.TextBox();
            this.outputCode = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.pathLabel1 = new System.Windows.Forms.Label();
            this.pathLabel2 = new System.Windows.Forms.Label();
            this.ImgpathLabel2 = new System.Windows.Forms.Label();
            this.ImgpathLabel1 = new System.Windows.Forms.Label();
            this.outputPathPanel = new System.Windows.Forms.Panel();
            this.scrollPanel2 = new System.Windows.Forms.Panel();
            this.inputPathPanel = new System.Windows.Forms.Panel();
            this.scrollPanel1 = new System.Windows.Forms.Panel();
            this.pathPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewLabel = new System.Windows.Forms.Label();
            this.largeScreen = new System.Windows.Forms.RadioButton();
            this.smallScreen = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.setPath = new System.Windows.Forms.Button();
            this.rememCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.inputImg)).BeginInit();
            this.outputPathPanel.SuspendLayout();
            this.scrollPanel2.SuspendLayout();
            this.inputPathPanel.SuspendLayout();
            this.scrollPanel1.SuspendLayout();
            this.pathPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImg
            // 
            this.openImg.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openImg.Location = new System.Drawing.Point(0, 0);
            this.openImg.Margin = new System.Windows.Forms.Padding(0);
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(85, 40);
            this.openImg.TabIndex = 0;
            this.openImg.Text = "Open";
            this.openImg.UseVisualStyleBackColor = true;
            this.openImg.Click += new System.EventHandler(this.openImg_Click);
            // 
            // inputImg
            // 
            this.inputImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputImg.Location = new System.Drawing.Point(3, 3);
            this.inputImg.Name = "inputImg";
            this.inputImg.Size = new System.Drawing.Size(640, 360);
            this.inputImg.TabIndex = 1;
            this.inputImg.TabStop = false;
            this.inputImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputImg_DragDrop);
            this.inputImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputImg_DragEnter);
            this.inputImg.Paint += new System.Windows.Forms.PaintEventHandler(this.inputImg_Paint);
            this.inputImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputImg_MouseDown);
            this.inputImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inputImg_MouseMove);
            this.inputImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inputImg_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ImgName
            // 
            this.ImgName.Location = new System.Drawing.Point(0, 0);
            this.ImgName.Margin = new System.Windows.Forms.Padding(0);
            this.ImgName.Name = "ImgName";
            this.ImgName.Size = new System.Drawing.Size(300, 22);
            this.ImgName.TabIndex = 3;
            this.ImgName.TextChanged += new System.EventHandler(this.ImgName_TextChanged);
            // 
            // outputCode
            // 
            this.outputCode.Location = new System.Drawing.Point(0, 35);
            this.outputCode.Margin = new System.Windows.Forms.Padding(0);
            this.outputCode.Multiline = true;
            this.outputCode.Name = "outputCode";
            this.outputCode.ReadOnly = true;
            this.outputCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputCode.Size = new System.Drawing.Size(300, 66);
            this.outputCode.TabIndex = 4;
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(0, 120);
            this.Copy.Margin = new System.Windows.Forms.Padding(0);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(150, 40);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pathLabel1
            // 
            this.pathLabel1.AutoSize = true;
            this.pathLabel1.Font = new System.Drawing.Font("新細明體", 10F);
            this.pathLabel1.Location = new System.Drawing.Point(0, 0);
            this.pathLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.pathLabel1.Name = "pathLabel1";
            this.pathLabel1.Size = new System.Drawing.Size(105, 14);
            this.pathLabel1.TabIndex = 6;
            this.pathLabel1.Text = "輸入檔案路徑：";
            // 
            // pathLabel2
            // 
            this.pathLabel2.AutoSize = true;
            this.pathLabel2.Font = new System.Drawing.Font("新細明體", 10F);
            this.pathLabel2.Location = new System.Drawing.Point(0, 0);
            this.pathLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.pathLabel2.Name = "pathLabel2";
            this.pathLabel2.Size = new System.Drawing.Size(697, 14);
            this.pathLabel2.TabIndex = 7;
            this.pathLabel2.Text = "TestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestT" +
    "estTestTestTestTestTestTestTestTestTest";
            // 
            // ImgpathLabel2
            // 
            this.ImgpathLabel2.AutoSize = true;
            this.ImgpathLabel2.Font = new System.Drawing.Font("新細明體", 10F);
            this.ImgpathLabel2.Location = new System.Drawing.Point(0, 0);
            this.ImgpathLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.ImgpathLabel2.Name = "ImgpathLabel2";
            this.ImgpathLabel2.Size = new System.Drawing.Size(697, 14);
            this.ImgpathLabel2.TabIndex = 9;
            this.ImgpathLabel2.Text = "TestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestT" +
    "estTestTestTestTestTestTestTestTestTest";
            // 
            // ImgpathLabel1
            // 
            this.ImgpathLabel1.AutoSize = true;
            this.ImgpathLabel1.Font = new System.Drawing.Font("新細明體", 10F);
            this.ImgpathLabel1.Location = new System.Drawing.Point(0, 0);
            this.ImgpathLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.ImgpathLabel1.Name = "ImgpathLabel1";
            this.ImgpathLabel1.Size = new System.Drawing.Size(105, 14);
            this.ImgpathLabel1.TabIndex = 8;
            this.ImgpathLabel1.Text = "輸出檔案路徑：";
            // 
            // outputPathPanel
            // 
            this.outputPathPanel.Controls.Add(this.scrollPanel2);
            this.outputPathPanel.Controls.Add(this.ImgpathLabel1);
            this.outputPathPanel.Location = new System.Drawing.Point(0, 75);
            this.outputPathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.outputPathPanel.Name = "outputPathPanel";
            this.outputPathPanel.Size = new System.Drawing.Size(300, 70);
            this.outputPathPanel.TabIndex = 12;
            // 
            // scrollPanel2
            // 
            this.scrollPanel2.AutoScroll = true;
            this.scrollPanel2.Controls.Add(this.ImgpathLabel2);
            this.scrollPanel2.Location = new System.Drawing.Point(0, 25);
            this.scrollPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.scrollPanel2.Name = "scrollPanel2";
            this.scrollPanel2.Size = new System.Drawing.Size(290, 35);
            this.scrollPanel2.TabIndex = 17;
            // 
            // inputPathPanel
            // 
            this.inputPathPanel.Controls.Add(this.scrollPanel1);
            this.inputPathPanel.Controls.Add(this.pathLabel1);
            this.inputPathPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputPathPanel.Name = "inputPathPanel";
            this.inputPathPanel.Size = new System.Drawing.Size(300, 70);
            this.inputPathPanel.TabIndex = 13;
            // 
            // scrollPanel1
            // 
            this.scrollPanel1.AutoScroll = true;
            this.scrollPanel1.Controls.Add(this.pathLabel2);
            this.scrollPanel1.Location = new System.Drawing.Point(0, 25);
            this.scrollPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.scrollPanel1.Name = "scrollPanel1";
            this.scrollPanel1.Size = new System.Drawing.Size(290, 35);
            this.scrollPanel1.TabIndex = 16;
            // 
            // pathPanel
            // 
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Controls.Add(this.inputPathPanel);
            this.pathPanel.Controls.Add(this.outputPathPanel);
            this.pathPanel.Font = new System.Drawing.Font("新細明體", 10F);
            this.pathPanel.Location = new System.Drawing.Point(0, 100);
            this.pathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(300, 150);
            this.pathPanel.TabIndex = 14;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.Controls.Add(this.panel3);
            this.rightPanel.Controls.Add(this.panel2);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Controls.Add(this.pathPanel);
            this.rightPanel.Location = new System.Drawing.Point(649, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(310, 460);
            this.rightPanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.viewLabel);
            this.panel3.Controls.Add(this.largeScreen);
            this.panel3.Controls.Add(this.smallScreen);
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 20);
            this.panel3.TabIndex = 20;
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(0, 3);
            this.viewLabel.Margin = new System.Windows.Forms.Padding(0);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(53, 12);
            this.viewLabel.TabIndex = 20;
            this.viewLabel.Text = "檢視大小";
            // 
            // largeScreen
            // 
            this.largeScreen.AutoSize = true;
            this.largeScreen.Checked = true;
            this.largeScreen.Location = new System.Drawing.Point(160, 1);
            this.largeScreen.Margin = new System.Windows.Forms.Padding(0);
            this.largeScreen.Name = "largeScreen";
            this.largeScreen.Size = new System.Drawing.Size(68, 16);
            this.largeScreen.TabIndex = 19;
            this.largeScreen.TabStop = true;
            this.largeScreen.Text = "640x360 ";
            this.largeScreen.UseVisualStyleBackColor = true;
            this.largeScreen.CheckedChanged += new System.EventHandler(this.largeScreen_CheckedChanged);
            // 
            // smallScreen
            // 
            this.smallScreen.AutoSize = true;
            this.smallScreen.Location = new System.Drawing.Point(70, 1);
            this.smallScreen.Margin = new System.Windows.Forms.Padding(0);
            this.smallScreen.Name = "smallScreen";
            this.smallScreen.Size = new System.Drawing.Size(65, 16);
            this.smallScreen.TabIndex = 19;
            this.smallScreen.Text = "480x270";
            this.smallScreen.UseVisualStyleBackColor = true;
            this.smallScreen.CheckedChanged += new System.EventHandler(this.smallScreen_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.openImg);
            this.panel2.Controls.Add(this.setPath);
            this.panel2.Controls.Add(this.rememCheckBox);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 18;
            // 
            // setPath
            // 
            this.setPath.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setPath.Location = new System.Drawing.Point(90, 0);
            this.setPath.Margin = new System.Windows.Forms.Padding(0);
            this.setPath.Name = "setPath";
            this.setPath.Size = new System.Drawing.Size(85, 40);
            this.setPath.TabIndex = 15;
            this.setPath.Text = "SetPath";
            this.setPath.UseVisualStyleBackColor = true;
            this.setPath.Click += new System.EventHandler(this.setPath_Click);
            // 
            // rememCheckBox
            // 
            this.rememCheckBox.AutoSize = true;
            this.rememCheckBox.Checked = true;
            this.rememCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememCheckBox.Location = new System.Drawing.Point(195, 14);
            this.rememCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.rememCheckBox.Name = "rememCheckBox";
            this.rememCheckBox.Size = new System.Drawing.Size(72, 16);
            this.rememCheckBox.TabIndex = 16;
            this.rememCheckBox.Text = "記住路徑";
            this.rememCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgName);
            this.panel1.Controls.Add(this.outputCode);
            this.panel1.Controls.Add(this.Copy);
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 160);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.inputImg);
            this.flowLayoutPanel2.Controls.Add(this.rightPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(962, 466);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 511);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 500);
            this.Name = "Form1";
            this.Text = "AnkuluaCropPic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputImg)).EndInit();
            this.outputPathPanel.ResumeLayout(false);
            this.outputPathPanel.PerformLayout();
            this.scrollPanel2.ResumeLayout(false);
            this.scrollPanel2.PerformLayout();
            this.inputPathPanel.ResumeLayout(false);
            this.inputPathPanel.PerformLayout();
            this.scrollPanel1.ResumeLayout(false);
            this.scrollPanel1.PerformLayout();
            this.pathPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openImg;
        private System.Windows.Forms.PictureBox inputImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ImgName;
        private System.Windows.Forms.TextBox outputCode;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label pathLabel1;
        private System.Windows.Forms.Label pathLabel2;
        private System.Windows.Forms.Label ImgpathLabel2;
        private System.Windows.Forms.Label ImgpathLabel1;
        private System.Windows.Forms.Panel outputPathPanel;
        private System.Windows.Forms.Panel inputPathPanel;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button setPath;
        private System.Windows.Forms.Panel scrollPanel1;
        private System.Windows.Forms.Panel scrollPanel2;
        private System.Windows.Forms.CheckBox rememCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton largeScreen;
        private System.Windows.Forms.RadioButton smallScreen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

