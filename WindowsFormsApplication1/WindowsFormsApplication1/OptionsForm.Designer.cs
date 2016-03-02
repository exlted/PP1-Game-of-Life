namespace WindowsFormsApplication1
{
    partial class OptionsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isGridHighlighted = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.highlightedGridColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.normalGridColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.livingCellColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackgroundColor = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel2Button = new System.Windows.Forms.Button();
            this.reset2Button = new System.Windows.Forms.Button();
            this.accept2Button = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancel3Button = new System.Windows.Forms.Button();
            this.reset3Button = new System.Windows.Forms.Button();
            this.accept3Button = new System.Windows.Forms.Button();
            this.toriodal = new System.Windows.Forms.RadioButton();
            this.finite = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 175);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isGridHighlighted);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.highlightedGridColor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.normalGridColor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.livingCellColor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panelBackgroundColor);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.resetButton);
            this.tabPage1.Controls.Add(this.acceptButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isGridHighlighted
            // 
            this.isGridHighlighted.AutoSize = true;
            this.isGridHighlighted.Location = new System.Drawing.Point(168, 94);
            this.isGridHighlighted.Name = "isGridHighlighted";
            this.isGridHighlighted.Size = new System.Drawing.Size(65, 17);
            this.isGridHighlighted.TabIndex = 11;
            this.isGridHighlighted.Text = "Enabled";
            this.isGridHighlighted.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grid Highlights";
            // 
            // highlightedGridColor
            // 
            this.highlightedGridColor.BackColor = System.Drawing.Color.Black;
            this.highlightedGridColor.Location = new System.Drawing.Point(89, 93);
            this.highlightedGridColor.Name = "highlightedGridColor";
            this.highlightedGridColor.Size = new System.Drawing.Size(75, 23);
            this.highlightedGridColor.TabIndex = 9;
            this.highlightedGridColor.Text = "button7";
            this.highlightedGridColor.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grid Color";
            // 
            // normalGridColor
            // 
            this.normalGridColor.BackColor = System.Drawing.Color.Black;
            this.normalGridColor.Location = new System.Drawing.Point(89, 64);
            this.normalGridColor.Name = "normalGridColor";
            this.normalGridColor.Size = new System.Drawing.Size(75, 23);
            this.normalGridColor.TabIndex = 7;
            this.normalGridColor.Text = "button6";
            this.normalGridColor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Living Cell";
            // 
            // livingCellColor
            // 
            this.livingCellColor.BackColor = System.Drawing.Color.Black;
            this.livingCellColor.Location = new System.Drawing.Point(89, 35);
            this.livingCellColor.Name = "livingCellColor";
            this.livingCellColor.Size = new System.Drawing.Size(75, 23);
            this.livingCellColor.TabIndex = 5;
            this.livingCellColor.Text = "button5";
            this.livingCellColor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dead Cell";
            // 
            // panelBackgroundColor
            // 
            this.panelBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panelBackgroundColor.Location = new System.Drawing.Point(89, 6);
            this.panelBackgroundColor.Name = "panelBackgroundColor";
            this.panelBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.panelBackgroundColor.TabIndex = 3;
            this.panelBackgroundColor.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(170, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(89, 122);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(8, 122);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cancel2Button);
            this.tabPage3.Controls.Add(this.reset2Button);
            this.tabPage3.Controls.Add(this.accept2Button);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(256, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rows";
            // 
            // cancel2Button
            // 
            this.cancel2Button.Location = new System.Drawing.Point(175, 118);
            this.cancel2Button.Name = "cancel2Button";
            this.cancel2Button.Size = new System.Drawing.Size(75, 23);
            this.cancel2Button.TabIndex = 9;
            this.cancel2Button.Text = "Cancel";
            this.cancel2Button.UseVisualStyleBackColor = true;
            // 
            // reset2Button
            // 
            this.reset2Button.Location = new System.Drawing.Point(94, 118);
            this.reset2Button.Name = "reset2Button";
            this.reset2Button.Size = new System.Drawing.Size(75, 23);
            this.reset2Button.TabIndex = 8;
            this.reset2Button.Text = "Reset";
            this.reset2Button.UseVisualStyleBackColor = true;
            // 
            // accept2Button
            // 
            this.accept2Button.Location = new System.Drawing.Point(13, 118);
            this.accept2Button.Name = "accept2Button";
            this.accept2Button.Size = new System.Drawing.Size(75, 23);
            this.accept2Button.TabIndex = 7;
            this.accept2Button.Text = "OK";
            this.accept2Button.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(73, 47);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cancel3Button);
            this.tabPage2.Controls.Add(this.reset3Button);
            this.tabPage2.Controls.Add(this.accept3Button);
            this.tabPage2.Controls.Add(this.toriodal);
            this.tabPage2.Controls.Add(this.finite);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edge Cases";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancel3Button
            // 
            this.cancel3Button.Location = new System.Drawing.Point(174, 118);
            this.cancel3Button.Name = "cancel3Button";
            this.cancel3Button.Size = new System.Drawing.Size(75, 23);
            this.cancel3Button.TabIndex = 12;
            this.cancel3Button.Text = "Cancel";
            this.cancel3Button.UseVisualStyleBackColor = true;
            // 
            // reset3Button
            // 
            this.reset3Button.Location = new System.Drawing.Point(93, 118);
            this.reset3Button.Name = "reset3Button";
            this.reset3Button.Size = new System.Drawing.Size(75, 23);
            this.reset3Button.TabIndex = 11;
            this.reset3Button.Text = "Reset";
            this.reset3Button.UseVisualStyleBackColor = true;
            // 
            // accept3Button
            // 
            this.accept3Button.Location = new System.Drawing.Point(12, 118);
            this.accept3Button.Name = "accept3Button";
            this.accept3Button.Size = new System.Drawing.Size(75, 23);
            this.accept3Button.TabIndex = 10;
            this.accept3Button.Text = "OK";
            this.accept3Button.UseVisualStyleBackColor = true;
            // 
            // toriodal
            // 
            this.toriodal.AutoSize = true;
            this.toriodal.Location = new System.Drawing.Point(93, 65);
            this.toriodal.Name = "toriodal";
            this.toriodal.Size = new System.Drawing.Size(91, 17);
            this.toriodal.TabIndex = 2;
            this.toriodal.TabStop = true;
            this.toriodal.Text = "ToroidalWorld";
            this.toriodal.UseVisualStyleBackColor = true;
            // 
            // finite
            // 
            this.finite.AutoSize = true;
            this.finite.Location = new System.Drawing.Point(93, 42);
            this.finite.Name = "finite";
            this.finite.Size = new System.Drawing.Size(78, 17);
            this.finite.TabIndex = 0;
            this.finite.TabStop = true;
            this.finite.Text = "FiniteWorld";
            this.finite.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 175);
            this.Controls.Add(this.tabControl1);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox isGridHighlighted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button highlightedGridColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button normalGridColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button livingCellColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button panelBackgroundColor;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton toriodal;
        private System.Windows.Forms.RadioButton finite;
        private System.Windows.Forms.Button accept2Button;
        private System.Windows.Forms.Button reset2Button;
        private System.Windows.Forms.Button cancel2Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel3Button;
        private System.Windows.Forms.Button reset3Button;
        private System.Windows.Forms.Button accept3Button;
    }
}