using DevNet.Common;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/11 10:41:42
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLT.Entity
{
    #region====SearchAdminMenu ====
    /// <summary>
    /// 表 AdminMenu 的查询类
    /// </summary>
    [Serializable]
    public class SearchAdminMenu : SearchBaseInfo
    {
        #region====查询属性 请自行根据项目具体情况添加查询属性====
        private int _ParentMenuID = 0;
        private int _MenuSort = 0;
        /// <summary>
        /// ParentMenuID 列
        /// </summary>
        public int ParentMenuID
        {
            get
            {
                return _ParentMenuID;
            }
            set
            {
                _ParentMenuID = value;
            }
        }
        /// <summary>
        /// MenuSort 列
        /// </summary>
        public int MenuSort
        {
            get
            {
                return _MenuSort;
            }
            set
            {
                _MenuSort = value;
            }
        }

        #endregion
    }
    #endregion
}
