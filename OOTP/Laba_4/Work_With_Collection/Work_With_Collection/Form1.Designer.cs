namespace Work_With_Collection
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GenCollection = new System.Windows.Forms.Button();
            this.SortUp = new System.Windows.Forms.Button();
            this.Request1 = new System.Windows.Forms.Button();
            this.Request2 = new System.Windows.Forms.Button();
            this.Request3 = new System.Windows.Forms.Button();
            this.SortDown = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox1_KeyPress);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(426, 276);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(348, 162);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 162);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // GenCollection
            // 
            this.GenCollection.Location = new System.Drawing.Point(233, 99);
            this.GenCollection.Name = "GenCollection";
            this.GenCollection.Size = new System.Drawing.Size(292, 75);
            this.GenCollection.TabIndex = 2;
            this.GenCollection.Text = "Сгенерировать коллекцию";
            this.GenCollection.UseVisualStyleBackColor = true;
            this.GenCollection.Click += new System.EventHandler(this.GenCollection_Click);
            // 
            // SortUp
            // 
            this.SortUp.Location = new System.Drawing.Point(20, 101);
            this.SortUp.Name = "SortUp";
            this.SortUp.Size = new System.Drawing.Size(133, 72);
            this.SortUp.TabIndex = 3;
            this.SortUp.Text = "Сортировать по возрастанию";
            this.SortUp.UseVisualStyleBackColor = true;
            this.SortUp.Click += new System.EventHandler(this.SortUp_Click);
            // 
            // Request1
            // 
            this.Request1.Location = new System.Drawing.Point(105, 189);
            this.Request1.Name = "Request1";
            this.Request1.Size = new System.Drawing.Size(133, 72);
            this.Request1.TabIndex = 3;
            this.Request1.Text = "Запрос №1";
            this.Request1.UseVisualStyleBackColor = true;
            this.Request1.Click += new System.EventHandler(this.Request1_Click);
            // 
            // Request2
            // 
            this.Request2.Location = new System.Drawing.Point(325, 198);
            this.Request2.Name = "Request2";
            this.Request2.Size = new System.Drawing.Size(133, 72);
            this.Request2.TabIndex = 3;
            this.Request2.Text = "Запрос №2";
            this.Request2.UseVisualStyleBackColor = true;
            this.Request2.Click += new System.EventHandler(this.Request2_Click);
            // 
            // Request3
            // 
            this.Request3.Location = new System.Drawing.Point(588, 189);
            this.Request3.Name = "Request3";
            this.Request3.Size = new System.Drawing.Size(133, 72);
            this.Request3.TabIndex = 3;
            this.Request3.Text = "Запрос №3";
            this.Request3.UseVisualStyleBackColor = true;
            this.Request3.Click += new System.EventHandler(this.Request3_Click);
            // 
            // SortDown
            // 
            this.SortDown.Location = new System.Drawing.Point(641, 99);
            this.SortDown.Name = "SortDown";
            this.SortDown.Size = new System.Drawing.Size(133, 72);
            this.SortDown.TabIndex = 3;
            this.SortDown.Text = "Сортировать по убыванию";
            this.SortDown.UseVisualStyleBackColor = true;
            this.SortDown.Click += new System.EventHandler(this.SortDown_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(315, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 15);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Размер коллекции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SortDown);
            this.Controls.Add(this.Request3);
            this.Controls.Add(this.Request2);
            this.Controls.Add(this.Request1);
            this.Controls.Add(this.SortUp);
            this.Controls.Add(this.GenCollection);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GenCollection;
        private System.Windows.Forms.Button SortUp;
        private System.Windows.Forms.Button Request1;
        private System.Windows.Forms.Button Request2;
        private System.Windows.Forms.Button Request3;
        private System.Windows.Forms.Button SortDown;
        private System.Windows.Forms.TextBox textBox2;
    }
}

