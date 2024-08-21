namespace httmlGUI
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
            this.btn10posts = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.btn10albums = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn10posts
            // 
            this.btn10posts.Location = new System.Drawing.Point(257, 116);
            this.btn10posts.Name = "btn10posts";
            this.btn10posts.Size = new System.Drawing.Size(227, 23);
            this.btn10posts.TabIndex = 0;
            this.btn10posts.Text = "Display first 10 posts";
            this.btn10posts.UseVisualStyleBackColor = true;
            this.btn10posts.Click += new System.EventHandler(this.btn10posts_Click);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(257, 172);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(227, 23);
            this.btnComments.TabIndex = 1;
            this.btnComments.Text = "Display comments of the 2nd  post";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btn10albums
            // 
            this.btn10albums.Location = new System.Drawing.Point(257, 238);
            this.btn10albums.Name = "btn10albums";
            this.btn10albums.Size = new System.Drawing.Size(227, 23);
            this.btn10albums.TabIndex = 2;
            this.btn10albums.Text = "Display first 10 albums";
            this.btn10albums.UseVisualStyleBackColor = true;
            this.btn10albums.Click += new System.EventHandler(this.btn10albums_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn10albums);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btn10posts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn10posts;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btn10albums;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

