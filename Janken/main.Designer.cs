
namespace Janken
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gameAreaPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.logolabel = new System.Windows.Forms.Label();
            this.paperHand = new System.Windows.Forms.PictureBox();
            this.scissorsHand = new System.Windows.Forms.PictureBox();
            this.rookHand = new System.Windows.Forms.PictureBox();
            this.prayerHand = new System.Windows.Forms.PictureBox();
            this.enemyHand = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.gameAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prayerHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAreaPanel
            // 
            this.gameAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameAreaPanel.Controls.Add(this.prayerHand);
            this.gameAreaPanel.Controls.Add(this.enemyHand);
            this.gameAreaPanel.Controls.Add(this.enemyPictureBox);
            this.gameAreaPanel.Location = new System.Drawing.Point(4, 30);
            this.gameAreaPanel.Name = "gameAreaPanel";
            this.gameAreaPanel.Size = new System.Drawing.Size(280, 410);
            this.gameAreaPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(290, 156);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 40);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "スタート！";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // logolabel
            // 
            this.logolabel.BackColor = System.Drawing.Color.LightCyan;
            this.logolabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logolabel.Font = new System.Drawing.Font("メイリオ", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logolabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.logolabel.Location = new System.Drawing.Point(290, 30);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(260, 122);
            this.logolabel.TabIndex = 3;
            this.logolabel.Text = "じゃんけん\r\nバトル";
            this.logolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paperHand
            // 
            this.paperHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperHand.Image = global::Janken.Properties.Resources.paper;
            this.paperHand.Location = new System.Drawing.Point(190, 444);
            this.paperHand.Name = "paperHand";
            this.paperHand.Size = new System.Drawing.Size(80, 80);
            this.paperHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperHand.TabIndex = 1;
            this.paperHand.TabStop = false;
            // 
            // scissorsHand
            // 
            this.scissorsHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scissorsHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorsHand.Image = global::Janken.Properties.Resources.scissors;
            this.scissorsHand.Location = new System.Drawing.Point(104, 446);
            this.scissorsHand.Name = "scissorsHand";
            this.scissorsHand.Size = new System.Drawing.Size(80, 80);
            this.scissorsHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsHand.TabIndex = 1;
            this.scissorsHand.TabStop = false;
            // 
            // rookHand
            // 
            this.rookHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rookHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rookHand.Image = global::Janken.Properties.Resources.rock;
            this.rookHand.Location = new System.Drawing.Point(18, 444);
            this.rookHand.Name = "rookHand";
            this.rookHand.Size = new System.Drawing.Size(80, 80);
            this.rookHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rookHand.TabIndex = 1;
            this.rookHand.TabStop = false;
            this.rookHand.Click += new System.EventHandler(this.rookHand_Click);
            // 
            // prayerHand
            // 
            this.prayerHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prayerHand.Location = new System.Drawing.Point(92, 290);
            this.prayerHand.Name = "prayerHand";
            this.prayerHand.Size = new System.Drawing.Size(100, 100);
            this.prayerHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prayerHand.TabIndex = 2;
            this.prayerHand.TabStop = false;
            // 
            // enemyHand
            // 
            this.enemyHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHand.Location = new System.Drawing.Point(92, 184);
            this.enemyHand.Name = "enemyHand";
            this.enemyHand.Size = new System.Drawing.Size(100, 100);
            this.enemyHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyHand.TabIndex = 1;
            this.enemyHand.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.LightCoral;
            this.enemyPictureBox.Image = global::Janken.Properties.Resources.enemy;
            this.enemyPictureBox.Location = new System.Drawing.Point(42, 18);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(200, 160);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 0;
            this.enemyPictureBox.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 533);
            this.Controls.Add(this.logolabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.paperHand);
            this.Controls.Add(this.scissorsHand);
            this.Controls.Add(this.rookHand);
            this.Controls.Add(this.gameAreaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "じゃんけんバトル";
            this.gameAreaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prayerHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameAreaPanel;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.PictureBox prayerHand;
        private System.Windows.Forms.PictureBox enemyHand;
        private System.Windows.Forms.PictureBox rookHand;
        private System.Windows.Forms.PictureBox scissorsHand;
        private System.Windows.Forms.PictureBox paperHand;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label logolabel;
    }
}

