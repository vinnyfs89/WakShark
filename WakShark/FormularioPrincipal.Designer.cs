﻿namespace WakBoy
{
    public partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.capinacao = new System.Windows.Forms.TabPage();
            this.checkBoxUtilizarRecursoSecundario = new System.Windows.Forms.CheckBox();
            this.groupBoxRecursoSecundario = new System.Windows.Forms.GroupBox();
            this.pictureBoxMiniaturaAcao2 = new System.Windows.Forms.PictureBox();
            this.comboBoxAcao2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxMiniaturaRecurso2 = new System.Windows.Forms.PictureBox();
            this.comboBoxRecurso2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxMovimentarAleatoriamente = new System.Windows.Forms.CheckBox();
            this.checkBoxAtivarBaixoConsumo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMiniaturaAcao = new System.Windows.Forms.PictureBox();
            this.comboBoxAcao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxMiniaturaRecurso = new System.Windows.Forms.PictureBox();
            this.comboBoxRecurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxMascaraLuminosidade = new System.Windows.Forms.CheckBox();
            this.labelObrigatorio = new System.Windows.Forms.Label();
            this.comboBoxTipoBusca = new System.Windows.Forms.ComboBox();
            this.labelTipoBusca = new System.Windows.Forms.Label();
            this.checkBoxCacadorPixelsLigado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abaCapturadorPixels = new System.Windows.Forms.TabPage();
            this.botaoScreenshotRotacionado = new System.Windows.Forms.Button();
            this.labelHorarioFranca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTransparencia = new System.Windows.Forms.TextBox();
            this.labelTransparencia = new System.Windows.Forms.Label();
            this.checkBoxVisualizarPixel = new System.Windows.Forms.CheckBox();
            this.labelLuminosidade = new System.Windows.Forms.Label();
            this.labelSaturacao = new System.Windows.Forms.Label();
            this.labelMatiz = new System.Windows.Forms.Label();
            this.textBoxLocalizacaoScreenshot = new System.Windows.Forms.TextBox();
            this.botaoScreenshot = new System.Windows.Forms.Button();
            this.checkBoxMostraPixelMovimentoMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxCapturaContinua = new System.Windows.Forms.CheckBox();
            this.textBoxLocalizacaoPixelsCapturados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTituloCaptura = new System.Windows.Forms.Label();
            this.textBoxTituloCaptura = new System.Windows.Forms.TextBox();
            this.labelEixoHorizontalPixel = new System.Windows.Forms.Label();
            this.labelEixoVerticalPixel = new System.Windows.Forms.Label();
            this.panelCorPixel = new System.Windows.Forms.Panel();
            this.checkBoxCapturadorLigado = new System.Windows.Forms.CheckBox();
            this.labelCor = new System.Windows.Forms.Label();
            this.timerHorarioFrances = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogImagemTemplate = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.capinacao.SuspendLayout();
            this.groupBoxRecursoSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaAcao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaRecurso2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaAcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaRecurso)).BeginInit();
            this.abaCapturadorPixels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.capinacao);
            this.tabControl1.Controls.Add(this.abaCapturadorPixels);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 389);
            this.tabControl1.TabIndex = 1;
            // 
            // capinacao
            // 
            this.capinacao.Controls.Add(this.checkBoxUtilizarRecursoSecundario);
            this.capinacao.Controls.Add(this.groupBoxRecursoSecundario);
            this.capinacao.Controls.Add(this.checkBoxMovimentarAleatoriamente);
            this.capinacao.Controls.Add(this.checkBoxAtivarBaixoConsumo);
            this.capinacao.Controls.Add(this.groupBox1);
            this.capinacao.Controls.Add(this.checkBoxMascaraLuminosidade);
            this.capinacao.Controls.Add(this.labelObrigatorio);
            this.capinacao.Controls.Add(this.comboBoxTipoBusca);
            this.capinacao.Controls.Add(this.labelTipoBusca);
            this.capinacao.Controls.Add(this.checkBoxCacadorPixelsLigado);
            this.capinacao.Controls.Add(this.label1);
            this.capinacao.Location = new System.Drawing.Point(4, 22);
            this.capinacao.Name = "capinacao";
            this.capinacao.Padding = new System.Windows.Forms.Padding(3);
            this.capinacao.Size = new System.Drawing.Size(433, 363);
            this.capinacao.TabIndex = 0;
            this.capinacao.Text = "Caçador de Pixels";
            this.capinacao.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtilizarRecursoSecundario
            // 
            this.checkBoxUtilizarRecursoSecundario.AutoSize = true;
            this.checkBoxUtilizarRecursoSecundario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUtilizarRecursoSecundario.Location = new System.Drawing.Point(23, 131);
            this.checkBoxUtilizarRecursoSecundario.Name = "checkBoxUtilizarRecursoSecundario";
            this.checkBoxUtilizarRecursoSecundario.Size = new System.Drawing.Size(150, 17);
            this.checkBoxUtilizarRecursoSecundario.TabIndex = 24;
            this.checkBoxUtilizarRecursoSecundario.Text = "Utilizar recurso secundário";
            this.checkBoxUtilizarRecursoSecundario.UseVisualStyleBackColor = true;
            this.checkBoxUtilizarRecursoSecundario.CheckedChanged += new System.EventHandler(this.checkBoxUtilizarRecursoSecundario_CheckedChanged);
            // 
            // groupBoxRecursoSecundario
            // 
            this.groupBoxRecursoSecundario.Controls.Add(this.pictureBoxMiniaturaAcao2);
            this.groupBoxRecursoSecundario.Controls.Add(this.comboBoxAcao2);
            this.groupBoxRecursoSecundario.Controls.Add(this.label7);
            this.groupBoxRecursoSecundario.Controls.Add(this.pictureBoxMiniaturaRecurso2);
            this.groupBoxRecursoSecundario.Controls.Add(this.comboBoxRecurso2);
            this.groupBoxRecursoSecundario.Controls.Add(this.label8);
            this.groupBoxRecursoSecundario.Location = new System.Drawing.Point(23, 153);
            this.groupBoxRecursoSecundario.Name = "groupBoxRecursoSecundario";
            this.groupBoxRecursoSecundario.Size = new System.Drawing.Size(382, 94);
            this.groupBoxRecursoSecundario.TabIndex = 23;
            this.groupBoxRecursoSecundario.TabStop = false;
            this.groupBoxRecursoSecundario.Text = "[ Recurso Secundário ]";
            this.groupBoxRecursoSecundario.Visible = false;
            // 
            // pictureBoxMiniaturaAcao2
            // 
            this.pictureBoxMiniaturaAcao2.Location = new System.Drawing.Point(342, 55);
            this.pictureBoxMiniaturaAcao2.Name = "pictureBoxMiniaturaAcao2";
            this.pictureBoxMiniaturaAcao2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMiniaturaAcao2.TabIndex = 24;
            this.pictureBoxMiniaturaAcao2.TabStop = false;
            // 
            // comboBoxAcao2
            // 
            this.comboBoxAcao2.FormattingEnabled = true;
            this.comboBoxAcao2.Location = new System.Drawing.Point(115, 54);
            this.comboBoxAcao2.Name = "comboBoxAcao2";
            this.comboBoxAcao2.Size = new System.Drawing.Size(221, 21);
            this.comboBoxAcao2.TabIndex = 22;
            this.comboBoxAcao2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcao2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ação:";
            // 
            // pictureBoxMiniaturaRecurso2
            // 
            this.pictureBoxMiniaturaRecurso2.Location = new System.Drawing.Point(342, 21);
            this.pictureBoxMiniaturaRecurso2.Name = "pictureBoxMiniaturaRecurso2";
            this.pictureBoxMiniaturaRecurso2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMiniaturaRecurso2.TabIndex = 17;
            this.pictureBoxMiniaturaRecurso2.TabStop = false;
            // 
            // comboBoxRecurso2
            // 
            this.comboBoxRecurso2.FormattingEnabled = true;
            this.comboBoxRecurso2.Location = new System.Drawing.Point(115, 20);
            this.comboBoxRecurso2.Name = "comboBoxRecurso2";
            this.comboBoxRecurso2.Size = new System.Drawing.Size(221, 21);
            this.comboBoxRecurso2.TabIndex = 16;
            this.comboBoxRecurso2.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecurso2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recurso :";
            // 
            // checkBoxMovimentarAleatoriamente
            // 
            this.checkBoxMovimentarAleatoriamente.AutoSize = true;
            this.checkBoxMovimentarAleatoriamente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMovimentarAleatoriamente.Location = new System.Drawing.Point(23, 306);
            this.checkBoxMovimentarAleatoriamente.Name = "checkBoxMovimentarAleatoriamente";
            this.checkBoxMovimentarAleatoriamente.Size = new System.Drawing.Size(154, 17);
            this.checkBoxMovimentarAleatoriamente.TabIndex = 18;
            this.checkBoxMovimentarAleatoriamente.Text = "Movimentar Aleatoriamente";
            this.checkBoxMovimentarAleatoriamente.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtivarBaixoConsumo
            // 
            this.checkBoxAtivarBaixoConsumo.AutoSize = true;
            this.checkBoxAtivarBaixoConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAtivarBaixoConsumo.Location = new System.Drawing.Point(23, 283);
            this.checkBoxAtivarBaixoConsumo.Name = "checkBoxAtivarBaixoConsumo";
            this.checkBoxAtivarBaixoConsumo.Size = new System.Drawing.Size(159, 17);
            this.checkBoxAtivarBaixoConsumo.TabIndex = 17;
            this.checkBoxAtivarBaixoConsumo.Text = "Ativar Modo Baixo Consumo";
            this.checkBoxAtivarBaixoConsumo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxMiniaturaAcao);
            this.groupBox1.Controls.Add(this.comboBoxAcao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBoxMiniaturaRecurso);
            this.groupBox1.Controls.Add(this.comboBoxRecurso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 92);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Recurso Primário ]";
            // 
            // pictureBoxMiniaturaAcao
            // 
            this.pictureBoxMiniaturaAcao.Location = new System.Drawing.Point(342, 57);
            this.pictureBoxMiniaturaAcao.Name = "pictureBoxMiniaturaAcao";
            this.pictureBoxMiniaturaAcao.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMiniaturaAcao.TabIndex = 23;
            this.pictureBoxMiniaturaAcao.TabStop = false;
            // 
            // comboBoxAcao
            // 
            this.comboBoxAcao.FormattingEnabled = true;
            this.comboBoxAcao.Location = new System.Drawing.Point(115, 54);
            this.comboBoxAcao.Name = "comboBoxAcao";
            this.comboBoxAcao.Size = new System.Drawing.Size(221, 21);
            this.comboBoxAcao.TabIndex = 22;
            this.comboBoxAcao.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ação:";
            // 
            // pictureBoxMiniaturaRecurso
            // 
            this.pictureBoxMiniaturaRecurso.Location = new System.Drawing.Point(342, 20);
            this.pictureBoxMiniaturaRecurso.Name = "pictureBoxMiniaturaRecurso";
            this.pictureBoxMiniaturaRecurso.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMiniaturaRecurso.TabIndex = 17;
            this.pictureBoxMiniaturaRecurso.TabStop = false;
            // 
            // comboBoxRecurso
            // 
            this.comboBoxRecurso.FormattingEnabled = true;
            this.comboBoxRecurso.Location = new System.Drawing.Point(115, 20);
            this.comboBoxRecurso.Name = "comboBoxRecurso";
            this.comboBoxRecurso.Size = new System.Drawing.Size(221, 21);
            this.comboBoxRecurso.TabIndex = 16;
            this.comboBoxRecurso.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Recurso :";
            // 
            // checkBoxMascaraLuminosidade
            // 
            this.checkBoxMascaraLuminosidade.AutoSize = true;
            this.checkBoxMascaraLuminosidade.Checked = true;
            this.checkBoxMascaraLuminosidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMascaraLuminosidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMascaraLuminosidade.Location = new System.Drawing.Point(23, 260);
            this.checkBoxMascaraLuminosidade.Name = "checkBoxMascaraLuminosidade";
            this.checkBoxMascaraLuminosidade.Size = new System.Drawing.Size(232, 17);
            this.checkBoxMascaraLuminosidade.TabIndex = 15;
            this.checkBoxMascaraLuminosidade.Text = "Utilizar máscara de luminosidade por horário";
            this.checkBoxMascaraLuminosidade.UseVisualStyleBackColor = true;
            // 
            // labelObrigatorio
            // 
            this.labelObrigatorio.AutoSize = true;
            this.labelObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.labelObrigatorio.Location = new System.Drawing.Point(81, 8);
            this.labelObrigatorio.Name = "labelObrigatorio";
            this.labelObrigatorio.Size = new System.Drawing.Size(11, 13);
            this.labelObrigatorio.TabIndex = 13;
            this.labelObrigatorio.Text = "*";
            // 
            // comboBoxTipoBusca
            // 
            this.comboBoxTipoBusca.FormattingEnabled = true;
            this.comboBoxTipoBusca.Location = new System.Drawing.Point(98, 8);
            this.comboBoxTipoBusca.Name = "comboBoxTipoBusca";
            this.comboBoxTipoBusca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoBusca.TabIndex = 9;
            this.comboBoxTipoBusca.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoBusca_SelectedIndexChanged);
            // 
            // labelTipoBusca
            // 
            this.labelTipoBusca.AutoSize = true;
            this.labelTipoBusca.Location = new System.Drawing.Point(20, 8);
            this.labelTipoBusca.Name = "labelTipoBusca";
            this.labelTipoBusca.Size = new System.Drawing.Size(64, 13);
            this.labelTipoBusca.TabIndex = 8;
            this.labelTipoBusca.Text = "Tipo Busca:";
            // 
            // checkBoxCacadorPixelsLigado
            // 
            this.checkBoxCacadorPixelsLigado.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCacadorPixelsLigado.AutoSize = true;
            this.checkBoxCacadorPixelsLigado.Location = new System.Drawing.Point(23, 331);
            this.checkBoxCacadorPixelsLigado.Name = "checkBoxCacadorPixelsLigado";
            this.checkBoxCacadorPixelsLigado.Size = new System.Drawing.Size(45, 23);
            this.checkBoxCacadorPixelsLigado.TabIndex = 7;
            this.checkBoxCacadorPixelsLigado.Text = "Iniciar";
            this.checkBoxCacadorPixelsLigado.UseVisualStyleBackColor = true;
            this.checkBoxCacadorPixelsLigado.CheckedChanged += new System.EventHandler(this.checkBoxCacadorPixelsLigado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "( ou pressione \"SHIFT + F4\" para INICIAR / PARAR )";
            // 
            // abaCapturadorPixels
            // 
            this.abaCapturadorPixels.Controls.Add(this.botaoScreenshotRotacionado);
            this.abaCapturadorPixels.Controls.Add(this.labelHorarioFranca);
            this.abaCapturadorPixels.Controls.Add(this.label3);
            this.abaCapturadorPixels.Controls.Add(this.textBoxTransparencia);
            this.abaCapturadorPixels.Controls.Add(this.labelTransparencia);
            this.abaCapturadorPixels.Controls.Add(this.checkBoxVisualizarPixel);
            this.abaCapturadorPixels.Controls.Add(this.labelLuminosidade);
            this.abaCapturadorPixels.Controls.Add(this.labelSaturacao);
            this.abaCapturadorPixels.Controls.Add(this.labelMatiz);
            this.abaCapturadorPixels.Controls.Add(this.textBoxLocalizacaoScreenshot);
            this.abaCapturadorPixels.Controls.Add(this.botaoScreenshot);
            this.abaCapturadorPixels.Controls.Add(this.checkBoxMostraPixelMovimentoMouse);
            this.abaCapturadorPixels.Controls.Add(this.checkBoxCapturaContinua);
            this.abaCapturadorPixels.Controls.Add(this.textBoxLocalizacaoPixelsCapturados);
            this.abaCapturadorPixels.Controls.Add(this.label2);
            this.abaCapturadorPixels.Controls.Add(this.labelTituloCaptura);
            this.abaCapturadorPixels.Controls.Add(this.textBoxTituloCaptura);
            this.abaCapturadorPixels.Controls.Add(this.labelEixoHorizontalPixel);
            this.abaCapturadorPixels.Controls.Add(this.labelEixoVerticalPixel);
            this.abaCapturadorPixels.Controls.Add(this.panelCorPixel);
            this.abaCapturadorPixels.Controls.Add(this.checkBoxCapturadorLigado);
            this.abaCapturadorPixels.Controls.Add(this.labelCor);
            this.abaCapturadorPixels.Location = new System.Drawing.Point(4, 22);
            this.abaCapturadorPixels.Name = "abaCapturadorPixels";
            this.abaCapturadorPixels.Padding = new System.Windows.Forms.Padding(3);
            this.abaCapturadorPixels.Size = new System.Drawing.Size(433, 363);
            this.abaCapturadorPixels.TabIndex = 1;
            this.abaCapturadorPixels.Text = "Capturador de Pixels";
            this.abaCapturadorPixels.UseVisualStyleBackColor = true;
            // 
            // botaoScreenshotRotacionado
            // 
            this.botaoScreenshotRotacionado.Location = new System.Drawing.Point(129, 218);
            this.botaoScreenshotRotacionado.Name = "botaoScreenshotRotacionado";
            this.botaoScreenshotRotacionado.Size = new System.Drawing.Size(133, 23);
            this.botaoScreenshotRotacionado.TabIndex = 22;
            this.botaoScreenshotRotacionado.Text = "Screenshot Rotacionado";
            this.botaoScreenshotRotacionado.UseVisualStyleBackColor = true;
            this.botaoScreenshotRotacionado.Click += new System.EventHandler(this.botaoScreenshotRotacionado_Click);
            // 
            // labelHorarioFranca
            // 
            this.labelHorarioFranca.AutoSize = true;
            this.labelHorarioFranca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHorarioFranca.Location = new System.Drawing.Point(125, 315);
            this.labelHorarioFranca.Name = "labelHorarioFranca";
            this.labelHorarioFranca.Size = new System.Drawing.Size(51, 15);
            this.labelHorarioFranca.TabIndex = 21;
            this.labelHorarioFranca.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Horário Atual (França):";
            // 
            // textBoxTransparencia
            // 
            this.textBoxTransparencia.Location = new System.Drawing.Point(138, 292);
            this.textBoxTransparencia.Name = "textBoxTransparencia";
            this.textBoxTransparencia.Size = new System.Drawing.Size(38, 20);
            this.textBoxTransparencia.TabIndex = 19;
            // 
            // labelTransparencia
            // 
            this.labelTransparencia.AutoSize = true;
            this.labelTransparencia.Location = new System.Drawing.Point(9, 295);
            this.labelTransparencia.Name = "labelTransparencia";
            this.labelTransparencia.Size = new System.Drawing.Size(123, 13);
            this.labelTransparencia.TabIndex = 18;
            this.labelTransparencia.Text = "Transparência (0 - 255) :";
            // 
            // checkBoxVisualizarPixel
            // 
            this.checkBoxVisualizarPixel.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxVisualizarPixel.AutoSize = true;
            this.checkBoxVisualizarPixel.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxVisualizarPixel.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxVisualizarPixel.Location = new System.Drawing.Point(9, 223);
            this.checkBoxVisualizarPixel.Name = "checkBoxVisualizarPixel";
            this.checkBoxVisualizarPixel.Size = new System.Drawing.Size(86, 23);
            this.checkBoxVisualizarPixel.TabIndex = 17;
            this.checkBoxVisualizarPixel.Text = "Visualizar Pixel";
            this.checkBoxVisualizarPixel.UseVisualStyleBackColor = false;
            this.checkBoxVisualizarPixel.CheckedChanged += new System.EventHandler(this.checkBoxVisualizarPixel_CheckedChanged);
            // 
            // labelLuminosidade
            // 
            this.labelLuminosidade.AutoSize = true;
            this.labelLuminosidade.Location = new System.Drawing.Point(300, 169);
            this.labelLuminosidade.Name = "labelLuminosidade";
            this.labelLuminosidade.Size = new System.Drawing.Size(75, 13);
            this.labelLuminosidade.TabIndex = 16;
            this.labelLuminosidade.Text = "Luminosidade:";
            // 
            // labelSaturacao
            // 
            this.labelSaturacao.AutoSize = true;
            this.labelSaturacao.Location = new System.Drawing.Point(300, 146);
            this.labelSaturacao.Name = "labelSaturacao";
            this.labelSaturacao.Size = new System.Drawing.Size(59, 13);
            this.labelSaturacao.TabIndex = 15;
            this.labelSaturacao.Text = "Saturação:";
            // 
            // labelMatiz
            // 
            this.labelMatiz.AutoSize = true;
            this.labelMatiz.Location = new System.Drawing.Point(300, 122);
            this.labelMatiz.Name = "labelMatiz";
            this.labelMatiz.Size = new System.Drawing.Size(35, 13);
            this.labelMatiz.TabIndex = 14;
            this.labelMatiz.Text = "Matiz:";
            // 
            // textBoxLocalizacaoScreenshot
            // 
            this.textBoxLocalizacaoScreenshot.Location = new System.Drawing.Point(211, 254);
            this.textBoxLocalizacaoScreenshot.Name = "textBoxLocalizacaoScreenshot";
            this.textBoxLocalizacaoScreenshot.Size = new System.Drawing.Size(164, 20);
            this.textBoxLocalizacaoScreenshot.TabIndex = 13;
            this.textBoxLocalizacaoScreenshot.Text = "C:\\Users\\Public\\imagem.bmp";
            // 
            // botaoScreenshot
            // 
            this.botaoScreenshot.Location = new System.Drawing.Point(129, 252);
            this.botaoScreenshot.Name = "botaoScreenshot";
            this.botaoScreenshot.Size = new System.Drawing.Size(75, 23);
            this.botaoScreenshot.TabIndex = 12;
            this.botaoScreenshot.Text = "Screenshot";
            this.botaoScreenshot.UseVisualStyleBackColor = true;
            this.botaoScreenshot.Click += new System.EventHandler(this.botaoScreenshot_Click);
            // 
            // checkBoxMostraPixelMovimentoMouse
            // 
            this.checkBoxMostraPixelMovimentoMouse.AutoSize = true;
            this.checkBoxMostraPixelMovimentoMouse.Location = new System.Drawing.Point(106, 97);
            this.checkBoxMostraPixelMovimentoMouse.Name = "checkBoxMostraPixelMovimentoMouse";
            this.checkBoxMostraPixelMovimentoMouse.Size = new System.Drawing.Size(156, 17);
            this.checkBoxMostraPixelMovimentoMouse.TabIndex = 11;
            this.checkBoxMostraPixelMovimentoMouse.Text = "Exibir pixel ao mover mouse";
            this.checkBoxMostraPixelMovimentoMouse.UseVisualStyleBackColor = true;
            // 
            // checkBoxCapturaContinua
            // 
            this.checkBoxCapturaContinua.AutoSize = true;
            this.checkBoxCapturaContinua.Checked = true;
            this.checkBoxCapturaContinua.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCapturaContinua.Location = new System.Drawing.Point(106, 74);
            this.checkBoxCapturaContinua.Name = "checkBoxCapturaContinua";
            this.checkBoxCapturaContinua.Size = new System.Drawing.Size(108, 17);
            this.checkBoxCapturaContinua.TabIndex = 10;
            this.checkBoxCapturaContinua.Text = "Captura Continua";
            this.checkBoxCapturaContinua.UseVisualStyleBackColor = true;
            // 
            // textBoxLocalizacaoPixelsCapturados
            // 
            this.textBoxLocalizacaoPixelsCapturados.Location = new System.Drawing.Point(123, 48);
            this.textBoxLocalizacaoPixelsCapturados.Name = "textBoxLocalizacaoPixelsCapturados";
            this.textBoxLocalizacaoPixelsCapturados.Size = new System.Drawing.Size(271, 20);
            this.textBoxLocalizacaoPixelsCapturados.TabIndex = 9;
            this.textBoxLocalizacaoPixelsCapturados.Text = "C:\\Users\\Public\\WAKLocation.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gravar em:";
            // 
            // labelTituloCaptura
            // 
            this.labelTituloCaptura.AutoSize = true;
            this.labelTituloCaptura.Location = new System.Drawing.Point(6, 21);
            this.labelTituloCaptura.Name = "labelTituloCaptura";
            this.labelTituloCaptura.Size = new System.Drawing.Size(75, 13);
            this.labelTituloCaptura.TabIndex = 6;
            this.labelTituloCaptura.Text = "Título Captura";
            // 
            // textBoxTituloCaptura
            // 
            this.textBoxTituloCaptura.AcceptsReturn = true;
            this.textBoxTituloCaptura.Location = new System.Drawing.Point(123, 21);
            this.textBoxTituloCaptura.Name = "textBoxTituloCaptura";
            this.textBoxTituloCaptura.Size = new System.Drawing.Size(271, 20);
            this.textBoxTituloCaptura.TabIndex = 5;
            this.textBoxTituloCaptura.Text = "TituloCaptura";
            // 
            // labelEixoHorizontalPixel
            // 
            this.labelEixoHorizontalPixel.AutoSize = true;
            this.labelEixoHorizontalPixel.Location = new System.Drawing.Point(121, 169);
            this.labelEixoHorizontalPixel.Name = "labelEixoHorizontalPixel";
            this.labelEixoHorizontalPixel.Size = new System.Drawing.Size(80, 13);
            this.labelEixoHorizontalPixel.TabIndex = 4;
            this.labelEixoHorizontalPixel.Text = "Eixo Horizontal:";
            // 
            // labelEixoVerticalPixel
            // 
            this.labelEixoVerticalPixel.AutoSize = true;
            this.labelEixoVerticalPixel.Location = new System.Drawing.Point(121, 146);
            this.labelEixoVerticalPixel.Name = "labelEixoVerticalPixel";
            this.labelEixoVerticalPixel.Size = new System.Drawing.Size(68, 13);
            this.labelEixoVerticalPixel.TabIndex = 0;
            this.labelEixoVerticalPixel.Text = "Eixo Vertical:";
            // 
            // panelCorPixel
            // 
            this.panelCorPixel.Location = new System.Drawing.Point(400, 21);
            this.panelCorPixel.Name = "panelCorPixel";
            this.panelCorPixel.Size = new System.Drawing.Size(25, 47);
            this.panelCorPixel.TabIndex = 3;
            // 
            // checkBoxCapturadorLigado
            // 
            this.checkBoxCapturadorLigado.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCapturadorLigado.AutoSize = true;
            this.checkBoxCapturadorLigado.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCapturadorLigado.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCapturadorLigado.Location = new System.Drawing.Point(9, 252);
            this.checkBoxCapturadorLigado.Name = "checkBoxCapturadorLigado";
            this.checkBoxCapturadorLigado.Size = new System.Drawing.Size(114, 23);
            this.checkBoxCapturadorLigado.TabIndex = 2;
            this.checkBoxCapturadorLigado.Text = "Capturador de Pixels";
            this.checkBoxCapturadorLigado.UseVisualStyleBackColor = false;
            this.checkBoxCapturadorLigado.CheckedChanged += new System.EventHandler(this.checkBoxCapturadorLigado_CheckedChanged);
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(121, 122);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(55, 13);
            this.labelCor.TabIndex = 1;
            this.labelCor.Text = "Cor (hex) :";
            // 
            // timerHorarioFrances
            // 
            this.timerHorarioFrances.Enabled = true;
            this.timerHorarioFrances.Tick += new System.EventHandler(this.timerHorarioFrances_Tick);
            // 
            // openFileDialogImagemTemplate
            // 
            this.openFileDialogImagemTemplate.FileName = "openFileDialogImagemTemplate";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 498);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.Text = "WakBoy";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.capinacao.ResumeLayout(false);
            this.capinacao.PerformLayout();
            this.groupBoxRecursoSecundario.ResumeLayout(false);
            this.groupBoxRecursoSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaAcao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaRecurso2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaAcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniaturaRecurso)).EndInit();
            this.abaCapturadorPixels.ResumeLayout(false);
            this.abaCapturadorPixels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage capinacao;
        private System.Windows.Forms.TabPage abaCapturadorPixels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCacadorPixelsLigado;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.CheckBox checkBoxCapturadorLigado;
        private System.Windows.Forms.Panel panelCorPixel;
        private System.Windows.Forms.Label labelEixoVerticalPixel;
        private System.Windows.Forms.Label labelEixoHorizontalPixel;
        private System.Windows.Forms.TextBox textBoxTituloCaptura;
        private System.Windows.Forms.CheckBox checkBoxCapturaContinua;
        private System.Windows.Forms.TextBox textBoxLocalizacaoPixelsCapturados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTituloCaptura;
        private System.Windows.Forms.CheckBox checkBoxMostraPixelMovimentoMouse;
        private System.Windows.Forms.Button botaoScreenshot;
        private System.Windows.Forms.TextBox textBoxLocalizacaoScreenshot;
        private System.Windows.Forms.Label labelLuminosidade;
        private System.Windows.Forms.Label labelSaturacao;
        private System.Windows.Forms.Label labelMatiz;
        private System.Windows.Forms.CheckBox checkBoxVisualizarPixel;
        private System.Windows.Forms.TextBox textBoxTransparencia;
        private System.Windows.Forms.Label labelTransparencia;
        private System.Windows.Forms.Label labelHorarioFranca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerHorarioFrances;
        private System.Windows.Forms.ComboBox comboBoxTipoBusca;
        private System.Windows.Forms.Label labelTipoBusca;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagemTemplate;
        private System.Windows.Forms.Label labelObrigatorio;
        private System.Windows.Forms.CheckBox checkBoxMascaraLuminosidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRecurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botaoScreenshotRotacionado;
        private System.Windows.Forms.CheckBox checkBoxAtivarBaixoConsumo;
        private System.Windows.Forms.PictureBox pictureBoxMiniaturaRecurso;
        private System.Windows.Forms.CheckBox checkBoxMovimentarAleatoriamente;
        private System.Windows.Forms.CheckBox checkBoxUtilizarRecursoSecundario;
        private System.Windows.Forms.GroupBox groupBoxRecursoSecundario;
        private System.Windows.Forms.ComboBox comboBoxAcao2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxMiniaturaRecurso2;
        private System.Windows.Forms.ComboBox comboBoxRecurso2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAcao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxMiniaturaAcao2;
        private System.Windows.Forms.PictureBox pictureBoxMiniaturaAcao;
    }
}

