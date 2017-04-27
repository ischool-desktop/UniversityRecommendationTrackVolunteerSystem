using System;
using System.Collections.Generic;
using System.Text;
using FISCA.UDT;

namespace 大學推甄校內志願選填系統
{
    static class 校系資料庫
    {
        private static Dictionary<string, 校系資料> _Items = null;
        public static Dictionary<string, 校系資料> Items { get { if (_Items == null)Sync(); return _Items; } }
        public static void Sync()
        {
            Dictionary<string, 校系資料> items = new Dictionary<string, 校系資料>();
            var list = new AccessHelper().Select<校系資料>();
            //new AccessHelper().DeletedValues(list as IEnumerable<ActiveRecord>);
            //list = null;
            list.Sort(delegate(校系資料 o1, 校系資料 o2)
            {
                return (o1.代碼.CompareTo(o2.代碼)) == 0 ? o1.UID.CompareTo(o2.UID) : (o1.代碼.CompareTo(o2.代碼));
            });
            foreach (var item in list)
            {
                //items.Add(item.代碼, item);
                // 2017/4/27 穎驊更新 處理 專案[03-03][03]demo 高中進入，會有當機現象。 發現是大學推甄校內志願選填模組 因為 校系資料存在相同的代碼 而造成資料整理Key值重覆錯誤的問題
                // 目前已將校系資料修正，且日後使用者自行再匯入時，代碼不得空白、與他校系重覆
                if (!items.ContainsKey(item.代碼)) 
                {
                    items.Add(item.代碼, item);                
                }
            }
            _Items = items;
        }
    }
}
