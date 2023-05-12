
namespace CheckedListBoxExtensionsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CompaniesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetButton = new System.Windows.Forms.Button();
            this.ClearCheckedButton = new System.Windows.Forms.Button();
            this.GetButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompaniesCheckedListBox
            // 
            this.CompaniesCheckedListBox.FormattingEnabled = true;
            this.CompaniesCheckedListBox.Location = new System.Drawing.Point(14, 16);
            this.CompaniesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompaniesCheckedListBox.Name = "CompaniesCheckedListBox";
            this.CompaniesCheckedListBox.Size = new System.Drawing.Size(230, 290);
            this.CompaniesCheckedListBox.TabIndex = 0;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ResultsDataGridView.Location = new System.Drawing.Point(251, 16);
            this.ResultsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.RowHeadersWidth = 51;
            this.ResultsDataGridView.RowTemplate.Height = 25;
            this.ResultsDataGridView.Size = new System.Drawing.Size(346, 293);
            this.ResultsDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(605, 16);
            this.GetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(86, 31);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // ClearCheckedButton
            // 
            this.ClearCheckedButton.Location = new System.Drawing.Point(14, 317);
            this.ClearCheckedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearCheckedButton.Name = "ClearCheckedButton";
            this.ClearCheckedButton.Size = new System.Drawing.Size(231, 31);
            this.ClearCheckedButton.TabIndex = 3;
            this.ClearCheckedButton.Text = "Clear";
            this.ClearCheckedButton.UseVisualStyleBackColor = true;
            this.ClearCheckedButton.Click += new System.EventHandler(this.ClearCheckedButton_Click);
            // 
            // GetButton1
            // 
            this.GetButton1.Location = new System.Drawing.Point(605, 55);
            this.GetButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetButton1.Name = "GetButton1";
            this.GetButton1.Size = new System.Drawing.Size(86, 31);
            this.GetButton1.TabIndex = 4;
            this.GetButton1.Text = "Get";
            this.GetButton1.UseVisualStyleBackColor = true;
            this.GetButton1.Click += new System.EventHandler(this.GetButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.GetButton1);
            this.Controls.Add(this.ClearCheckedButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.CompaniesCheckedListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic CheckedListBox example";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CompaniesCheckedListBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ClearCheckedButton;
        private Button GetButton1;
    }
}

