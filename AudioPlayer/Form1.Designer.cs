namespace AudioPlayer
{
    partial class Form1
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
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenTile = new MetroFramework.Controls.MetroTile();
            this.PlayTile = new MetroFramework.Controls.MetroTile();
            this.StopTile = new MetroFramework.Controls.MetroTile();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.AudioPosition = new MetroFramework.Controls.MetroLabel();
            this.lbNameAudio = new MetroFramework.Controls.MetroLabel();
            this.lbTags = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OpenTile
            // 
            this.OpenTile.ActiveControl = null;
            this.OpenTile.Location = new System.Drawing.Point(170, 393);
            this.OpenTile.Name = "OpenTile";
            this.OpenTile.PaintTileCount = false;
            this.OpenTile.Size = new System.Drawing.Size(138, 53);
            this.OpenTile.Style = MetroFramework.MetroColorStyle.Red;
            this.OpenTile.TabIndex = 0;
            this.OpenTile.Text = "Open new";
            this.OpenTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenTile.UseSelectable = true;
            this.OpenTile.UseStyleColors = true;
            this.OpenTile.Click += new System.EventHandler(this.OpenTile_Click);
            // 
            // PlayTile
            // 
            this.PlayTile.ActiveControl = null;
            this.PlayTile.Location = new System.Drawing.Point(314, 393);
            this.PlayTile.Name = "PlayTile";
            this.PlayTile.PaintTileCount = false;
            this.PlayTile.Size = new System.Drawing.Size(138, 53);
            this.PlayTile.Style = MetroFramework.MetroColorStyle.Red;
            this.PlayTile.TabIndex = 1;
            this.PlayTile.Text = "Pause";
            this.PlayTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayTile.UseSelectable = true;
            this.PlayTile.UseStyleColors = true;
            this.PlayTile.Click += new System.EventHandler(this.PlayTile_Click);
            // 
            // StopTile
            // 
            this.StopTile.ActiveControl = null;
            this.StopTile.Location = new System.Drawing.Point(458, 393);
            this.StopTile.Name = "StopTile";
            this.StopTile.PaintTileCount = false;
            this.StopTile.Size = new System.Drawing.Size(138, 53);
            this.StopTile.Style = MetroFramework.MetroColorStyle.Red;
            this.StopTile.TabIndex = 2;
            this.StopTile.Text = "Stop";
            this.StopTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StopTile.UseSelectable = true;
            this.StopTile.UseStyleColors = true;
            this.StopTile.Click += new System.EventHandler(this.StopTile_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(26, 364);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(858, 23);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar1.TabIndex = 3;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroProgressBar1_MouseDown);
            this.metroProgressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroProgressBar1_MouseUp);
            // 
            // AudioPosition
            // 
            this.AudioPosition.AutoSize = true;
            this.AudioPosition.Location = new System.Drawing.Point(26, 341);
            this.AudioPosition.Name = "AudioPosition";
            this.AudioPosition.Size = new System.Drawing.Size(44, 20);
            this.AudioPosition.TabIndex = 4;
            this.AudioPosition.Text = "00:00";
            this.AudioPosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbNameAudio
            // 
            this.lbNameAudio.AutoSize = true;
            this.lbNameAudio.Location = new System.Drawing.Point(26, 312);
            this.lbNameAudio.Name = "lbNameAudio";
            this.lbNameAudio.Size = new System.Drawing.Size(167, 20);
            this.lbNameAudio.TabIndex = 5;
            this.lbNameAudio.Text = " Welcome to audioplayer!";
            this.lbNameAudio.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbTags
            // 
            this.lbTags.AutoSize = true;
            this.lbTags.Location = new System.Drawing.Point(267, 63);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(17, 20);
            this.lbTags.TabIndex = 6;
            this.lbTags.Text = "  ";
            this.lbTags.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(602, 393);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.PaintTileCount = false;
            this.metroTile1.Size = new System.Drawing.Size(138, 53);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Next";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(26, 393);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.PaintTileCount = false;
            this.metroTile2.Size = new System.Drawing.Size(138, 53);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Previous";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(620, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 285);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(746, 393);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.PaintTileCount = false;
            this.metroTile3.Size = new System.Drawing.Size(138, 53);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Text = "Remove";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 469);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTags);
            this.Controls.Add(this.lbNameAudio);
            this.Controls.Add(this.AudioPosition);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.StopTile);
            this.Controls.Add(this.PlayTile);
            this.Controls.Add(this.OpenTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    private System.Windows.Forms.Timer timer1;
    private MetroFramework.Controls.MetroTile OpenTile;
    private MetroFramework.Controls.MetroTile PlayTile;
    private MetroFramework.Controls.MetroTile StopTile;
    private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    private MetroFramework.Controls.MetroLabel AudioPosition;
    private MetroFramework.Controls.MetroLabel lbNameAudio;
    private MetroFramework.Controls.MetroLabel lbTags;
    private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}

