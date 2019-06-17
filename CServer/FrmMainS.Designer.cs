namespace CServer
{
    partial class FrmMainS
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbChatname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOneClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChatname
            // 
            this.tbChatname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbChatname.Location = new System.Drawing.Point(102, 9);
            this.tbChatname.Name = "tbChatname";
            this.tbChatname.Size = new System.Drawing.Size(119, 21);
            this.tbChatname.TabIndex = 1;
            this.tbChatname.Text = "Hubeen Chat";
            this.tbChatname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Name : ";
            // 
            // btOneClick
            // 
            this.btOneClick.Location = new System.Drawing.Point(227, 9);
            this.btOneClick.Name = "btOneClick";
            this.btOneClick.Size = new System.Drawing.Size(67, 20);
            this.btOneClick.TabIndex = 3;
            this.btOneClick.Text = "Start";
            this.btOneClick.UseVisualStyleBackColor = true;
            this.btOneClick.Click += new System.EventHandler(this.btOneClick_Click);
            // 
            // FrmMainS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 38);
            this.Controls.Add(this.btOneClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChatname);
            this.Name = "FrmMainS";
            this.Text = "Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbChatname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOneClick;
    }
}

