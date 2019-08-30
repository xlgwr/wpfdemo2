﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>  
    /// 路径转图片  
    /// </summary>  
    public class PathToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string url = (string)value;
            return (new BitmapImage(new Uri(url, UriKind.Relative)));
        } 

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        } 
    }
}
