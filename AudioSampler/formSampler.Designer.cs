using AudioSampler;

namespace AudioSampler
{
    partial class FormSampler
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSampler));
         this.panelPads = new System.Windows.Forms.Panel();
         this.padContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.loadSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editEffectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.assignKeyTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.txtBoxDebug = new System.Windows.Forms.TextBox();
         this.lblDebug = new System.Windows.Forms.Label();
         this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
         this.effect4Panel = new System.Windows.Forms.Panel();
         this.fx4OnCheckBox = new System.Windows.Forms.CheckBox();
         this.effect3Panel = new System.Windows.Forms.Panel();
         this.fx3OnCheckBox = new System.Windows.Forms.CheckBox();
         this.effect2Panel = new System.Windows.Forms.Panel();
         this.fx2OnCheckBox = new System.Windows.Forms.CheckBox();
         this.effect1Panel = new System.Windows.Forms.Panel();
         this.fx1OnCheckBox = new System.Windows.Forms.CheckBox();
         this.label1 = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pad3 = new AudioSampler.Pad();
         this.padContextMenuStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
         this.effect4Panel.SuspendLayout();
         this.effect3Panel.SuspendLayout();
         this.effect2Panel.SuspendLayout();
         this.effect1Panel.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pad3)).BeginInit();
         this.SuspendLayout();
         // 
         // panelPads
         // 
         this.panelPads.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.panelPads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panelPads.Location = new System.Drawing.Point(17, 21);
         this.panelPads.Name = "panelPads";
         this.panelPads.Size = new System.Drawing.Size(385, 378);
         this.panelPads.TabIndex = 1;
         // 
         // padContextMenuStrip
         // 
         this.padContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSampleToolStripMenuItem,
            this.editEffectsToolStripMenuItem,
            this.assignKeyTriggerToolStripMenuItem});
         this.padContextMenuStrip.Name = "padContextMenuStrip";
         this.padContextMenuStrip.Size = new System.Drawing.Size(170, 70);
         // 
         // loadSampleToolStripMenuItem
         // 
         this.loadSampleToolStripMenuItem.Name = "loadSampleToolStripMenuItem";
         this.loadSampleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
         this.loadSampleToolStripMenuItem.Text = "Load Sample";
         this.loadSampleToolStripMenuItem.Click += new System.EventHandler(this.loadSampleToolStripMenuItem_Click);
         // 
         // editEffectsToolStripMenuItem
         // 
         this.editEffectsToolStripMenuItem.Name = "editEffectsToolStripMenuItem";
         this.editEffectsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
         this.editEffectsToolStripMenuItem.Text = "Edit Effects";
         // 
         // assignKeyTriggerToolStripMenuItem
         // 
         this.assignKeyTriggerToolStripMenuItem.Name = "assignKeyTriggerToolStripMenuItem";
         this.assignKeyTriggerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
         this.assignKeyTriggerToolStripMenuItem.Text = "Assign KeyTrigger";
         // 
         // splitContainer1
         // 
         this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
         this.splitContainer1.IsSplitterFixed = true;
         this.splitContainer1.Location = new System.Drawing.Point(0, 22);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.BackgroundImage = global::AudioSampler.Properties.Resources.DisplayBackgroundCollapsed;
         this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.splitContainer1.Panel1.Controls.Add(this.txtBoxDebug);
         this.splitContainer1.Panel1.Controls.Add(this.lblDebug);
         this.splitContainer1.Panel1.Controls.Add(this.pictureBoxExpand);
         this.splitContainer1.Panel1.Controls.Add(this.panelPads);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.splitContainer1.Panel2.Controls.Add(this.effect4Panel);
         this.splitContainer1.Panel2.Controls.Add(this.effect3Panel);
         this.splitContainer1.Panel2.Controls.Add(this.effect2Panel);
         this.splitContainer1.Panel2.Controls.Add(this.effect1Panel);
         this.splitContainer1.Panel2.Controls.Add(this.label1);
         this.splitContainer1.Size = new System.Drawing.Size(752, 727);
         this.splitContainer1.SplitterDistance = 453;
         this.splitContainer1.SplitterWidth = 1;
         this.splitContainer1.TabIndex = 2;
         // 
         // txtBoxDebug
         // 
         this.txtBoxDebug.Enabled = false;
         this.txtBoxDebug.Location = new System.Drawing.Point(459, 351);
         this.txtBoxDebug.Multiline = true;
         this.txtBoxDebug.Name = "txtBoxDebug";
         this.txtBoxDebug.Size = new System.Drawing.Size(262, 58);
         this.txtBoxDebug.TabIndex = 4;
         // 
         // lblDebug
         // 
         this.lblDebug.AutoSize = true;
         this.lblDebug.Location = new System.Drawing.Point(456, 335);
         this.lblDebug.Name = "lblDebug";
         this.lblDebug.Size = new System.Drawing.Size(62, 13);
         this.lblDebug.TabIndex = 3;
         this.lblDebug.Text = "Debugging:";
         // 
         // pictureBoxExpand
         // 
         this.pictureBoxExpand.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Default;
         this.pictureBoxExpand.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExpand.Image")));
         this.pictureBoxExpand.Location = new System.Drawing.Point(0, 430);
         this.pictureBoxExpand.Name = "pictureBoxExpand";
         this.pictureBoxExpand.Size = new System.Drawing.Size(749, 20);
         this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pictureBoxExpand.TabIndex = 2;
         this.pictureBoxExpand.TabStop = false;
         this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // effect4Panel
         // 
         this.effect4Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect4Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
         this.effect4Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.effect4Panel.Controls.Add(this.fx4OnCheckBox);
         this.effect4Panel.Location = new System.Drawing.Point(563, 3);
         this.effect4Panel.Name = "effect4Panel";
         this.effect4Panel.Size = new System.Drawing.Size(180, 259);
         this.effect4Panel.TabIndex = 1;
         // 
         // fx4OnCheckBox
         // 
         this.fx4OnCheckBox.AutoSize = true;
         this.fx4OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.fx4OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.fx4OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fx4OnCheckBox.Location = new System.Drawing.Point(103, 12);
         this.fx4OnCheckBox.Name = "fx4OnCheckBox";
         this.fx4OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx4OnCheckBox.TabIndex = 0;
         this.fx4OnCheckBox.Text = "Enabled";
         this.fx4OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect3Panel
         // 
         this.effect3Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect3Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
         this.effect3Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.effect3Panel.Controls.Add(this.fx3OnCheckBox);
         this.effect3Panel.Location = new System.Drawing.Point(377, 3);
         this.effect3Panel.Name = "effect3Panel";
         this.effect3Panel.Size = new System.Drawing.Size(180, 259);
         this.effect3Panel.TabIndex = 1;
         // 
         // fx3OnCheckBox
         // 
         this.fx3OnCheckBox.AutoSize = true;
         this.fx3OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.fx3OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.fx3OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fx3OnCheckBox.Location = new System.Drawing.Point(103, 12);
         this.fx3OnCheckBox.Name = "fx3OnCheckBox";
         this.fx3OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx3OnCheckBox.TabIndex = 0;
         this.fx3OnCheckBox.Text = "Enabled";
         this.fx3OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect2Panel
         // 
         this.effect2Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect2Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
         this.effect2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.effect2Panel.Controls.Add(this.fx2OnCheckBox);
         this.effect2Panel.Location = new System.Drawing.Point(191, 3);
         this.effect2Panel.Name = "effect2Panel";
         this.effect2Panel.Size = new System.Drawing.Size(180, 259);
         this.effect2Panel.TabIndex = 1;
         // 
         // fx2OnCheckBox
         // 
         this.fx2OnCheckBox.AutoSize = true;
         this.fx2OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.fx2OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.fx2OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fx2OnCheckBox.Location = new System.Drawing.Point(103, 12);
         this.fx2OnCheckBox.Name = "fx2OnCheckBox";
         this.fx2OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx2OnCheckBox.TabIndex = 0;
         this.fx2OnCheckBox.Text = "Enabled";
         this.fx2OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect1Panel
         // 
         this.effect1Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect1Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
         this.effect1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.effect1Panel.Controls.Add(this.fx1OnCheckBox);
         this.effect1Panel.Location = new System.Drawing.Point(5, 3);
         this.effect1Panel.Name = "effect1Panel";
         this.effect1Panel.Size = new System.Drawing.Size(180, 259);
         this.effect1Panel.TabIndex = 1;
         // 
         // fx1OnCheckBox
         // 
         this.fx1OnCheckBox.AutoSize = true;
         this.fx1OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.fx1OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.fx1OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fx1OnCheckBox.Location = new System.Drawing.Point(103, 12);
         this.fx1OnCheckBox.Name = "fx1OnCheckBox";
         this.fx1OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx1OnCheckBox.TabIndex = 0;
         this.fx1OnCheckBox.Text = "Enabled";
         this.fx1OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(71, 63);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "label1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(747, 24);
         this.menuStrip1.TabIndex = 3;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem1
         // 
         this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem1});
         this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
         this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem1.Text = "File";
         // 
         // loadToolStripMenuItem1
         // 
         this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
         this.loadToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
         this.loadToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
         this.loadToolStripMenuItem1.Text = "&Load";
         // 
         // saveToolStripMenuItem1
         // 
         this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
         this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
         this.saveToolStripMenuItem1.Text = "&Save";
         // 
         // exitToolStripMenuItem1
         // 
         this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
         this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
         this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
         this.exitToolStripMenuItem1.Text = "&Exit";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.loadToolStripMenuItem.Text = "&Load";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.saveToolStripMenuItem.Text = "&Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // pad3
         // 
         this.pad3.chorusDelay = 0D;
         this.pad3.chorusDepth = 0D;
         this.pad3.chorusLevel = 0D;
         this.pad3.driveSetting = 0D;
         this.pad3.echoCount = 0;
         this.pad3.echoDelay = 0;
         this.pad3.echoFactor = 0F;
         this.pad3.frequency = 0D;
         this.pad3.isChorusing = false;
         this.pad3.isEchoing = false;
         this.pad3.isLoaded = true;
         this.pad3.isLowPass = false;
         this.pad3.isOverdriving = false;
         this.pad3.isPassing = false;
         this.pad3.keyShortCut = System.Windows.Forms.Keys.None;
         this.pad3.Location = new System.Drawing.Point(0, 0);
         this.pad3.Name = "pad3";
         this.pad3.SamplePath = "";
         this.pad3.Size = new System.Drawing.Size(100, 50);
         this.pad3.TabIndex = 0;
         this.pad3.TabStop = false;
         // 
         // FormSampler
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.ClientSize = new System.Drawing.Size(747, 746);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(763, 784);
         this.MinimumSize = new System.Drawing.Size(763, 510);
         this.Name = "FormSampler";
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "Instigator Sampler and Effects Processor";
         this.padContextMenuStrip.ResumeLayout(false);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
         this.effect4Panel.ResumeLayout(false);
         this.effect4Panel.PerformLayout();
         this.effect3Panel.ResumeLayout(false);
         this.effect3Panel.PerformLayout();
         this.effect2Panel.ResumeLayout(false);
         this.effect2Panel.PerformLayout();
         this.effect1Panel.ResumeLayout(false);
         this.effect1Panel.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pad3)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private Pad pad1;
        private Pad pad2;
        private Pad pad3;
        private Pad pad4;
        private Pad pad5;
        private Pad pad6;
        private Pad pad7;
        private Pad pad8;
        private Pad pad9;
        private System.Windows.Forms.Panel panelPads;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.TextBox txtBoxDebug;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel effect4Panel;
        private System.Windows.Forms.Panel effect3Panel;
        private System.Windows.Forms.Panel effect2Panel;
        private System.Windows.Forms.Panel effect1Panel;
        private System.Windows.Forms.CheckBox fx4OnCheckBox;
        private System.Windows.Forms.CheckBox fx3OnCheckBox;
        private System.Windows.Forms.CheckBox fx2OnCheckBox;
        private System.Windows.Forms.CheckBox fx1OnCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip padContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEffectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignKeyTriggerToolStripMenuItem;
    }
}

