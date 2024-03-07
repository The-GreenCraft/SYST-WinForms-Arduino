namespace W_UE_LED_einaus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_on = new System.Windows.Forms.Button();
            this.button_off = new System.Windows.Forms.Button();
            this.serialPortLED = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button_on
            // 
            this.button_on.BackColor = System.Drawing.Color.PaleGreen;
            this.button_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_on.Location = new System.Drawing.Point(151, 139);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(128, 128);
            this.button_on.TabIndex = 0;
            this.button_on.Text = "Ein";
            this.button_on.UseVisualStyleBackColor = false;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // button_off
            // 
            this.button_off.BackColor = System.Drawing.Color.OrangeRed;
            this.button_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button_off.Location = new System.Drawing.Point(379, 139);
            this.button_off.Name = "button_off";
            this.button_off.Size = new System.Drawing.Size(128, 128);
            this.button_off.TabIndex = 1;
            this.button_off.Text = "Aus";
            this.button_off.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 415);
            this.Controls.Add(this.button_off);
            this.Controls.Add(this.button_on);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Button button_off;
        private System.IO.Ports.SerialPort serialPortLED;
    }
}

