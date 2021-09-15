namespace RussianToMorse_v2._0
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
            this.tB_RTM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_MTR = new System.Windows.Forms.TextBox();
            this.tB_RTMres = new System.Windows.Forms.TextBox();
            this.tB_MTRres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RTM = new System.Windows.Forms.Button();
            this.btn_MTR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_RTM
            // 
            this.tB_RTM.Location = new System.Drawing.Point(13, 68);
            this.tB_RTM.Multiline = true;
            this.tB_RTM.Name = "tB_RTM";
            this.tB_RTM.Size = new System.Drawing.Size(339, 33);
            this.tB_RTM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Русский в морзе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Морзе в русский";
            // 
            // tB_MTR
            // 
            this.tB_MTR.Location = new System.Drawing.Point(16, 142);
            this.tB_MTR.Multiline = true;
            this.tB_MTR.Name = "tB_MTR";
            this.tB_MTR.Size = new System.Drawing.Size(336, 33);
            this.tB_MTR.TabIndex = 4;
            // 
            // tB_RTMres
            // 
            this.tB_RTMres.Location = new System.Drawing.Point(430, 68);
            this.tB_RTMres.Multiline = true;
            this.tB_RTMres.Name = "tB_RTMres";
            this.tB_RTMres.Size = new System.Drawing.Size(347, 33);
            this.tB_RTMres.TabIndex = 5;
            // 
            // tB_MTRres
            // 
            this.tB_MTRres.Location = new System.Drawing.Point(430, 142);
            this.tB_MTRres.Multiline = true;
            this.tB_MTRres.Name = "tB_MTRres";
            this.tB_MTRres.Size = new System.Drawing.Size(347, 33);
            this.tB_MTRres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            // 
            // btn_RTM
            // 
            this.btn_RTM.Location = new System.Drawing.Point(359, 68);
            this.btn_RTM.Name = "btn_RTM";
            this.btn_RTM.Size = new System.Drawing.Size(65, 33);
            this.btn_RTM.TabIndex = 9;
            this.btn_RTM.Text = "Перевод";
            this.btn_RTM.UseVisualStyleBackColor = true;
            this.btn_RTM.Click += new System.EventHandler(this.btn_RTM_Click);
            // 
            // btn_MTR
            // 
            this.btn_MTR.Location = new System.Drawing.Point(358, 142);
            this.btn_MTR.Name = "btn_MTR";
            this.btn_MTR.Size = new System.Drawing.Size(65, 33);
            this.btn_MTR.TabIndex = 10;
            this.btn_MTR.Text = "Перевод";
            this.btn_MTR.UseVisualStyleBackColor = true;
            this.btn_MTR.Click += new System.EventHandler(this.btn_MTR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 293);
            this.Controls.Add(this.btn_MTR);
            this.Controls.Add(this.btn_RTM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_MTRres);
            this.Controls.Add(this.tB_RTMres);
            this.Controls.Add(this.tB_MTR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_RTM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_RTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_MTR;
        private System.Windows.Forms.TextBox tB_RTMres;
        private System.Windows.Forms.TextBox tB_MTRres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RTM;
        private System.Windows.Forms.Button btn_MTR;
    }
}

