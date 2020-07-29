namespace Laba_5
{
    partial class AddCrew
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
            this.Name = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TrackBar();
            this.Position = new System.Windows.Forms.ComboBox();
            this.Expirience = new System.Windows.Forms.NumericUpDown();
            this.Add_New_Crew = new System.Windows.Forms.Button();
            this.End_Add_Crew = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expirience)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.Info;
            this.Name.Location = new System.Drawing.Point(121, 31);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(178, 22);
            this.Name.TabIndex = 0;
            // 
            // SecondName
            // 
            this.SecondName.BackColor = System.Drawing.SystemColors.Info;
            this.SecondName.Location = new System.Drawing.Point(121, 81);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(178, 22);
            this.SecondName.TabIndex = 0;
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.SystemColors.Info;
            this.Age.Location = new System.Drawing.Point(121, 127);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(178, 56);
            this.Age.TabIndex = 1;
            this.Age.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Position
            // 
            this.Position.BackColor = System.Drawing.SystemColors.Info;
            this.Position.FormattingEnabled = true;
            this.Position.Location = new System.Drawing.Point(121, 189);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(178, 24);
            this.Position.TabIndex = 2;
            this.Position.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Expirience
            // 
            this.Expirience.BackColor = System.Drawing.SystemColors.Info;
            this.Expirience.Location = new System.Drawing.Point(121, 241);
            this.Expirience.Name = "Expirience";
            this.Expirience.Size = new System.Drawing.Size(178, 22);
            this.Expirience.TabIndex = 3;
            // 
            // Add_New_Crew
            // 
            this.Add_New_Crew.BackColor = System.Drawing.Color.Lime;
            this.Add_New_Crew.Location = new System.Drawing.Point(153, 290);
            this.Add_New_Crew.Name = "Add_New_Crew";
            this.Add_New_Crew.Size = new System.Drawing.Size(107, 37);
            this.Add_New_Crew.TabIndex = 4;
            this.Add_New_Crew.Text = "Добавить";
            this.Add_New_Crew.UseVisualStyleBackColor = false;
            this.Add_New_Crew.Click += new System.EventHandler(this.Add_New_Crew_Click);
            // 
            // End_Add_Crew
            // 
            this.End_Add_Crew.BackColor = System.Drawing.Color.Red;
            this.End_Add_Crew.Location = new System.Drawing.Point(134, 342);
            this.End_Add_Crew.Name = "End_Add_Crew";
            this.End_Add_Crew.Size = new System.Drawing.Size(146, 50);
            this.End_Add_Crew.TabIndex = 4;
            this.End_Add_Crew.Text = "Завершить";
            this.End_Add_Crew.UseVisualStyleBackColor = false;
            this.End_Add_Crew.Click += new System.EventHandler(this.End_Add_Crew_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 31);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(96, 33);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Имя";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(12, 81);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(96, 33);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Фамилия";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(12, 127);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(96, 33);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Возраст";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(12, 189);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(96, 24);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Должность";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Gray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(12, 240);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(96, 33);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Стаж";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // AddCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.End_Add_Crew);
            this.Controls.Add(this.Add_New_Crew);
            this.Controls.Add(this.Expirience);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.Name);
          
            this.Text = "AddCrew";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expirience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TrackBar Age;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.NumericUpDown Expirience;
        private System.Windows.Forms.Button Add_New_Crew;
        private System.Windows.Forms.Button End_Add_Crew;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
    }
}