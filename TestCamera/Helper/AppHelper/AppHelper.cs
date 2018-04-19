﻿namespace TestCamera
{
    /// <summary>
    /// 全局辅助者
    /// </summary>
    public static class AppHelper
    {
        /// <summary>
        /// 是否显示底部BAR
        /// </summary>
        public static bool IsShowBottomAppBar
        {
            get { return _IsShowBottomAppBar; }
            set
            {
                _IsShowBottomAppBar = value;
            }
        }
        private static bool _IsShowBottomAppBar;


        /// <summary>
        /// 摄像头缩放数字
        /// </summary>
        public static double CameraZoomNumber = 0;  

    }
}