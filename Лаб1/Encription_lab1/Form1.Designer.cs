namespace Encription_lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDigramm = new System.Windows.Forms.RadioButton();
            this.rbVigener = new System.Windows.Forms.RadioButton();
            this.rbCezar = new System.Windows.Forms.RadioButton();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInitialText = new System.Windows.Forms.TextBox();
            this.tbDecriptionText = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(512, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Расшифрованный текст";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDecrypt);
            this.groupBox2.Controls.Add(this.rbEncrypt);
            this.groupBox2.Location = new System.Drawing.Point(276, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 124);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действие";
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(55, 89);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(97, 17);
            this.rbDecrypt.TabIndex = 14;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Дешифровать";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(55, 35);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(95, 17);
            this.rbEncrypt.TabIndex = 13;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Зашифровать";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDigramm);
            this.groupBox3.Controls.Add(this.rbVigener);
            this.groupBox3.Controls.Add(this.rbCezar);
            this.groupBox3.Location = new System.Drawing.Point(276, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метод";
            // 
            // rbDigramm
            // 
            this.rbDigramm.AutoSize = true;
            this.rbDigramm.Location = new System.Drawing.Point(55, 111);
            this.rbDigramm.Name = "rbDigramm";
            this.rbDigramm.Size = new System.Drawing.Size(122, 17);
            this.rbDigramm.TabIndex = 15;
            this.rbDigramm.TabStop = true;
            this.rbDigramm.Text = "Шифр биграммами";
            this.rbDigramm.UseVisualStyleBackColor = true;
            // 
            // rbVigener
            // 
            this.rbVigener.AutoSize = true;
            this.rbVigener.Location = new System.Drawing.Point(55, 71);
            this.rbVigener.Name = "rbVigener";
            this.rbVigener.Size = new System.Drawing.Size(108, 17);
            this.rbVigener.TabIndex = 14;
            this.rbVigener.TabStop = true;
            this.rbVigener.Text = "Шифр Виженера";
            this.rbVigener.UseVisualStyleBackColor = true;
            // 
            // rbCezar
            // 
            this.rbCezar.AutoSize = true;
            this.rbCezar.Location = new System.Drawing.Point(55, 31);
            this.rbCezar.Name = "rbCezar";
            this.rbCezar.Size = new System.Drawing.Size(95, 17);
            this.rbCezar.TabIndex = 13;
            this.rbCezar.TabStop = true;
            this.rbCezar.Text = "Шифр Цезаря";
            this.rbCezar.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(322, 171);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(104, 30);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Выполнить";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(371, 408);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 20);
            this.tbKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите ключ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tbInitialText
            // 
            this.tbInitialText.Location = new System.Drawing.Point(12, 75);
            this.tbInitialText.Multiline = true;
            this.tbInitialText.Name = "tbInitialText";
            this.tbInitialText.Size = new System.Drawing.Size(256, 303);
            this.tbInitialText.TabIndex = 10;
            // 
            // tbDecriptionText
            // 
            this.tbDecriptionText.Location = new System.Drawing.Point(468, 75);
            this.tbDecriptionText.Multiline = true;
            this.tbDecriptionText.Name = "tbDecriptionText";
            this.tbDecriptionText.Size = new System.Drawing.Size(262, 303);
            this.tbDecriptionText.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbDecriptionText);
            this.Controls.Add(this.tbInitialText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Encription";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox tbInitialText;
        private System.Windows.Forms.TextBox tbDecriptionText;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDigramm;
        private System.Windows.Forms.RadioButton rbVigener;
        private System.Windows.Forms.RadioButton rbCezar;
        private System.Windows.Forms.Button btnClear;
    }
}

