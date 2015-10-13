namespace View
{
    partial class frm_Pesquisa
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
            this.dgv_Pesquisa = new System.Windows.Forms.DataGridView();
            this.ltb_SQL = new System.Windows.Forms.ListBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.lbl_SQL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pesquisa
            // 
            this.dgv_Pesquisa.AllowDrop = true;
            this.dgv_Pesquisa.AllowUserToAddRows = false;
            this.dgv_Pesquisa.AllowUserToDeleteRows = false;
            this.dgv_Pesquisa.AllowUserToOrderColumns = true;
            this.dgv_Pesquisa.AllowUserToResizeColumns = false;
            this.dgv_Pesquisa.AllowUserToResizeRows = false;
            this.dgv_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Pesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pesquisa.Location = new System.Drawing.Point(12, 183);
            this.dgv_Pesquisa.Name = "dgv_Pesquisa";
            this.dgv_Pesquisa.RowHeadersVisible = false;
            this.dgv_Pesquisa.Size = new System.Drawing.Size(960, 367);
            this.dgv_Pesquisa.TabIndex = 0;
            // 
            // ltb_SQL
            // 
            this.ltb_SQL.BackColor = System.Drawing.Color.Silver;
            this.ltb_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_SQL.FormattingEnabled = true;
            this.ltb_SQL.ItemHeight = 16;
            this.ltb_SQL.Location = new System.Drawing.Point(12, 82);
            this.ltb_SQL.Name = "ltb_SQL";
            this.ltb_SQL.Size = new System.Drawing.Size(960, 84);
            this.ltb_SQL.TabIndex = 1;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.Silver;
            this.txt_Titulo.Enabled = false;
            this.txt_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_Titulo.Location = new System.Drawing.Point(12, 27);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(960, 22);
            this.txt_Titulo.TabIndex = 2;
            // 
            // lbl_SQL
            // 
            this.lbl_SQL.AutoSize = true;
            this.lbl_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SQL.Location = new System.Drawing.Point(378, 66);
            this.lbl_SQL.Name = "lbl_SQL";
            this.lbl_SQL.Size = new System.Drawing.Size(255, 13);
            this.lbl_SQL.TabIndex = 3;
            this.lbl_SQL.Text = "Conversão Para TSQL [SQL SERVER 2012]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título";
            // 
            // frm_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SQL);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.ltb_SQL);
            this.Controls.Add(this.dgv_Pesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frm_Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pesquisa;
        private System.Windows.Forms.ListBox ltb_SQL;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label lbl_SQL;
        private System.Windows.Forms.Label label1;
    }
}