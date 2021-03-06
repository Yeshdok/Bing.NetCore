﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Bing.Applications.Dtos;

namespace Bing.DbDesigner.Service.Dtos.Projects {
    /// <summary>
    /// 项目数据传输对象
    /// </summary>
    public class ProjectDto : DtoBase {
        /// <summary>
        /// 解决方案标识
        /// </summary>
        [Required(ErrorMessage = "解决方案标识不能为空")]
        [Display( Name = "解决方案标识" )]
        [DataMember]
        public Guid SolutionId { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        [Required(ErrorMessage = "用户标识不能为空")]
        [Display( Name = "用户标识" )]
        [DataMember]
        public Guid UserId { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "编码不能为空")]
        [StringLength( 50, ErrorMessage = "编码输入过长，不能超过50位" )]
        [Display( Name = "编码" )]
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 200, ErrorMessage = "名称输入过长，不能超过200位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 缩写
        /// </summary>
        [StringLength( 200, ErrorMessage = "缩写输入过长，不能超过200位" )]
        [Display( Name = "缩写" )]
        [DataMember]
        public string Addreviation { get; set; }
        /// <summary>
        /// 授权码
        /// </summary>
        [StringLength( 50, ErrorMessage = "授权码输入过长，不能超过50位" )]
        [Display( Name = "授权码" )]
        [DataMember]
        public string AuthCode { get; set; }
        /// <summary>
        /// 授权密钥
        /// </summary>
        [StringLength( 200, ErrorMessage = "授权密钥输入过长，不能超过200位" )]
        [Display( Name = "授权密钥" )]
        [DataMember]
        public string AuthKey { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Display( Name = "启用" )]
        [DataMember]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Display( Name = "排序号" )]
        [DataMember]
        public int? SortId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}