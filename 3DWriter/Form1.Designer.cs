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
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
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
            this.differentSizeCheckbox = new System.Windows.Forms.CheckBox();
            this.textSize_tb = new MaterialSkin.Controls.MaterialTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.rotCheckbox = new System.Windows.Forms.CheckBox();
            this.randomLineSpacingCheckbox = new System.Windows.Forms.CheckBox();
            this.lineGoingDownCheckbox = new System.Windows.Forms.CheckBox();
            this.correctLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.sloppyCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.connectLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.topMenuTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
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
            resources.ApplyResources(this.fontscale_value, "fontscale_value");
            this.fontscale_value.Name = "fontscale_value";
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FontComboBox
            // 
            resources.ApplyResources(this.FontComboBox, "FontComboBox");
            this.FontComboBox.AutoResize = false;
            this.FontComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FontComboBox.Depth = 0;
            this.FontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FontComboBox.DropDownHeight = 174;
            this.FontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontComboBox.DropDownWidth = 121;
            this.FontComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Hint = "Шрифт";
            this.FontComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // SimpleFontsCheckbox
            // 
            resources.ApplyResources(this.SimpleFontsCheckbox, "SimpleFontsCheckbox");
            this.SimpleFontsCheckbox.Depth = 0;
            this.SimpleFontsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SimpleFontsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SimpleFontsCheckbox.Name = "SimpleFontsCheckbox";
            this.SimpleFontsCheckbox.Ripple = true;
            this.SimpleFontsCheckbox.UseVisualStyleBackColor = true;
            this.SimpleFontsCheckbox.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // previewScale2
            // 
            resources.ApplyResources(this.previewScale2, "previewScale2");
            this.previewScale2.Depth = 0;
            this.previewScale2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale2.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale2.Name = "previewScale2";
            this.previewScale2.Ripple = true;
            this.previewScale2.TabStop = true;
            this.previewScale2.UseVisualStyleBackColor = true;
            this.previewScale2.Click += new System.EventHandler(this.preview_mag2_Click);
            // 
            // previewScale4
            // 
            resources.ApplyResources(this.previewScale4, "previewScale4");
            this.previewScale4.Depth = 0;
            this.previewScale4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale4.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale4.Name = "previewScale4";
            this.previewScale4.Ripple = true;
            this.previewScale4.TabStop = true;
            this.previewScale4.UseVisualStyleBackColor = true;
            this.previewScale4.Click += new System.EventHandler(this.preview_mag4_Click);
            // 
            // previewScale1
            // 
            resources.ApplyResources(this.previewScale1, "previewScale1");
            this.previewScale1.Depth = 0;
            this.previewScale1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.previewScale1.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewScale1.Name = "previewScale1";
            this.previewScale1.Ripple = true;
            this.previewScale1.TabStop = true;
            this.previewScale1.UseVisualStyleBackColor = true;
            this.previewScale1.Click += new System.EventHandler(this.preview_mag1_Click);
            // 
            // tb_input
            // 
            resources.ApplyResources(this.tb_input, "tb_input");
            this.tb_input.BackColor = System.Drawing.Color.White;
            this.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_input.Name = "tb_input";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.fontscale_value);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.previewScale4);
            this.panel4.Controls.Add(this.previewScale2);
            this.panel4.Controls.Add(this.previewScale1);
            this.panel4.Controls.Add(this.previewCard);
            this.panel4.Controls.Add(this.materialLabel2);
            this.panel4.Name = "panel4";
            // 
            // previewCard
            // 
            resources.ApplyResources(this.previewCard, "previewCard");
            this.previewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewCard.Controls.Add(this.pb_preview);
            this.previewCard.Depth = 0;
            this.previewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.previewCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewCard.Name = "previewCard";
            // 
            // pb_preview
            // 
            resources.ApplyResources(this.pb_preview, "pb_preview");
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.TabStop = false;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.materialCard2);
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Depth = 0;
            this.button2.DrawShadows = true;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialCard2
            // 
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tb_input);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // materialContextMenuStrip1
            // 
            resources.ApplyResources(this.materialContextMenuStrip1, "materialContextMenuStrip1");
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
            // 
            // resetDefaultsToolStripMenuItem1
            // 
            resources.ApplyResources(this.resetDefaultsToolStripMenuItem1, "resetDefaultsToolStripMenuItem1");
            this.resetDefaultsToolStripMenuItem1.Name = "resetDefaultsToolStripMenuItem1";
            this.resetDefaultsToolStripMenuItem1.Click += new System.EventHandler(this.resetDefaultsToolStripMenuItem_Click);
            // 
            // fontEditorToolStripMenuItem
            // 
            resources.ApplyResources(this.fontEditorToolStripMenuItem, "fontEditorToolStripMenuItem");
            this.fontEditorToolStripMenuItem.Name = "fontEditorToolStripMenuItem";
            this.fontEditorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // wikiToolStripMenuItem
            // 
            resources.ApplyResources(this.wikiToolStripMenuItem, "wikiToolStripMenuItem");
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // about3DWriterToolStripMenuItem
            // 
            resources.ApplyResources(this.about3DWriterToolStripMenuItem, "about3DWriterToolStripMenuItem");
            this.about3DWriterToolStripMenuItem.Name = "about3DWriterToolStripMenuItem";
            this.about3DWriterToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.menuButton);
            this.panel5.Name = "panel5";
            // 
            // menuButton
            // 
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Depth = 0;
            this.menuButton.DrawShadows = true;
            this.menuButton.HighEmphasis = true;
            this.menuButton.Icon = ((System.Drawing.Image)(resources.GetObject("menuButton.Icon")));
            this.menuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuButton.Name = "menuButton";
            this.menuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.menuButton.UseAccentColor = false;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuClick);
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.topMenuTabControl);
            this.panel6.Controls.Add(this.topMenuTabSelector);
            this.panel6.Name = "panel6";
            // 
            // topMenuTabControl
            // 
            resources.ApplyResources(this.topMenuTabControl, "topMenuTabControl");
            this.topMenuTabControl.Controls.Add(this.GCodeTab);
            this.topMenuTabControl.Controls.Add(this.HandwritingModTab);
            this.topMenuTabControl.Depth = 0;
            this.topMenuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMenuTabControl.Multiline = true;
            this.topMenuTabControl.Name = "topMenuTabControl";
            this.topMenuTabControl.SelectedIndex = 0;
            // 
            // GCodeTab
            // 
            resources.ApplyResources(this.GCodeTab, "GCodeTab");
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
            this.GCodeTab.Name = "GCodeTab";
            this.GCodeTab.UseVisualStyleBackColor = true;
            // 
            // homez
            // 
            resources.ApplyResources(this.homez, "homez");
            this.homez.Name = "homez";
            this.homez.UseVisualStyleBackColor = true;
            // 
            // homey
            // 
            resources.ApplyResources(this.homey, "homey");
            this.homey.Name = "homey";
            this.homey.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // homex
            // 
            resources.ApplyResources(this.homex, "homex");
            this.homex.Name = "homex";
            this.homex.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // dryrun
            // 
            resources.ApplyResources(this.dryrun, "dryrun");
            this.dryrun.Name = "dryrun";
            this.dryrun.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // letspacing
            // 
            resources.ApplyResources(this.letspacing, "letspacing");
            this.letspacing.Name = "letspacing";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // lspacing
            // 
            resources.ApplyResources(this.lspacing, "lspacing");
            this.lspacing.Name = "lspacing";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label_mode_up
            // 
            resources.ApplyResources(this.label_mode_up, "label_mode_up");
            this.label_mode_up.Name = "label_mode_up";
            // 
            // label_mode_down
            // 
            resources.ApplyResources(this.label_mode_down, "label_mode_down");
            this.label_mode_down.Name = "label_mode_down";
            // 
            // penup
            // 
            resources.ApplyResources(this.penup, "penup");
            this.penup.BackColor = System.Drawing.Color.White;
            this.penup.Name = "penup";
            // 
            // pendown
            // 
            resources.ApplyResources(this.pendown, "pendown");
            this.pendown.Name = "pendown";
            // 
            // label_mode_up_text
            // 
            resources.ApplyResources(this.label_mode_up_text, "label_mode_up_text");
            this.label_mode_up_text.Name = "label_mode_up_text";
            // 
            // label_mode_down_text
            // 
            resources.ApplyResources(this.label_mode_down_text, "label_mode_down_text");
            this.label_mode_down_text.Name = "label_mode_down_text";
            // 
            // radio_laser_mode
            // 
            resources.ApplyResources(this.radio_laser_mode, "radio_laser_mode");
            this.radio_laser_mode.Name = "radio_laser_mode";
            this.radio_laser_mode.TabStop = true;
            this.radio_laser_mode.UseVisualStyleBackColor = true;
            // 
            // radio_draw_mode
            // 
            resources.ApplyResources(this.radio_draw_mode, "radio_draw_mode");
            this.radio_draw_mode.Name = "radio_draw_mode";
            this.radio_draw_mode.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // zspeed
            // 
            resources.ApplyResources(this.zspeed, "zspeed");
            this.zspeed.Name = "zspeed";
            // 
            // offsety
            // 
            resources.ApplyResources(this.offsety, "offsety");
            this.offsety.Name = "offsety";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // offsetx
            // 
            resources.ApplyResources(this.offsetx, "offsetx");
            this.offsetx.Name = "offsetx";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // beddepth
            // 
            resources.ApplyResources(this.beddepth, "beddepth");
            this.beddepth.Name = "beddepth";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // bedwidth
            // 
            resources.ApplyResources(this.bedwidth, "bedwidth");
            this.bedwidth.BackColor = System.Drawing.SystemColors.Window;
            this.bedwidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bedwidth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedwidth.Name = "bedwidth";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // tspeed
            // 
            resources.ApplyResources(this.tspeed, "tspeed");
            this.tspeed.Name = "tspeed";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // dspeed
            // 
            resources.ApplyResources(this.dspeed, "dspeed");
            this.dspeed.Name = "dspeed";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // HandwritingModTab
            // 
            resources.ApplyResources(this.HandwritingModTab, "HandwritingModTab");
            this.HandwritingModTab.Controls.Add(this.differentSizeCheckbox);
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
            this.HandwritingModTab.Name = "HandwritingModTab";
            this.HandwritingModTab.UseVisualStyleBackColor = true;
            // 
            // differentSizeCheckbox
            // 
            resources.ApplyResources(this.differentSizeCheckbox, "differentSizeCheckbox");
            this.differentSizeCheckbox.Name = "differentSizeCheckbox";
            this.differentSizeCheckbox.UseVisualStyleBackColor = true;
            this.differentSizeCheckbox.Click += new System.EventHandler(this.differentSizeCheckbox_Click);
            // 
            // textSize_tb
            // 
            resources.ApplyResources(this.textSize_tb, "textSize_tb");
            this.textSize_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSize_tb.Depth = 0;
            this.textSize_tb.Hint = "Размер";
            this.textSize_tb.MouseState = MaterialSkin.MouseState.OUT;
            this.textSize_tb.Name = "textSize_tb";
            this.textSize_tb.TextChanged += new System.EventHandler(this.textSize_tb_TextChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // rotCheckbox
            // 
            resources.ApplyResources(this.rotCheckbox, "rotCheckbox");
            this.rotCheckbox.Name = "rotCheckbox";
            this.rotCheckbox.UseVisualStyleBackColor = true;
            this.rotCheckbox.Click += new System.EventHandler(this.rotationCheckbox);
            // 
            // randomLineSpacingCheckbox
            // 
            resources.ApplyResources(this.randomLineSpacingCheckbox, "randomLineSpacingCheckbox");
            this.randomLineSpacingCheckbox.Name = "randomLineSpacingCheckbox";
            this.randomLineSpacingCheckbox.UseVisualStyleBackColor = true;
            this.randomLineSpacingCheckbox.Click += new System.EventHandler(this.lineSpacingRandomizeCheckbox);
            // 
            // lineGoingDownCheckbox
            // 
            resources.ApplyResources(this.lineGoingDownCheckbox, "lineGoingDownCheckbox");
            this.lineGoingDownCheckbox.Name = "lineGoingDownCheckbox";
            this.lineGoingDownCheckbox.UseVisualStyleBackColor = true;
            this.lineGoingDownCheckbox.Click += new System.EventHandler(this.lineGoingDown);
            // 
            // correctLettersCheckbox
            // 
            resources.ApplyResources(this.correctLettersCheckbox, "correctLettersCheckbox");
            this.correctLettersCheckbox.Name = "correctLettersCheckbox";
            this.correctLettersCheckbox.UseVisualStyleBackColor = true;
            this.correctLettersCheckbox.Click += new System.EventHandler(this.letterCorrectionModifierCheckbox);
            // 
            // sloppyCheckbox
            // 
            resources.ApplyResources(this.sloppyCheckbox, "sloppyCheckbox");
            this.sloppyCheckbox.Name = "sloppyCheckbox";
            this.sloppyCheckbox.UseVisualStyleBackColor = true;
            this.sloppyCheckbox.CheckedChanged += new System.EventHandler(this.sloppyCheckbox_CheckedChanged);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkbox2_move_letters_randomly);
            // 
            // connectLettersCheckBox
            // 
            resources.ApplyResources(this.connectLettersCheckBox, "connectLettersCheckBox");
            this.connectLettersCheckBox.Name = "connectLettersCheckBox";
            this.connectLettersCheckBox.UseVisualStyleBackColor = true;
            this.connectLettersCheckBox.Click += new System.EventHandler(this.connectLettersCheckbox_Click);
            // 
            // topMenuTabSelector
            // 
            resources.ApplyResources(this.topMenuTabSelector, "topMenuTabSelector");
            this.topMenuTabSelector.BaseTabControl = this.topMenuTabControl;
            this.topMenuTabSelector.Depth = 0;
            this.topMenuTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMenuTabSelector.Name = "topMenuTabSelector";
            this.topMenuTabSelector.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SimpleFontsCheckbox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.CheckBox differentSizeCheckbox;
    }
}

