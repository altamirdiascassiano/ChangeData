namespace ChangeMetadataFile
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
            this.btn_processar = new System.Windows.Forms.Button();
            this.dt_criacao = new System.Windows.Forms.DateTimePicker();
            this.lbl_criacao = new System.Windows.Forms.Label();
            this.opt_file = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_alteracao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_processar
            // 
            this.btn_processar.Location = new System.Drawing.Point(204, 194);
            this.btn_processar.Name = "btn_processar";
            this.btn_processar.Size = new System.Drawing.Size(75, 23);
            this.btn_processar.TabIndex = 0;
            this.btn_processar.Text = "Processar";
            this.btn_processar.UseVisualStyleBackColor = true;
            this.btn_processar.Click += new System.EventHandler(this.btn_processar_Click);
            // 
            // dt_criacao
            // 
            this.dt_criacao.Location = new System.Drawing.Point(204, 90);
            this.dt_criacao.Name = "dt_criacao";
            this.dt_criacao.Size = new System.Drawing.Size(228, 20);
            this.dt_criacao.TabIndex = 1;
            this.dt_criacao.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_criacao.ValueChanged += new System.EventHandler(this.dt_criacao_ValueChanged);
            // 
            // lbl_criacao
            // 
            this.lbl_criacao.AutoSize = true;
            this.lbl_criacao.Location = new System.Drawing.Point(97, 96);
            this.lbl_criacao.Name = "lbl_criacao";
            this.lbl_criacao.Size = new System.Drawing.Size(69, 13);
            this.lbl_criacao.TabIndex = 2;
            this.lbl_criacao.Text = "Data Criação";
            // 
            // opt_file
            // 
            this.opt_file.FileOk += new System.ComponentModel.CancelEventHandler(this.opt_file_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data último acesso";
            // 
            // dt_alteracao
            // 
            this.dt_alteracao.Location = new System.Drawing.Point(204, 120);
            this.dt_alteracao.Name = "dt_alteracao";
            this.dt_alteracao.Size = new System.Drawing.Size(228, 20);
            this.dt_alteracao.TabIndex = 3;
            this.dt_alteracao.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_alteracao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arquivo";
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(204, 146);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(228, 23);
            this.btn_file.TabIndex = 6;
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 330);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_alteracao);
            this.Controls.Add(this.lbl_criacao);
            this.Controls.Add(this.dt_criacao);
            this.Controls.Add(this.btn_processar);
            this.Name = "Form1";
            this.Text = "Data Change";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_processar;
        private System.Windows.Forms.DateTimePicker dt_criacao;
        private System.Windows.Forms.Label lbl_criacao;
        private System.Windows.Forms.OpenFileDialog opt_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_alteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_file;
    }
}

