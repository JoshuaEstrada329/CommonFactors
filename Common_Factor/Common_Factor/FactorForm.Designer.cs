namespace Common_Factor
{
    partial class FactorForm
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1TxtBx = new System.Windows.Forms.TextBox();
            this.num2TxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grcLb = new System.Windows.Forms.Label();
            this.lcbLb = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(15, 309);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(114, 49);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate Common Factors";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(288, 310);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(114, 48);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2:";
            // 
            // num1TxtBx
            // 
            this.num1TxtBx.Location = new System.Drawing.Point(75, 37);
            this.num1TxtBx.Name = "num1TxtBx";
            this.num1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.num1TxtBx.TabIndex = 4;
            // 
            // num2TxtBx
            // 
            this.num2TxtBx.Location = new System.Drawing.Point(75, 93);
            this.num2TxtBx.Name = "num2TxtBx";
            this.num2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.num2TxtBx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Greatest Common Factor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Least Common Factor: ";
            // 
            // grcLb
            // 
            this.grcLb.AutoSize = true;
            this.grcLb.Location = new System.Drawing.Point(152, 171);
            this.grcLb.Name = "grcLb";
            this.grcLb.Size = new System.Drawing.Size(35, 13);
            this.grcLb.TabIndex = 8;
            this.grcLb.Text = "label5";
            // 
            // lcbLb
            // 
            this.lcbLb.AutoSize = true;
            this.lcbLb.Location = new System.Drawing.Point(152, 230);
            this.lcbLb.Name = "lcbLb";
            this.lcbLb.Size = new System.Drawing.Size(35, 13);
            this.lcbLb.TabIndex = 9;
            this.lcbLb.Text = "label5";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(152, 309);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(114, 48);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // FactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 383);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.lcbLb);
            this.Controls.Add(this.grcLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2TxtBx);
            this.Controls.Add(this.num1TxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FactorForm";
            this.Text = "Factor Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1TxtBx;
        private System.Windows.Forms.TextBox num2TxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grcLb;
        private System.Windows.Forms.Label lcbLb;
        private System.Windows.Forms.Button clearBtn;
    }
}

