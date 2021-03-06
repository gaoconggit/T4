//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//       生成时间 2018-08-09 23:01:48 by 大聪哥
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;


namespace T4.Entities
{
    /// <summary>
    /// sys_inst Entity Model
    /// </summary>    
   
    public class sys_inst
    {
        /// <summary>
        /// 三方机构信息
        /// </summary>

        public int id { get; set; }
    
        /// <summary>
        /// 机构类型：1收呗，2第三方
        /// </summary>

        public int type { get; set; }
    
        /// <summary>
        /// 机构角色类型：1 平台  2 一级代理  3二级代理  4bd  5商户
        /// </summary>

        public int inst_type { get; set; }
    
        /// <summary>
        /// 机构号
        /// </summary>

        public string inst_no { get; set; }
    
        /// <summary>
        /// 机构名称
        /// </summary>

        public string inst_name { get; set; }
    
        /// <summary>
        /// 是否需要签名，1需要签名，2不需要签名
        /// </summary>

        public int is_sign { get; set; }
    
        /// <summary>
        /// 是否需要创建后台账户，会校验唯一，1需要，2不需要
        /// </summary>

        public int is_user { get; set; }
    
        /// <summary>
        /// 令牌 主要做校验用
        /// </summary>

        public string token { get; set; }
    
        /// <summary>
        /// 机构状态，1正常，98封停，99删除
        /// </summary>

        public int status { get; set; }
    
        /// <summary>
        /// 对账单： 0不下载    1下载 
        /// </summary>

        public int order_status { get; set; }
    
        /// <summary>
        /// 创建时间 yyyy-MM-dd HH:mm:ss
        /// </summary>

        public DateTime create_time { get; set; }
    
        /// <summary>
        /// 更新时间,yyyy-MM-dd HH:mm:ss
        /// </summary>

        public DateTime update_time { get; set; }
    
        /// <summary>
        /// 支付回调
        /// </summary>

        public string pay_notify_url { get; set; }
    
        /// <summary>
        /// 商户回调
        /// </summary>

        public string mch_notify_url { get; set; }
    
        /// <summary>
        /// 外部角色id
        /// </summary>

        public int fid { get; set; }
    }
}
