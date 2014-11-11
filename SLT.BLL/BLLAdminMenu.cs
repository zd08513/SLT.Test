using DevNet.Common.DevNetExt;
using SLT.DAL;
using SLT.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/11 10:41:04
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

namespace SLT.BLL
{
    #region====BLLAdminMenu====
    /// <summary>
    /// AdminMenu 表的业务逻辑类
    /// </summary>
    public class BLLAdminMenu : BLLExt<AdminMenu, SearchAdminMenu>
    {

        //可以根据情况替换为工厂模式创建DAL类
        private readonly DALAdminMenu dalAdminMenu = new DALAdminMenu();

        public BLLAdminMenu()
        {
            base.TDALManager = dalAdminMenu;
        }

    }
    #endregion
}
