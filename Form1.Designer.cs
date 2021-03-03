
namespace Task2Cities
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.listCountries = new System.Windows.Forms.ListBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(134, 198);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 198);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(122, 247);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // listCountries
            // 
            this.listCountries.FormattingEnabled = true;
            this.listCountries.ItemHeight = 16;
            this.listCountries.Items.AddRange(new object[] {
            "New Zealand",
            "Australia"});
            this.listCountries.Location = new System.Drawing.Point(198, 247);
            this.listCountries.Name = "listCountries";
            this.listCountries.Size = new System.Drawing.Size(137, 84);
            this.listCountries.TabIndex = 3;
            this.listCountries.SelectedIndexChanged += new System.EventHandler(this.listCountries_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(148, 365);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // comboCity
            // 
            this.comboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(198, 362);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(137, 24);
            this.comboCity.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(230, 426);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(148, 68);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(164, 17);
            this.lbltitle.TabIndex = 7;
            this.lbltitle.Text = "Tell us where do you live";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 605);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.listCountries);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ListBox listCountries;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbltitle;
    }
}

