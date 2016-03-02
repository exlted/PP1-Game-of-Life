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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelBackgroundColor = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.livingCellColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.normalGridColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.highlightedGridColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.isGridHighlighted = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(264, 261);
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
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edge Cases";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(256, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grid";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Living Cell";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grid Color";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grid Highlights";
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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}