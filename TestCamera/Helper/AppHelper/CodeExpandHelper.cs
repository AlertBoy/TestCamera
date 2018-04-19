﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace TestCamera
{
    public static class CodeExpandHelper
    {
        /// <summary>
        /// (FindControls)查找类型控件
        /// </summary>
        public static T FC<T>(this DependencyObject panel) where T : DependencyObject
        {
            T resObj = null;
            int childCount = VisualTreeHelper.GetChildrenCount(panel);
            for (int i = 0; i < childCount; i++)
            {
                var childObj = VisualTreeHelper.GetChild(panel, i);
                if (childObj == null) { continue; }
                resObj = childObj as T;
                if (resObj == null) { resObj = childObj.FC<T>(); }
                if (resObj != null) { break; }
            }
            return resObj;
        }
    }
}