﻿namespace ZhonTai.Plate.Admin.Service.Permission.Input
{
    public class PermissionUpdateMenuInput : PermissionAddMenuInput
    {
        /// <summary>
        /// 权限Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public long Version { get; set; }
    }
}