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
using System.Runtime.InteropServices;
using System.Windows.Forms.Integration;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Windows.Media;
using Pen = System.Drawing.Pen;
using Color = System.Drawing.Color;
using SimplifyCSharp;

namespace _3DWriter

{
    // This is an absolute mess, i am experimenting with a graphical font editor. This will change a lot before i enable the menu option in the main form
    // Not such a  mess as my code :d 
    public partial class FontEditor : MaterialSkin.Controls.MaterialForm
    {





        Point lastPoint = Point.Empty;
        int pointsCounter = 0;
        IList<Point> pointCollection = new List<Point>();
        Pen pen = new Pen(Color.Black, 2);
        bool isMouseDown = false;
        Boolean transpModeOn = false;
        ToolTip tt = new ToolTip();
        double h_height = 160;       
        //font character height
        double h_char_count;                                    //font character count
        string h_font_map;                                      //font mapz - Character index array
        double[][] font_chars = new double[250][];              //the main font array
        int segs = 0;
        int selected_seg = 0;

        public FontEditor()
        {
            InitializeComponent();
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);


        }

        private void FontEditor_Load(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles("fonts");
            foreach (string fileName in fileEntries)
            {
                String font_name = fileName.Replace("fonts" + Path.DirectorySeparatorChar, "");
                if (font_name.IndexOf(".cmf") > 0)
                {
                    FontComboBox.Items.Add(font_name.Replace(".cmf", ""));
                }
            }
            if(FontComboBox.Items.Count > 0) FontComboBox.SelectedItem = FontComboBox.Items[0]; //Selecting the first font on startup
            if(lv_charmap.Items.Count > 0) lv_charmap.Items[0].Selected = true; //selecting the first char on startup
            
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_font(FontComboBox.Text);
            //lv_charmap
        }

        public void load_font(string fname)
        {
            int counter = 0;
            string line;

            int charcount = 0;
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
            lv_charmap.Items.Clear();
            for (int char_idx=0; char_idx< h_font_map.Length; char_idx++)
            {
                lv_charmap.Items.Add(h_font_map.Substring(char_idx,1));
                
            }
        }

