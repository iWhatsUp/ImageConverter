
namespace ImageConverter
{
   partial class Converter
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null)) components.Dispose();

         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.OpenImage = new System.Windows.Forms.Button();
         this.Image = new System.Windows.Forms.PictureBox();
         this.Convert = new System.Windows.Forms.Button();
         this.FormatImage = new System.Windows.Forms.DomainUpDown();
         this.ClearIMG = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.ForeColor = System.Drawing.SystemColors.Control;
         this.label1.Location = new System.Drawing.Point(93, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(161, 35);
         this.label1.TabIndex = 0;
         this.label1.Text = "iConverter";
         // 
         // OpenImage
         // 
         this.OpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
         this.OpenImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.OpenImage.FlatAppearance.BorderSize = 0;
         this.OpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.OpenImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.OpenImage.ForeColor = System.Drawing.SystemColors.Control;
         this.OpenImage.Location = new System.Drawing.Point(21, 254);
         this.OpenImage.Name = "OpenImage";
         this.OpenImage.Size = new System.Drawing.Size(100, 52);
         this.OpenImage.TabIndex = 1;
         this.OpenImage.TabStop = false;
         this.OpenImage.Text = "Add IMG";
         this.OpenImage.UseVisualStyleBackColor = false;
         this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
         // 
         // Image
         // 
         this.Image.BackColor = System.Drawing.Color.Black;
         this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.Image.Location = new System.Drawing.Point(21, 73);
         this.Image.Name = "Image";
         this.Image.Size = new System.Drawing.Size(317, 161);
         this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.Image.TabIndex = 2;
         this.Image.TabStop = false;
         // 
         // Convert
         // 
         this.Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
         this.Convert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.Convert.FlatAppearance.BorderSize = 0;
         this.Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Convert.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.Convert.ForeColor = System.Drawing.SystemColors.Control;
         this.Convert.Location = new System.Drawing.Point(232, 254);
         this.Convert.Name = "Convert";
         this.Convert.Size = new System.Drawing.Size(106, 52);
         this.Convert.TabIndex = 3;
         this.Convert.TabStop = false;
         this.Convert.Text = "Convert";
         this.Convert.UseVisualStyleBackColor = false;
         this.Convert.Click += new System.EventHandler(this.Convert_Click);
         // 
         // FormatImage
         // 
         this.FormatImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
         this.FormatImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.FormatImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.FormatImage.ForeColor = System.Drawing.SystemColors.Control;
         this.FormatImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.FormatImage.Location = new System.Drawing.Point(129, 254);
         this.FormatImage.Name = "FormatImage";
         this.FormatImage.ReadOnly = true;
         this.FormatImage.Size = new System.Drawing.Size(97, 23);
         this.FormatImage.TabIndex = 4;
         this.FormatImage.TabStop = false;
         this.FormatImage.Text = "Format";
         this.FormatImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.FormatImage.Wrap = true;
         // 
         // ClearIMG
         // 
         this.ClearIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.ClearIMG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.ClearIMG.FlatAppearance.BorderSize = 0;
         this.ClearIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ClearIMG.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ClearIMG.ForeColor = System.Drawing.SystemColors.Control;
         this.ClearIMG.Location = new System.Drawing.Point(129, 283);
         this.ClearIMG.Name = "ClearIMG";
         this.ClearIMG.Size = new System.Drawing.Size(97, 23);
         this.ClearIMG.TabIndex = 5;
         this.ClearIMG.TabStop = false;
         this.ClearIMG.Text = "Clear IMG";
         this.ClearIMG.UseVisualStyleBackColor = false;
         this.ClearIMG.Click += new System.EventHandler(this.ClearIMG_Click);
         // 
         // Converter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.ClientSize = new System.Drawing.Size(355, 321);
         this.ControlBox = false;
         this.Controls.Add(this.ClearIMG);
         this.Controls.Add(this.FormatImage);
         this.Controls.Add(this.Convert);
         this.Controls.Add(this.Image);
         this.Controls.Add(this.OpenImage);
         this.Controls.Add(this.label1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Converter";
         this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
         this.ShowIcon = false;
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.Style = MetroFramework.MetroColorStyle.Purple;
         this.Theme = MetroFramework.MetroThemeStyle.Dark;
         ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button OpenImage;
      private System.Windows.Forms.PictureBox Image;
      private System.Windows.Forms.Button Convert;
      private System.Windows.Forms.DomainUpDown FormatImage;
      private System.Windows.Forms.Button ClearIMG;
   }
}

