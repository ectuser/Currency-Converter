namespace CurrencyConverter
{
    partial class AuthForm
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
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthFormErrorStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(119, 153);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(188, 22);
            this.LoginInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(119, 245);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(188, 22);
            this.PasswordInput.TabIndex = 1;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(119, 336);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(232, 336);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // AuthFormErrorStatus
            // 
            this.AuthFormErrorStatus.AutoSize = true;
            this.AuthFormErrorStatus.Location = new System.Drawing.Point(50, 394);
            this.AuthFormErrorStatus.Name = "AuthFormErrorStatus";
            this.AuthFormErrorStatus.Size = new System.Drawing.Size(0, 17);
            this.AuthFormErrorStatus.TabIndex = 7;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 469);
            this.Controls.Add(this.AuthFormErrorStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Name = "AuthForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AuthFormErrorStatus;
    }
}

