namespace WinFormsApp1
{
    partial class Login
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
            button1 = new Button();
            button2 = new Button();
            txt_Senha = new TextBox();
            txt_Usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 182);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 182);
            button2.Name = "button2";
            button2.Size = new Size(123, 50);
            button2.TabIndex = 1;
            button2.Text = "Cancela";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(148, 107);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(276, 27);
            txt_Senha.TabIndex = 2;
            txt_Senha.UseSystemPasswordChar = true;
            txt_Senha.Enter += txt_Senha_Enter;
            txt_Senha.KeyDown += txt_Senha_KeyDown;
            txt_Senha.KeyPress += txt_Senha_KeyPress;
            txt_Senha.KeyUp += txt_Senha_KeyUp;
            txt_Senha.Leave += txt_Senha_Leave;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(148, 38);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(276, 27);
            txt_Usuario.TabIndex = 3;
            txt_Usuario.Enter += txt_Usuario_Enter;
            txt_Usuario.KeyPress += txt_Usuario_KeyPress;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 4;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 110);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(510, 272);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Senha);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txt_Senha;
        private TextBox txt_Usuario;
        private Label label1;
        private Label label2;
    }
}
