using DevNet.Common;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:17:26
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;

namespace SLT.Entity
{
    #region====SearchAdminUser ====
    /// <summary>
    /// 表 AdminUser 的查询类
    /// </summary>
    [Serializable]
    public class SearchAdminUser : SearchBaseInfo
    {
        #region====查询属性 请自行根据项目具体情况添加查询属性====
        private string _UserAccount = string.Empty;
        private string _UserPwd = string.Empty;
        /// <summary>
        /// UserAccount 列
        /// </summary>
        public string UserAccount
        {
            get
            {
                return _UserAccount;
            }
            set
            {
                _UserAccount = value;
            }
        }
        /// <summary>
        /// UserPwd 列
        /// </summary>
        public string UserPwd
        {
            get
            {
                return _UserPwd;
            }
            set
            {
                _UserPwd = value;
            }
        }

        #endregion
    }
    #endregion
}
