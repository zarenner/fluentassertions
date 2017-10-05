﻿using System.Threading.Tasks;

namespace FluentAssertions.Formatting
{
    /// <summary>
    /// Provides a human readable version of a generic or non-generic <see cref="Task"/> 
    /// including its state.
    /// </summary>
    public class TaskFormatter : IValueFormatter
    {
        public bool CanHandle(object value)
        {
            return value is Task;
        }

        public string Format(object value, FormattingContext context, FormatChild formatChild)
        {
            var task = value as Task;
            
            if (!ReferenceEquals(task, null))
            {
                return $"{formatChild("type", task.GetType())} {{Status={task.Status}}}"; 
            }
            else
            {
                return "<null>";
            }
        }
    }
}