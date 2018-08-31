namespace LiquidHash.Win.Forms
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LiquidHashLabel = new System.Windows.Forms.Label();
            this.bfgminerLabel = new System.Windows.Forms.Label();
            this.LiquidHashLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.revisionLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiquidHashLabel
            // 
            this.LiquidHashLabel.AutoSize = true;
            this.LiquidHashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiquidHashLabel.Location = new System.Drawing.Point(106, 14);
            this.LiquidHashLabel.Name = "LiquidHashLabel";
            this.LiquidHashLabel.Size = new System.Drawing.Size(114, 16);
            this.LiquidHashLabel.TabIndex = 1;
            this.LiquidHashLabel.Text = "LiquidHash 1.1.1";
            // 
            // bfgminerLabel
            // 
            this.bfgminerLabel.AutoSize = true;
            this.bfgminerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfgminerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bfgminerLabel.Location = new System.Drawing.Point(131, 72);
            this.bfgminerLabel.Name = "bfgminerLabel";
            this.bfgminerLabel.Size = new System.Drawing.Size(124, 15);
            this.bfgminerLabel.TabIndex = 3;
            this.bfgminerLabel.Text = "xgminer 1.1.1 installed";
            this.bfgminerLabel.Click += new System.EventHandler(this.backendMinerLabel_Click);
            // 
            // LiquidHashLink
            // 
            this.LiquidHashLink.AutoSize = true;
            this.LiquidHashLink.Location = new System.Drawing.Point(106, 32);
            this.LiquidHashLink.Name = "LiquidHashLink";
            this.LiquidHashLink.Size = new System.Drawing.Size(113, 15);
            this.LiquidHashLink.TabIndex = 5;
            this.LiquidHashLink.TabStop = true;
            this.LiquidHashLink.Text = "LiquidHashapp.com";
            this.LiquidHashLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LiquidHashLink_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 54);
            this.panel1.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(446, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 27);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.licenseTextBox.Location = new System.Drawing.Point(14, 102);
            this.licenseTextBox.Multiline = true;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.licenseTextBox.Size = new System.Drawing.Size(516, 294);
            this.licenseTextBox.TabIndex = 8;
            this.licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
            // 
            // revisionLabel
            // 
            this.revisionLabel.AutoSize = true;
            this.revisionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.revisionLabel.Location = new System.Drawing.Point(226, 14);
            this.revisionLabel.Name = "revisionLabel";
            this.revisionLabel.Size = new System.Drawing.Size(52, 15);
            this.revisionLabel.TabIndex = 9;
            this.revisionLabel.Text = "(rev 214)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LiquidHash.Win.Properties.Resources.mouse_new;
            this.pictureBox2.Location = new System.Drawing.Point(109, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 16);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.backendMinerLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiquidHash.Win.Properties.Resources.computer_coins;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(547, 465);
            this.Controls.Add(this.bfgminerLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.revisionLabel);
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LiquidHashLink);
            this.Controls.Add(this.LiquidHashLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About LiquidHash";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LiquidHashLabel;
        private System.Windows.Forms.Label bfgminerLabel;
        private System.Windows.Forms.LinkLabel LiquidHashLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Label revisionLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}