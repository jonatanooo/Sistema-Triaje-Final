namespace Fase_1_C_
{
	// Token: 0x0200000D RID: 13
	public partial class VistaPacientes : global::System.Windows.Forms.Form
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000E30C File Offset: 0x0000C50C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.registrosTriajeBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.triajeClinicoContextBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.pacienteBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.vistaPacientesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.dgvtriaje = new global::ReaLTaiizor.Controls.PoisonDataGridView();
			this.btningresar = new global::ReaLTaiizor.Controls.Button();
			this.btncancelar = new global::ReaLTaiizor.Controls.Button();
			this.button1 = new global::ReaLTaiizor.Controls.Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.btnatras = new global::ReaLTaiizor.Controls.Button();
			this.button2 = new global::ReaLTaiizor.Controls.Button();
			this.parrotGradientPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.registrosTriajeBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.triajeClinicoContextBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pacienteBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vistaPacientesBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvtriaje).BeginInit();
			base.SuspendLayout();
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.Indigo;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.MediumSlateBlue;
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.label1);
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(-4, -4);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1473, 66);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 70;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(629, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(244, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listado Pacientes";
			this.dgvtriaje.AllowUserToResizeRows = false;
			this.dgvtriaje.BackgroundColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvtriaje.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvtriaje.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvtriaje.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvtriaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvtriaje.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvtriaje.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvtriaje.EnableHeadersVisualStyles = false;
			this.dgvtriaje.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.dgvtriaje.GridColor = global::System.Drawing.Color.White;
			this.dgvtriaje.Location = new global::System.Drawing.Point(45, 131);
			this.dgvtriaje.Name = "dgvtriaje";
			this.dgvtriaje.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvtriaje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvtriaje.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvtriaje.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvtriaje.Size = new global::System.Drawing.Size(1151, 581);
			this.dgvtriaje.TabIndex = 71;
			this.dgvtriaje.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtriaje_CellContentClick);
			this.dgvtriaje.CellPainting += new global::System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvtriaje_CellPainting);
			this.btningresar.BackColor = global::System.Drawing.Color.Transparent;
			this.btningresar.BorderColor = global::System.Drawing.Color.Black;
			this.btningresar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btningresar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btningresar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btningresar.Image = null;
			this.btningresar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btningresar.InactiveColor = global::System.Drawing.Color.MediumOrchid;
			this.btningresar.Location = new global::System.Drawing.Point(1251, 262);
			this.btningresar.Name = "btningresar";
			this.btningresar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.Size = new global::System.Drawing.Size(120, 40);
			this.btningresar.TabIndex = 73;
			this.btningresar.Text = "Ingresar";
			this.btningresar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btningresar.Click += new global::System.EventHandler(this.btningresar_Click);
			this.btncancelar.BackColor = global::System.Drawing.Color.Transparent;
			this.btncancelar.BorderColor = global::System.Drawing.Color.Black;
			this.btncancelar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btncancelar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btncancelar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btncancelar.Image = null;
			this.btncancelar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btncancelar.InactiveColor = global::System.Drawing.Color.LightCoral;
			this.btncancelar.Location = new global::System.Drawing.Point(1251, 327);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.Size = new global::System.Drawing.Size(120, 40);
			this.btncancelar.TabIndex = 72;
			this.btncancelar.Text = "Ver mis Pacientes";
			this.btncancelar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btncancelar.Click += new global::System.EventHandler(this.btncancelar_Click);
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.BorderColor = global::System.Drawing.Color.Black;
			this.button1.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.button1.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.button1.Image = null;
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.InactiveColor = global::System.Drawing.Color.HotPink;
			this.button1.Location = new global::System.Drawing.Point(1245, 468);
			this.button1.Name = "button1";
			this.button1.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button1.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button1.Size = new global::System.Drawing.Size(138, 40);
			this.button1.TabIndex = 74;
			this.button1.Text = "Buscar Historial Paciente";
			this.button1.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 5000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.btnatras.BackColor = global::System.Drawing.Color.Transparent;
			this.btnatras.BorderColor = global::System.Drawing.Color.Black;
			this.btnatras.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btnatras.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btnatras.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btnatras.Image = null;
			this.btnatras.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnatras.InactiveColor = global::System.Drawing.Color.LightCoral;
			this.btnatras.Location = new global::System.Drawing.Point(1251, 591);
			this.btnatras.Name = "btnatras";
			this.btnatras.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnatras.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btnatras.Size = new global::System.Drawing.Size(120, 40);
			this.btnatras.TabIndex = 75;
			this.btnatras.Text = "Volver";
			this.btnatras.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btnatras.Click += new global::System.EventHandler(this.btnatras_Click);
			this.button2.BackColor = global::System.Drawing.Color.Transparent;
			this.button2.BorderColor = global::System.Drawing.Color.Black;
			this.button2.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.button2.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.button2.Image = null;
			this.button2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.InactiveColor = global::System.Drawing.Color.Crimson;
			this.button2.Location = new global::System.Drawing.Point(1251, 395);
			this.button2.Name = "button2";
			this.button2.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button2.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.button2.Size = new global::System.Drawing.Size(120, 40);
			this.button2.TabIndex = 76;
			this.button2.Text = "Abandono";
			this.button2.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1463, 753);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.btnatras);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btningresar);
			base.Controls.Add(this.btncancelar);
			base.Controls.Add(this.dgvtriaje);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Name = "VistaPacientes";
			this.Text = "VistaPacientes";
			base.Load += new global::System.EventHandler(this.VistaPacientes_Load);
			this.parrotGradientPanel1.ResumeLayout(false);
			this.parrotGradientPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.registrosTriajeBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.triajeClinicoContextBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pacienteBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vistaPacientesBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvtriaje).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400009F RID: 159
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A0 RID: 160
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.BindingSource registrosTriajeBindingSource;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.BindingSource vistaPacientesBindingSource;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.BindingSource triajeClinicoContextBindingSource;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.BindingSource pacienteBindingSource;

		// Token: 0x040000A6 RID: 166
		private global::ReaLTaiizor.Controls.PoisonDataGridView dgvtriaje;

		// Token: 0x040000A7 RID: 167
		private global::ReaLTaiizor.Controls.Button btningresar;

		// Token: 0x040000A8 RID: 168
		private global::ReaLTaiizor.Controls.Button btncancelar;

		// Token: 0x040000A9 RID: 169
		private global::ReaLTaiizor.Controls.Button button1;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000AB RID: 171
		private global::ReaLTaiizor.Controls.Button btnatras;

		// Token: 0x040000AC RID: 172
		private global::ReaLTaiizor.Controls.Button button2;
	}
}
