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
    /// 数据表实体类：系统日志 (Sys_Log)
    /// </summary>
    [Serializable()]
    public partial class Sys_Log:BaseModel
    {
	   private string _F_Id;
       /// <summary>
       /// 日志主键
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
	   private DateTime? _F_Date;
       /// <summary>
       /// 日期
       /// </summary>  
        
       public DateTime? F_Date
	   { 
            get
            {
                BeforeGetProperty("F_Date", _F_Date);
                return _F_Date;
            }
            set
            {
                if(!BeforeSetProperty("F_Date", _F_Date))
                    return;
                _F_Date=value;
                AfterSetProperty("F_Date", _F_Date);
             }
		}
	   private string _F_Account;
       /// <summary>
       /// 用户名
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
	   private string _F_NickName;
       /// <summary>
       /// 姓名
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
	   private string _F_Type;
       /// <summary>
       /// 类型
       /// </summary>  
        
       public string F_Type
	   { 
            get
            {
                BeforeGetProperty("F_Type", _F_Type);
                return _F_Type;
            }
            set
            {
                if(!BeforeSetProperty("F_Type", _F_Type))
                    return;
                _F_Type=value;
                AfterSetProperty("F_Type", _F_Type);
             }
		}
	   private string _F_IPAddress;
       /// <summary>
       /// IP地址
       /// </summary>  
        
       public string F_IPAddress
	   { 
            get
            {
                BeforeGetProperty("F_IPAddress", _F_IPAddress);
                return _F_IPAddress;
            }
            set
            {
                if(!BeforeSetProperty("F_IPAddress", _F_IPAddress))
                    return;
                _F_IPAddress=value;
                AfterSetProperty("F_IPAddress", _F_IPAddress);
             }
		}
	   private string _F_IPAddressName;
       /// <summary>
       /// IP所在城市
       /// </summary>  
        
       public string F_IPAddressName
	   { 
            get
            {
                BeforeGetProperty("F_IPAddressName", _F_IPAddressName);
                return _F_IPAddressName;
            }
            set
            {
                if(!BeforeSetProperty("F_IPAddressName", _F_IPAddressName))
                    return;
                _F_IPAddressName=value;
                AfterSetProperty("F_IPAddressName", _F_IPAddressName);
             }
		}
	   private string _F_ModuleId;
       /// <summary>
       /// 系统模块Id
       /// </summary>  
        
       public string F_ModuleId
	   { 
            get
            {
                BeforeGetProperty("F_ModuleId", _F_ModuleId);
                return _F_ModuleId;
            }
            set
            {
                if(!BeforeSetProperty("F_ModuleId", _F_ModuleId))
                    return;
                _F_ModuleId=value;
                AfterSetProperty("F_ModuleId", _F_ModuleId);
             }
		}
	   private string _F_ModuleName;
       /// <summary>
       /// 系统模块
       /// </summary>  
        
       public string F_ModuleName
	   { 
            get
            {
                BeforeGetProperty("F_ModuleName", _F_ModuleName);
                return _F_ModuleName;
            }
            set
            {
                if(!BeforeSetProperty("F_ModuleName", _F_ModuleName))
                    return;
                _F_ModuleName=value;
                AfterSetProperty("F_ModuleName", _F_ModuleName);
             }
		}
	   private bool? _F_Result;
       /// <summary>
       /// 结果
       /// </summary>  
        
       public bool? F_Result
	   { 
            get
            {
                BeforeGetProperty("F_Result", _F_Result);
                return _F_Result;
            }
            set
            {
                if(!BeforeSetProperty("F_Result", _F_Result))
                    return;
                _F_Result=value;
                AfterSetProperty("F_Result", _F_Result);
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
    }
}

