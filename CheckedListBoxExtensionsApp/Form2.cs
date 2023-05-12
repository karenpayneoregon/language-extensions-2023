using System.ComponentModel;
using System.Diagnostics;
using CheckedListBoxExtensionsApp.Classes;
using CheckedListBoxExtensionsApp.Extensions;
using CheckedListBoxExtensionsApp.Models;

namespace CheckedListBoxExtensionsApp;
public partial class Form2 : Form
{
    private readonly BindingSource _bindingSourceRight = new();
    protected BindingList<Company> _bindingListRight = new();
    public Form2()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    private void OnShown(object? sender, EventArgs e)
    {
        _bindingSourceRight.DataSource = _bindingListRight;
        ResultsListBox.DataSource = _bindingListRight;
        CompaniesCheckedListBox.DataSource = BogusOperations.Companies();
    }

    private void MoveLeftButton_Click(object sender, EventArgs e)
    {
        /*
         * The list box sorted property is set to true
         */
        List<CheckedData<Company>> result = CompaniesCheckedListBox.IndexList<Company>();
        if (result.Count == 0)
        {
            _bindingListRight.Clear();
            return;
        }

        foreach (var data in result)
        {
            if (_bindingListRight.Contains(data.Model)) continue;
            _bindingListRight.Add(data.Model);
            CompaniesCheckedListBox.SetItemCheckState(data.Index, CheckState.Unchecked);

        }
    }

    private void PeekButton_Click(object sender, EventArgs e)
    {
        if (_bindingListRight.Count > 0)
        {
            foreach (var company in _bindingListRight)
            {
                Debug.WriteLine($"{company.Id, -4}{company.Name}");
            }

            Debug.WriteLine("");
        }
    }

    private void ClearCheckedButton_Click(object sender, EventArgs e)
    {
        CompaniesCheckedListBox.UnCheckAll();
    }

    private void ClearListBoxButton_Click(object sender, EventArgs e)
    {
        if (_bindingListRight.Count > 0)
        {
            _bindingListRight.Clear();
        }
    }
}
