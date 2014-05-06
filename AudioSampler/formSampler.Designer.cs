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
         this.pad3 = new AudioSampler.Pad();
         this.padContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.loadSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editEffectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.assignKeyTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pad6 = new AudioSampler.Pad();
         this.pad9 = new AudioSampler.Pad();
         this.pad2 = new AudioSampler.Pad();
         this.pad5 = new AudioSampler.Pad();
         this.pad8 = new AudioSampler.Pad();
         this.pad1 = new AudioSampler.Pad();
         this.pad4 = new AudioSampler.Pad();
         this.pad7 = new AudioSampler.Pad();
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
         this.panelPads.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pad3)).BeginInit();
         this.padContextMenuStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pad6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad9)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad8)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad7)).BeginInit();
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
         this.SuspendLayout();
         // 
         // panelPads
         // 
         this.panelPads.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.panelPads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panelPads.Controls.Add(this.pad3);
         this.panelPads.Controls.Add(this.pad6);
         this.panelPads.Controls.Add(this.pad9);
         this.panelPads.Controls.Add(this.pad2);
         this.panelPads.Controls.Add(this.pad5);
         this.panelPads.Controls.Add(this.pad8);
         this.panelPads.Controls.Add(this.pad1);
         this.panelPads.Controls.Add(this.pad4);
         this.panelPads.Controls.Add(this.pad7);
         this.panelPads.Location = new System.Drawing.Point(25, 3);
         this.panelPads.MaximumSize = new System.Drawing.Size(404, 404);
         this.panelPads.MinimumSize = new System.Drawing.Size(404, 404);
         this.panelPads.Name = "panelPads";
         this.panelPads.Size = new System.Drawing.Size(404, 404);
         this.panelPads.TabIndex = 1;
         // 
         // pad3
         // 
         this.pad3.chorusDelay = 0D;
         this.pad3.chorusDepth = 0D;
         this.pad3.chorusLevel = 0D;
         this.pad3.ContextMenuStrip = this.padContextMenuStrip;
         this.pad3.driveSetting = 0D;
         this.pad3.echoCount = 0;
         this.pad3.echoDelay = 0;
         this.pad3.echoFactor = 0F;
         this.pad3.frequency = 0D;
         this.pad3.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad3.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad3.isChorusing = false;
         this.pad3.isEchoing = false;
         this.pad3.isLoaded = false;
         this.pad3.isLowPass = false;
         this.pad3.isOverdriving = false;
         this.pad3.isPassing = false;
         this.pad3.keyShortCut = '\0';
         this.pad3.Location = new System.Drawing.Point(279, 279);
         this.pad3.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad3.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad3.Name = "pad3";
         this.pad3.SamplePath = null;
         this.pad3.Size = new System.Drawing.Size(114, 114);
         this.pad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad3.TabIndex = 0;
         this.pad3.TabStop = false;
         this.pad3.Click += new System.EventHandler(this.pad_Activated);
         // 
         // padContextMenuStrip
         // 
         this.padContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSampleToolStripMenuItem,
            this.editEffectsToolStripMenuItem,
            this.assignKeyTriggerToolStripMenuItem});
         this.padContextMenuStrip.Name = "padContextMenuStrip";
         this.padContextMenuStrip.Size = new System.Drawing.Size(170, 92);
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
         // pad6
         // 
         this.pad6.chorusDelay = 0D;
         this.pad6.chorusDepth = 0D;
         this.pad6.chorusLevel = 0D;
         this.pad6.ContextMenuStrip = this.padContextMenuStrip;
         this.pad6.driveSetting = 0D;
         this.pad6.echoCount = 0;
         this.pad6.echoDelay = 0;
         this.pad6.echoFactor = 0F;
         this.pad6.frequency = 0D;
         this.pad6.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad6.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad6.isChorusing = false;
         this.pad6.isEchoing = false;
         this.pad6.isLoaded = false;
         this.pad6.isLowPass = false;
         this.pad6.isOverdriving = false;
         this.pad6.isPassing = false;
         this.pad6.keyShortCut = '\0';
         this.pad6.Location = new System.Drawing.Point(279, 144);
         this.pad6.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad6.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad6.Name = "pad6";
         this.pad6.SamplePath = null;
         this.pad6.Size = new System.Drawing.Size(114, 114);
         this.pad6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad6.TabIndex = 0;
         this.pad6.TabStop = false;
         this.pad6.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad9
         // 
         this.pad9.chorusDelay = 0D;
         this.pad9.chorusDepth = 0D;
         this.pad9.chorusLevel = 0D;
         this.pad9.ContextMenuStrip = this.padContextMenuStrip;
         this.pad9.driveSetting = 0D;
         this.pad9.echoCount = 0;
         this.pad9.echoDelay = 0;
         this.pad9.echoFactor = 0F;
         this.pad9.frequency = 0D;
         this.pad9.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad9.InitialImage = null;
         this.pad9.isChorusing = false;
         this.pad9.isEchoing = false;
         this.pad9.isLoaded = false;
         this.pad9.isLowPass = false;
         this.pad9.isOverdriving = false;
         this.pad9.isPassing = false;
         this.pad9.keyShortCut = '\0';
         this.pad9.Location = new System.Drawing.Point(279, 9);
         this.pad9.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad9.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad9.Name = "pad9";
         this.pad9.SamplePath = null;
         this.pad9.Size = new System.Drawing.Size(114, 114);
         this.pad9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad9.TabIndex = 0;
         this.pad9.TabStop = false;
         this.pad9.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad2
         // 
         this.pad2.chorusDelay = 0D;
         this.pad2.chorusDepth = 0D;
         this.pad2.chorusLevel = 0D;
         this.pad2.ContextMenuStrip = this.padContextMenuStrip;
         this.pad2.driveSetting = 0D;
         this.pad2.echoCount = 0;
         this.pad2.echoDelay = 0;
         this.pad2.echoFactor = 0F;
         this.pad2.frequency = 0D;
         this.pad2.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad2.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad2.isChorusing = false;
         this.pad2.isEchoing = false;
         this.pad2.isLoaded = false;
         this.pad2.isLowPass = false;
         this.pad2.isOverdriving = false;
         this.pad2.isPassing = false;
         this.pad2.keyShortCut = '\0';
         this.pad2.Location = new System.Drawing.Point(144, 279);
         this.pad2.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad2.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad2.Name = "pad2";
         this.pad2.SamplePath = null;
         this.pad2.Size = new System.Drawing.Size(114, 114);
         this.pad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad2.TabIndex = 0;
         this.pad2.TabStop = false;
         this.pad2.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad5
         // 
         this.pad5.chorusDelay = 0D;
         this.pad5.chorusDepth = 0D;
         this.pad5.chorusLevel = 0D;
         this.pad5.ContextMenuStrip = this.padContextMenuStrip;
         this.pad5.driveSetting = 0D;
         this.pad5.echoCount = 0;
         this.pad5.echoDelay = 0;
         this.pad5.echoFactor = 0F;
         this.pad5.frequency = 0D;
         this.pad5.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad5.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad5.isChorusing = false;
         this.pad5.isEchoing = false;
         this.pad5.isLoaded = false;
         this.pad5.isLowPass = false;
         this.pad5.isOverdriving = false;
         this.pad5.isPassing = false;
         this.pad5.keyShortCut = '\0';
         this.pad5.Location = new System.Drawing.Point(144, 144);
         this.pad5.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad5.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad5.Name = "pad5";
         this.pad5.SamplePath = null;
         this.pad5.Size = new System.Drawing.Size(114, 114);
         this.pad5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad5.TabIndex = 0;
         this.pad5.TabStop = false;
         this.pad5.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad8
         // 
         this.pad8.chorusDelay = 0D;
         this.pad8.chorusDepth = 0D;
         this.pad8.chorusLevel = 0D;
         this.pad8.ContextMenuStrip = this.padContextMenuStrip;
         this.pad8.driveSetting = 0D;
         this.pad8.echoCount = 0;
         this.pad8.echoDelay = 0;
         this.pad8.echoFactor = 0F;
         this.pad8.frequency = 0D;
         this.pad8.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad8.InitialImage = null;
         this.pad8.isChorusing = false;
         this.pad8.isEchoing = false;
         this.pad8.isLoaded = false;
         this.pad8.isLowPass = false;
         this.pad8.isOverdriving = false;
         this.pad8.isPassing = false;
         this.pad8.keyShortCut = '\0';
         this.pad8.Location = new System.Drawing.Point(144, 9);
         this.pad8.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad8.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad8.Name = "pad8";
         this.pad8.SamplePath = null;
         this.pad8.Size = new System.Drawing.Size(114, 114);
         this.pad8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad8.TabIndex = 0;
         this.pad8.TabStop = false;
         this.pad8.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad1
         // 
         this.pad1.chorusDelay = 0D;
         this.pad1.chorusDepth = 0D;
         this.pad1.chorusLevel = 0D;
         this.pad1.ContextMenuStrip = this.padContextMenuStrip;
         this.pad1.driveSetting = 0D;
         this.pad1.echoCount = 0;
         this.pad1.echoDelay = 0;
         this.pad1.echoFactor = 0F;
         this.pad1.frequency = 0D;
         this.pad1.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad1.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad1.isChorusing = false;
         this.pad1.isEchoing = false;
         this.pad1.isLoaded = false;
         this.pad1.isLowPass = false;
         this.pad1.isOverdriving = false;
         this.pad1.isPassing = false;
         this.pad1.keyShortCut = '\0';
         this.pad1.Location = new System.Drawing.Point(9, 279);
         this.pad1.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad1.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad1.Name = "pad1";
         this.pad1.SamplePath = null;
         this.pad1.Size = new System.Drawing.Size(114, 114);
         this.pad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad1.TabIndex = 0;
         this.pad1.TabStop = false;
         this.pad1.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad4
         // 
         this.pad4.chorusDelay = 0D;
         this.pad4.chorusDepth = 0D;
         this.pad4.chorusLevel = 0D;
         this.pad4.ContextMenuStrip = this.padContextMenuStrip;
         this.pad4.driveSetting = 0D;
         this.pad4.echoCount = 0;
         this.pad4.echoDelay = 0;
         this.pad4.echoFactor = 0F;
         this.pad4.frequency = 0D;
         this.pad4.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad4.InitialImage = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad4.isChorusing = false;
         this.pad4.isEchoing = false;
         this.pad4.isLoaded = false;
         this.pad4.isLowPass = false;
         this.pad4.isOverdriving = false;
         this.pad4.isPassing = false;
         this.pad4.keyShortCut = '\0';
         this.pad4.Location = new System.Drawing.Point(9, 144);
         this.pad4.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad4.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad4.Name = "pad4";
         this.pad4.SamplePath = null;
         this.pad4.Size = new System.Drawing.Size(114, 114);
         this.pad4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad4.TabIndex = 0;
         this.pad4.TabStop = false;
         this.pad4.Click += new System.EventHandler(this.pad_Activated);
         // 
         // pad7
         // 
         this.pad7.chorusDelay = 0D;
         this.pad7.chorusDepth = 0D;
         this.pad7.chorusLevel = 0D;
         this.pad7.ContextMenuStrip = this.padContextMenuStrip;
         this.pad7.driveSetting = 0D;
         this.pad7.echoCount = 0;
         this.pad7.echoDelay = 0;
         this.pad7.echoFactor = 0F;
         this.pad7.frequency = 0D;
         this.pad7.Image = global::AudioSampler.Properties.Resources.Black_Pad;
         this.pad7.InitialImage = null;
         this.pad7.isChorusing = false;
         this.pad7.isEchoing = false;
         this.pad7.isLoaded = false;
         this.pad7.isLowPass = false;
         this.pad7.isOverdriving = false;
         this.pad7.isPassing = false;
         this.pad7.keyShortCut = '\0';
         this.pad7.Location = new System.Drawing.Point(9, 9);
         this.pad7.MaximumSize = new System.Drawing.Size(114, 114);
         this.pad7.MinimumSize = new System.Drawing.Size(114, 114);
         this.pad7.Name = "pad7";
         this.pad7.SamplePath = null;
         this.pad7.Size = new System.Drawing.Size(114, 114);
         this.pad7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pad7.TabIndex = 0;
         this.pad7.TabStop = false;
         this.pad7.Click += new System.EventHandler(this.pad_Activated);
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
         this.txtBoxDebug.Location = new System.Drawing.Point(459, 276);
         this.txtBoxDebug.Multiline = true;
         this.txtBoxDebug.Name = "txtBoxDebug";
         this.txtBoxDebug.Size = new System.Drawing.Size(262, 133);
         this.txtBoxDebug.TabIndex = 4;
         // 
         // lblDebug
         // 
         this.lblDebug.AutoSize = true;
         this.lblDebug.Location = new System.Drawing.Point(456, 259);
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
         this.effect4Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
         this.fx4OnCheckBox.Location = new System.Drawing.Point(99, 3);
         this.fx4OnCheckBox.Name = "fx4OnCheckBox";
         this.fx4OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx4OnCheckBox.TabIndex = 0;
         this.fx4OnCheckBox.Text = "Enabled";
         this.fx4OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect3Panel
         // 
         this.effect3Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect3Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
         this.fx3OnCheckBox.Location = new System.Drawing.Point(103, 3);
         this.fx3OnCheckBox.Name = "fx3OnCheckBox";
         this.fx3OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx3OnCheckBox.TabIndex = 0;
         this.fx3OnCheckBox.Text = "Enabled";
         this.fx3OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect2Panel
         // 
         this.effect2Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
         this.fx2OnCheckBox.Location = new System.Drawing.Point(103, 3);
         this.fx2OnCheckBox.Name = "fx2OnCheckBox";
         this.fx2OnCheckBox.Size = new System.Drawing.Size(72, 17);
         this.fx2OnCheckBox.TabIndex = 0;
         this.fx2OnCheckBox.Text = "Enabled";
         this.fx2OnCheckBox.UseVisualStyleBackColor = false;
         // 
         // effect1Panel
         // 
         this.effect1Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.effect1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
         this.fx1OnCheckBox.Location = new System.Drawing.Point(103, 3);
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
         this.panelPads.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pad3)).EndInit();
         this.padContextMenuStrip.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pad6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad9)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad8)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pad7)).EndInit();
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

