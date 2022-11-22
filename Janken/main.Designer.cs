
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
            this.gameAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAreaPanel
            // 
            this.gameAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameAreaPanel.Controls.Add(this.playerHandBox);
            this.gameAreaPanel.Controls.Add(this.enemyHandBox);
            this.gameAreaPanel.Controls.Add(this.enemyPictureBox);
            this.gameAreaPanel.Location = new System.Drawing.Point(2, 20);
            this.gameAreaPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameAreaPanel.Name = "gameAreaPanel";
            this.gameAreaPanel.Size = new System.Drawing.Size(169, 274);
            this.gameAreaPanel.TabIndex = 0;
            // 
            // playerHandBox
            // 
            this.playerHandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHandBox.Location = new System.Drawing.Point(55, 193);
            this.playerHandBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerHandBox.Name = "playerHandBox";
            this.playerHandBox.Size = new System.Drawing.Size(61, 67);
            this.playerHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHandBox.TabIndex = 2;
            this.playerHandBox.TabStop = false;
            // 
            // enemyHandBox
            // 
            this.enemyHandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHandBox.Location = new System.Drawing.Point(55, 123);
            this.enemyHandBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemyHandBox.Name = "enemyHandBox";
            this.enemyHandBox.Size = new System.Drawing.Size(61, 67);
            this.enemyHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyHandBox.TabIndex = 1;
            this.enemyHandBox.TabStop = false;
            this.enemyHandBox.Click += new System.EventHandler(this.enemyHandBox_Click);
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.LightCoral;
            this.enemyPictureBox.Image = global::Janken.Properties.Resources.enemy;
            this.enemyPictureBox.Location = new System.Drawing.Point(25, 12);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(120, 107);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 0;
            this.enemyPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(174, 104);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(156, 27);
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
            this.logolabel.Location = new System.Drawing.Point(174, 20);
            this.logolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(157, 82);
            this.logolabel.TabIndex = 3;
            this.logolabel.Text = "じゃんけん\r\nバトル";
            this.logolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paperHand
            // 
            this.paperHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperHand.Image = global::Janken.Properties.Resources.paper;
            this.paperHand.Location = new System.Drawing.Point(114, 296);
            this.paperHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paperHand.Name = "paperHand";
            this.paperHand.Size = new System.Drawing.Size(49, 54);
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
            this.scissorsHand.Location = new System.Drawing.Point(62, 297);
            this.scissorsHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scissorsHand.Name = "scissorsHand";
            this.scissorsHand.Size = new System.Drawing.Size(49, 54);
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
            this.rookHand.Location = new System.Drawing.Point(11, 296);
            this.rookHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rookHand.Name = "rookHand";
            this.rookHand.Size = new System.Drawing.Size(49, 54);
            this.rookHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rookHand.TabIndex = 1;
            this.rookHand.TabStop = false;
            this.rookHand.Click += new System.EventHandler(this.rookHand_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 355);
            this.Controls.Add(this.logolabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.paperHand);
            this.Controls.Add(this.scissorsHand);
            this.Controls.Add(this.rookHand);
            this.Controls.Add(this.gameAreaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "じゃんけんバトル";
            this.gameAreaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookHand)).EndInit();
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
    }
}

