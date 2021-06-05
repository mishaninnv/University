
namespace ExerciseTwo
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PeriodicityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CostOfCopiesLable = new System.Windows.Forms.Label();
            this.JournalList = new System.Windows.Forms.ListBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PeriodicityPlane = new System.Windows.Forms.NumericUpDown();
            this.PricePlane = new System.Windows.Forms.NumericUpDown();
            this.CountCopiesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicityPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название: ";
            // 
            // PeriodicityLabel
            // 
            this.PeriodicityLabel.AutoSize = true;
            this.PeriodicityLabel.Location = new System.Drawing.Point(19, 40);
            this.PeriodicityLabel.Name = "PeriodicityLabel";
            this.PeriodicityLabel.Size = new System.Drawing.Size(131, 15);
            this.PeriodicityLabel.TabIndex = 1;
            this.PeriodicityLabel.Text = "Периодичность (дни): ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(19, 65);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(41, 15);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Цена: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FinishTime);
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Location = new System.Drawing.Point(19, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подписка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "C";
            // 
            // FinishTime
            // 
            this.FinishTime.Location = new System.Drawing.Point(210, 22);
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.Size = new System.Drawing.Size(150, 23);
            this.FinishTime.TabIndex = 1;
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(27, 20);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(150, 23);
            this.StartTime.TabIndex = 0;
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(19, 190);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(145, 23);
            this.AddToListButton.TabIndex = 4;
            this.AddToListButton.Text = "Добавить";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать стоимость ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CostOfCopiesLable
            // 
            this.CostOfCopiesLable.AutoSize = true;
            this.CostOfCopiesLable.Location = new System.Drawing.Point(181, 165);
            this.CostOfCopiesLable.Name = "CostOfCopiesLable";
            this.CostOfCopiesLable.Size = new System.Drawing.Size(129, 15);
            this.CostOfCopiesLable.TabIndex = 6;
            this.CostOfCopiesLable.Text = "Стоимость подписки: ";
            // 
            // JournalList
            // 
            this.JournalList.FormattingEnabled = true;
            this.JournalList.ItemHeight = 15;
            this.JournalList.Location = new System.Drawing.Point(19, 220);
            this.JournalList.Name = "JournalList";
            this.JournalList.Size = new System.Drawing.Size(374, 394);
            this.JournalList.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(165, 10);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(228, 23);
            this.NameText.TabIndex = 8;
            // 
            // PeriodicityPlane
            // 
            this.PeriodicityPlane.Location = new System.Drawing.Point(165, 38);
            this.PeriodicityPlane.Name = "PeriodicityPlane";
            this.PeriodicityPlane.Size = new System.Drawing.Size(228, 23);
            this.PeriodicityPlane.TabIndex = 9;
            // 
            // PricePlane
            // 
            this.PricePlane.Location = new System.Drawing.Point(165, 68);
            this.PricePlane.Name = "PricePlane";
            this.PricePlane.Size = new System.Drawing.Size(228, 23);
            this.PricePlane.TabIndex = 10;
            // 
            // CountCopiesLabel
            // 
            this.CountCopiesLabel.AutoSize = true;
            this.CountCopiesLabel.Location = new System.Drawing.Point(185, 194);
            this.CountCopiesLabel.Name = "CountCopiesLabel";
            this.CountCopiesLabel.Size = new System.Drawing.Size(153, 15);
            this.CountCopiesLabel.TabIndex = 11;
            this.CountCopiesLabel.Text = "Количество экземпляров: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 643);
            this.Controls.Add(this.CountCopiesLabel);
            this.Controls.Add(this.PricePlane);
            this.Controls.Add(this.PeriodicityPlane);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.JournalList);
            this.Controls.Add(this.CostOfCopiesLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PeriodicityLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Журналы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicityPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Periadi;
        private System.Windows.Forms.Label PeriodicityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FinishTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label CostOfCopiesLable;
        private System.Windows.Forms.ListBox JournalList;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.NumericUpDown PeriodicityPlane;
        private System.Windows.Forms.NumericUpDown PricePlane;
        private System.Windows.Forms.Label CountCopiesLabel;
    }
}

