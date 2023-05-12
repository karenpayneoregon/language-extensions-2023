using CheckedListBoxExtensionsApp.Models;

#pragma warning disable CS8618

namespace CheckedListBoxExtensionsApp.Extensions;

public static class CheckedListBoxExtensions
{
    /// <summary>
    /// Get checked items as <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Model</typeparam>
    /// <param name="sender">CheckedListBox</param>
    /// <returns>List if one or more items are checked</returns>
    public static List<T> CheckedList<T>(this CheckedListBox sender)
        => sender.Items.Cast<T>()
            .Where((item, index) => sender.GetItemChecked(index))
            .Select(item => item)
            .ToList();

    /// <summary>
    /// Uncheck all items
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    public static void UnCheckAll(this CheckedListBox sender)
    {
        foreach (int index in sender.CheckedIndices)
        {
            sender.SetItemCheckState(index, CheckState.Unchecked);
        }
    }

    /// <summary>
    /// Get all <typeparamref name="TModel"/> items
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    /// <returns></returns>
    public static List<CheckedData<TModel>> IndexList<TModel>(this CheckedListBox sender) =>
    (
        from item in sender.Items.Cast<TModel>()
            .Select(
                (model, index) =>
                    new CheckedData<TModel>
                    {
                        Index = index,
                        Model = model
                    }
            )
            .Where((x) 
                => sender.GetItemChecked(x.Index))
        select item
    ).ToList();
}