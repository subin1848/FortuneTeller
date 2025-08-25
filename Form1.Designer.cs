namespace FortuneTeller
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbBirthtime = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.tbBirthtime);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과 보기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 입력해주세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 입력하세요.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(33, 64);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(143, 21);
            this.tbBirthday.TabIndex = 2;
            // 
            // tbBirthtime
            // 
            this.tbBirthtime.Location = new System.Drawing.Point(33, 154);
            this.tbBirthtime.Name = "tbBirthtime";
            this.tbBirthtime.Size = new System.Drawing.Size(69, 21);
            this.tbBirthtime.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(37, 208);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(286, 53);
            this.btn.TabIndex = 4;
            this.btn.Text = "사주 결과 보기";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "포춘텔러";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbBirthtime;
        private System.Windows.Forms.TextBox tbBirthday;
    }
}

