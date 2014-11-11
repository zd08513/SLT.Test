using DevNet.Common.DevNetExt;
using SLT.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/11 10:40:15
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

namespace SLT.DAL
{
    #region
    public class DALAdminMenu: DALExt<AdminMenu,SearchAdminMenu>{

		public override List<AdminMenu> GetList(SearchAdminMenu condition, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum){
			throw new NotImplementedException();
		}

		public override List<AdminMenu> GetList(SearchAdminMenu condition){
			throw new NotImplementedException();
		}
		public override List<AdminMenu> GetPageList(SearchAdminMenu condition, DevNet.Common.Pagination pagination, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum){
			//复杂的SQL语句可以使用存储过程实现
			Script.Select().ALL().From().Where();

			//请注意判断条件
			if(condition.ParentMenuID!=0){
				Script.Where(AdminMenu.ParentMenuID_FieldName, condition.ParentMenuID);
			}

			//请注意判断条件
			if(condition.MenuSort!=0){
				Script.Where(AdminMenu.MenuSort_FieldName, condition.MenuSort);
			}

			//请注意排序字段
			Script.AddOrderBy().OrderBy(sortFieldName, sortEnum);

			Script.PageIndex = pagination.PageIndex;
			Script.PageSize = pagination.PageSize;
			List<AdminMenu> lists = Script.GetList<AdminMenu>();
			pagination.RecordCount = Script.RecordCount;
			return lists;
		}
		public override List<AdminMenu> GetPageList(SearchAdminMenu condition, DevNet.Common.Pagination pagination){
			throw new NotImplementedException();
		}
		public override System.Data.DataTable GetPageTable(SearchAdminMenu condition, DevNet.Common.Pagination pagination, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum){
			throw new NotImplementedException();
		}
		public override System.Data.DataTable GetPageTable(SearchAdminMenu condition, DevNet.Common.Pagination pagination){
			throw new NotImplementedException();
		}
		public override System.Data.DataTable GetTable(SearchAdminMenu condition, string sortFieldName, DevNet.DBAccess.ScriptQuery.SortEnum sortEnum){
			throw new NotImplementedException();
		}
		public override System.Data.DataTable GetTable(SearchAdminMenu condition){
			throw new NotImplementedException();
		}
	}

	#endregion
}
