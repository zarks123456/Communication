
namespace WinFormsApp2
{
    partial class Form1
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
            this.button_Cnt = new System.Windows.Forms.Button();
            this.comboBox_cmd = new System.Windows.Forms.ComboBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_v4 = new System.Windows.Forms.TextBox();
            this.textBox_v3 = new System.Windows.Forms.TextBox();
            this.textBox_v2 = new System.Windows.Forms.TextBox();
            this.textBox_v1 = new System.Windows.Forms.TextBox();
            this.label_V4 = new System.Windows.Forms.Label();
            this.label_v3 = new System.Windows.Forms.Label();
            this.label_v2 = new System.Windows.Forms.Label();
            this.label_v1 = new System.Windows.Forms.Label();
            this.button_Receive = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cnt
            // 
            this.button_Cnt.Location = new System.Drawing.Point(199, 120);
            this.button_Cnt.Name = "button_Cnt";
            this.button_Cnt.Size = new System.Drawing.Size(75, 23);
            this.button_Cnt.TabIndex = 0;
            this.button_Cnt.Text = "Connect";
            this.button_Cnt.UseVisualStyleBackColor = true;
            this.button_Cnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_cmd
            // 
            this.comboBox_cmd.FormattingEnabled = true;
            this.comboBox_cmd.Items.AddRange(new object[] {
            " 1IDEN?",
            " 1WRITE",
            " 1INPI?",
            " 1INPO?",
            " 1CTR11"});
            this.comboBox_cmd.Location = new System.Drawing.Point(199, 173);
            this.comboBox_cmd.Name = "comboBox_cmd";
            this.comboBox_cmd.Size = new System.Drawing.Size(142, 23);
            this.comboBox_cmd.TabIndex = 1;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(199, 237);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_v4
            // 
            this.textBox_v4.Location = new System.Drawing.Point(507, 96);
            this.textBox_v4.Name = "textBox_v4";
            this.textBox_v4.Size = new System.Drawing.Size(120, 25);
            this.textBox_v4.TabIndex = 3;
            // 
            // textBox_v3
            // 
            this.textBox_v3.Location = new System.Drawing.Point(507, 146);
            this.textBox_v3.Name = "textBox_v3";
            this.textBox_v3.Size = new System.Drawing.Size(120, 25);
            this.textBox_v3.TabIndex = 4;
            // 
            // textBox_v2
            // 
            this.textBox_v2.Location = new System.Drawing.Point(507, 193);
            this.textBox_v2.Name = "textBox_v2";
            this.textBox_v2.Size = new System.Drawing.Size(120, 25);
            this.textBox_v2.TabIndex = 5;
            // 
            // textBox_v1
            // 
            this.textBox_v1.Location = new System.Drawing.Point(507, 238);
            this.textBox_v1.Name = "textBox_v1";
            this.textBox_v1.Size = new System.Drawing.Size(120, 25);
            this.textBox_v1.TabIndex = 6;
            // 
            // label_V4
            // 
            this.label_V4.AutoSize = true;
            this.label_V4.Location = new System.Drawing.Point(428, 97);
            this.label_V4.Name = "label_V4";
            this.label_V4.Size = new System.Drawing.Size(23, 15);
            this.label_V4.TabIndex = 7;
            this.label_V4.Text = "V4";
            // 
            // label_v3
            // 
            this.label_v3.AutoSize = true;
            this.label_v3.Location = new System.Drawing.Point(428, 149);
            this.label_v3.Name = "label_v3";
            this.label_v3.Size = new System.Drawing.Size(23, 15);
            this.label_v3.TabIndex = 8;
            this.label_v3.Text = "V3";
            // 
            // label_v2
            // 
            this.label_v2.AutoSize = true;
            this.label_v2.Location = new System.Drawing.Point(428, 196);
            this.label_v2.Name = "label_v2";
            this.label_v2.Size = new System.Drawing.Size(23, 15);
            this.label_v2.TabIndex = 9;
            this.label_v2.Text = "V2";
            // 
            // label_v1
            // 
            this.label_v1.AutoSize = true;
            this.label_v1.Location = new System.Drawing.Point(428, 248);
            this.label_v1.Name = "label_v1";
            this.label_v1.Size = new System.Drawing.Size(23, 15);
            this.label_v1.TabIndex = 10;
            this.label_v1.Text = "V1";
            // 
            // button_Receive
            // 
            this.button_Receive.Location = new System.Drawing.Point(199, 305);
            this.button_Receive.Name = "button_Receive";
            this.button_Receive.Size = new System.Drawing.Size(75, 23);
            this.button_Receive.TabIndex = 11;
            this.button_Receive.Text = "ReceiveData";
            this.button_Receive.UseVisualStyleBackColor = true;
            this.button_Receive.Click += new System.EventHandler(this.button_Receive_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(377, 306);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 25);
            this.textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button_Receive);
            this.Controls.Add(this.label_v1);
            this.Controls.Add(this.label_v2);
            this.Controls.Add(this.label_v3);
            this.Controls.Add(this.label_V4);
            this.Controls.Add(this.textBox_v1);
            this.Controls.Add(this.textBox_v2);
            this.Controls.Add(this.textBox_v3);
            this.Controls.Add(this.textBox_v4);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.comboBox_cmd);
            this.Controls.Add(this.button_Cnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cnt;
        private System.Windows.Forms.ComboBox comboBox_cmd;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_v4;
        private System.Windows.Forms.TextBox textBox_v3;
        private System.Windows.Forms.TextBox textBox_v2;
        private System.Windows.Forms.TextBox textBox_v1;
        private System.Windows.Forms.Label label_V4;
        private System.Windows.Forms.Label label_v3;
        private System.Windows.Forms.Label label_v2;
        private System.Windows.Forms.Label label_v1;
        private System.Windows.Forms.Button button_Receive;
        private System.Windows.Forms.TextBox textBox5;
    }
}