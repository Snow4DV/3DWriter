

namespace _3DWriter
{
    partial class FontEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontEditor));
            this.FontComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_save_as = new MaterialSkin.Controls.MaterialButton();
            this.lv_charmap = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_points = new MaterialSkin.Controls.MaterialListView();
            this.ch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_x1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_x2 = new MaterialSkin.Controls.MaterialTextBox();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.tb_width = new MaterialSkin.Controls.MaterialTextBox();
            this.button6 = new MaterialSkin.Controls.MaterialButton();
            this.button5 = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_char = new MaterialSkin.Controls.MaterialButton();
            this.tb_char_to_add = new MaterialSkin.Controls.MaterialTextBox();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.pb_editor = new System.Windows.Forms.PictureBox();
            this.button4 = new MaterialSkin.Controls.MaterialButton();
            this.button7 = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hq_checkbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tolerance_textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.outputPointsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PointsAmountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.drawCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.clearButton = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.FontComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.FontComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Hint = "Font";
            this.FontComboBox.IntegralHeight = false;
            this.FontComboBox.ItemHeight = 43;
            this.FontComboBox.Location = new System.Drawing.Point(9, 5);
            this.FontComboBox.MaxDropDownItems = 4;
            this.FontComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(118, 49);
            this.FontComboBox.TabIndex = 0;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // btn_save_as
            // 
            this.btn_save_as.AutoSize = false;
            this.btn_save_as.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_as.Depth = 0;
            this.btn_save_as.DrawShadows = true;
            this.btn_save_as.HighEmphasis = true;
            this.btn_save_as.Icon = null;
            this.btn_save_as.Location = new System.Drawing.Point(738, 370);
            this.btn_save_as.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save_as.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save_as.Name = "btn_save_as";
            this.btn_save_as.Size = new System.Drawing.Size(74, 35);
            this.btn_save_as.TabIndex = 3;
            this.btn_save_as.Text = "Save";
            this.btn_save_as.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save_as.UseAccentColor = false;
            this.btn_save_as.UseVisualStyleBackColor = true;
            this.btn_save_as.Click += new System.EventHandler(this.p);
            // 
            // lv_charmap
            // 
            this.lv_charmap.AutoSizeTable = false;
            this.lv_charmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_charmap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_charmap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_charmap.Depth = 0;
            this.lv_charmap.FullRowSelect = true;
            this.lv_charmap.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_charmap.HideSelection = false;
            this.lv_charmap.Location = new System.Drawing.Point(9, 59);
            this.lv_charmap.MinimumSize = new System.Drawing.Size(10, 10);
            this.lv_charmap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_charmap.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_charmap.MultiSelect = false;
            this.lv_charmap.Name = "lv_charmap";
            this.lv_charmap.OwnerDraw = true;
            this.lv_charmap.ShowGroups = false;
            this.lv_charmap.Size = new System.Drawing.Size(118, 315);
            this.lv_charmap.TabIndex = 5;
            this.lv_charmap.UseCompatibleStateImageBehavior = false;
            this.lv_charmap.View = System.Windows.Forms.View.Details;
            this.lv_charmap.SelectedIndexChanged += new System.EventHandler(this.lv_charmap_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 120;
            // 
            // lv_points
            // 
            this.lv_points.AutoSizeTable = false;
            this.lv_points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_points.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_points.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch});
            this.lv_points.Depth = 0;
            this.lv_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_points.FullRowSelect = true;
            this.lv_points.HideSelection = false;
            this.lv_points.Location = new System.Drawing.Point(517, 5);
            this.lv_points.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lv_points.MinimumSize = new System.Drawing.Size(10, 10);
            this.lv_points.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_points.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_points.MultiSelect = false;
            this.lv_points.Name = "lv_points";
            this.lv_points.OwnerDraw = true;
            this.lv_points.Size = new System.Drawing.Size(135, 376);
            this.lv_points.TabIndex = 10;
            this.lv_points.UseCompatibleStateImageBehavior = false;
            this.lv_points.View = System.Windows.Forms.View.Details;
            this.lv_points.SelectedIndexChanged += new System.EventHandler(this.lv_points_SelectedIndexChanged);
            // 
            // ch
            // 
            this.ch.Text = "Points";
            this.ch.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(663, 94);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Line Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(662, 179);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Line End";
            // 
            // tb_x1
            // 
            this.tb_x1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_x1.Depth = 0;
            this.tb_x1.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_x1.Hint = "X1,Y1";
            this.tb_x1.Location = new System.Drawing.Point(735, 92);
            this.tb_x1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_x1.MaxLength = 50;
            this.tb_x1.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_x1.Multiline = false;
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(77, 50);
            this.tb_x1.TabIndex = 14;
            this.tb_x1.Text = "";
            // 
            // tb_x2
            // 
            this.tb_x2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_x2.Depth = 0;
            this.tb_x2.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_x2.Hint = "X2,Y2";
            this.tb_x2.Location = new System.Drawing.Point(735, 148);
            this.tb_x2.Margin = new System.Windows.Forms.Padding(1);
            this.tb_x2.MaxLength = 50;
            this.tb_x2.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_x2.Multiline = false;
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(77, 50);
            this.tb_x2.TabIndex = 18;
            this.tb_x2.Text = "";
            // 
            // button3
            // 
            this.button3.AutoSize = false;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Depth = 0;
            this.button3.DrawShadows = true;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(661, 119);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 54);
            this.button3.TabIndex = 23;
            this.button3.Text = "Set";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.setButton_Click);
            // 
            // tb_width
            // 
            this.tb_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_width.Depth = 0;
            this.tb_width.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_width.Hint = "Width";
            this.tb_width.Location = new System.Drawing.Point(664, 5);
            this.tb_width.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.tb_width.MaxLength = 20;
            this.tb_width.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_width.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_width.Multiline = false;
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(148, 50);
            this.tb_width.TabIndex = 27;
            this.tb_width.Text = "";
            // 
            // button6
            // 
            this.button6.AutoSize = false;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Depth = 0;
            this.button6.DrawShadows = true;
            this.button6.HighEmphasis = true;
            this.button6.Icon = null;
            this.button6.Location = new System.Drawing.Point(661, 205);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button6.MouseState = MaterialSkin.MouseState.HOVER;
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 36);
            this.button6.TabIndex = 28;
            this.button6.Text = "Update";
            this.button6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button6.UseAccentColor = false;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // button5
            // 
            this.button5.AutoSize = false;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Depth = 0;
            this.button5.DrawShadows = true;
            this.button5.HighEmphasis = true;
            this.button5.Icon = null;
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button5.MouseState = MaterialSkin.MouseState.HOVER;
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "+";
            this.button5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button5.UseAccentColor = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddSegment_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // btn_add_char
            // 
            this.btn_add_char.AutoSize = false;
            this.btn_add_char.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_char.Depth = 0;
            this.btn_add_char.DrawShadows = true;
            this.btn_add_char.HighEmphasis = true;
            this.btn_add_char.Icon = null;
            this.btn_add_char.Location = new System.Drawing.Point(84, 6);
            this.btn_add_char.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_char.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_char.Name = "btn_add_char";
            this.btn_add_char.Size = new System.Drawing.Size(30, 19);
            this.btn_add_char.TabIndex = 30;
            this.btn_add_char.Text = "+";
            this.btn_add_char.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_char.UseAccentColor = false;
            this.btn_add_char.UseVisualStyleBackColor = true;
            this.btn_add_char.Click += new System.EventHandler(this.btn_add_char_Click);
            this.btn_add_char.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // tb_char_to_add
            // 
            this.tb_char_to_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_char_to_add.Depth = 0;
            this.tb_char_to_add.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_char_to_add.Location = new System.Drawing.Point(0, 5);
            this.tb_char_to_add.Margin = new System.Windows.Forms.Padding(0);
            this.tb_char_to_add.MaximumSize = new System.Drawing.Size(500, 500);
            this.tb_char_to_add.MaxLength = 50;
            this.tb_char_to_add.MinimumSize = new System.Drawing.Size(10, 10);
            this.tb_char_to_add.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_char_to_add.Multiline = false;
            this.tb_char_to_add.Name = "tb_char_to_add";
            this.tb_char_to_add.Size = new System.Drawing.Size(80, 50);
            this.tb_char_to_add.TabIndex = 31;
            this.tb_char_to_add.Text = "";
            // 
            // button2
            // 
            this.button2.AutoSize = false;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.DrawShadows = true;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(105, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "-";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteSegment_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // pb_editor
            // 
            this.pb_editor.Image = global::_3DWriter.Properties.Resources.red_grid;
            this.pb_editor.Location = new System.Drawing.Point(135, 5);
            this.pb_editor.Name = "pb_editor";
            this.pb_editor.Size = new System.Drawing.Size(400, 400);
            this.pb_editor.TabIndex = 25;
            this.pb_editor.TabStop = false;
            this.pb_editor.Click += new System.EventHandler(this.picture_box_click);
            this.pb_editor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Draw_MouseDown);
            this.pb_editor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Draw_MouseMove);
            this.pb_editor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Draw_MouseUp);
            // 
            // button4
            // 
            this.button4.AutoSize = false;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Depth = 0;
            this.button4.DrawShadows = true;
            this.button4.HighEmphasis = true;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(735, 207);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.MinimumSize = new System.Drawing.Size(10, 10);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 34);
            this.button4.TabIndex = 33;
            this.button4.Text = "Transp";
            this.button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button4.UseAccentColor = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.switch_transparency);
            // 
            // button7
            // 
            this.button7.AutoSize = false;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Depth = 0;
            this.button7.DrawShadows = true;
            this.button7.HighEmphasis = true;
            this.button7.Icon = null;
            this.button7.Location = new System.Drawing.Point(665, 58);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button7.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.button7.MinimumSize = new System.Drawing.Size(1, 1);
            this.button7.MouseState = MaterialSkin.MouseState.HOVER;
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 30);
            this.button7.TabIndex = 34;
            this.button7.Text = "Size x5";
            this.button7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button7.UseAccentColor = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.scaleFontBy5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(517, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 55);
            this.panel1.TabIndex = 35;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(71, 3);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(30, 36);
            this.materialButton2.TabIndex = 34;
            this.materialButton2.Text = "out";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.add_output);
            this.materialButton2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(35, 3);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(30, 36);
            this.materialButton1.TabIndex = 33;
            this.materialButton1.Text = "IN";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.add_input);
            this.materialButton1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialButton4);
            this.panel2.Controls.Add(this.tb_char_to_add);
            this.panel2.Controls.Add(this.btn_add_char);
            this.panel2.Location = new System.Drawing.Point(9, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 55);
            this.panel2.TabIndex = 36;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(84, 31);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(30, 19);
            this.materialButton4.TabIndex = 32;
            this.materialButton4.Text = "-";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hq_checkbox);
            this.panel3.Controls.Add(this.tolerance_textbox);
            this.panel3.Controls.Add(this.outputPointsLabel);
            this.panel3.Controls.Add(this.PointsAmountLabel);
            this.panel3.Controls.Add(this.drawCheckbox);
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.materialButton3);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.FontComboBox);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.tb_width);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.tb_x2);
            this.panel3.Controls.Add(this.tb_x1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lv_charmap);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btn_save_as);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lv_points);
            this.panel3.Controls.Add(this.pb_editor);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 419);
            this.panel3.TabIndex = 37;
            // 
            // hq_checkbox
            // 
            this.hq_checkbox.Depth = 0;
            this.hq_checkbox.Location = new System.Drawing.Point(733, 337);
            this.hq_checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.hq_checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hq_checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hq_checkbox.Name = "hq_checkbox";
            this.hq_checkbox.Ripple = true;
            this.hq_checkbox.Size = new System.Drawing.Size(79, 30);
            this.hq_checkbox.TabIndex = 42;
            this.hq_checkbox.Text = "HQ";
            this.hq_checkbox.UseVisualStyleBackColor = true;
            // 
            // tolerance_textbox
            // 
            this.tolerance_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tolerance_textbox.Depth = 0;
            this.tolerance_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tolerance_textbox.Hint = "Draw tolerance";
            this.tolerance_textbox.Location = new System.Drawing.Point(661, 248);
            this.tolerance_textbox.MaxLength = 50;
            this.tolerance_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.tolerance_textbox.Multiline = false;
            this.tolerance_textbox.Name = "tolerance_textbox";
            this.tolerance_textbox.Size = new System.Drawing.Size(153, 50);
            this.tolerance_textbox.TabIndex = 41;
            this.tolerance_textbox.Text = "1";
            // 
            // outputPointsLabel
            // 
            this.outputPointsLabel.Depth = 0;
            this.outputPointsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.outputPointsLabel.Location = new System.Drawing.Point(663, 319);
            this.outputPointsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.outputPointsLabel.Name = "outputPointsLabel";
            this.outputPointsLabel.Size = new System.Drawing.Size(151, 19);
            this.outputPointsLabel.TabIndex = 40;
            this.outputPointsLabel.Text = "Output points: 0";
            // 
            // PointsAmountLabel
            // 
            this.PointsAmountLabel.Depth = 0;
            this.PointsAmountLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PointsAmountLabel.Location = new System.Drawing.Point(663, 300);
            this.PointsAmountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PointsAmountLabel.Name = "PointsAmountLabel";
            this.PointsAmountLabel.Size = new System.Drawing.Size(149, 23);
            this.PointsAmountLabel.TabIndex = 39;
            this.PointsAmountLabel.Text = "Points: 0";
            // 
            // drawCheckbox
            // 
            this.drawCheckbox.Checked = true;
            this.drawCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawCheckbox.Depth = 0;
            this.drawCheckbox.Location = new System.Drawing.Point(655, 337);
            this.drawCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.drawCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.drawCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.drawCheckbox.Name = "drawCheckbox";
            this.drawCheckbox.Ripple = true;
            this.drawCheckbox.Size = new System.Drawing.Size(75, 30);
            this.drawCheckbox.TabIndex = 38;
            this.drawCheckbox.Text = "Draw";
            this.drawCheckbox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = false;
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.Depth = 0;
            this.clearButton.DrawShadows = true;
            this.clearButton.HighEmphasis = true;
            this.clearButton.Icon = null;
            this.clearButton.Location = new System.Drawing.Point(659, 370);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(71, 36);
            this.clearButton.TabIndex = 35;
            this.clearButton.Text = "Clear";
            this.clearButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearButton.UseAccentColor = false;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(664, 58);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.materialButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(148, 30);
            this.materialButton3.TabIndex = 37;
            this.materialButton3.Text = "Del Gap";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.remove_gaps);
            // 
            // FontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 479);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontEditor";
            this.Text = "FontEditor";
            this.Load += new System.EventHandler(this.FontEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox FontComboBox;
        private MaterialSkin.Controls.MaterialButton btn_save_as;
        private MaterialSkin.Controls.MaterialListView lv_charmap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialListView lv_points;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialTextBox tb_x1;
        private MaterialSkin.Controls.MaterialTextBox tb_x2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialTextBox tb_width;
        private MaterialSkin.Controls.MaterialButton button6;
        private MaterialSkin.Controls.MaterialButton button5;
        private MaterialSkin.Controls.MaterialButton btn_add_char;
        private MaterialSkin.Controls.MaterialTextBox tb_char_to_add;
        private MaterialSkin.Controls.MaterialButton button2;
        private System.Windows.Forms.PictureBox pb_editor;
        private MaterialSkin.Controls.MaterialButton button4;
        private MaterialSkin.Controls.MaterialButton button7;
        private System.Windows.Forms.ColumnHeader ch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton clearButton;
        private MaterialSkin.Controls.MaterialCheckbox drawCheckbox;
        private MaterialSkin.Controls.MaterialLabel PointsAmountLabel;
        private MaterialSkin.Controls.MaterialLabel outputPointsLabel;
        private MaterialSkin.Controls.MaterialCheckbox hq_checkbox;
        private MaterialSkin.Controls.MaterialTextBox tolerance_textbox;
    }
}