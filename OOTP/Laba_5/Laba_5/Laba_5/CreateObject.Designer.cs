namespace Laba_5
{
    partial class CreateObject
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Create_object = new System.Windows.Forms.Button();
            this.Save_object = new System.Windows.Forms.Button();
            this.Output_object = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(78, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 194);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(431, 244);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(307, 194);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // Create_object
            // 
            this.Create_object.Location = new System.Drawing.Point(330, 96);
            this.Create_object.Name = "Create_object";
            this.Create_object.Size = new System.Drawing.Size(143, 55);
            this.Create_object.TabIndex = 1;
            this.Create_object.Text = "Создать объект";
            this.Create_object.UseVisualStyleBackColor = true;
            this.Create_object.Click += new System.EventHandler(this.Create_object_Click);
            // 
            // Save_object
            // 
            this.Save_object.Location = new System.Drawing.Point(114, 26);
            this.Save_object.Name = "Save_object";
            this.Save_object.Size = new System.Drawing.Size(143, 55);
            this.Save_object.TabIndex = 1;
            this.Save_object.Text = "Сохранить объект";
            this.Save_object.UseVisualStyleBackColor = true;
            this.Save_object.Click += new System.EventHandler(this.Save_object_Click);
            // 
            // Output_object
            // 
            this.Output_object.Location = new System.Drawing.Point(528, 26);
            this.Output_object.Name = "Output_object";
            this.Output_object.Size = new System.Drawing.Size(143, 55);
            this.Output_object.TabIndex = 1;
            this.Output_object.Text = "Вывести объект";
            this.Output_object.UseVisualStyleBackColor = true;
            this.Output_object.Click += new System.EventHandler(this.Output_object_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(129, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Описание самолета";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(485, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Описание экипажа";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save_object);
            this.Controls.Add(this.Output_object);
            this.Controls.Add(this.Create_object);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CreateObject";
            this.Text = "CreateObject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Create_object;
        private System.Windows.Forms.Button Save_object;
        private System.Windows.Forms.Button Output_object;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}