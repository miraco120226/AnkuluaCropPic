using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkuluaCropPic
{
    public partial class Form1 : Form
    {
        string strFileName;
        string strInputFilePath;
        string strFileNameEx;
        string ImgFileName;
        Image sourceImage;
        Image viewImage;

        int objHeight = 0;
        int ImgWidth = 1920;
        int ImgHeight = 1080;
        int ImgBoxWidth = 640;
        int ImgBoxHeight = 360;
        bool horizon = true;
        double magnification;
        const int space = 10;
        const int btuFontSize = 10;

        private Point RectStartPoint;                         // imageBoxInput's ROI 起始點 (picture coordinates)
        private Rectangle Rect = new Rectangle();             // imageBoxInput's ROI (picture coordinates)
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 64, 64, 64)); // 128: 透明度
        Image outputFileImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            magnification = (double)ImgWidth / ImgBoxWidth;

            inputImg.Size = new Size(ImgBoxWidth, ImgBoxHeight);
            inputImg.Location = new Point(space, space);
            inputImg.AllowDrop = true;

            rightPanel.Font = new Font("微軟正黑體", btuFontSize, FontStyle.Regular);
            rightPanel.Location= new Point(space * 3 + ImgBoxWidth, 0);

            pathLabel2.Text = "";
            ImgpathLabel2.Text = "";

            setHorizonLarge();
        }

        private int CalHeight(int height)
        {
            if (objHeight == 0)
                objHeight += space * 2;
            int tmpHeight = objHeight;
            objHeight += height + space * 2;

            return tmpHeight;
        }

        private void setCodeTxt()
        {
            /*
              = ".png"
              reg = Region()
            */
            string result;
            int x = Math.Max((int)Math.Floor(Rect.Location.X * magnification) - 1, 0);
            int y = Math.Max((int)Math.Floor(Rect.Location.Y * magnification) - 1, 0);
            int cx = Math.Min((int)Math.Floor(Rect.Width * magnification) + 1, ImgWidth);
            int cy = Math.Min((int)Math.Floor(Rect.Height * magnification) + 1, ImgHeight);
            string ex = strFileNameEx == null ? ".png" : strFileNameEx;

            result = ImgFileName + "=\"" + ImgFileName + ex + "\"" + "\r\n" + ImgFileName + "reg=Region(" + x + "," + y + "," + cx + "," + cy + ")";
            outputCode.Text = result;
        }

        private void setInputImg(string src)
        {
            try
            {
                Image tmp = Image.FromFile(src);
                horizon = tmp.Height < tmp.Width;

                if (horizon)
                {
                    setHorizonLarge();
                    tmp.Dispose();
                }
                else
                {
                    setVerticalLarge();
                    tmp.Dispose();
                }

                strFileName = src;
                sourceImage = Image.FromFile(strFileName);
                ImgWidth = sourceImage.Width;
                ImgHeight = sourceImage.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show("不是有效的圖檔格式");
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                if (!rememCheckBox.Checked || ImgpathLabel2.Text.Length == 0)
                {
                    strInputFilePath = strFileName.Substring(0, strFileName.LastIndexOf("\\") + 1);
                }                    
                strFileNameEx = strFileName.Substring(strFileName.LastIndexOf("."));
                setImgPathLabel2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                strInputFilePath = null;
            }

            pathLabel2.Text = strFileName;

            Image tmpImg = new Bitmap(ImgBoxWidth, ImgBoxHeight);

            Graphics g = Graphics.FromImage(tmpImg);
            g.InterpolationMode = InterpolationMode.High;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            g.DrawImage(sourceImage, new Rectangle(0, 0, ImgBoxWidth, ImgBoxHeight), new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), GraphicsUnit.Pixel);

            viewImage = (Image)tmpImg.Clone();

            inputImg.Image = viewImage;
        }

        private void setImgPathLabel2()
        { 
            ImgpathLabel2.Text = strInputFilePath + ImgFileName ;
            if(ImgFileName != null && ImgFileName.Length != 0)
            {
                ImgpathLabel2.Text +=  strFileNameEx;
            }
        }

        private void openImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            setInputImg(openFileDialog1.FileName);
        }

        private void setPath_Click(object sender, EventArgs e)
        {
            if (strFileName != null)
            {
                folderBrowserDialog1.SelectedPath = strInputFilePath;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                strInputFilePath = folderBrowserDialog1.SelectedPath;
                if (!strInputFilePath.EndsWith("\\") )
                {
                    strInputFilePath += '\\';
                }
                Console.WriteLine(strInputFilePath);
                setImgPathLabel2();
            }
        }

        private void inputImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (sourceImage == null)
                return;
            Rect = new Rectangle();
            ((PictureBox)sender).Invalidate();
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void inputImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (sourceImage == null || e.Button != MouseButtons.Left)   // 如果移動中同時按下左鍵繼續往下, 否則離開
                return;

            int endX = Math.Min(e.Location.X, ImgBoxWidth);
            int endY = Math.Min(e.Location.Y, ImgBoxHeight);

            Rect.Location = new Point(
                  Math.Min(RectStartPoint.X, endX),
                  Math.Min(RectStartPoint.Y, endY));
            Rect.Size = new Size(
                  Math.Abs(RectStartPoint.X - endX),
                  Math.Abs(RectStartPoint.Y - endY));

            ((PictureBox)sender).Invalidate();

        }

        private void inputImg_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine(Rect.Location.X+","+ Rect.Location.Y + ","+ Rect.Width + ","+ Rect.Height );
            if (sourceImage == null || Rect.Height == 0 || Rect.Width == 0)
            {
                outputCode.Text = ImgFileName + "=" + ImgFileName + strFileNameEx + "\r\n" + ImgFileName + "reg=Region(0,0,0,0)";
                return;
            }
                
            
            //建立新的影像
            Image cropImage = new Bitmap(Rect.Width, Rect.Height) as Image;
            //準備繪製新的影像
            Graphics graphics2 = Graphics.FromImage(cropImage);
            //於座標(0,0)開始繪製裁切影像
            graphics2.DrawImage(viewImage, 0, 0, Rect, GraphicsUnit.Pixel);
            graphics2.Dispose();

            setCodeTxt();

            int x = Math.Max((int)Math.Floor(Rect.Location.X * magnification), 0);
            int y = Math.Max((int)Math.Floor(Rect.Location.Y * magnification), 0);
            int cx = Math.Min((int)Math.Floor(Rect.Width * magnification), ImgWidth);
            int cy = Math.Min((int)Math.Floor(Rect.Height * magnification), ImgHeight);
            Rectangle output_rect = new Rectangle(x,y,cx,cy);

            outputFileImage = new Bitmap(output_rect.Width, output_rect.Height) as Image;
            Graphics graphics3 = Graphics.FromImage(outputFileImage);
            //於座標(0,0)開始繪製裁切影像
            graphics3.DrawImage(Image.FromFile(strFileName), 0 , 0, output_rect, GraphicsUnit.Pixel);
            graphics3.Dispose();

        }

        private void inputImg_Paint(object sender, PaintEventArgs e)
        {
            if (sourceImage == null)
            {
                Brush br = new SolidBrush(Color.FromArgb(240, 240, 240));
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
            }
            if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
            {
                e.Graphics.SetClip(Rect, System.Drawing.Drawing2D.CombineMode.Exclude);
                e.Graphics.FillRectangle(selectionBrush, new Rectangle(0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
            }
        }

        private void outputImg_Paint(object sender, PaintEventArgs e)
        {
            if (viewImage == null)
            {
                Brush br = new SolidBrush(Color.FromArgb(240, 240, 240));
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
            }
        }

        private void ImgName_TextChanged(object sender, EventArgs e)
        {
            ImgFileName = ImgName.Text;
            if (strInputFilePath!=null && strInputFilePath.Length != 0)
            {
                setImgPathLabel2();
            }
            setCodeTxt();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if(Rect.Height == 0 || Rect.Width == 0 )
            {
                MessageBox.Show("請先框選出一個範圍");
                return;
            }
            if (ImgName.Text.Length == 0)
            {
                MessageBox.Show("請先輸入檔名");
                return;
            }
            Clipboard.SetDataObject(outputCode.Text);
            try
            {
                outputFileImage.Save(ImgpathLabel2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("圖檔輸出錯誤：" + ex.Message);
            }
            
        }

        private void inputImg_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileNameW"))
            {
                string[] data = (e.Data.GetData("FileNameW") as string[]);
                try
                {
                    //拖曳檔案是否存在
                    if (File.Exists(data[0]))
                    {
                        setInputImg(data[0]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("不是有效的圖檔格式");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void inputImg_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileNameW"))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void smallScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (smallScreen.Checked)
            {
                if (horizon)
                {
                    setHorizonSmall();
                }
                else
                {
                    setVerticalSmall();
                }
                
            }
        }

        private void largeScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (largeScreen.Checked)
            {
                if (horizon)
                {
                    setHorizonLarge();
                }
                else
                {
                    setVerticalLarge();
                }
            }

        }

        public void clean()
        {
            sourceImage = null;
            viewImage = null;
            outputFileImage = null;

            strFileName = null;
            strInputFilePath = null;
            strFileNameEx = null;
            ImgFileName = null;

            ImgName.Text = "";
            pathLabel2.Text = "";
            ImgpathLabel2.Text = "";

            Rect = new Rectangle();
            RectStartPoint = new Point(0, 0);
            inputImg.Refresh();
        }

        public void setVerticalSmall()
        {
            ImgBoxWidth = 270;
            ImgBoxHeight = 480;
            magnification = (double)ImgWidth / ImgBoxWidth;

            flowLayoutPanel2.Width = ImgBoxWidth + rightPanel.Width + 50;
            flowLayoutPanel2.Height = Math.Max(ImgBoxHeight + 70, rightPanel.Height + 50);
            Width = flowLayoutPanel2.Width;
            Height = flowLayoutPanel2.Height;

            inputImg.Size = new Size(ImgBoxWidth, ImgBoxHeight);

            clean();
        }

        public void setVerticalLarge()
        {
            ImgBoxWidth = 360;
            ImgBoxHeight = 640;
            magnification = (double)ImgWidth / ImgBoxWidth;

            flowLayoutPanel2.Width = ImgBoxWidth + rightPanel.Width + 50;
            flowLayoutPanel2.Height = Math.Max(ImgBoxHeight + 70, rightPanel.Height + 50);
            Width = flowLayoutPanel2.Width;
            Height = flowLayoutPanel2.Height;

            inputImg.Size = new Size(ImgBoxWidth, ImgBoxHeight);

            clean();
        }

        public void setHorizonSmall()
        {
            ImgBoxWidth = 480;
            ImgBoxHeight = 270;
            magnification = (double)ImgWidth / ImgBoxWidth;

            flowLayoutPanel2.Width = ImgBoxWidth + rightPanel.Width + 50;
            flowLayoutPanel2.Height = Math.Max(ImgBoxHeight + 70, rightPanel.Height + 50);
            Width = flowLayoutPanel2.Width;
            Height = flowLayoutPanel2.Height;

            inputImg.Size = new Size(ImgBoxWidth, ImgBoxHeight);

            clean();
        }

        public void setHorizonLarge()
        {
            ImgBoxWidth = 640;
            ImgBoxHeight = 360;
            magnification = (double)ImgWidth / ImgBoxWidth;

            flowLayoutPanel2.Width = ImgBoxWidth + rightPanel.Width + 50;
            flowLayoutPanel2.Height = Math.Max(ImgBoxHeight + 70, rightPanel.Height + 50);
            Width = flowLayoutPanel2.Width;
            Height = flowLayoutPanel2.Height;

            inputImg.Size = new Size(ImgBoxWidth, ImgBoxHeight);

            clean();
        }

    }
}
