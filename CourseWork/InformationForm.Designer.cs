namespace CourseWork
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            groupBoxDescription = new GroupBox();
            textBoxDescription = new TextBox();
            groupBoxUsing = new GroupBox();
            textBoxUsing = new TextBox();
            groupBoxAlgorithm = new GroupBox();
            textBoxAlgorithm = new TextBox();
            groupBoxDescription.SuspendLayout();
            groupBoxUsing.SuspendLayout();
            groupBoxAlgorithm.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDescription
            // 
            groupBoxDescription.Controls.Add(textBoxDescription);
            groupBoxDescription.Dock = DockStyle.Left;
            groupBoxDescription.Location = new Point(0, 0);
            groupBoxDescription.Name = "groupBoxDescription";
            groupBoxDescription.Size = new Size(200, 216);
            groupBoxDescription.TabIndex = 0;
            groupBoxDescription.TabStop = false;
            groupBoxDescription.Text = "Описание";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(3, 19);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(194, 194);
            textBoxDescription.TabIndex = 0;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // groupBoxUsing
            // 
            groupBoxUsing.Controls.Add(textBoxUsing);
            groupBoxUsing.Dock = DockStyle.Right;
            groupBoxUsing.Location = new Point(401, 0);
            groupBoxUsing.Name = "groupBoxUsing";
            groupBoxUsing.Size = new Size(200, 216);
            groupBoxUsing.TabIndex = 1;
            groupBoxUsing.TabStop = false;
            groupBoxUsing.Text = "Использование";
            // 
            // textBoxUsing
            // 
            textBoxUsing.Dock = DockStyle.Fill;
            textBoxUsing.Location = new Point(3, 19);
            textBoxUsing.Multiline = true;
            textBoxUsing.Name = "textBoxUsing";
            textBoxUsing.ReadOnly = true;
            textBoxUsing.Size = new Size(194, 194);
            textBoxUsing.TabIndex = 1;
            textBoxUsing.TabStop = false;
            textBoxUsing.Text = resources.GetString("textBoxUsing.Text");
            // 
            // groupBoxAlgorithm
            // 
            groupBoxAlgorithm.Controls.Add(textBoxAlgorithm);
            groupBoxAlgorithm.Dock = DockStyle.Fill;
            groupBoxAlgorithm.Location = new Point(200, 0);
            groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            groupBoxAlgorithm.Size = new Size(201, 216);
            groupBoxAlgorithm.TabIndex = 2;
            groupBoxAlgorithm.TabStop = false;
            groupBoxAlgorithm.Text = "Алгоритм";
            // 
            // textBoxAlgorithm
            // 
            textBoxAlgorithm.Dock = DockStyle.Fill;
            textBoxAlgorithm.Location = new Point(3, 19);
            textBoxAlgorithm.Multiline = true;
            textBoxAlgorithm.Name = "textBoxAlgorithm";
            textBoxAlgorithm.ReadOnly = true;
            textBoxAlgorithm.Size = new Size(195, 194);
            textBoxAlgorithm.TabIndex = 1;
            textBoxAlgorithm.TabStop = false;
            textBoxAlgorithm.Text = resources.GetString("textBoxAlgorithm.Text");
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 216);
            Controls.Add(groupBoxAlgorithm);
            Controls.Add(groupBoxUsing);
            Controls.Add(groupBoxDescription);
            Name = "InformationForm";
            Text = "Информация";
            groupBoxDescription.ResumeLayout(false);
            groupBoxDescription.PerformLayout();
            groupBoxUsing.ResumeLayout(false);
            groupBoxUsing.PerformLayout();
            groupBoxAlgorithm.ResumeLayout(false);
            groupBoxAlgorithm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDescription;
        private GroupBox groupBoxUsing;
        private TextBox textBoxUsing;
        private GroupBox groupBoxAlgorithm;
        private TextBox textBoxAlgorithm;
        private TextBox textBoxDescription;
    }
}