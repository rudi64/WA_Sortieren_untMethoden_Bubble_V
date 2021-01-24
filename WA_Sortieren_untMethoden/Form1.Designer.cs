namespace WA_Sortieren_untMethoden
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
            this.btn_bubble = new System.Windows.Forms.Button();
            this.btn_quick = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_merge = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_neu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_unsort = new System.Windows.Forms.Label();
            this.lbl_sort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bubble
            // 
            this.btn_bubble.Location = new System.Drawing.Point(12, 444);
            this.btn_bubble.Name = "btn_bubble";
            this.btn_bubble.Size = new System.Drawing.Size(86, 48);
            this.btn_bubble.TabIndex = 0;
            this.btn_bubble.Text = "bubble";
            this.btn_bubble.UseVisualStyleBackColor = true;
            this.btn_bubble.Click += new System.EventHandler(this.btn_bubble_Click);
            // 
            // btn_quick
            // 
            this.btn_quick.Location = new System.Drawing.Point(104, 444);
            this.btn_quick.Name = "btn_quick";
            this.btn_quick.Size = new System.Drawing.Size(86, 48);
            this.btn_quick.TabIndex = 1;
            this.btn_quick.Text = "quick";
            this.btn_quick.UseVisualStyleBackColor = true;
            this.btn_quick.Click += new System.EventHandler(this.btn_quick_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(196, 444);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(86, 48);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_merge
            // 
            this.btn_merge.Location = new System.Drawing.Point(288, 444);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(86, 48);
            this.btn_merge.TabIndex = 3;
            this.btn_merge.Text = "merge";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.btn_merge_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(380, 444);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(86, 48);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_neu
            // 
            this.btn_neu.Location = new System.Drawing.Point(472, 444);
            this.btn_neu.Name = "btn_neu";
            this.btn_neu.Size = new System.Drawing.Size(86, 48);
            this.btn_neu.TabIndex = 5;
            this.btn_neu.Text = "neu";
            this.btn_neu.UseVisualStyleBackColor = true;
            this.btn_neu.Click += new System.EventHandler(this.btn_neu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "unsortiert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "sortiert:";
            // 
            // lbl_unsort
            // 
            this.lbl_unsort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_unsort.Location = new System.Drawing.Point(13, 38);
            this.lbl_unsort.Name = "lbl_unsort";
            this.lbl_unsort.Size = new System.Drawing.Size(543, 165);
            this.lbl_unsort.TabIndex = 8;
            // 
            // lbl_sort
            // 
            this.lbl_sort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sort.Location = new System.Drawing.Point(13, 238);
            this.lbl_sort.Name = "lbl_sort";
            this.lbl_sort.Size = new System.Drawing.Size(543, 165);
            this.lbl_sort.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.lbl_sort);
            this.Controls.Add(this.lbl_unsort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_neu);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_merge);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_quick);
            this.Controls.Add(this.btn_bubble);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bubble;
        private System.Windows.Forms.Button btn_quick;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_neu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_unsort;
        private System.Windows.Forms.Label lbl_sort;
    }
}

