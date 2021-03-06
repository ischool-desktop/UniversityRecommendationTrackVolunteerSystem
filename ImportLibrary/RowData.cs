﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 大學推甄校內志願選填系統.ImportLibrary
{
    /// <summary>
    /// 要匯入的一筆資料
    /// </summary>
    public class RowData : SortedList<string, string>
    {
        private string _ID = "";

        /// <summary>
        /// 編號
        /// </summary>
        public string ID { get { return _ID; } set { _ID = value; } }
    }
}
