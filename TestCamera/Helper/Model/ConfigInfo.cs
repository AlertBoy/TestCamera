﻿namespace TestCamera
{
    public class ConfigInfo
    {
        #region 日志

        /// <summary>
        /// 使用写日志的KEY
        /// </summary>
        public string UseWriteLogKey = "NoKey";
        /// <summary>
        /// 写入标识日志
        /// </summary>
        public bool IsWriteStringLog = true;
        /// <summary>
        /// 写入异常日志
        /// </summary>
        public bool IsWriteErrorLog = true;
        /// <summary>
        /// 写入时间日志
        /// </summary>
        public bool IsWriteTimeLog = true;
        /// <summary>
        /// 将异常输出到单独文件
        /// </summary>
        public bool IsOneLogFileByException = false;
        /// <summary>
        /// 将时间输出到单独文件
        /// </summary>
        public bool IsOneLogFileByTime = false;
        /// <summary>
        /// 在字符串日志中添加异常标识
        /// </summary>
        public bool IsAddExceptionString = false;
        /// <summary>
        /// 输出日志等待时间
        /// </summary>
        public int WriteLogSleepTime = 1000;

        #endregion

        #region 提示

        /// <summary>
        /// 显示提示-Video_1
        /// </summary>
        public bool IsShowHint_Video_ReflectionOff = true;
        /// <summary>
        /// 显示提示-Video_2
        /// </summary>
        public bool IsShowHint_Video_ReflectionOn = true;
        /// <summary>
        /// 显示提示-Video_全景
        /// </summary>
        public bool IsShowHint_Video_Stitching = true;
        /// <summary>
        /// 显示提示-Image
        /// </summary>
        public bool IsShowHint_Image = true;
        /// <summary>
        /// 显示提示-Edit
        /// </summary>
        public bool IsShowHint_Edit = true;
        /// <summary>
        /// 显示提示-Crop
        /// </summary>
        public bool IsShowHint_Crop = true;
        /// <summary>
        /// 显示提示-Ocr
        /// </summary>
        public bool IsShowHint_Ocr = true;

        #endregion

        #region 初次进入

        /// <summary>
        /// 初次进入页面-VidePage
        /// </summary>
        public bool IsFirstInVidePage = true;
        /// <summary>
        /// 初次进入页面-ImagePage
        /// </summary>
        public bool IsFirstInImagePage = true;
        /// <summary>
        /// 初次进入页面-EditPage
        /// </summary>
        public bool IsFirstInEditPage = true;
        /// <summary>
        /// 初次进入页面-CropPage
        /// </summary>
        public bool IsFirstInCropPage = true;

        #endregion

        #region 其他

        /// <summary>
        /// 裁剪类型
        /// </summary>
        public string CropType = "Auto";
        /// <summary>
        /// 颜色等级
        /// </summary>
        public int ColorLevel = 0;
        /// <summary>
        /// 当前选择的OCR语言
        /// </summary>
        public string SelectedOcrLanguage = "";
        /// <summary>
        /// 编辑页面是否写入识别标识
        /// </summary>
        public bool EditPageIsWriteOcrTag = false;
        /// <summary>
        /// 是否显示提示面板
        /// </summary>
        public bool ImagePageIsShowSaveTip = true;
        /// <summary>
        /// 是否保存有字的PDF
        /// </summary>
        public bool ImagePageIsPdfWriteText = false;
        /// <summary>
        /// 是播放快门声音
        /// </summary>
        public bool IsPlayCaptureSound = true;
        /// <summary>
        /// 是否保留原始照片
        /// </summary>
        public bool IsKeepOriginal = true;
        /// <summary>
        /// 是上传OneDrive
        /// </summary>
        public bool IsOneDriveUpload = false;
        /// <summary>
        /// 已开启增强清晰度
        /// </summary>
        public bool IsOpenNoiseReduce = false;
        /// <summary>
        /// 已开启高分辨率扫描
        /// </summary>
        public bool IsOpenSuperResolution = false;
        /// <summary>
        /// 是否开启摩尔
        /// </summary>
        public bool IsOpenMoire = false;
        /// <summary>
        /// 已开启减少反光
        /// </summary>
        public bool IsOpenReflectionReduction = false;
        /// <summary>
        /// 摄像头分辨率宽度
        /// </summary>
        public uint CameraPhotoSizeWidth = 0;
        /// <summary>
        /// 摄像头分辨率高度
        /// </summary>
        public uint CameraPhotoSizeHeight = 0;
        /// <summary>
        /// 拍照模式标识
        /// </summary>
        public string CaptureModelTag = string.Empty;
        /// <summary>
        /// 是否显示测试图片
        /// </summary>
        public bool IsShowTestImage = false;
        /// <summary>
        /// 是否反转颜色
        /// </summary>
        public bool IsInvertColor = true;

        /// <summary>
        /// 是否指定保存的文件名
        /// </summary>
        public bool IsSpecifyFileName = true;

        /// <summary>
        /// 默认保存文件格式
        /// </summary>
        public int SaveFormatType;

        /// <summary>
        /// 是否保存
        /// </summary>
        ///public bool IsSaveTestMedia = true;

        #endregion
    }
}