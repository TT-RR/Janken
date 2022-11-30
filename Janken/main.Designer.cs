
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
            this.playerHandBox = new System.Windows.Forms.PictureBox();
            this.enemyHandBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.logolabel = new System.Windows.Forms.Label();
            this.paperHand = new System.Windows.Forms.PictureBox();
            this.scissorsHand = new System.Windows.Forms.PictureBox();
            this.rookHand = new System.Windows.Forms.PictureBox();
            this.winLoss1PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss5PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss4PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss3PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss2PictureBox = new System.Windows.Forms.PictureBox();
            this.enemyBar = new System.Windows.Forms.ProgressBar();
            this.playerBar = new System.Windows.Forms.ProgressBar();
            this.gameAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAreaPanel
            // 
            this.gameAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameAreaPanel.Controls.Add(this.enemyBar);
            this.gameAreaPanel.Controls.Add(this.playerBar);
            this.gameAreaPanel.Controls.Add(this.playerHandBox);
            this.gameAreaPanel.Controls.Add(this.enemyHandBox);
            this.gameAreaPanel.Controls.Add(this.enemyPictureBox);
            this.gameAreaPanel.Location = new System.Drawing.Point(3, 30);
            this.gameAreaPanel.Name = "gameAreaPanel";
            this.gameAreaPanel.Size = new System.Drawing.Size(280, 410);
            this.gameAreaPanel.TabIndex = 0;
            // 
            // playerHandBox
            // 
            this.playerHandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHandBox.Location = new System.Drawing.Point(92, 290);
            this.playerHandBox.Name = "playerHandBox";
            this.playerHandBox.Size = new System.Drawing.Size(100, 100);
            this.playerHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHandBox.TabIndex = 2;
            this.playerHandBox.TabStop = false;
            // 
            // enemyHandBox
            // 
            this.enemyHandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHandBox.Location = new System.Drawing.Point(92, 184);
            this.enemyHandBox.Name = "enemyHandBox";
            this.enemyHandBox.Size = new System.Drawing.Size(100, 100);
            this.enemyHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyHandBox.TabIndex = 1;
            this.enemyHandBox.TabStop = false;
            this.enemyHandBox.Click += new System.EventHandler(this.enemyHandBox_Click);
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
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(290, 156);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 40);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "スタート！";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
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
            this.paperHand.Click += new System.EventHandler(this.paperHand_Click_1);
            // 
            // scissorsHand
            // 
            this.scissorsHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scissorsHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorsHand.Image = global::Janken.Properties.Resources.scissors;
            this.scissorsHand.Location = new System.Drawing.Point(103, 446);
            this.scissorsHand.Name = "scissorsHand";
            this.scissorsHand.Size = new System.Drawing.Size(80, 80);
            this.scissorsHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsHand.TabIndex = 1;
            this.scissorsHand.TabStop = false;
            this.scissorsHand.Click += new System.EventHandler(this.scissorsHand_Click_1);
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
            // winLoss1PictureBox
            // 
            this.winLoss1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss1PictureBox.Location = new System.Drawing.Point(390, 216);
            this.winLoss1PictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.winLoss1PictureBox.Name = "winLoss1PictureBox";
            this.winLoss1PictureBox.Size = new System.Drawing.Size(52, 46);
            this.winLoss1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss1PictureBox.TabIndex = 4;
            this.winLoss1PictureBox.TabStop = false;
            // 
            // winLoss5PictureBox
            // 
            this.winLoss5PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss5PictureBox.Location = new System.Drawing.Point(390, 450);
            this.winLoss5PictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.winLoss5PictureBox.Name = "winLoss5PictureBox";
            this.winLoss5PictureBox.Size = new System.Drawing.Size(52, 46);
            this.winLoss5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss5PictureBox.TabIndex = 6;
            this.winLoss5PictureBox.TabStop = false;
            // 
            // winLoss4PictureBox
            // 
            this.winLoss4PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss4PictureBox.Location = new System.Drawing.Point(390, 394);
            this.winLoss4PictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.winLoss4PictureBox.Name = "winLoss4PictureBox";
            this.winLoss4PictureBox.Size = new System.Drawing.Size(52, 46);
            this.winLoss4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss4PictureBox.TabIndex = 7;
            this.winLoss4PictureBox.TabStop = false;
            // 
            // winLoss3PictureBox
            // 
            this.winLoss3PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss3PictureBox.Location = new System.Drawing.Point(390, 334);
            this.winLoss3PictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.winLoss3PictureBox.Name = "winLoss3PictureBox";
            this.winLoss3PictureBox.Size = new System.Drawing.Size(52, 46);
            this.winLoss3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss3PictureBox.TabIndex = 8;
            this.winLoss3PictureBox.TabStop = false;
            // 
            // winLoss2PictureBox
            // 
            this.winLoss2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss2PictureBox.Location = new System.Drawing.Point(390, 279);
            this.winLoss2PictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.winLoss2PictureBox.Name = "winLoss2PictureBox";
            this.winLoss2PictureBox.Size = new System.Drawing.Size(52, 46);
            this.winLoss2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss2PictureBox.TabIndex = 9;
            this.winLoss2PictureBox.TabStop = false;
            // 
            // enemyBar
            // 
            this.enemyBar.Location = new System.Drawing.Point(5, 3);
            this.enemyBar.Name = "enemyBar";
            this.enemyBar.Size = new System.Drawing.Size(270, 10);
            this.enemyBar.TabIndex = 10;
            // 
            // playerBar
            // 
            this.playerBar.Location = new System.Drawing.Point(5, 395);
            this.playerBar.Name = "playerBar";
            this.playerBar.Size = new System.Drawing.Size(270, 10);
            this.playerBar.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 532);
            this.Controls.Add(this.winLoss2PictureBox);
            this.Controls.Add(this.winLoss3PictureBox);
            this.Controls.Add(this.winLoss4PictureBox);
            this.Controls.Add(this.winLoss5PictureBox);
            this.Controls.Add(this.winLoss1PictureBox);
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
            this.Load += new System.EventHandler(this.main_Load);
            this.gameAreaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss2PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameAreaPanel;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.PictureBox playerHandBox;
        private System.Windows.Forms.PictureBox enemyHandBox;
        private System.Windows.Forms.PictureBox rookHand;
        private System.Windows.Forms.PictureBox scissorsHand;
        private System.Windows.Forms.PictureBox paperHand;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.PictureBox winLoss1PictureBox;
        private System.Windows.Forms.PictureBox winLoss5PictureBox;
        private System.Windows.Forms.PictureBox winLoss4PictureBox;
        private System.Windows.Forms.PictureBox winLoss3PictureBox;
        private System.Windows.Forms.PictureBox winLoss2PictureBox;
        private System.Windows.Forms.ProgressBar enemyBar;
        private System.Windows.Forms.ProgressBar playerBar;
    }
}

