using DevNet.Common.DevNetExt;
using SLT.DAL;
using SLT.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:13:15
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/

namespace SLT.BLL
{
    #region====BLLAdminUser====
    /// <summary>
    /// AdminUser 表的业务逻辑类
    /// </summary>
    public class BLLAdminUser : BLLExt<AdminUser, SearchAdminUser>
    {

        //可以根据情况替换为工厂模式创建DAL类
        private readonly DALAdminUser dalAdminUser = new DALAdminUser();

        public BLLAdminUser()
        {
            base.TDALManager = dalAdminUser;
        }
        public AdminUser Login(string account, string pwd)
        {
            return dalAdminUser.Login(account, pwd);
        }
    }
    #endregion
}
