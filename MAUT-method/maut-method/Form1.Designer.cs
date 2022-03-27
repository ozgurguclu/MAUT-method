namespace maut_method_project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_selectFile = new System.Windows.Forms.Button();
            this.label_dragFile = new System.Windows.Forms.Label();
            this.button_createEmpty = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_createEmpty = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selectFile
            // 
            this.button_selectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_selectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_selectFile.ForeColor = System.Drawing.Color.White;
            this.button_selectFile.Location = new System.Drawing.Point(80, 74);
            this.button_selectFile.Name = "button_selectFile";
            this.button_selectFile.Size = new System.Drawing.Size(120, 30);
            this.button_selectFile.TabIndex = 1;
            this.button_selectFile.Text = "Select file";
            this.button_selectFile.UseCompatibleTextRendering = true;
            this.button_selectFile.UseVisualStyleBackColor = false;
            this.button_selectFile.Click += new System.EventHandler(this.button_selectFile_Click);
            // 
            // label_dragFile
            // 
            this.label_dragFile.AutoSize = true;
            this.label_dragFile.BackColor = System.Drawing.Color.Transparent;
            this.label_dragFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_dragFile.ForeColor = System.Drawing.Color.White;
            this.label_dragFile.Location = new System.Drawing.Point(70, 25);
            this.label_dragFile.Name = "label_dragFile";
            this.label_dragFile.Size = new System.Drawing.Size(146, 42);
            this.label_dragFile.TabIndex = 3;
            this.label_dragFile.Text = "Drag and drop an Excel file\r\n\r\nOr";
            this.label_dragFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_dragFile.UseCompatibleTextRendering = true;
            // 
            // button_createEmpty
            // 
            this.button_createEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_createEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_createEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_createEmpty.ForeColor = System.Drawing.Color.White;
            this.button_createEmpty.Location = new System.Drawing.Point(80, 74);
            this.button_createEmpty.Name = "button_createEmpty";
            this.button_createEmpty.Size = new System.Drawing.Size(120, 30);
            this.button_createEmpty.TabIndex = 5;
            this.button_createEmpty.Text = "Create";
            this.button_createEmpty.UseCompatibleTextRendering = true;
            this.button_createEmpty.UseVisualStyleBackColor = false;
            this.button_createEmpty.Click += new System.EventHandler(this.button_createEmpty_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(59)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_selectFile);
            this.panel1.Controls.Add(this.label_dragFile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 125);
            this.panel1.TabIndex = 4;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::maut_app.Properties.Resources.excel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(260, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label_createEmpty);
            this.panel2.Controls.Add(this.button_createEmpty);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 125);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::maut_app.Properties.Resources.excel2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(260, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label_createEmpty
            // 
            this.label_createEmpty.AutoSize = true;
            this.label_createEmpty.BackColor = System.Drawing.Color.Transparent;
            this.label_createEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_createEmpty.ForeColor = System.Drawing.Color.White;
            this.label_createEmpty.Location = new System.Drawing.Point(70, 23);
            this.label_createEmpty.Name = "label_createEmpty";
            this.label_createEmpty.Size = new System.Drawing.Size(138, 42);
            this.label_createEmpty.TabIndex = 6;
            this.label_createEmpty.Text = "To create a empty project\r\n\r\nClick here";
            this.label_createEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_createEmpty.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 326);
            this.MinimumSize = new System.Drawing.Size(400, 326);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAUT - Load Decision Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_selectFile;
        private System.Windows.Forms.Label label_dragFile;
        private System.Windows.Forms.Button button_createEmpty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_createEmpty;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

