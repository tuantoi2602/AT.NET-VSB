
namespace Painter
{
	partial class frmMain
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
            this.container = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loadDllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDLLFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openXMLFile = new System.Windows.Forms.OpenFileDialog();
            this.saveAsJPG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(12, 83);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(858, 425);
            this.container.TabIndex = 0;
            this.container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.container_MouseDown);
            this.container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.container_MouseUp);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Red;
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Location = new System.Drawing.Point(760, 37);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(110, 32);
            this.btnColor.TabIndex = 100;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(663, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 32);
            this.btnClear.TabIndex = 99;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // flowLayout
            // 
            this.flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout.Location = new System.Drawing.Point(12, 37);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(645, 40);
            this.flowLayout.TabIndex = 101;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDllToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(882, 30);
            this.menuStrip.TabIndex = 102;
            this.menuStrip.Text = "menuStrip1";
            // 
            // loadDllToolStripMenuItem
            // 
            this.loadDllToolStripMenuItem.Name = "loadDllToolStripMenuItem";
            this.loadDllToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.loadDllToolStripMenuItem.Text = "Load dll";
            this.loadDllToolStripMenuItem.Click += new System.EventHandler(this.loadDllToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsxmlToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveAsJPG});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // saveAsxmlToolStripMenuItem
            // 
            this.saveAsxmlToolStripMenuItem.Name = "saveAsxmlToolStripMenuItem";
            this.saveAsxmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsxmlToolStripMenuItem.Text = "Save as *.xml";
            this.saveAsxmlToolStripMenuItem.Click += new System.EventHandler(this.saveAsxmlToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadDLLFile
            // 
            this.loadDLLFile.Filter = "DLL Files|*.dll;";
            this.loadDLLFile.FileOk += new System.ComponentModel.CancelEventHandler(this.loadDLLFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "xml";
            this.saveFile.Filter = "XML Files|*.xml;";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // openXMLFile
            // 
            this.openXMLFile.DefaultExt = "xml";
            this.openXMLFile.Filter = "XML Files|*.xml;";
            this.openXMLFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openXMLFile_FileOk);
            // 
            // saveAsJPG
            // 
            this.saveAsJPG.Name = "saveAsJPG";
            this.saveAsJPG.Size = new System.Drawing.Size(224, 26);
            this.saveAsJPG.Text = "Save as *.jpg";
            this.saveAsJPG.Click += new System.EventHandler(this.saveAsJPG_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.container);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painter";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel container;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.FlowLayoutPanel flowLayout;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem loadDllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog loadDLLFile;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsxmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.OpenFileDialog openXMLFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsJPG;
    }
}

