﻿namespace WinFormDB01
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpenConnection = new System.Windows.Forms.Button();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB 연결 상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenConnection
            // 
            this.OpenConnection.Font = new System.Drawing.Font("굴림", 20F);
            this.OpenConnection.Location = new System.Drawing.Point(35, 141);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(248, 62);
            this.OpenConnection.TabIndex = 1;
            this.OpenConnection.Text = "Open Connection";
            this.OpenConnection.UseVisualStyleBackColor = true;
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Font = new System.Drawing.Font("굴림", 20F);
            this.CloseConnection.Location = new System.Drawing.Point(478, 141);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(248, 62);
            this.CloseConnection.TabIndex = 2;
            this.CloseConnection.Text = "Close Connection";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.OpenConnection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.Button CloseConnection;
    }
}

