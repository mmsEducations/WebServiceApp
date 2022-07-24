namespace WebServiceAppCalculator.Frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownS1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS2 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMyltiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonExpo = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "say1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "say2";
            // 
            // numericUpDownS1
            // 
            this.numericUpDownS1.Location = new System.Drawing.Point(251, 97);
            this.numericUpDownS1.Name = "numericUpDownS1";
            this.numericUpDownS1.Size = new System.Drawing.Size(279, 27);
            this.numericUpDownS1.TabIndex = 4;
            // 
            // numericUpDownS2
            // 
            this.numericUpDownS2.Location = new System.Drawing.Point(251, 159);
            this.numericUpDownS2.Name = "numericUpDownS2";
            this.numericUpDownS2.Size = new System.Drawing.Size(279, 27);
            this.numericUpDownS2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(169, 221);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(62, 29);
            this.buttonSub.TabIndex = 7;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMyltiply
            // 
            this.buttonMyltiply.Location = new System.Drawing.Point(248, 221);
            this.buttonMyltiply.Name = "buttonMyltiply";
            this.buttonMyltiply.Size = new System.Drawing.Size(52, 29);
            this.buttonMyltiply.TabIndex = 8;
            this.buttonMyltiply.Text = "*";
            this.buttonMyltiply.UseVisualStyleBackColor = true;
            this.buttonMyltiply.Click += new System.EventHandler(this.buttonMyltiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(315, 221);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 29);
            this.buttonDivide.TabIndex = 9;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonExpo
            // 
            this.buttonExpo.Location = new System.Drawing.Point(391, 221);
            this.buttonExpo.Name = "buttonExpo";
            this.buttonExpo.Size = new System.Drawing.Size(60, 29);
            this.buttonExpo.TabIndex = 10;
            this.buttonExpo.Text = "Expo";
            this.buttonExpo.UseVisualStyleBackColor = true;
            this.buttonExpo.Click += new System.EventHandler(this.buttonExpo_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(470, 221);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(60, 29);
            this.buttonMax.TabIndex = 11;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(551, 221);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(60, 29);
            this.buttonMin.TabIndex = 12;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 481);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonExpo);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMyltiply);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDownS2);
            this.Controls.Add(this.numericUpDownS1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownS1;
        private NumericUpDown numericUpDownS2;
        private Button btnAdd;
        private Button buttonSub;
        private Button buttonMyltiply;
        private Button buttonDivide;
        private Button buttonExpo;
        private Button buttonMax;
        private Button buttonMin;
    }
}