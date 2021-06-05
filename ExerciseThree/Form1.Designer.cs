
namespace ExerciseThree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodicityTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfCopiesTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountCopiesTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PeriodicityPlace = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinishTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicityPlace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTxt,
            this.PeriodicityTxt,
            this.PriceTxt,
            this.CostOfCopiesTxt,
            this.CountCopiesTxt});
            this.dataGridView1.Location = new System.Drawing.Point(242, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(546, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.HeaderText = "Название";
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            // 
            // PeriodicityTxt
            // 
            this.PeriodicityTxt.HeaderText = "Периодичность";
            this.PeriodicityTxt.Name = "PeriodicityTxt";
            this.PeriodicityTxt.ReadOnly = true;
            // 
            // PriceTxt
            // 
            this.PriceTxt.HeaderText = "Цена за 1 шт.";
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.ReadOnly = true;
            // 
            // CostOfCopiesTxt
            // 
            this.CostOfCopiesTxt.HeaderText = "Стоимость подписки";
            this.CostOfCopiesTxt.Name = "CostOfCopiesTxt";
            this.CostOfCopiesTxt.ReadOnly = true;
            // 
            // CountCopiesTxt
            // 
            this.CountCopiesTxt.HeaderText = "Количество экземпляров";
            this.CountCopiesTxt.Name = "CountCopiesTxt";
            this.CountCopiesTxt.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывод всех";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сортировка по убыванию цены подписки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сортировка по возрастанию цены подписки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отбор по периодичности";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Периодичность: ";
            // 
            // PeriodicityPlace
            // 
            this.PeriodicityPlace.Location = new System.Drawing.Point(118, 490);
            this.PeriodicityPlace.Name = "PeriodicityPlace";
            this.PeriodicityPlace.Size = new System.Drawing.Size(101, 23);
            this.PeriodicityPlace.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(12, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 62);
            this.button5.TabIndex = 7;
            this.button5.Text = "Вывод в файл";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FinishTime);
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подписка";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 31);
            this.button6.TabIndex = 4;
            this.button6.Text = "Установить значение";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "C";
            // 
            // FinishTime
            // 
            this.FinishTime.Location = new System.Drawing.Point(54, 52);
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.Size = new System.Drawing.Size(153, 23);
            this.FinishTime.TabIndex = 1;
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(54, 23);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(153, 23);
            this.StartTime.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PeriodicityPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicityPlace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodicityTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfCopiesTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCopiesTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PeriodicityPlace;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FinishTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Button button6;
    }
}

