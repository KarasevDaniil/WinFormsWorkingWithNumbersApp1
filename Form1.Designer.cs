namespace WinFormsWorkingWithNumbersApp1
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxAnsw = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.erorr_A = new System.Windows.Forms.Label();
            this.erorr_B = new System.Windows.Forms.Label();
            this.erorr_Answ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterForDecomposition = new System.Windows.Forms.TextBox();
            this.primeFactors = new System.Windows.Forms.TextBox();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.erorr_C = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(57, 133);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(144, 30);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "введите число";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxA.Click += new System.EventHandler(this.textBoxA_Click);
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(330, 133);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(144, 30);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Text = "введите число";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxB.Click += new System.EventHandler(this.textBoxB_Click);
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxAnsw
            // 
            this.textBoxAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnsw.Location = new System.Drawing.Point(595, 134);
            this.textBoxAnsw.Name = "textBoxAnsw";
            this.textBoxAnsw.Size = new System.Drawing.Size(100, 30);
            this.textBoxAnsw.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  +",
            "  −",
            "  ×",
            "  ÷"});
            this.comboBox1.Location = new System.Drawing.Point(242, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите два числа, выберите арифметическое действие и узнайте ответ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(519, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer.Location = new System.Drawing.Point(556, 189);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(182, 34);
            this.buttonAnswer.TabIndex = 7;
            this.buttonAnswer.Text = "Получить ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // erorr_A
            // 
            this.erorr_A.AutoSize = true;
            this.erorr_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorr_A.ForeColor = System.Drawing.Color.Red;
            this.erorr_A.Location = new System.Drawing.Point(53, 167);
            this.erorr_A.Name = "erorr_A";
            this.erorr_A.Size = new System.Drawing.Size(0, 20);
            this.erorr_A.TabIndex = 8;
            // 
            // erorr_B
            // 
            this.erorr_B.AutoSize = true;
            this.erorr_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorr_B.ForeColor = System.Drawing.Color.Red;
            this.erorr_B.Location = new System.Drawing.Point(326, 167);
            this.erorr_B.Name = "erorr_B";
            this.erorr_B.Size = new System.Drawing.Size(0, 20);
            this.erorr_B.TabIndex = 9;
            // 
            // erorr_Answ
            // 
            this.erorr_Answ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorr_Answ.ForeColor = System.Drawing.Color.Red;
            this.erorr_Answ.Location = new System.Drawing.Point(522, 238);
            this.erorr_Answ.Name = "erorr_Answ";
            this.erorr_Answ.Size = new System.Drawing.Size(255, 64);
            this.erorr_Answ.TabIndex = 10;
            this.erorr_Answ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Разложить число на простые множители";
            // 
            // EnterForDecomposition
            // 
            this.EnterForDecomposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterForDecomposition.Location = new System.Drawing.Point(57, 372);
            this.EnterForDecomposition.Name = "EnterForDecomposition";
            this.EnterForDecomposition.Size = new System.Drawing.Size(144, 30);
            this.EnterForDecomposition.TabIndex = 12;
            this.EnterForDecomposition.Text = "введите число";
            this.EnterForDecomposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterForDecomposition.Click += new System.EventHandler(this.EnterForDecomposition_Click);
            this.EnterForDecomposition.TextChanged += new System.EventHandler(this.EnterForDecomposition_TextChanged);
            // 
            // primeFactors
            // 
            this.primeFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primeFactors.Location = new System.Drawing.Point(556, 365);
            this.primeFactors.Multiline = true;
            this.primeFactors.Name = "primeFactors";
            this.primeFactors.Size = new System.Drawing.Size(182, 51);
            this.primeFactors.TabIndex = 13;
            this.primeFactors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer2.Location = new System.Drawing.Point(556, 434);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(182, 34);
            this.buttonAnswer2.TabIndex = 14;
            this.buttonAnswer2.Text = "Получить ответ";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // erorr_C
            // 
            this.erorr_C.AutoSize = true;
            this.erorr_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorr_C.ForeColor = System.Drawing.Color.Red;
            this.erorr_C.Location = new System.Drawing.Point(53, 421);
            this.erorr_C.Name = "erorr_C";
            this.erorr_C.Size = new System.Drawing.Size(0, 20);
            this.erorr_C.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 484);
            this.Controls.Add(this.erorr_C);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.primeFactors);
            this.Controls.Add(this.EnterForDecomposition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.erorr_Answ);
            this.Controls.Add(this.erorr_B);
            this.Controls.Add(this.erorr_A);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxAnsw);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Работа с числами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxAnsw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label erorr_A;
        private System.Windows.Forms.Label erorr_B;
        private System.Windows.Forms.Label erorr_Answ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterForDecomposition;
        private System.Windows.Forms.TextBox primeFactors;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Label erorr_C;
    }
}

