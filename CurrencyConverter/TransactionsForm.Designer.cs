namespace CurrencyConverter
{
    partial class TransactionsForm
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
            this.TransactionsList = new System.Windows.Forms.ListView();
            this.FromCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTimeTransaction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TransactionsList
            // 
            this.TransactionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FromCurrency,
            this.FromValue,
            this.ToCurrency,
            this.ToValue,
            this.Rate,
            this.DateTimeTransaction});
            this.TransactionsList.FullRowSelect = true;
            this.TransactionsList.GridLines = true;
            this.TransactionsList.HideSelection = false;
            this.TransactionsList.Location = new System.Drawing.Point(12, 37);
            this.TransactionsList.MultiSelect = false;
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.Size = new System.Drawing.Size(776, 363);
            this.TransactionsList.TabIndex = 13;
            this.TransactionsList.UseCompatibleStateImageBehavior = false;
            this.TransactionsList.View = System.Windows.Forms.View.Details;
            // 
            // FromCurrency
            // 
            this.FromCurrency.Text = "From";
            this.FromCurrency.Width = 129;
            // 
            // FromValue
            // 
            this.FromValue.Text = "Value";
            this.FromValue.Width = 92;
            // 
            // ToCurrency
            // 
            this.ToCurrency.Text = "To";
            this.ToCurrency.Width = 119;
            // 
            // ToValue
            // 
            this.ToValue.Text = "Value";
            this.ToValue.Width = 107;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            this.Rate.Width = 76;
            // 
            // DateTimeTransaction
            // 
            this.DateTimeTransaction.Text = "Date";
            this.DateTimeTransaction.Width = 242;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.TransactionsList);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TransactionsList;
        private System.Windows.Forms.ColumnHeader FromCurrency;
        private System.Windows.Forms.ColumnHeader FromValue;
        private System.Windows.Forms.ColumnHeader ToCurrency;
        private System.Windows.Forms.ColumnHeader ToValue;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader DateTimeTransaction;
    }
}