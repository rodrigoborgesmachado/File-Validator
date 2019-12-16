namespace View
{
    partial class FO_Principal
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
            this.pan_completo = new System.Windows.Forms.Panel();
            this.pan_botoes = new System.Windows.Forms.Panel();
            this.pan_opcoes = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.grb_opcoes = new System.Windows.Forms.GroupBox();
            this.lbl_xmlFile = new System.Windows.Forms.Label();
            this.tbx_xml = new System.Windows.Forms.TextBox();
            this.btn_xmlFile = new System.Windows.Forms.Button();
            this.tbx_file = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.pan_xml = new System.Windows.Forms.Panel();
            this.pan_file = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_completo.SuspendLayout();
            this.pan_botoes.SuspendLayout();
            this.pan_opcoes.SuspendLayout();
            this.grb_opcoes.SuspendLayout();
            this.pan_xml.SuspendLayout();
            this.pan_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.pan_opcoes);
            this.pan_completo.Controls.Add(this.pan_botoes);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(316, 166);
            this.pan_completo.TabIndex = 0;
            // 
            // pan_botoes
            // 
            this.pan_botoes.Controls.Add(this.btn_confirmar);
            this.pan_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botoes.Location = new System.Drawing.Point(0, 135);
            this.pan_botoes.Name = "pan_botoes";
            this.pan_botoes.Size = new System.Drawing.Size(316, 31);
            this.pan_botoes.TabIndex = 0;
            // 
            // pan_opcoes
            // 
            this.pan_opcoes.Controls.Add(this.grb_opcoes);
            this.pan_opcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_opcoes.Location = new System.Drawing.Point(0, 0);
            this.pan_opcoes.Name = "pan_opcoes";
            this.pan_opcoes.Size = new System.Drawing.Size(316, 135);
            this.pan_opcoes.TabIndex = 1;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(234, 4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Verificar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // grb_opcoes
            // 
            this.grb_opcoes.Controls.Add(this.pan_file);
            this.grb_opcoes.Controls.Add(this.pan_xml);
            this.grb_opcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_opcoes.Location = new System.Drawing.Point(0, 0);
            this.grb_opcoes.Name = "grb_opcoes";
            this.grb_opcoes.Size = new System.Drawing.Size(316, 135);
            this.grb_opcoes.TabIndex = 0;
            this.grb_opcoes.TabStop = false;
            this.grb_opcoes.Text = "Arquivos";
            // 
            // lbl_xmlFile
            // 
            this.lbl_xmlFile.AutoSize = true;
            this.lbl_xmlFile.Location = new System.Drawing.Point(13, 4);
            this.lbl_xmlFile.Name = "lbl_xmlFile";
            this.lbl_xmlFile.Size = new System.Drawing.Size(170, 15);
            this.lbl_xmlFile.TabIndex = 0;
            this.lbl_xmlFile.Text = "Arquivo XML de configuração:";
            // 
            // tbx_xml
            // 
            this.tbx_xml.Enabled = false;
            this.tbx_xml.Location = new System.Drawing.Point(32, 21);
            this.tbx_xml.Name = "tbx_xml";
            this.tbx_xml.Size = new System.Drawing.Size(200, 21);
            this.tbx_xml.TabIndex = 3;
            // 
            // btn_xmlFile
            // 
            this.btn_xmlFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xmlFile.Location = new System.Drawing.Point(238, 21);
            this.btn_xmlFile.Name = "btn_xmlFile";
            this.btn_xmlFile.Size = new System.Drawing.Size(55, 28);
            this.btn_xmlFile.TabIndex = 5;
            this.btn_xmlFile.Text = "Arquivo";
            this.btn_xmlFile.UseVisualStyleBackColor = true;
            this.btn_xmlFile.Click += new System.EventHandler(this.btn_xmlFile_Click);
            // 
            // tbx_file
            // 
            this.tbx_file.Enabled = false;
            this.tbx_file.Location = new System.Drawing.Point(32, 19);
            this.tbx_file.Name = "tbx_file";
            this.tbx_file.Size = new System.Drawing.Size(200, 21);
            this.tbx_file.TabIndex = 4;
            // 
            // btn_file
            // 
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_file.Location = new System.Drawing.Point(238, 19);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(55, 31);
            this.btn_file.TabIndex = 6;
            this.btn_file.Text = "Arquivo";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // pan_xml
            // 
            this.pan_xml.Controls.Add(this.btn_xmlFile);
            this.pan_xml.Controls.Add(this.tbx_xml);
            this.pan_xml.Controls.Add(this.lbl_xmlFile);
            this.pan_xml.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_xml.Location = new System.Drawing.Point(3, 17);
            this.pan_xml.Name = "pan_xml";
            this.pan_xml.Size = new System.Drawing.Size(310, 62);
            this.pan_xml.TabIndex = 7;
            // 
            // pan_file
            // 
            this.pan_file.Controls.Add(this.label1);
            this.pan_file.Controls.Add(this.btn_file);
            this.pan_file.Controls.Add(this.tbx_file);
            this.pan_file.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_file.Location = new System.Drawing.Point(3, 79);
            this.pan_file.Name = "pan_file";
            this.pan_file.Size = new System.Drawing.Size(310, 56);
            this.pan_file.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arquivo para verificação:";
            // 
            // FO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(316, 166);
            this.Controls.Add(this.pan_completo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FO_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validator";
            this.pan_completo.ResumeLayout(false);
            this.pan_botoes.ResumeLayout(false);
            this.pan_opcoes.ResumeLayout(false);
            this.grb_opcoes.ResumeLayout(false);
            this.pan_xml.ResumeLayout(false);
            this.pan_xml.PerformLayout();
            this.pan_file.ResumeLayout(false);
            this.pan_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.Panel pan_botoes;
        private System.Windows.Forms.Panel pan_opcoes;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox grb_opcoes;
        private System.Windows.Forms.Label lbl_xmlFile;
        private System.Windows.Forms.Panel pan_xml;
        private System.Windows.Forms.Button btn_xmlFile;
        private System.Windows.Forms.TextBox tbx_xml;
        private System.Windows.Forms.TextBox tbx_file;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Panel pan_file;
        private System.Windows.Forms.Label label1;
    }
}