        private void lv_charmap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_charmap.SelectedItems.Count > 0) tb_char_to_add.Text = lv_charmap.SelectedItems[0].Text;
            lv_points.Items.Clear();

            int idx = 0;
            segs = 0;
            if (lv_charmap.SelectedItems.Count > 0)
            {
                idx = lv_charmap.Items.IndexOf(lv_charmap.SelectedItems[0]);
                double[] thisChar = font_chars[idx];
                double char_width = 1.0;
                try
                {
                    char_width = thisChar[1];
                }
                catch(Exception exept)
                {

                }
                tb_width.Text = char_width.ToString();
                for (int ptr = 0; ptr < (thisChar.Length - 3) / 4; ptr++)
                {
                    double x1 = thisChar[(ptr * 4) + 3];
                    double y1 = thisChar[(ptr * 4) + 4];
                    double x2 = thisChar[(ptr * 4) + 5];
                    double y2 = thisChar[(ptr * 4) + 6];
                    lv_points.Items.Add( x1 + "," + y1 + "," + x2 + "," + y2);
                    segs++;
                }
                update_preview();
            }
            //MessageBox.Show(idx.ToString());
            
            
        }

        private void on_pointslv_change(object sender, EventArgs e)
        {
            lv_points.Columns[0].Width = lv_points.Width - 4 - SystemInformation.VerticalScrollBarWidth; 
        }

        private void on_charslv_change(object sender, EventArgs e)
        {
            lv_charmap.Columns[0].Width = lv_charmap.Width - 4 - SystemInformation.VerticalScrollBarWidth;
        }
        private void lv_points_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx;
            if (lv_points.SelectedItems.Count > 0)
            {
                idx = lv_points.Items.IndexOf(lv_points.SelectedItems[0]);
                selected_seg = idx;
                update_preview();
            }
        }

        private void add_input(object sender, EventArgs e)
        {
            if (lv_charmap.SelectedItems.Count != 0)
            {
                lv_points.Items.Insert(0, "5,5,-1,-1"); //adding input to the beginning so machine would draw the connection line first THAT ADDS THE PREV FIRST ELEMENT NOT 5,5,-1,-1 FIX!
                segs++;
                selected_seg = 0;
                for (int i = 0; i < segs; i++)
                {
                    lv_points.Items[i].Selected = false;
                    lv_points.Items[i].Focused = false;
                }
                lv_points.Items[0].Selected = true;
                lv_points.Items[0].Focused = true;
                setButton_Click(null, null); //Update the array
                lv_points.Items[0].Text = "5,5,-1,-1"; //sorry didn't have motivation to fix
            }
            else
            {


                tt.Show("Choose character to add the line", this, materialButton1.Location);
            }
        }
        private void add_output(object sender, EventArgs e)
        {
            if (lv_charmap.SelectedItems.Count != 0)
            {
                lv_points.Items.Add("-1,-1,10,10");
                segs++;
                selected_seg = segs - 1;
                for (int i = 0; i < segs; i++)
                {
                    lv_points.Items[i].Selected = false;
                    lv_points.Items[i].Focused = false;
                }
                lv_points.Items[segs - 1].Selected = true;
                lv_points.Items[segs - 1].Focused = true;


            }
            else
            {


                tt.Show("Choose character to add the line", this, materialButton2.Location);
            }
        }
        private void picture_box_click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if(drawCheckbox.Checked && lv_charmap.SelectedItems.Count != 0)
            {
                if(me.Button == MouseButtons.Right)
                {
                    clearButton_Click(null, null);
                }
            }
            if (tb_width.Text != "" && lv_charmap.SelectedItems.Count != 0 && !drawCheckbox.Checked)
            {
                int scale = 2;
                switch (me.Button)
                {
                    case MouseButtons.Left:
                        //MessageBox.Show((me.X).ToString() + "/" + (Convert.ToInt32(tb_width.Text) * scale).ToString() + "and" + (me.Y).ToString() + "/" + Convert.ToSingle(h_height) * scale);
                        if(lv_points.SelectedItems.Count != 0)
                        {
                            String[] sel = lv_points.SelectedItems[0].Text.Split(',');
                            double xCoord = me.X / scale;
                            double yCoord = me.Y / scale;
                            if (!(lv_points.SelectedItems[0].Index == 0) && Control.ModifierKeys != Keys.Alt) //Hold alt not to connect the line with the previous one 
                            {
                                String[] prevSel = lv_points.Items[lv_points.SelectedItems[0].Index - 1].Text.Split(','); //obtaining previous item and checking if it is close enough
                                if (Math.Abs(Convert.ToDouble(prevSel[2]) - xCoord) <= 3 && Math.Abs(Convert.ToDouble(prevSel[3]) - yCoord) <= 3)
                                {
                                    xCoord = Convert.ToDouble(prevSel[2]);
                                    yCoord = Convert.ToDouble(prevSel[3]);
                                }
                            }
                            
                           
                                sel[0] = xCoord.ToString();
                                sel[1] = yCoord.ToString();
                                lv_points.SelectedItems[0].Text = sel[0] + "," + sel[1] + "," + sel[2] + "," + sel[3];
                                save_selected_seg();
                        }
                        else
                        {
                            double xCoord = me.X / scale;
                            double yCoord = me.Y / scale;
                            if(lv_points.Items.Count != 0) //if there's at least one point - trying to check if the last point in the list is close
                            {
                                String[] prevSel = lv_points.Items[lv_points.Items.Count - 1].Text.Split(',');
                                if (Math.Abs(Convert.ToDouble(prevSel[2]) - xCoord) <= 3 && Math.Abs(Convert.ToDouble(prevSel[3]) - yCoord) <= 3)
                                {
                                    xCoord = Convert.ToDouble(prevSel[2]);
                                    yCoord = Convert.ToDouble(prevSel[3]);
                                }
                            }
                            lv_points.Items.Add(xCoord.ToString() + "," + yCoord.ToString() +",0,0"); //adding new item
                            for(int i = 0; i < segs; i++)
                            {
                                lv_points.Items[i].Selected = false;
                                lv_points.Items[i].Focused = false;
                            }
                            segs++;
                            selected_seg = segs - 1;
                            save_selected_seg();
                            lv_points.Items[segs - 1].Selected = true;
                            lv_points.Items[segs - 1].Focused = true;
                        }
                        break;
                    case MouseButtons.Right:
                        if(lv_points.SelectedItems.Count != 0)
                        {

                            String[] sel = lv_points.SelectedItems[0].Text.Split(',');
                            double xCoord = me.X / scale;
                            double yCoord = me.Y / scale;
                            if (!(lv_points.SelectedItems[0].Index == 0) && Control.ModifierKeys != Keys.Alt)
                            {
                                String[] prevSel = lv_points.Items[lv_points.SelectedItems[0].Index - 1].Text.Split(','); //obtaining previous item and checking if it is close enough
                                if (Math.Abs(Convert.ToDouble(prevSel[0]) - xCoord) <= 3 && Math.Abs(Convert.ToDouble(prevSel[1]) - yCoord) <= 3)
                                {
                                    xCoord = Convert.ToDouble(prevSel[0]);
                                    yCoord = Convert.ToDouble(prevSel[1]);
                                }
                            }
                            sel[2] = xCoord.ToString();
                            sel[3] = yCoord.ToString();
                            lv_points.SelectedItems[0].Text = sel[0] + "," + sel[1] + "," + sel[2] + "," + sel[3];
                            save_selected_seg();
                        }
                        else
                        {
                            double xCoord = me.X / scale;
                            double yCoord = me.Y / scale;
                            if (!(lv_points.SelectedItems[0].Index == 0) && Control.ModifierKeys != Keys.Alt)
                            {
                                String[] prevSel = lv_points.Items[lv_points.SelectedItems[0].Index - 1].Text.Split(','); //obtaining previous item and checking if it is close enough
                                if (Math.Abs(Convert.ToDouble(prevSel[0]) - xCoord) <= 3 && Math.Abs(Convert.ToDouble(prevSel[1]) - yCoord) <= 3)
                                {
                                    xCoord = Convert.ToDouble(prevSel[0]);
                                    yCoord = Convert.ToDouble(prevSel[1]);
                                }
                            }
                            lv_points.Items.Add("0,0," + xCoord.ToString() + "," + yCoord.ToString()); //adding new item
                            for (int i = 0; i < segs; i++)
                            {
                                lv_points.Items[i].Selected = false;
                                lv_points.Items[i].Focused = false;
                            }
                            segs++;
                            selected_seg = segs - 1;
                            save_selected_seg();
                            lv_points.Items[segs - 1].Selected = true;
                            lv_points.Items[segs - 1].Focused = true;
                        }
                        break;
                    case MouseButtons.Middle:
                        AddSegment_Click(null, null); //button 5 is add button - that func adds the point by middle mouse click
                        if (lv_points.SelectedItems.Count != 0)
                        {
                            String[] sel = lv_points.SelectedItems[0].Text.Split(',');
                            double xCoord = me.X / scale;
                            double yCoord = me.Y / scale;
                            if (!(lv_points.SelectedItems[0].Index == 0) && Control.ModifierKeys != Keys.Alt) //Hold alt not to connect the line with the previous one 
                            {
                                String[] prevSel = lv_points.Items[lv_points.SelectedItems[0].Index - 1].Text.Split(','); //obtaining previous item and checking if it is close enough
                                if (Math.Abs(Convert.ToDouble(prevSel[2]) - xCoord) <= 3 && Math.Abs(Convert.ToDouble(prevSel[3]) - yCoord) <= 3)
                                {
                                    xCoord = Convert.ToDouble(prevSel[2]);
                                    yCoord = Convert.ToDouble(prevSel[3]);
                                }
                            }


                            sel[0] = xCoord.ToString();
                            sel[1] = yCoord.ToString();
                            lv_points.SelectedItems[0].Text = sel[0] + "," + sel[1] + "," + sel[2] + "," + sel[3];
                            save_selected_seg();
                        }
                            break;
                }
                update_preview();
            }
        }

        private void remove_gaps(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection lvCol = lv_points.Items; //saving current lv_points
            double minX = 0;
            double maxX = 0;
            for(int i = 0; i < lvCol.Count; i++) //getting min and max of X
            {
                String[] sel = lvCol[i].Text.Split(',');
                if (i == 0) minX = Convert.ToDouble(sel[0]);
                if (Convert.ToDouble(sel[0]) < minX) minX = Convert.ToDouble(sel[0]); //obtaining minX
                if (Convert.ToDouble(sel[2]) < minX) minX = Convert.ToDouble(sel[2]);
                if (Convert.ToDouble(sel[0]) > maxX) maxX = Convert.ToDouble(sel[0]); //obtaining maxX
                if (Convert.ToDouble(sel[2]) > maxX) maxX = Convert.ToDouble(sel[2]);
            }
            //MessageBox.Show("Deleted successfully!:" + maxX + "/min:" + minX); 
            tb_width.Text = ((Single)(maxX - minX)).ToString();
            for (int i = 0; i < lvCol.Count; i++)
            {
                String[] sel = lvCol[i].Text.Split(',');
                int x1 = (int)(Convert.ToDouble(sel[0]) - minX);
                int x2 = (int)(Convert.ToDouble(sel[2]) - minX);
                lv_points.Items[i].Text = x1.ToString() + ',' + sel[1] + ',' + x2.ToString() + ',' + sel[3];
            }
            save_selected_seg();
            update_preview();


        }

        private void save_selected_seg()
        {
            //lv_points
            double[] new_seg = new double[lv_points.Items.Count * 4 + 3];
            new_seg[0] = Convert.ToSingle(tb_width.Text);   //width;
            new_seg[1] = Convert.ToSingle(tb_width.Text);   //realwidth;
            new_seg[2] = Convert.ToSingle(lv_points.Items.Count);   //size;
            int iteration = 0;
            for (int ptr = 0; ptr < lv_points.Items.Count*4; ptr += 4)
            {
                String[] this_seg = (lv_points.Items[iteration].Text).Split(',');
                new_seg[ptr + 3] = Convert.ToSingle(this_seg[0]);
                new_seg[ptr + 4] = Convert.ToSingle(this_seg[1]);
                new_seg[ptr + 5] = Convert.ToSingle(this_seg[2]);
                new_seg[ptr + 6] = Convert.ToSingle(this_seg[3]);
                iteration++;
            }
            font_chars[lv_charmap.SelectedItems[0].Index] = new_seg;
        }
        private void scaleFontBy5(object sender, EventArgs e) 
        {
            const string message =
       "That function will increase the font fivefold. Its main preposition is to convert fonts from older version of 3DWriter. Are you sure?";
            const string caption = "Font multiplying";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

      
            if (result == DialogResult.Yes)
            {
                for(int f = 0; f < FontComboBox.Items.Count; f++)
                {
                    FontComboBox.SelectedItem = FontComboBox.Items[f];
                    
                    for (int j = 0; j < lv_charmap.Items.Count; j++)
                    {
                    lv_charmap.Items[j].Selected = false;
                    lv_charmap.Items[j].Focused = false;
                    }
                    for (int j = 0; j < lv_charmap.Items.Count; j++) {
                    if (j != 0)
                    {
                        lv_charmap.Items[j - 1].Selected = false;
                     lv_charmap.Items[j - 1].Focused = false;
                    }
                    lv_charmap.Items[j].Selected = true;
                    lv_charmap.Items[j].Focused = true;
                    tb_width.Text = Convert.ToString(Convert.ToDouble(tb_width.Text) * 5);
                    double[] new_seg = new double[lv_points.Items.Count * 4 + 3];
                    new_seg[0] = Convert.ToSingle(tb_width.Text);   //width;
                    new_seg[1] = Convert.ToSingle(tb_width.Text);   //realwidth;
                    new_seg[2] = Convert.ToSingle(lv_points.Items.Count);   //size;
                    int iteration = 0;
                    for (int ptr = 0; ptr < lv_points.Items.Count * 4; ptr += 4)
                    {
                     String[] this_seg = (lv_points.Items[iteration].Text).Split(',');
                        new_seg[ptr + 3] = Convert.ToSingle(this_seg[0]) * 5;
                        new_seg[ptr + 4] = Convert.ToSingle(this_seg[1]) * 5;
                        new_seg[ptr + 5] = Convert.ToSingle(this_seg[2]) * 5;
                        new_seg[ptr + 6] = Convert.ToSingle(this_seg[3]) * 5;
                        iteration++;
                    }
                    font_chars[lv_charmap.SelectedItems[0].Index] = new_seg;
                
                    }
                    btn_save_as_Click(null, null); //clicking save button. Dev func only!
                }
            }
        }
        private void update_preview()
        {
            Pen bluePen = new Pen(System.Drawing.Brushes.Blue);
            bluePen.Width = 3.0F;
            Pen greenPen = new Pen(System.Drawing.Brushes.Green);
            greenPen.Width = 3.0F;


            if (lv_points.Items.Count == 0)
            {
                tt.Show("Choose valid character with at least one line to update the preview", this, button6.Location);
            }
            else
            {
                int scale = 2;
                Bitmap preview = new Bitmap(pb_editor.Width, pb_editor.Height);       //init the picturebox
                Graphics previewGraphics = Graphics.FromImage(preview);
                Pen semiTransPen = new Pen(Color.FromArgb(25, 255, 0, 0), 2);           //create a transparent red pen for the margins (offset)


                //height
                //previewGraphics.DrawLine(semiTransPen, 0 * scale, 0 * scale, Convert.ToSingle(tb_width.Text) * scale, 0 * scale);
                //previewGraphics.DrawLine(semiTransPen, 0 * scale, Convert.ToSingle(h_height) * scale, Convert.ToSingle(tb_width.Text) * scale, Convert.ToSingle(h_height) * scale);

                previewGraphics.DrawLine(semiTransPen, 0 * scale * 5, 0 * scale * 5, Convert.ToSingle(tb_width.Text) * scale, 0 * scale*5);
                previewGraphics.DrawLine(semiTransPen, 0 * scale * 5, Convert.ToSingle(h_height) * scale * 5, Convert.ToSingle(tb_width.Text) * scale , Convert.ToSingle(h_height) * scale * 5);

                //width
                //previewGraphics.DrawLine(semiTransPen, 0 * scale, 0 * scale, 0 * scale, Convert.ToSingle(h_height) * scale);
                //previewGraphics.DrawLine(semiTransPen, Convert.ToSingle(tb_width.Text) * scale, 0 * scale, Convert.ToSingle(tb_width.Text) * scale, Convert.ToSingle(h_height) * scale);
                previewGraphics.DrawLine(semiTransPen, 0 * scale * 5, 0 * scale * 5, 0 * scale * 5, Convert.ToSingle(h_height) * scale * 5);
                previewGraphics.DrawLine(semiTransPen, Convert.ToSingle(tb_width.Text) * scale, 0 * scale * 5, Convert.ToSingle(tb_width.Text) * scale, Convert.ToSingle(h_height) * scale * 5);


                for (int point = 0; point < segs; point++)
                {

                    String[] this_seg = (lv_points.Items[point].Text).Split(',');
                    if (!(Convert.ToDouble(this_seg[0]) < 0) && !(Convert.ToDouble(this_seg[3]) < 0)) previewGraphics.DrawLine((selected_seg == point ? Pens.Red : Pens.Blue), Convert.ToSingle(this_seg[0]) * scale, Convert.ToSingle(this_seg[1]) * scale, Convert.ToSingle(this_seg[2]) * scale, Convert.ToSingle(this_seg[3]) * scale);
                    if (selected_seg == point)
                    {
                        if (!(Convert.ToDouble(this_seg[0]) < 0) && !(Convert.ToDouble(this_seg[3]) < 0))
                        {
                            tb_x1.Text = this_seg[0] + "," + this_seg[1];
                            tb_x2.Text = this_seg[2] + "," + this_seg[3];

                            //draw starting point
                            previewGraphics.DrawEllipse(Pens.Red, (Convert.ToSingle(this_seg[0]) * scale) - 3, (Convert.ToSingle(this_seg[1]) * scale) - 3, 6, 6);
                        }
                        else if(Convert.ToDouble(this_seg[0]) > 0 && Convert.ToDouble(this_seg[3]) < 0) //entry point to the symbol - green
                        {
                            previewGraphics.DrawEllipse(greenPen, Convert.ToSingle(this_seg[0]) * scale - 3, Convert.ToSingle(this_seg[1]) * scale - 3, 6, 6);
                           
                        }
                        else  //out-point of symbol - blue
                        {
                            previewGraphics.DrawEllipse(bluePen, Convert.ToSingle(this_seg[2]) * scale - 3, (Convert.ToSingle(this_seg[3]) * scale) - 3, 6, 6);
                        }

                    }
                    if (!(Convert.ToDouble(this_seg[0]) < 0) && !(Convert.ToDouble(this_seg[3]) < 0))
                    {
                        //skip
                    }
                    else if (Convert.ToDouble(this_seg[0]) > 0 && Convert.ToDouble(this_seg[3]) < 0) //entry point to the symbol - green
                    {
                        previewGraphics.DrawEllipse(greenPen, Convert.ToSingle(this_seg[0]) * scale - 3, Convert.ToSingle(this_seg[1]) * scale - 3, 6, 6);

                    }
                    else  //out-point of symbol - blue
                    {
                        previewGraphics.DrawEllipse(bluePen, Convert.ToSingle(this_seg[2]) * scale - 3, (Convert.ToSingle(this_seg[3]) * scale) - 3, 6, 6);
                    }
                }

                pb_editor.Image = preview;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update_preview();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                lv_points.Items[selected_seg].Text = tb_x1.Text + "," + tb_x2.Text;
                update_preview();

                //lv_points
                /*double[] new_seg = new double[250];
                new_seg[0] = Convert.ToSingle(tb_width.Text);   //width;
                new_seg[1] = Convert.ToSingle(tb_width.Text);   //realwidth;
                new_seg[2] = Convert.ToSingle(lv_points.Items.Count);   //size;

                for(int ptr=0; ptr< lv_points.Items.Count; ptr++)
                {
                    String[] this_seg = (lv_points.Items[selected_seg].Text).Split(',');
                    new_seg[ptr + 3] = Convert.ToSingle(this_seg[0]);
                    new_seg[ptr + 4] = Convert.ToSingle(this_seg[1]);
                    new_seg[ptr + 5] = Convert.ToSingle(this_seg[2]);
                    new_seg[ptr + 6] = Convert.ToSingle(this_seg[3]);
                }
                font_chars[selected_seg] = new_seg;*/
                save_selected_seg();
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                //Ignored
            }
        }

        private void AddSegment_Click(object sender, EventArgs e)
        {
            if (lv_charmap.SelectedItems.Count != 0) 
            { 
            lv_points.Items.Add("0,0,0,0");
            segs++;
                selected_seg = segs - 1;
                for (int i = 0; i < segs; i++)
                {
                    lv_points.Items[i].Selected = false;
                    lv_points.Items[i].Focused = false;
                }
                lv_points.Items[segs - 1].Selected = true;
                lv_points.Items[segs - 1].Focused = true;
              
                
            }
            else
            { 
                tt.Show("Choose character to add the line", this, button5.Location);
            }

        }

        private void button_Leave(object sender, EventArgs e)
        {   
                tt.Hide(this);
        }

        private void deleteSegment_Click(object sender, EventArgs e)
        {
            if (lv_points.SelectedItems.Count != 0)
            {
                if (lv_points.Items.Count == 1) //if there's only one item it sets it to 0;0 - 0;0
                {
                    lv_points.Items.Remove(lv_points.SelectedItems[0]);
                    lv_points.Items.Insert(0, "0,0,0,0");
                    lv_points.Items[0].Selected = true;
                    update_preview();
                }
                else
                {   //if > 1 - removes it.
                    lv_points.Items.Remove(lv_points.SelectedItems[0]);
                    segs--;
                    selected_seg = segs - 1;
                    if (selected_seg < 0) selected_seg = 0;
                    else lv_points.Items[selected_seg].Selected = true;
                    update_preview(); //buttons' listener just updates the array to currentlistview
                                      //update_preview();
                }
            }
     
            else
            {
                if (lv_points.Items.Count != 0)
                {
                    lv_points.Items[segs - 1].Selected = true;
                    lv_points.Items[segs - 1].Focused = true;

                }
                else
                {
                    tt.Show("Choose character and line to remove", this, button2.Location);
                }
                
            }
            setButton_Click(null, null); //clicks set button
        }

        private void btn_add_char_Click(object sender, EventArgs e)
        {
        

            if (tb_char_to_add.Text.Length != 1)
            {
               
                tt.Show("Please enter a single character", this, btn_add_char.Location);
            }
            else
            {

              
                lv_charmap.Items.Add(tb_char_to_add.Text);
                font_chars[lv_charmap.Items.Count] = new double[7];
                font_chars[lv_charmap.Items.Count][0] = 5;
                font_chars[lv_charmap.Items.Count][1] = 5;
                font_chars[lv_charmap.Items.Count][2] = 4;
                font_chars[lv_charmap.Items.Count][3] = 0;
                font_chars[lv_charmap.Items.Count][4] = 20;
                font_chars[lv_charmap.Items.Count][5] = 5;
                font_chars[lv_charmap.Items.Count][6] = 20;

            }
        }

        private void open_image(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|JPG/JPEG files|*.jpg;*.jpeg|PNG files|*.png";
            openFileDialog.RestoreDirectory = true;
            String filePath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(openFileDialog.FileName);
                pb_editor.BackgroundImage = bm;
                pb_editor.BackColor = Color.Transparent;
            }
        }

        private void switch_transparency(object sender, EventArgs e)
        {
            if (transpModeOn)
            {
                this.Opacity = 1.0;
                this.TopMost = false;
                transpModeOn = false;
            }
            else
            {
                this.Opacity = 0.6;
                this.TopMost = true;
                transpModeOn = true;
            }
        }
        private void btn_save_as_Click(object sender, EventArgs e)
        {
            //btn_save_as
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "custom.cmf";
            if (FontComboBox.SelectedItem != null) save.FileName = FontComboBox.SelectedItem + ".cmf";
            save.Filter = "cmf File | *.cmf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string output = "";

                /*
                if (counter == 0) { Double.TryParse(line, out h_char_count); }          //first line: Character count
                if (counter == 1) { Double.TryParse(line, out h_height); }              //second line: Character height
                if (counter == 2) { h_font_map = line; }                                //third line: Character map
                */

                output += lv_charmap.Items.Count + "\n";
                output += h_height.ToString() + "\n";

                for (int ptr = 0; ptr < lv_charmap.Items.Count; ptr++)
                {
                    output += lv_charmap.Items[ptr].Text;
                }
                output += "\n";
                

                for (int ptr = 0; ptr < lv_charmap.Items.Count; ptr++)
                {
                    for(int aa=0; aa< font_chars[ptr].Length; aa++)
                    {
                        output += font_chars[ptr][aa];
                        if (!(aa == font_chars[ptr].Length - 1)) output += ",";
                    }
         
                    output += "\n";
                }


                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(output);
                writer.Dispose();
                writer.Close();
            }
        }

      

        public void ProcessCallBackDrawing(List<String> points)
        {
            for(int i = 0; i < points.Count; i++)
            {
                string[] curPoints = points[i].Split(',');
                if(curPoints.Length == 4) //checking if there is correct argument
                {
                    if (lv_charmap.SelectedItems.Count != 0)
                    {
                        lv_points.Items.Add(points[i]);
                        segs++;
                        selected_seg = segs - 1;
                        for (int j = 0; j < segs; j++)
                        {
                            lv_points.Items[j].Selected = false;
                            lv_points.Items[j].Focused = false;
                        }
                        lv_points.Items[segs - 1].Selected = true;
                        lv_points.Items[segs - 1].Focused = true;
                    }
                    else
                    {
                        tt.Show("Choose character to add the line", this, materialButton2.Location);

                    }
                }
            }
            setButton_Click(null, null);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (lv_points.Items.Count != 0)
            {
                lv_points.Items.Clear();
                lv_points.Items.Add("0,0,0,0");
                segs = 1;
                selected_seg = 0;
                lv_points.Items[0].Selected = true;
                lv_points.Items[0].Focused = true;
                setButton_Click(null, null); //Update the array
                update_preview();
            }
        }


        private void pb_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            pointsCounter = 0;
            lastPoint = e.Location;
            pointCollection.Add(e.Location);
            isMouseDown = true;
        }

        private void pb_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (drawCheckbox.Checked)
            {
                try
                {
                    IList<Point> simplifiedPointsLine = SimplificationHelpers.Simplify<Point>(
                        pointCollection,
                        (p1, p2) => p1 == p2,
                        (p) => p.X,
                        (p) => p.Y,
                        Convert.ToDouble(tolerance_textbox.Text),
                        hq_checkbox.Checked
                        );
                    pointCollection = new List<Point>();
                    outputPointsLabel.Text = "Output points: " + simplifiedPointsLine.Count;
                    if(tb_width.Text != "" && lv_charmap.SelectedItems.Count != 0)
                    {
                        for(int i = 0; i < simplifiedPointsLine.Count - 1; i++) //iterating through every point except the last one because line builds of two points - this and next
                        {
                          
                            lv_points.Items.Add(simplifiedPointsLine[i].X / 2 + "," + simplifiedPointsLine[i].Y / 2 + "," + (simplifiedPointsLine[i+1].X / 2 + "," + simplifiedPointsLine[i+1].Y / 2));
                            segs++;
                        }
                        selected_seg = segs - 1;
                        for (int i = 0; i < segs; i++)
                        {
                            lv_points.Items[i].Selected = false;
                            lv_points.Items[i].Focused = false;
                        }
                        lv_points.Items[segs - 1].Selected = true;
                        lv_points.Items[segs - 1].Focused = true;
                        setButton_Click(null, null); //save points
                    }
                    else
                    {
                        MessageBox.Show("Select the char and enter the width first!");
                    }
                    
                }
                catch(FormatException exep)
                {
                    MessageBox.Show("Tolerance value is incorrect!");
                }
                //simplifying the pointcollection
            }
        }

        private void pb_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && drawCheckbox.Checked)
            {
                if (lastPoint != null)
                {
                    using (Graphics g = Graphics.FromImage(pb_editor.Image))
                    {
                        g.DrawLine(pen, lastPoint, e.Location);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    }
                    pb_editor.Invalidate();
                    lastPoint = e.Location;
                    pointCollection.Add(new System.Drawing.Point(e.Location.X, e.Location.Y));
                    pointsCounter = pointCollection.Count;
                    PointsAmountLabel.Text = "Points: " + pointsCounter;
                }
            }
        }

        

        private void bottomWritingLineArrow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bottomWritingLineArrow.Location = new Point(bottomWritingLineArrow.Location.X, Convert.ToInt32(e.Location.Y + bottomWritingLineArrow.Location.Y - bottomWritingLineArrow.Height/2));
                bottomLineDrawing.Location = new Point(bottomLineDrawing.Location.X, Convert.ToInt32(e.Location.Y + bottomWritingLineArrow.Location.Y - bottomLineDrawing.Height / 2));
            }
        }

        private void topWritingLineArrow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                topWritingLineArrow.Location = new Point(topWritingLineArrow.Location.X, Convert.ToInt32(e.Location.Y + topWritingLineArrow.Location.Y - topWritingLineArrow.Height / 2));
                topLineDrawing.Location = new Point(topLineDrawing.Location.X, Convert.ToInt32(e.Location.Y + topWritingLineArrow.Location.Y - topLineDrawing.Height / 2));
            }
        }
    }
}
