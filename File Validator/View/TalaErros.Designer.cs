namespace View
{
    partial class TalaErros
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
            this.pan_footer = new System.Windows.Forms.Panel();
            this.pan_webview = new System.Windows.Forms.Panel();
            this.grb_webView = new System.Windows.Forms.GroupBox();
            this.web_view = new System.Windows.Forms.WebBrowser();
            this.btn_copiar = new System.Windows.Forms.Button();
            this.pan_completo.SuspendLayout();
            this.pan_footer.SuspendLayout();
            this.pan_webview.SuspendLayout();
            this.grb_webView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.pan_webview);
            this.pan_completo.Controls.Add(this.pan_footer);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(464, 214);
            this.pan_completo.TabIndex = 0;
            // 
            // pan_footer
            // 
            this.pan_footer.Controls.Add(this.btn_copiar);
            this.pan_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_footer.Location = new System.Drawing.Point(0, 181);
            this.pan_footer.Name = "pan_footer";
            this.pan_footer.Size = new System.Drawing.Size(464, 33);
            this.pan_footer.TabIndex = 0;
            // 
            // pan_webview
            // 
            this.pan_webview.Controls.Add(this.grb_webView);
            this.pan_webview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_webview.Location = new System.Drawing.Point(0, 0);
            this.pan_webview.Name = "pan_webview";
            this.pan_webview.Size = new System.Drawing.Size(464, 181);
            this.pan_webview.TabIndex = 1;
            // 
            // grb_webView
            // 
            this.grb_webView.Controls.Add(this.web_view);
            this.grb_webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_webView.Location = new System.Drawing.Point(0, 0);
            this.grb_webView.Name = "grb_webView";
            this.grb_webView.Size = new System.Drawing.Size(464, 181);
            this.grb_webView.TabIndex = 0;
            this.grb_webView.TabStop = false;
            this.grb_webView.Text = "Listagem de linhas incorretas";
            // 
            // web_view
            // 
            this.web_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_view.Location = new System.Drawing.Point(3, 16);
            this.web_view.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_view.Name = "web_view";
            this.web_view.Size = new System.Drawing.Size(458, 162);
            this.web_view.TabIndex = 0;
            // 
            // btn_copiar
            // 
            this.btn_copiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar.Location = new System.Drawing.Point(386, 6);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(75, 23);
            this.btn_copiar.TabIndex = 1;
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.UseVisualStyleBackColor = true;
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // TalaErros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(464, 214);
            this.Controls.Add(this.pan_completo);
            this.MinimizeBox = false;
            this.Name = "TalaErros";
            this.ShowIcon = false;
            this.Text = "Linhas incorretas";
            this.pan_completo.ResumeLayout(false);
            this.pan_footer.ResumeLayout(false);
            this.pan_webview.ResumeLayout(false);
            this.grb_webView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.Panel pan_footer;
        private System.Windows.Forms.Panel pan_webview;
        private System.Windows.Forms.GroupBox grb_webView;
        private System.Windows.Forms.WebBrowser web_view;
        private System.Windows.Forms.Button btn_copiar;
    }
}