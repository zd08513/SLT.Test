using DevNet.Common.DevNetExt;
using DevNet.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:11:44
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace SLT.Entity
{
    #region====AdminUserEntity====
    /// <summary>
    /// 表 AdminUser 的实体类
    /// </summary>
    [Serializable]
    public partial class AdminUser : EntityBase,IEntity
    {
        /// <summary>
        ///  AdminUser 构造函数
        /// </summary>
        public AdminUser()
        {
            Ini();
        }

        /// <summary>
        ///  AdminUser 构造函数
        /// </summary>
        public AdminUser(bool isIni)
        {
            if (isIni)
            {
                Ini();
            }
        }

        void Ini()
        {
            base.IniMember(
                new string[]{ID_FieldName,
						UserAccount_FieldName,
						UserPwd_FieldName,
						TrueName_FieldName,
						Sex_FieldName,
						DepartmentId_FieldName,
						UserMobil_FieldName,
						Phone_FieldName,
						UserDate_FieldName,
						Flag_FieldName,
						AdminRoleID_FieldName},
                new object[]{ 0,
						 string.Empty,
						 string.Empty,
						 string.Empty,
						 0,
						 0,
						 string.Empty,
						 string.Empty,
						 DateTime.Now,
						 0,
						 0});
            base.TableName = AdminUser_TableName;
            base.AutoIncrements = AutoIncrement;
            base.PrimaryKeyFields = PrimaryKeyField;
        }


        #region====数据表名称、主键字段名称、数据表字段名称、自动增长型字段名称
        /// <summary>
        /// 表 AdminUser 数据表名称
        /// </summary>
        public const string AdminUser_TableName = "AdminUser";

        /// <summary>
        /// 表AdminUser 主键字段
        /// </summary>
        public readonly static string[] PrimaryKeyField = new string[] { "ID" };

        /// <summary>
        /// 表AdminUser 自动增长型字段名称  --Oracle、SQLite、Access2007等数据库请注意该常量值的手动设置
        /// </summary>
        public const string AutoIncrement = "ID";

        /// <summary>
        /// ID 字段名称
        /// </summary>
        public const string ID_FieldName = "ID";
        /// <summary>
        /// UserAccount 字段名称
        /// </summary>
        public const string UserAccount_FieldName = "UserAccount";
        /// <summary>
        /// UserPwd 字段名称
        /// </summary>
        public const string UserPwd_FieldName = "UserPwd";
        /// <summary>
        /// TrueName 字段名称
        /// </summary>
        public const string TrueName_FieldName = "TrueName";
        /// <summary>
        /// Sex 字段名称
        /// </summary>
        public const string Sex_FieldName = "Sex";
        /// <summary>
        /// DepartmentId 字段名称
        /// </summary>
        public const string DepartmentId_FieldName = "DepartmentId";
        /// <summary>
        /// UserMobil 字段名称
        /// </summary>
        public const string UserMobil_FieldName = "UserMobil";
        /// <summary>
        /// Phone 字段名称
        /// </summary>
        public const string Phone_FieldName = "Phone";
        /// <summary>
        /// UserDate 字段名称
        /// </summary>
        public const string UserDate_FieldName = "UserDate";
        /// <summary>
        /// Flag 字段名称
        /// </summary>
        public const string Flag_FieldName = "Flag";
        /// <summary>
        /// AdminRoleID 字段名称
        /// </summary>
        public const string AdminRoleID_FieldName = "AdminRoleID";

        #endregion

        #region====字段属性====
        /// <summary>
        /// ID 列
        /// </summary>
        public int? ID
        {
            get
            {
                return Convert.ToInt32(GetProperty(ID_FieldName));
            }
            set
            {
                SetProperty(ID_FieldName, value);
            }
        }
        /// <summary>
        /// UserAccount 列
        /// </summary>
        public string UserAccount
        {
            get
            {
                return Convert.ToString(GetProperty(UserAccount_FieldName));
            }
            set
            {
                SetProperty(UserAccount_FieldName, value);
            }
        }
        /// <summary>
        /// UserPwd 列
        /// </summary>
        public string UserPwd
        {
            get
            {
                return Convert.ToString(GetProperty(UserPwd_FieldName));
            }
            set
            {
                SetProperty(UserPwd_FieldName, value);
            }
        }
        /// <summary>
        /// TrueName 列
        /// </summary>
        public string TrueName
        {
            get
            {
                return Convert.ToString(GetProperty(TrueName_FieldName));
            }
            set
            {
                SetProperty(TrueName_FieldName, value);
            }
        }
        /// <summary>
        /// Sex 列
        /// </summary>
        public int? Sex
        {
            get
            {
                return Convert.ToInt32(GetProperty(Sex_FieldName));
            }
            set
            {
                SetProperty(Sex_FieldName, value);
            }
        }
        /// <summary>
        /// DepartmentId 列
        /// </summary>
        public int? DepartmentId
        {
            get
            {
                return Convert.ToInt32(GetProperty(DepartmentId_FieldName));
            }
            set
            {
                SetProperty(DepartmentId_FieldName, value);
            }
        }
        /// <summary>
        /// UserMobil 列
        /// </summary>
        public string UserMobil
        {
            get
            {
                return Convert.ToString(GetProperty(UserMobil_FieldName));
            }
            set
            {
                SetProperty(UserMobil_FieldName, value);
            }
        }
        /// <summary>
        /// Phone 列
        /// </summary>
        public string Phone
        {
            get
            {
                return Convert.ToString(GetProperty(Phone_FieldName));
            }
            set
            {
                SetProperty(Phone_FieldName, value);
            }
        }
        /// <summary>
        /// UserDate 列
        /// </summary>
        public DateTime? UserDate
        {
            get
            {
                return Convert.ToDateTime(GetProperty(UserDate_FieldName));
            }
            set
            {
                SetProperty(UserDate_FieldName, value);
            }
        }
        /// <summary>
        /// Flag 列
        /// </summary>
        public int? Flag
        {
            get
            {
                return Convert.ToInt32(GetProperty(Flag_FieldName));
            }
            set
            {
                SetProperty(Flag_FieldName, value);
            }
        }
        /// <summary>
        /// AdminRoleID 列
        /// </summary>
        public int? AdminRoleID
        {
            get
            {
                return Convert.ToInt32(GetProperty(AdminRoleID_FieldName));
            }
            set
            {
                SetProperty(AdminRoleID_FieldName, value);
            }
        }

        #endregion

        #region=====表关系属性，可以手动将实体类作为该实体的属性====


        #endregion

        int IEntity.ID
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    #endregion
}
