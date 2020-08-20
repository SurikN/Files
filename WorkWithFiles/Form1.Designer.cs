namespace WorkWithFiles
{
    partial class Form1
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreateFolded = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveFolded = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.richTextBoxForSearched = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 30);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create 100";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCreateFolded
            // 
            this.buttonCreateFolded.Location = new System.Drawing.Point(118, 12);
            this.buttonCreateFolded.Name = "buttonCreateFolded";
            this.buttonCreateFolded.Size = new System.Drawing.Size(100, 30);
            this.buttonCreateFolded.TabIndex = 1;
            this.buttonCreateFolded.Text = "Create Folded";
            this.buttonCreateFolded.UseVisualStyleBackColor = true;
            this.buttonCreateFolded.Click += new System.EventHandler(this.buttonCreateFolded_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 84);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 48);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 30);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove 100";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRemoveFolded
            // 
            this.buttonRemoveFolded.Location = new System.Drawing.Point(118, 48);
            this.buttonRemoveFolded.Name = "buttonRemoveFolded";
            this.buttonRemoveFolded.Size = new System.Drawing.Size(100, 30);
            this.buttonRemoveFolded.TabIndex = 4;
            this.buttonRemoveFolded.Text = "Remove Folded";
            this.buttonRemoveFolded.UseVisualStyleBackColor = true;
            this.buttonRemoveFolded.Click += new System.EventHandler(this.buttonRemoveFolded_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(118, 84);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 20);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // richTextBoxForSearched
            // 
            this.richTextBoxForSearched.Location = new System.Drawing.Point(12, 110);
            this.richTextBoxForSearched.Name = "richTextBoxForSearched";
            this.richTextBoxForSearched.Size = new System.Drawing.Size(206, 271);
            this.richTextBoxForSearched.TabIndex = 6;
            this.richTextBoxForSearched.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 393);
            this.Controls.Add(this.richTextBoxForSearched);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemoveFolded);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonCreateFolded);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreateFolded;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveFolded;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox richTextBoxForSearched;
    }
}

