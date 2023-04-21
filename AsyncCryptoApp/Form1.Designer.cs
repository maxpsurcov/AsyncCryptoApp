namespace AsyncCryptoApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBlowfish = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnWake = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBlowfish
            // 
            this.btnBlowfish.Location = new System.Drawing.Point(120, 115);
            this.btnBlowfish.Name = "btnBlowfish";
            this.btnBlowfish.Size = new System.Drawing.Size(146, 63);
            this.btnBlowfish.TabIndex = 0;
            this.btnBlowfish.Text = "btnBlowfish";
            this.btnBlowfish.UseVisualStyleBackColor = true;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(291, 115);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(146, 63);
            this.btnMD5.TabIndex = 1;
            this.btnMD5.Text = "btnMD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            // 
            // btnWake
            // 
            this.btnWake.Location = new System.Drawing.Point(471, 115);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(146, 63);
            this.btnWake.TabIndex = 2;
            this.btnWake.Text = " btnWake";
            this.btnWake.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(173, 250);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 29);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 476);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnWake);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.btnBlowfish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlowfish;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.TextBox txtResult;
    }
}

