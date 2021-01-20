/*
 * 3DWriter - Chris Mitchell 2017 - Apache 2.0 License
 */
//Redesign and remake by snow4dv 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;

namespace _3DWriter
{
    public partial class Form1 : MaterialForm
    {
        double minUnitsLineSpacingRandomize = -1; //Units range randomizing the line spacing
        double maxUnitsLineSpacingRandomize = -1;
        String moveCoordSettings = "-1,-1"; //Random moving string range
        double lineGoingDownCoefficient = 0;
        double symbolSizeRandomizer = -1; //-1 means disabled
        double h_height;                                        //font character height
        double h_char_count;                                    //font character count
        string h_font_map;                                      //font map - Character index array
        int rendercount = 0;                                    //count the renders
        private static CultureInfo ci = CultureInfo.InstalledUICulture;

        double[][] font_chars = new double[2000][];              //the main font array
        string last_filename = "";
        bool appfault = false;
        int preview_mag = 2;
        bool shouldBeRotated = false;
        int minRotate, maxRotate;
        double incorrectLetterChance = 0.0;
        public void load_font(string fname)
        {
            int counter = 0;
            string line;

            int charcount = 0;
            // toolStripStatusLabel1.Text = "Loading font - " + fname;//TODO OR RM
            try
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader("fonts" + Path.DirectorySeparatorChar + fname + ".cmf");
                while ((line = file.ReadLine()) != null)                                    // iterate through the font file
                {
                    if (counter == 0) { Double.TryParse(line, out h_char_count); }          //first line: Character count
                    if (counter == 1) { Double.TryParse(line, out h_height); }              //second line: Character height
                    if (counter == 2) { h_font_map = line; }                                //third line: Character map
                    if (counter > 2)
                    {
                        //each line consists of width, realwidth, arraysize, [x/y pairs]    //arraysize is unused   //??
                        string[] temparray = line.Split(',');
                        font_chars[charcount] = new double[temparray.Length];
                        for (int idx = 0; idx < temparray.Length; idx++)
                        {
                            Double.TryParse(temparray[idx], out font_chars[charcount][idx]);
                        }
                        charcount++;
                    }
                    counter++;
                }
                file.Close();
                update_font_size();
            }
            catch (FileNotFoundException exeption)
            {
                MaterialMessageBox.Show("Error! Font called " + fname + " that you previously selected was not found. Select another one.");
            }
        }

        public void load_font_old(string fname)
        {
            using (System.IO.StreamWriter filewriter =
               new System.IO.StreamWriter(@"fonts" + Path.DirectorySeparatorChar + fname + ".cmf"))
            {
                //reads the font file as text. these are written in c++, i'm just reading them in to an array to use in the render function.
                //if you think this is ugly, wait till you see the render function :P
                int counter = 0;
                string line;
                bool comment = false;
                bool array_active = false;
                string array_text = "";
                bool commit = false;
                bool stop_read = false;

                double c_width = 0;                                 //temporary storage of character width. line array index #0             ///not used - i used realwidth instead
                double c_realwidth = 0;                             //temporary storage of character real width. line array index #1
                double c_size = 0;                                  //temporary storage of character size. line array index #2

                int charcount = 0;
                // toolStripStatusLabel1.Text = "Loading font - " + fname; TODO OR REMOVE
                System.IO.StreamReader file =
                new System.IO.StreamReader("fonts" + Path.DirectorySeparatorChar + fname + ".h");
                while ((line = file.ReadLine()) != null)            // iterate through the font file
                {
                    if (!stop_read)
                    {
                        line = line.Trim();
                        if (line != "" && line.Substring(0, 2) != "//" && (" " + line).IndexOf("/*") > 0) { comment = true; }
                        if (line != "" && line.Substring(0, 2) != "//" && (" " + line).IndexOf("*/") > 0) { comment = false; }
                        if (line != "" && line.Substring(0, 2) != "//" && !comment)
                        {
                            //This loop plucks out relevant chunks of data from each line
                            if ((" " + line).IndexOf("{") > 0) { array_active = true; }                 //start curly brace - start of stroke x/y pair array
                            if ((" " + line).IndexOf("}") > 0) { array_active = false; commit = true; } //end curly brace - end of stroke x/y pair array
                            if (commit)
                            {
                                //we have all the data for 1 character, time to commit it to the main font character array 
                                string[] temparray = array_text.Split(',');
                                font_chars[charcount] = new double[Convert.ToInt32(c_size + 3)];
                                font_chars[charcount][0] = c_width;
                                font_chars[charcount][1] = c_realwidth;
                                font_chars[charcount][2] = c_size;
                                for (int aa = 0; aa < temparray.Length; aa++)
                                {
                                    font_chars[charcount][aa + 3] = Convert.ToSingle(temparray[aa]);
                                }
                                commit = false;
                                array_text = "";
                                charcount++;
                            }
                            if (array_active)
                            {
                                if (array_text == "")
                                {
                                    line = line.Substring(line.IndexOf("{") + 1);                       //start of array - start store the data
                                }
                                array_text += line.Replace(" ", "");                                    //clean it up
                            }

                            if (!commit && !array_active)
                            {
                                if ((" " + line).IndexOf("_width") > 0) { c_width = Convert.ToSingle((line.Substring(line.IndexOf("_width") + 8)).Replace(";", "")); }                      //nasty
                                if ((" " + line).IndexOf("_realwidth") > 0) { c_realwidth = Convert.ToSingle((line.Substring(line.IndexOf("_realwidth") + 12)).Replace(";", "")); }         //nasty
                                if ((" " + line).IndexOf("_size") > 0) { c_size = Convert.ToSingle((line.Substring(line.IndexOf("_size") + 7)).Replace(";", "")); }                         //nasty
                                if ((" " + line).IndexOf("_count") > 0) { h_char_count = Convert.ToSingle((line.Substring(line.IndexOf("_count") + 8)).Replace(";", "")); }                 //nasty
                                if ((" " + line).IndexOf("_height") > 0)
                                {
                                    h_height = Convert.ToSingle((line.Substring(line.IndexOf("_height") + 9)).Replace(";", ""));                                                            //nasty
                                    stop_read = true;
                                }
                            }
                        }
                    }
                    counter++;
                }
                file.Close();
                update_font_size();

                //TMP font write cmf file
                //filewriter.WriteLine(line);
                filewriter.WriteLine(h_char_count);
                filewriter.WriteLine(h_height);
                filewriter.WriteLine(" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~");
                for (int tmpa = 0; tmpa < charcount; tmpa++)
                {

                    filewriter.WriteLine(string.Join(",", font_chars[tmpa]));
                }

            }
        }

