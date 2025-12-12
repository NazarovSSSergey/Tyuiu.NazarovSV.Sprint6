namespace Tyuiu.NazarovSV.Sprint6.Task7.V3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile = new Button();
            button2 = new Button();
            button4 = new Button();
            toolTipButton = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            openFileDialogMatrix = new OpenFileDialog();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox5 = new GroupBox();
            textBoxReqs = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.ForeColor = SystemColors.ButtonShadow;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(64, 54);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonShadow;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(82, 12);
            button2.Name = "button2";
            button2.Size = new Size(64, 54);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonShadow;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1529, 12);
            button4.Name = "button4";
            button4.Size = new Size(60, 54);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // openFileDialogMatrix
            // 
            openFileDialogMatrix.FileName = "openFileDialog2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(textBoxReqs);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1596, 656);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(splitContainer1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1590, 567);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox5);
            splitContainer1.Size = new Size(1584, 545);
            splitContainer1.SplitterDistance = 528;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1938, 645);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(538, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1043, 514);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(3, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(519, 514);
            textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(3, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1506, 666);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // textBoxReqs
            // 
            textBoxReqs.BackColor = SystemColors.ButtonHighlight;
            textBoxReqs.Dock = DockStyle.Fill;
            textBoxReqs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxReqs.ForeColor = SystemColors.ActiveCaptionText;
            textBoxReqs.Location = new Point(3, 19);
            textBoxReqs.Multiline = true;
            textBoxReqs.Name = "textBoxReqs";
            textBoxReqs.ReadOnly = true;
            textBoxReqs.Size = new Size(1590, 634);
            textBoxReqs.TabIndex = 0;
            textBoxReqs.Text = resources.GetString("textBoxReqs.Text");
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(buttonOpenFile);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1596, 72);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.AppWorkspace;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(152, 12);
            button3.Name = "button3";
            button3.Size = new Size(58, 54);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(6, 19);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1043, 514);
            textBox3.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1596, 728);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 3 | Назаров С. В.";
            Load += this.FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private Button button2;
        private Button button4;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask;
        private OpenFileDialog openFileDialogMatrix;
        private GroupBox groupBox1;
        private TextBox textBoxReqs;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private SplitContainer splitContainer1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}
