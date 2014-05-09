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
            this.lblDrive = new System.Windows.Forms.Label();
            this.btnDrive = new System.Windows.Forms.Button();
            this.lblDriveAmount = new System.Windows.Forms.Label();
            this.txtBoxDriveAmount = new System.Windows.Forms.TextBox();
            this.effect3Panel = new System.Windows.Forms.Panel();
            this.rbtnFilterHP = new System.Windows.Forms.RadioButton();
            this.rbtnFilterLP = new System.Windows.Forms.RadioButton();
            this.btnFilter = new System.Windows.Forms.Button();
            this.fx3OnCheckBox = new System.Windows.Forms.CheckBox();
            this.lblFilterFrequency = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtBoxFilterFrequency = new System.Windows.Forms.TextBox();
            this.effect2Panel = new System.Windows.Forms.Panel();
            this.btnChorus = new System.Windows.Forms.Button();
            this.fx2OnCheckBox = new System.Windows.Forms.CheckBox();
            this.lblChorusDelay = new System.Windows.Forms.Label();
            this.lblChorus = new System.Windows.Forms.Label();
            this.txtBoxChorusDelay = new System.Windows.Forms.TextBox();
            this.txtBoxChorusLevel = new System.Windows.Forms.TextBox();
            this.txtBoxChorusDepth = new System.Windows.Forms.TextBox();
            this.lblChorusDepth = new System.Windows.Forms.Label();
            this.lblChorusLevel = new System.Windows.Forms.Label();
            this.effect1Panel = new System.Windows.Forms.Panel();
            this.btnEcho = new System.Windows.Forms.Button();
            this.lblEchoFactor = new System.Windows.Forms.Label();
            this.txtBoxEchoFactor = new System.Windows.Forms.TextBox();
            this.lblEcho = new System.Windows.Forms.Label();
            this.lblEchoCount = new System.Windows.Forms.Label();
            this.lblEchoDelay = new System.Windows.Forms.Label();
            this.txtBoxEchoCount = new System.Windows.Forms.TextBox();
            this.txtBoxEchoDelay = new System.Windows.Forms.TextBox();
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
            this.txtBoxDebug.Location = new System.Drawing.Point(420, 351);
            this.txtBoxDebug.Multiline = true;
            this.txtBoxDebug.Name = "txtBoxDebug";
            this.txtBoxDebug.ReadOnly = true;
            this.txtBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDebug.Size = new System.Drawing.Size(315, 67);
            this.txtBoxDebug.TabIndex = 4;
            this.txtBoxDebug.Visible = false;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(426, 335);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(62, 13);
            this.lblDebug.TabIndex = 3;
            this.lblDebug.Text = "Debugging:";
            this.lblDebug.Visible = false;
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
            this.effect4Panel.Controls.Add(this.lblDrive);
            this.effect4Panel.Controls.Add(this.btnDrive);
            this.effect4Panel.Controls.Add(this.lblDriveAmount);
            this.effect4Panel.Controls.Add(this.txtBoxDriveAmount);
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
            this.fx4OnCheckBox.Enabled = false;
            this.fx4OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx4OnCheckBox.Location = new System.Drawing.Point(103, 12);
            this.fx4OnCheckBox.Name = "fx4OnCheckBox";
            this.fx4OnCheckBox.Size = new System.Drawing.Size(72, 17);
            this.fx4OnCheckBox.TabIndex = 0;
            this.fx4OnCheckBox.Text = "Enabled";
            this.fx4OnCheckBox.UseVisualStyleBackColor = false;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive.Location = new System.Drawing.Point(22, 12);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(63, 25);
            this.lblDrive.TabIndex = 3;
            this.lblDrive.Text = "DRIVE";
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(56, 218);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(75, 23);
            this.btnDrive.TabIndex = 4;
            this.btnDrive.Text = "Apply";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // lblDriveAmount
            // 
            this.lblDriveAmount.AutoSize = true;
            this.lblDriveAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDriveAmount.Location = new System.Drawing.Point(40, 60);
            this.lblDriveAmount.Name = "lblDriveAmount";
            this.lblDriveAmount.Size = new System.Drawing.Size(43, 13);
            this.lblDriveAmount.TabIndex = 2;
            this.lblDriveAmount.Text = "Amount";
            // 
            // txtBoxDriveAmount
            // 
            this.txtBoxDriveAmount.Location = new System.Drawing.Point(41, 76);
            this.txtBoxDriveAmount.Name = "txtBoxDriveAmount";
            this.txtBoxDriveAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDriveAmount.TabIndex = 1;
            this.txtBoxDriveAmount.TextChanged += new System.EventHandler(this.Drive_ParamsChanged);
            // 
            // effect3Panel
            // 
            this.effect3Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.effect3Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
            this.effect3Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.effect3Panel.Controls.Add(this.rbtnFilterHP);
            this.effect3Panel.Controls.Add(this.rbtnFilterLP);
            this.effect3Panel.Controls.Add(this.btnFilter);
            this.effect3Panel.Controls.Add(this.fx3OnCheckBox);
            this.effect3Panel.Controls.Add(this.lblFilterFrequency);
            this.effect3Panel.Controls.Add(this.lblFilter);
            this.effect3Panel.Controls.Add(this.txtBoxFilterFrequency);
            this.effect3Panel.Location = new System.Drawing.Point(377, 3);
            this.effect3Panel.Name = "effect3Panel";
            this.effect3Panel.Size = new System.Drawing.Size(180, 259);
            this.effect3Panel.TabIndex = 1;
            // 
            // rbtnFilterHP
            // 
            this.rbtnFilterHP.AutoSize = true;
            this.rbtnFilterHP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rbtnFilterHP.Location = new System.Drawing.Point(45, 159);
            this.rbtnFilterHP.Name = "rbtnFilterHP";
            this.rbtnFilterHP.Size = new System.Drawing.Size(73, 17);
            this.rbtnFilterHP.TabIndex = 5;
            this.rbtnFilterHP.TabStop = true;
            this.rbtnFilterHP.Text = "High-Pass";
            this.rbtnFilterHP.UseVisualStyleBackColor = false;
            this.rbtnFilterHP.CheckedChanged += new System.EventHandler(this.Filter_ParamsChanged);
            // 
            // rbtnFilterLP
            // 
            this.rbtnFilterLP.AutoSize = true;
            this.rbtnFilterLP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rbtnFilterLP.Location = new System.Drawing.Point(45, 120);
            this.rbtnFilterLP.Name = "rbtnFilterLP";
            this.rbtnFilterLP.Size = new System.Drawing.Size(71, 17);
            this.rbtnFilterLP.TabIndex = 5;
            this.rbtnFilterLP.TabStop = true;
            this.rbtnFilterLP.Text = "Low-Pass";
            this.rbtnFilterLP.UseVisualStyleBackColor = false;
            this.rbtnFilterLP.CheckedChanged += new System.EventHandler(this.Filter_ParamsChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(52, 218);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Apply";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // fx3OnCheckBox
            // 
            this.fx3OnCheckBox.AutoSize = true;
            this.fx3OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fx3OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fx3OnCheckBox.Enabled = false;
            this.fx3OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx3OnCheckBox.Location = new System.Drawing.Point(103, 12);
            this.fx3OnCheckBox.Name = "fx3OnCheckBox";
            this.fx3OnCheckBox.Size = new System.Drawing.Size(72, 17);
            this.fx3OnCheckBox.TabIndex = 0;
            this.fx3OnCheckBox.Text = "Enabled";
            this.fx3OnCheckBox.UseVisualStyleBackColor = false;
            // 
            // lblFilterFrequency
            // 
            this.lblFilterFrequency.AutoSize = true;
            this.lblFilterFrequency.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilterFrequency.Location = new System.Drawing.Point(40, 60);
            this.lblFilterFrequency.Name = "lblFilterFrequency";
            this.lblFilterFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFilterFrequency.TabIndex = 2;
            this.lblFilterFrequency.Text = "Frequency";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(15, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(73, 25);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "FILTER";
            // 
            // txtBoxFilterFrequency
            // 
            this.txtBoxFilterFrequency.Location = new System.Drawing.Point(41, 76);
            this.txtBoxFilterFrequency.Name = "txtBoxFilterFrequency";
            this.txtBoxFilterFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFilterFrequency.TabIndex = 1;
            this.txtBoxFilterFrequency.TextChanged += new System.EventHandler(this.Filter_ParamsChanged);
            // 
            // effect2Panel
            // 
            this.effect2Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.effect2Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
            this.effect2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.effect2Panel.Controls.Add(this.btnChorus);
            this.effect2Panel.Controls.Add(this.fx2OnCheckBox);
            this.effect2Panel.Controls.Add(this.lblChorusDelay);
            this.effect2Panel.Controls.Add(this.lblChorus);
            this.effect2Panel.Controls.Add(this.txtBoxChorusDelay);
            this.effect2Panel.Controls.Add(this.txtBoxChorusLevel);
            this.effect2Panel.Controls.Add(this.txtBoxChorusDepth);
            this.effect2Panel.Controls.Add(this.lblChorusDepth);
            this.effect2Panel.Controls.Add(this.lblChorusLevel);
            this.effect2Panel.Location = new System.Drawing.Point(191, 3);
            this.effect2Panel.Name = "effect2Panel";
            this.effect2Panel.Size = new System.Drawing.Size(180, 259);
            this.effect2Panel.TabIndex = 1;
            // 
            // btnChorus
            // 
            this.btnChorus.Location = new System.Drawing.Point(52, 218);
            this.btnChorus.Name = "btnChorus";
            this.btnChorus.Size = new System.Drawing.Size(75, 23);
            this.btnChorus.TabIndex = 4;
            this.btnChorus.Text = "Apply";
            this.btnChorus.UseVisualStyleBackColor = true;
            this.btnChorus.Click += new System.EventHandler(this.btnChorus_Click);
            // 
            // fx2OnCheckBox
            // 
            this.fx2OnCheckBox.AutoSize = true;
            this.fx2OnCheckBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fx2OnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fx2OnCheckBox.Enabled = false;
            this.fx2OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx2OnCheckBox.Location = new System.Drawing.Point(103, 12);
            this.fx2OnCheckBox.Name = "fx2OnCheckBox";
            this.fx2OnCheckBox.Size = new System.Drawing.Size(72, 17);
            this.fx2OnCheckBox.TabIndex = 0;
            this.fx2OnCheckBox.Text = "Enabled";
            this.fx2OnCheckBox.UseVisualStyleBackColor = false;
            // 
            // lblChorusDelay
            // 
            this.lblChorusDelay.AutoSize = true;
            this.lblChorusDelay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblChorusDelay.Location = new System.Drawing.Point(40, 163);
            this.lblChorusDelay.Name = "lblChorusDelay";
            this.lblChorusDelay.Size = new System.Drawing.Size(34, 13);
            this.lblChorusDelay.TabIndex = 2;
            this.lblChorusDelay.Text = "Delay";
            // 
            // lblChorus
            // 
            this.lblChorus.AutoSize = true;
            this.lblChorus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChorus.Location = new System.Drawing.Point(13, 12);
            this.lblChorus.Name = "lblChorus";
            this.lblChorus.Size = new System.Drawing.Size(84, 25);
            this.lblChorus.TabIndex = 3;
            this.lblChorus.Text = "CHORUS";
            // 
            // txtBoxChorusDelay
            // 
            this.txtBoxChorusDelay.Location = new System.Drawing.Point(41, 179);
            this.txtBoxChorusDelay.Name = "txtBoxChorusDelay";
            this.txtBoxChorusDelay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChorusDelay.TabIndex = 1;
            this.txtBoxChorusDelay.TextChanged += new System.EventHandler(this.Chorus_ParamsChanged);
            // 
            // txtBoxChorusLevel
            // 
            this.txtBoxChorusLevel.Location = new System.Drawing.Point(38, 76);
            this.txtBoxChorusLevel.Name = "txtBoxChorusLevel";
            this.txtBoxChorusLevel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChorusLevel.TabIndex = 1;
            this.txtBoxChorusLevel.TextChanged += new System.EventHandler(this.Chorus_ParamsChanged);
            // 
            // txtBoxChorusDepth
            // 
            this.txtBoxChorusDepth.Location = new System.Drawing.Point(41, 127);
            this.txtBoxChorusDepth.Name = "txtBoxChorusDepth";
            this.txtBoxChorusDepth.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChorusDepth.TabIndex = 1;
            this.txtBoxChorusDepth.TextChanged += new System.EventHandler(this.Chorus_ParamsChanged);
            // 
            // lblChorusDepth
            // 
            this.lblChorusDepth.AutoSize = true;
            this.lblChorusDepth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblChorusDepth.Location = new System.Drawing.Point(40, 111);
            this.lblChorusDepth.Name = "lblChorusDepth";
            this.lblChorusDepth.Size = new System.Drawing.Size(36, 13);
            this.lblChorusDepth.TabIndex = 2;
            this.lblChorusDepth.Text = "Depth";
            // 
            // lblChorusLevel
            // 
            this.lblChorusLevel.AutoSize = true;
            this.lblChorusLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblChorusLevel.Location = new System.Drawing.Point(37, 60);
            this.lblChorusLevel.Name = "lblChorusLevel";
            this.lblChorusLevel.Size = new System.Drawing.Size(33, 13);
            this.lblChorusLevel.TabIndex = 2;
            this.lblChorusLevel.Text = "Level";
            // 
            // effect1Panel
            // 
            this.effect1Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.effect1Panel.BackgroundImage = global::AudioSampler.Properties.Resources.FXBoxBackground;
            this.effect1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.effect1Panel.Controls.Add(this.btnEcho);
            this.effect1Panel.Controls.Add(this.lblEchoFactor);
            this.effect1Panel.Controls.Add(this.txtBoxEchoFactor);
            this.effect1Panel.Controls.Add(this.lblEcho);
            this.effect1Panel.Controls.Add(this.lblEchoCount);
            this.effect1Panel.Controls.Add(this.lblEchoDelay);
            this.effect1Panel.Controls.Add(this.txtBoxEchoCount);
            this.effect1Panel.Controls.Add(this.txtBoxEchoDelay);
            this.effect1Panel.Controls.Add(this.fx1OnCheckBox);
            this.effect1Panel.Location = new System.Drawing.Point(5, 3);
            this.effect1Panel.Name = "effect1Panel";
            this.effect1Panel.Size = new System.Drawing.Size(180, 259);
            this.effect1Panel.TabIndex = 1;
            // 
            // btnEcho
            // 
            this.btnEcho.Location = new System.Drawing.Point(50, 218);
            this.btnEcho.Name = "btnEcho";
            this.btnEcho.Size = new System.Drawing.Size(75, 23);
            this.btnEcho.TabIndex = 4;
            this.btnEcho.Text = "Apply";
            this.btnEcho.UseVisualStyleBackColor = true;
            this.btnEcho.Click += new System.EventHandler(this.btnEcho_Click);
            // 
            // lblEchoFactor
            // 
            this.lblEchoFactor.AutoSize = true;
            this.lblEchoFactor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEchoFactor.Location = new System.Drawing.Point(38, 163);
            this.lblEchoFactor.Name = "lblEchoFactor";
            this.lblEchoFactor.Size = new System.Drawing.Size(103, 13);
            this.lblEchoFactor.TabIndex = 2;
            this.lblEchoFactor.Text = "Echo Factor (decay)";
            // 
            // txtBoxEchoFactor
            // 
            this.txtBoxEchoFactor.Location = new System.Drawing.Point(39, 179);
            this.txtBoxEchoFactor.Name = "txtBoxEchoFactor";
            this.txtBoxEchoFactor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEchoFactor.TabIndex = 3;
            this.txtBoxEchoFactor.TextChanged += new System.EventHandler(this.Echo_ParamsChanged);
            // 
            // lblEcho
            // 
            this.lblEcho.AutoSize = true;
            this.lblEcho.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcho.Location = new System.Drawing.Point(21, 12);
            this.lblEcho.Name = "lblEcho";
            this.lblEcho.Size = new System.Drawing.Size(60, 25);
            this.lblEcho.TabIndex = 3;
            this.lblEcho.Text = "ECHO";
            // 
            // lblEchoCount
            // 
            this.lblEchoCount.AutoSize = true;
            this.lblEchoCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEchoCount.Location = new System.Drawing.Point(38, 111);
            this.lblEchoCount.Name = "lblEchoCount";
            this.lblEchoCount.Size = new System.Drawing.Size(63, 13);
            this.lblEchoCount.TabIndex = 2;
            this.lblEchoCount.Text = "Echo Count";
            // 
            // lblEchoDelay
            // 
            this.lblEchoDelay.AutoSize = true;
            this.lblEchoDelay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEchoDelay.Location = new System.Drawing.Point(35, 60);
            this.lblEchoDelay.Name = "lblEchoDelay";
            this.lblEchoDelay.Size = new System.Drawing.Size(82, 13);
            this.lblEchoDelay.TabIndex = 2;
            this.lblEchoDelay.Text = "Delay Time (ms)";
            // 
            // txtBoxEchoCount
            // 
            this.txtBoxEchoCount.Location = new System.Drawing.Point(39, 127);
            this.txtBoxEchoCount.Name = "txtBoxEchoCount";
            this.txtBoxEchoCount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEchoCount.TabIndex = 2;
            this.txtBoxEchoCount.TextChanged += new System.EventHandler(this.Echo_ParamsChanged);
            // 
            // txtBoxEchoDelay
            // 
            this.txtBoxEchoDelay.Location = new System.Drawing.Point(36, 76);
            this.txtBoxEchoDelay.Name = "txtBoxEchoDelay";
            this.txtBoxEchoDelay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEchoDelay.TabIndex = 1;
            this.txtBoxEchoDelay.TextChanged += new System.EventHandler(this.Echo_ParamsChanged);
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
            this.fx1OnCheckBox.CheckedChanged += new System.EventHandler(this.fx1OnCheckBox_CheckedChanged);
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
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            // 
            // pad3
            // 
            this.pad3.chorusDelay = 0D;
            this.pad3.chorusDepth = 0D;
            this.pad3.chorusLevel = 0D;
            this.pad3.currentFilter = 0;
            this.pad3.driveSetting = 0D;
            this.pad3.echoCount = 0;
            this.pad3.echoDelay = 0;
            this.pad3.echoFactor = 0F;
            this.pad3.frequency = 0D;
            this.pad3.Image = ((System.Drawing.Image)(resources.GetObject("pad3.Image")));
            this.pad3.InitialImage = null;
            this.pad3.isChorusing = false;
            this.pad3.isEchoing = false;
            this.pad3.isLoaded = true;
            this.pad3.isLowPass = false;
            this.pad3.isOverdriving = false;
            this.pad3.isPassing = false;
            this.pad3.keyShortCut = System.Windows.Forms.Keys.None;
            this.pad3.Location = new System.Drawing.Point(0, 0);
            this.pad3.MaximumSize = new System.Drawing.Size(114, 114);
            this.pad3.MinimumSize = new System.Drawing.Size(114, 114);
            this.pad3.Name = "pad3";
            this.pad3.parametersChanged = false;
            this.pad3.SamplePath = "";
            this.pad3.Size = new System.Drawing.Size(114, 114);
            this.pad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
        private System.Windows.Forms.TextBox txtBoxEchoDelay;
        private System.Windows.Forms.TextBox txtBoxEchoCount;
        private System.Windows.Forms.TextBox txtBoxEchoFactor;
        private System.Windows.Forms.Label lblEcho;
        private System.Windows.Forms.Label lblEchoCount;
        private System.Windows.Forms.Label lblEchoFactor;
        private System.Windows.Forms.Label lblEchoDelay;
        private System.Windows.Forms.Button btnChorus;
        private System.Windows.Forms.Label lblChorusDelay;
        private System.Windows.Forms.Label lblChorus;
        private System.Windows.Forms.TextBox txtBoxChorusDelay;
        private System.Windows.Forms.TextBox txtBoxChorusLevel;
        private System.Windows.Forms.TextBox txtBoxChorusDepth;
        private System.Windows.Forms.Label lblChorusDepth;
        private System.Windows.Forms.Label lblChorusLevel;
        private System.Windows.Forms.Button btnEcho;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterFrequency;
        private System.Windows.Forms.TextBox txtBoxFilterFrequency;
        private System.Windows.Forms.RadioButton rbtnFilterHP;
        private System.Windows.Forms.RadioButton rbtnFilterLP;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Label lblDriveAmount;
        private System.Windows.Forms.TextBox txtBoxDriveAmount;
        private System.Windows.Forms.Button btnDrive;
    }
}

