﻿namespace 에라번역
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.파일열기버튼 = new System.Windows.Forms.Button();
            this.VersionText = new System.Windows.Forms.TextBox();
            this.번역적용버튼 = new System.Windows.Forms.Button();
            this.번역합치기버튼 = new System.Windows.Forms.Button();
            this.되돌리기버튼 = new System.Windows.Forms.Button();
            this.EncodingText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.폴더열기버튼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 파일열기버튼
            // 
            this.파일열기버튼.Location = new System.Drawing.Point(24, 24);
            this.파일열기버튼.Margin = new System.Windows.Forms.Padding(15, 12, 3, 4);
            this.파일열기버튼.Name = "파일열기버튼";
            this.파일열기버튼.Size = new System.Drawing.Size(82, 39);
            this.파일열기버튼.TabIndex = 0;
            this.파일열기버튼.Text = "파일열기";
            this.파일열기버튼.UseVisualStyleBackColor = true;
            this.파일열기버튼.Click += new System.EventHandler(this.파일열기버튼_Click);
            // 
            // VersionText
            // 
            this.VersionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.VersionText.Location = new System.Drawing.Point(61, 208);
            this.VersionText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VersionText.Name = "VersionText";
            this.VersionText.ReadOnly = true;
            this.VersionText.Size = new System.Drawing.Size(274, 16);
            this.VersionText.TabIndex = 1;
            this.VersionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 번역적용버튼
            // 
            this.번역적용버튼.Enabled = false;
            this.번역적용버튼.Location = new System.Drawing.Point(204, 24);
            this.번역적용버튼.Margin = new System.Windows.Forms.Padding(15, 12, 3, 4);
            this.번역적용버튼.Name = "번역적용버튼";
            this.번역적용버튼.Size = new System.Drawing.Size(82, 39);
            this.번역적용버튼.TabIndex = 2;
            this.번역적용버튼.Text = "번역적용";
            this.번역적용버튼.UseVisualStyleBackColor = true;
            // 
            // 번역합치기버튼
            // 
            this.번역합치기버튼.Enabled = false;
            this.번역합치기버튼.Location = new System.Drawing.Point(113, 71);
            this.번역합치기버튼.Margin = new System.Windows.Forms.Padding(15, 12, 3, 4);
            this.번역합치기버튼.Name = "번역합치기버튼";
            this.번역합치기버튼.Size = new System.Drawing.Size(82, 39);
            this.번역합치기버튼.TabIndex = 3;
            this.번역합치기버튼.Text = "번역합치기";
            this.번역합치기버튼.UseVisualStyleBackColor = true;
            // 
            // 되돌리기버튼
            // 
            this.되돌리기버튼.Enabled = false;
            this.되돌리기버튼.Location = new System.Drawing.Point(24, 71);
            this.되돌리기버튼.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.되돌리기버튼.Name = "되돌리기버튼";
            this.되돌리기버튼.Size = new System.Drawing.Size(82, 39);
            this.되돌리기버튼.TabIndex = 4;
            this.되돌리기버튼.Text = "되돌리기";
            this.되돌리기버튼.UseVisualStyleBackColor = true;
            // 
            // EncodingText
            // 
            this.EncodingText.Location = new System.Drawing.Point(235, 177);
            this.EncodingText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncodingText.Name = "EncodingText";
            this.EncodingText.Size = new System.Drawing.Size(100, 23);
            this.EncodingText.TabIndex = 5;
            this.EncodingText.Text = "인코딩설정";
            this.EncodingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncodingText.Enter += new System.EventHandler(this.EncodingText_Enter);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "ERB파일이 들어있는 폴더를 선택해주세요";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "ERB파일을 선택해주세요";
            // 
            // 폴더열기버튼
            // 
            this.폴더열기버튼.Location = new System.Drawing.Point(113, 24);
            this.폴더열기버튼.Margin = new System.Windows.Forms.Padding(15, 12, 3, 4);
            this.폴더열기버튼.Name = "폴더열기버튼";
            this.폴더열기버튼.Size = new System.Drawing.Size(82, 39);
            this.폴더열기버튼.TabIndex = 6;
            this.폴더열기버튼.Text = "폴더열기";
            this.폴더열기버튼.UseVisualStyleBackColor = true;
            this.폴더열기버튼.Click += new System.EventHandler(this.폴더열기버튼_Click);
            // 
            // Main_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 237);
            this.Controls.Add(this.폴더열기버튼);
            this.Controls.Add(this.EncodingText);
            this.Controls.Add(this.되돌리기버튼);
            this.Controls.Add(this.번역합치기버튼);
            this.Controls.Add(this.번역적용버튼);
            this.Controls.Add(this.VersionText);
            this.Controls.Add(this.파일열기버튼);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "에라번역";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_Form_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 파일열기버튼;
        private System.Windows.Forms.TextBox VersionText;
        private System.Windows.Forms.Button 번역적용버튼;
        private System.Windows.Forms.Button 번역합치기버튼;
        private System.Windows.Forms.Button 되돌리기버튼;
        private System.Windows.Forms.TextBox EncodingText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button 폴더열기버튼;
    }
}

