namespace ListBox
{
    partial class Form1
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
            this.idView = new System.Windows.Forms.ListBox();
            this.ivlResult = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idView
            // 
            this.idView.FormattingEnabled = true;
            this.idView.ItemHeight = 12;
            this.idView.Location = new System.Drawing.Point(12, 12);
            this.idView.Name = "idView";
            this.idView.Size = new System.Drawing.Size(120, 88);
            this.idView.TabIndex = 0;
            this.idView.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // ivlResult
            // 
            this.ivlResult.AutoSize = true;
            this.ivlResult.Location = new System.Drawing.Point(13, 107);
            this.ivlResult.Name = "ivlResult";
            this.ivlResult.Size = new System.Drawing.Size(33, 12);
            this.ivlResult.TabIndex = 1;
            this.ivlResult.Text = "결과:";
            this.ivlResult.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(15, 123);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(117, 21);
            this.txtList.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 322);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.ivlResult);
            this.Controls.Add(this.idView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "리스트 추";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox idView;
        private System.Windows.Forms.Label ivlResult;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnAdd;
    }
}

