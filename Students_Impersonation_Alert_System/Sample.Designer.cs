namespace Students_Impersonation_Alert_System
{
    partial class Sample
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
            this.leftPanelMain = new System.Windows.Forms.Panel();
            this.leftPanelCentre = new System.Windows.Forms.Panel();
            this.leftPanelTop = new System.Windows.Forms.Panel();
            this.rightPanelMain = new System.Windows.Forms.Panel();
            this.rightPanelCentre = new System.Windows.Forms.Panel();
            this.rightPanelTop = new System.Windows.Forms.Panel();
            this.leftPanelMain.SuspendLayout();
            this.rightPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanelMain
            // 
            this.leftPanelMain.BackColor = System.Drawing.Color.Firebrick;
            this.leftPanelMain.Controls.Add(this.leftPanelCentre);
            this.leftPanelMain.Controls.Add(this.leftPanelTop);
            this.leftPanelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelMain.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanelMain.ForeColor = System.Drawing.Color.White;
            this.leftPanelMain.Location = new System.Drawing.Point(0, 0);
            this.leftPanelMain.Name = "leftPanelMain";
            this.leftPanelMain.Size = new System.Drawing.Size(200, 555);
            this.leftPanelMain.TabIndex = 0;
            // 
            // leftPanelCentre
            // 
            this.leftPanelCentre.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelCentre.Location = new System.Drawing.Point(0, 54);
            this.leftPanelCentre.Name = "leftPanelCentre";
            this.leftPanelCentre.Size = new System.Drawing.Size(200, 501);
            this.leftPanelCentre.TabIndex = 1;
            // 
            // leftPanelTop
            // 
            this.leftPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelTop.Location = new System.Drawing.Point(0, 0);
            this.leftPanelTop.Name = "leftPanelTop";
            this.leftPanelTop.Size = new System.Drawing.Size(200, 54);
            this.leftPanelTop.TabIndex = 0;
            // 
            // rightPanelMain
            // 
            this.rightPanelMain.Controls.Add(this.rightPanelCentre);
            this.rightPanelMain.Controls.Add(this.rightPanelTop);
            this.rightPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelMain.Location = new System.Drawing.Point(200, 0);
            this.rightPanelMain.Name = "rightPanelMain";
            this.rightPanelMain.Size = new System.Drawing.Size(870, 555);
            this.rightPanelMain.TabIndex = 1;
            // 
            // rightPanelCentre
            // 
            this.rightPanelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelCentre.Location = new System.Drawing.Point(0, 54);
            this.rightPanelCentre.Name = "rightPanelCentre";
            this.rightPanelCentre.Size = new System.Drawing.Size(870, 501);
            this.rightPanelCentre.TabIndex = 2;
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanelTop.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTop.Name = "rightPanelTop";
            this.rightPanelTop.Size = new System.Drawing.Size(870, 54);
            this.rightPanelTop.TabIndex = 1;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.rightPanelMain);
            this.Controls.Add(this.leftPanelMain);
            this.Name = "Sample";
            this.leftPanelMain.ResumeLayout(false);
            this.rightPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftPanelMain;
        public System.Windows.Forms.Panel leftPanelTop;
        public System.Windows.Forms.Panel rightPanelTop;
        public System.Windows.Forms.Panel leftPanelCentre;
        public System.Windows.Forms.Panel rightPanelMain;
        public System.Windows.Forms.Panel rightPanelCentre;
    }
}

