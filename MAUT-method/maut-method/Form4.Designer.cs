namespace maut_method_project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.button_AddValue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Value
            // 
            this.textBox_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Value.ForeColor = System.Drawing.Color.White;
            this.textBox_Value.Location = new System.Drawing.Point(15, 15);
            this.textBox_Value.MaxLength = 100;
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(215, 20);
            this.textBox_Value.TabIndex = 0;
            this.textBox_Value.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Value_KeyUp);
            // 
            // button_AddValue
            // 
            this.button_AddValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_AddValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddValue.ForeColor = System.Drawing.Color.White;
            this.button_AddValue.Location = new System.Drawing.Point(236, 12);
            this.button_AddValue.Name = "button_AddValue";
            this.button_AddValue.Size = new System.Drawing.Size(75, 25);
            this.button_AddValue.TabIndex = 1;
            this.button_AddValue.Text = "Add";
            this.button_AddValue.UseCompatibleTextRendering = true;
            this.button_AddValue.UseVisualStyleBackColor = false;
            this.button_AddValue.Click += new System.EventHandler(this.button_AddValue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.textBox_Value);
            this.panel1.Controls.Add(this.button_AddValue);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 48);
            this.panel1.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(354, 71);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(370, 110);
            this.MinimumSize = new System.Drawing.Size(370, 110);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Button button_AddValue;
        private System.Windows.Forms.Panel panel1;
    }
}