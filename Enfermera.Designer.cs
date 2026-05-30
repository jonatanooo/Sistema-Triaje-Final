namespace Fase_1_C_
{
	// Token: 0x02000007 RID: 7
	public partial class Enfermera : global::System.Windows.Forms.Form
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000054F4 File Offset: 0x000036F4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000552C File Offset: 0x0000372C
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.rdbDesmayoSi = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.panelRedondeado1 = new global::Fase_1_C_.PanelRedondeado();
			this.rdbDesmayoNo = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.label14 = new global::System.Windows.Forms.Label();
			this.txtnombre = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtapellidos = new global::ReaLTaiizor.Controls.BigTextBox();
			this.panelRedondeado2 = new global::Fase_1_C_.PanelRedondeado();
			this.rdbHemorragiaNo = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.rdbHemorragiaSi = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.panelRedondeado3 = new global::Fase_1_C_.PanelRedondeado();
			this.rdbDificultadadResNo = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.rdbDificultadadResSi = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.panelRedondeado4 = new global::Fase_1_C_.PanelRedondeado();
			this.rdbTraumaCraneoNo = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.rdbTraumaCraneoSi = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.panelRedondeado5 = new global::Fase_1_C_.PanelRedondeado();
			this.rdbDolorPechoNo = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.rdbDolorPechoSi = new global::ReaLTaiizor.Controls.MaterialRadioButton();
			this.numdolor = new global::ReaLTaiizor.Controls.HopeNumeric();
			this.numtemperatura = new global::ReaLTaiizor.Controls.HopeNumeric();
			this.numoxigeno = new global::ReaLTaiizor.Controls.HopeNumeric();
			this.numevolucion = new global::ReaLTaiizor.Controls.HopeNumeric();
			this.cbmotivo = new global::ReaLTaiizor.Controls.PoisonComboBox();
			this.cbestadomental = new global::ReaLTaiizor.Controls.PoisonComboBox();
			this.cbmecanismo = new global::ReaLTaiizor.Controls.PoisonComboBox();
			this.btncancelar = new global::ReaLTaiizor.Controls.Button();
			this.btningresar = new global::ReaLTaiizor.Controls.Button();
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.txtdui = new global::ReaLTaiizor.Controls.BigTextBox();
			this.dateedad = new global::ReaLTaiizor.Controls.PoisonDateTime();
			this.label17 = new global::System.Windows.Forms.Label();
			this.cbgenero = new global::ReaLTaiizor.Controls.PoisonComboBox();
			this.panelRedondeado1.SuspendLayout();
			this.panelRedondeado2.SuspendLayout();
			this.panelRedondeado3.SuspendLayout();
			this.panelRedondeado4.SuspendLayout();
			this.panelRedondeado5.SuspendLayout();
			this.parrotGradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(570, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(299, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registro de Pacientes";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label2.Location = new global::System.Drawing.Point(52, 192);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(403, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "¿El paciente presenta pérdida de consciencia o desmayo?";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label3.Location = new global::System.Drawing.Point(52, 245);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(287, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "¿Existe hemorragia activa incontrolable?";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label4.Location = new global::System.Drawing.Point(51, 299);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(581, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "¿Presenta dificultad respiratoria severa (se ahoga o tiene cianosis/coloración azul)?";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label5.Location = new global::System.Drawing.Point(52, 361);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(507, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "¿Sufrió un trauma craneoencefálico (golpe fuerte en la cabeza) reciente?";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label6.Location = new global::System.Drawing.Point(51, 417);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(450, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "¿Siente dolor opresivo en el pecho irradiado al brazo izquierdo?";
			this.rdbDesmayoSi.AutoSize = true;
			this.rdbDesmayoSi.Depth = 0;
			this.rdbDesmayoSi.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDesmayoSi.Location = new global::System.Drawing.Point(25, 1);
			this.rdbDesmayoSi.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDesmayoSi.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDesmayoSi.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDesmayoSi.Name = "rdbDesmayoSi";
			this.rdbDesmayoSi.Ripple = true;
			this.rdbDesmayoSi.Size = new global::System.Drawing.Size(49, 37);
			this.rdbDesmayoSi.TabIndex = 20;
			this.rdbDesmayoSi.TabStop = true;
			this.rdbDesmayoSi.Text = "Si";
			this.rdbDesmayoSi.UseAccentColor = false;
			this.rdbDesmayoSi.UseVisualStyleBackColor = true;
			this.rdbDesmayoSi.CheckedChanged += new global::System.EventHandler(this.materialRadioButton1_CheckedChanged);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label7.Location = new global::System.Drawing.Point(955, 303);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(184, 21);
			this.label7.TabIndex = 24;
			this.label7.Text = "Escala del Dolor (1 al 10):";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label8.Location = new global::System.Drawing.Point(955, 354);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(197, 21);
			this.label8.TabIndex = 25;
			this.label8.Text = "Temperatura Corporal (°C):";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label9.Location = new global::System.Drawing.Point(955, 405);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(240, 21);
			this.label9.TabIndex = 26;
			this.label9.Text = "Saturación de Oxígeno (SpO2 %):";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label10.Location = new global::System.Drawing.Point(955, 454);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(243, 42);
			this.label10.TabIndex = 27;
			this.label10.Text = "Tiempo de evolución del síntoma \r\nprincipal (horas):";
			this.label10.Click += new global::System.EventHandler(this.label10_Click);
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label11.Location = new global::System.Drawing.Point(52, 501);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(209, 21);
			this.label11.TabIndex = 28;
			this.label11.Text = "Motivo principal de consulta:";
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label12.Location = new global::System.Drawing.Point(52, 551);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(266, 42);
			this.label12.TabIndex = 29;
			this.label12.Text = "Estado mental / Nivel de consciencia \r\n(Escala de Glasgow simplificada):";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label13.Location = new global::System.Drawing.Point(52, 623);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(228, 21);
			this.label13.TabIndex = 30;
			this.label13.Text = "Mecanismo de lesión (si aplica):";
			this.panelRedondeado1.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.panelRedondeado1.Controls.Add(this.rdbDesmayoNo);
			this.panelRedondeado1.Controls.Add(this.rdbDesmayoSi);
			this.panelRedondeado1.Location = new global::System.Drawing.Point(638, 180);
			this.panelRedondeado1.Name = "panelRedondeado1";
			this.panelRedondeado1.RadioBordes = 30;
			this.panelRedondeado1.Size = new global::System.Drawing.Size(184, 38);
			this.panelRedondeado1.TabIndex = 41;
			this.rdbDesmayoNo.AutoSize = true;
			this.rdbDesmayoNo.Depth = 0;
			this.rdbDesmayoNo.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDesmayoNo.Location = new global::System.Drawing.Point(93, 1);
			this.rdbDesmayoNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDesmayoNo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDesmayoNo.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDesmayoNo.Name = "rdbDesmayoNo";
			this.rdbDesmayoNo.Ripple = true;
			this.rdbDesmayoNo.Size = new global::System.Drawing.Size(55, 37);
			this.rdbDesmayoNo.TabIndex = 42;
			this.rdbDesmayoNo.TabStop = true;
			this.rdbDesmayoNo.Text = "No";
			this.rdbDesmayoNo.UseAccentColor = false;
			this.rdbDesmayoNo.UseVisualStyleBackColor = true;
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Ebrima", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(52, 116);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(313, 21);
			this.label14.TabIndex = 42;
			this.label14.Text = "Ingrese el Nombres y Apellidos del Paciente";
			this.txtnombre.BackColor = global::System.Drawing.Color.Transparent;
			this.txtnombre.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtnombre.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtnombre.Image = null;
			this.txtnombre.Location = new global::System.Drawing.Point(402, 110);
			this.txtnombre.MaxLength = 32767;
			this.txtnombre.Multiline = false;
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.ReadOnly = false;
			this.txtnombre.Size = new global::System.Drawing.Size(325, 41);
			this.txtnombre.TabIndex = 43;
			this.txtnombre.Text = "Nombres";
			this.txtnombre.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtnombre.UseSystemPasswordChar = false;
			this.txtnombre.TextChanged += new global::System.EventHandler(this.txtnombre_TextChanged);
			this.txtnombre.Enter += new global::System.EventHandler(this.txtnombre_Enter);
			this.txtapellidos.BackColor = global::System.Drawing.Color.Transparent;
			this.txtapellidos.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtapellidos.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtapellidos.Image = null;
			this.txtapellidos.Location = new global::System.Drawing.Point(752, 110);
			this.txtapellidos.MaxLength = 32767;
			this.txtapellidos.Multiline = false;
			this.txtapellidos.Name = "txtapellidos";
			this.txtapellidos.ReadOnly = false;
			this.txtapellidos.Size = new global::System.Drawing.Size(325, 41);
			this.txtapellidos.TabIndex = 44;
			this.txtapellidos.Text = "Apellidos";
			this.txtapellidos.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtapellidos.UseSystemPasswordChar = false;
			this.txtapellidos.Enter += new global::System.EventHandler(this.txtapellidos_Enter);
			this.panelRedondeado2.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.panelRedondeado2.Controls.Add(this.rdbHemorragiaNo);
			this.panelRedondeado2.Controls.Add(this.rdbHemorragiaSi);
			this.panelRedondeado2.Location = new global::System.Drawing.Point(638, 238);
			this.panelRedondeado2.Name = "panelRedondeado2";
			this.panelRedondeado2.RadioBordes = 30;
			this.panelRedondeado2.Size = new global::System.Drawing.Size(184, 38);
			this.panelRedondeado2.TabIndex = 45;
			this.rdbHemorragiaNo.AutoSize = true;
			this.rdbHemorragiaNo.Depth = 0;
			this.rdbHemorragiaNo.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbHemorragiaNo.Location = new global::System.Drawing.Point(93, 1);
			this.rdbHemorragiaNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbHemorragiaNo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbHemorragiaNo.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbHemorragiaNo.Name = "rdbHemorragiaNo";
			this.rdbHemorragiaNo.Ripple = true;
			this.rdbHemorragiaNo.Size = new global::System.Drawing.Size(55, 37);
			this.rdbHemorragiaNo.TabIndex = 42;
			this.rdbHemorragiaNo.TabStop = true;
			this.rdbHemorragiaNo.Text = "No";
			this.rdbHemorragiaNo.UseAccentColor = false;
			this.rdbHemorragiaNo.UseVisualStyleBackColor = true;
			this.rdbHemorragiaSi.AutoSize = true;
			this.rdbHemorragiaSi.Depth = 0;
			this.rdbHemorragiaSi.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbHemorragiaSi.Location = new global::System.Drawing.Point(25, 1);
			this.rdbHemorragiaSi.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbHemorragiaSi.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbHemorragiaSi.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbHemorragiaSi.Name = "rdbHemorragiaSi";
			this.rdbHemorragiaSi.Ripple = true;
			this.rdbHemorragiaSi.Size = new global::System.Drawing.Size(49, 37);
			this.rdbHemorragiaSi.TabIndex = 20;
			this.rdbHemorragiaSi.TabStop = true;
			this.rdbHemorragiaSi.Text = "Si";
			this.rdbHemorragiaSi.UseAccentColor = false;
			this.rdbHemorragiaSi.UseVisualStyleBackColor = true;
			this.panelRedondeado3.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.panelRedondeado3.Controls.Add(this.rdbDificultadadResNo);
			this.panelRedondeado3.Controls.Add(this.rdbDificultadadResSi);
			this.panelRedondeado3.Location = new global::System.Drawing.Point(638, 292);
			this.panelRedondeado3.Name = "panelRedondeado3";
			this.panelRedondeado3.RadioBordes = 30;
			this.panelRedondeado3.Size = new global::System.Drawing.Size(184, 38);
			this.panelRedondeado3.TabIndex = 46;
			this.rdbDificultadadResNo.AutoSize = true;
			this.rdbDificultadadResNo.Depth = 0;
			this.rdbDificultadadResNo.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDificultadadResNo.Location = new global::System.Drawing.Point(93, 1);
			this.rdbDificultadadResNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDificultadadResNo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDificultadadResNo.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDificultadadResNo.Name = "rdbDificultadadResNo";
			this.rdbDificultadadResNo.Ripple = true;
			this.rdbDificultadadResNo.Size = new global::System.Drawing.Size(55, 37);
			this.rdbDificultadadResNo.TabIndex = 42;
			this.rdbDificultadadResNo.TabStop = true;
			this.rdbDificultadadResNo.Text = "No";
			this.rdbDificultadadResNo.UseAccentColor = false;
			this.rdbDificultadadResNo.UseVisualStyleBackColor = true;
			this.rdbDificultadadResSi.AutoSize = true;
			this.rdbDificultadadResSi.Depth = 0;
			this.rdbDificultadadResSi.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDificultadadResSi.Location = new global::System.Drawing.Point(25, 1);
			this.rdbDificultadadResSi.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDificultadadResSi.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDificultadadResSi.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDificultadadResSi.Name = "rdbDificultadadResSi";
			this.rdbDificultadadResSi.Ripple = true;
			this.rdbDificultadadResSi.Size = new global::System.Drawing.Size(49, 37);
			this.rdbDificultadadResSi.TabIndex = 20;
			this.rdbDificultadadResSi.TabStop = true;
			this.rdbDificultadadResSi.Text = "Si";
			this.rdbDificultadadResSi.UseAccentColor = false;
			this.rdbDificultadadResSi.UseVisualStyleBackColor = true;
			this.panelRedondeado4.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.panelRedondeado4.Controls.Add(this.rdbTraumaCraneoNo);
			this.panelRedondeado4.Controls.Add(this.rdbTraumaCraneoSi);
			this.panelRedondeado4.Location = new global::System.Drawing.Point(638, 351);
			this.panelRedondeado4.Name = "panelRedondeado4";
			this.panelRedondeado4.RadioBordes = 30;
			this.panelRedondeado4.Size = new global::System.Drawing.Size(184, 38);
			this.panelRedondeado4.TabIndex = 47;
			this.rdbTraumaCraneoNo.AutoSize = true;
			this.rdbTraumaCraneoNo.Depth = 0;
			this.rdbTraumaCraneoNo.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbTraumaCraneoNo.Location = new global::System.Drawing.Point(93, 1);
			this.rdbTraumaCraneoNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbTraumaCraneoNo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbTraumaCraneoNo.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbTraumaCraneoNo.Name = "rdbTraumaCraneoNo";
			this.rdbTraumaCraneoNo.Ripple = true;
			this.rdbTraumaCraneoNo.Size = new global::System.Drawing.Size(55, 37);
			this.rdbTraumaCraneoNo.TabIndex = 42;
			this.rdbTraumaCraneoNo.TabStop = true;
			this.rdbTraumaCraneoNo.Text = "No";
			this.rdbTraumaCraneoNo.UseAccentColor = false;
			this.rdbTraumaCraneoNo.UseVisualStyleBackColor = true;
			this.rdbTraumaCraneoSi.AutoSize = true;
			this.rdbTraumaCraneoSi.Depth = 0;
			this.rdbTraumaCraneoSi.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbTraumaCraneoSi.Location = new global::System.Drawing.Point(25, 1);
			this.rdbTraumaCraneoSi.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbTraumaCraneoSi.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbTraumaCraneoSi.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbTraumaCraneoSi.Name = "rdbTraumaCraneoSi";
			this.rdbTraumaCraneoSi.Ripple = true;
			this.rdbTraumaCraneoSi.Size = new global::System.Drawing.Size(49, 37);
			this.rdbTraumaCraneoSi.TabIndex = 20;
			this.rdbTraumaCraneoSi.TabStop = true;
			this.rdbTraumaCraneoSi.Text = "Si";
			this.rdbTraumaCraneoSi.UseAccentColor = false;
			this.rdbTraumaCraneoSi.UseVisualStyleBackColor = true;
			this.panelRedondeado5.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.panelRedondeado5.Controls.Add(this.rdbDolorPechoNo);
			this.panelRedondeado5.Controls.Add(this.rdbDolorPechoSi);
			this.panelRedondeado5.Location = new global::System.Drawing.Point(638, 410);
			this.panelRedondeado5.Name = "panelRedondeado5";
			this.panelRedondeado5.RadioBordes = 30;
			this.panelRedondeado5.Size = new global::System.Drawing.Size(184, 38);
			this.panelRedondeado5.TabIndex = 48;
			this.rdbDolorPechoNo.AutoSize = true;
			this.rdbDolorPechoNo.Depth = 0;
			this.rdbDolorPechoNo.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDolorPechoNo.Location = new global::System.Drawing.Point(93, 1);
			this.rdbDolorPechoNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDolorPechoNo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDolorPechoNo.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDolorPechoNo.Name = "rdbDolorPechoNo";
			this.rdbDolorPechoNo.Ripple = true;
			this.rdbDolorPechoNo.Size = new global::System.Drawing.Size(55, 37);
			this.rdbDolorPechoNo.TabIndex = 42;
			this.rdbDolorPechoNo.TabStop = true;
			this.rdbDolorPechoNo.Text = "No";
			this.rdbDolorPechoNo.UseAccentColor = false;
			this.rdbDolorPechoNo.UseVisualStyleBackColor = true;
			this.rdbDolorPechoSi.AutoSize = true;
			this.rdbDolorPechoSi.Depth = 0;
			this.rdbDolorPechoSi.Font = new global::System.Drawing.Font("Segoe UI Symbol", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdbDolorPechoSi.Location = new global::System.Drawing.Point(25, 1);
			this.rdbDolorPechoSi.Margin = new global::System.Windows.Forms.Padding(0);
			this.rdbDolorPechoSi.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.rdbDolorPechoSi.MouseState = global::ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			this.rdbDolorPechoSi.Name = "rdbDolorPechoSi";
			this.rdbDolorPechoSi.Ripple = true;
			this.rdbDolorPechoSi.Size = new global::System.Drawing.Size(49, 37);
			this.rdbDolorPechoSi.TabIndex = 20;
			this.rdbDolorPechoSi.TabStop = true;
			this.rdbDolorPechoSi.Text = "Si";
			this.rdbDolorPechoSi.UseAccentColor = false;
			this.rdbDolorPechoSi.UseVisualStyleBackColor = true;
			this.numdolor.BackColor = global::System.Drawing.Color.White;
			this.numdolor.BaseColor = global::System.Drawing.Color.FromArgb(242, 246, 252);
			this.numdolor.BorderColorA = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numdolor.BorderColorB = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numdolor.BorderHoverColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numdolor.ButtonTextColorA = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numdolor.ButtonTextColorB = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numdolor.EnterKey = true;
			this.numdolor.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.numdolor.ForeColor = global::System.Drawing.Color.Black;
			this.numdolor.HoverButtonTextColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numdolor.HoverButtonTextColorB = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numdolor.Location = new global::System.Drawing.Point(1205, 297);
			this.numdolor.MaxNum = 10f;
			this.numdolor.MinimumSize = new global::System.Drawing.Size(1, 1);
			this.numdolor.MinNum = 0f;
			this.numdolor.Name = "numdolor";
			this.numdolor.Precision = 0;
			this.numdolor.Size = new global::System.Drawing.Size(120, 32);
			this.numdolor.Step = 1f;
			this.numdolor.Style = global::ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numdolor.TabIndex = 55;
			this.numdolor.Text = "hopeNumeric1";
			this.numdolor.ValueNumber = 0f;
			this.numtemperatura.BackColor = global::System.Drawing.Color.White;
			this.numtemperatura.BaseColor = global::System.Drawing.Color.FromArgb(242, 246, 252);
			this.numtemperatura.BorderColorA = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numtemperatura.BorderColorB = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numtemperatura.BorderHoverColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numtemperatura.ButtonTextColorA = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numtemperatura.ButtonTextColorB = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numtemperatura.EnterKey = true;
			this.numtemperatura.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.numtemperatura.ForeColor = global::System.Drawing.Color.Black;
			this.numtemperatura.HoverButtonTextColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numtemperatura.HoverButtonTextColorB = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numtemperatura.Location = new global::System.Drawing.Point(1205, 351);
			this.numtemperatura.MaxNum = 45f;
			this.numtemperatura.MinimumSize = new global::System.Drawing.Size(1, 1);
			this.numtemperatura.MinNum = 32f;
			this.numtemperatura.Name = "numtemperatura";
			this.numtemperatura.Precision = 1;
			this.numtemperatura.Size = new global::System.Drawing.Size(120, 32);
			this.numtemperatura.Step = 1f;
			this.numtemperatura.Style = global::ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numtemperatura.TabIndex = 56;
			this.numtemperatura.Text = "hopeNumeric2";
			this.numtemperatura.ValueNumber = 32f;
			this.numtemperatura.Click += new global::System.EventHandler(this.hopeNumeric2_Click);
			this.numoxigeno.BackColor = global::System.Drawing.Color.White;
			this.numoxigeno.BaseColor = global::System.Drawing.Color.FromArgb(242, 246, 252);
			this.numoxigeno.BorderColorA = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numoxigeno.BorderColorB = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numoxigeno.BorderHoverColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numoxigeno.ButtonTextColorA = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numoxigeno.ButtonTextColorB = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numoxigeno.EnterKey = true;
			this.numoxigeno.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.numoxigeno.ForeColor = global::System.Drawing.Color.Black;
			this.numoxigeno.HoverButtonTextColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numoxigeno.HoverButtonTextColorB = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numoxigeno.Location = new global::System.Drawing.Point(1205, 404);
			this.numoxigeno.MaxNum = 100f;
			this.numoxigeno.MinimumSize = new global::System.Drawing.Size(0, 1);
			this.numoxigeno.MinNum = 0f;
			this.numoxigeno.Name = "numoxigeno";
			this.numoxigeno.Precision = 1;
			this.numoxigeno.Size = new global::System.Drawing.Size(120, 32);
			this.numoxigeno.Step = 1f;
			this.numoxigeno.Style = global::ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numoxigeno.TabIndex = 57;
			this.numoxigeno.Text = "hopeNumeric3";
			this.numoxigeno.ValueNumber = 0f;
			this.numevolucion.BackColor = global::System.Drawing.Color.White;
			this.numevolucion.BaseColor = global::System.Drawing.Color.FromArgb(242, 246, 252);
			this.numevolucion.BorderColorA = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numevolucion.BorderColorB = global::System.Drawing.Color.FromArgb(192, 196, 204);
			this.numevolucion.BorderHoverColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numevolucion.ButtonTextColorA = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numevolucion.ButtonTextColorB = global::System.Drawing.Color.FromArgb(144, 147, 153);
			this.numevolucion.EnterKey = true;
			this.numevolucion.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.numevolucion.ForeColor = global::System.Drawing.Color.Black;
			this.numevolucion.HoverButtonTextColorA = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numevolucion.HoverButtonTextColorB = global::System.Drawing.Color.FromArgb(64, 158, 255);
			this.numevolucion.Location = new global::System.Drawing.Point(1206, 455);
			this.numevolucion.MaxNum = 300f;
			this.numevolucion.MinimumSize = new global::System.Drawing.Size(1, 1);
			this.numevolucion.MinNum = 0f;
			this.numevolucion.Name = "numevolucion";
			this.numevolucion.Precision = 1;
			this.numevolucion.Size = new global::System.Drawing.Size(120, 32);
			this.numevolucion.Step = 1f;
			this.numevolucion.Style = global::ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
			this.numevolucion.TabIndex = 58;
			this.numevolucion.Text = "hopeNumeric4";
			this.numevolucion.ValueNumber = 0f;
			this.cbmotivo.FormattingEnabled = true;
			this.cbmotivo.ItemHeight = 23;
			this.cbmotivo.Items.AddRange(new object[]
			{
				"Traumatismo / Accidente",
				"Problemas Respiratorios",
				"Dolor Abdominal / Gastrointestinal",
				"Fiebre / Infección",
				"Consulta General / Rutina",
				"Sospecha de derrame (ACV)",
				"Reacción alérgica grave",
				"Dolor en el pecho / Problemas cardíacos",
				"Intoxicación / Envenenamiento / Sobredosis",
				"Convulsiones / Epilepsia",
				"Crisis de salud mental / Agitación",
				"Emergencia Obstétrica / Embarazo",
				"Dolor de cabeza severo / Migraña extrema",
				"Problemas urinarios / Renales",
				"Lesiones menores / Cortes superficiales",
				"Dolor muscular / Articular crónico",
				"Problemas en la piel / Erupciones Leve ",
				"Resfriado común / Tos leve"
			});
			this.cbmotivo.Location = new global::System.Drawing.Point(320, 500);
			this.cbmotivo.Name = "cbmotivo";
			this.cbmotivo.Size = new global::System.Drawing.Size(292, 29);
			this.cbmotivo.TabIndex = 64;
			this.cbmotivo.UseSelectable = true;
			this.cbestadomental.FormattingEnabled = true;
			this.cbestadomental.ItemHeight = 23;
			this.cbestadomental.Items.AddRange(new object[]
			{
				"Alerta y orientado",
				"Responde a estimulos verbales",
				"Responde solo al dolor",
				"Inconsciente"
			});
			this.cbestadomental.Location = new global::System.Drawing.Point(320, 561);
			this.cbestadomental.Name = "cbestadomental";
			this.cbestadomental.Size = new global::System.Drawing.Size(292, 29);
			this.cbestadomental.TabIndex = 65;
			this.cbestadomental.UseSelectable = true;
			this.cbmecanismo.FormattingEnabled = true;
			this.cbmecanismo.ItemHeight = 23;
			this.cbmecanismo.Items.AddRange(new object[]
			{
				"Caída desde su propia altura",
				"Accidente de transito",
				"Quemadura",
				"Corte / Herida punzante",
				"Traumatismo / Accidente leve",
				"No aplica"
			});
			this.cbmecanismo.Location = new global::System.Drawing.Point(320, 622);
			this.cbmecanismo.Name = "cbmecanismo";
			this.cbmecanismo.Size = new global::System.Drawing.Size(292, 29);
			this.cbmecanismo.TabIndex = 66;
			this.cbmecanismo.UseSelectable = true;
			this.btncancelar.BackColor = global::System.Drawing.Color.Transparent;
			this.btncancelar.BorderColor = global::System.Drawing.Color.Black;
			this.btncancelar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btncancelar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btncancelar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btncancelar.Image = null;
			this.btncancelar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btncancelar.InactiveColor = global::System.Drawing.Color.LightCoral;
			this.btncancelar.Location = new global::System.Drawing.Point(477, 694);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.Size = new global::System.Drawing.Size(120, 40);
			this.btncancelar.TabIndex = 67;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btncancelar.Click += new global::System.EventHandler(this.btncancelar_Click);
			this.btningresar.BackColor = global::System.Drawing.Color.Transparent;
			this.btningresar.BorderColor = global::System.Drawing.Color.Black;
			this.btningresar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btningresar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btningresar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btningresar.Image = null;
			this.btningresar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btningresar.InactiveColor = global::System.Drawing.Color.MediumOrchid;
			this.btningresar.Location = new global::System.Drawing.Point(793, 694);
			this.btningresar.Name = "btningresar";
			this.btningresar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.Size = new global::System.Drawing.Size(120, 40);
			this.btningresar.TabIndex = 68;
			this.btningresar.Text = "Ingresar";
			this.btningresar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btningresar.Click += new global::System.EventHandler(this.btningresar_Click);
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.Indigo;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.MediumSlateBlue;
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.label1);
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(-17, -6);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1434, 73);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 69;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.panel1.BackColor = global::System.Drawing.Color.Indigo;
			this.panel1.Location = new global::System.Drawing.Point(59, 453);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(771, 1);
			this.panel1.TabIndex = 70;
			this.panel2.BackColor = global::System.Drawing.Color.Indigo;
			this.panel2.Location = new global::System.Drawing.Point(59, 398);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(771, 1);
			this.panel2.TabIndex = 71;
			this.panel3.BackColor = global::System.Drawing.Color.Indigo;
			this.panel3.Location = new global::System.Drawing.Point(59, 337);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(771, 1);
			this.panel3.TabIndex = 72;
			this.panel4.BackColor = global::System.Drawing.Color.Indigo;
			this.panel4.Location = new global::System.Drawing.Point(59, 281);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(771, 1);
			this.panel4.TabIndex = 73;
			this.panel5.BackColor = global::System.Drawing.Color.Indigo;
			this.panel5.Location = new global::System.Drawing.Point(59, 225);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(771, 1);
			this.panel5.TabIndex = 74;
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label15.Location = new global::System.Drawing.Point(1097, 123);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(47, 21);
			this.label15.TabIndex = 75;
			this.label15.Text = "Edad:\r\n";
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label16.Location = new global::System.Drawing.Point(955, 245);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(39, 21);
			this.label16.TabIndex = 77;
			this.label16.Text = "DUI:";
			this.txtdui.BackColor = global::System.Drawing.Color.Transparent;
			this.txtdui.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtdui.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtdui.Image = null;
			this.txtdui.Location = new global::System.Drawing.Point(1000, 237);
			this.txtdui.MaxLength = 32767;
			this.txtdui.Multiline = false;
			this.txtdui.Name = "txtdui";
			this.txtdui.ReadOnly = false;
			this.txtdui.Size = new global::System.Drawing.Size(326, 41);
			this.txtdui.TabIndex = 78;
			this.txtdui.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtdui.UseSystemPasswordChar = false;
			this.txtdui.Enter += new global::System.EventHandler(this.txtdui_Enter);
			this.dateedad.FontSize = global::ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
			this.dateedad.Location = new global::System.Drawing.Point(1150, 120);
			this.dateedad.MinimumSize = new global::System.Drawing.Size(0, 29);
			this.dateedad.Name = "dateedad";
			this.dateedad.Size = new global::System.Drawing.Size(178, 29);
			this.dateedad.TabIndex = 79;
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label17.Location = new global::System.Drawing.Point(955, 190);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(64, 21);
			this.label17.TabIndex = 80;
			this.label17.Text = "Genero:";
			this.cbgenero.FormattingEnabled = true;
			this.cbgenero.ItemHeight = 23;
			this.cbgenero.Items.AddRange(new object[]
			{
				"Masculino",
				"Femenino"
			});
			this.cbgenero.Location = new global::System.Drawing.Point(1033, 189);
			this.cbgenero.Name = "cbgenero";
			this.cbgenero.Size = new global::System.Drawing.Size(292, 29);
			this.cbgenero.TabIndex = 81;
			this.cbgenero.UseSelectable = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1391, 800);
			base.Controls.Add(this.cbgenero);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.dateedad);
			base.Controls.Add(this.txtdui);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Controls.Add(this.btningresar);
			base.Controls.Add(this.btncancelar);
			base.Controls.Add(this.cbmecanismo);
			base.Controls.Add(this.cbestadomental);
			base.Controls.Add(this.cbmotivo);
			base.Controls.Add(this.numevolucion);
			base.Controls.Add(this.numoxigeno);
			base.Controls.Add(this.numtemperatura);
			base.Controls.Add(this.numdolor);
			base.Controls.Add(this.panelRedondeado5);
			base.Controls.Add(this.panelRedondeado4);
			base.Controls.Add(this.panelRedondeado3);
			base.Controls.Add(this.panelRedondeado2);
			base.Controls.Add(this.txtapellidos);
			base.Controls.Add(this.txtnombre);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.panelRedondeado1);
			base.Name = "Enfermera";
			this.Text = "Edad:";
			base.Load += new global::System.EventHandler(this.Enfermera_Load);
			this.panelRedondeado1.ResumeLayout(false);
			this.panelRedondeado1.PerformLayout();
			this.panelRedondeado2.ResumeLayout(false);
			this.panelRedondeado2.PerformLayout();
			this.panelRedondeado3.ResumeLayout(false);
			this.panelRedondeado3.PerformLayout();
			this.panelRedondeado4.ResumeLayout(false);
			this.panelRedondeado4.PerformLayout();
			this.panelRedondeado5.ResumeLayout(false);
			this.panelRedondeado5.PerformLayout();
			this.parrotGradientPanel1.ResumeLayout(false);
			this.parrotGradientPanel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000044 RID: 68
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400004B RID: 75
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDesmayoSi;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000053 RID: 83
		private global::Fase_1_C_.PanelRedondeado panelRedondeado1;

		// Token: 0x04000054 RID: 84
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDesmayoNo;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000056 RID: 86
		private global::ReaLTaiizor.Controls.BigTextBox txtnombre;

		// Token: 0x04000057 RID: 87
		private global::ReaLTaiizor.Controls.BigTextBox txtapellidos;

		// Token: 0x04000058 RID: 88
		private global::Fase_1_C_.PanelRedondeado panelRedondeado2;

		// Token: 0x04000059 RID: 89
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbHemorragiaNo;

		// Token: 0x0400005A RID: 90
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbHemorragiaSi;

		// Token: 0x0400005B RID: 91
		private global::Fase_1_C_.PanelRedondeado panelRedondeado3;

		// Token: 0x0400005C RID: 92
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDificultadadResNo;

		// Token: 0x0400005D RID: 93
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDificultadadResSi;

		// Token: 0x0400005E RID: 94
		private global::Fase_1_C_.PanelRedondeado panelRedondeado4;

		// Token: 0x0400005F RID: 95
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbTraumaCraneoNo;

		// Token: 0x04000060 RID: 96
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbTraumaCraneoSi;

		// Token: 0x04000061 RID: 97
		private global::Fase_1_C_.PanelRedondeado panelRedondeado5;

		// Token: 0x04000062 RID: 98
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDolorPechoNo;

		// Token: 0x04000063 RID: 99
		private global::ReaLTaiizor.Controls.MaterialRadioButton rdbDolorPechoSi;

		// Token: 0x04000064 RID: 100
		private global::ReaLTaiizor.Controls.HopeNumeric numdolor;

		// Token: 0x04000065 RID: 101
		private global::ReaLTaiizor.Controls.HopeNumeric numtemperatura;

		// Token: 0x04000066 RID: 102
		private global::ReaLTaiizor.Controls.HopeNumeric numoxigeno;

		// Token: 0x04000067 RID: 103
		private global::ReaLTaiizor.Controls.HopeNumeric numevolucion;

		// Token: 0x04000068 RID: 104
		private global::ReaLTaiizor.Controls.PoisonComboBox cbmotivo;

		// Token: 0x04000069 RID: 105
		private global::ReaLTaiizor.Controls.PoisonComboBox cbestadomental;

		// Token: 0x0400006A RID: 106
		private global::ReaLTaiizor.Controls.PoisonComboBox cbmecanismo;

		// Token: 0x0400006B RID: 107
		private global::ReaLTaiizor.Controls.Button btncancelar;

		// Token: 0x0400006C RID: 108
		private global::ReaLTaiizor.Controls.Button btningresar;

		// Token: 0x0400006D RID: 109
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000075 RID: 117
		private global::ReaLTaiizor.Controls.BigTextBox txtdui;

		// Token: 0x04000076 RID: 118
		private global::ReaLTaiizor.Controls.PoisonDateTime dateedad;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000078 RID: 120
		private global::ReaLTaiizor.Controls.PoisonComboBox cbgenero;
	}
}
