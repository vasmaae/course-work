namespace CourseWork
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
            pictureBox = new PictureBox();
            buttonRun = new Button();
            buttonNext = new Button();
            buttonPrevious = new Button();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            groupBoxVisualization = new GroupBox();
            labelCurrentItems = new Label();
            labelItems = new Label();
            groupBoxControl = new GroupBox();
            panelSteps = new Panel();
            groupBoxSteps = new GroupBox();
            labelCurrentStep = new Label();
            labelTotalSteps = new Label();
            groupBoxKnapsack = new GroupBox();
            labelCurrentValue = new Label();
            labelCurrentWeight = new Label();
            labelCapacity = new Label();
            groupBoxStatus = new GroupBox();
            checkBoxShowMessageBox = new CheckBox();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            groupBoxVisualization.SuspendLayout();
            groupBoxControl.SuspendLayout();
            panelSteps.SuspendLayout();
            groupBoxSteps.SuspendLayout();
            groupBoxKnapsack.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 19);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(377, 222);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(6, 22);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(127, 46);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "Задать параметры";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += ButtonRun_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(67, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(60, 46);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Вперёд";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += ButtonNext_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(0, 3);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(60, 46);
            buttonPrevious.TabIndex = 3;
            buttonPrevious.Text = "Назад";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += ButtonPrevious_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, infoToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(554, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 22);
            saveToolStripMenuItem.Text = "Сохранение";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(181, 22);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(65, 20);
            infoToolStripMenuItem.Text = "Справка";
            infoToolStripMenuItem.Click += InfoToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "bin file | *.bin";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "bin file | *.bin";
            // 
            // groupBoxVisualization
            // 
            groupBoxVisualization.Controls.Add(labelCurrentItems);
            groupBoxVisualization.Controls.Add(labelItems);
            groupBoxVisualization.Controls.Add(pictureBox);
            groupBoxVisualization.Enabled = false;
            groupBoxVisualization.Location = new Point(12, 27);
            groupBoxVisualization.Name = "groupBoxVisualization";
            groupBoxVisualization.Size = new Size(383, 244);
            groupBoxVisualization.TabIndex = 5;
            groupBoxVisualization.TabStop = false;
            groupBoxVisualization.Text = "Визуализация";
            // 
            // labelCurrentItems
            // 
            labelCurrentItems.AutoSize = true;
            labelCurrentItems.Location = new Point(190, 22);
            labelCurrentItems.Name = "labelCurrentItems";
            labelCurrentItems.Size = new Size(125, 15);
            labelCurrentItems.TabIndex = 2;
            labelCurrentItems.Text = "Предметы в рюкзаке:";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(6, 22);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(67, 15);
            labelItems.TabIndex = 1;
            labelItems.Text = "Предметы:";
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(panelSteps);
            groupBoxControl.Controls.Add(buttonRun);
            groupBoxControl.Location = new Point(401, 27);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(139, 134);
            groupBoxControl.TabIndex = 6;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "Управление";
            // 
            // panelSteps
            // 
            panelSteps.Controls.Add(buttonPrevious);
            panelSteps.Controls.Add(buttonNext);
            panelSteps.Enabled = false;
            panelSteps.Location = new Point(6, 74);
            panelSteps.Name = "panelSteps";
            panelSteps.Size = new Size(127, 50);
            panelSteps.TabIndex = 4;
            // 
            // groupBoxSteps
            // 
            groupBoxSteps.Controls.Add(labelCurrentStep);
            groupBoxSteps.Controls.Add(labelTotalSteps);
            groupBoxSteps.Enabled = false;
            groupBoxSteps.Location = new Point(324, 277);
            groupBoxSteps.Name = "groupBoxSteps";
            groupBoxSteps.Size = new Size(216, 60);
            groupBoxSteps.TabIndex = 7;
            groupBoxSteps.TabStop = false;
            groupBoxSteps.Text = "Шаги";
            // 
            // labelCurrentStep
            // 
            labelCurrentStep.AutoSize = true;
            labelCurrentStep.Location = new Point(125, 19);
            labelCurrentStep.Name = "labelCurrentStep";
            labelCurrentStep.Size = new Size(84, 15);
            labelCurrentStep.TabIndex = 1;
            labelCurrentStep.Text = "Текущий шаг:\r\n";
            // 
            // labelTotalSteps
            // 
            labelTotalSteps.AutoSize = true;
            labelTotalSteps.Location = new Point(6, 19);
            labelTotalSteps.Name = "labelTotalSteps";
            labelTotalSteps.Size = new Size(113, 15);
            labelTotalSteps.TabIndex = 0;
            labelTotalSteps.Text = "Количество шагов:\r";
            // 
            // groupBoxKnapsack
            // 
            groupBoxKnapsack.Controls.Add(labelCurrentValue);
            groupBoxKnapsack.Controls.Add(labelCurrentWeight);
            groupBoxKnapsack.Controls.Add(labelCapacity);
            groupBoxKnapsack.Enabled = false;
            groupBoxKnapsack.Location = new Point(12, 277);
            groupBoxKnapsack.Name = "groupBoxKnapsack";
            groupBoxKnapsack.Size = new Size(306, 60);
            groupBoxKnapsack.TabIndex = 8;
            groupBoxKnapsack.TabStop = false;
            groupBoxKnapsack.Text = "Рюкзак";
            // 
            // labelCurrentValue
            // 
            labelCurrentValue.AutoSize = true;
            labelCurrentValue.Location = new Point(181, 19);
            labelCurrentValue.Name = "labelCurrentValue";
            labelCurrentValue.Size = new Size(118, 15);
            labelCurrentValue.TabIndex = 2;
            labelCurrentValue.Text = "Текущая стоимость:";
            // 
            // labelCurrentWeight
            // 
            labelCurrentWeight.AutoSize = true;
            labelCurrentWeight.Location = new Point(95, 19);
            labelCurrentWeight.Name = "labelCurrentWeight";
            labelCurrentWeight.Size = new Size(80, 15);
            labelCurrentWeight.TabIndex = 1;
            labelCurrentWeight.Text = "Текущий вес:\r\n";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(6, 19);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(83, 15);
            labelCapacity.TabIndex = 0;
            labelCapacity.Text = "Вместимость:\r\n";
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(checkBoxShowMessageBox);
            groupBoxStatus.Controls.Add(labelStatus);
            groupBoxStatus.Enabled = false;
            groupBoxStatus.Location = new Point(401, 167);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(139, 104);
            groupBoxStatus.TabIndex = 9;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Статус";
            // 
            // checkBoxShowMessageBox
            // 
            checkBoxShowMessageBox.AutoSize = true;
            checkBoxShowMessageBox.Location = new Point(6, 67);
            checkBoxShowMessageBox.Name = "checkBoxShowMessageBox";
            checkBoxShowMessageBox.Size = new Size(96, 34);
            checkBoxShowMessageBox.TabIndex = 1;
            checkBoxShowMessageBox.Text = "Сообщать о \r\nзавершении";
            checkBoxShowMessageBox.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(6, 19);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(46, 15);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Статус:\r\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 348);
            Controls.Add(groupBoxStatus);
            Controls.Add(groupBoxKnapsack);
            Controls.Add(groupBoxSteps);
            Controls.Add(groupBoxControl);
            Controls.Add(groupBoxVisualization);
            Controls.Add(menuStrip);
            Name = "MainForm";
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBoxVisualization.ResumeLayout(false);
            groupBoxVisualization.PerformLayout();
            groupBoxControl.ResumeLayout(false);
            panelSteps.ResumeLayout(false);
            groupBoxSteps.ResumeLayout(false);
            groupBoxSteps.PerformLayout();
            groupBoxKnapsack.ResumeLayout(false);
            groupBoxKnapsack.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonRun;
        private Button buttonNext;
        private Button buttonPrevious;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private GroupBox groupBoxVisualization;
        private GroupBox groupBoxControl;
        private GroupBox groupBoxSteps;
        private Panel panelSteps;
        private Label labelCurrentStep;
        private Label labelTotalSteps;
        private GroupBox groupBoxKnapsack;
        private Label labelCapacity;
        private Label labelCurrentValue;
        private Label labelCurrentWeight;
        private GroupBox groupBoxStatus;
        private Label labelStatus;
        private Label labelItems;
        private Label labelCurrentItems;
        private CheckBox checkBoxShowMessageBox;
    }
}