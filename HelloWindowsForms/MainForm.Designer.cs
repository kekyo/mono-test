namespace HelloWindowsForms
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
            this.components = new System.ComponentModel.Container();
            this.fetchButton = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // fetchButton
            // 
            this.fetchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fetchButton.Location = new System.Drawing.Point(0, 0);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(800, 23);
            this.fetchButton.TabIndex = 0;
            this.fetchButton.Text = "Fetch";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // itemsList
            // 
            this.itemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsList.HideSelection = false;
            this.itemsList.LargeImageList = this.imageList;
            this.itemsList.Location = new System.Drawing.Point(0, 23);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(800, 427);
            this.itemsList.TabIndex = 1;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.fetchButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.ImageList imageList;
    }
}

