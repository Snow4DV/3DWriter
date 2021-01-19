using System.Drawing;

namespace _3DWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontscale_value = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.FontComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SimpleFontsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.previewScale2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.previewScale4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.previewScale1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.previewCard = new MaterialSkin.Controls.MaterialCard();
            this.pb_preview = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.resetDefaultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about3DWriterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuButton = new MaterialSkin.Controls.MaterialButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.topMenuTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.GCodeTab = new System.Windows.Forms.TabPage();
            this.homez = new System.Windows.Forms.CheckBox();
            this.homey = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.homex = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dryrun = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.letspacing = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lspacing = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label_mode_up = new System.Windows.Forms.Label();
            this.label_mode_down = new System.Windows.Forms.Label();
            this.penup = new System.Windows.Forms.TextBox();
            this.pendown = new System.Windows.Forms.TextBox();
            this.label_mode_up_text = new System.Windows.Forms.Label();
            this.label_mode_down_text = new System.Windows.Forms.Label();
            this.radio_laser_mode = new System.Windows.Forms.RadioButton();
            this.radio_draw_mode = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.zspeed = new System.Windows.Forms.TextBox();
            this.offsety = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.offsetx = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beddepth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bedwidth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tspeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dspeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.HandwritingModTab = new System.Windows.Forms.TabPage();
            this.rotCheckbox = new System.Windows.Forms.CheckBox();
            this.randomLineSpacingCheckbox = new System.Windows.Forms.CheckBox();
            this.lineGoingDownCheckbox = new System.Windows.Forms.CheckBox();
            this.correctLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.sloppyCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.connectLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.topMenuTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label30 = new System.Windows.Forms.Label();
            this.textSize_tb = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.previewCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.panel3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.topMenuTabControl.SuspendLayout();
            this.GCodeTab.SuspendLayout();
            this.HandwritingModTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontscale_value
            // 
            this.fontscale_value.Location = new System.Drawing.Point(294, 461);
            this.fontscale_value.Name = "fontscale_value";
            this.fontscale_value.Size = new System.Drawing.Size(37, 13);
            this.fontscale_value.TabIndex = 32;
            this.fontscale_value.Text = "0";
            this.fontscale_value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.fontscale_value.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(459, 10);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(50, 49);
            this.materialButton1.TabIndex = 58;
            this.materialButton1.Text = "Thmb";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FontComboBox
            // 
            this.FontComboBox.AutoResize = false;
            this.FontComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FontComboBox.Depth = 0;
            this.FontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FontComboBox.DropDownHeight = 174;
            this.FontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontComboBox.DropDownWidth = 121;
            this.FontComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FontComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Hint = "Fonts";
            this.FontComboBox.IntegralHeight = false;
            this.FontComboBox.ItemHeight = 43;
            this.FontComboBox.Location = new System.Drawing.Point(516, 10);
            this.FontComboBox.MaxDropDownItems = 4;
            this.FontComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(169, 49);
            this.FontComboBox.TabIndex = 59;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // SimpleFontsCheckbox
            // 
            this.SimpleFontsCheckbox.AutoSize = true;
            this.SimpleFontsCheckbox.Depth = 0;
            this.SimpleFontsCheckbox.Enabled = false;
            this.SimpleFontsCheckbox.Location = new System.Drawing.Point(741, 30);
            this.SimpleFontsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.SimpleFontsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SimpleFontsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SimpleFontsCheckbox.Name = "SimpleFontsCheckbox";
            this.SimpleFontsCheckbox.Ripple = true;
            this.SimpleFontsCheckbox.Size = new System.Drawing.Size(125, 37);
            this.SimpleFontsCheckbox.TabIndex = 60;
            this.SimpleFontsCheckbox.Text = "Simple fonts";
            this.SimpleFontsCheckbox.UseVisualStyleBackColor = true;
            this.SimpleFontsCheckbox.Visible = false;
            this.SimpleFontsCheckbox.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 24);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 63;
            this.materialLabel2.Text = "Preview";
            // 
            // previewScale2
            // 
            this.previewScale2.Depth = 0;
            this.previewScale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.previewScale2.Location = new System.Drawing.Point(328, 16);
            this.previewScale2.Margin = new System.Windows.Forms.Padding(0);
            this.previewScale2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale2.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale2.Name = "previewScale2";
            this.previewScale2.Ripple = true;
            this.previewScale2.Size = new System.Drawing.Size(51, 23);
            this.previewScale2.TabIndex = 66;
            this.previewScale2.TabStop = true;
            this.previewScale2.Text = "2x";
            this.previewScale2.UseVisualStyleBackColor = true;
            this.previewScale2.Click += new System.EventHandler(this.preview_mag2_Click);
            // 
            // previewScale4
            // 
            this.previewScale4.Depth = 0;
            this.previewScale4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.previewScale4.Location = new System.Drawing.Point(379, 16);
            this.previewScale4.Margin = new System.Windows.Forms.Padding(0);
            this.previewScale4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale4.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale4.Name = "previewScale4";
            this.previewScale4.Ripple = true;
            this.previewScale4.Size = new System.Drawing.Size(51, 23);
            this.previewScale4.TabIndex = 67;
            this.previewScale4.TabStop = true;
            this.previewScale4.Text = "4x";
            this.previewScale4.UseVisualStyleBackColor = true;
            this.previewScale4.Click += new System.EventHandler(this.preview_mag4_Click);
            // 
            // previewScale1
            // 
            this.previewScale1.Depth = 0;
            this.previewScale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.previewScale1.Location = new System.Drawing.Point(277, 16);
            this.previewScale1.Margin = new System.Windows.Forms.Padding(0);
            this.previewScale1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale1.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale1.Name = "previewScale1";
            this.previewScale1.Ripple = true;
            this.previewScale1.Size = new System.Drawing.Size(51, 23);
            this.previewScale1.TabIndex = 68;
            this.previewScale1.TabStop = true;
            this.previewScale1.Text = "1x";
            this.previewScale1.UseVisualStyleBackColor = true;
            this.previewScale1.Visible = false;
            this.previewScale1.Click += new System.EventHandler(this.preview_mag1_Click);
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.Color.White;
            this.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_input.Location = new System.Drawing.Point(5, 8);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(455, 265);
            this.tb_input.TabIndex = 69;
            this.tb_input.Text = "Welcome to 3DWriter!";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.fontscale_value);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 491);
            this.panel2.TabIndex = 70;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.previewScale4);
            this.panel4.Controls.Add(this.previewScale2);
            this.panel4.Controls.Add(this.previewScale1);
            this.panel4.Controls.Add(this.previewCard);
            this.panel4.Controls.Add(this.materialLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(500, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 491);
            this.panel4.TabIndex = 74;
            // 
            // previewCard
            // 
            this.previewCard.AutoSize = true;
            this.previewCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewCard.Controls.Add(this.pb_preview);
            this.previewCard.Depth = 0;
            this.previewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.previewCard.Location = new System.Drawing.Point(20, 48);
            this.previewCard.Margin = new System.Windows.Forms.Padding(14);
            this.previewCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewCard.Name = "previewCard";
            this.previewCard.Padding = new System.Windows.Forms.Padding(14);
            this.previewCard.Size = new System.Drawing.Size(427, 429);
            this.previewCard.TabIndex = 72;
            // 
            // pb_preview
            // 
            this.pb_preview.Location = new System.Drawing.Point(0, 12);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(410, 400);
            this.pb_preview.TabIndex = 0;
            this.pb_preview.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.materialCard2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 491);
            this.panel3.TabIndex = 73;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tb_input);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(16, 69);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(467, 281);
            this.materialCard2.TabIndex = 71;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDefaultsToolStripMenuItem1,
            this.fontEditorToolStripMenuItem,
            this.wikiToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.about3DWriterToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(171, 136);
            // 
            // resetDefaultsToolStripMenuItem1
            // 
            this.resetDefaultsToolStripMenuItem1.Name = "resetDefaultsToolStripMenuItem1";
            this.resetDefaultsToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.resetDefaultsToolStripMenuItem1.Text = "Reset defaults";
            this.resetDefaultsToolStripMenuItem1.Click += new System.EventHandler(this.resetDefaultsToolStripMenuItem_Click);
            // 
            // fontEditorToolStripMenuItem
            // 
            this.fontEditorToolStripMenuItem.Name = "fontEditorToolStripMenuItem";
            this.fontEditorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontEditorToolStripMenuItem.Text = "Font editor";
            this.fontEditorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.wikiToolStripMenuItem.Text = "Wiki";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // about3DWriterToolStripMenuItem
            // 
            this.about3DWriterToolStripMenuItem.Name = "about3DWriterToolStripMenuItem";
            this.about3DWriterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.about3DWriterToolStripMenuItem.Text = "About 3DWriter";
            this.about3DWriterToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.menuButton);
            this.panel5.Location = new System.Drawing.Point(887, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 25);
            this.panel5.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = false;
            this.menuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Depth = 0;
            this.menuButton.DrawShadows = true;
            this.menuButton.HighEmphasis = true;
            this.menuButton.Icon = ((System.Drawing.Image)(resources.GetObject("menuButton.Icon")));
            this.menuButton.Location = new System.Drawing.Point(4, -4);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.menuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(55, 31);
            this.menuButton.TabIndex = 73;
            this.menuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.menuButton.UseAccentColor = false;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.topMenuTabControl);
            this.panel6.Controls.Add(this.topMenuTabSelector);
            this.panel6.Location = new System.Drawing.Point(0, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2093, 121);
            this.panel6.TabIndex = 72;
            // 
            // topMenuTabControl
            // 
            this.topMenuTabControl.Controls.Add(this.GCodeTab);
            this.topMenuTabControl.Controls.Add(this.HandwritingModTab);
            this.topMenuTabControl.Depth = 0;
            this.topMenuTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.topMenuTabControl.Location = new System.Drawing.Point(0, 37);
            this.topMenuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMenuTabControl.Multiline = true;
            this.topMenuTabControl.Name = "topMenuTabControl";
            this.topMenuTabControl.SelectedIndex = 0;
            this.topMenuTabControl.Size = new System.Drawing.Size(2093, 84);
            this.topMenuTabControl.TabIndex = 2;
            // 
            // GCodeTab
            // 
            this.GCodeTab.Controls.Add(this.homez);
            this.GCodeTab.Controls.Add(this.homey);
            this.GCodeTab.Controls.Add(this.label16);
            this.GCodeTab.Controls.Add(this.homex);
            this.GCodeTab.Controls.Add(this.label25);
            this.GCodeTab.Controls.Add(this.dryrun);
            this.GCodeTab.Controls.Add(this.label27);
            this.GCodeTab.Controls.Add(this.label26);
            this.GCodeTab.Controls.Add(this.letspacing);
            this.GCodeTab.Controls.Add(this.label24);
            this.GCodeTab.Controls.Add(this.lspacing);
            this.GCodeTab.Controls.Add(this.label23);
            this.GCodeTab.Controls.Add(this.label_mode_up);
            this.GCodeTab.Controls.Add(this.label_mode_down);
            this.GCodeTab.Controls.Add(this.penup);
            this.GCodeTab.Controls.Add(this.pendown);
            this.GCodeTab.Controls.Add(this.label_mode_up_text);
            this.GCodeTab.Controls.Add(this.label_mode_down_text);
            this.GCodeTab.Controls.Add(this.radio_laser_mode);
            this.GCodeTab.Controls.Add(this.radio_draw_mode);
            this.GCodeTab.Controls.Add(this.label33);
            this.GCodeTab.Controls.Add(this.label18);
            this.GCodeTab.Controls.Add(this.label32);
            this.GCodeTab.Controls.Add(this.label19);
            this.GCodeTab.Controls.Add(this.zspeed);
            this.GCodeTab.Controls.Add(this.offsety);
            this.GCodeTab.Controls.Add(this.label31);
            this.GCodeTab.Controls.Add(this.offsetx);
            this.GCodeTab.Controls.Add(this.label20);
            this.GCodeTab.Controls.Add(this.label21);
            this.GCodeTab.Controls.Add(this.label7);
            this.GCodeTab.Controls.Add(this.label5);
            this.GCodeTab.Controls.Add(this.beddepth);
            this.GCodeTab.Controls.Add(this.label4);
            this.GCodeTab.Controls.Add(this.label6);
            this.GCodeTab.Controls.Add(this.label15);
            this.GCodeTab.Controls.Add(this.bedwidth);
            this.GCodeTab.Controls.Add(this.label14);
            this.GCodeTab.Controls.Add(this.tspeed);
            this.GCodeTab.Controls.Add(this.label12);
            this.GCodeTab.Controls.Add(this.dspeed);
            this.GCodeTab.Controls.Add(this.label13);
            this.GCodeTab.Location = new System.Drawing.Point(4, 22);
            this.GCodeTab.Name = "GCodeTab";
            this.GCodeTab.Padding = new System.Windows.Forms.Padding(3);
            this.GCodeTab.Size = new System.Drawing.Size(2085, 58);
            this.GCodeTab.TabIndex = 0;
            this.GCodeTab.Text = "GCode";
            this.GCodeTab.UseVisualStyleBackColor = true;
            // 
            // homez
            // 
            this.homez.AutoSize = true;
            this.homez.Location = new System.Drawing.Point(367, 61);
            this.homez.Name = "homez";
            this.homez.Size = new System.Drawing.Size(33, 17);
            this.homez.TabIndex = 74;
            this.homez.Text = "Z";
            this.homez.UseVisualStyleBackColor = true;
            // 
            // homey
            // 
            this.homey.AutoSize = true;
            this.homey.Location = new System.Drawing.Point(328, 61);
            this.homey.Name = "homey";
            this.homey.Size = new System.Drawing.Size(33, 17);
            this.homey.TabIndex = 73;
            this.homey.Text = "Y";
            this.homey.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(249, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Home";
            // 
            // homex
            // 
            this.homex.AutoSize = true;
            this.homex.Location = new System.Drawing.Point(289, 61);
            this.homex.Name = "homex";
            this.homex.Size = new System.Drawing.Size(33, 17);
            this.homex.TabIndex = 71;
            this.homex.Text = "X";
            this.homex.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(772, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 70;
            this.label25.Text = "Dry run";
            // 
            // dryrun
            // 
            this.dryrun.AutoSize = true;
            this.dryrun.Location = new System.Drawing.Point(830, 61);
            this.dryrun.Name = "dryrun";
            this.dryrun.Size = new System.Drawing.Size(110, 17);
            this.dryrun.TabIndex = 69;
            this.dryrun.Text = "(pen is always up)";
            this.dryrun.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(909, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 68;
            this.label27.Text = "units";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(909, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 67;
            this.label26.Text = "units";
            // 
            // letspacing
            // 
            this.letspacing.Location = new System.Drawing.Point(852, 34);
            this.letspacing.Name = "letspacing";
            this.letspacing.Size = new System.Drawing.Size(48, 20);
            this.letspacing.TabIndex = 66;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(769, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 13);
            this.label24.TabIndex = 65;
            this.label24.Text = "Letter Spacing";
            // 
            // lspacing
            // 
            this.lspacing.Location = new System.Drawing.Point(852, 8);
            this.lspacing.Name = "lspacing";
            this.lspacing.Size = new System.Drawing.Size(48, 20);
            this.lspacing.TabIndex = 64;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(769, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 63;
            this.label23.Text = "Line Spacing";
            // 
            // label_mode_up
            // 
            this.label_mode_up.AutoSize = true;
            this.label_mode_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mode_up.Location = new System.Drawing.Point(353, 10);
            this.label_mode_up.Name = "label_mode_up";
            this.label_mode_up.Size = new System.Drawing.Size(41, 13);
            this.label_mode_up.TabIndex = 57;
            this.label_mode_up.Text = "Pen up";
            // 
            // label_mode_down
            // 
            this.label_mode_down.AutoSize = true;
            this.label_mode_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mode_down.Location = new System.Drawing.Point(353, 37);
            this.label_mode_down.Name = "label_mode_down";
            this.label_mode_down.Size = new System.Drawing.Size(55, 13);
            this.label_mode_down.TabIndex = 58;
            this.label_mode_down.Text = "Pen down";
            // 
            // penup
            // 
            this.penup.BackColor = System.Drawing.Color.White;
            this.penup.Location = new System.Drawing.Point(414, 7);
            this.penup.Name = "penup";
            this.penup.Size = new System.Drawing.Size(48, 20);
            this.penup.TabIndex = 59;
            // 
            // pendown
            // 
            this.pendown.Location = new System.Drawing.Point(414, 34);
            this.pendown.Name = "pendown";
            this.pendown.Size = new System.Drawing.Size(48, 20);
            this.pendown.TabIndex = 60;
            // 
            // label_mode_up_text
            // 
            this.label_mode_up_text.AutoSize = true;
            this.label_mode_up_text.Location = new System.Drawing.Point(468, 9);
            this.label_mode_up_text.Name = "label_mode_up_text";
            this.label_mode_up_text.Size = new System.Drawing.Size(23, 13);
            this.label_mode_up_text.TabIndex = 61;
            this.label_mode_up_text.Text = "mm";
            // 
            // label_mode_down_text
            // 
            this.label_mode_down_text.AutoSize = true;
            this.label_mode_down_text.Location = new System.Drawing.Point(468, 37);
            this.label_mode_down_text.Name = "label_mode_down_text";
            this.label_mode_down_text.Size = new System.Drawing.Size(23, 13);
            this.label_mode_down_text.TabIndex = 62;
            this.label_mode_down_text.Text = "mm";
            // 
            // radio_laser_mode
            // 
            this.radio_laser_mode.AutoSize = true;
            this.radio_laser_mode.Location = new System.Drawing.Point(129, 61);
            this.radio_laser_mode.Name = "radio_laser_mode";
            this.radio_laser_mode.Size = new System.Drawing.Size(51, 17);
            this.radio_laser_mode.TabIndex = 56;
            this.radio_laser_mode.TabStop = true;
            this.radio_laser_mode.Text = "Laser";
            this.radio_laser_mode.UseVisualStyleBackColor = true;
            // 
            // radio_draw_mode
            // 
            this.radio_draw_mode.AutoSize = true;
            this.radio_draw_mode.Location = new System.Drawing.Point(80, 61);
            this.radio_draw_mode.Name = "radio_draw_mode";
            this.radio_draw_mode.Size = new System.Drawing.Size(44, 17);
            this.radio_draw_mode.TabIndex = 55;
            this.radio_draw_mode.Text = "Pen";
            this.radio_draw_mode.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(14, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 13);
            this.label33.TabIndex = 54;
            this.label33.Text = "Draw Mode";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(287, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "mm";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(679, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 13);
            this.label32.TabIndex = 50;
            this.label32.Text = "mm/sec";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(287, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "mm";
            // 
            // zspeed
            // 
            this.zspeed.Location = new System.Drawing.Point(619, 59);
            this.zspeed.Name = "zspeed";
            this.zspeed.Size = new System.Drawing.Size(48, 20);
            this.zspeed.TabIndex = 49;
            // 
            // offsety
            // 
            this.offsety.Location = new System.Drawing.Point(233, 32);
            this.offsety.Name = "offsety";
            this.offsety.Size = new System.Drawing.Size(48, 20);
            this.offsety.TabIndex = 42;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(540, 64);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "Z Speed";
            // 
            // offsetx
            // 
            this.offsetx.Location = new System.Drawing.Point(233, 5);
            this.offsetx.Name = "offsetx";
            this.offsetx.Size = new System.Drawing.Size(48, 20);
            this.offsetx.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(183, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Offset Y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(183, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Offset X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bed Y";
            // 
            // beddepth
            // 
            this.beddepth.Location = new System.Drawing.Point(59, 33);
            this.beddepth.Name = "beddepth";
            this.beddepth.Size = new System.Drawing.Size(48, 20);
            this.beddepth.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bed X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "mm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(540, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Travel Speed";
            // 
            // bedwidth
            // 
            this.bedwidth.BackColor = System.Drawing.SystemColors.Window;
            this.bedwidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bedwidth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedwidth.Location = new System.Drawing.Point(59, 6);
            this.bedwidth.Name = "bedwidth";
            this.bedwidth.Size = new System.Drawing.Size(48, 20);
            this.bedwidth.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(540, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Draw Speed";
            // 
            // tspeed
            // 
            this.tspeed.Location = new System.Drawing.Point(619, 8);
            this.tspeed.Name = "tspeed";
            this.tspeed.Size = new System.Drawing.Size(48, 20);
            this.tspeed.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "mm/sec";
            // 
            // dspeed
            // 
            this.dspeed.Location = new System.Drawing.Point(619, 33);
            this.dspeed.Name = "dspeed";
            this.dspeed.Size = new System.Drawing.Size(48, 20);
            this.dspeed.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(679, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "mm/sec";
            // 
            // HandwritingModTab
            // 
            this.HandwritingModTab.Controls.Add(this.textSize_tb);
            this.HandwritingModTab.Controls.Add(this.label29);
            this.HandwritingModTab.Controls.Add(this.materialButton1);
            this.HandwritingModTab.Controls.Add(this.FontComboBox);
            this.HandwritingModTab.Controls.Add(this.label28);
            this.HandwritingModTab.Controls.Add(this.materialLabel1);
            this.HandwritingModTab.Controls.Add(this.label30);
            this.HandwritingModTab.Controls.Add(this.label34);
            this.HandwritingModTab.Controls.Add(this.rotCheckbox);
            this.HandwritingModTab.Controls.Add(this.randomLineSpacingCheckbox);
            this.HandwritingModTab.Controls.Add(this.lineGoingDownCheckbox);
            this.HandwritingModTab.Controls.Add(this.correctLettersCheckbox);
            this.HandwritingModTab.Controls.Add(this.sloppyCheckbox);
            this.HandwritingModTab.Controls.Add(this.checkBox2);
            this.HandwritingModTab.Controls.Add(this.connectLettersCheckBox);
            this.HandwritingModTab.Location = new System.Drawing.Point(4, 22);
            this.HandwritingModTab.Name = "HandwritingModTab";
            this.HandwritingModTab.Padding = new System.Windows.Forms.Padding(3);
            this.HandwritingModTab.Size = new System.Drawing.Size(1522, 58);
            this.HandwritingModTab.TabIndex = 1;
            this.HandwritingModTab.Text = "Modifiers & Font";
            this.HandwritingModTab.UseVisualStyleBackColor = true;
            // 
            // rotCheckbox
            // 
            this.rotCheckbox.AutoSize = true;
            this.rotCheckbox.Location = new System.Drawing.Point(322, 10);
            this.rotCheckbox.Name = "rotCheckbox";
            this.rotCheckbox.Size = new System.Drawing.Size(89, 17);
            this.rotCheckbox.TabIndex = 64;
            this.rotCheckbox.Text = "Rotate letters";
            this.rotCheckbox.UseVisualStyleBackColor = true;
            this.rotCheckbox.Click += new System.EventHandler(this.rotationCheckbox);
            // 
            // randomLineSpacingCheckbox
            // 
            this.randomLineSpacingCheckbox.AutoSize = true;
            this.randomLineSpacingCheckbox.Location = new System.Drawing.Point(163, 58);
            this.randomLineSpacingCheckbox.Name = "randomLineSpacingCheckbox";
            this.randomLineSpacingCheckbox.Size = new System.Drawing.Size(138, 17);
            this.randomLineSpacingCheckbox.TabIndex = 63;
            this.randomLineSpacingCheckbox.Text = "Randomize line spacing";
            this.randomLineSpacingCheckbox.UseVisualStyleBackColor = true;
            this.randomLineSpacingCheckbox.Click += new System.EventHandler(this.lineSpacingRandomizeCheckbox);
            // 
            // lineGoingDownCheckbox
            // 
            this.lineGoingDownCheckbox.AutoSize = true;
            this.lineGoingDownCheckbox.Location = new System.Drawing.Point(163, 35);
            this.lineGoingDownCheckbox.Name = "lineGoingDownCheckbox";
            this.lineGoingDownCheckbox.Size = new System.Drawing.Size(104, 17);
            this.lineGoingDownCheckbox.TabIndex = 62;
            this.lineGoingDownCheckbox.Text = "Line going down";
            this.lineGoingDownCheckbox.UseVisualStyleBackColor = true;
            this.lineGoingDownCheckbox.Click += new System.EventHandler(this.lineGoingDown);
            // 
            // correctLettersCheckbox
            // 
            this.correctLettersCheckbox.AutoSize = true;
            this.correctLettersCheckbox.Enabled = false;
            this.correctLettersCheckbox.Location = new System.Drawing.Point(164, 10);
            this.correctLettersCheckbox.Name = "correctLettersCheckbox";
            this.correctLettersCheckbox.Size = new System.Drawing.Size(103, 17);
            this.correctLettersCheckbox.TabIndex = 61;
            this.correctLettersCheckbox.Text = "Corrected letters";
            this.correctLettersCheckbox.UseVisualStyleBackColor = true;
            this.correctLettersCheckbox.Click += new System.EventHandler(this.letterCorrectionModifierCheckbox);
            // 
            // sloppyCheckbox
            // 
            this.sloppyCheckbox.AutoSize = true;
            this.sloppyCheckbox.Enabled = false;
            this.sloppyCheckbox.Location = new System.Drawing.Point(17, 58);
            this.sloppyCheckbox.Name = "sloppyCheckbox";
            this.sloppyCheckbox.Size = new System.Drawing.Size(88, 17);
            this.sloppyCheckbox.TabIndex = 60;
            this.sloppyCheckbox.Text = "Sloppy effect";
            this.sloppyCheckbox.UseVisualStyleBackColor = true;
            this.sloppyCheckbox.CheckedChanged += new System.EventHandler(this.sloppyCheckbox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 17);
            this.checkBox2.TabIndex = 59;
            this.checkBox2.Text = "Move letters randomly";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkbox2_move_letters_randomly);
            // 
            // connectLettersCheckBox
            // 
            this.connectLettersCheckBox.AutoSize = true;
            this.connectLettersCheckBox.Location = new System.Drawing.Point(17, 10);
            this.connectLettersCheckBox.Name = "connectLettersCheckBox";
            this.connectLettersCheckBox.Size = new System.Drawing.Size(97, 17);
            this.connectLettersCheckBox.TabIndex = 58;
            this.connectLettersCheckBox.Text = "Connect letters";
            this.connectLettersCheckBox.UseVisualStyleBackColor = true;
            this.connectLettersCheckBox.Click += new System.EventHandler(this.connectLettersCheckbox_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = false;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.DrawShadows = true;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(330, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate GCODE";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // topMenuTabSelector
            // 
            this.topMenuTabSelector.BaseTabControl = this.topMenuTabControl;
            this.topMenuTabSelector.Depth = 0;
            this.topMenuTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.topMenuTabSelector.Location = new System.Drawing.Point(0, 0);
            this.topMenuTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.topMenuTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMenuTabSelector.Name = "topMenuTabSelector";
            this.topMenuTabSelector.Size = new System.Drawing.Size(2093, 34);
            this.topMenuTabSelector.TabIndex = 0;
            this.topMenuTabSelector.Text = "materialTabSelector1";
            this.topMenuTabSelector.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = false;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(16, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 62;
            this.button1.Text = "Preview";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(794, 44);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(24, 13);
            this.label34.TabIndex = 68;
            this.label34.Text = "mm";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(825, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 13);
            this.label29.TabIndex = 70;
            this.label29.Text = "Letter Heading: 13mm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(825, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 13);
            this.label28.TabIndex = 69;
            this.label28.Text = "Letter Writing: 7.5mm";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(825, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 72;
            this.materialLabel1.Text = "Scaling guide:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(825, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 13);
            this.label30.TabIndex = 71;
            this.label30.Text = "Title: 18.5mm";
            // 
            // textSize_tb
            // 
            this.textSize_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSize_tb.Depth = 0;
            this.textSize_tb.Font = new System.Drawing.Font("Roboto", 12F);
            this.textSize_tb.Hint = "Font size";
            this.textSize_tb.Location = new System.Drawing.Point(691, 9);
            this.textSize_tb.MaxLength = 50;
            this.textSize_tb.MouseState = MaterialSkin.MouseState.OUT;
            this.textSize_tb.Multiline = false;
            this.textSize_tb.Name = "textSize_tb";
            this.textSize_tb.Size = new System.Drawing.Size(100, 50);
            this.textSize_tb.TabIndex = 73;
            this.textSize_tb.Text = "";
            this.textSize_tb.TextChanged += new System.EventHandler(this.textSize_tb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 671);
            this.Controls.Add(this.SimpleFontsCheckbox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "3DWriter by boy1dr | Handwriting edition forked by snow4dv ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.previewCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.topMenuTabControl.ResumeLayout(false);
            this.GCodeTab.ResumeLayout(false);
            this.GCodeTab.PerformLayout();
            this.HandwritingModTab.ResumeLayout(false);
            this.HandwritingModTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fontscale_value;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox FontComboBox;
        private MaterialSkin.Controls.MaterialCheckbox SimpleFontsCheckbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton previewScale2;
        private MaterialSkin.Controls.MaterialRadioButton previewScale4;
        private MaterialSkin.Controls.MaterialRadioButton previewScale1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard previewCard;
        private System.Windows.Forms.PictureBox pb_preview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about3DWriterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialButton menuButton;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialTabControl topMenuTabControl;
        private System.Windows.Forms.TabPage GCodeTab;
        private System.Windows.Forms.TabPage HandwritingModTab;
        private MaterialSkin.Controls.MaterialTabSelector topMenuTabSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bedwidth;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox zspeed;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tspeed;
        private System.Windows.Forms.TextBox dspeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_mode_up;
        private System.Windows.Forms.Label label_mode_down;
        private System.Windows.Forms.TextBox penup;
        private System.Windows.Forms.TextBox pendown;
        private System.Windows.Forms.Label label_mode_up_text;
        private System.Windows.Forms.Label label_mode_down_text;
        private System.Windows.Forms.RadioButton radio_laser_mode;
        private System.Windows.Forms.RadioButton radio_draw_mode;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox offsety;
        private System.Windows.Forms.TextBox offsetx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox beddepth;
        private System.Windows.Forms.CheckBox homez;
        private System.Windows.Forms.CheckBox homey;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox homex;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox dryrun;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox letspacing;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox lspacing;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox correctLettersCheckbox;
        private System.Windows.Forms.CheckBox sloppyCheckbox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox connectLettersCheckBox;
        private System.Windows.Forms.CheckBox rotCheckbox;
        private System.Windows.Forms.CheckBox randomLineSpacingCheckbox;
        private System.Windows.Forms.CheckBox lineGoingDownCheckbox;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialButton button1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private MaterialSkin.Controls.MaterialTextBox textSize_tb;
    }
}

