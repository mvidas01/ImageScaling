
namespace ImageScalling
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loadInputButton = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.inputShowButton = new System.Windows.Forms.Button();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.inputUp = new System.Windows.Forms.Panel();
            this.inputDown = new System.Windows.Forms.Panel();
            this.outputShowButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.interpolationSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heightInterpolation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.widthInterpolation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proportionsInterpolation = new System.Windows.Forms.CheckBox();
            this.upscalingSizeInterpolation = new System.Windows.Forms.TextBox();
            this.typeInterpolation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.superResolutionSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.superResolutionMethod = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.saveAllButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.saveInput = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.saveOutput = new System.Windows.Forms.Button();
            this.outputImageBox = new ImageScalling.InterpolationPictureBox();
            this.inputImageBox = new ImageScalling.InterpolationPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.interpolationSettings.SuspendLayout();
            this.superResolutionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadInputButton
            // 
            this.loadInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadInputButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadInputButton.ForeColor = System.Drawing.Color.Navy;
            this.loadInputButton.Location = new System.Drawing.Point(451, 318);
            this.loadInputButton.Name = "loadInputButton";
            this.loadInputButton.Size = new System.Drawing.Size(320, 59);
            this.loadInputButton.TabIndex = 3;
            this.loadInputButton.Text = "Нажмите, чтобы загрузить свое изображение";
            this.loadInputButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadInputButton.Click += new System.EventHandler(this.loadInputButton_Click);
            this.loadInputButton.MouseLeave += new System.EventHandler(this.loadInputButton_MouseLeave);
            this.loadInputButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loadInputButton_MouseMove);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.Location = new System.Drawing.Point(12, 575);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(234, 44);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.clearButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.clearButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // inputShowButton
            // 
            this.inputShowButton.BackColor = System.Drawing.Color.White;
            this.inputShowButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.inputShowButton.FlatAppearance.BorderSize = 0;
            this.inputShowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.inputShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputShowButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputShowButton.ForeColor = System.Drawing.Color.Navy;
            this.inputShowButton.Location = new System.Drawing.Point(744, 701);
            this.inputShowButton.Name = "inputShowButton";
            this.inputShowButton.Size = new System.Drawing.Size(188, 44);
            this.inputShowButton.TabIndex = 5;
            this.inputShowButton.Text = "Просмотр";
            this.inputShowButton.UseVisualStyleBackColor = false;
            this.inputShowButton.Click += new System.EventHandler(this.inputShowButton_Click);
            this.inputShowButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.inputShowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // methodBox
            // 
            this.methodBox.BackColor = System.Drawing.Color.White;
            this.methodBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodBox.ForeColor = System.Drawing.Color.Black;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Интерполяция",
            "Super Resolution"});
            this.methodBox.Location = new System.Drawing.Point(12, 12);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(234, 29);
            this.methodBox.TabIndex = 6;
            this.methodBox.SelectedIndexChanged += new System.EventHandler(this.methodBox_SelectedIndexChanged);
            // 
            // inputUp
            // 
            this.inputUp.BackColor = System.Drawing.Color.Navy;
            this.inputUp.Location = new System.Drawing.Point(262, 10);
            this.inputUp.Name = "inputUp";
            this.inputUp.Size = new System.Drawing.Size(670, 5);
            this.inputUp.TabIndex = 7;
            this.inputUp.Visible = false;
            // 
            // inputDown
            // 
            this.inputDown.BackColor = System.Drawing.Color.Navy;
            this.inputDown.Location = new System.Drawing.Point(262, 680);
            this.inputDown.Name = "inputDown";
            this.inputDown.Size = new System.Drawing.Size(670, 5);
            this.inputDown.TabIndex = 8;
            this.inputDown.Visible = false;
            // 
            // outputShowButton
            // 
            this.outputShowButton.BackColor = System.Drawing.Color.White;
            this.outputShowButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.outputShowButton.FlatAppearance.BorderSize = 0;
            this.outputShowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.outputShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputShowButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputShowButton.ForeColor = System.Drawing.Color.Navy;
            this.outputShowButton.Location = new System.Drawing.Point(1433, 701);
            this.outputShowButton.Name = "outputShowButton";
            this.outputShowButton.Size = new System.Drawing.Size(188, 44);
            this.outputShowButton.TabIndex = 9;
            this.outputShowButton.Text = "Просмотр";
            this.outputShowButton.UseVisualStyleBackColor = false;
            this.outputShowButton.Click += new System.EventHandler(this.outputShowButton_Click);
            this.outputShowButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.outputShowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(760, 711);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1449, 711);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // interpolationSettings
            // 
            this.interpolationSettings.Controls.Add(this.label4);
            this.interpolationSettings.Controls.Add(this.heightInterpolation);
            this.interpolationSettings.Controls.Add(this.label3);
            this.interpolationSettings.Controls.Add(this.widthInterpolation);
            this.interpolationSettings.Controls.Add(this.label2);
            this.interpolationSettings.Controls.Add(this.proportionsInterpolation);
            this.interpolationSettings.Controls.Add(this.upscalingSizeInterpolation);
            this.interpolationSettings.Controls.Add(this.typeInterpolation);
            this.interpolationSettings.Controls.Add(this.label1);
            this.interpolationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interpolationSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interpolationSettings.ForeColor = System.Drawing.Color.Black;
            this.interpolationSettings.Location = new System.Drawing.Point(12, 47);
            this.interpolationSettings.Name = "interpolationSettings";
            this.interpolationSettings.Size = new System.Drawing.Size(234, 522);
            this.interpolationSettings.TabIndex = 12;
            this.interpolationSettings.TabStop = false;
            this.interpolationSettings.Text = "Свойства";
            this.interpolationSettings.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Высота:";
            // 
            // heightInterpolation
            // 
            this.heightInterpolation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightInterpolation.Location = new System.Drawing.Point(94, 222);
            this.heightInterpolation.Name = "heightInterpolation";
            this.heightInterpolation.Size = new System.Drawing.Size(134, 23);
            this.heightInterpolation.TabIndex = 17;
            this.heightInterpolation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ширина:";
            // 
            // widthInterpolation
            // 
            this.widthInterpolation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthInterpolation.Location = new System.Drawing.Point(94, 183);
            this.widthInterpolation.Name = "widthInterpolation";
            this.widthInterpolation.Size = new System.Drawing.Size(134, 23);
            this.widthInterpolation.TabIndex = 15;
            this.widthInterpolation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Степень увеличения:";
            // 
            // proportionsInterpolation
            // 
            this.proportionsInterpolation.AutoSize = true;
            this.proportionsInterpolation.Checked = true;
            this.proportionsInterpolation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.proportionsInterpolation.Location = new System.Drawing.Point(6, 101);
            this.proportionsInterpolation.Name = "proportionsInterpolation";
            this.proportionsInterpolation.Size = new System.Drawing.Size(215, 25);
            this.proportionsInterpolation.TabIndex = 13;
            this.proportionsInterpolation.Text = "Соблюдать пропорции";
            this.proportionsInterpolation.UseVisualStyleBackColor = true;
            this.proportionsInterpolation.CheckedChanged += new System.EventHandler(this.proportionsInterpolation_CheckedChanged);
            // 
            // upscalingSizeInterpolation
            // 
            this.upscalingSizeInterpolation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upscalingSizeInterpolation.Location = new System.Drawing.Point(184, 143);
            this.upscalingSizeInterpolation.Name = "upscalingSizeInterpolation";
            this.upscalingSizeInterpolation.Size = new System.Drawing.Size(44, 23);
            this.upscalingSizeInterpolation.TabIndex = 13;
            this.upscalingSizeInterpolation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_KeyPress);
            // 
            // typeInterpolation
            // 
            this.typeInterpolation.BackColor = System.Drawing.Color.White;
            this.typeInterpolation.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeInterpolation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeInterpolation.ForeColor = System.Drawing.Color.Black;
            this.typeInterpolation.FormattingEnabled = true;
            this.typeInterpolation.Items.AddRange(new object[] {
            "Бикубическая",
            "Билинейная"});
            this.typeInterpolation.Location = new System.Drawing.Point(6, 58);
            this.typeInterpolation.Name = "typeInterpolation";
            this.typeInterpolation.Size = new System.Drawing.Size(222, 25);
            this.typeInterpolation.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тип интерполяции:";
            // 
            // superResolutionSettings
            // 
            this.superResolutionSettings.Controls.Add(this.label5);
            this.superResolutionSettings.Controls.Add(this.superResolutionMethod);
            this.superResolutionSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superResolutionSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.superResolutionSettings.ForeColor = System.Drawing.Color.Black;
            this.superResolutionSettings.Location = new System.Drawing.Point(12, 47);
            this.superResolutionSettings.Name = "superResolutionSettings";
            this.superResolutionSettings.Size = new System.Drawing.Size(234, 522);
            this.superResolutionSettings.TabIndex = 19;
            this.superResolutionSettings.TabStop = false;
            this.superResolutionSettings.Text = "Свойства";
            this.superResolutionSettings.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Метод Super-Resolution:";
            // 
            // superResolutionMethod
            // 
            this.superResolutionMethod.BackColor = System.Drawing.Color.White;
            this.superResolutionMethod.Cursor = System.Windows.Forms.Cursors.Default;
            this.superResolutionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.superResolutionMethod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.superResolutionMethod.ForeColor = System.Drawing.Color.Black;
            this.superResolutionMethod.FormattingEnabled = true;
            this.superResolutionMethod.Items.AddRange(new object[] {
            "psnr-small",
            "psnr-large",
            "noise-cancel",
            "gans"});
            this.superResolutionMethod.Location = new System.Drawing.Point(6, 58);
            this.superResolutionMethod.Name = "superResolutionMethod";
            this.superResolutionMethod.Size = new System.Drawing.Size(222, 25);
            this.superResolutionMethod.TabIndex = 14;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(12, 701);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(234, 44);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButtonAsync_Click);
            this.startButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.startButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 585);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 711);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.Navy;
            this.loadingLabel.Location = new System.Drawing.Point(1161, 401);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(273, 22);
            this.loadingLabel.TabIndex = 23;
            this.loadingLabel.Text = "Подождите, идет загрузка...";
            this.loadingLabel.Visible = false;
            // 
            // loadingBox
            // 
            this.loadingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingBox.Image")));
            this.loadingBox.Location = new System.Drawing.Point(1165, 271);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(262, 127);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox.TabIndex = 24;
            this.loadingBox.TabStop = false;
            this.loadingBox.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 649);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // saveAllButton
            // 
            this.saveAllButton.BackColor = System.Drawing.Color.White;
            this.saveAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.saveAllButton.FlatAppearance.BorderSize = 0;
            this.saveAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAllButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveAllButton.ForeColor = System.Drawing.Color.Navy;
            this.saveAllButton.Location = new System.Drawing.Point(12, 638);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(234, 44);
            this.saveAllButton.TabIndex = 25;
            this.saveAllButton.Text = "Сохранить все";
            this.saveAllButton.UseVisualStyleBackColor = false;
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            this.saveAllButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.saveAllButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(560, 711);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // saveInput
            // 
            this.saveInput.BackColor = System.Drawing.Color.White;
            this.saveInput.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.saveInput.FlatAppearance.BorderSize = 0;
            this.saveInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInput.ForeColor = System.Drawing.Color.Navy;
            this.saveInput.Location = new System.Drawing.Point(550, 701);
            this.saveInput.Name = "saveInput";
            this.saveInput.Size = new System.Drawing.Size(188, 44);
            this.saveInput.TabIndex = 27;
            this.saveInput.Text = "Сохранить";
            this.saveInput.UseVisualStyleBackColor = false;
            this.saveInput.Click += new System.EventHandler(this.saveInput_Click);
            this.saveInput.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.saveInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1248, 711);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // saveOutput
            // 
            this.saveOutput.BackColor = System.Drawing.Color.White;
            this.saveOutput.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.saveOutput.FlatAppearance.BorderSize = 0;
            this.saveOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOutput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveOutput.ForeColor = System.Drawing.Color.Navy;
            this.saveOutput.Location = new System.Drawing.Point(1239, 701);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(188, 44);
            this.saveOutput.TabIndex = 29;
            this.saveOutput.Text = "Сохранить";
            this.saveOutput.UseVisualStyleBackColor = false;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            this.saveOutput.MouseLeave += new System.EventHandler(this.Button_MouseLeave1);
            this.saveOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove1);
            // 
            // outputImageBox
            // 
            this.outputImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.outputImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.outputImageBox.Location = new System.Drawing.Point(956, 12);
            this.outputImageBox.Name = "outputImageBox";
            this.outputImageBox.Size = new System.Drawing.Size(670, 670);
            this.outputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImageBox.TabIndex = 2;
            this.outputImageBox.TabStop = false;
            // 
            // inputImageBox
            // 
            this.inputImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.inputImageBox.Location = new System.Drawing.Point(262, 12);
            this.inputImageBox.Name = "inputImageBox";
            this.inputImageBox.Size = new System.Drawing.Size(670, 670);
            this.inputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImageBox.TabIndex = 1;
            this.inputImageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1638, 757);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.saveOutput);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.saveInput);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.saveAllButton);
            this.Controls.Add(this.loadingBox);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputShowButton);
            this.Controls.Add(this.inputDown);
            this.Controls.Add(this.inputUp);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.inputShowButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadInputButton);
            this.Controls.Add(this.outputImageBox);
            this.Controls.Add(this.inputImageBox);
            this.Controls.Add(this.interpolationSettings);
            this.Controls.Add(this.superResolutionSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ImageScaling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.interpolationSettings.ResumeLayout(false);
            this.interpolationSettings.PerformLayout();
            this.superResolutionSettings.ResumeLayout(false);
            this.superResolutionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InterpolationPictureBox inputImageBox;
        private InterpolationPictureBox outputImageBox;
        private System.Windows.Forms.Label loadInputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button inputShowButton;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Panel inputUp;
        private System.Windows.Forms.Panel inputDown;
        private System.Windows.Forms.Button outputShowButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox interpolationSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightInterpolation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthInterpolation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox proportionsInterpolation;
        private System.Windows.Forms.TextBox upscalingSizeInterpolation;
        private System.Windows.Forms.ComboBox typeInterpolation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox superResolutionSettings;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox superResolutionMethod;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox loadingBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button saveAllButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button saveInput;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button saveOutput;
    }
}

