using DevNet.Common.DevNetExt;
using SLT.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:15:56
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;

namespace SLT.DAL
{
    #region====DALAdminUser====
    /// <summary>
    /// AdminUser 表的数据类
    /// </summary>
    public class DALAdminUser : DALExt<AdminUser, SearchAdminUser>
    {

        public override List<AdminUser> GetList(SearchAdminUser condition, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum)
        {
            throw new NotImplementedException();
        }

        public override List<AdminUser> GetList(SearchAdminUser condition)
        {
            throw new NotImplementedException();
        }
        public override List<AdminUser> GetPageList(SearchAdminUser condition, DevNet.Common.Pagination pagination, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum)
        {
            //复杂的SQL语句可以使用存储过程实现
            Script.Select().ALL().From().Where();

            //请注意Like的条件
            if (!string.IsNullOrEmpty(condition.UserAccount))
            {
                Script.Like(AdminUser.UserAccount_FieldName, condition.UserAccount);
            }

            //请注意Like的条件
            if (!string.IsNullOrEmpty(condition.UserPwd))
            {
                Script.Like(AdminUser.UserPwd_FieldName, condition.UserPwd);
            }

            //请注意排序字段
            Script.AddOrderBy().OrderBy(sortFieldName, sortEnum);

            Script.PageIndex = pagination.PageIndex;
            Script.PageSize = pagination.PageSize;
            List<AdminUser> lists = Script.GetList<AdminUser>();
            pagination.RecordCount = Script.RecordCount;
            return lists;
        }
        public override List<AdminUser> GetPageList(SearchAdminUser condition, DevNet.Common.Pagination pagination)
        {
            throw new NotImplementedException();
        }
        public override System.Data.DataTable GetPageTable(SearchAdminUser condition, DevNet.Common.Pagination pagination, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum)
        {
            throw new NotImplementedException();
        }
        public override System.Data.DataTable GetPageTable(SearchAdminUser condition, DevNet.Common.Pagination pagination)
        {
            throw new NotImplementedException();
        }
        public override System.Data.DataTable GetTable(SearchAdminUser condition, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum)
        {
            throw new NotImplementedException();
        }
        public override System.Data.DataTable GetTable(SearchAdminUser condition)
        {
            throw new NotImplementedException();
        }
        public AdminUser Login(string account, string pwd)
        {
            AdminUser obj = this.GetSingle(new string[] { AdminUser.UserAccount_FieldName, AdminUser.UserPwd_FieldName }, new object[] { account, pwd });
            if (obj != null)
            {
                obj.UserDate = DateTime.Now;
                this.Update(obj);
            }
            return obj;
        }
    }

    #endregion
}
