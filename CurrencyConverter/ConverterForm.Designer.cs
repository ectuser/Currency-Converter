namespace CurrencyConverter
{

    partial class ConverterForm
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
            this.FromCurrencyList = new System.Windows.Forms.ListBox();
            this.ToCurrencyList = new System.Windows.Forms.ListBox();
            this.AmountInput = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CountCurrencyButton = new System.Windows.Forms.Button();
            this.OpenTransactionsForm = new System.Windows.Forms.Button();
            this.ConvertFormErrorStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FromCurrencyList
            // 
            this.FromCurrencyList.FormattingEnabled = true;
            this.FromCurrencyList.ItemHeight = 16;
            this.FromCurrencyList.Location = new System.Drawing.Point(49, 60);
            this.FromCurrencyList.Name = "FromCurrencyList";
            this.FromCurrencyList.Size = new System.Drawing.Size(125, 148);
            this.FromCurrencyList.TabIndex = 0;
            // 
            // ToCurrencyList
            // 
            this.ToCurrencyList.FormattingEnabled = true;
            this.ToCurrencyList.ItemHeight = 16;
            this.ToCurrencyList.Location = new System.Drawing.Point(304, 60);
            this.ToCurrencyList.Name = "ToCurrencyList";
            this.ToCurrencyList.Size = new System.Drawing.Size(120, 148);
            this.ToCurrencyList.TabIndex = 1;
            // 
            // AmountInput
            // 
            this.AmountInput.Location = new System.Drawing.Point(54, 265);
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(120, 22);
            this.AmountInput.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(306, 265);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 17);
            this.OutputLabel.TabIndex = 3;
            // 
            // CountCurrencyButton
            // 
            this.CountCurrencyButton.Location = new System.Drawing.Point(173, 326);
            this.CountCurrencyButton.Name = "CountCurrencyButton";
            this.CountCurrencyButton.Size = new System.Drawing.Size(133, 23);
            this.CountCurrencyButton.TabIndex = 4;
            this.CountCurrencyButton.Text = "Count";
            this.CountCurrencyButton.UseVisualStyleBackColor = true;
            this.CountCurrencyButton.Click += new System.EventHandler(this.CountCurrencyButton_Click);
            // 
            // OpenTransactionsForm
            // 
            this.OpenTransactionsForm.Location = new System.Drawing.Point(49, 443);
            this.OpenTransactionsForm.Name = "OpenTransactionsForm";
            this.OpenTransactionsForm.Size = new System.Drawing.Size(375, 23);
            this.OpenTransactionsForm.TabIndex = 6;
            this.OpenTransactionsForm.Text = "All Transactions";
            this.OpenTransactionsForm.UseVisualStyleBackColor = true;
            this.OpenTransactionsForm.Click += new System.EventHandler(this.OpenTransactionsForm_Click);
            // 
            // ConvertFormErrorStatus
            // 
            this.ConvertFormErrorStatus.AutoSize = true;
            this.ConvertFormErrorStatus.Location = new System.Drawing.Point(51, 410);
            this.ConvertFormErrorStatus.Name = "ConvertFormErrorStatus";
            this.ConvertFormErrorStatus.Size = new System.Drawing.Size(0, 17);
            this.ConvertFormErrorStatus.TabIndex = 7;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 493);
            this.Controls.Add(this.ConvertFormErrorStatus);
            this.Controls.Add(this.OpenTransactionsForm);
            this.Controls.Add(this.CountCurrencyButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.AmountInput);
            this.Controls.Add(this.ToCurrencyList);
            this.Controls.Add(this.FromCurrencyList);
            this.Name = "ConverterForm";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FromCurrencyList;
        private System.Windows.Forms.ListBox ToCurrencyList;
        private System.Windows.Forms.TextBox AmountInput;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button CountCurrencyButton;
        private System.Windows.Forms.Button OpenTransactionsForm;
        private System.Windows.Forms.Label ConvertFormErrorStatus;
    }
}