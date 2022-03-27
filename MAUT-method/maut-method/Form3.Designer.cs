namespace maut_method_project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel_DecisionMatrix = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_CellName = new System.Windows.Forms.TextBox();
            this.comboBox_CellSelection = new System.Windows.Forms.ComboBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CellValue = new System.Windows.Forms.TextBox();
            this.button_DeleteValuesByRow = new System.Windows.Forms.Button();
            this.button_DeleteValuesByColumn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Paste = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Cut = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DecisionMatrix
            // 
            this.panel_DecisionMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel_DecisionMatrix.Location = new System.Drawing.Point(12, 99);
            this.panel_DecisionMatrix.Name = "panel_DecisionMatrix";
            this.panel_DecisionMatrix.Size = new System.Drawing.Size(780, 340);
            this.panel_DecisionMatrix.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.textBox_CellName);
            this.panel1.Controls.Add(this.comboBox_CellSelection);
            this.panel1.Controls.Add(this.button_Calculate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_CellValue);
            this.panel1.Controls.Add(this.button_DeleteValuesByRow);
            this.panel1.Controls.Add(this.button_DeleteValuesByColumn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Paste);
            this.panel1.Controls.Add(this.button_Copy);
            this.panel1.Controls.Add(this.button_Cut);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 81);
            this.panel1.TabIndex = 2;
            // 
            // textBox_CellName
            // 
            this.textBox_CellName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox_CellName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_CellName.ForeColor = System.Drawing.Color.White;
            this.textBox_CellName.Location = new System.Drawing.Point(7, 50);
            this.textBox_CellName.Name = "textBox_CellName";
            this.textBox_CellName.ReadOnly = true;
            this.textBox_CellName.Size = new System.Drawing.Size(202, 20);
            this.textBox_CellName.TabIndex = 17;
            // 
            // comboBox_CellSelection
            // 
            this.comboBox_CellSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBox_CellSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CellSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_CellSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_CellSelection.ForeColor = System.Drawing.Color.White;
            this.comboBox_CellSelection.FormattingEnabled = true;
            this.comboBox_CellSelection.Items.AddRange(new object[] {
            "Seçili Hücre",
            "Tüm Boş Hücreler",
            "Seçili Sütundaki Boş Hücreler",
            "Seçili Satırdaki Boş Hücreler"});
            this.comboBox_CellSelection.Location = new System.Drawing.Point(215, 25);
            this.comboBox_CellSelection.Name = "comboBox_CellSelection";
            this.comboBox_CellSelection.Size = new System.Drawing.Size(225, 21);
            this.comboBox_CellSelection.TabIndex = 15;
            this.comboBox_CellSelection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_CellSelection_DrawItem);
            this.comboBox_CellSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_CellSelection_SelectedIndexChanged);
            this.comboBox_CellSelection.SelectionChangeCommitted += new System.EventHandler(this.comboBox_CellSelection_SelectionChangeCommitted);
            // 
            // button_Calculate
            // 
            this.button_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Calculate.ForeColor = System.Drawing.Color.White;
            this.button_Calculate.Location = new System.Drawing.Point(648, 23);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(124, 47);
            this.button_Calculate.TabIndex = 14;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseCompatibleTextRendering = true;
            this.button_Calculate.UseVisualStyleBackColor = false;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(645, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Continue";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add value into the cell";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // textBox_CellValue
            // 
            this.textBox_CellValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox_CellValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CellValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_CellValue.ForeColor = System.Drawing.Color.White;
            this.textBox_CellValue.Location = new System.Drawing.Point(215, 50);
            this.textBox_CellValue.MaxLength = 10;
            this.textBox_CellValue.Name = "textBox_CellValue";
            this.textBox_CellValue.Size = new System.Drawing.Size(225, 20);
            this.textBox_CellValue.TabIndex = 10;
            this.textBox_CellValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_CellValue_KeyUp);
            // 
            // button_DeleteValuesByRow
            // 
            this.button_DeleteValuesByRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_DeleteValuesByRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DeleteValuesByRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DeleteValuesByRow.ForeColor = System.Drawing.Color.White;
            this.button_DeleteValuesByRow.Location = new System.Drawing.Point(446, 48);
            this.button_DeleteValuesByRow.Name = "button_DeleteValuesByRow";
            this.button_DeleteValuesByRow.Size = new System.Drawing.Size(196, 22);
            this.button_DeleteValuesByRow.TabIndex = 9;
            this.button_DeleteValuesByRow.Text = "Delete values by row";
            this.button_DeleteValuesByRow.UseCompatibleTextRendering = true;
            this.button_DeleteValuesByRow.UseVisualStyleBackColor = false;
            this.button_DeleteValuesByRow.Click += new System.EventHandler(this.button_DeleteValuesByRow_Click);
            // 
            // button_DeleteValuesByColumn
            // 
            this.button_DeleteValuesByColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_DeleteValuesByColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DeleteValuesByColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_DeleteValuesByColumn.ForeColor = System.Drawing.Color.White;
            this.button_DeleteValuesByColumn.Location = new System.Drawing.Point(446, 23);
            this.button_DeleteValuesByColumn.Name = "button_DeleteValuesByColumn";
            this.button_DeleteValuesByColumn.Size = new System.Drawing.Size(196, 22);
            this.button_DeleteValuesByColumn.TabIndex = 8;
            this.button_DeleteValuesByColumn.Text = "Delete values by column";
            this.button_DeleteValuesByColumn.UseCompatibleTextRendering = true;
            this.button_DeleteValuesByColumn.UseVisualStyleBackColor = false;
            this.button_DeleteValuesByColumn.Click += new System.EventHandler(this.button_DeleteValuesByColumn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(443, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Column/Row cells";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit cell";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button_Paste
            // 
            this.button_Paste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Paste.BackgroundImage = global::maut_app.Properties.Resources.paste_white;
            this.button_Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Paste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Paste.ForeColor = System.Drawing.Color.White;
            this.button_Paste.Location = new System.Drawing.Point(100, 20);
            this.button_Paste.Name = "button_Paste";
            this.button_Paste.Size = new System.Drawing.Size(25, 25);
            this.button_Paste.TabIndex = 5;
            this.button_Paste.UseCompatibleTextRendering = true;
            this.button_Paste.UseVisualStyleBackColor = false;
            this.button_Paste.Click += new System.EventHandler(this.button_Paste_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Copy.BackgroundImage = global::maut_app.Properties.Resources.copy_white;
            this.button_Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Copy.ForeColor = System.Drawing.Color.White;
            this.button_Copy.Location = new System.Drawing.Point(69, 20);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(25, 25);
            this.button_Copy.TabIndex = 4;
            this.button_Copy.UseCompatibleTextRendering = true;
            this.button_Copy.UseVisualStyleBackColor = false;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Cut
            // 
            this.button_Cut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Cut.BackgroundImage = global::maut_app.Properties.Resources.cut_white;
            this.button_Cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cut.ForeColor = System.Drawing.Color.White;
            this.button_Cut.Location = new System.Drawing.Point(38, 20);
            this.button_Cut.Name = "button_Cut";
            this.button_Cut.Size = new System.Drawing.Size(25, 25);
            this.button_Cut.TabIndex = 3;
            this.button_Cut.UseCompatibleTextRendering = true;
            this.button_Cut.UseVisualStyleBackColor = false;
            this.button_Cut.Click += new System.EventHandler(this.button_Cut_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Delete.BackgroundImage = global::maut_app.Properties.Resources.delete;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(7, 20);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(25, 25);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.UseCompatibleTextRendering = true;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_DecisionMatrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Decision Matrix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DecisionMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Paste;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Cut;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteValuesByRow;
        private System.Windows.Forms.Button button_DeleteValuesByColumn;
        private System.Windows.Forms.TextBox textBox_CellValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_CellSelection;
        private System.Windows.Forms.TextBox textBox_CellName;
    }
}