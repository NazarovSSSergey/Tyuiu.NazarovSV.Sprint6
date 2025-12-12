namespace Tyuiu.NazarovSV.Sprint6.Task4.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxУСЛО = new GroupBox();
            textBox1 = new TextBox();
            groupBoxInput = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStopStep = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStartStep = new TextBox();
            buttonStart = new Button();
            buttonSave = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxУСЛО.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxStart.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxУСЛО
            // 
            groupBoxУСЛО.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxУСЛО.BackColor = SystemColors.ActiveCaption;
            groupBoxУСЛО.Controls.Add(textBox1);
            groupBoxУСЛО.Location = new Point(12, 12);
            groupBoxУСЛО.Name = "groupBoxУСЛО";
            groupBoxУСЛО.Size = new Size(417, 87);
            groupBoxУСЛО.TabIndex = 0;
            groupBoxУСЛО.TabStop = false;
            groupBoxУСЛО.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ImeMode = ImeMode.On;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(332, 58);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию F(x) на заданнои диапазоне от -5 до 5. Реузльтат вывести в textBox, построить график функции....";
            // 
            // groupBoxInput
            // 
            groupBoxInput.BackColor = SystemColors.ActiveCaption;
            groupBoxInput.Controls.Add(groupBoxStop);
            groupBoxInput.Controls.Add(groupBoxStart);
            groupBoxInput.Location = new Point(451, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(337, 87);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStopStep);
            groupBoxStop.Location = new Point(143, 22);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(131, 49);
            groupBoxStop.TabIndex = 1;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.BackColor = SystemColors.ButtonHighlight;
            textBoxStopStep.Location = new Point(6, 20);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(100, 23);
            textBoxStopStep.TabIndex = 1;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStartStep);
            groupBoxStart.Location = new Point(6, 22);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(131, 49);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.BackColor = SystemColors.ButtonHighlight;
            textBoxStartStep.Location = new Point(6, 20);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(100, 23);
            textBoxStartStep.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.LightSteelBlue;
            buttonStart.ForeColor = Color.Black;
            buttonStart.Location = new Point(809, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(137, 87);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Выполнить";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightSteelBlue;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(952, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 87);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(1088, 12);
            button1.Name = "button1";
            button1.Size = new Size(124, 87);
            button1.TabIndex = 4;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 562);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(401, 530);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1266, 679);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(buttonSave);
            Controls.Add(buttonStart);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxУСЛО);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Назаров Сергей СМАРТб-25-1";
            groupBoxУСЛО.ResumeLayout(false);
            groupBoxУСЛО.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxУСЛО;
        private TextBox textBox1;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxStop;
        private TextBox textBoxStopStep;
        private GroupBox groupBoxStart;
        private TextBox textBoxStartStep;
        private Button buttonStart;
        private Button buttonSave;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBoxResult;
    }
}
