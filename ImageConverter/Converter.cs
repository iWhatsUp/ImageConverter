using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ImageConverter
{
   public partial class Converter : MetroForm
   {
      private readonly OpenFileDialog fileDialog = new OpenFileDialog
      {
         Filter = "Image Files | *.png; *.jpg; *.bmp; *.ico; *.gif;"
      };

      public Converter()
      {
         InitializeComponent();

         string[] ImageFormats = new string[] { "png", "jpeg", "bmp", "ico", "gif" };

         for (byte i = 0; i < ImageFormats.Length; i++)
         {
            FormatImage.Items.Add(ImageFormats[i]);
         }
      }

      private void OpenImage_Click(object sender, EventArgs e)
      {
         if (fileDialog.ShowDialog() == DialogResult.OK)
         {
            Image.Image = System.Drawing.Image.FromFile(fileDialog.FileName);
         }
      }

      private void ClearIMG_Click(object sender, EventArgs e) => Image.Image = null;

      private async void Convert_Click(object sender, EventArgs e)
      {
         if (Image.Image != null)
         {
            OpenImage.Enabled = false; Convert.Enabled = false;

            await Task.Run(() =>
            {
               using (Image img = System.Drawing.Image.FromFile(fileDialog.FileName))
               {
                  string fileSaveName = Path.Combine($"{fileDialog.FileName}.{FormatImage.Text}");

                  switch (FormatImage.Text)
                  {
                     case "png":
                        img.Save(fileSaveName, ImageFormat.Png); break;

                     case "jpeg":
                        img.Save(fileSaveName, ImageFormat.Jpeg); break;

                     case "bmp":
                        img.Save(fileSaveName, ImageFormat.Bmp); break;

                     case "gif":
                        img.Save(fileSaveName, ImageFormat.Gif); break;

                     case "ico":
                        using (var bitmap = new Bitmap(img))
                        {
                           using (var icon = Icon.FromHandle(bitmap.GetHicon()))
                           {
                              using (var stream = new FileStream(fileSaveName, FileMode.Create))
                              {
                                 icon.Save(stream);
                              }
                           }
                        }
                        break;
                  }
               }
            });

            OpenImage.Enabled = true; Convert.Enabled = true;
         }
         else
         {
            MessageBox.Show("First add image with button 'Add IMG'.", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }
   }
}