//------------------------------------------------------------------------------
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:feng yuan
//------------------------------------------------------------------------------
using Senparc.Ncf.Core.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Senparc.Xncf.MaQueKeTang.Request;

namespace Senparc.Xncf.MaQueKeTang
{
    /// <summary>
///实体类
/// </summary>

    [Table(Register.DATABASE_PREFIX + nameof(VideoUser))]//必须添加前缀，防止全系统中发生冲突
    [Serializable]
    public class VideoUser : EntityBase<int>
    {
    public VideoUser()
    {
           this.Id=0;
       this.UserId=0;
       this.VideoId=0;
       this.Charge=0;
       this.Flag=false;
       this.AddTime=DateTime.Now;;
       this.AddUserId=0;
       this.AddUserName="";
       this.LastUpdateTime=DateTime.Now;;
       this.UpdateUserId=0;
       this.UpdateUserName="";
       this.AdminRemark="";
       this.Remark="";
       this.TenantId=0;
       this.deleted_at=DateTime.Now;;

    }
    public VideoUser(AddOrUpdateVideoUserReq req)
    {
           this.Id= req.Id;
       this.UserId= req.UserId;
       this.VideoId= req.VideoId;
       this.Charge= req.Charge;
       this.Flag= req.Flag;
       this.AddTime= req.AddTime;
       this.AddUserId= req.AddUserId;
       this.AddUserName= req.AddUserName;
       this.LastUpdateTime= req.LastUpdateTime;
       this.UpdateUserId= req.UpdateUserId;
       this.UpdateUserName= req.UpdateUserName;
       this.AdminRemark= req.AdminRemark;
       this.Remark= req.Remark;
       this.TenantId= req.TenantId;
       this.deleted_at= req.deleted_at;

    }

    /// <summary>
       ///ID
       /// </summary>
       [Description("ID")]
       public int Id { get; set; }

       /// <summary>
       ///用户ID
       /// </summary>
       [Description("用户ID")]
       public int UserId { get; set; }

       /// <summary>
       ///视频ID
       /// </summary>
       [Description("视频ID")]
       public int VideoId { get; set; }

       /// <summary>
       ///收费
       /// </summary>
       [Description("收费")]
       public int Charge { get; set; }

       /// <summary>
       ///删除状态
       /// </summary>
       [Description("删除状态")]
       public bool Flag { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Description("添加时间")]
       public DateTime AddTime { get; set; }

       /// <summary>
       ///添加者ID
       /// </summary>
       [Description("添加者ID")]
       public int? AddUserId { get; set; }

       /// <summary>
       ///添加者姓名
       /// </summary>
       [Description("添加者姓名")]
       public string AddUserName { get; set; }

       /// <summary>
       ///最后修改时间
       /// </summary>
       [Description("最后修改时间")]
       public DateTime LastUpdateTime { get; set; }

       /// <summary>
       ///更新者ID
       /// </summary>
       [Description("更新者ID")]
       public int? UpdateUserId { get; set; }

       /// <summary>
       ///更新者姓名
       /// </summary>
       [Description("更新者姓名")]
       public string UpdateUserName { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Description("备注")]
       public string AdminRemark { get; set; }

       /// <summary>
       ///说明
       /// </summary>
       [Description("说明")]
       public string Remark { get; set; }

       /// <summary>
       ///租户Id
       /// </summary>
       [Description("租户Id")]
       public int TenantId { get; set; }

       /// <summary>
       ///删除时间
       /// </summary>
       [Description("删除时间")]
       public DateTime? deleted_at { get; set; }

       
    }
    }