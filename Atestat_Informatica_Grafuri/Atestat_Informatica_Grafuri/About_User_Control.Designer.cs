
namespace Atestat_Informatica_Grafuri
{
    partial class About_User_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_User_Control));
            this.labelAuthorAbout = new System.Windows.Forms.Label();
            this.pictureBoxGifLeft = new System.Windows.Forms.PictureBox();
            this.panelBottomAbout = new System.Windows.Forms.Panel();
            this.pictureBoxGifRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifLeft)).BeginInit();
            this.panelBottomAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifRight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthorAbout
            // 
            this.labelAuthorAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthorAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorAbout.ForeColor = System.Drawing.Color.Teal;
            this.labelAuthorAbout.Location = new System.Drawing.Point(0, 0);
            this.labelAuthorAbout.Name = "labelAuthorAbout";
            this.labelAuthorAbout.Size = new System.Drawing.Size(750, 435);
            this.labelAuthorAbout.TabIndex = 0;
            this.labelAuthorAbout.Text = "Filipoiu Patrick - Lari\r\nColegiul National \"Liviu Rebreanu\" Bistrita\r\nClasa a XII" +
    "-a A\r\nProfesor coordonator: Ciprian Muresan\r\n\r\n\r\n\r\n\r\n";
            this.labelAuthorAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGifLeft
            // 
            this.pictureBoxGifLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGifLeft.Image")));
            this.pictureBoxGifLeft.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxGifLeft.Name = "pictureBoxGifLeft";
            this.pictureBoxGifLeft.Size = new System.Drawing.Size(170, 187);
            this.pictureBoxGifLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGifLeft.TabIndex = 1;
            this.pictureBoxGifLeft.TabStop = false;
            // 
            // panelBottomAbout
            // 
            this.panelBottomAbout.Controls.Add(this.pictureBoxGifRight);
            this.panelBottomAbout.Controls.Add(this.pictureBoxGifLeft);
            this.panelBottomAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomAbout.Location = new System.Drawing.Point(0, 242);
            this.panelBottomAbout.Name = "panelBottomAbout";
            this.panelBottomAbout.Size = new System.Drawing.Size(750, 193);
            this.panelBottomAbout.TabIndex = 2;
            // 
            // pictureBoxGifRight
            // 
            this.pictureBoxGifRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGifRight.Image")));
            this.pictureBoxGifRight.Location = new System.Drawing.Point(603, 3);
            this.pictureBoxGifRight.Name = "pictureBoxGifRight";
            this.pictureBoxGifRight.Size = new System.Drawing.Size(144, 190);
            this.pictureBoxGifRight.TabIndex = 2;
            this.pictureBoxGifRight.TabStop = false;
            // 
            // About_User_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelBottomAbout);
            this.Controls.Add(this.labelAuthorAbout);
            this.Name = "About_User_Control";
            this.Size = new System.Drawing.Size(750, 435);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifLeft)).EndInit();
            this.panelBottomAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorAbout;
        private System.Windows.Forms.PictureBox pictureBoxGifLeft;
        private System.Windows.Forms.Panel panelBottomAbout;
        private System.Windows.Forms.PictureBox pictureBoxGifRight;
    }
}
