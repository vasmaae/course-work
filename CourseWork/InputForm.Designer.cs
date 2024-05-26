namespace CourseWork
{
    partial class InputForm
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
            buttonAddItem = new Button();
            buttonSubmit = new Button();
            numericUpDownWeight = new NumericUpDown();
            listBoxItems = new ListBox();
            labelWeight = new Label();
            labelValue = new Label();
            numericUpDownValue = new NumericUpDown();
            labelCapacity = new Label();
            numericUpDownCapacity = new NumericUpDown();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            SuspendLayout();
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(12, 70);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(209, 23);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Добавить предмет";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += ButtonAddItem_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(12, 129);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(209, 23);
            buttonSubmit.TabIndex = 3;
            buttonSubmit.Text = "Принять";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += ButtonSubmit_Click;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(101, 12);
            numericUpDownWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(120, 23);
            numericUpDownWeight.TabIndex = 4;
            numericUpDownWeight.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 15;
            listBoxItems.Location = new Point(227, 12);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(135, 139);
            listBoxItems.TabIndex = 5;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(12, 14);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(29, 15);
            labelWeight.TabIndex = 6;
            labelWeight.Text = "Вес:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(12, 43);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(70, 15);
            labelValue.TabIndex = 8;
            labelValue.Text = "Стоимость:";
            // 
            // numericUpDownValue
            // 
            numericUpDownValue.Location = new Point(101, 41);
            numericUpDownValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownValue.Name = "numericUpDownValue";
            numericUpDownValue.Size = new Size(120, 23);
            numericUpDownValue.TabIndex = 7;
            numericUpDownValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(12, 96);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(83, 30);
            labelCapacity.TabIndex = 10;
            labelCapacity.Text = "Вместимость \r\nрюкзака:";
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.Location = new Point(101, 99);
            numericUpDownCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(120, 23);
            numericUpDownCapacity.TabIndex = 9;
            numericUpDownCapacity.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(12, 158);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(349, 23);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 191);
            Controls.Add(buttonReset);
            Controls.Add(labelCapacity);
            Controls.Add(numericUpDownCapacity);
            Controls.Add(labelValue);
            Controls.Add(numericUpDownValue);
            Controls.Add(labelWeight);
            Controls.Add(listBoxItems);
            Controls.Add(numericUpDownWeight);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonAddItem);
            Name = "InputForm";
            Text = "Форма ввода";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddItem;
        private Button buttonSubmit;
        private NumericUpDown numericUpDownWeight;
        private ListBox listBoxItems;
        private Label labelWeight;
        private Label labelValue;
        private NumericUpDown numericUpDownValue;
        private Label labelCapacity;
        private NumericUpDown numericUpDownCapacity;
        private Button buttonReset;
    }
}