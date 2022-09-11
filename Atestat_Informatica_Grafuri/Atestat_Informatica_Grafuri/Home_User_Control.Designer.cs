
namespace Atestat_Informatica_Grafuri
{
    partial class Home_User_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_User_Control));
            this.pictureBoxGifRight = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelBottomHome = new System.Windows.Forms.Panel();
            this.panelCenterHome = new System.Windows.Forms.Panel();
            this.pictureBoxGiftLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifRight)).BeginInit();
            this.panelBottomHome.SuspendLayout();
            this.panelCenterHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiftLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGifRight
            // 
            this.pictureBoxGifRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGifRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGifRight.Image")));
            this.pictureBoxGifRight.Location = new System.Drawing.Point(379, 3);
            this.pictureBoxGifRight.Name = "pictureBoxGifRight";
            this.pictureBoxGifRight.Size = new System.Drawing.Size(368, 278);
            this.pictureBoxGifRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGifRight.TabIndex = 0;
            this.pictureBoxGifRight.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(0, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(750, 148);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "\r\nÎn cadrul acestei aplicații vei înțelege ce sunt grafurile și modul lor de impl" +
    "ementare, iar la final vei putea să îți testezi cunoștințele\r\n\r\nHai să începem s" +
    "ă învățăm😀\r\n\r\n\r\n";
            this.labelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottomHome
            // 
            this.panelBottomHome.Controls.Add(this.labelHome);
            this.panelBottomHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomHome.Location = new System.Drawing.Point(0, 287);
            this.panelBottomHome.Name = "panelBottomHome";
            this.panelBottomHome.Size = new System.Drawing.Size(750, 148);
            this.panelBottomHome.TabIndex = 2;
            // 
            // panelCenterHome
            // 
            this.panelCenterHome.Controls.Add(this.pictureBoxGiftLeft);
            this.panelCenterHome.Controls.Add(this.pictureBoxGifRight);
            this.panelCenterHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterHome.Location = new System.Drawing.Point(0, 0);
            this.panelCenterHome.Name = "panelCenterHome";
            this.panelCenterHome.Size = new System.Drawing.Size(750, 287);
            this.panelCenterHome.TabIndex = 3;
            // 
            // pictureBoxGiftLeft
            // 
            this.pictureBoxGiftLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGiftLeft.Image")));
            this.pictureBoxGiftLeft.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxGiftLeft.Name = "pictureBoxGiftLeft";
            this.pictureBoxGiftLeft.Size = new System.Drawing.Size(369, 278);
            this.pictureBoxGiftLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGiftLeft.TabIndex = 1;
            this.pictureBoxGiftLeft.TabStop = false;
            // 
            // Home_User_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelCenterHome);
            this.Controls.Add(this.panelBottomHome);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home_User_Control";
            this.Size = new System.Drawing.Size(750, 435);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifRight)).EndInit();
            this.panelBottomHome.ResumeLayout(false);
            this.panelCenterHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiftLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGifRight;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelBottomHome;
        private System.Windows.Forms.Panel panelCenterHome;
        private System.Windows.Forms.PictureBox pictureBoxGiftLeft;
    }
}
