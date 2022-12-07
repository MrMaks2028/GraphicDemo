namespace GraphicDemo
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
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.buttonClearRTB = new System.Windows.Forms.Button();
            this.buttonDrawChess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Location = new System.Drawing.Point(576, 12);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeFont.TabIndex = 0;
            this.buttonChangeFont.Text = "Шрифт";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChangeFont_MouseClick);
            // 
            // buttonClearRTB
            // 
            this.buttonClearRTB.Location = new System.Drawing.Point(576, 58);
            this.buttonClearRTB.Name = "buttonClearRTB";
            this.buttonClearRTB.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRTB.TabIndex = 1;
            this.buttonClearRTB.Text = "Убрать";
            this.buttonClearRTB.UseVisualStyleBackColor = true;
            this.buttonClearRTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClearRTB_MouseClick);
            // 
            // buttonDrawChess
            // 
            this.buttonDrawChess.Location = new System.Drawing.Point(576, 106);
            this.buttonDrawChess.Name = "buttonDrawChess";
            this.buttonDrawChess.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawChess.TabIndex = 2;
            this.buttonDrawChess.Text = "Шахматы";
            this.buttonDrawChess.UseVisualStyleBackColor = true;
            this.buttonDrawChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDrawChess_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 442);
            this.Controls.Add(this.buttonDrawChess);
            this.Controls.Add(this.buttonClearRTB);
            this.Controls.Add(this.buttonChangeFont);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.Button buttonClearRTB;
        private System.Windows.Forms.Button buttonDrawChess;
    }
}

