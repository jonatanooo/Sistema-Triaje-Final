namespace Fase_1_C_
{
	// Token: 0x02000006 RID: 6
	public partial class Crear_Usuario : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003908 File Offset: 0x00001B08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003940 File Offset: 0x00001B40
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Fase_1_C_.Crear_Usuario));
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.panelRedondeado1 = new global::Fase_1_C_.PanelRedondeado();
			this.btnatras = new global::ReaLTaiizor.Controls.Button();
			this.txtDUI = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtapellidos = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtnombres = new global::ReaLTaiizor.Controls.BigTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.cbrol = new global::ReaLTaiizor.Controls.PoisonComboBox();
			this.txtcontracrear = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtcrearuser = new global::ReaLTaiizor.Controls.BigTextBox();
			this.btnregistrar = new global::ReaLTaiizor.Controls.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.sqlCommandBuilder1 = new global::Microsoft.Data.SqlClient.SqlCommandBuilder();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.parrotGradientPanel1.SuspendLayout();
			this.panelRedondeado1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.DarkBlue;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.panelRedondeado1);
			this.parrotGradientPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1258, 699);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 1;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.panelRedondeado1.BackColor = global::System.Drawing.Color.White;
			this.panelRedondeado1.Controls.Add(this.label8);
			this.panelRedondeado1.Controls.Add(this.label7);
			this.panelRedondeado1.Controls.Add(this.label6);
			this.panelRedondeado1.Controls.Add(this.label5);
			this.panelRedondeado1.Controls.Add(this.label4);
			this.panelRedondeado1.Controls.Add(this.btnatras);
			this.panelRedondeado1.Controls.Add(this.txtDUI);
			this.panelRedondeado1.Controls.Add(this.txtapellidos);
			this.panelRedondeado1.Controls.Add(this.txtnombres);
			this.panelRedondeado1.Controls.Add(this.label3);
			this.panelRedondeado1.Controls.Add(this.cbrol);
			this.panelRedondeado1.Controls.Add(this.txtcontracrear);
			this.panelRedondeado1.Controls.Add(this.txtcrearuser);
			this.panelRedondeado1.Controls.Add(this.btnregistrar);
			this.panelRedondeado1.Controls.Add(this.pictureBox2);
			this.panelRedondeado1.Controls.Add(this.label2);
			this.panelRedondeado1.Controls.Add(this.label1);
			this.panelRedondeado1.Location = new global::System.Drawing.Point(73, 62);
			this.panelRedondeado1.Name = "panelRedondeado1";
			this.panelRedondeado1.RadioBordes = 30;
			this.panelRedondeado1.Size = new global::System.Drawing.Size(1132, 595);
			this.panelRedondeado1.TabIndex = 0;
			this.btnatras.BackColor = global::System.Drawing.Color.Transparent;
			this.btnatras.BorderColor = global::System.Drawing.Color.Black;
			this.btnatras.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btnatras.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btnatras.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btnatras.Image = null;
			this.btnatras.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnatras.InactiveColor = global::System.Drawing.Color.Blue;
			this.btnatras.Location = new global::System.Drawing.Point(375, 499);
			this.btnatras.Name = "btnatras";
			this.btnatras.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnatras.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnatras.Size = new global::System.Drawing.Size(120, 40);
			this.btnatras.TabIndex = 8;
			this.btnatras.Text = "Cancelar";
			this.btnatras.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btnatras.Click += new global::System.EventHandler(this.btnatras_Click);
			this.txtDUI.BackColor = global::System.Drawing.Color.Transparent;
			this.txtDUI.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtDUI.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtDUI.Image = null;
			this.txtDUI.Location = new global::System.Drawing.Point(206, 406);
			this.txtDUI.MaxLength = 32767;
			this.txtDUI.Multiline = false;
			this.txtDUI.Name = "txtDUI";
			this.txtDUI.ReadOnly = false;
			this.txtDUI.Size = new global::System.Drawing.Size(325, 41);
			this.txtDUI.TabIndex = 69;
			this.txtDUI.Text = "DUI";
			this.txtDUI.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDUI.UseSystemPasswordChar = false;
			this.txtDUI.Enter += new global::System.EventHandler(this.txtDUI_Enter);
			this.txtapellidos.BackColor = global::System.Drawing.Color.Transparent;
			this.txtapellidos.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtapellidos.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtapellidos.Image = null;
			this.txtapellidos.Location = new global::System.Drawing.Point(206, 339);
			this.txtapellidos.MaxLength = 32767;
			this.txtapellidos.Multiline = false;
			this.txtapellidos.Name = "txtapellidos";
			this.txtapellidos.ReadOnly = false;
			this.txtapellidos.Size = new global::System.Drawing.Size(325, 41);
			this.txtapellidos.TabIndex = 68;
			this.txtapellidos.Text = "Apellidos";
			this.txtapellidos.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtapellidos.UseSystemPasswordChar = false;
			this.txtapellidos.Enter += new global::System.EventHandler(this.txtapellidos_Enter);
			this.txtnombres.BackColor = global::System.Drawing.Color.Transparent;
			this.txtnombres.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtnombres.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtnombres.Image = null;
			this.txtnombres.Location = new global::System.Drawing.Point(206, 275);
			this.txtnombres.MaxLength = 32767;
			this.txtnombres.Multiline = false;
			this.txtnombres.Name = "txtnombres";
			this.txtnombres.ReadOnly = false;
			this.txtnombres.Size = new global::System.Drawing.Size(325, 41);
			this.txtnombres.TabIndex = 67;
			this.txtnombres.Tag = "Nombres";
			this.txtnombres.Text = "Nombres";
			this.txtnombres.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtnombres.UseSystemPasswordChar = false;
			this.txtnombres.Enter += new global::System.EventHandler(this.txtnombres_Enter);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Century Gothic", 15.75f);
			this.label3.Location = new global::System.Drawing.Point(632, 414);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 24);
			this.label3.TabIndex = 66;
			this.label3.Text = "Rol:";
			this.cbrol.FormattingEnabled = true;
			this.cbrol.ItemHeight = 23;
			this.cbrol.Items.AddRange(new object[]
			{
				"Doctor",
				"Enfermera"
			});
			this.cbrol.Location = new global::System.Drawing.Point(685, 414);
			this.cbrol.Name = "cbrol";
			this.cbrol.Size = new global::System.Drawing.Size(272, 29);
			this.cbrol.TabIndex = 65;
			this.cbrol.UseSelectable = true;
			this.txtcontracrear.BackColor = global::System.Drawing.Color.Transparent;
			this.txtcontracrear.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtcontracrear.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtcontracrear.Image = null;
			this.txtcontracrear.Location = new global::System.Drawing.Point(678, 339);
			this.txtcontracrear.MaxLength = 32767;
			this.txtcontracrear.Multiline = false;
			this.txtcontracrear.Name = "txtcontracrear";
			this.txtcontracrear.ReadOnly = false;
			this.txtcontracrear.Size = new global::System.Drawing.Size(325, 41);
			this.txtcontracrear.TabIndex = 47;
			this.txtcontracrear.Text = "Contraseña";
			this.txtcontracrear.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtcontracrear.UseSystemPasswordChar = false;
			this.txtcontracrear.Enter += new global::System.EventHandler(this.txtcontracrear_Enter);
			this.txtcrearuser.BackColor = global::System.Drawing.Color.Transparent;
			this.txtcrearuser.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtcrearuser.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtcrearuser.Image = null;
			this.txtcrearuser.Location = new global::System.Drawing.Point(678, 275);
			this.txtcrearuser.MaxLength = 32767;
			this.txtcrearuser.Multiline = false;
			this.txtcrearuser.Name = "txtcrearuser";
			this.txtcrearuser.ReadOnly = false;
			this.txtcrearuser.Size = new global::System.Drawing.Size(325, 41);
			this.txtcrearuser.TabIndex = 46;
			this.txtcrearuser.Text = "Usuario";
			this.txtcrearuser.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtcrearuser.UseSystemPasswordChar = false;
			this.txtcrearuser.Enter += new global::System.EventHandler(this.txtcrearuser_Enter);
			this.btnregistrar.BackColor = global::System.Drawing.Color.Transparent;
			this.btnregistrar.BorderColor = global::System.Drawing.Color.Black;
			this.btnregistrar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btnregistrar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btnregistrar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btnregistrar.Image = null;
			this.btnregistrar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnregistrar.InactiveColor = global::System.Drawing.Color.DarkMagenta;
			this.btnregistrar.Location = new global::System.Drawing.Point(590, 499);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnregistrar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnregistrar.Size = new global::System.Drawing.Size(120, 40);
			this.btnregistrar.TabIndex = 7;
			this.btnregistrar.Text = "Registrarse";
			this.btnregistrar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btnregistrar.Click += new global::System.EventHandler(this.btnregistrar_Click);
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(523, 33);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(76, 74);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Century Gothic", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(471, 196);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(189, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingrese sus Datos:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(461, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(202, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrarse";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(112, 285);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(78, 20);
			this.label4.TabIndex = 70;
			this.label4.Text = "Nombres:";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(112, 350);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(78, 20);
			this.label5.TabIndex = 71;
			this.label5.Text = "Apellidos:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(576, 285);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(67, 20);
			this.label6.TabIndex = 72;
			this.label6.Text = "Usuario:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(576, 350);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(92, 20);
			this.label7.TabIndex = 73;
			this.label7.Text = "Contraseña:";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(112, 418);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(40, 20);
			this.label8.TabIndex = 74;
			this.label8.Text = "DUI:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1258, 699);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Name = "Crear_Usuario";
			this.Text = "Crear_Usuario";
			this.parrotGradientPanel1.ResumeLayout(false);
			this.panelRedondeado1.ResumeLayout(false);
			this.panelRedondeado1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400002E RID: 46
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002F RID: 47
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x04000030 RID: 48
		private global::Fase_1_C_.PanelRedondeado panelRedondeado1;

		// Token: 0x04000031 RID: 49
		private global::ReaLTaiizor.Controls.Button btnregistrar;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000035 RID: 53
		private global::ReaLTaiizor.Controls.BigTextBox txtcontracrear;

		// Token: 0x04000036 RID: 54
		private global::ReaLTaiizor.Controls.BigTextBox txtcrearuser;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000038 RID: 56
		private global::ReaLTaiizor.Controls.PoisonComboBox cbrol;

		// Token: 0x04000039 RID: 57
		private global::ReaLTaiizor.Controls.BigTextBox txtDUI;

		// Token: 0x0400003A RID: 58
		private global::ReaLTaiizor.Controls.BigTextBox txtapellidos;

		// Token: 0x0400003B RID: 59
		private global::ReaLTaiizor.Controls.BigTextBox txtnombres;

		// Token: 0x0400003C RID: 60
		private global::Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;

		// Token: 0x0400003D RID: 61
		private global::ReaLTaiizor.Controls.Button btnatras;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label4;
	}
}
