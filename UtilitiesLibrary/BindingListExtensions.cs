﻿using System.ComponentModel;

namespace UtilitiesLibrary;
public static class BindingListExtensions
{
    /// <summary>
    /// Add range of <see cref="T"/> without raising RaiseListChangedEvents event
    /// </summary>
    /// <typeparam name="T">Model</typeparam>
    /// <param name="list">List of <see cref="T"/></param>
    /// <param name="data">Add to add</param>
    public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
    {
        if (list is null || data is null) { return; }

        try
        {
            list.RaiseListChangedEvents = false;
            foreach (T item in data)
            {
                list.Add(item);
            }
        }
        finally
        {
            list.RaiseListChangedEvents = true;
        }
    }
}
