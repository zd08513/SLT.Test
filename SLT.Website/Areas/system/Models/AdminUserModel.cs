/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:23:47
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SLT.Website.Areas.system.Models
{
    public class AdminUserModel
    {
        [DisplayName("用户名")]
        [Required(ErrorMessage="{0}不能为空！")]
        public string UserAccount { get; set; }

        [DisplayName("密码")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage="{0}不能为空！")]
        public string UserPwd { get; set; }
    }
}