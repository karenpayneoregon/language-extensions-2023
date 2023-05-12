namespace CheckedListBoxExtensionsApp;

partial class Form2
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
            this.CompaniesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.PeekButton = new System.Windows.Forms.Button();
            this.ClearCheckedButton = new System.Windows.Forms.Button();
            this.ClearListBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompaniesCheckedListBox
            // 
            this.CompaniesCheckedListBox.FormattingEnabled = true;
            this.CompaniesCheckedListBox.Location = new System.Drawing.Point(12, 13);
            this.CompaniesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompaniesCheckedListBox.Name = "CompaniesCheckedListBox";
            this.CompaniesCheckedListBox.Size = new System.Drawing.Size(272, 290);
            this.CompaniesCheckedListBox.TabIndex = 1;
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Location = new System.Drawing.Point(290, 38);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(104, 29);
            this.MoveLeftButton.TabIndex = 3;
            this.MoveLeftButton.Text = ">>";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 20;
            this.ResultsListBox.Location = new System.Drawing.Point(400, 12);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(272, 284);
            this.ResultsListBox.Sorted = true;
            this.ResultsListBox.TabIndex = 4;
            // 
            // PeekButton
            // 
            this.PeekButton.Location = new System.Drawing.Point(400, 313);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(272, 29);
            this.PeekButton.TabIndex = 5;
            this.PeekButton.Text = "Iterate items";
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // ClearCheckedButton
            // 
            this.ClearCheckedButton.Location = new System.Drawing.Point(12, 313);
            this.ClearCheckedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearCheckedButton.Name = "ClearCheckedButton";
            this.ClearCheckedButton.Size = new System.Drawing.Size(272, 31);
            this.ClearCheckedButton.TabIndex = 6;
            this.ClearCheckedButton.Text = "Clear checked items";
            this.ClearCheckedButton.UseVisualStyleBackColor = true;
            this.ClearCheckedButton.Click += new System.EventHandler(this.ClearCheckedButton_Click);
            // 
            // ClearListBoxButton
            // 
            this.ClearListBoxButton.Location = new System.Drawing.Point(400, 349);
            this.ClearListBoxButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearListBoxButton.Name = "ClearListBoxButton";
            this.ClearListBoxButton.Size = new System.Drawing.Size(272, 31);
            this.ClearListBoxButton.TabIndex = 7;
            this.ClearListBoxButton.Text = "Clear list";
            this.ClearListBoxButton.UseVisualStyleBackColor = true;
            this.ClearListBoxButton.Click += new System.EventHandler(this.ClearListBoxButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 416);
            this.Controls.Add(this.ClearListBoxButton);
            this.Controls.Add(this.ClearCheckedButton);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.MoveLeftButton);
            this.Controls.Add(this.CompaniesCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mover";
            this.ResumeLayout(false);

    }

    #endregion

    private CheckedListBox CompaniesCheckedListBox;
    private Button MoveLeftButton;
    private ListBox ResultsListBox;
    private Button PeekButton;
    private Button ClearCheckedButton;
    private Button ClearListBoxButton;
}