
namespace ExerciseOne
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.Visa = new System.Windows.Forms.RadioButton();
            this.MasterCard = new System.Windows.Forms.RadioButton();
            this.ChoiceOfPayment = new System.Windows.Forms.GroupBox();
            this.Copies = new System.Windows.Forms.NumericUpDown();
            this.NumberOfCopies = new System.Windows.Forms.Label();
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deposited = new System.Windows.Forms.NumericUpDown();
            this.ChoiceOfPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deposited)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(29, 558);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(89, 23);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Оплатить";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(29, 477);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(89, 23);
            this.CountButton.TabIndex = 1;
            this.CountButton.Text = "Рассчитать";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(137, 481);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(51, 15);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "Сумма: ";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(142, 562);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(46, 15);
            this.Change.TabIndex = 3;
            this.Change.Text = "Сдача: ";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Checked = true;
            this.Cash.Location = new System.Drawing.Point(6, 22);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(83, 19);
            this.Cash.TabIndex = 4;
            this.Cash.TabStop = true;
            this.Cash.Text = "Наличные";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // Visa
            // 
            this.Visa.AutoSize = true;
            this.Visa.Location = new System.Drawing.Point(6, 47);
            this.Visa.Name = "Visa";
            this.Visa.Size = new System.Drawing.Size(167, 19);
            this.Visa.TabIndex = 5;
            this.Visa.Text = "Карточка Visa (скидка 5%)";
            this.Visa.UseVisualStyleBackColor = true;
            // 
            // MasterCard
            // 
            this.MasterCard.AutoSize = true;
            this.MasterCard.Location = new System.Drawing.Point(6, 72);
            this.MasterCard.Name = "MasterCard";
            this.MasterCard.Size = new System.Drawing.Size(207, 19);
            this.MasterCard.TabIndex = 6;
            this.MasterCard.Text = "Карточка MasterCard (скидка 3%)";
            this.MasterCard.UseVisualStyleBackColor = true;
            // 
            // ChoiceOfPayment
            // 
            this.ChoiceOfPayment.Controls.Add(this.Cash);
            this.ChoiceOfPayment.Controls.Add(this.MasterCard);
            this.ChoiceOfPayment.Controls.Add(this.Visa);
            this.ChoiceOfPayment.Location = new System.Drawing.Point(29, 349);
            this.ChoiceOfPayment.Name = "ChoiceOfPayment";
            this.ChoiceOfPayment.Size = new System.Drawing.Size(222, 100);
            this.ChoiceOfPayment.TabIndex = 7;
            this.ChoiceOfPayment.TabStop = false;
            this.ChoiceOfPayment.Text = "Выбор оплаты";
            // 
            // Copies
            // 
            this.Copies.Location = new System.Drawing.Point(194, 318);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(57, 23);
            this.Copies.TabIndex = 8;
            // 
            // NumberOfCopies
            // 
            this.NumberOfCopies.AutoSize = true;
            this.NumberOfCopies.Location = new System.Drawing.Point(35, 320);
            this.NumberOfCopies.Name = "NumberOfCopies";
            this.NumberOfCopies.Size = new System.Drawing.Size(153, 15);
            this.NumberOfCopies.TabIndex = 9;
            this.NumberOfCopies.Text = "Количество экземпляров: ";
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.ItemHeight = 15;
            this.ProductsList.Location = new System.Drawing.Point(29, 13);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(222, 289);
            this.ProductsList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Внесенная сумма:";
            // 
            // Deposited
            // 
            this.Deposited.Location = new System.Drawing.Point(152, 519);
            this.Deposited.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Deposited.Name = "Deposited";
            this.Deposited.Size = new System.Drawing.Size(99, 23);
            this.Deposited.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 603);
            this.Controls.Add(this.Deposited);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.NumberOfCopies);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.ChoiceOfPayment);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.BuyButton);
            this.Name = "Form1";
            this.Text = "Хозяйственный магазин";
            this.ChoiceOfPayment.ResumeLayout(false);
            this.ChoiceOfPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deposited)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton Visa;
        private System.Windows.Forms.RadioButton MasterCard;
        private System.Windows.Forms.GroupBox ChoiceOfPayment;
        private System.Windows.Forms.NumericUpDown Copies;
        private System.Windows.Forms.Label NumberOfCopies;
        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Deposited;
    }
}

