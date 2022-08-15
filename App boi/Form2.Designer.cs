
namespace App_boi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "First number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second number";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(213, 83);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 3;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(213, 175);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 4;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(213, 265);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrement.ForeColor = System.Drawing.Color.Green;
            this.btnIncrement.Location = new System.Drawing.Point(388, 82);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(98, 58);
            this.btnIncrement.TabIndex = 6;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrease.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnIncrease.Location = new System.Drawing.Point(388, 197);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(98, 58);
            this.btnIncrease.TabIndex = 7;
            this.btnIncrease.Text = "* ";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.ForeColor = System.Drawing.Color.Crimson;
            this.btnDivide.Location = new System.Drawing.Point(519, 197);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(99, 58);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDecrement.Location = new System.Drawing.Point(519, 79);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(99, 61);
            this.btnDecrement.TabIndex = 9;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnDivide;
    }
}