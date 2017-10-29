namespace Arduino_Pedelec_Configurator
{
    partial class FormInputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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

        /// <summary>
        /// Legt den Fenstertext fest oder gibt diesen zurück.
        /// </summary>
        public string WindowTitle
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        /// <summary>
        /// Legt die Benutzereingabe fest oder gibt diese zurück
        /// </summary>
        public decimal kilometers
        {
            get { return nud_kilometers.Value; }
            set { nud_kilometers.Value = value; }
        }

        /// <summary>
        /// Initialisiert die InputBox mit den übergebenen Werten
        /// </summary>
        /// <param name="Description">Beschreibung, die über dem Eingabefeld steht</param>
        /// <param name="Fenstertext"></param>
        /// <param name="Default">Vorgegebene Benutzereingabe</param>
        public FormInputBox(string windowtitle, int kilometers)
            : this()
        {
            this.WindowTitle = windowtitle;
            if (kilometers<32000)
                nud_kilometers.Value = kilometers;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nud_kilometers = new System.Windows.Forms.NumericUpDown();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kilometers)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_kilometers
            // 
            this.nud_kilometers.Location = new System.Drawing.Point(64, 12);
            this.nud_kilometers.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nud_kilometers.Name = "nud_kilometers";
            this.nud_kilometers.Size = new System.Drawing.Size(67, 20);
            this.nud_kilometers.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(15, 48);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "Set";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(103, 48);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // FormInputBox
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(196, 83);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.nud_kilometers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInputBox";
            ((System.ComponentModel.ISupportInitialize)(this.nud_kilometers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_kilometers;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
    }
}