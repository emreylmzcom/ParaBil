﻿namespace ParaBil
{
    partial class ParaBil
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaBil));
            this.menu = new System.Windows.Forms.Panel();
            this.menu_sil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.emre = new System.Windows.Forms.Label();
            this.menu_profil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menu_durum = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menu_ekle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menu_ozet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.min = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.max = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.icerik = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.menu_sil);
            this.menu.Controls.Add(this.emre);
            this.menu.Controls.Add(this.menu_profil);
            this.menu.Controls.Add(this.kryptonButton3);
            this.menu.Controls.Add(this.menu_durum);
            this.menu.Controls.Add(this.menu_ekle);
            this.menu.Controls.Add(this.menu_ozet);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(160, 720);
            this.menu.TabIndex = 16;
            // 
            // menu_sil
            // 
            this.menu_sil.Location = new System.Drawing.Point(12, 304);
            this.menu_sil.Name = "menu_sil";
            this.menu_sil.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_sil.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_sil.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_sil.OverrideDefault.Border.Rounding = 18;
            this.menu_sil.OverrideDefault.Border.Width = 1;
            this.menu_sil.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.menu_sil.Size = new System.Drawing.Size(129, 38);
            this.menu_sil.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.StateCommon.Back.ColorAngle = 45F;
            this.menu_sil.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_sil.StateCommon.Border.ColorAngle = 45F;
            this.menu_sil.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_sil.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_sil.StateCommon.Border.Rounding = 18;
            this.menu_sil.StateCommon.Border.Width = 1;
            this.menu_sil.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.menu_sil.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.menu_sil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_sil.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_sil.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_sil.StateTracking.Back.ColorAngle = 45F;
            this.menu_sil.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_sil.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_sil.StateTracking.Border.ColorAngle = 45F;
            this.menu_sil.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_sil.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_sil.StateTracking.Border.Rounding = 18;
            this.menu_sil.StateTracking.Border.Width = 1;
            this.menu_sil.TabIndex = 17;
            this.menu_sil.TabStop = false;
            this.menu_sil.Values.Text = "İşlemlerim";
            this.menu_sil.Click += new System.EventHandler(this.menu_sil_Click);
            // 
            // emre
            // 
            this.emre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emre.AutoSize = true;
            this.emre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emre.Location = new System.Drawing.Point(21, 692);
            this.emre.Name = "emre";
            this.emre.Size = new System.Drawing.Size(120, 19);
            this.emre.TabIndex = 16;
            this.emre.Text = "EMREYLMZ.COM";
            this.emre.Click += new System.EventHandler(this.emre_Click);
            // 
            // menu_profil
            // 
            this.menu_profil.Location = new System.Drawing.Point(12, 393);
            this.menu_profil.Name = "menu_profil";
            this.menu_profil.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_profil.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_profil.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_profil.OverrideDefault.Border.Rounding = 18;
            this.menu_profil.OverrideDefault.Border.Width = 1;
            this.menu_profil.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.menu_profil.Size = new System.Drawing.Size(129, 38);
            this.menu_profil.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.StateCommon.Back.ColorAngle = 45F;
            this.menu_profil.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_profil.StateCommon.Border.ColorAngle = 45F;
            this.menu_profil.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_profil.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_profil.StateCommon.Border.Rounding = 18;
            this.menu_profil.StateCommon.Border.Width = 1;
            this.menu_profil.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.menu_profil.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.menu_profil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_profil.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_profil.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_profil.StateTracking.Back.ColorAngle = 45F;
            this.menu_profil.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_profil.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_profil.StateTracking.Border.ColorAngle = 45F;
            this.menu_profil.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_profil.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_profil.StateTracking.Border.Rounding = 18;
            this.menu_profil.StateTracking.Border.Width = 1;
            this.menu_profil.TabIndex = 15;
            this.menu_profil.TabStop = false;
            this.menu_profil.Values.Text = "Profil";
            this.menu_profil.Click += new System.EventHandler(this.menu_profil_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonButton3.Location = new System.Drawing.Point(53, 620);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Border.Rounding = 18;
            this.kryptonButton3.OverrideDefault.Border.Width = 1;
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton3.Size = new System.Drawing.Size(50, 50);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton3.StateCommon.Back.Image")));
            this.kryptonButton3.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StateCommon.Border.Rounding = 18;
            this.kryptonButton3.StateCommon.Border.Width = 1;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StatePressed.Back.ColorAngle = 45F;
            this.kryptonButton3.StatePressed.Border.Color1 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StatePressed.Border.Color2 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StatePressed.Border.ColorAngle = 45F;
            this.kryptonButton3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StatePressed.Border.Rounding = 18;
            this.kryptonButton3.StatePressed.Border.Width = 1;
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StateTracking.Border.Color2 = System.Drawing.Color.Lavender;
            this.kryptonButton3.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StateTracking.Border.Rounding = 18;
            this.kryptonButton3.StateTracking.Border.Width = 1;
            this.kryptonButton3.TabIndex = 14;
            this.kryptonButton3.Values.Text = "";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // menu_durum
            // 
            this.menu_durum.Location = new System.Drawing.Point(12, 349);
            this.menu_durum.Name = "menu_durum";
            this.menu_durum.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_durum.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_durum.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_durum.OverrideDefault.Border.Rounding = 18;
            this.menu_durum.OverrideDefault.Border.Width = 1;
            this.menu_durum.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.menu_durum.Size = new System.Drawing.Size(129, 38);
            this.menu_durum.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.StateCommon.Back.ColorAngle = 45F;
            this.menu_durum.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_durum.StateCommon.Border.ColorAngle = 45F;
            this.menu_durum.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_durum.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_durum.StateCommon.Border.Rounding = 18;
            this.menu_durum.StateCommon.Border.Width = 1;
            this.menu_durum.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.menu_durum.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.menu_durum.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_durum.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_durum.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_durum.StateTracking.Back.ColorAngle = 45F;
            this.menu_durum.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_durum.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_durum.StateTracking.Border.ColorAngle = 45F;
            this.menu_durum.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_durum.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_durum.StateTracking.Border.Rounding = 18;
            this.menu_durum.StateTracking.Border.Width = 1;
            this.menu_durum.TabIndex = 12;
            this.menu_durum.TabStop = false;
            this.menu_durum.Values.Text = "Durum";
            this.menu_durum.Click += new System.EventHandler(this.menu_durum_Click);
            // 
            // menu_ekle
            // 
            this.menu_ekle.Location = new System.Drawing.Point(12, 260);
            this.menu_ekle.Name = "menu_ekle";
            this.menu_ekle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_ekle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_ekle.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ekle.OverrideDefault.Border.Rounding = 18;
            this.menu_ekle.OverrideDefault.Border.Width = 1;
            this.menu_ekle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.menu_ekle.Size = new System.Drawing.Size(129, 38);
            this.menu_ekle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.StateCommon.Back.ColorAngle = 45F;
            this.menu_ekle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ekle.StateCommon.Border.ColorAngle = 45F;
            this.menu_ekle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ekle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_ekle.StateCommon.Border.Rounding = 18;
            this.menu_ekle.StateCommon.Border.Width = 1;
            this.menu_ekle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.menu_ekle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.menu_ekle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_ekle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ekle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ekle.StateTracking.Back.ColorAngle = 45F;
            this.menu_ekle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ekle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ekle.StateTracking.Border.ColorAngle = 45F;
            this.menu_ekle.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ekle.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_ekle.StateTracking.Border.Rounding = 18;
            this.menu_ekle.StateTracking.Border.Width = 1;
            this.menu_ekle.TabIndex = 11;
            this.menu_ekle.TabStop = false;
            this.menu_ekle.Values.Text = "Ekle";
            this.menu_ekle.Click += new System.EventHandler(this.menu_ekle_Click);
            // 
            // menu_ozet
            // 
            this.menu_ozet.Location = new System.Drawing.Point(12, 216);
            this.menu_ozet.Name = "menu_ozet";
            this.menu_ozet.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.OverrideDefault.Back.ColorAngle = 45F;
            this.menu_ozet.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.OverrideDefault.Border.ColorAngle = 45F;
            this.menu_ozet.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ozet.OverrideDefault.Border.Rounding = 18;
            this.menu_ozet.OverrideDefault.Border.Width = 1;
            this.menu_ozet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.menu_ozet.Size = new System.Drawing.Size(129, 38);
            this.menu_ozet.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.StateCommon.Back.ColorAngle = 45F;
            this.menu_ozet.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.menu_ozet.StateCommon.Border.ColorAngle = 45F;
            this.menu_ozet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ozet.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_ozet.StateCommon.Border.Rounding = 18;
            this.menu_ozet.StateCommon.Border.Width = 1;
            this.menu_ozet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.menu_ozet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.menu_ozet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_ozet.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ozet.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ozet.StateTracking.Back.ColorAngle = 45F;
            this.menu_ozet.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ozet.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.menu_ozet.StateTracking.Border.ColorAngle = 45F;
            this.menu_ozet.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menu_ozet.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.menu_ozet.StateTracking.Border.Rounding = 18;
            this.menu_ozet.StateTracking.Border.Width = 1;
            this.menu_ozet.TabIndex = 9;
            this.menu_ozet.TabStop = false;
            this.menu_ozet.Values.Text = "Özet";
            this.menu_ozet.Click += new System.EventHandler(this.menu_ozet_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.min);
            this.header.Controls.Add(this.max);
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(160, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1120, 34);
            this.header.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hoşgeldin";
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Location = new System.Drawing.Point(1004, 1);
            this.min.Name = "min";
            this.min.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.min.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.min.OverrideDefault.Back.ColorAngle = 45F;
            this.min.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.min.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.min.OverrideDefault.Border.ColorAngle = 45F;
            this.min.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.min.OverrideDefault.Border.Rounding = 18;
            this.min.OverrideDefault.Border.Width = 1;
            this.min.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.min.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.min.StateCommon.Back.ColorAngle = 45F;
            this.min.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("min.StateCommon.Back.Image")));
            this.min.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.min.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.min.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.min.StateCommon.Border.ColorAngle = 45F;
            this.min.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.min.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.min.StateCommon.Border.Rounding = 18;
            this.min.StateCommon.Border.Width = 1;
            this.min.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.min.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.min.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.min.StatePressed.Back.Color1 = System.Drawing.Color.Lavender;
            this.min.StatePressed.Back.Color2 = System.Drawing.Color.Lavender;
            this.min.StatePressed.Back.ColorAngle = 45F;
            this.min.StatePressed.Border.Color1 = System.Drawing.Color.Lavender;
            this.min.StatePressed.Border.Color2 = System.Drawing.Color.Lavender;
            this.min.StatePressed.Border.ColorAngle = 45F;
            this.min.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.min.StatePressed.Border.Rounding = 18;
            this.min.StatePressed.Border.Width = 1;
            this.min.StateTracking.Back.Color1 = System.Drawing.Color.Lavender;
            this.min.StateTracking.Back.Color2 = System.Drawing.Color.Lavender;
            this.min.StateTracking.Back.ColorAngle = 45F;
            this.min.StateTracking.Border.Color1 = System.Drawing.Color.Lavender;
            this.min.StateTracking.Border.Color2 = System.Drawing.Color.Lavender;
            this.min.StateTracking.Border.ColorAngle = 45F;
            this.min.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.min.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.min.StateTracking.Border.Rounding = 18;
            this.min.StateTracking.Border.Width = 1;
            this.min.TabIndex = 13;
            this.min.Values.Text = "";
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.Location = new System.Drawing.Point(1040, 1);
            this.max.Name = "max";
            this.max.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.max.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.max.OverrideDefault.Back.ColorAngle = 45F;
            this.max.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.max.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.max.OverrideDefault.Border.ColorAngle = 45F;
            this.max.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.max.OverrideDefault.Border.Rounding = 18;
            this.max.OverrideDefault.Border.Width = 1;
            this.max.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.max.Size = new System.Drawing.Size(30, 30);
            this.max.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.max.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.max.StateCommon.Back.ColorAngle = 45F;
            this.max.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("max.StateCommon.Back.Image")));
            this.max.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.max.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.max.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.max.StateCommon.Border.ColorAngle = 45F;
            this.max.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.max.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.max.StateCommon.Border.Rounding = 18;
            this.max.StateCommon.Border.Width = 1;
            this.max.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.max.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.max.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.max.StatePressed.Back.Color1 = System.Drawing.Color.Lavender;
            this.max.StatePressed.Back.Color2 = System.Drawing.Color.Lavender;
            this.max.StatePressed.Back.ColorAngle = 45F;
            this.max.StatePressed.Border.Color1 = System.Drawing.Color.Lavender;
            this.max.StatePressed.Border.Color2 = System.Drawing.Color.Lavender;
            this.max.StatePressed.Border.ColorAngle = 45F;
            this.max.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.max.StatePressed.Border.Rounding = 18;
            this.max.StatePressed.Border.Width = 1;
            this.max.StateTracking.Back.Color1 = System.Drawing.Color.Lavender;
            this.max.StateTracking.Back.Color2 = System.Drawing.Color.Lavender;
            this.max.StateTracking.Back.ColorAngle = 45F;
            this.max.StateTracking.Border.Color1 = System.Drawing.Color.Lavender;
            this.max.StateTracking.Border.Color2 = System.Drawing.Color.Lavender;
            this.max.StateTracking.Border.ColorAngle = 45F;
            this.max.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.max.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.max.StateTracking.Border.Rounding = 18;
            this.max.StateTracking.Border.Width = 1;
            this.max.TabIndex = 12;
            this.max.Values.Text = "";
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(1076, 1);
            this.close.Name = "close";
            this.close.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.close.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.close.OverrideDefault.Back.ColorAngle = 45F;
            this.close.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.close.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.close.OverrideDefault.Border.ColorAngle = 45F;
            this.close.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.close.OverrideDefault.Border.Rounding = 18;
            this.close.OverrideDefault.Border.Width = 1;
            this.close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.close.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.close.StateCommon.Back.ColorAngle = 45F;
            this.close.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("close.StateCommon.Back.Image")));
            this.close.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.close.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.close.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.close.StateCommon.Border.ColorAngle = 45F;
            this.close.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.close.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.close.StateCommon.Border.Rounding = 18;
            this.close.StateCommon.Border.Width = 1;
            this.close.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.close.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.StatePressed.Back.Color1 = System.Drawing.Color.Lavender;
            this.close.StatePressed.Back.Color2 = System.Drawing.Color.Lavender;
            this.close.StatePressed.Back.ColorAngle = 45F;
            this.close.StatePressed.Border.Color1 = System.Drawing.Color.Lavender;
            this.close.StatePressed.Border.Color2 = System.Drawing.Color.Lavender;
            this.close.StatePressed.Border.ColorAngle = 45F;
            this.close.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.close.StatePressed.Border.Rounding = 18;
            this.close.StatePressed.Border.Width = 1;
            this.close.StateTracking.Back.Color1 = System.Drawing.Color.Lavender;
            this.close.StateTracking.Back.Color2 = System.Drawing.Color.Lavender;
            this.close.StateTracking.Back.ColorAngle = 45F;
            this.close.StateTracking.Border.Color1 = System.Drawing.Color.Lavender;
            this.close.StateTracking.Border.Color2 = System.Drawing.Color.Lavender;
            this.close.StateTracking.Border.ColorAngle = 45F;
            this.close.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.close.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.close.StateTracking.Border.Rounding = 18;
            this.close.StateTracking.Border.Width = 1;
            this.close.TabIndex = 11;
            this.close.Values.Text = "";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // icerik
            // 
            this.icerik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icerik.Location = new System.Drawing.Point(160, 34);
            this.icerik.Name = "icerik";
            this.icerik.Size = new System.Drawing.Size(1120, 686);
            this.icerik.TabIndex = 18;
            this.icerik.Paint += new System.Windows.Forms.PaintEventHandler(this.icerik_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ParaBil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ParaBil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel icerik;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_ozet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton close;
        private ComponentFactory.Krypton.Toolkit.KryptonButton min;
        private ComponentFactory.Krypton.Toolkit.KryptonButton max;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_durum;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_ekle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_profil;
        private System.Windows.Forms.Label emre;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menu_sil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

