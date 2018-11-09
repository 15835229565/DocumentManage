//------------------------------------------------------------------------------
// <auto-generated>
//     此代码从T4模板生成。
//     黄正辉（623128629@qq.com）
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace DM.Domain
{
    /// <summary>	
    /// 数据表实体类：用户表 (Sys_User)
    /// </summary>
    [Serializable()]
    public partial class Sys_User:BaseModel
    {
	   private string _F_Id;
       /// <summary>
       /// 用户主键
       /// </summary>  
       [Key] 
       public string F_Id
	   { 
            get
            {
                BeforeGetProperty("F_Id", _F_Id);
                return _F_Id;
            }
            set
            {
                if(!BeforeSetProperty("F_Id", _F_Id))
                    return;
                _F_Id=value;
                AfterSetProperty("F_Id", _F_Id);
             }
		}
	   private string _F_Account;
       /// <summary>
       /// 账户
       /// </summary>  
        
       public string F_Account
	   { 
            get
            {
                BeforeGetProperty("F_Account", _F_Account);
                return _F_Account;
            }
            set
            {
                if(!BeforeSetProperty("F_Account", _F_Account))
                    return;
                _F_Account=value;
                AfterSetProperty("F_Account", _F_Account);
             }
		}
	   private string _F_RealName;
       /// <summary>
       /// 姓名
       /// </summary>  
        
       public string F_RealName
	   { 
            get
            {
                BeforeGetProperty("F_RealName", _F_RealName);
                return _F_RealName;
            }
            set
            {
                if(!BeforeSetProperty("F_RealName", _F_RealName))
                    return;
                _F_RealName=value;
                AfterSetProperty("F_RealName", _F_RealName);
             }
		}
	   private string _F_NickName;
       /// <summary>
       /// 呢称
       /// </summary>  
        
       public string F_NickName
	   { 
            get
            {
                BeforeGetProperty("F_NickName", _F_NickName);
                return _F_NickName;
            }
            set
            {
                if(!BeforeSetProperty("F_NickName", _F_NickName))
                    return;
                _F_NickName=value;
                AfterSetProperty("F_NickName", _F_NickName);
             }
		}
	   private string _F_HeadIcon;
       /// <summary>
       /// 头像
       /// </summary>  
        
       public string F_HeadIcon
	   { 
            get
            {
                BeforeGetProperty("F_HeadIcon", _F_HeadIcon);
                return _F_HeadIcon;
            }
            set
            {
                if(!BeforeSetProperty("F_HeadIcon", _F_HeadIcon))
                    return;
                _F_HeadIcon=value;
                AfterSetProperty("F_HeadIcon", _F_HeadIcon);
             }
		}
	   private bool? _F_Gender;
       /// <summary>
       /// 性别
       /// </summary>  
        
       public bool? F_Gender
	   { 
            get
            {
                BeforeGetProperty("F_Gender", _F_Gender);
                return _F_Gender;
            }
            set
            {
                if(!BeforeSetProperty("F_Gender", _F_Gender))
                    return;
                _F_Gender=value;
                AfterSetProperty("F_Gender", _F_Gender);
             }
		}
	   private DateTime? _F_Birthday;
       /// <summary>
       /// 生日
       /// </summary>  
        
       public DateTime? F_Birthday
	   { 
            get
            {
                BeforeGetProperty("F_Birthday", _F_Birthday);
                return _F_Birthday;
            }
            set
            {
                if(!BeforeSetProperty("F_Birthday", _F_Birthday))
                    return;
                _F_Birthday=value;
                AfterSetProperty("F_Birthday", _F_Birthday);
             }
		}
	   private string _F_MobilePhone;
       /// <summary>
       /// 手机
       /// </summary>  
        
       public string F_MobilePhone
	   { 
            get
            {
                BeforeGetProperty("F_MobilePhone", _F_MobilePhone);
                return _F_MobilePhone;
            }
            set
            {
                if(!BeforeSetProperty("F_MobilePhone", _F_MobilePhone))
                    return;
                _F_MobilePhone=value;
                AfterSetProperty("F_MobilePhone", _F_MobilePhone);
             }
		}
	   private string _F_Email;
       /// <summary>
       /// 邮箱
       /// </summary>  
        
       public string F_Email
	   { 
            get
            {
                BeforeGetProperty("F_Email", _F_Email);
                return _F_Email;
            }
            set
            {
                if(!BeforeSetProperty("F_Email", _F_Email))
                    return;
                _F_Email=value;
                AfterSetProperty("F_Email", _F_Email);
             }
		}
	   private string _F_WeChat;
       /// <summary>
       /// 微信
       /// </summary>  
        
       public string F_WeChat
	   { 
            get
            {
                BeforeGetProperty("F_WeChat", _F_WeChat);
                return _F_WeChat;
            }
            set
            {
                if(!BeforeSetProperty("F_WeChat", _F_WeChat))
                    return;
                _F_WeChat=value;
                AfterSetProperty("F_WeChat", _F_WeChat);
             }
		}
	   private string _F_ManagerId;
       /// <summary>
       /// 主管主键
       /// </summary>  
        
       public string F_ManagerId
	   { 
            get
            {
                BeforeGetProperty("F_ManagerId", _F_ManagerId);
                return _F_ManagerId;
            }
            set
            {
                if(!BeforeSetProperty("F_ManagerId", _F_ManagerId))
                    return;
                _F_ManagerId=value;
                AfterSetProperty("F_ManagerId", _F_ManagerId);
             }
		}
	   private int? _F_SecurityLevel;
       /// <summary>
       /// 安全级别
       /// </summary>  
        
       public int? F_SecurityLevel
	   { 
            get
            {
                BeforeGetProperty("F_SecurityLevel", _F_SecurityLevel);
                return _F_SecurityLevel;
            }
            set
            {
                if(!BeforeSetProperty("F_SecurityLevel", _F_SecurityLevel))
                    return;
                _F_SecurityLevel=value;
                AfterSetProperty("F_SecurityLevel", _F_SecurityLevel);
             }
		}
	   private string _F_Signature;
       /// <summary>
       /// 个性签名
       /// </summary>  
        
       public string F_Signature
	   { 
            get
            {
                BeforeGetProperty("F_Signature", _F_Signature);
                return _F_Signature;
            }
            set
            {
                if(!BeforeSetProperty("F_Signature", _F_Signature))
                    return;
                _F_Signature=value;
                AfterSetProperty("F_Signature", _F_Signature);
             }
		}
	   private string _F_OrganizeId;
       /// <summary>
       /// 组织主键
       /// </summary>  
        
       public string F_OrganizeId
	   { 
            get
            {
                BeforeGetProperty("F_OrganizeId", _F_OrganizeId);
                return _F_OrganizeId;
            }
            set
            {
                if(!BeforeSetProperty("F_OrganizeId", _F_OrganizeId))
                    return;
                _F_OrganizeId=value;
                AfterSetProperty("F_OrganizeId", _F_OrganizeId);
             }
		}
	   private string _F_DepartmentId;
       /// <summary>
       /// 部门主键
       /// </summary>  
        
       public string F_DepartmentId
	   { 
            get
            {
                BeforeGetProperty("F_DepartmentId", _F_DepartmentId);
                return _F_DepartmentId;
            }
            set
            {
                if(!BeforeSetProperty("F_DepartmentId", _F_DepartmentId))
                    return;
                _F_DepartmentId=value;
                AfterSetProperty("F_DepartmentId", _F_DepartmentId);
             }
		}
	   private string _F_RoleId;
       /// <summary>
       /// 角色主键
       /// </summary>  
        
       public string F_RoleId
	   { 
            get
            {
                BeforeGetProperty("F_RoleId", _F_RoleId);
                return _F_RoleId;
            }
            set
            {
                if(!BeforeSetProperty("F_RoleId", _F_RoleId))
                    return;
                _F_RoleId=value;
                AfterSetProperty("F_RoleId", _F_RoleId);
             }
		}
	   private string _F_DutyId;
       /// <summary>
       /// 岗位主键
       /// </summary>  
        
       public string F_DutyId
	   { 
            get
            {
                BeforeGetProperty("F_DutyId", _F_DutyId);
                return _F_DutyId;
            }
            set
            {
                if(!BeforeSetProperty("F_DutyId", _F_DutyId))
                    return;
                _F_DutyId=value;
                AfterSetProperty("F_DutyId", _F_DutyId);
             }
		}
	   private bool? _F_IsAdministrator;
       /// <summary>
       /// 是否管理员
       /// </summary>  
        
       public bool? F_IsAdministrator
	   { 
            get
            {
                BeforeGetProperty("F_IsAdministrator", _F_IsAdministrator);
                return _F_IsAdministrator;
            }
            set
            {
                if(!BeforeSetProperty("F_IsAdministrator", _F_IsAdministrator))
                    return;
                _F_IsAdministrator=value;
                AfterSetProperty("F_IsAdministrator", _F_IsAdministrator);
             }
		}
	   private int? _F_SortCode;
       /// <summary>
       /// 排序码
       /// </summary>  
        
       public int? F_SortCode
	   { 
            get
            {
                BeforeGetProperty("F_SortCode", _F_SortCode);
                return _F_SortCode;
            }
            set
            {
                if(!BeforeSetProperty("F_SortCode", _F_SortCode))
                    return;
                _F_SortCode=value;
                AfterSetProperty("F_SortCode", _F_SortCode);
             }
		}
	   private bool? _F_DeleteMark;
       /// <summary>
       /// 删除标志
       /// </summary>  
        
       public bool? F_DeleteMark
	   { 
            get
            {
                BeforeGetProperty("F_DeleteMark", _F_DeleteMark);
                return _F_DeleteMark;
            }
            set
            {
                if(!BeforeSetProperty("F_DeleteMark", _F_DeleteMark))
                    return;
                _F_DeleteMark=value;
                AfterSetProperty("F_DeleteMark", _F_DeleteMark);
             }
		}
	   private bool? _F_EnabledMark;
       /// <summary>
       /// 有效标志
       /// </summary>  
        
       public bool? F_EnabledMark
	   { 
            get
            {
                BeforeGetProperty("F_EnabledMark", _F_EnabledMark);
                return _F_EnabledMark;
            }
            set
            {
                if(!BeforeSetProperty("F_EnabledMark", _F_EnabledMark))
                    return;
                _F_EnabledMark=value;
                AfterSetProperty("F_EnabledMark", _F_EnabledMark);
             }
		}
	   private string _F_Description;
       /// <summary>
       /// 描述
       /// </summary>  
        
       public string F_Description
	   { 
            get
            {
                BeforeGetProperty("F_Description", _F_Description);
                return _F_Description;
            }
            set
            {
                if(!BeforeSetProperty("F_Description", _F_Description))
                    return;
                _F_Description=value;
                AfterSetProperty("F_Description", _F_Description);
             }
		}
	   private DateTime? _F_CreatorTime;
       /// <summary>
       /// 创建时间
       /// </summary>  
        
       public DateTime? F_CreatorTime
	   { 
            get
            {
                BeforeGetProperty("F_CreatorTime", _F_CreatorTime);
                return _F_CreatorTime;
            }
            set
            {
                if(!BeforeSetProperty("F_CreatorTime", _F_CreatorTime))
                    return;
                _F_CreatorTime=value;
                AfterSetProperty("F_CreatorTime", _F_CreatorTime);
             }
		}
	   private string _F_CreatorUserId;
       /// <summary>
       /// 创建用户
       /// </summary>  
        
       public string F_CreatorUserId
	   { 
            get
            {
                BeforeGetProperty("F_CreatorUserId", _F_CreatorUserId);
                return _F_CreatorUserId;
            }
            set
            {
                if(!BeforeSetProperty("F_CreatorUserId", _F_CreatorUserId))
                    return;
                _F_CreatorUserId=value;
                AfterSetProperty("F_CreatorUserId", _F_CreatorUserId);
             }
		}
	   private DateTime? _F_LastModifyTime;
       /// <summary>
       /// 最后修改时间
       /// </summary>  
        
       public DateTime? F_LastModifyTime
	   { 
            get
            {
                BeforeGetProperty("F_LastModifyTime", _F_LastModifyTime);
                return _F_LastModifyTime;
            }
            set
            {
                if(!BeforeSetProperty("F_LastModifyTime", _F_LastModifyTime))
                    return;
                _F_LastModifyTime=value;
                AfterSetProperty("F_LastModifyTime", _F_LastModifyTime);
             }
		}
	   private string _F_LastModifyUserId;
       /// <summary>
       /// 最后修改用户
       /// </summary>  
        
       public string F_LastModifyUserId
	   { 
            get
            {
                BeforeGetProperty("F_LastModifyUserId", _F_LastModifyUserId);
                return _F_LastModifyUserId;
            }
            set
            {
                if(!BeforeSetProperty("F_LastModifyUserId", _F_LastModifyUserId))
                    return;
                _F_LastModifyUserId=value;
                AfterSetProperty("F_LastModifyUserId", _F_LastModifyUserId);
             }
		}
	   private DateTime? _F_DeleteTime;
       /// <summary>
       /// 删除时间
       /// </summary>  
        
       public DateTime? F_DeleteTime
	   { 
            get
            {
                BeforeGetProperty("F_DeleteTime", _F_DeleteTime);
                return _F_DeleteTime;
            }
            set
            {
                if(!BeforeSetProperty("F_DeleteTime", _F_DeleteTime))
                    return;
                _F_DeleteTime=value;
                AfterSetProperty("F_DeleteTime", _F_DeleteTime);
             }
		}
	   private string _F_DeleteUserId;
       /// <summary>
       /// 删除用户
       /// </summary>  
        
       public string F_DeleteUserId
	   { 
            get
            {
                BeforeGetProperty("F_DeleteUserId", _F_DeleteUserId);
                return _F_DeleteUserId;
            }
            set
            {
                if(!BeforeSetProperty("F_DeleteUserId", _F_DeleteUserId))
                    return;
                _F_DeleteUserId=value;
                AfterSetProperty("F_DeleteUserId", _F_DeleteUserId);
             }
		}
    }
}

