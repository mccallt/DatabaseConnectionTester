namespace DatabaseConnectionTester
{
    partial class MainForm
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
            lblServer = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtServer = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblResult = new Label();
            btnTestConnection = new Button();
            btnTestConnection2 = new Button();
            SuspendLayout();
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Font = new Font("Segoe UI", 10.125F);
            lblServer.Location = new Point(119, 68);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(96, 37);
            lblServer.TabIndex = 0;
            lblServer.Text = "Server:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.125F);
            lblUsername.Location = new Point(61, 165);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(154, 37);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.125F);
            lblPassword.Location = new Point(81, 261);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(134, 37);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtServer
            // 
            txtServer.Font = new Font("Segoe UI", 10.125F);
            txtServer.Location = new Point(231, 69);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(1183, 43);
            txtServer.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.125F);
            txtUsername.Location = new Point(231, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(1183, 43);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.125F);
            txtPassword.Location = new Point(231, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(1183, 43);
            txtPassword.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.125F);
            lblResult.Location = new Point(104, 400);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 37);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result:";
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(1179, 325);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(235, 76);
            btnTestConnection.TabIndex = 4;
            btnTestConnection.Text = "Connection Test 1";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // btnTestConnection2
            // 
            btnTestConnection2.Location = new Point(1179, 407);
            btnTestConnection2.Name = "btnTestConnection2";
            btnTestConnection2.Size = new Size(235, 76);
            btnTestConnection2.TabIndex = 5;
            btnTestConnection2.Text = "Connection Test 2";
            btnTestConnection2.UseVisualStyleBackColor = true;
            btnTestConnection2.Click += btnTestConnection2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 532);
            Controls.Add(btnTestConnection2);
            Controls.Add(btnTestConnection);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtServer);
            Controls.Add(lblResult);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblServer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Database Connection Tester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServer;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtServer;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblResult;
        private Button btnTestConnection;
        private Button btnTestConnection2;
    }
}
