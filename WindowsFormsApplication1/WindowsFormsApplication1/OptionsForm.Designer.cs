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
            this.colorOptions = new System.Windows.Forms.TabPage();
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
            this.gridOptions = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel2Button = new System.Windows.Forms.Button();
            this.reset2Button = new System.Windows.Forms.Button();
            this.accept2Button = new System.Windows.Forms.Button();
            this.colCount = new System.Windows.Forms.NumericUpDown();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.edgeOptions = new System.Windows.Forms.TabPage();
            this.cancel3Button = new System.Windows.Forms.Button();
            this.reset3Button = new System.Windows.Forms.Button();
            this.accept3Button = new System.Windows.Forms.Button();
            this.toriodal = new System.Windows.Forms.RadioButton();
            this.finite = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.TabPage();
            this.timerTicks = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.colorOptions.SuspendLayout();
            this.gridOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            this.edgeOptions.SuspendLayout();
            this.timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerTicks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.colorOptions);
            this.tabControl1.Controls.Add(this.gridOptions);
            this.tabControl1.Controls.Add(this.edgeOptions);
            this.tabControl1.Controls.Add(this.timer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 215);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OptionsForm_KeyPress);
            // 
            // colorOptions
            // 
            this.colorOptions.Controls.Add(this.isGridHighlighted);
            this.colorOptions.Controls.Add(this.label4);
            this.colorOptions.Controls.Add(this.highlightedGridColor);
            this.colorOptions.Controls.Add(this.label3);
            this.colorOptions.Controls.Add(this.normalGridColor);
            this.colorOptions.Controls.Add(this.label2);
            this.colorOptions.Controls.Add(this.livingCellColor);
            this.colorOptions.Controls.Add(this.label1);
            this.colorOptions.Controls.Add(this.panelBackgroundColor);
            this.colorOptions.Controls.Add(this.cancelButton);
            this.colorOptions.Controls.Add(this.resetButton);
            this.colorOptions.Controls.Add(this.acceptButton);
            this.colorOptions.Location = new System.Drawing.Point(4, 25);
            this.colorOptions.Margin = new System.Windows.Forms.Padding(4);
            this.colorOptions.Name = "colorOptions";
            this.colorOptions.Padding = new System.Windows.Forms.Padding(4);
            this.colorOptions.Size = new System.Drawing.Size(344, 186);
            this.colorOptions.TabIndex = 0;
            this.colorOptions.Text = "Color";
            this.colorOptions.UseVisualStyleBackColor = true;
            // 
            // isGridHighlighted
            // 
            this.isGridHighlighted.AutoSize = true;
            this.isGridHighlighted.Location = new System.Drawing.Point(224, 116);
            this.isGridHighlighted.Margin = new System.Windows.Forms.Padding(4);
            this.isGridHighlighted.Name = "isGridHighlighted";
            this.isGridHighlighted.Size = new System.Drawing.Size(82, 21);
            this.isGridHighlighted.TabIndex = 5;
            this.isGridHighlighted.Text = "Enabled";
            this.isGridHighlighted.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grid Highlights";
            // 
            // highlightedGridColor
            // 
            this.highlightedGridColor.BackColor = System.Drawing.Color.Black;
            this.highlightedGridColor.Location = new System.Drawing.Point(119, 114);
            this.highlightedGridColor.Margin = new System.Windows.Forms.Padding(4);
            this.highlightedGridColor.Name = "highlightedGridColor";
            this.highlightedGridColor.Size = new System.Drawing.Size(100, 28);
            this.highlightedGridColor.TabIndex = 4;
            this.highlightedGridColor.UseVisualStyleBackColor = false;
            this.highlightedGridColor.Click += new System.EventHandler(this.panelBackgroundColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grid Color";
            // 
            // normalGridColor
            // 
            this.normalGridColor.BackColor = System.Drawing.Color.Black;
            this.normalGridColor.Location = new System.Drawing.Point(119, 79);
            this.normalGridColor.Margin = new System.Windows.Forms.Padding(4);
            this.normalGridColor.Name = "normalGridColor";
            this.normalGridColor.Size = new System.Drawing.Size(100, 28);
            this.normalGridColor.TabIndex = 3;
            this.normalGridColor.UseVisualStyleBackColor = false;
            this.normalGridColor.Click += new System.EventHandler(this.panelBackgroundColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Living Cell";
            // 
            // livingCellColor
            // 
            this.livingCellColor.BackColor = System.Drawing.Color.Black;
            this.livingCellColor.Location = new System.Drawing.Point(119, 43);
            this.livingCellColor.Margin = new System.Windows.Forms.Padding(4);
            this.livingCellColor.Name = "livingCellColor";
            this.livingCellColor.Size = new System.Drawing.Size(100, 28);
            this.livingCellColor.TabIndex = 2;
            this.livingCellColor.UseVisualStyleBackColor = false;
            this.livingCellColor.Click += new System.EventHandler(this.panelBackgroundColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dead Cell";
            // 
            // panelBackgroundColor
            // 
            this.panelBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panelBackgroundColor.Location = new System.Drawing.Point(119, 7);
            this.panelBackgroundColor.Margin = new System.Windows.Forms.Padding(4);
            this.panelBackgroundColor.Name = "panelBackgroundColor";
            this.panelBackgroundColor.Size = new System.Drawing.Size(100, 28);
            this.panelBackgroundColor.TabIndex = 1;
            this.panelBackgroundColor.UseVisualStyleBackColor = false;
            this.panelBackgroundColor.Click += new System.EventHandler(this.panelBackgroundColor_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(227, 150);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(119, 150);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(11, 150);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(100, 28);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // gridOptions
            // 
            this.gridOptions.Controls.Add(this.label5);
            this.gridOptions.Controls.Add(this.label6);
            this.gridOptions.Controls.Add(this.cancel2Button);
            this.gridOptions.Controls.Add(this.reset2Button);
            this.gridOptions.Controls.Add(this.accept2Button);
            this.gridOptions.Controls.Add(this.colCount);
            this.gridOptions.Controls.Add(this.rowCount);
            this.gridOptions.Location = new System.Drawing.Point(4, 25);
            this.gridOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gridOptions.Name = "gridOptions";
            this.gridOptions.Size = new System.Drawing.Size(344, 186);
            this.gridOptions.TabIndex = 2;
            this.gridOptions.Text = "Grid";
            this.gridOptions.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rows";
            // 
            // cancel2Button
            // 
            this.cancel2Button.Location = new System.Drawing.Point(233, 145);
            this.cancel2Button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel2Button.Name = "cancel2Button";
            this.cancel2Button.Size = new System.Drawing.Size(100, 28);
            this.cancel2Button.TabIndex = 4;
            this.cancel2Button.Text = "Cancel";
            this.cancel2Button.UseVisualStyleBackColor = true;
            this.cancel2Button.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reset2Button
            // 
            this.reset2Button.Location = new System.Drawing.Point(125, 145);
            this.reset2Button.Margin = new System.Windows.Forms.Padding(4);
            this.reset2Button.Name = "reset2Button";
            this.reset2Button.Size = new System.Drawing.Size(100, 28);
            this.reset2Button.TabIndex = 3;
            this.reset2Button.Text = "Reset";
            this.reset2Button.UseVisualStyleBackColor = true;
            this.reset2Button.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // accept2Button
            // 
            this.accept2Button.Location = new System.Drawing.Point(17, 145);
            this.accept2Button.Margin = new System.Windows.Forms.Padding(4);
            this.accept2Button.Name = "accept2Button";
            this.accept2Button.Size = new System.Drawing.Size(100, 28);
            this.accept2Button.TabIndex = 2;
            this.accept2Button.Text = "OK";
            this.accept2Button.UseVisualStyleBackColor = true;
            this.accept2Button.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // colCount
            // 
            this.colCount.Location = new System.Drawing.Point(97, 58);
            this.colCount.Margin = new System.Windows.Forms.Padding(4);
            this.colCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.colCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colCount.Name = "colCount";
            this.colCount.Size = new System.Drawing.Size(160, 22);
            this.colCount.TabIndex = 1;
            this.colCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colCount.Enter += new System.EventHandler(this.rowCount_Enter);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(97, 26);
            this.rowCount.Margin = new System.Windows.Forms.Padding(4);
            this.rowCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.rowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(160, 22);
            this.rowCount.TabIndex = 0;
            this.rowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCount.Enter += new System.EventHandler(this.rowCount_Enter);
            // 
            // edgeOptions
            // 
            this.edgeOptions.Controls.Add(this.cancel3Button);
            this.edgeOptions.Controls.Add(this.reset3Button);
            this.edgeOptions.Controls.Add(this.accept3Button);
            this.edgeOptions.Controls.Add(this.toriodal);
            this.edgeOptions.Controls.Add(this.finite);
            this.edgeOptions.Location = new System.Drawing.Point(4, 25);
            this.edgeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.edgeOptions.Name = "edgeOptions";
            this.edgeOptions.Padding = new System.Windows.Forms.Padding(4);
            this.edgeOptions.Size = new System.Drawing.Size(344, 186);
            this.edgeOptions.TabIndex = 1;
            this.edgeOptions.Text = "Edge Cases";
            this.edgeOptions.UseVisualStyleBackColor = true;
            // 
            // cancel3Button
            // 
            this.cancel3Button.Location = new System.Drawing.Point(232, 145);
            this.cancel3Button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel3Button.Name = "cancel3Button";
            this.cancel3Button.Size = new System.Drawing.Size(100, 28);
            this.cancel3Button.TabIndex = 4;
            this.cancel3Button.Text = "Cancel";
            this.cancel3Button.UseVisualStyleBackColor = true;
            this.cancel3Button.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reset3Button
            // 
            this.reset3Button.Location = new System.Drawing.Point(124, 145);
            this.reset3Button.Margin = new System.Windows.Forms.Padding(4);
            this.reset3Button.Name = "reset3Button";
            this.reset3Button.Size = new System.Drawing.Size(100, 28);
            this.reset3Button.TabIndex = 3;
            this.reset3Button.Text = "Reset";
            this.reset3Button.UseVisualStyleBackColor = true;
            this.reset3Button.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // accept3Button
            // 
            this.accept3Button.Location = new System.Drawing.Point(16, 145);
            this.accept3Button.Margin = new System.Windows.Forms.Padding(4);
            this.accept3Button.Name = "accept3Button";
            this.accept3Button.Size = new System.Drawing.Size(100, 28);
            this.accept3Button.TabIndex = 2;
            this.accept3Button.Text = "OK";
            this.accept3Button.UseVisualStyleBackColor = true;
            this.accept3Button.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // toriodal
            // 
            this.toriodal.AutoSize = true;
            this.toriodal.Location = new System.Drawing.Point(124, 80);
            this.toriodal.Margin = new System.Windows.Forms.Padding(4);
            this.toriodal.Name = "toriodal";
            this.toriodal.Size = new System.Drawing.Size(118, 21);
            this.toriodal.TabIndex = 1;
            this.toriodal.TabStop = true;
            this.toriodal.Text = "ToroidalWorld";
            this.toriodal.UseVisualStyleBackColor = true;
            // 
            // finite
            // 
            this.finite.AutoSize = true;
            this.finite.Location = new System.Drawing.Point(124, 52);
            this.finite.Margin = new System.Windows.Forms.Padding(4);
            this.finite.Name = "finite";
            this.finite.Size = new System.Drawing.Size(100, 21);
            this.finite.TabIndex = 0;
            this.finite.TabStop = true;
            this.finite.Text = "FiniteWorld";
            this.finite.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Controls.Add(this.timerTicks);
            this.timer.Controls.Add(this.button1);
            this.timer.Controls.Add(this.button2);
            this.timer.Controls.Add(this.button3);
            this.timer.Location = new System.Drawing.Point(4, 25);
            this.timer.Margin = new System.Windows.Forms.Padding(4);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(344, 186);
            this.timer.TabIndex = 3;
            this.timer.Text = "Timer";
            this.timer.UseVisualStyleBackColor = true;
            // 
            // timerTicks
            // 
            this.timerTicks.Location = new System.Drawing.Point(85, 71);
            this.timerTicks.Margin = new System.Windows.Forms.Padding(4);
            this.timerTicks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerTicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerTicks.Name = "timerTicks";
            this.timerTicks.Size = new System.Drawing.Size(160, 22);
            this.timerTicks.TabIndex = 0;
            this.timerTicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerTicks.Enter += new System.EventHandler(this.rowCount_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 215);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OptionsForm_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.colorOptions.ResumeLayout(false);
            this.colorOptions.PerformLayout();
            this.gridOptions.ResumeLayout(false);
            this.gridOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            this.edgeOptions.ResumeLayout(false);
            this.edgeOptions.PerformLayout();
            this.timer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timerTicks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage colorOptions;
        private System.Windows.Forms.TabPage edgeOptions;
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
        private System.Windows.Forms.TabPage gridOptions;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown colCount;
        private System.Windows.Forms.NumericUpDown rowCount;
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
        private System.Windows.Forms.TabPage timer;
        private System.Windows.Forms.NumericUpDown timerTicks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}