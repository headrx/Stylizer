
namespace Style_Editor
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.citationTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.styleListBox = new System.Windows.Forms.ListBox();
            this.citationInformationPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Style_Editor.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(569, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 329);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // citationTextBox
            // 
            this.citationTextBox.Location = new System.Drawing.Point(28, 407);
            this.citationTextBox.Name = "citationTextBox";
            this.citationTextBox.Size = new System.Drawing.Size(497, 20);
            this.citationTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(531, 404);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // styleListBox
            // 
            this.styleListBox.FormattingEnabled = true;
            this.styleListBox.Items.AddRange(new object[] {
            "APA Style - Book",
            "APA Style - Chapter in Book",
            "APA Style - Print Journal",
            "APA Style - Electronic Journal ",
            "APA Style - Website",
            "MLA Style - Book",
            "MLA Style - eBook",
            "MLA Style - Print Journal",
            "MLA Style - Electronic Journal ",
            "MLA Style - Enclyopedia Entry",
            "MLA Style - Government Publication",
            "MLA Style - Interview",
            "MLA Style - Film / Dvd",
            "MLA Style - Page on website with no author",
            "MLA Style - Page on website with an author",
            "MLA Style - Artwork from website",
            "Chicago Style - Book in print",
            "Chicago Style - Article in a print Journal",
            "Chicago Style - An article in an electronic Journal ",
            "Chicago Style - A Website"});
            this.styleListBox.Location = new System.Drawing.Point(28, 88);
            this.styleListBox.Name = "styleListBox";
            this.styleListBox.Size = new System.Drawing.Size(265, 277);
            this.styleListBox.TabIndex = 0;
            this.styleListBox.SelectedIndexChanged += new System.EventHandler(this.styleListBox_SelectedIndexChanged);
            // 
            // citationInformationPanel
            // 
            this.citationInformationPanel.Location = new System.Drawing.Point(314, 93);
            this.citationInformationPanel.Name = "citationInformationPanel";
            this.citationInformationPanel.Size = new System.Drawing.Size(243, 297);
            this.citationInformationPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(613, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stylizer 2021 © Joshua Belmar";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.citationInformationPanel);
            this.Controls.Add(this.styleListBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.citationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "mainForm";
            this.Text = "The Stylizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox citationTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox styleListBox;
        private System.Windows.Forms.Panel citationInformationPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
    }
}

