namespace DressMe
{
    partial class MainForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.jeansRadioButton = new System.Windows.Forms.RadioButton();
            this.tshirtsRadioButton = new System.Windows.Forms.RadioButton();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(455, 462);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.updateButton);
            this.splitContainer.Panel1.Controls.Add(this.jeansRadioButton);
            this.splitContainer.Panel1.Controls.Add(this.tshirtsRadioButton);
            this.splitContainer.Panel1.Controls.Add(this.maxPriceLabel);
            this.splitContainer.Panel1.Controls.Add(this.maxPriceTextBox);
            this.splitContainer.Panel1.Controls.Add(this.minPriceLabel);
            this.splitContainer.Panel1.Controls.Add(this.minPriceTextBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(584, 462);
            this.splitContainer.SplitterDistance = 125;
            this.splitContainer.TabIndex = 1;
            // 
            // jeansRadioButton
            // 
            this.jeansRadioButton.AutoSize = true;
            this.jeansRadioButton.ForeColor = System.Drawing.Color.White;
            this.jeansRadioButton.Location = new System.Drawing.Point(15, 87);
            this.jeansRadioButton.Name = "jeansRadioButton";
            this.jeansRadioButton.Size = new System.Drawing.Size(53, 17);
            this.jeansRadioButton.TabIndex = 5;
            this.jeansRadioButton.Text = "Jeans";
            this.jeansRadioButton.UseVisualStyleBackColor = true;
            // 
            // tshirtsRadioButton
            // 
            this.tshirtsRadioButton.AutoSize = true;
            this.tshirtsRadioButton.Checked = true;
            this.tshirtsRadioButton.ForeColor = System.Drawing.Color.White;
            this.tshirtsRadioButton.Location = new System.Drawing.Point(15, 64);
            this.tshirtsRadioButton.Name = "tshirtsRadioButton";
            this.tshirtsRadioButton.Size = new System.Drawing.Size(61, 17);
            this.tshirtsRadioButton.TabIndex = 4;
            this.tshirtsRadioButton.TabStop = true;
            this.tshirtsRadioButton.Text = "T-Shirts";
            this.tshirtsRadioButton.UseVisualStyleBackColor = true;
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.ForeColor = System.Drawing.Color.White;
            this.maxPriceLabel.Location = new System.Drawing.Point(12, 41);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.maxPriceLabel.TabIndex = 3;
            this.maxPriceLabel.Text = "Max Price:";
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPriceTextBox.Location = new System.Drawing.Point(72, 38);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(50, 20);
            this.maxPriceTextBox.TabIndex = 2;
            this.maxPriceTextBox.Text = "10";
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.ForeColor = System.Drawing.Color.White;
            this.minPriceLabel.Location = new System.Drawing.Point(12, 15);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.minPriceLabel.TabIndex = 1;
            this.minPriceLabel.Text = "Min Price:";
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minPriceTextBox.Location = new System.Drawing.Point(72, 12);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(50, 20);
            this.minPriceTextBox.TabIndex = 0;
            this.minPriceTextBox.Text = "1";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(15, 111);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(107, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dress Me";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.RadioButton jeansRadioButton;
        private System.Windows.Forms.RadioButton tshirtsRadioButton;
        private System.Windows.Forms.Button updateButton;
    }
}

