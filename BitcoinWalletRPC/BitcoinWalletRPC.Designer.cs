namespace BitcoinWalletRPC
{
    partial class BitcoinWalletRPC
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
            this.fetch = new System.Windows.Forms.Button();
            this.rpc_host = new System.Windows.Forms.TextBox();
            this.rpc_password = new System.Windows.Forms.TextBox();
            this.rpc_user = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_host = new System.Windows.Forms.Label();
            this.rpc_port = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.rpc_method = new System.Windows.Forms.TextBox();
            this.label_method = new System.Windows.Forms.Label();
            this.rpc_params = new System.Windows.Forms.TextBox();
            this.label_params = new System.Windows.Forms.Label();
            this.label_donate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fetch
            // 
            this.fetch.Location = new System.Drawing.Point(100, 157);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(75, 23);
            this.fetch.TabIndex = 6;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = true;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // rpc_host
            // 
            this.rpc_host.Location = new System.Drawing.Point(100, 108);
            this.rpc_host.Name = "rpc_host";
            this.rpc_host.Size = new System.Drawing.Size(100, 20);
            this.rpc_host.TabIndex = 2;
            // 
            // rpc_password
            // 
            this.rpc_password.Location = new System.Drawing.Point(100, 82);
            this.rpc_password.Name = "rpc_password";
            this.rpc_password.PasswordChar = '*';
            this.rpc_password.Size = new System.Drawing.Size(100, 20);
            this.rpc_password.TabIndex = 1;
            // 
            // rpc_user
            // 
            this.rpc_user.Location = new System.Drawing.Point(100, 56);
            this.rpc_user.Name = "rpc_user";
            this.rpc_user.Size = new System.Drawing.Size(100, 20);
            this.rpc_user.TabIndex = 0;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(13, 62);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(29, 13);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "User";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(13, 88);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Password";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(12, 114);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(29, 13);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "Host";
            // 
            // rpc_port
            // 
            this.rpc_port.Location = new System.Drawing.Point(207, 107);
            this.rpc_port.Name = "rpc_port";
            this.rpc_port.Size = new System.Drawing.Size(34, 20);
            this.rpc_port.TabIndex = 3;
            this.rpc_port.Text = "8332";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 186);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(463, 119);
            this.result.TabIndex = 7;
            // 
            // rpc_method
            // 
            this.rpc_method.Location = new System.Drawing.Point(100, 134);
            this.rpc_method.Name = "rpc_method";
            this.rpc_method.Size = new System.Drawing.Size(100, 20);
            this.rpc_method.TabIndex = 4;
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(13, 140);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(43, 13);
            this.label_method.TabIndex = 10;
            this.label_method.Text = "Method";
            // 
            // rpc_params
            // 
            this.rpc_params.Location = new System.Drawing.Point(255, 133);
            this.rpc_params.Name = "rpc_params";
            this.rpc_params.Size = new System.Drawing.Size(100, 20);
            this.rpc_params.TabIndex = 5;
            // 
            // label_params
            // 
            this.label_params.AutoSize = true;
            this.label_params.Location = new System.Drawing.Point(207, 139);
            this.label_params.Name = "label_params";
            this.label_params.Size = new System.Drawing.Size(42, 13);
            this.label_params.TabIndex = 12;
            this.label_params.Text = "Params";
            // 
            // label_donate
            // 
            this.label_donate.AutoSize = true;
            this.label_donate.Location = new System.Drawing.Point(15, 320);
            this.label_donate.Name = "label_donate";
            this.label_donate.Size = new System.Drawing.Size(343, 13);
            this.label_donate.TabIndex = 13;
            this.label_donate.Text = "Donations are appreciated - 176SZeDZJJ6sJi7cjVfRq4yD9wMaPsj2wC";
            // 
            // BitcoinWalletRPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 345);
            this.Controls.Add(this.label_donate);
            this.Controls.Add(this.label_params);
            this.Controls.Add(this.rpc_params);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.rpc_method);
            this.Controls.Add(this.result);
            this.Controls.Add(this.rpc_port);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.rpc_user);
            this.Controls.Add(this.rpc_password);
            this.Controls.Add(this.rpc_host);
            this.Controls.Add(this.fetch);
            this.Name = "BitcoinWalletRPC";
            this.Text = "Bitcoin Wallet RPC - Made by Han Lin Yap";
            this.Load += new System.EventHandler(this.BitcoinWalletRPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetch;
        private System.Windows.Forms.TextBox rpc_host;
        private System.Windows.Forms.TextBox rpc_password;
        private System.Windows.Forms.TextBox rpc_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.TextBox rpc_port;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox rpc_method;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.TextBox rpc_params;
        private System.Windows.Forms.Label label_params;
        private System.Windows.Forms.Label label_donate;
    }
}

