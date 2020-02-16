namespace PNY.ASPNET20.WinUI
{
    partial class frmCountryList
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
            this.grdCountries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCountries
            // 
            this.grdCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCountries.Location = new System.Drawing.Point(12, 12);
            this.grdCountries.Name = "grdCountries";
            this.grdCountries.Size = new System.Drawing.Size(240, 150);
            this.grdCountries.TabIndex = 0;
            // 
            // frmCountryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCountries);
            this.Name = "frmCountryList";
            this.Text = "Country List";
            ((System.ComponentModel.ISupportInitialize)(this.grdCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCountries;
    }
}