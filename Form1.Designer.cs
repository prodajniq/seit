namespace пр12
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.числитель1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.знаменатель1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxNumerator = new System.Windows.Forms.TextBox();
            this.textBoxDenominator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wholePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числитель2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.знаменатель2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "добавление дробей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddFraction_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "проверка неправильных дробей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonProcessFractions_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "сортировка списков";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonSortDescending_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.числитель1,
            this.знаменатель1});
            this.dataGridView1.Location = new System.Drawing.Point(56, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // числитель1
            // 
            this.числитель1.HeaderText = "числитель";
            this.числитель1.Name = "числитель1";
            // 
            // знаменатель1
            // 
            this.знаменатель1.HeaderText = "знаменатль";
            this.знаменатель1.Name = "знаменатель1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wholePart,
            this.числитель2,
            this.знаменатель2});
            this.dataGridView2.Location = new System.Drawing.Point(348, 290);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(347, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // textBoxNumerator
            // 
            this.textBoxNumerator.Location = new System.Drawing.Point(61, 99);
            this.textBoxNumerator.Name = "textBoxNumerator";
            this.textBoxNumerator.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerator.TabIndex = 5;
            // 
            // textBoxDenominator
            // 
            this.textBoxDenominator.Location = new System.Drawing.Point(167, 99);
            this.textBoxDenominator.Name = "textBoxDenominator";
            this.textBoxDenominator.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominator.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "числитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "знаменатель";
            // 
            // wholePart
            // 
            this.wholePart.HeaderText = "целая часть";
            this.wholePart.Name = "wholePart";
            // 
            // числитель2
            // 
            this.числитель2.HeaderText = "числитель";
            this.числитель2.Name = "числитель2";
            // 
            // знаменатель2
            // 
            this.знаменатель2.HeaderText = "знаменатель";
            this.знаменатель2.Name = "знаменатель2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDenominator);
            this.Controls.Add(this.textBoxNumerator);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxNumerator;
        private System.Windows.Forms.TextBox textBoxDenominator;
        private System.Windows.Forms.DataGridViewTextBoxColumn числитель1;
        private System.Windows.Forms.DataGridViewTextBoxColumn знаменатель1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn числитель2;
        private System.Windows.Forms.DataGridViewTextBoxColumn знаменатель2;
    }
}

