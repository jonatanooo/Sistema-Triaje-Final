namespace Fase_1_C_
{
	// Token: 0x02000009 RID: 9
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000AF68 File Offset: 0x00009168
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AFA0 File Offset: 0x000091A0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Fase_1_C_.Login));
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panelRedondeado1 = new global::Fase_1_C_.PanelRedondeado();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.txtcontraseña = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtusuario = new global::ReaLTaiizor.Controls.BigTextBox();
			this.button3 = new global::ReaLTaiizor.Controls.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.parrotGradientPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panelRedondeado1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.Indigo;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.Blue;
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.label4);
			this.parrotGradientPanel1.Controls.Add(this.pictureBox1);
			this.parrotGradientPanel1.Controls.Add(this.panelRedondeado1);
			this.parrotGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1336, 771);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 0;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Century Gothic", 27.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(268, 343);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(262, 44);
			this.label4.TabIndex = 2;
			this.label4.Text = "Sistema Triaje";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(133, 303);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(110, 120);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.panelRedondeado1.BackColor = global::System.Drawing.Color.White;
			this.panelRedondeado1.Controls.Add(this.linkLabel1);
			this.panelRedondeado1.Controls.Add(this.txtcontraseña);
			this.panelRedondeado1.Controls.Add(this.txtusuario);
			this.panelRedondeado1.Controls.Add(this.button3);
			this.panelRedondeado1.Controls.Add(this.pictureBox2);
			this.panelRedondeado1.Controls.Add(this.label2);
			this.panelRedondeado1.Controls.Add(this.label1);
			this.panelRedondeado1.Location = new global::System.Drawing.Point(728, 92);
			this.panelRedondeado1.Name = "panelRedondeado1";
			this.panelRedondeado1.RadioBordes = 30;
			this.panelRedondeado1.Size = new global::System.Drawing.Size(443, 595);
			this.panelRedondeado1.TabIndex = 0;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new global::System.Drawing.Point(177, 519);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(78, 15);
			this.linkLabel1.TabIndex = 47;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Crear Usuario";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.txtcontraseña.BackColor = global::System.Drawing.Color.Transparent;
			this.txtcontraseña.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtcontraseña.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtcontraseña.Image = null;
			this.txtcontraseña.Location = new global::System.Drawing.Point(57, 364);
			this.txtcontraseña.MaxLength = 32767;
			this.txtcontraseña.Multiline = false;
			this.txtcontraseña.Name = "txtcontraseña";
			this.txtcontraseña.ReadOnly = false;
			this.txtcontraseña.Size = new global::System.Drawing.Size(325, 41);
			this.txtcontraseña.TabIndex = 46;
			this.txtcontraseña.Text = "Contraseña";
			this.txtcontraseña.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtcontraseña.UseSystemPasswordChar = true;
			this.txtcontraseña.Enter += new global::System.EventHandler(this.txtcontraseña_Enter);
			this.txtusuario.BackColor = global::System.Drawing.Color.Transparent;
			this.txtusuario.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtusuario.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtusuario.Image = null;
			this.txtusuario.Location = new global::System.Drawing.Point(57, 293);
			this.txtusuario.MaxLength = 32767;
			this.txtusuario.Multiline = false;
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.ReadOnly = false;
			this.txtusuario.Size = new global::System.Drawing.Size(325, 41);
			this.txtusuario.TabIndex = 45;
			this.txtusuario.Text = "Usuario";
			this.txtusuario.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtusuario.UseSystemPasswordChar = false;
			this.txtusuario.Enter += new global::System.EventHandler(this.txtusuario_Enter);
			this.button3.BackColor = global::System.Drawing.Color.Transparent;
			this.button3.BorderColor = global::System.Drawing.Color.Black;
			this.button3.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.button3.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.button3.Image = null;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.InactiveColor = global::System.Drawing.Color.DarkViolet;
			this.button3.Location = new global::System.Drawing.Point(157, 459);
			this.button3.Name = "button3";
			this.button3.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button3.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button3.Size = new global::System.Drawing.Size(120, 40);
			this.button3.TabIndex = 7;
			this.button3.Text = "Ingresar";
			this.button3.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(177, 58);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(76, 74);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Century Gothic", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(88, 225);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(266, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingrese sus Credenciales:";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(164, 156);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(109, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1336, 771);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Name = "Login";
			this.Text = "Form2";
			this.parrotGradientPanel1.ResumeLayout(false);
			this.parrotGradientPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panelRedondeado1.ResumeLayout(false);
			this.panelRedondeado1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000088 RID: 136
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000089 RID: 137
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x0400008A RID: 138
		private global::Fase_1_C_.PanelRedondeado panelRedondeado1;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000090 RID: 144
		private global::ReaLTaiizor.Controls.Button button3;

		// Token: 0x04000091 RID: 145
		private global::ReaLTaiizor.Controls.BigTextBox txtcontraseña;

		// Token: 0x04000092 RID: 146
		private global::ReaLTaiizor.Controls.BigTextBox txtusuario;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
