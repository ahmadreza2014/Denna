﻿using Core.Domain;
using Realms;
using System;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace Denna.Converters
{
    public class TaskListToDonePercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var items = value as IRealmCollection<Todo>;
            var done = items.Where(x => x.Status == 0).Count();
            if (items.Count == 0 || done == 0)
                return 0.0;
            return Math.Round(done / (double)items.Count, 2) * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
