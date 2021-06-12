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

    [Table(Register.DATABASE_PREFIX + nameof(Video))]//必须添加前缀，防止全系统中发生冲突
    [Serializable]
    public class Video : EntityBase<int>
    {
        public Video()
        {
            this.UserId = 0;
            this.CourseId = 0;
            this.Title = "";
            this.Slug = "";
            this.Url = "";
            this.Charge = 0;
            this.ViewNum = 0;
            this.ShortDescription = "";
            this.OriginalDesc = "";
            this.RenderDesc = "";
            this.SeoKeywords = "";
            this.SeoDescription = "";
            this.PublishedAt = DateTime.Now; ;
            this.IsShow = 0;
            this.AliyunVideoId = "";
            this.ChapterId = 0;
            this.Duration = 0;
            this.TencentVideoId = "";
            this.IsBanSell = 0;
            this.CommentStatus = 0;
            this.FreeSeconds = 0;
            this.PlayerPC = "";
            this.PlayerH5 = "";
            this.BanDrag = 0;
            this.Flag = false;
            this.AddTime = DateTime.Now; ;
            this.AddUserId = 0;
            this.AddUserName = "";
            this.LastUpdateTime = DateTime.Now; ;
            this.UpdateUserId = 0;
            this.UpdateUserName = "";
            this.AdminRemark = "";
            this.Remark = "";
            this.TenantId = 0;
            this.deleted_at = DateTime.Now; ;

        }
        public Video(AddOrUpdateVideoReq req)
        {
            this.UserId = req.UserId;
            this.CourseId = req.CourseId;
            this.Title = req.Title;
            this.Slug = req.Slug;
            this.Url = req.Url;
            this.Charge = req.Charge;
            this.ViewNum = req.ViewNum;
            this.ShortDescription = req.ShortDescription;
            this.OriginalDesc = req.OriginalDesc;
            this.RenderDesc = req.RenderDesc;
            this.SeoKeywords = req.SeoKeywords;
            this.SeoDescription = req.SeoDescription;
            this.PublishedAt = req.PublishedAt;
            this.IsShow = req.IsShow;
            this.AliyunVideoId = req.AliyunVideoId;
            this.ChapterId = req.ChapterId;
            this.Duration = req.Duration;
            this.TencentVideoId = req.TencentVideoId;
            this.IsBanSell = req.IsBanSell;
            this.CommentStatus = req.CommentStatus;
            this.FreeSeconds = req.FreeSeconds;
            this.PlayerPC = req.PlayerPC;
            this.PlayerH5 = req.PlayerH5;
            this.BanDrag = req.BanDrag;
            this.Flag = req.Flag;
            this.AddTime = req.AddTime;
            this.AddUserId = req.AddUserId;
            this.AddUserName = req.AddUserName;
            this.LastUpdateTime = req.LastUpdateTime;
            this.UpdateUserId = req.UpdateUserId;
            this.UpdateUserName = req.UpdateUserName;
            this.AdminRemark = req.AdminRemark;
            this.Remark = req.Remark;
            this.TenantId = req.TenantId;
            this.deleted_at = req.deleted_at;

        }

        /// <summary>
        ///用户ID
        /// </summary>
        [Description("用户ID")]
        public int UserId { get; set; }

        /// <summary>
        ///课程ID
        /// </summary>
        [Description("课程ID")]
        public int CourseId { get; set; }

        /// <summary>
        ///标题
        /// </summary>
        [Description("标题")]
        public string Title { get; set; }

        /// <summary>
        ///slug
        /// </summary>
        [Description("slug")]
        public string Slug { get; set; }

        /// <summary>
        ///播放地址
        /// </summary>
        [Description("播放地址")]
        public string Url { get; set; }

        /// <summary>
        ///价格
        /// </summary>
        [Description("价格")]
        public int Charge { get; set; }

        /// <summary>
        ///观看次数
        /// </summary>
        [Description("观看次数")]
        public int ViewNum { get; set; }

        /// <summary>
        ///简短介绍
        /// </summary>
        [Description("简短介绍")]
        public string ShortDescription { get; set; }

        /// <summary>
        ///简介原始内容
        /// </summary>
        [Description("简介原始内容")]
        public string OriginalDesc { get; set; }

        /// <summary>
        ///简介渲染后的内容
        /// </summary>
        [Description("简介渲染后的内容")]
        public string RenderDesc { get; set; }

        /// <summary>
        ///SEO关键字
        /// </summary>
        [Description("SEO关键字")]
        public string SeoKeywords { get; set; }

        /// <summary>
        ///SEO描述
        /// </summary>
        [Description("SEO描述")]
        public string SeoDescription { get; set; }

        /// <summary>
        ///上线时间
        /// </summary>
        [Description("上线时间")]
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        ///1显示,-1隐藏
        /// </summary>
        [Description("1显示,-1隐藏")]
        public byte IsShow { get; set; }

        /// <summary>
        ///阿里云视频ID
        /// </summary>
        [Description("阿里云视频ID")]
        public string AliyunVideoId { get; set; }

        /// <summary>
        ///章节ID
        /// </summary>
        [Description("章节ID")]
        public int ChapterId { get; set; }

        /// <summary>
        ///时长，单位：秒
        /// </summary>
        [Description("时长，单位：秒")]
        public int Duration { get; set; }

        /// <summary>
        ///腾讯云video_id
        /// </summary>
        [Description("腾讯云video_id")]
        public string TencentVideoId { get; set; }

        /// <summary>
        ///禁止售卖,0否,1是
        /// </summary>
        [Description("禁止售卖,0否,1是")]
        public byte IsBanSell { get; set; }

        /// <summary>
        ///0禁止评论,1所有人,2仅购买
        /// </summary>
        [Description("0禁止评论,1所有人,2仅购买")]
        public byte CommentStatus { get; set; }

        /// <summary>
        ///试看秒数
        /// </summary>
        [Description("试看秒数")]
        public int FreeSeconds { get; set; }

        /// <summary>
        ///pc播放器
        /// </summary>
        [Description("pc播放器")]
        public string PlayerPC { get; set; }

        /// <summary>
        ///h5播放器
        /// </summary>
        [Description("h5播放器")]
        public string PlayerH5 { get; set; }

        /// <summary>
        ///禁止拖动,0否,1是
        /// </summary>
        [Description("禁止拖动,0否,1是")]
        public byte BanDrag { get; set; }

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