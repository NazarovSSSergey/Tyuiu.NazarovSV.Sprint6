namespace Tyuiu.NazarovSV.Sprint6.Task7.V3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            groupBox2 = new GroupBox();
            splitContainer1 = new SplitContainer();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            textBox1 = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            openFileDialogMatrix = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHelp);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonDone);
            groupBox1.Controls.Add(buttonOpenFile);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = SystemColors.ButtonHighlight;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(1102, 22);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(61, 62);
            buttonHelp.TabIndex = 3;
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonHighlight;
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(146, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(61, 62);
            buttonSave.TabIndex = 2;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ButtonHighlight;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(79, 22);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(61, 62);
            buttonDone.TabIndex = 1;
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.ButtonHighlight;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 22);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(61, 62);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1175, 636);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 110);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewIn);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewOut);
            splitContainer1.Size = new Size(1169, 523);
            splitContainer1.SplitterDistance = 631;
            splitContainer1.TabIndex = 5;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(2, 0);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.Size = new Size(627, 538);
            dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(0, 0);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.Size = new Size(531, 541);
            dataGridViewOut.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1169, 91);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            // 
            // openFileDialogMatrix
            // 
            openFileDialogMatrix.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 736);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonOpenFile;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogMatrix;
        private SplitContainer splitContainer1;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
