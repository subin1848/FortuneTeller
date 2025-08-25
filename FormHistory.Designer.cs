namespace FortuneTeller
{
    partial class FormHistory
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
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-24 13:00:01 - 20070302 03 - 오늘은 물을 조심하세요",
            "2025-08-24 13:05:01 - 20070302 03 - 오늘은 불을 조심하세요",
            "2025-08-24 13:10:01 - 20070302 03 - 오늘은 선생님을 조심하세요",
            "2025-08-24 13:30:01 - 20070302 03 - 오늘은 빛을 조심하세요",
            "2025-08-24 13:50:01 - 20070302 03 - 오늘은 흙을 조심하세요",
            "2025-08-24 13:55:01 - 20070302 03 - 오늘은 문을 조심하세요"});
            this.lbHistory.Location = new System.Drawing.Point(13, 85);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(352, 340);
            this.lbHistory.TabIndex = 0;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(348, 51);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "내역 다시 불러오기";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbHistory);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnRefresh;
    }
}