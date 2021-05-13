
namespace Optimal_Asset_Allocation_final
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.nEnt = new System.Windows.Forms.NumericUpDown();
            this.nAtt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(261, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(527, 317);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(146, 347);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість підприємств:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість варіантів вкладення:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сума вкладення:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(12, 347);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(91, 47);
            this.btnTable.TabIndex = 5;
            this.btnTable.Text = "Створити таблицю";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // money
            // 
            this.money.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.money.Location = new System.Drawing.Point(197, 144);
            this.money.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.money.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(40, 20);
            this.money.TabIndex = 6;
            this.money.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.money.ValueChanged += new System.EventHandler(this.money_ValueChanged);
            // 
            // nEnt
            // 
            this.nEnt.Location = new System.Drawing.Point(197, 182);
            this.nEnt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nEnt.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nEnt.Name = "nEnt";
            this.nEnt.Size = new System.Drawing.Size(40, 20);
            this.nEnt.TabIndex = 7;
            this.nEnt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nEnt.ValueChanged += new System.EventHandler(this.nEnt_ValueChanged);
            // 
            // nAtt
            // 
            this.nAtt.Location = new System.Drawing.Point(197, 222);
            this.nAtt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAtt.Name = "nAtt";
            this.nAtt.Size = new System.Drawing.Size(40, 20);
            this.nAtt.TabIndex = 8;
            this.nAtt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nAtt.ValueChanged += new System.EventHandler(this.nAtt_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nAtt);
            this.Controls.Add(this.nEnt);
            this.Controls.Add(this.money);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Optimal Asset Allocation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.NumericUpDown nEnt;
        private System.Windows.Forms.NumericUpDown nAtt;
    }
}

