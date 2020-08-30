﻿using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace GalleryApp.Converters
{
    public class BytesToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var bytes = (byte[])value;

                var stream = new MemoryStream(bytes);

                return ImageSource.FromStream(() => stream);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
