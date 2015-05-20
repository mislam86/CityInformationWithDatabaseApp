namespace CityInformationWithDatabaseApp.UI
{
    partial class CityInfoUI
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
            this.cityInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchByCountryRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByCityRadioButton = new System.Windows.Forms.RadioButton();
            this.showResultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.cityInformationGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityInformationGroupBox
            // 
            this.cityInformationGroupBox.Controls.Add(this.saveButton);
            this.cityInformationGroupBox.Controls.Add(this.countryTextBox);
            this.cityInformationGroupBox.Controls.Add(this.aboutTextBox);
            this.cityInformationGroupBox.Controls.Add(this.cityNameTextBox);
            this.cityInformationGroupBox.Controls.Add(this.label3);
            this.cityInformationGroupBox.Controls.Add(this.label2);
            this.cityInformationGroupBox.Controls.Add(this.label1);
            this.cityInformationGroupBox.Location = new System.Drawing.Point(103, 12);
            this.cityInformationGroupBox.Name = "cityInformationGroupBox";
            this.cityInformationGroupBox.Size = new System.Drawing.Size(338, 165);
            this.cityInformationGroupBox.TabIndex = 0;
            this.cityInformationGroupBox.TabStop = false;
            this.cityInformationGroupBox.Text = "City Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(212, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(104, 105);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(183, 20);
            this.countryTextBox.TabIndex = 2;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(104, 46);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(183, 53);
            this.aboutTextBox.TabIndex = 1;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(104, 20);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.cityNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchByCountryRadioButton);
            this.searchGroupBox.Controls.Add(this.searchByCityRadioButton);
            this.searchGroupBox.Controls.Add(this.showResultListView);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 183);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(529, 228);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchByCountryRadioButton
            // 
            this.searchByCountryRadioButton.AutoSize = true;
            this.searchByCountryRadioButton.Location = new System.Drawing.Point(68, 33);
            this.searchByCountryRadioButton.Name = "searchByCountryRadioButton";
            this.searchByCountryRadioButton.Size = new System.Drawing.Size(112, 17);
            this.searchByCountryRadioButton.TabIndex = 1;
            this.searchByCountryRadioButton.TabStop = true;
            this.searchByCountryRadioButton.Text = "Search by Country";
            this.searchByCountryRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByCityRadioButton
            // 
            this.searchByCityRadioButton.AutoSize = true;
            this.searchByCityRadioButton.Checked = true;
            this.searchByCityRadioButton.Location = new System.Drawing.Point(68, 9);
            this.searchByCityRadioButton.Name = "searchByCityRadioButton";
            this.searchByCityRadioButton.Size = new System.Drawing.Size(93, 17);
            this.searchByCityRadioButton.TabIndex = 0;
            this.searchByCityRadioButton.TabStop = true;
            this.searchByCityRadioButton.Text = "Search by City";
            this.searchByCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // showResultListView
            // 
            this.showResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.showResultListView.FullRowSelect = true;
            this.showResultListView.GridLines = true;
            this.showResultListView.Location = new System.Drawing.Point(6, 56);
            this.showResultListView.Name = "showResultListView";
            this.showResultListView.Size = new System.Drawing.Size(517, 166);
            this.showResultListView.TabIndex = 4;
            this.showResultListView.UseCompatibleStateImageBehavior = false;
            this.showResultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "About";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 87;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(384, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(195, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(183, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // CityInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 422);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.cityInformationGroupBox);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityInfoUI";
            this.Text = "City Information";
            this.cityInformationGroupBox.ResumeLayout(false);
            this.cityInformationGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cityInformationGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.ListView showResultListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton searchByCountryRadioButton;
        private System.Windows.Forms.RadioButton searchByCityRadioButton;
    }
}

