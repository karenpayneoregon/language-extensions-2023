﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLibrary;
public static class TimeOnlyExtensions
{
    /// <summary>
    /// Format a <see cref="TimeOnly"/> with AM PM
    /// </summary>
    /// <param name="sender">TimeSpan to format</param>
    /// <param name="format">Optional format</param>
    public static string Formatted(this TimeOnly sender, string format = "hh:mm tt")
        => sender.ToString(format);

    /// <summary>
    /// Clean method for separating time parts
    /// </summary>
    public static void Deconstruct(this TimeOnly time, out int hour, out int minutes, out int seconds, out int milliseconds)
        => (hour, minutes, seconds, milliseconds) = (time.Hour, time.Minute, time.Second, time.Microsecond);

    public static void Deconstruct(this TimeOnly time, out int hour, out int minutes, out int seconds)
        => (hour, minutes, seconds) = (time.Hour, time.Minute, time.Second);
}
