namespace maut_method_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_WeightingMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EqualWeighting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SimpleWeighting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Entropy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_PairwiseComparison = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Alternatives = new System.Windows.Forms.ListBox();
            this.button_EditDataTable = new System.Windows.Forms.Button();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.panel_Alternatives = new System.Windows.Forms.Panel();
            this.button_RemoveAlternative = new System.Windows.Forms.Button();
            this.button_EditAlternative = new System.Windows.Forms.Button();
            this.label_Alternatives = new System.Windows.Forms.Label();
            this.button_AddAlternative = new System.Windows.Forms.Button();
            this.panel_Criteria = new System.Windows.Forms.Panel();
            this.button_BenefitOrCost = new System.Windows.Forms.Button();
            this.button_RemoveCriterion = new System.Windows.Forms.Button();
            this.label_Criteria = new System.Windows.Forms.Label();
            this.button_EditCriterion = new System.Windows.Forms.Button();
            this.listBox_Criteria = new System.Windows.Forms.ListBox();
            this.button_AddCriterion = new System.Windows.Forms.Button();
            this.panel_SelectedWeightingMethod = new System.Windows.Forms.Panel();
            this.label_SelectedWeightingMethod = new System.Windows.Forms.Label();
            this.label_WeightingMethod = new System.Windows.Forms.Label();
            this.panel_CriteriaWeighting = new System.Windows.Forms.Panel();
            this.panel_PairwiseComparisonConsistency = new System.Windows.Forms.Panel();
            this.button_UploadPairwiseComparisonFile = new System.Windows.Forms.Button();
            this.button_CalculatePairwiseComparisonConsistency = new System.Windows.Forms.Button();
            this.label_PairwiseComparisonConsistency = new System.Windows.Forms.Label();
            this.label_PairwiseComparisonConsistencyValue = new System.Windows.Forms.Label();
            this.panel_PairwiseComparisonColors = new System.Windows.Forms.Panel();
            this.label_EquallyImportant = new System.Windows.Forms.Label();
            this.pictureBox_green = new System.Windows.Forms.PictureBox();
            this.pictureBox_blue = new System.Windows.Forms.PictureBox();
            this.label_NotImportant = new System.Windows.Forms.Label();
            this.label_MoreImportant = new System.Windows.Forms.Label();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.panel_NormalizationMethodsForEntropy = new System.Windows.Forms.Panel();
            this.panel_EntropyIndirectCalculationMethods = new System.Windows.Forms.Panel();
            this.radioButton_EntropyNormalizationMaxMin = new System.Windows.Forms.RadioButton();
            this.radioButton_EntropyNormalizationMax = new System.Windows.Forms.RadioButton();
            this.radioButton_EntropyIndirectCalculation = new System.Windows.Forms.RadioButton();
            this.radioButton_EntropyDirectCalculation = new System.Windows.Forms.RadioButton();
            this.label_SelectNormalizationMethodForEntropy = new System.Windows.Forms.Label();
            this.panel_EqualWeighting = new System.Windows.Forms.Panel();
            this.label_NumberOfCriteria = new System.Windows.Forms.Label();
            this.label_CalculatedWeightValue = new System.Windows.Forms.Label();
            this.label_NumberOfCriteriaValue = new System.Windows.Forms.Label();
            this.label_CalculatedWeight = new System.Windows.Forms.Label();
            this.label_SumWeightValue = new System.Windows.Forms.Label();
            this.label_SumWeight = new System.Windows.Forms.Label();
            this.label_Weighting = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel_Alternatives.SuspendLayout();
            this.panel_Criteria.SuspendLayout();
            this.panel_SelectedWeightingMethod.SuspendLayout();
            this.panel_CriteriaWeighting.SuspendLayout();
            this.panel_PairwiseComparisonConsistency.SuspendLayout();
            this.panel_PairwiseComparisonColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).BeginInit();
            this.panel_NormalizationMethodsForEntropy.SuspendLayout();
            this.panel_EntropyIndirectCalculationMethods.SuspendLayout();
            this.panel_EqualWeighting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Start,
            this.ToolStripMenuItem_WeightingMethods});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(814, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // ToolStripMenuItem_Start
            // 
            this.ToolStripMenuItem_Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_CreateNew});
            this.ToolStripMenuItem_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToolStripMenuItem_Start.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start";
            this.ToolStripMenuItem_Start.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem_Start.Text = "Start";
            // 
            // ToolStripMenuItem_CreateNew
            // 
            this.ToolStripMenuItem_CreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToolStripMenuItem_CreateNew.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_CreateNew.Name = "ToolStripMenuItem_CreateNew";
            this.ToolStripMenuItem_CreateNew.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_CreateNew.Text = "Create new";
            this.ToolStripMenuItem_CreateNew.Click += new System.EventHandler(this.ToolStripMenuItem_CreateNew_Click);
            // 
            // ToolStripMenuItem_WeightingMethods
            // 
            this.ToolStripMenuItem_WeightingMethods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EqualWeighting,
            this.ToolStripMenuItem_SimpleWeighting,
            this.ToolStripMenuItem_Entropy,
            this.ToolStripMenuItem_PairwiseComparison});
            this.ToolStripMenuItem_WeightingMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToolStripMenuItem_WeightingMethods.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_WeightingMethods.Name = "ToolStripMenuItem_WeightingMethods";
            this.ToolStripMenuItem_WeightingMethods.Size = new System.Drawing.Size(125, 20);
            this.ToolStripMenuItem_WeightingMethods.Text = "Weighting Methods";
            // 
            // ToolStripMenuItem_EqualWeighting
            // 
            this.ToolStripMenuItem_EqualWeighting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToolStripMenuItem_EqualWeighting.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_EqualWeighting.Name = "ToolStripMenuItem_EqualWeighting";
            this.ToolStripMenuItem_EqualWeighting.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_EqualWeighting.Text = "Equal Weighting";
            this.ToolStripMenuItem_EqualWeighting.Click += new System.EventHandler(this.ToolStripMenuItem_EqualWeighting_Click);
            // 
            // ToolStripMenuItem_SimpleWeighting
            // 
            this.ToolStripMenuItem_SimpleWeighting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToolStripMenuItem_SimpleWeighting.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_SimpleWeighting.Name = "ToolStripMenuItem_SimpleWeighting";
            this.ToolStripMenuItem_SimpleWeighting.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_SimpleWeighting.Text = "Simple Weighting";
            this.ToolStripMenuItem_SimpleWeighting.Click += new System.EventHandler(this.ToolStripMenuItem_SimpleWeighting_Click);
            // 
            // ToolStripMenuItem_Entropy
            // 
            this.ToolStripMenuItem_Entropy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToolStripMenuItem_Entropy.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Entropy.Name = "ToolStripMenuItem_Entropy";
            this.ToolStripMenuItem_Entropy.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Entropy.Text = "Entropy";
            this.ToolStripMenuItem_Entropy.Click += new System.EventHandler(this.ToolStripMenuItem_Entropy_Click);
            // 
            // ToolStripMenuItem_PairwiseComparison
            // 
            this.ToolStripMenuItem_PairwiseComparison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToolStripMenuItem_PairwiseComparison.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_PairwiseComparison.Name = "ToolStripMenuItem_PairwiseComparison";
            this.ToolStripMenuItem_PairwiseComparison.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_PairwiseComparison.Text = "Pairwise Comparison";
            this.ToolStripMenuItem_PairwiseComparison.Click += new System.EventHandler(this.ToolStripMenuItem_PairwiseComparison_Click);
            // 
            // listBox_Alternatives
            // 
            this.listBox_Alternatives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox_Alternatives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Alternatives.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Alternatives.ForeColor = System.Drawing.Color.White;
            this.listBox_Alternatives.FormattingEnabled = true;
            this.listBox_Alternatives.Location = new System.Drawing.Point(7, 20);
            this.listBox_Alternatives.Name = "listBox_Alternatives";
            this.listBox_Alternatives.Size = new System.Drawing.Size(175, 156);
            this.listBox_Alternatives.TabIndex = 0;
            // 
            // button_EditDataTable
            // 
            this.button_EditDataTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_EditDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EditDataTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EditDataTable.ForeColor = System.Drawing.Color.White;
            this.button_EditDataTable.Location = new System.Drawing.Point(6, 91);
            this.button_EditDataTable.Name = "button_EditDataTable";
            this.button_EditDataTable.Size = new System.Drawing.Size(174, 56);
            this.button_EditDataTable.TabIndex = 4;
            this.button_EditDataTable.Text = "EDIT DATATABLE";
            this.button_EditDataTable.UseCompatibleTextRendering = true;
            this.button_EditDataTable.UseVisualStyleBackColor = false;
            this.button_EditDataTable.Click += new System.EventHandler(this.button_EditDataTable_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Calculate.ForeColor = System.Drawing.Color.White;
            this.button_Calculate.Location = new System.Drawing.Point(6, 156);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(174, 56);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.Text = "CALCULATE";
            this.button_Calculate.UseCompatibleTextRendering = true;
            this.button_Calculate.UseVisualStyleBackColor = false;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // panel_Alternatives
            // 
            this.panel_Alternatives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel_Alternatives.Controls.Add(this.button_RemoveAlternative);
            this.panel_Alternatives.Controls.Add(this.button_EditAlternative);
            this.panel_Alternatives.Controls.Add(this.label_Alternatives);
            this.panel_Alternatives.Controls.Add(this.button_AddAlternative);
            this.panel_Alternatives.Controls.Add(this.listBox_Alternatives);
            this.panel_Alternatives.Location = new System.Drawing.Point(212, 35);
            this.panel_Alternatives.Name = "panel_Alternatives";
            this.panel_Alternatives.Size = new System.Drawing.Size(190, 220);
            this.panel_Alternatives.TabIndex = 6;
            // 
            // button_RemoveAlternative
            // 
            this.button_RemoveAlternative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_RemoveAlternative.BackgroundImage = global::maut_app.Properties.Resources.delete_icon;
            this.button_RemoveAlternative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_RemoveAlternative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RemoveAlternative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_RemoveAlternative.ForeColor = System.Drawing.Color.White;
            this.button_RemoveAlternative.Location = new System.Drawing.Point(69, 186);
            this.button_RemoveAlternative.Name = "button_RemoveAlternative";
            this.button_RemoveAlternative.Size = new System.Drawing.Size(25, 25);
            this.button_RemoveAlternative.TabIndex = 31;
            this.button_RemoveAlternative.UseCompatibleTextRendering = true;
            this.button_RemoveAlternative.UseVisualStyleBackColor = false;
            this.button_RemoveAlternative.Click += new System.EventHandler(this.button_RemoveAlternative_Click);
            // 
            // button_EditAlternative
            // 
            this.button_EditAlternative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_EditAlternative.BackgroundImage = global::maut_app.Properties.Resources.edit_icon_beyaz;
            this.button_EditAlternative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_EditAlternative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EditAlternative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EditAlternative.ForeColor = System.Drawing.Color.White;
            this.button_EditAlternative.Location = new System.Drawing.Point(38, 186);
            this.button_EditAlternative.Name = "button_EditAlternative";
            this.button_EditAlternative.Size = new System.Drawing.Size(25, 25);
            this.button_EditAlternative.TabIndex = 30;
            this.button_EditAlternative.UseCompatibleTextRendering = true;
            this.button_EditAlternative.UseVisualStyleBackColor = false;
            this.button_EditAlternative.Click += new System.EventHandler(this.button_EditAlternative_Click);
            // 
            // label_Alternatives
            // 
            this.label_Alternatives.AutoSize = true;
            this.label_Alternatives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Alternatives.ForeColor = System.Drawing.Color.White;
            this.label_Alternatives.Location = new System.Drawing.Point(4, 4);
            this.label_Alternatives.Name = "label_Alternatives";
            this.label_Alternatives.Size = new System.Drawing.Size(63, 17);
            this.label_Alternatives.TabIndex = 0;
            this.label_Alternatives.Text = "Alternatives";
            this.label_Alternatives.UseCompatibleTextRendering = true;
            // 
            // button_AddAlternative
            // 
            this.button_AddAlternative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_AddAlternative.BackgroundImage = global::maut_app.Properties.Resources.add_icon;
            this.button_AddAlternative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddAlternative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddAlternative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddAlternative.ForeColor = System.Drawing.Color.White;
            this.button_AddAlternative.Location = new System.Drawing.Point(7, 186);
            this.button_AddAlternative.Name = "button_AddAlternative";
            this.button_AddAlternative.Size = new System.Drawing.Size(25, 25);
            this.button_AddAlternative.TabIndex = 29;
            this.button_AddAlternative.UseCompatibleTextRendering = true;
            this.button_AddAlternative.UseVisualStyleBackColor = false;
            this.button_AddAlternative.Click += new System.EventHandler(this.button_AddAlternative_Click);
            // 
            // panel_Criteria
            // 
            this.panel_Criteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel_Criteria.Controls.Add(this.button_BenefitOrCost);
            this.panel_Criteria.Controls.Add(this.button_RemoveCriterion);
            this.panel_Criteria.Controls.Add(this.label_Criteria);
            this.panel_Criteria.Controls.Add(this.button_EditCriterion);
            this.panel_Criteria.Controls.Add(this.listBox_Criteria);
            this.panel_Criteria.Controls.Add(this.button_AddCriterion);
            this.panel_Criteria.Location = new System.Drawing.Point(412, 35);
            this.panel_Criteria.Name = "panel_Criteria";
            this.panel_Criteria.Size = new System.Drawing.Size(190, 220);
            this.panel_Criteria.TabIndex = 7;
            // 
            // button_BenefitOrCost
            // 
            this.button_BenefitOrCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_BenefitOrCost.BackgroundImage = global::maut_app.Properties.Resources.değiştir;
            this.button_BenefitOrCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_BenefitOrCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BenefitOrCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BenefitOrCost.ForeColor = System.Drawing.Color.White;
            this.button_BenefitOrCost.Location = new System.Drawing.Point(157, 186);
            this.button_BenefitOrCost.Name = "button_BenefitOrCost";
            this.button_BenefitOrCost.Size = new System.Drawing.Size(25, 25);
            this.button_BenefitOrCost.TabIndex = 33;
            this.button_BenefitOrCost.UseCompatibleTextRendering = true;
            this.button_BenefitOrCost.UseVisualStyleBackColor = false;
            this.button_BenefitOrCost.Click += new System.EventHandler(this.button_BenefitOrCost_Click);
            // 
            // button_RemoveCriterion
            // 
            this.button_RemoveCriterion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_RemoveCriterion.BackgroundImage = global::maut_app.Properties.Resources.delete_icon;
            this.button_RemoveCriterion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_RemoveCriterion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RemoveCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_RemoveCriterion.ForeColor = System.Drawing.Color.White;
            this.button_RemoveCriterion.Location = new System.Drawing.Point(69, 186);
            this.button_RemoveCriterion.Name = "button_RemoveCriterion";
            this.button_RemoveCriterion.Size = new System.Drawing.Size(25, 25);
            this.button_RemoveCriterion.TabIndex = 34;
            this.button_RemoveCriterion.UseCompatibleTextRendering = true;
            this.button_RemoveCriterion.UseVisualStyleBackColor = false;
            this.button_RemoveCriterion.Click += new System.EventHandler(this.button_RemoveCriterion_Click);
            // 
            // label_Criteria
            // 
            this.label_Criteria.AutoSize = true;
            this.label_Criteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Criteria.ForeColor = System.Drawing.Color.White;
            this.label_Criteria.Location = new System.Drawing.Point(4, 4);
            this.label_Criteria.Name = "label_Criteria";
            this.label_Criteria.Size = new System.Drawing.Size(41, 17);
            this.label_Criteria.TabIndex = 0;
            this.label_Criteria.Text = "Criteria";
            this.label_Criteria.UseCompatibleTextRendering = true;
            // 
            // button_EditCriterion
            // 
            this.button_EditCriterion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_EditCriterion.BackgroundImage = global::maut_app.Properties.Resources.edit_icon_beyaz;
            this.button_EditCriterion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_EditCriterion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EditCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EditCriterion.ForeColor = System.Drawing.Color.White;
            this.button_EditCriterion.Location = new System.Drawing.Point(38, 186);
            this.button_EditCriterion.Name = "button_EditCriterion";
            this.button_EditCriterion.Size = new System.Drawing.Size(25, 25);
            this.button_EditCriterion.TabIndex = 33;
            this.button_EditCriterion.UseCompatibleTextRendering = true;
            this.button_EditCriterion.UseVisualStyleBackColor = false;
            this.button_EditCriterion.Click += new System.EventHandler(this.button_EditCriterion_Click);
            // 
            // listBox_Criteria
            // 
            this.listBox_Criteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox_Criteria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Criteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Criteria.ForeColor = System.Drawing.Color.White;
            this.listBox_Criteria.FormattingEnabled = true;
            this.listBox_Criteria.Location = new System.Drawing.Point(7, 20);
            this.listBox_Criteria.Name = "listBox_Criteria";
            this.listBox_Criteria.Size = new System.Drawing.Size(175, 156);
            this.listBox_Criteria.TabIndex = 0;
            // 
            // button_AddCriterion
            // 
            this.button_AddCriterion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_AddCriterion.BackgroundImage = global::maut_app.Properties.Resources.add_icon;
            this.button_AddCriterion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddCriterion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddCriterion.ForeColor = System.Drawing.Color.White;
            this.button_AddCriterion.Location = new System.Drawing.Point(7, 186);
            this.button_AddCriterion.Name = "button_AddCriterion";
            this.button_AddCriterion.Size = new System.Drawing.Size(25, 25);
            this.button_AddCriterion.TabIndex = 32;
            this.button_AddCriterion.UseCompatibleTextRendering = true;
            this.button_AddCriterion.UseVisualStyleBackColor = false;
            this.button_AddCriterion.Click += new System.EventHandler(this.button_AddCriterion_Click);
            // 
            // panel_SelectedWeightingMethod
            // 
            this.panel_SelectedWeightingMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel_SelectedWeightingMethod.Controls.Add(this.label_SelectedWeightingMethod);
            this.panel_SelectedWeightingMethod.Controls.Add(this.label_WeightingMethod);
            this.panel_SelectedWeightingMethod.Controls.Add(this.button_Calculate);
            this.panel_SelectedWeightingMethod.Controls.Add(this.button_EditDataTable);
            this.panel_SelectedWeightingMethod.Location = new System.Drawing.Point(12, 35);
            this.panel_SelectedWeightingMethod.Name = "panel_SelectedWeightingMethod";
            this.panel_SelectedWeightingMethod.Size = new System.Drawing.Size(190, 220);
            this.panel_SelectedWeightingMethod.TabIndex = 8;
            // 
            // label_SelectedWeightingMethod
            // 
            this.label_SelectedWeightingMethod.AutoSize = true;
            this.label_SelectedWeightingMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_SelectedWeightingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SelectedWeightingMethod.ForeColor = System.Drawing.Color.White;
            this.label_SelectedWeightingMethod.Location = new System.Drawing.Point(4, 22);
            this.label_SelectedWeightingMethod.Name = "label_SelectedWeightingMethod";
            this.label_SelectedWeightingMethod.Size = new System.Drawing.Size(101, 19);
            this.label_SelectedWeightingMethod.TabIndex = 8;
            this.label_SelectedWeightingMethod.Text = "Simple Weighting";
            this.label_SelectedWeightingMethod.UseCompatibleTextRendering = true;
            // 
            // label_WeightingMethod
            // 
            this.label_WeightingMethod.AutoSize = true;
            this.label_WeightingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_WeightingMethod.ForeColor = System.Drawing.Color.White;
            this.label_WeightingMethod.Location = new System.Drawing.Point(4, 4);
            this.label_WeightingMethod.Name = "label_WeightingMethod";
            this.label_WeightingMethod.Size = new System.Drawing.Size(143, 17);
            this.label_WeightingMethod.TabIndex = 7;
            this.label_WeightingMethod.Text = "Selected Weighting Method";
            this.label_WeightingMethod.UseCompatibleTextRendering = true;
            // 
            // panel_CriteriaWeighting
            // 
            this.panel_CriteriaWeighting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel_CriteriaWeighting.Controls.Add(this.panel_PairwiseComparisonConsistency);
            this.panel_CriteriaWeighting.Controls.Add(this.panel_PairwiseComparisonColors);
            this.panel_CriteriaWeighting.Controls.Add(this.panel_NormalizationMethodsForEntropy);
            this.panel_CriteriaWeighting.Controls.Add(this.panel_EqualWeighting);
            this.panel_CriteriaWeighting.Controls.Add(this.label_SumWeightValue);
            this.panel_CriteriaWeighting.Controls.Add(this.label_SumWeight);
            this.panel_CriteriaWeighting.Controls.Add(this.label_Weighting);
            this.panel_CriteriaWeighting.Location = new System.Drawing.Point(12, 269);
            this.panel_CriteriaWeighting.Name = "panel_CriteriaWeighting";
            this.panel_CriteriaWeighting.Size = new System.Drawing.Size(789, 260);
            this.panel_CriteriaWeighting.TabIndex = 9;
            // 
            // panel_PairwiseComparisonConsistency
            // 
            this.panel_PairwiseComparisonConsistency.Controls.Add(this.button_UploadPairwiseComparisonFile);
            this.panel_PairwiseComparisonConsistency.Controls.Add(this.button_CalculatePairwiseComparisonConsistency);
            this.panel_PairwiseComparisonConsistency.Controls.Add(this.label_PairwiseComparisonConsistency);
            this.panel_PairwiseComparisonConsistency.Controls.Add(this.label_PairwiseComparisonConsistencyValue);
            this.panel_PairwiseComparisonConsistency.Location = new System.Drawing.Point(6, 217);
            this.panel_PairwiseComparisonConsistency.Name = "panel_PairwiseComparisonConsistency";
            this.panel_PairwiseComparisonConsistency.Size = new System.Drawing.Size(400, 40);
            this.panel_PairwiseComparisonConsistency.TabIndex = 28;
            // 
            // button_UploadPairwiseComparisonFile
            // 
            this.button_UploadPairwiseComparisonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(114)))), ((int)(((byte)(59)))));
            this.button_UploadPairwiseComparisonFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_UploadPairwiseComparisonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_UploadPairwiseComparisonFile.ForeColor = System.Drawing.Color.White;
            this.button_UploadPairwiseComparisonFile.Image = global::maut_app.Properties.Resources.excel_extra_small;
            this.button_UploadPairwiseComparisonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_UploadPairwiseComparisonFile.Location = new System.Drawing.Point(0, 3);
            this.button_UploadPairwiseComparisonFile.Name = "button_UploadPairwiseComparisonFile";
            this.button_UploadPairwiseComparisonFile.Size = new System.Drawing.Size(107, 30);
            this.button_UploadPairwiseComparisonFile.TabIndex = 12;
            this.button_UploadPairwiseComparisonFile.Text = "Load File";
            this.button_UploadPairwiseComparisonFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_UploadPairwiseComparisonFile.UseCompatibleTextRendering = true;
            this.button_UploadPairwiseComparisonFile.UseVisualStyleBackColor = false;
            this.button_UploadPairwiseComparisonFile.Click += new System.EventHandler(this.button_UploadPairwiseComparisonFile_Click);
            // 
            // button_CalculatePairwiseComparisonConsistency
            // 
            this.button_CalculatePairwiseComparisonConsistency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_CalculatePairwiseComparisonConsistency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CalculatePairwiseComparisonConsistency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_CalculatePairwiseComparisonConsistency.ForeColor = System.Drawing.Color.White;
            this.button_CalculatePairwiseComparisonConsistency.Location = new System.Drawing.Point(113, 3);
            this.button_CalculatePairwiseComparisonConsistency.Name = "button_CalculatePairwiseComparisonConsistency";
            this.button_CalculatePairwiseComparisonConsistency.Size = new System.Drawing.Size(60, 30);
            this.button_CalculatePairwiseComparisonConsistency.TabIndex = 3;
            this.button_CalculatePairwiseComparisonConsistency.Text = "Calculate";
            this.button_CalculatePairwiseComparisonConsistency.UseCompatibleTextRendering = true;
            this.button_CalculatePairwiseComparisonConsistency.UseVisualStyleBackColor = false;
            this.button_CalculatePairwiseComparisonConsistency.Click += new System.EventHandler(this.button_CalculatePairwiseComparisonConsistency_Click);
            // 
            // label_PairwiseComparisonConsistency
            // 
            this.label_PairwiseComparisonConsistency.AutoSize = true;
            this.label_PairwiseComparisonConsistency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_PairwiseComparisonConsistency.ForeColor = System.Drawing.Color.White;
            this.label_PairwiseComparisonConsistency.Location = new System.Drawing.Point(179, 10);
            this.label_PairwiseComparisonConsistency.Name = "label_PairwiseComparisonConsistency";
            this.label_PairwiseComparisonConsistency.Size = new System.Drawing.Size(92, 17);
            this.label_PairwiseComparisonConsistency.TabIndex = 13;
            this.label_PairwiseComparisonConsistency.Text = "Consistency rate:";
            this.label_PairwiseComparisonConsistency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_PairwiseComparisonConsistency.UseCompatibleTextRendering = true;
            // 
            // label_PairwiseComparisonConsistencyValue
            // 
            this.label_PairwiseComparisonConsistencyValue.AutoSize = true;
            this.label_PairwiseComparisonConsistencyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_PairwiseComparisonConsistencyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_PairwiseComparisonConsistencyValue.ForeColor = System.Drawing.Color.White;
            this.label_PairwiseComparisonConsistencyValue.Location = new System.Drawing.Point(274, 10);
            this.label_PairwiseComparisonConsistencyValue.Name = "label_PairwiseComparisonConsistencyValue";
            this.label_PairwiseComparisonConsistencyValue.Size = new System.Drawing.Size(76, 17);
            this.label_PairwiseComparisonConsistencyValue.TabIndex = 14;
            this.label_PairwiseComparisonConsistencyValue.Text = "Not calculated";
            this.label_PairwiseComparisonConsistencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PairwiseComparisonConsistencyValue.UseCompatibleTextRendering = true;
            // 
            // panel_PairwiseComparisonColors
            // 
            this.panel_PairwiseComparisonColors.Controls.Add(this.label_EquallyImportant);
            this.panel_PairwiseComparisonColors.Controls.Add(this.pictureBox_green);
            this.panel_PairwiseComparisonColors.Controls.Add(this.pictureBox_blue);
            this.panel_PairwiseComparisonColors.Controls.Add(this.label_NotImportant);
            this.panel_PairwiseComparisonColors.Controls.Add(this.label_MoreImportant);
            this.panel_PairwiseComparisonColors.Controls.Add(this.pictureBox_red);
            this.panel_PairwiseComparisonColors.Location = new System.Drawing.Point(460, 0);
            this.panel_PairwiseComparisonColors.Name = "panel_PairwiseComparisonColors";
            this.panel_PairwiseComparisonColors.Size = new System.Drawing.Size(326, 24);
            this.panel_PairwiseComparisonColors.TabIndex = 27;
            // 
            // label_EquallyImportant
            // 
            this.label_EquallyImportant.AutoSize = true;
            this.label_EquallyImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_EquallyImportant.ForeColor = System.Drawing.Color.White;
            this.label_EquallyImportant.Location = new System.Drawing.Point(19, 4);
            this.label_EquallyImportant.Name = "label_EquallyImportant";
            this.label_EquallyImportant.Size = new System.Drawing.Size(92, 17);
            this.label_EquallyImportant.TabIndex = 16;
            this.label_EquallyImportant.Text = "Equally important";
            this.label_EquallyImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_EquallyImportant.UseCompatibleTextRendering = true;
            // 
            // pictureBox_green
            // 
            this.pictureBox_green.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_green.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_green.Name = "pictureBox_green";
            this.pictureBox_green.Size = new System.Drawing.Size(13, 13);
            this.pictureBox_green.TabIndex = 15;
            this.pictureBox_green.TabStop = false;
            // 
            // pictureBox_blue
            // 
            this.pictureBox_blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox_blue.Location = new System.Drawing.Point(119, 6);
            this.pictureBox_blue.Name = "pictureBox_blue";
            this.pictureBox_blue.Size = new System.Drawing.Size(13, 13);
            this.pictureBox_blue.TabIndex = 17;
            this.pictureBox_blue.TabStop = false;
            // 
            // label_NotImportant
            // 
            this.label_NotImportant.AutoSize = true;
            this.label_NotImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_NotImportant.ForeColor = System.Drawing.Color.White;
            this.label_NotImportant.Location = new System.Drawing.Point(247, 4);
            this.label_NotImportant.Name = "label_NotImportant";
            this.label_NotImportant.Size = new System.Drawing.Size(72, 17);
            this.label_NotImportant.TabIndex = 20;
            this.label_NotImportant.Text = "Not important";
            this.label_NotImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_NotImportant.UseCompatibleTextRendering = true;
            // 
            // label_MoreImportant
            // 
            this.label_MoreImportant.AutoSize = true;
            this.label_MoreImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_MoreImportant.ForeColor = System.Drawing.Color.White;
            this.label_MoreImportant.Location = new System.Drawing.Point(138, 4);
            this.label_MoreImportant.Name = "label_MoreImportant";
            this.label_MoreImportant.Size = new System.Drawing.Size(80, 17);
            this.label_MoreImportant.TabIndex = 18;
            this.label_MoreImportant.Text = "More important";
            this.label_MoreImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_MoreImportant.UseCompatibleTextRendering = true;
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox_red.Location = new System.Drawing.Point(228, 6);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(13, 13);
            this.pictureBox_red.TabIndex = 19;
            this.pictureBox_red.TabStop = false;
            // 
            // panel_NormalizationMethodsForEntropy
            // 
            this.panel_NormalizationMethodsForEntropy.Controls.Add(this.panel_EntropyIndirectCalculationMethods);
            this.panel_NormalizationMethodsForEntropy.Controls.Add(this.radioButton_EntropyIndirectCalculation);
            this.panel_NormalizationMethodsForEntropy.Controls.Add(this.radioButton_EntropyDirectCalculation);
            this.panel_NormalizationMethodsForEntropy.Controls.Add(this.label_SelectNormalizationMethodForEntropy);
            this.panel_NormalizationMethodsForEntropy.Location = new System.Drawing.Point(6, 30);
            this.panel_NormalizationMethodsForEntropy.Name = "panel_NormalizationMethodsForEntropy";
            this.panel_NormalizationMethodsForEntropy.Size = new System.Drawing.Size(225, 117);
            this.panel_NormalizationMethodsForEntropy.TabIndex = 26;
            // 
            // panel_EntropyIndirectCalculationMethods
            // 
            this.panel_EntropyIndirectCalculationMethods.Controls.Add(this.radioButton_EntropyNormalizationMaxMin);
            this.panel_EntropyIndirectCalculationMethods.Controls.Add(this.radioButton_EntropyNormalizationMax);
            this.panel_EntropyIndirectCalculationMethods.Location = new System.Drawing.Point(25, 67);
            this.panel_EntropyIndirectCalculationMethods.Name = "panel_EntropyIndirectCalculationMethods";
            this.panel_EntropyIndirectCalculationMethods.Size = new System.Drawing.Size(200, 50);
            this.panel_EntropyIndirectCalculationMethods.TabIndex = 29;
            // 
            // radioButton_EntropyNormalizationMaxMin
            // 
            this.radioButton_EntropyNormalizationMaxMin.AutoSize = true;
            this.radioButton_EntropyNormalizationMaxMin.ForeColor = System.Drawing.Color.White;
            this.radioButton_EntropyNormalizationMaxMin.Location = new System.Drawing.Point(0, 23);
            this.radioButton_EntropyNormalizationMaxMin.Name = "radioButton_EntropyNormalizationMaxMin";
            this.radioButton_EntropyNormalizationMaxMin.Size = new System.Drawing.Size(66, 18);
            this.radioButton_EntropyNormalizationMaxMin.TabIndex = 26;
            this.radioButton_EntropyNormalizationMaxMin.TabStop = true;
            this.radioButton_EntropyNormalizationMaxMin.Text = "Max-Min";
            this.radioButton_EntropyNormalizationMaxMin.UseCompatibleTextRendering = true;
            this.radioButton_EntropyNormalizationMaxMin.UseVisualStyleBackColor = true;
            this.radioButton_EntropyNormalizationMaxMin.Click += new System.EventHandler(this.SelectNormalizationMethodForEntropy);
            // 
            // radioButton_EntropyNormalizationMax
            // 
            this.radioButton_EntropyNormalizationMax.AutoSize = true;
            this.radioButton_EntropyNormalizationMax.ForeColor = System.Drawing.Color.White;
            this.radioButton_EntropyNormalizationMax.Location = new System.Drawing.Point(0, 0);
            this.radioButton_EntropyNormalizationMax.Name = "radioButton_EntropyNormalizationMax";
            this.radioButton_EntropyNormalizationMax.Size = new System.Drawing.Size(44, 18);
            this.radioButton_EntropyNormalizationMax.TabIndex = 25;
            this.radioButton_EntropyNormalizationMax.TabStop = true;
            this.radioButton_EntropyNormalizationMax.Text = "Max";
            this.radioButton_EntropyNormalizationMax.UseCompatibleTextRendering = true;
            this.radioButton_EntropyNormalizationMax.UseVisualStyleBackColor = true;
            this.radioButton_EntropyNormalizationMax.Click += new System.EventHandler(this.SelectNormalizationMethodForEntropy);
            // 
            // radioButton_EntropyIndirectCalculation
            // 
            this.radioButton_EntropyIndirectCalculation.AutoSize = true;
            this.radioButton_EntropyIndirectCalculation.ForeColor = System.Drawing.Color.White;
            this.radioButton_EntropyIndirectCalculation.Location = new System.Drawing.Point(0, 45);
            this.radioButton_EntropyIndirectCalculation.Name = "radioButton_EntropyIndirectCalculation";
            this.radioButton_EntropyIndirectCalculation.Size = new System.Drawing.Size(116, 18);
            this.radioButton_EntropyIndirectCalculation.TabIndex = 24;
            this.radioButton_EntropyIndirectCalculation.TabStop = true;
            this.radioButton_EntropyIndirectCalculation.Text = "Indirect calculation";
            this.radioButton_EntropyIndirectCalculation.UseCompatibleTextRendering = true;
            this.radioButton_EntropyIndirectCalculation.UseVisualStyleBackColor = true;
            this.radioButton_EntropyIndirectCalculation.CheckedChanged += new System.EventHandler(this.radioButton_EntropyIndirectCalculation_CheckedChanged);
            // 
            // radioButton_EntropyDirectCalculation
            // 
            this.radioButton_EntropyDirectCalculation.AutoSize = true;
            this.radioButton_EntropyDirectCalculation.ForeColor = System.Drawing.Color.White;
            this.radioButton_EntropyDirectCalculation.Location = new System.Drawing.Point(0, 22);
            this.radioButton_EntropyDirectCalculation.Name = "radioButton_EntropyDirectCalculation";
            this.radioButton_EntropyDirectCalculation.Size = new System.Drawing.Size(109, 18);
            this.radioButton_EntropyDirectCalculation.TabIndex = 23;
            this.radioButton_EntropyDirectCalculation.TabStop = true;
            this.radioButton_EntropyDirectCalculation.Text = "Direct calculation";
            this.radioButton_EntropyDirectCalculation.UseCompatibleTextRendering = true;
            this.radioButton_EntropyDirectCalculation.UseVisualStyleBackColor = true;
            this.radioButton_EntropyDirectCalculation.Click += new System.EventHandler(this.SelectNormalizationMethodForEntropy);
            // 
            // label_SelectNormalizationMethodForEntropy
            // 
            this.label_SelectNormalizationMethodForEntropy.AutoSize = true;
            this.label_SelectNormalizationMethodForEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SelectNormalizationMethodForEntropy.ForeColor = System.Drawing.Color.White;
            this.label_SelectNormalizationMethodForEntropy.Location = new System.Drawing.Point(0, 0);
            this.label_SelectNormalizationMethodForEntropy.Name = "label_SelectNormalizationMethodForEntropy";
            this.label_SelectNormalizationMethodForEntropy.Size = new System.Drawing.Size(147, 17);
            this.label_SelectNormalizationMethodForEntropy.TabIndex = 22;
            this.label_SelectNormalizationMethodForEntropy.Text = "Select normalization method";
            this.label_SelectNormalizationMethodForEntropy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_SelectNormalizationMethodForEntropy.UseCompatibleTextRendering = true;
            // 
            // panel_EqualWeighting
            // 
            this.panel_EqualWeighting.Controls.Add(this.label_NumberOfCriteria);
            this.panel_EqualWeighting.Controls.Add(this.label_CalculatedWeightValue);
            this.panel_EqualWeighting.Controls.Add(this.label_NumberOfCriteriaValue);
            this.panel_EqualWeighting.Controls.Add(this.label_CalculatedWeight);
            this.panel_EqualWeighting.Location = new System.Drawing.Point(6, 30);
            this.panel_EqualWeighting.Name = "panel_EqualWeighting";
            this.panel_EqualWeighting.Size = new System.Drawing.Size(250, 50);
            this.panel_EqualWeighting.TabIndex = 25;
            // 
            // label_NumberOfCriteria
            // 
            this.label_NumberOfCriteria.AutoSize = true;
            this.label_NumberOfCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_NumberOfCriteria.ForeColor = System.Drawing.Color.White;
            this.label_NumberOfCriteria.Location = new System.Drawing.Point(0, 0);
            this.label_NumberOfCriteria.Name = "label_NumberOfCriteria";
            this.label_NumberOfCriteria.Size = new System.Drawing.Size(97, 17);
            this.label_NumberOfCriteria.TabIndex = 21;
            this.label_NumberOfCriteria.Text = "Number of criteria:";
            this.label_NumberOfCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_NumberOfCriteria.UseCompatibleTextRendering = true;
            // 
            // label_CalculatedWeightValue
            // 
            this.label_CalculatedWeightValue.AutoSize = true;
            this.label_CalculatedWeightValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_CalculatedWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CalculatedWeightValue.ForeColor = System.Drawing.Color.White;
            this.label_CalculatedWeightValue.Location = new System.Drawing.Point(100, 22);
            this.label_CalculatedWeightValue.Name = "label_CalculatedWeightValue";
            this.label_CalculatedWeightValue.Size = new System.Drawing.Size(10, 17);
            this.label_CalculatedWeightValue.TabIndex = 24;
            this.label_CalculatedWeightValue.Text = "0";
            this.label_CalculatedWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CalculatedWeightValue.UseCompatibleTextRendering = true;
            // 
            // label_NumberOfCriteriaValue
            // 
            this.label_NumberOfCriteriaValue.AutoSize = true;
            this.label_NumberOfCriteriaValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_NumberOfCriteriaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_NumberOfCriteriaValue.ForeColor = System.Drawing.Color.White;
            this.label_NumberOfCriteriaValue.Location = new System.Drawing.Point(100, 0);
            this.label_NumberOfCriteriaValue.Name = "label_NumberOfCriteriaValue";
            this.label_NumberOfCriteriaValue.Size = new System.Drawing.Size(10, 17);
            this.label_NumberOfCriteriaValue.TabIndex = 22;
            this.label_NumberOfCriteriaValue.Text = "0";
            this.label_NumberOfCriteriaValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_NumberOfCriteriaValue.UseCompatibleTextRendering = true;
            // 
            // label_CalculatedWeight
            // 
            this.label_CalculatedWeight.AutoSize = true;
            this.label_CalculatedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CalculatedWeight.ForeColor = System.Drawing.Color.White;
            this.label_CalculatedWeight.Location = new System.Drawing.Point(0, 22);
            this.label_CalculatedWeight.Name = "label_CalculatedWeight";
            this.label_CalculatedWeight.Size = new System.Drawing.Size(96, 17);
            this.label_CalculatedWeight.TabIndex = 23;
            this.label_CalculatedWeight.Text = "CalculatedWeight:";
            this.label_CalculatedWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CalculatedWeight.UseCompatibleTextRendering = true;
            // 
            // label_SumWeightValue
            // 
            this.label_SumWeightValue.AutoSize = true;
            this.label_SumWeightValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_SumWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SumWeightValue.ForeColor = System.Drawing.Color.White;
            this.label_SumWeightValue.Location = new System.Drawing.Point(89, 96);
            this.label_SumWeightValue.Name = "label_SumWeightValue";
            this.label_SumWeightValue.Size = new System.Drawing.Size(10, 17);
            this.label_SumWeightValue.TabIndex = 11;
            this.label_SumWeightValue.Text = "0";
            this.label_SumWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SumWeightValue.UseCompatibleTextRendering = true;
            // 
            // label_SumWeight
            // 
            this.label_SumWeight.AutoSize = true;
            this.label_SumWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SumWeight.ForeColor = System.Drawing.Color.White;
            this.label_SumWeight.Location = new System.Drawing.Point(4, 96);
            this.label_SumWeight.Name = "label_SumWeight";
            this.label_SumWeight.Size = new System.Drawing.Size(79, 17);
            this.label_SumWeight.TabIndex = 10;
            this.label_SumWeight.Text = "Toplam Ağırlık:";
            this.label_SumWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_SumWeight.UseCompatibleTextRendering = true;
            // 
            // label_Weighting
            // 
            this.label_Weighting.AutoSize = true;
            this.label_Weighting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Weighting.ForeColor = System.Drawing.Color.White;
            this.label_Weighting.Location = new System.Drawing.Point(4, 4);
            this.label_Weighting.Name = "label_Weighting";
            this.label_Weighting.Size = new System.Drawing.Size(90, 17);
            this.label_Weighting.TabIndex = 9;
            this.label_Weighting.Text = "Simple weighting";
            this.label_Weighting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Weighting.UseCompatibleTextRendering = true;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Info.ForeColor = System.Drawing.Color.White;
            this.label_Info.Location = new System.Drawing.Point(611, 39);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(164, 67);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Multiple Attribute Utility Theory\r\n\r\nMAUT Application v1.0\r\n\r\ngithub.com/ozgurguc" +
    "lu";
            this.label_Info.UseCompatibleTextRendering = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.panel_CriteriaWeighting);
            this.Controls.Add(this.panel_SelectedWeightingMethod);
            this.Controls.Add(this.panel_Criteria);
            this.Controls.Add(this.panel_Alternatives);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(830, 580);
            this.MinimumSize = new System.Drawing.Size(830, 300);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAUT - Decision Matrix Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_Alternatives.ResumeLayout(false);
            this.panel_Alternatives.PerformLayout();
            this.panel_Criteria.ResumeLayout(false);
            this.panel_Criteria.PerformLayout();
            this.panel_SelectedWeightingMethod.ResumeLayout(false);
            this.panel_SelectedWeightingMethod.PerformLayout();
            this.panel_CriteriaWeighting.ResumeLayout(false);
            this.panel_CriteriaWeighting.PerformLayout();
            this.panel_PairwiseComparisonConsistency.ResumeLayout(false);
            this.panel_PairwiseComparisonConsistency.PerformLayout();
            this.panel_PairwiseComparisonColors.ResumeLayout(false);
            this.panel_PairwiseComparisonColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).EndInit();
            this.panel_NormalizationMethodsForEntropy.ResumeLayout(false);
            this.panel_NormalizationMethodsForEntropy.PerformLayout();
            this.panel_EntropyIndirectCalculationMethods.ResumeLayout(false);
            this.panel_EntropyIndirectCalculationMethods.PerformLayout();
            this.panel_EqualWeighting.ResumeLayout(false);
            this.panel_EqualWeighting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CreateNew;
        private System.Windows.Forms.Button button_EditDataTable;
        private System.Windows.Forms.Button button_Calculate;
        public System.Windows.Forms.ListBox listBox_Alternatives;
        private System.Windows.Forms.Panel panel_Alternatives;
        private System.Windows.Forms.Label label_Alternatives;
        private System.Windows.Forms.Panel panel_Criteria;
        private System.Windows.Forms.Label label_Criteria;
        public System.Windows.Forms.ListBox listBox_Criteria;
        private System.Windows.Forms.Panel panel_SelectedWeightingMethod;
        private System.Windows.Forms.Label label_SelectedWeightingMethod;
        private System.Windows.Forms.Label label_WeightingMethod;
        private System.Windows.Forms.Panel panel_CriteriaWeighting;
        private System.Windows.Forms.Label label_Weighting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_WeightingMethods;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SimpleWeighting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Entropy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EqualWeighting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PairwiseComparison;
        private System.Windows.Forms.Label label_SumWeightValue;
        private System.Windows.Forms.Label label_SumWeight;
        private System.Windows.Forms.Button button_UploadPairwiseComparisonFile;
        private System.Windows.Forms.Label label_PairwiseComparisonConsistencyValue;
        private System.Windows.Forms.Label label_PairwiseComparisonConsistency;
        private System.Windows.Forms.Button button_CalculatePairwiseComparisonConsistency;
        private System.Windows.Forms.Label label_NotImportant;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.Label label_MoreImportant;
        private System.Windows.Forms.PictureBox pictureBox_blue;
        private System.Windows.Forms.Label label_EquallyImportant;
        private System.Windows.Forms.PictureBox pictureBox_green;
        private System.Windows.Forms.Label label_CalculatedWeightValue;
        private System.Windows.Forms.Label label_CalculatedWeight;
        private System.Windows.Forms.Label label_NumberOfCriteriaValue;
        private System.Windows.Forms.Label label_NumberOfCriteria;
        private System.Windows.Forms.Panel panel_EqualWeighting;
        private System.Windows.Forms.Panel panel_NormalizationMethodsForEntropy;
        private System.Windows.Forms.RadioButton radioButton_EntropyNormalizationMaxMin;
        private System.Windows.Forms.RadioButton radioButton_EntropyNormalizationMax;
        private System.Windows.Forms.RadioButton radioButton_EntropyIndirectCalculation;
        private System.Windows.Forms.RadioButton radioButton_EntropyDirectCalculation;
        private System.Windows.Forms.Label label_SelectNormalizationMethodForEntropy;
        private System.Windows.Forms.Panel panel_PairwiseComparisonColors;
        private System.Windows.Forms.Panel panel_PairwiseComparisonConsistency;
        private System.Windows.Forms.Panel panel_EntropyIndirectCalculationMethods;
        private System.Windows.Forms.Button button_RemoveAlternative;
        private System.Windows.Forms.Button button_EditAlternative;
        private System.Windows.Forms.Button button_AddAlternative;
        private System.Windows.Forms.Button button_EditCriterion;
        private System.Windows.Forms.Button button_AddCriterion;
        private System.Windows.Forms.Button button_RemoveCriterion;
        private System.Windows.Forms.Button button_BenefitOrCost;
        private System.Windows.Forms.Label label_Info;
    }
}