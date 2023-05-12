using System.ComponentModel;
using CheckedListBoxExtensionsApp.Classes;
using CheckedListBoxExtensionsApp.Extensions;
using CheckedListBoxExtensionsApp.Models;
#pragma warning disable CS8622

namespace CheckedListBoxExtensionsApp;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();
    private readonly BindingList<Company> _bindingList = new();

    public Form1()
    {
        InitializeComponent();

        ResultsDataGridView.AutoGenerateColumns = false;

        Shown += OnShown;
    }

    private void OnShown(object sender, EventArgs e)
    {
        _bindingSource.DataSource = _bindingList;
        ResultsDataGridView.DataSource = _bindingSource;

        CompaniesCheckedListBox.DataSource = BogusOperations.Companies();
    }

    private void GetButton_Click(object sender, EventArgs e)
    {
        List<Company> result = CompaniesCheckedListBox.CheckedList<Company>();
        List<CheckedData<Company>> result1 = CompaniesCheckedListBox.IndexList<Company>();



        if (result.Count == 0)  
        {
            _bindingList.Clear();
            return;
        }

        foreach (var company in result)
        {
            if (!_bindingList.Contains(company))
            {
                _bindingList.Add(company);
            }

        }

        ResultsDataGridView.ExpandColumns();
    }
    private void GetButton1_Click(object sender, EventArgs e)
    {
        List<CheckedData<Company>> result = CompaniesCheckedListBox.IndexList<Company>();
        if (result.Count == 0)
        {
            _bindingList.Clear();
            return;
        }

        foreach (var data in result)
        {
            if (!_bindingList.Contains(data.Model))
            {
                _bindingList.Add(data.Model);
                CompaniesCheckedListBox.SetItemCheckState(data.Index, CheckState.Unchecked);
            }

        }
    }
    private void ClearCheckedButton_Click(object sender, EventArgs e)
    {
        CompaniesCheckedListBox.UnCheckAll();

        if (_bindingList.Count >0)
        {
            _bindingList.Clear();
        }
    }


}