namespace Csharp_Tibia_Bot
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel_potions = new TableLayoutPanel();
            panel1 = new Panel();
            label_current_hp = new Label();
            checkBox_ativarPotions = new CheckBox();
            label_hp = new Label();
            progressBar_hp = new ProgressBar();
            tableLayoutPanel_hpPotions = new TableLayoutPanel();
            tableLayoutPanel_manaPotions = new TableLayoutPanel();
            panel4 = new Panel();
            label_current_mana = new Label();
            label_mana = new Label();
            progressBar_mana = new ProgressBar();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            checkBox_gold = new CheckBox();
            checkBox_food = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel_potions.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel_potions, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Size = new Size(406, 384);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_potions
            // 
            tableLayoutPanel_potions.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel_potions.ColumnCount = 2;
            tableLayoutPanel_potions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_potions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_potions.Controls.Add(panel1, 0, 0);
            tableLayoutPanel_potions.Controls.Add(tableLayoutPanel_hpPotions, 0, 1);
            tableLayoutPanel_potions.Controls.Add(tableLayoutPanel_manaPotions, 1, 1);
            tableLayoutPanel_potions.Controls.Add(panel4, 1, 0);
            tableLayoutPanel_potions.Dock = DockStyle.Fill;
            tableLayoutPanel_potions.Location = new Point(3, 3);
            tableLayoutPanel_potions.Name = "tableLayoutPanel_potions";
            tableLayoutPanel_potions.RowCount = 2;
            tableLayoutPanel_potions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_potions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_potions.Size = new Size(400, 234);
            tableLayoutPanel_potions.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_current_hp);
            panel1.Controls.Add(checkBox_ativarPotions);
            panel1.Controls.Add(label_hp);
            panel1.Controls.Add(progressBar_hp);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 106);
            panel1.TabIndex = 0;
            // 
            // label_current_hp
            // 
            label_current_hp.BackColor = Color.Transparent;
            label_current_hp.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label_current_hp.Location = new Point(55, 58);
            label_current_hp.Name = "label_current_hp";
            label_current_hp.Size = new Size(80, 15);
            label_current_hp.TabIndex = 12;
            label_current_hp.Text = "-";
            label_current_hp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox_ativarPotions
            // 
            checkBox_ativarPotions.AutoSize = true;
            checkBox_ativarPotions.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_ativarPotions.Location = new Point(7, 3);
            checkBox_ativarPotions.Name = "checkBox_ativarPotions";
            checkBox_ativarPotions.Size = new Size(56, 23);
            checkBox_ativarPotions.TabIndex = 0;
            checkBox_ativarPotions.Text = "ON";
            checkBox_ativarPotions.UseVisualStyleBackColor = true;
            checkBox_ativarPotions.CheckedChanged += checkBox_ativarPotions_CheckedChanged;
            // 
            // label_hp
            // 
            label_hp.AutoSize = true;
            label_hp.Location = new Point(78, 20);
            label_hp.Name = "label_hp";
            label_hp.Size = new Size(35, 25);
            label_hp.TabIndex = 8;
            label_hp.Text = "HP";
            // 
            // progressBar_hp
            // 
            progressBar_hp.Location = new Point(20, 48);
            progressBar_hp.Name = "progressBar_hp";
            progressBar_hp.Size = new Size(150, 34);
            progressBar_hp.TabIndex = 7;
            // 
            // tableLayoutPanel_hpPotions
            // 
            tableLayoutPanel_hpPotions.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel_hpPotions.ColumnCount = 2;
            tableLayoutPanel_hpPotions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_hpPotions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_hpPotions.Dock = DockStyle.Fill;
            tableLayoutPanel_hpPotions.Location = new Point(6, 121);
            tableLayoutPanel_hpPotions.Name = "tableLayoutPanel_hpPotions";
            tableLayoutPanel_hpPotions.RowCount = 2;
            tableLayoutPanel_hpPotions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_hpPotions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_hpPotions.Size = new Size(189, 107);
            tableLayoutPanel_hpPotions.TabIndex = 1;
            // 
            // tableLayoutPanel_manaPotions
            // 
            tableLayoutPanel_manaPotions.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel_manaPotions.ColumnCount = 2;
            tableLayoutPanel_manaPotions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_manaPotions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_manaPotions.Dock = DockStyle.Fill;
            tableLayoutPanel_manaPotions.Location = new Point(204, 121);
            tableLayoutPanel_manaPotions.Name = "tableLayoutPanel_manaPotions";
            tableLayoutPanel_manaPotions.RowCount = 2;
            tableLayoutPanel_manaPotions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_manaPotions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_manaPotions.Size = new Size(190, 107);
            tableLayoutPanel_manaPotions.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label_current_mana);
            panel4.Controls.Add(label_mana);
            panel4.Controls.Add(progressBar_mana);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(204, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 106);
            panel4.TabIndex = 3;
            // 
            // label_current_mana
            // 
            label_current_mana.BackColor = Color.Transparent;
            label_current_mana.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label_current_mana.Location = new Point(55, 58);
            label_current_mana.Name = "label_current_mana";
            label_current_mana.Size = new Size(80, 15);
            label_current_mana.TabIndex = 11;
            label_current_mana.Text = "-";
            label_current_mana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_mana
            // 
            label_mana.AutoSize = true;
            label_mana.Location = new Point(63, 20);
            label_mana.Name = "label_mana";
            label_mana.Size = new Size(65, 25);
            label_mana.TabIndex = 10;
            label_mana.Text = "MANA";
            // 
            // progressBar_mana
            // 
            progressBar_mana.Location = new Point(20, 48);
            progressBar_mana.Name = "progressBar_mana";
            progressBar_mana.Size = new Size(150, 34);
            progressBar_mana.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 138);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(400, 138);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(checkBox_gold, 0, 0);
            tableLayoutPanel3.Controls.Add(checkBox_food, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(189, 228);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // checkBox_gold
            // 
            checkBox_gold.AutoSize = true;
            checkBox_gold.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_gold.Location = new Point(6, 6);
            checkBox_gold.Name = "checkBox_gold";
            checkBox_gold.Size = new Size(76, 29);
            checkBox_gold.TabIndex = 16;
            checkBox_gold.Text = "Gold";
            checkBox_gold.UseVisualStyleBackColor = true;
            // 
            // checkBox_food
            // 
            checkBox_food.AutoSize = true;
            checkBox_food.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_food.Location = new Point(6, 44);
            checkBox_food.Name = "checkBox_food";
            checkBox_food.Size = new Size(80, 29);
            checkBox_food.TabIndex = 15;
            checkBox_food.Text = "Food";
            checkBox_food.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 384);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Tibia Bot";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel_potions.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel_potions;
        private Panel panel1;
        private Label label_mana;
        private ProgressBar progressBar_mana;
        private Label label_hp;
        private ProgressBar progressBar_hp;
        private TableLayoutPanel tableLayoutPanel_hpPotions;
        private TableLayoutPanel tableLayoutPanel_manaPotions;
        private Panel panel4;
        private CheckBox checkBox_ativarPotions;
        private Label label_current_mana;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label_current_hp;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox checkBox_gold;
        private CheckBox checkBox_food;
    }
}