using DevNet.Common.DevNetExt;
using DevNet.Entity;
/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/11 10:35:39
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
    #region====AdminMenuEntity====
    /// <summary>
    /// 表 AdminMenu 的实体类
    /// </summary>
    [Serializable]
    public partial class AdminMenu : EntityBase,IEntity
    {
        /// <summary>
        ///  AdminMenu 构造函数
        /// </summary>
        public AdminMenu()
        {
            Ini();
        }

        /// <summary>
        ///  AdminMenu 构造函数
        /// </summary>
        public AdminMenu(bool isIni)
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
						MenuName_FieldName,
						MenuUrl_FieldName,
						ParentMenuID_FieldName,
						MenuSort_FieldName,
						Flag_FieldName},
                new object[]{ 0,
						 string.Empty,
						 string.Empty,
						 0,
						 0,
						 0});
            base.TableName = AdminMenu_TableName;
            base.AutoIncrements = AutoIncrement;
            base.PrimaryKeyFields = PrimaryKeyField;
        }


        #region====数据表名称、主键字段名称、数据表字段名称、自动增长型字段名称
        /// <summary>
        /// 表 AdminMenu 数据表名称
        /// </summary>
        public const string AdminMenu_TableName = "AdminMenu";

        /// <summary>
        /// 表AdminMenu 主键字段
        /// </summary>
        public readonly static string[] PrimaryKeyField = new string[] { "ID" };

        /// <summary>
        /// 表AdminMenu 自动增长型字段名称  --Oracle、SQLite、Access2007等数据库请注意该常量值的手动设置
        /// </summary>
        public const string AutoIncrement = "ID";

        /// <summary>
        /// ID 字段名称
        /// </summary>
        public const string ID_FieldName = "ID";
        /// <summary>
        /// MenuName 字段名称
        /// </summary>
        public const string MenuName_FieldName = "MenuName";
        /// <summary>
        /// MenuUrl 字段名称
        /// </summary>
        public const string MenuUrl_FieldName = "MenuUrl";
        /// <summary>
        /// ParentMenuID 字段名称
        /// </summary>
        public const string ParentMenuID_FieldName = "ParentMenuID";
        /// <summary>
        /// MenuSort 字段名称
        /// </summary>
        public const string MenuSort_FieldName = "MenuSort";
        /// <summary>
        /// Flag 字段名称
        /// </summary>
        public const string Flag_FieldName = "Flag";

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
        /// MenuName 列
        /// </summary>
        public string MenuName
        {
            get
            {
                return Convert.ToString(GetProperty(MenuName_FieldName));
            }
            set
            {
                SetProperty(MenuName_FieldName, value);
            }
        }
        /// <summary>
        /// MenuUrl 列
        /// </summary>
        public string MenuUrl
        {
            get
            {
                return Convert.ToString(GetProperty(MenuUrl_FieldName));
            }
            set
            {
                SetProperty(MenuUrl_FieldName, value);
            }
        }
        /// <summary>
        /// ParentMenuID 列
        /// </summary>
        public int? ParentMenuID
        {
            get
            {
                return Convert.ToInt32(GetProperty(ParentMenuID_FieldName));
            }
            set
            {
                SetProperty(ParentMenuID_FieldName, value);
            }
        }
        /// <summary>
        /// MenuSort 列
        /// </summary>
        public int? MenuSort
        {
            get
            {
                return Convert.ToInt32(GetProperty(MenuSort_FieldName));
            }
            set
            {
                SetProperty(MenuSort_FieldName, value);
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
