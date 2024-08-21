namespace httmlGUI
{
    partial class formFirst10Post
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
            this.labelFirst10Post = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirst10Post
            // 
            this.labelFirst10Post.AutoSize = true;
            this.labelFirst10Post.Location = new System.Drawing.Point(21, 9);
            this.labelFirst10Post.Name = "labelFirst10Post";
            this.labelFirst10Post.Size = new System.Drawing.Size(19, 16);
            this.labelFirst10Post.TabIndex = 0;
            this.labelFirst10Post.Text = "    ";
            this.labelFirst10Post.Click += new System.EventHandler(this.labelFirst10Post_Click);
            // 
            // formFirst10Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFirst10Post);
            this.Name = "formFirst10Post";
            this.Text = "formFirst10Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFirst10Post;
    }
}