        private void update_font_size()
        {
            //toolStripStatusLabel1.Text = "Font: " + FontComboBox.Text;  TODO OR REMOVE
            // toolStripStatusLabel2.Text = "Font Height: " + h_height + " Units";   TODO OR REMOVE
            //textSize_tb.Text = (h_height * double.Parse(fontscale_value.Text)).ToString();
        }

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            panel5.BackColor = ColorTranslator.FromHtml("#37474F");



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuClick(object sender, EventArgs e)
        {
            materialContextMenuStrip1.Show(Cursor.Position);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("fonts" + Path.DirectorySeparatorChar + "scriptc.cmf"))        //check for fonts folder
            {
                if (ci.TwoLetterISOLanguageName != "ru")
                {
                    MaterialMessageBox.Show("Unable to find the fonts folder in the application folder.");
                }
                else
                {
                    MaterialMessageBox.Show("В папке с программой отсутствует папка со шрифтами \"fonts\"");
                }
                appfault = true;
                Application.Exit();
            }
            else
            {
                LoadSettings(); //reads the application settings and fills in all the UI components
                LoadFonts(SimpleFontsCheckbox.Checked);    //fills in the font selection combobox
                if (Properties.Settings.Default.default_font != "") load_font(Properties.Settings.Default.default_font);    //reads the selected font file in to memory
            }
            menuButton.BackColor = Color.Transparent;
            CheckVersion(0);

        }

        void CheckVersion(int notify) //REDO
        {
            try
            {
                //read the version file from github
                Random random = new Random();
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/Snow4DV/3DWriter/master/3DWriter/version.txt?random=" + random.Next());
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd().Trim('\n');
                if (content != "" && !Application.ProductVersion.ToString().Equals(content))
                {
                    string msgBoxString = "Open github page? Current version is \"" + Application.ProductVersion.ToString() + "\"";
                    string msgBoxTitleString = "Update available - \"" + content + "\"";
                    if (ci.TwoLetterISOLanguageName == "ru") msgBoxString = "Открыть страницу проекта? Текущая версия - \"" + Application.ProductVersion.ToString() + "\"";
                    if(ci.TwoLetterISOLanguageName == "ru") msgBoxTitleString = "Доступно обновление - \"" + content + "\"";
                    DialogResult dialogResult = MaterialMessageBox.Show(msgBoxString, msgBoxTitleString, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/Snow4DV/3DWriter");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
                else
                {
                    if (notify == 1 && Application.ProductVersion.ToString() == content)
                    {
                        if(ci.TwoLetterISOLanguageName != "ru") MessageBox.Show("You are running the current version\n" + Application.ProductVersion.ToString());
                        else MessageBox.Show("В данный момент текущая версия софта - последняя:\n" + Application.ProductVersion.ToString());
                    }
                }
            } catch
            {

            }
        }

        private void LoadFonts(bool simple_fonts)
        {
            //fills in the font selection combobox
            FontComboBox.Items.Clear();
            if (simple_fonts)
            {
                FontComboBox.Items.Add("cursive");
                FontComboBox.Items.Add("futural");
                FontComboBox.Items.Add("scriptc");
                FontComboBox.Items.Add("scripts");
            }
            else
            {
                string[] fileEntries = Directory.GetFiles("fonts" + Path.DirectorySeparatorChar);
                foreach (string fileName in fileEntries)
                {
                    String font_name = fileName.Replace("fonts" + Path.DirectorySeparatorChar, "");
                    if (font_name.IndexOf(".cmf") > 0)
                    {
                        FontComboBox.Items.Add(font_name.Replace(".cmf", ""));
                    }
                }
            }
            FontComboBox.Text = Properties.Settings.Default.default_font;
        }

        private void checkbox2_move_letters_randomly(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                String coeffStart = "";
                String coeffEnd = "";

                if (InputBoxRandomMove(ref coeffStart, ref coeffEnd) == DialogResult.OK)
                {
                    try
                    {
                        Properties.Settings.Default.coord_move = coeffStart + "," + coeffEnd;
                    }
                    catch (Exception ex)
                    {

                        if (ci.TwoLetterISOLanguageName != "ru")  MaterialMessageBox.Show("Invalid number format. Example: \"0.55\"");
                        else MaterialMessageBox.Show("Неверный формат. Пример: \"0.55\"");
                        checkBox2.Checked = false;
                    }
                }
                else
                {
                    checkBox2.Checked = false;
                }

            }
            else
            {
                Properties.Settings.Default.coord_move = "-1,-1";
            }
        }

        private void LoadSettings()
        {
            //reads the application settings and fills in all the UI components
            bedwidth.Text = Properties.Settings.Default.bedwidth;
            beddepth.Text = Properties.Settings.Default.beddepth;
            penup.Text = Properties.Settings.Default.penup;
            rotCheckbox.Checked = Properties.Settings.Default.rotate_letters;
            try
            {
                minRotate = Convert.ToInt16(Properties.Settings.Default.rotate_letters_angles.Split(',')[0]);
                maxRotate = Convert.ToInt16(Properties.Settings.Default.rotate_letters_angles.Split(',')[1]);
                minUnitsLineSpacingRandomize = Convert.ToInt16(Properties.Settings.Default.randomize_line_spacing.Split(',')[0]);
                maxUnitsLineSpacingRandomize = Convert.ToInt16(Properties.Settings.Default.randomize_line_spacing.Split(',')[0]);
            }
            catch (Exception ex)
            {
                minRotate = 0;
                maxRotate = 0;
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Loading settings exception");
                else MaterialMessageBox.Show("Ошибка при загрузке настроек");
            }
            try
            {
                symbolSizeRandomizer = Convert.ToDouble(Properties.Settings.Default.randomize_size);
                if(symbolSizeRandomizer != -1)
                {
                    differentSizeCheckbox.Checked = true;
                }
            }
            catch (Exception ex)
            {
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Loading settings exception");
                else MaterialMessageBox.Show("Ошибка при загрузке настроек");
            }
            try
            {
                minUnitsLineSpacingRandomize = Convert.ToInt16(Properties.Settings.Default.randomize_line_spacing.Split(',')[0]);
                maxUnitsLineSpacingRandomize = Convert.ToInt16(Properties.Settings.Default.randomize_line_spacing.Split(',')[0]);
            }
            catch (Exception ignoredEx) {
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Loading settings exception");
                else MaterialMessageBox.Show("Ошибка при загрузке настроек");
            }
            try
            {
                lineGoingDownCoefficient = Properties.Settings.Default.line_going_down;
                if (lineGoingDownCoefficient != 0)
                {
                    lineGoingDownCheckbox.Checked = true;
                }
            }
            catch (Exception ex)
            {
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Loading settings exception");
                else MaterialMessageBox.Show("Ошибка при загрузке настроек");
            }
            if (Properties.Settings.Default.correct_letters_coefficient != 0)
            {
                correctLettersCheckbox.Checked = true;
                incorrectLetterChance = Properties.Settings.Default.correct_letters_coefficient;
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Loading settings exception");
                else MaterialMessageBox.Show("Ошибка при загрузке настроек");
            }
            pendown.Text = Properties.Settings.Default.pendown;
            tspeed.Text = Properties.Settings.Default.tspeed;
            dspeed.Text = Properties.Settings.Default.dspeed;
            zspeed.Text = Properties.Settings.Default.zspeed;
            connectLettersCheckBox.Checked = Properties.Settings.Default.connectLettersCheckbox;
            homex.Checked = Properties.Settings.Default.homex;
            homey.Checked = Properties.Settings.Default.homey;
            homez.Checked = Properties.Settings.Default.homez;
            offsetx.Text = Properties.Settings.Default.offsetx;
            offsety.Text = Properties.Settings.Default.offsety;
            fontscale_value.Text = Properties.Settings.Default.font_scale.ToString();
            textSize_tb.Text = String.Format("{0:0.00}", Properties.Settings.Default.font_scale * 0.37 * 100);
            tb_input.Text = Properties.Settings.Default.default_text;
            lspacing.Text = (Properties.Settings.Default.linespace).ToString();
            letspacing.Text = Properties.Settings.Default.letter_spacing;
            SimpleFontsCheckbox.Checked = Properties.Settings.Default.fonts_all;

            //Handwriting features

            moveCoordSettings = Properties.Settings.Default.coord_move;
            if (moveCoordSettings != "-1,-1") checkBox2.Checked = true;
            if (Properties.Settings.Default.preview_multiplier == 1) { previewScale1.Checked = true; }
            if (Properties.Settings.Default.preview_multiplier == 2) { previewScale2.Checked = true; }
            if (Properties.Settings.Default.preview_multiplier == 4) { previewScale4.Checked = true; }

            if (Properties.Settings.Default.laser) {
                radio_laser_mode.Checked = true;
            } else
            {
                radio_draw_mode.Checked = true;
            }
            update_bed_size();
        }

        private void SaveSettings()
        {
            //saves the application settings from the data in the UI components
            if (!appfault)  //if the app fails to load, we don't want a save to occur on unload. i.e. if fonts folder is missing
            {
                Properties.Settings.Default.bedwidth = bedwidth.Text;
                Properties.Settings.Default.beddepth = beddepth.Text;
                Properties.Settings.Default.tspeed = tspeed.Text;
                Properties.Settings.Default.dspeed = dspeed.Text;
                Properties.Settings.Default.zspeed = zspeed.Text;
                Properties.Settings.Default.homex = homex.Checked;
                Properties.Settings.Default.homey = homey.Checked;
                Properties.Settings.Default.homez = homez.Checked;
                Properties.Settings.Default.offsetx = offsetx.Text;
                Properties.Settings.Default.offsety = offsety.Text;
                Properties.Settings.Default.font_scale = double.Parse(fontscale_value.Text);
                Properties.Settings.Default.default_text = tb_input.Text;
                Properties.Settings.Default.linespace = Convert.ToSingle(lspacing.Text);
                Properties.Settings.Default.default_font = FontComboBox.Text;
                Properties.Settings.Default.letter_spacing = letspacing.Text;
                Properties.Settings.Default.fonts_all = SimpleFontsCheckbox.Checked;
                Properties.Settings.Default.rotate_letters = rotCheckbox.Checked;
                if (previewScale1.Checked) { Properties.Settings.Default.preview_multiplier = 1; }
                if (previewScale2.Checked) { Properties.Settings.Default.preview_multiplier = 2; }
                if (previewScale4.Checked) { Properties.Settings.Default.preview_multiplier = 4; }

                Properties.Settings.Default.laser = radio_laser_mode.Checked;
                if (radio_laser_mode.Checked)
                {
                    Properties.Settings.Default.laser_off = penup.Text;
                    Properties.Settings.Default.laser_on = pendown.Text;
                }
                else
                {
                    Properties.Settings.Default.penup = penup.Text;
                    Properties.Settings.Default.pendown = pendown.Text;
                }
                Properties.Settings.Default.Save();
            }
        }


        public static DialogResult InputBoxRandomMove(ref string value, ref string value2)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Label label2 = new Label();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Moving letters modifier";
            label.Text = "Enter X coefficient:";
            info.Text = "That modifier randomly moves letter. Define the moving" + "\n" + " coefficient up to origin symbol size on X/Y axes, " + "\n" + "where 1.00 equals 100% of letter's size.";
            label2.Text = "Enter Y coefficient:";
            textBox.Text = value;



            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            if (ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Смещение букв";
                label.Text = "Введите коэффициент X:";
                info.Text = "Этот модификатор случайно смещает буквы. Объявите\nкоэффициент, на который будет смещен символ" + "\n" + "от 0 до 1.0, где 1 - высота символа.";
                label2.Text = "Введите коэффициент Y:";
                buttonOk.Text = "OK";
                buttonCancel.Text = "Отменить";
            }

            label.SetBounds(9, 55, 372, 13);
            textBox.SetBounds(12, 76, 372, 20);
            info.SetBounds(9, 10, 372, 13);
            label2.SetBounds(9, 100, 372, 13);
            textBox2.SetBounds(12, 115, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            label2.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "0.20";
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox2.Text = "0.20";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { info, label, textBox, label2, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label2.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            value2 = textBox2.Text;
            return dialogResult;
        }

        public static DialogResult InputBoxCorrectLetters(ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Corrected letters modifier";
            label.Text = "Enter the corrected letters chance:";
            info.Text = "That modifier randomly writes incorrect letter. Define the moving" + "\n" + " coefficient range from 0.00  to 1.00, " + "\n" + "where 1.00 means every letter is corrected.";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";

            if(ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Модификатор исправленных символов";
                label.Text = "Введите вероятность исправленного символа:";
                info.Text = "Этот модификатор пишет неверную букву, а потом исправляет поверх." + "\n" + "Введите вероятность от 0.00  до 1.00, " + "\n" + "где при 1.00 каждая буква будет исправлена:";
                buttonOk.Text = "OK";
                buttonCancel.Text = "Отмена";
            }
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 55, 372, 13);
            textBox.SetBounds(12, 76, 372, 20);
            info.SetBounds(9, 10, 372, 13);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "0.20";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { info, label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public static DialogResult InputBoxLineGoingDown(ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Label label2 = new Label();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Line going down modifier";
            info.Text = "That modifier makes line going down to the end" + "\n" + "(That happens if you write with no drawn lines)" + "\n" + "Enter coefficient and line will go down up to \ncoefficent * letter height slowly:";
            label2.Text = "Enter max coefficient:";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";

            if(ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Съезд строки";
                info.Text = "Строка съезжает вниз ближе к концу" + "\n" + "(Это происходит при письме без линий)" + "\n" + "Введите коэффициент съезда от 0 до \n1, строка съедет на коэф. * высоту символа:";
                label2.Text = "";
                textBox.Text = value;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
            }
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;


            textBox.SetBounds(12, 76, 372, 10);
            info.SetBounds(9, 10, 372, 10);
            buttonOk.SetBounds(228, 30, 75, 23);
            buttonCancel.SetBounds(306, 30, 75, 23);


            label2.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "0.05";
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox2.Text = "0.20";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 60);
            form.Controls.AddRange(new Control[] { info, label, textBox, label2, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label2.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public static DialogResult InputBoxSizeRandomizer(ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Label label2 = new Label();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Random size modifier";
            info.Text = "That modifier multiplies the symbol size by random number" + "\n" + "from the coefficient to its origin size" + "\n" + "Enter coefficient:";
            label2.Text = "Enter max coefficient:";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            if (ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Модификатор случайного размера";
                info.Text = "Этот модификатор изменяет размер символа от" + "\n" + "коэфф. до стандартного размера буквы" + "\n" + "Введите коэффициент:";
                label2.Text = "Enter max coefficient:";
                textBox.Text = value;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Отмена";
            }
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;


            textBox.SetBounds(12, 76, 372, 10);
            info.SetBounds(9, 10, 372, 10);
            buttonOk.SetBounds(228, 30, 75, 23);
            buttonCancel.SetBounds(306, 30, 75, 23);


            label2.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "0.05";
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox2.Text = "0.20";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 60);
            form.Controls.AddRange(new Control[] { info, label, textBox, label2, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label2.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult InputBoxRotation(ref string value, ref string value2)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Label label2 = new Label();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Rotation modifier";
            label.Text = "Enter min angle:";
            info.Text = "That modifier randomly rotates letter. Define the rotating" + "\n" + " angle range from -360  to 360";
            label2.Text = "Enter max angle:";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            if(ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Модификатор поворота";
                label.Text = "Введите мин. угол:";
                info.Text = "Этот модификатор поворачивает символ. Введите\nспектр" + " поворота range от -360  до 360:";
                label2.Text = "Введите макс. угол:";

                buttonOk.Text = "OK";
                buttonCancel.Text = "Отмена";

            }
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 55, 372, 13);
            textBox.SetBounds(12, 76, 372, 20);
            info.SetBounds(9, 10, 372, 13);
            label2.SetBounds(9, 100, 200, 13);
            textBox2.SetBounds(12, 115, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            label2.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "10";
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox2.Text = "20";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { info, label, textBox, label2, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label2.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            value2 = textBox2.Text;
            return dialogResult;
        }

        public static DialogResult InputBoxLine(ref string value, ref string value2)
        {
            Form form = new Form();
            Label label = new Label();
            Label info = new Label();
            TextBox textBox = new TextBox();
            Label label2 = new Label();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Random line space modifier";
            label.Text = "Enter min, units:";
            info.Text = "That modifier randomizes line spacing. Define the" + "\n" + " range from 0. This will override line spacing!";
            label2.Text = "Enter max, units:";
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            if(ci.TwoLetterISOLanguageName == "ru")
            {
                form.Text = "Модификатор межстрочного расст.";
                label.Text = "Введите минимум, ед.:";
                info.Text = "Случайное расстояние между строк. Введите спектр:" + "\n" + "Это перезапишет текущее межстр. расстояние!";
                label2.Text = "Введите макс., ед.:";
                textBox.Text = value;
                buttonCancel.Text = "Отмена";
            }
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 55, 372, 13);
            textBox.SetBounds(12, 76, 372, 20);
            info.SetBounds(9, 10, 372, 13);
            label2.SetBounds(9, 100, 372, 13);
            textBox2.SetBounds(12, 115, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            label2.AutoSize = true;
            info.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            textBox.Text = "-5.0";
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox2.Text = "5.0";
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { info, label, textBox, label2, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label2.Right + 10), form.ClientSize.Height + 80);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            value2 = textBox2.Text;
            return dialogResult;
        }
        private void lineSpacingRandomizeCheckbox(object sender, EventArgs e)
        {
            if (randomLineSpacingCheckbox.Checked)
            {
                String minUnits = "";
                String maxUnits = "";
                try
                {
                    if (InputBoxLine(ref minUnits, ref maxUnits) == DialogResult.OK)
                    {
                        minUnitsLineSpacingRandomize = Convert.ToDouble(minUnits);
                        maxUnitsLineSpacingRandomize = Convert.ToDouble(maxUnits);
                        Properties.Settings.Default.randomize_line_spacing = minUnits + "," + maxUnits;
                    }
                    else
                    {
                        Properties.Settings.Default.randomize_line_spacing = "-1,-1";
                        randomLineSpacingCheckbox.Checked = false;
                        minUnitsLineSpacingRandomize = -1;
                        maxUnitsLineSpacingRandomize = -1;
                    }
                }
                catch (Exception ex)
                {
                    Properties.Settings.Default.randomize_line_spacing = "-1,-1";
                    randomLineSpacingCheckbox.Checked = false;
                    minUnitsLineSpacingRandomize = -1;
                    maxUnitsLineSpacingRandomize = -1;
                }
            }
            else
            {
                Properties.Settings.Default.randomize_line_spacing = "-1,-1";
            }
        }
        private void letterCorrectionModifierCheckbox(object sender, EventArgs e)
        {
            if (correctLettersCheckbox.Checked)
            {
                String coefficient = "";
                try
                {
                    if (InputBoxCorrectLetters(ref coefficient) == DialogResult.OK)
                    {
                        Properties.Settings.Default.correct_letters_coefficient = Convert.ToDouble(coefficient);
                        incorrectLetterChance = Convert.ToDouble(coefficient);
                    }
                    else
                    {
                        Properties.Settings.Default.correct_letters_coefficient = 0.0;
                        correctLettersCheckbox.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    Properties.Settings.Default.correct_letters_coefficient = 0.0;
                    correctLettersCheckbox.Checked = false;
                }
            }
            else
            {
                Properties.Settings.Default.correct_letters_coefficient = 0.0;
            }
        }
        private void rotationCheckbox(object sender, EventArgs e)
        {
            shouldBeRotated = rotCheckbox.Checked;
            Properties.Settings.Default.rotate_letters = rotCheckbox.Checked;
            if (shouldBeRotated)
            {
                try
                {
                    string rotatingAngleMin = "0";
                    string rotatingAngleMax = "0";
                    if (InputBoxRotation(ref rotatingAngleMin, ref rotatingAngleMax) == DialogResult.OK)
                    {
                        Properties.Settings.Default.rotate_letters_angles = rotatingAngleMin + "," + rotatingAngleMax;
                        minRotate = Convert.ToInt32(rotatingAngleMin);
                        maxRotate = Convert.ToInt32(rotatingAngleMax);
                    }
                    else
                    {
                        rotCheckbox.Checked = false;
                        shouldBeRotated = rotCheckbox.Checked;
                        Properties.Settings.Default.rotate_letters = rotCheckbox.Checked;
                    }
                }
                catch (Exception ex)
                {
                    shouldBeRotated = false;
                    rotCheckbox.Checked = false;

                }
            }
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //font preview
            String pic_file = (Application.StartupPath) + Path.DirectorySeparatorChar + "fonts" + Path.DirectorySeparatorChar + FontComboBox.Text + ".png";
            try
            {
                Process.Start(@pic_file);
            }
            catch (System.ComponentModel.Win32Exception excep)
            {
                if (ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show(excep.Message, "Error");
                else MaterialMessageBox.Show(excep.Message, "Ошибка");
            }
        }

        


        /*private void fontscale_value_DoubleClick(object sender, EventArgs e)
        {
            fontscale_value.Text = "0.2";
            trackBar1.Value = 20;
            update_font_size();
        }*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save settings on close
            SaveSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //runs the render routine. 'False' argument means it won't offer to save the GCode file.
            render_stuff(false);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //runs the render routine. 'True' argument means it will offer to save the GCode file.
            render_stuff(true);
        }

        //handwriting features 
        private double coordRandomMove(double c)
        {
            return 0.0;
        }
        private void render_stuff(bool saving)
        {
            //To my future self and anyone else, Sorry

            button1.Enabled = false;                                                //disable the render and preview buttons
            button2.Enabled = false;
            //toolStripStatusLabel3.Text = "Rendering...Please wait";
            double GX = 0;
            double GY = 0;
            double accum_x = 0;
            double accum_y = 0;

            double scale = double.Parse(fontscale_value.Text) / 5;                      //get the font scale - divides by 5 to increase the resolution
            double char_height = h_height * scale;                                  //scale up the character height

            double line_spacing = Convert.ToSingle(lspacing.Text) * scale * 5;          //scale up the line spacing  resolution increased by 5
            double letter_spacing = Convert.ToSingle(letspacing.Text) * scale * 5;      //scale up the letter spacing  res increased by 5
            double font_offset_y = 7.5;
            try
            {
                font_offset_y = double.Parse(textSize_tb.Text);              //align text with edge of bed
            }
            catch(Exception ingEx)
            {
                if(ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Something wrong happened about the text size. Did you enter it correctly?");
                else MaterialMessageBox.Show("Что-то не так с размером текста. Вы точно ввели его верно?"); 
            }

            double offx = Convert.ToSingle(offsetx.Text);                            //get the X Offset from the UI
            double offy = Convert.ToSingle(offsety.Text);                            //get the Y Offset from the UI

            bool out_of_bounds = false;                                             //init a boolean for general plotting fault

            double max_x = Convert.ToSingle(bedwidth.Text);                          //get the Bed X setting from the UI
            double max_y = Convert.ToSingle(beddepth.Text);                          //get the Bed Y setting from the UI

            int F_draw = Convert.ToInt32(dspeed.Text) * 60;                         //get the Draw speed setting from the UI
            int F_travel = Convert.ToInt32(tspeed.Text) * 60;                       //get the Travel speed setting from the UI
            int F_zspeed = Convert.ToInt32(zspeed.Text) * 60;                       //get the Z-Axis speed setting from the UI
            bool first_move = true;

            double lastx = 0;                                                       //keep track of where we were for pen up/pen down test
            double lasty = 0;

            Bitmap preview = new Bitmap(pb_preview.Width, pb_preview.Height);       //init the picturebox
            Graphics previewGraphics = Graphics.FromImage(preview);
            Pen semiTransPen = new Pen(Color.FromArgb(25, 255, 0, 0), 2);           //create a transparent red pen for the margins (offset)

            //draw red offset lines
            previewGraphics.DrawLine(semiTransPen, 0, Convert.ToSingle((offy * preview_mag)), pb_preview.Width, Convert.ToSingle((offy * preview_mag)));  //horizontal line X
            previewGraphics.DrawLine(semiTransPen, Convert.ToSingle(offx * preview_mag), 0, Convert.ToSingle(offx * preview_mag), pb_preview.Height);   //vertical line Y

            string output = "";                                                     //init the GCode output string

            //write current settings to file for debug and consistency
            output += "; Generated with 3DWriter, fork by snow4dv " + Application.ProductVersion.ToString() + "\r\n; \r\n";
            output += "; Font: " + FontComboBox.Text + "\r\n";
            output += "; FontScale: " + textSize_tb.Text + "mm (" + scale + ")\r\n";
            output += "; Bed: " + bedwidth.Text + " x " + beddepth.Text + "\r\n";
            output += "; Offset: " + offsetx.Text + " x " + offsety.Text + "\r\n";
            output += "; Draw mode: " + (radio_laser_mode.Checked ? "Laser" : "Pen") + "\r\n";
            output += "; Pen Up: " + penup.Text + "\r\n";
            output += "; Pen Down: " + pendown.Text + "\r\n";
            output += "; Travel speed: " + tspeed.Text + "\r\n";
            output += "; Draw speed: " + dspeed.Text + "\r\n";
            output += "; Z speed: " + zspeed.Text + "\r\n";
            output += "; Line Spacing: " + lspacing.Text + "\r\n";
            output += "; Letter spacing: " + letspacing.Text + "\r\n";
            output += "; Home: " + (homex.Checked ? "X" : "") + (homey.Checked ? "Y" : "") + (homez.Checked ? "Z" : "") + "\r\n";
            output += "; Dry run: " + (dryrun.Checked ? "ON" : "OFF") + "\r\n";
            output += "; Render count: " + rendercount + "\r\n";
            output += "; Decimal: " + Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator + "\r\n";
            output += "; Text input...\r\n; ----\r\n;\t" + (tb_input.Text.Replace("\r\n", "\r\n;\t")) + "\r\n; ---- \r\n";

            //if ( !(!homex.Checked && !homey.Checked && !homez.Checked) ) {          //Do we need to home the printer?
            if (homex.Checked || homey.Checked || homez.Checked)
            {
                output += "G28 " + (homex.Checked ? "X" : "") + " " + (homey.Checked ? "Y" : "") + " " + (homez.Checked ? "Z" : "") + " F" + F_travel + "\r\n";
            }
            output += "G21" + "\r\n";               //set units to millimeters
            if (radio_laser_mode.Checked)
            {
                output += "M452" + "\r\n";          //select laser print mode
                output += "M3 S255" + "\r\n";       //Spindle On, Clockwise (CNC specific)

                output += "G90" + "\r\n";           // G90: Set to Absolute Positioning
                output += "G21" + "\r\n";           // G21: Set Units to Millimeters

                output += penup.Text + "\r\n";                                      //Laser off before any moves
            }
            else
            {
                output += "G0 Z" + penup.Text + " F" + F_travel + "\r\n";           //Pen up before any moves
            }

            string[] lines = (tb_input.Text).Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None); //split the text input up in to lines
            bool symbolMovingError = false;
            Random rnd = new Random();
            for (int ptr = 0; ptr < lines.Length; ptr++)                            //interate through the lines
            {
                if (randomLineSpacingCheckbox.Checked && !(minUnitsLineSpacingRandomize == -1 || maxUnitsLineSpacingRandomize == -1)) //function to increase/decrease line spacing randomly
                    line_spacing = (((double)rnd.Next((int)(minUnitsLineSpacingRandomize * 100), (int)(maxUnitsLineSpacingRandomize * 100))) / 100) * scale * 5;
                string thisline = lines[ptr];                                       //gets the line
                double prevOutputPointX = -1;
                double prevOutputPointY = -1;
                bool correctedLetter = false;
                bool prevCorrectedLetter = false;
                for (int a = 0; a < thisline.Length; a++)                           //interate through each character of the line
                {

                    double lineFactor = 0;
                    if (lineGoingDownCheckbox.Checked) //Line going down
                    {
                        int maxSymbolsInTheLine = (int)((max_x-offx)/(70 * 2.5 * scale));//70 is average symbol width - count it as is not to spend time on counting width sum
                        lineFactor = (lineGoingDownCoefficient / maxSymbolsInTheLine) * a;//TODO: make the line going down not by amount of words but by its width
                    }
                    bool ifOuputPointFound = false; //this bool is used to clear the output point valuee if it is not found
                    double xFactor = 0.0;  //Random character movement modifier is here.
                    double yFactor = 0.0;
                    int multX = 0;
                    int multY = 0;
                    if (Properties.Settings.Default.coord_move != "-1,-1")
                    {
                        try
                        {
                            double xMultiplier = Convert.ToDouble(Properties.Settings.Default.coord_move.Split(',')[0]);
                            double yMultiplier = Convert.ToDouble(Properties.Settings.Default.coord_move.Split(',')[1]);

                            xFactor = rnd.NextDouble() * xMultiplier;
                            yFactor = rnd.NextDouble() * yMultiplier;

                            if (rnd.Next(0, 100) > 50)
                            {
                                multX = -1;
                            }
                            else
                            {
                                multX = 1;
                            }
                            if (rnd.Next(0, 100) > 50)
                            {
                                multY = -1;
                            }
                            else
                            {
                                multY = 1;
                            }

                        }
                        catch (Exception ex)
                        {
                            symbolMovingError = true;
                        }
                    }




                    //init cnum - this string is a map of the font. the index of the character aligns with the font_chars array for the character data.
                    //Language other than english won't map correctly here.// Actually it would after you implemented new cmf format. I am here because i want the cyrillic support :D (snow4dv)
                    //int cnum = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~".IndexOf(thisline.Substring(a, 1)); //font map is now read from the cmf font file
                    int cnum = 0;
                    bool valid = true;
                    double thewidth = 0;
                    try
                    {
                        //check to see if we have that character and if >1  - getting random of ones we have
                        ArrayList indexes = new ArrayList();
                        for (int iter = 0; iter < h_font_map.Length; iter++)
                        {
                            if (h_font_map.ToCharArray()[iter] == Convert.ToChar(thisline.Substring(a, 1)))
                            {
                                indexes.Add(iter);
                            }
                        }

                        cnum = (int)indexes[rnd.Next(0, indexes.Count)];
                        //double thewidth = Convert.ToInt32(font_chars[cnum][0]);         //gets the character width (0)
                        thewidth = Convert.ToInt32(font_chars[cnum][1]);         //gets the character real width (1)
                    }
                    catch (Exception excep)
                    {
                        valid = false;
                    }

                    if ((rnd.NextDouble() <= incorrectLetterChance) && correctLettersCheckbox.Checked && !prevCorrectedLetter && valid) //checking if letter is going to be wrong and corrected
                    {
                        correctedLetter = true;
                        prevCorrectedLetter = true;
                        int lineNum = rnd.Next(0, lines.Length);
                        int symbolNum = rnd.Next(0, lines[lineNum].Length);
                        char randChar = lines[lineNum][symbolNum];
                        ArrayList indexes = new ArrayList();
                        for (int iter = 0; iter < h_font_map.Length; iter++)
                        {
                            if (h_font_map.ToCharArray()[iter] == randChar)
                            {
                                indexes.Add(iter);
                            }
                        }


                        cnum = (int)indexes[rnd.Next(0, indexes.Count)];
                        //double thewidth = Convert.ToInt32(font_chars[cnum][0]);         //gets the character width (0)
                        if (Convert.ToInt32(font_chars[cnum][1]) > thewidth) //if correctedSymbol and its width is larger - using its width
                            thewidth = Convert.ToInt32(font_chars[cnum][1]);         //gets the character real width (1)
                    }
                    else
                    {
                        prevCorrectedLetter = false;
                    }


                    if (valid && cnum != 0)                                                  //if the index is 0, this is a space
                    {
                        //This is used to rotate symbols later 
                        int rotatingAngle = 0; //Prepare sin/cos for rotating the segments


                        if (rotCheckbox.Checked)
                        {
                            rotatingAngle = rnd.Next(minRotate, maxRotate);
                        }
                        if (differentSizeCheckbox.Checked) //scaling by the modifier
                        {
                            scale = double.Parse(fontscale_value.Text) / 5;
                            scale *= rnd.NextDouble() * (1 - symbolSizeRandomizer) + symbolSizeRandomizer;
                        }

                        //previewGraphics.DrawEllipse(Pens.Green, new Rectangle((int)(midPointX * scale + xFactor * thewidth * 2.5 * multX + accum_x + offx), (int)(midPointY * scale + yFactor * thewidth * 2.5 * multY + offx + accum_y), 5, 5));

                        for (int b = 0; b < font_chars[cnum].Length / 4; b++)       //loop through the stroke x/y pairs     //Needed some extra iterations here
                        {

                            if (font_chars[cnum][(b * 4) + 3 + 3] >= 0 && font_chars[cnum][b * 4 + 3] >= 0)
                            {
                                
                                double x1 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3]);      //the +3 is because there are 3 array elements prior to x/y pair data in the array.
                                double y1 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 1]);
                                double x2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 2]);
                                double y2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 3]);
                                if (lineGoingDownCheckbox.Checked)
                                { 
                                    y1 += lineFactor*161; //161 - symbol height! 
                                    y2 += lineFactor*161; 
                                }
                                if (rotCheckbox.Checked) //Rotating the line
                                {
                                    List<double> points = rotate(x1, y1, thewidth / 2, 161 / 2, rotatingAngle);
                                    x1 = points[0];
                                    y1 = points[1];
                                    points = rotate(x2, y2, thewidth / 2, 161/2, rotatingAngle);
                                    x2 = points[0];
                                    y2 = points[1];
                                }
                                
                                x1 = x1 * scale + xFactor * thewidth *  multX * scale; //Increasing the size and adding random movement
                                x2 = x2 * scale + xFactor * thewidth *  multX * scale;
                                y1 = y1 * scale + yFactor * 37 *  multY * scale;
                                y2 = y2 * scale + yFactor * 37 *  multY * scale;
                               


                                double draw_x1 = accum_x + x1 + offx;                   //calculate the scaled points for the picutrebox
                                double draw_y1 = (offy + accum_y) + y1;
                                double draw_x2 = accum_x + x2 + offx;
                                double draw_y2 = (offy + accum_y) + y2;

                                previewGraphics.DrawLine(Pens.Blue, Convert.ToInt32(draw_x1 * preview_mag), Convert.ToInt32(draw_y1 * preview_mag), Convert.ToInt32(draw_x2 * preview_mag), Convert.ToInt32(draw_y2 * preview_mag));    //draw a stroke to the picturebox

                                //start a pen stroke
                                GX = accum_x + x1 + offx;                                               //calculate the GCode X value
                                GY = ((char_height - y1) + (max_y - offy) - accum_y) - font_offset_y;     //calculate the GCode Y value

                                if (lastx == accum_x + x1 + offx && lasty == (char_height - y1) + (max_y - offy))           //test if the pen needs to raise for a travel
                                {
                                    output += "G1 X" + GX.ToString() + " Y" + (GY).ToString() + " F" + (first_move ? F_travel : F_draw) + "\r\n";     //write the move to the output string
                                    first_move = false;
                                }
                                else
                                {
                                    if (radio_laser_mode.Checked)
                                    {
                                        output += penup.Text + "\r\n";                               //laser poweroff - (Pen up)
                                    }
                                    else
                                    {
                                        output += "G0 Z" + penup.Text + " F" + F_zspeed + "\r\n";                               //raise the pen - Pen up
                                    }
                                    output += "G0 X" + GX.ToString() + " Y" + GY.ToString() + " F" + F_travel + "\r\n";       //move the pen      
                                    if (radio_laser_mode.Checked)
                                    {
                                        output += (dryrun.Checked ? penup.Text : pendown.Text) + "\r\n";     //turn laser on (unless dry run is on)
                                    }
                                    else
                                    {
                                        output += "G0 Z" + (dryrun.Checked ? penup.Text : pendown.Text) + " F" + F_zspeed + "\r\n";     //put the pen down (unless dry run is on)
                                    }

                                }
                                if (Convert.ToInt32(GX) > max_x || Convert.ToInt32(GX) < 0) { out_of_bounds = true; }       //check if we went out of bounds
                                if (Convert.ToInt32(GY) > max_y || Convert.ToInt32(GY) < 0) { out_of_bounds = true; }

                                //end the pen stroke
                                GX = (accum_x + x2 + offx);                                                 //calculate the GCode X value
                                GY = (((char_height - y2) + (max_y - offy)) - accum_y) - font_offset_y;     //calculate the GCode Y value
                                output += "G1 X" + GX.ToString() + " Y" + GY.ToString() + " F" + F_draw + "\r\n";       //write the move to the output string

                                lastx = accum_x + x2 + offx;                            //keep the last x/y so we can test it for pen up on next loop
                                lasty = (char_height - y2) + (max_y - offy);
                            }
                            else if (font_chars[cnum][(b * 4) + 3 + 3] < 0 && prevOutputPointX != -1 && prevOutputPointY != -1 && connectLettersCheckBox.Checked) // found an input point! If there is an output point of previous letter - i'd draw a line
                            {
                                double x1 = prevOutputPointX;
                                double y1 = prevOutputPointY;
                                double x2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3]);
                                double y2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 1]);
                                if (rotCheckbox.Checked) //Rotating the line
                                {
                                    List<double> points;
                                    points = rotate(x2, y2, thewidth / 2, 161 / 2, rotatingAngle);
                                    x2 = points[0];
                                    y2 = points[1];
                                }
                                
                                //Increasing the size and adding random movement
                                x2 = x2 * scale + xFactor * thewidth * multX * scale;
                                y2 = y2 * scale + yFactor * 37 * multY * scale;



                                double draw_x1 = x1 + offx;                   //calculate the scaled points for the picutrebox
                                double draw_y1 = (offy) + y1 + accum_y;
                                double draw_x2 = accum_x + x2 + offx;
                                double draw_y2 = (offy + accum_y) + y2;

                                previewGraphics.DrawLine(Pens.Blue, Convert.ToInt32(draw_x1 * preview_mag), Convert.ToInt32(draw_y1 * preview_mag), Convert.ToInt32(draw_x2 * preview_mag), Convert.ToInt32(draw_y2 * preview_mag));    //draw a stroke to the picturebox

                                //start a pen stroke
                                GX = x1 + offx;                                               //calculate the GCode X value
                                GY = ((char_height - y1) + (max_y - offy) - accum_y) - font_offset_y;     //calculate the GCode Y value

                                if (lastx == accum_x + x1 + offx && lasty == (char_height - y1) + (max_y - offy))           //test if the pen needs to raise for a travel
                                {
                                    output += "G1 X" + GX.ToString() + " Y" + (GY).ToString() + " F" + (first_move ? F_travel : F_draw) + "\r\n";     //write the move to the output string
                                    first_move = false;
                                }
                                else
                                {
                                    if (radio_laser_mode.Checked)
                                    {
                                        output += penup.Text + "\r\n";                               //laser poweroff - (Pen up)
                                    }
                                    else
                                    {
                                        output += "G0 Z" + penup.Text + " F" + F_zspeed + "\r\n";                               //raise the pen - Pen up
                                    }
                                    output += "G0 X" + GX.ToString() + " Y" + GY.ToString() + " F" + F_travel + "\r\n";       //move the pen      
                                    if (radio_laser_mode.Checked)
                                    {
                                        output += (dryrun.Checked ? penup.Text : pendown.Text) + "\r\n";     //turn laser on (unless dry run is on)
                                    }
                                    else
                                    {
                                        output += "G0 Z" + (dryrun.Checked ? penup.Text : pendown.Text) + " F" + F_zspeed + "\r\n";     //put the pen down (unless dry run is on)
                                    }

                                }
                                if (Convert.ToInt32(GX) > max_x || Convert.ToInt32(GX) < 0) { out_of_bounds = true; }       //check if we went out of bounds
                                if (Convert.ToInt32(GY) > max_y || Convert.ToInt32(GY) < 0) { out_of_bounds = true; }

                                //end the pen stroke
                                GX = (accum_x + x2 + offx);                                                 //calculate the GCode X value
                                GY = (((char_height - y2) + (max_y - offy)) - accum_y) - font_offset_y;     //calculate the GCode Y value
                                output += "G1 X" + GX.ToString() + " Y" + GY.ToString() + " F" + F_draw + "\r\n";       //write the move to the output string

                                lastx = accum_x + x2 + offx;                            //keep the last x/y so we can test it for pen up on next loop
                                lasty = (char_height - y2) + (max_y - offy);
                            }

                            else //there's an output point. Saving it and will use if there is an input point
                            {
                                double x2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 2]);
                                double y2 = Convert.ToDouble(font_chars[cnum][(b * 4) + 3 + 3]);
                                if (rotCheckbox.Checked) //Rotating the line
                                {
                                    List<double> points;
                                    points = rotate(x2, y2, thewidth / 2, 161 / 2, rotatingAngle);
                                    x2 = points[0];
                                    y2 = points[1];
                                }
                                
                                //Increasing the size and adding random movement
                                x2 = x2 * scale + xFactor * thewidth * multX * scale + accum_x;
                                y2 = y2 * scale + yFactor * 37 * multY * scale;
                                ifOuputPointFound = true;
                                prevOutputPointY = y2;
                                prevOutputPointX = x2;

                            }


                        }
                        if (!ifOuputPointFound)
                        {
                            prevOutputPointX = -1;
                            prevOutputPointY = -1;
                        }
                        if (!correctedLetter)
                            accum_x += (Convert.ToDouble(thewidth) * scale) + letter_spacing;   //accumulated X value plus spacing
                        correctedLetter = false;
                    }
                    else
                    {
                        accum_x += Convert.ToDouble(thewidth) * scale + letter_spacing; //accumulated X value (space) plus spacing
                        prevOutputPointX = -1;
                        prevOutputPointY = -1;
                    }
                }
                accum_x = 0;    //CR                                                    //reset the accumulated X value
                accum_y += char_height + line_spacing;  //LF                            //increment the accumulated Y value plus spacing
                                                        //end lines loop
            }
            if (symbolMovingError)
            {
                if(ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Random symbol moving function error. Check if you entered correct coefficients and try again.");
                else MaterialMessageBox.Show("Ошибка во время случайного смещения символа. Проверьте, правильно ли введены коэффициенты и попробуйте снова.");
            }
            //end of ploting moves
            if (radio_laser_mode.Checked)
            {
                output += "G0 F3000" + "\r\n";
                output += penup.Text + "\r\n";                                          //poweroff the laser

                output += "G91" + "\r\n";
                output += "G90" + "\r\n";
                output += "M3 S0" + "\r\n";                                             //speed zero
                output += "M5 S0" + "\r\n";                                             //spindle off

                output += "M18" + "\r\n";                                               //Disable steppers
            }
            else
            {
                output += "G0 Z" + penup.Text + " F" + F_zspeed + "\r\n";               //Raise the pen
            }

            //if (!(!homex.Checked && !homey.Checked))                                    //Home the pen (if enabled in UI)
            if (homex.Checked || homey.Checked)
            {
                output += "G0 " + (homex.Checked ? "X0" : "") + " " + (homey.Checked ? "Y0" : "") + " F" + F_travel + "\r\n";
            }

            output += "" + "\r\n";                                                      //end space

            //FIXES: 14/04/2018 : remove line duplicates, enforce periods instead of comma's in decimal numbers caused by language preferences
            //it's a bit of a hack but whatever works
            string output_filtered = "";
            string lastline = "";
            int lines_omitted = 0;
            using (StringReader reader = new StringReader(output))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null && lastline != line)
                    {
                        output_filtered += line.Replace(",", ".") + "\r\n";
                        lastline = line;
                    }
                    else
                    {
                        if (line != null)
                        {
                            output_filtered += line.Replace(",", ".") + "\r\n"; //DELETE ME - here for testing purposes only
                        }
                        lines_omitted++;
                    }

                } while (line != null);
            }
            output_filtered += "; lines omitted: " + lines_omitted + "\r\n";            //keep an eye on the duplicate lines for further refinement later


            pb_preview.Image = preview;                                                 //write the preview image to the picturebox
            if (saving)                                                                 //if "Render GCode" was clicked, offer to save the GCode file
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = last_filename != "" ? last_filename : "3DWriter.gcode";
                save.Filter = "Gcode File | *.gcode";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    last_filename = save.FileName;
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(output_filtered);
                    writer.Dispose();
                    writer.Close();
                }
            }
            //toolStripStatusLabel3.Text = "";

            if (out_of_bounds)
            {                                                        //Complain about life 
                if(ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Warning: " + (radio_laser_mode.Checked ? "Laser" : "Pen") + " went out of bounds !");
                else MaterialMessageBox.Show("Ошибка: " + (radio_laser_mode.Checked ? "Лазер" : "Ручка") + " вышла за пределы рабочей области!");
            }
            button1.Enabled = true;                                                  //re-enable the buttons
            button2.Enabled = true;

        }

        private void update_bed_size()
        {
            //update the preview picturebox and form size based on bed x/y settings
            //also sets the preview magnification level
            if (previewScale1.Checked)
            {
                preview_mag = 1;
            }
            if (previewScale2.Checked)
            {
                preview_mag = 2;
            }
            if (previewScale4.Checked)
            {
                preview_mag = 4;
            }

            if (Screen.FromControl(this).Bounds.Height <= 1000)
            {
                previewScale4.Checked = false;
                previewScale2.Checked = true;

                preview_mag = 2;
            }

            if (bedwidth.Text != "" && IsNumeric(bedwidth.Text) && int.Parse(bedwidth.Text) > 10)
            {
                if (int.Parse(bedwidth.Text) > Screen.PrimaryScreen.Bounds.Width) { bedwidth.Text = (Screen.PrimaryScreen.Bounds.Width - 700).ToString(); }
                bedwidth.BackColor = System.Drawing.SystemColors.Window;
                pb_preview.Width = Convert.ToInt32(bedwidth.Text) * preview_mag;        //apply the magnification factor
                this.Width = Convert.ToInt32(bedwidth.Text) * preview_mag + 730 - 285 + 109;                                    //resize the form to fit new preview size
                                                                                                                    //previewCard.Width = Convert.ToInt32(bedwidth.Text) * preview_mag;
                                                                                                                    //panel4.Width = Convert.ToInt32(bedwidth.Text) * preview_mag + 400;
            }
            else
            {
                bedwidth.BackColor = Color.Red;                                         //incorrect value entered, make it visible
            }

            if (beddepth.Text != "" && IsNumeric(beddepth.Text) && int.Parse(beddepth.Text) > 10)
            {
                if (int.Parse(beddepth.Text) > Screen.PrimaryScreen.Bounds.Height) { beddepth.Text = (Screen.PrimaryScreen.Bounds.Height - 170).ToString(); }
                beddepth.BackColor = System.Drawing.SystemColors.Window;
                pb_preview.Height = Convert.ToInt32(beddepth.Text) * preview_mag;       //apply the magnification factor
                tb_input.Height = Convert.ToInt32(beddepth.Text) * preview_mag;
                materialCard2.Height = Convert.ToInt32(beddepth.Text) * preview_mag;
                this.Height = (pb_preview.Height + 170) < 565 ? 565 : (pb_preview.Height + 170 + 100);    //resize the form to fit new preview size
                                                                                                    //previewCard.Height = Convert.ToInt32(beddepth.Text) * preview_mag;
                                                                                                    //panel4.Height = Convert.ToInt32(beddepth.Text) * preview_mag + 400;
            }
            else
            {
                beddepth.BackColor = Color.Red;                                         //incorrect value entered, make it visible
            }
            button1_Click(null, null);
            panel5.Location = new Point(this.Width - 50, panel5.Location.Y);

        }



        private void bedwidth_TextChanged(object sender, EventArgs e)
        {
            update_bed_size();
        }

        private void beddepth_TextChanged(object sender, EventArgs e)
        {
            update_bed_size();
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontComboBox.Text != "" || FontComboBox.Text != null) load_font(FontComboBox.Text);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();

            box.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/boy1dr");
        }


        private bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        /*private void label28_DoubleClick(object sender, EventArgs e)
        {
            fontscale_value.Text = "0.2";
            textSize_tb.Value = 20;
            update_font_size();
        }

        private void label29_DoubleClick(object sender, EventArgs e)
        {
            fontscale_value.Text = "0.35";
            trackBar1.Value = 35;
            update_font_size();
        }

        private void label30_DoubleClick(object sender, EventArgs e)
        {
            fontscale_value.Text = "0.5";
            trackBar1.Value = 50;
            update_font_size();
        }*/

        private void resetDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset default - these are just safe settings i used initially
            bedwidth.Text = "200";
            Properties.Settings.Default.rotate_letters = false;
            rotCheckbox.Checked = false;
            beddepth.Text = "200";
            penup.Text = "50";
            pendown.Text = "45";
            tspeed.Text = "100";
            dspeed.Text = "40";
            zspeed.Text = "40";
            homex.Checked = true;
            homey.Checked = true;
            homez.Checked = true;
            connectLettersCheckBox.Checked = false;
            checkBox2.Checked = false;
            offsetx.Text = "45";
            offsety.Text = "45";
            fontscale_value.Text = "0.2";
            textSize_tb.Text = "20";
            if(ci.TwoLetterISOLanguageName != "ru") tb_input.Text = "Welcome to 3DWriter!";
            else tb_input.Text = "Добро пожаловать в 3DWriter!";
            lspacing.Text = "0";
            letspacing.Text = "0";
            SimpleFontsCheckbox.Checked = true;
            FontComboBox.Text = "cursive";
            previewScale2.Checked = true;
            update_bed_size();
            update_font_size();

        }

        private void preview_mag1_Click(object sender, EventArgs e)
        {
            update_bed_size();
        }

        private void preview_mag2_Click(object sender, EventArgs e)
        {
            update_bed_size();
        }

        private void preview_mag4_Click(object sender, EventArgs e)
        {
            update_bed_size();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontEditor editorbox = new FontEditor();

            editorbox.Show();
        }

        private void radio_draw_mode_CheckedChanged(object sender, EventArgs e)
        {
            //save current values
            //Properties.Settings.Default.penup = penup.Text;
            //Properties.Settings.Default.pendown = pendown.Text;
            set_pen_mode();
        }

        private void radio_laser_mode_CheckedChanged(object sender, EventArgs e)
        {
            //save current values
            //Properties.Settings.Default.penup = penup.Text;
            //Properties.Settings.Default.pendown = pendown.Text;
            set_laser_mode();
        }

        private void set_laser_mode()
        {
            if (ci.TwoLetterISOLanguageName != "ru")
            {
                label_mode_down.Text = "Laser ON";
                label_mode_up.Text = "Laser OFF";
                label_mode_down_text.Text = "GCode";
                label_mode_up_text.Text = "GCode";
            }
            else
            {
                label_mode_down.Text = "Лазер вкл.";
                label_mode_up.Text = "Лазер выкл.";
                label_mode_down_text.Text = "GCode";
                label_mode_up_text.Text = "GCode";
            }

            pendown.Text = Properties.Settings.Default.laser_on;
            penup.Text = Properties.Settings.Default.laser_off;

            dryrun.Text = "(laser is always off)";
        }
        private void set_pen_mode()
        {
            if (ci.TwoLetterISOLanguageName != "ru")
            {
                label_mode_down.Text = "Pen down";
                label_mode_up.Text = "Pen up";
                label_mode_down_text.Text = "mm";
                label_mode_up_text.Text = "mm";
                dryrun.Text = "(pen is always up)";
            }
            else
            {
                label_mode_down.Text = "Ручка вверху";
                label_mode_up.Text = "Ручка внизу";
                label_mode_down_text.Text = "мм";
                label_mode_up_text.Text = "мм";
                dryrun.Text = "(ручка всегда поднята)";
            }

            pendown.Text = Properties.Settings.Default.pendown;
            penup.Text = Properties.Settings.Default.penup;

            
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckVersion(1);
        }

        private void lineGoingDown(object sender, EventArgs e)
        {
            if (lineGoingDownCheckbox.Checked)
            {
                try
                {
                    String coeff = "0";
                    if (InputBoxLineGoingDown(ref coeff) == DialogResult.OK)
                    {
                        Properties.Settings.Default.line_going_down = Convert.ToDouble(coeff);
                        lineGoingDownCoefficient = Convert.ToDouble(coeff);
                    }
                    else
                    {
                        Properties.Settings.Default.line_going_down = 0;
                        lineGoingDownCoefficient = 0;
                        lineGoingDownCheckbox.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    Properties.Settings.Default.line_going_down = 0;
                    lineGoingDownCoefficient = 0;
                    lineGoingDownCheckbox.Checked = false;
                }
            }
            else
            {
                Properties.Settings.Default.line_going_down = 0;
                lineGoingDownCoefficient = 0;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadFonts(SimpleFontsCheckbox.Checked);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void preview_mag1(object sender, EventArgs e)
        {

        }

        private void preview_mag4(object sender, EventArgs e)
        {

        }

        private void preview_mag4_Clic(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void connectLettersCheckbox_Click(object sender, EventArgs e)
        {
            if (connectLettersCheckBox.Checked)
            {
                Properties.Settings.Default.connectLettersCheckbox = true;
            }
            else
            {
                Properties.Settings.Default.connectLettersCheckbox = false;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sloppyCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void connectLettersCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textSize_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fontscale_value.Text = (Convert.ToDouble(textSize_tb.Text) /0.37)/100.0 + "";
                update_font_size();
            }
            catch(Exception ex)
            {
                //Ignored
            }
        }

        private void differentSizeCheckbox_Click(object sender, EventArgs e)
        {
            if (differentSizeCheckbox.Checked)
            {
                try
                {
                    String coeff = "-1";
                    if (InputBoxSizeRandomizer(ref coeff) == DialogResult.OK)
                    {
                        Properties.Settings.Default.randomize_size = Convert.ToDouble(coeff);
                        symbolSizeRandomizer = Convert.ToDouble(coeff);
                    }
                    else
                    {
                        Properties.Settings.Default.randomize_size = -1;
                        symbolSizeRandomizer = -1;
                        differentSizeCheckbox.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    if(ci.TwoLetterISOLanguageName != "ru") MaterialMessageBox.Show("Check if entered value is correct");
                    else MaterialMessageBox.Show("Проверьте, верно ли введенное значение");
                    Properties.Settings.Default.randomize_size = -1;
                    symbolSizeRandomizer = -1;
                    differentSizeCheckbox.Checked = false;
                }
            }
            else
            {

            }
        }

        private List<double> rotate(double thisPointX, double thisPointY, double originPointX, double originPointY, double degrees){ 
            double radians = (Math.PI / 180) * degrees;
        //x, y = thispoint
        //offset_x, offset_y = originpoint
            double adjusted_x = (thisPointX - originPointX);
            double adjusted_y = (thisPointY - originPointY);
            double cos_rad = Math.Cos(radians);
            double sin_rad = Math.Sin(radians);
            List<double> result = new List<double>();
            result.Add(originPointX + cos_rad * adjusted_x + sin_rad * adjusted_y);
            result.Add(originPointY + -sin_rad * adjusted_x + cos_rad * adjusted_y);
            return result;
    }
        //Wow you made it, take a break :P
    }
}
