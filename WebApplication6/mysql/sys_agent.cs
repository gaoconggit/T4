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
    /// sys_agent Entity Model
    /// </summary>    
   
    public class sys_agent
    {
        /// <summary>
        /// 
        /// </summary>

        public int id { get; set; }
    
        /// <summary>
        /// 创建时间 yyyy-MM-dd HH:mm:ss 创建时间
        /// </summary>

        public DateTime createtime { get; set; }
    
        /// <summary>
        /// 代理名称
        /// </summary>

        public string agentname { get; set; }
    
        /// <summary>
        /// 代理商编号
        /// </summary>

        public string agentcode { get; set; }
    
        /// <summary>
        /// 邮箱
        /// </summary>

        public string email { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>

        public string contacts { get; set; }
    
        /// <summary>
        /// 手机号
        /// </summary>

        public string phone { get; set; }
    
        /// <summary>
        /// 联系地址
        /// </summary>

        public string address { get; set; }
    
        /// <summary>
        /// 状态 0正常 1费率未配置 97 禁止商户入网 99关闭（删除）
        /// </summary>

        public int status { get; set; }
    
        /// <summary>
        /// 1 一级代理   2二级代理  
        /// </summary>

        public int type { get; set; }
    
        /// <summary>
        /// 更新时间
        /// </summary>

        public DateTime updatetime { get; set; }
    
        /// <summary>
        /// 描述
        /// </summary>

        public string description { get; set; }
    
        /// <summary>
        /// 关联通道表（b_passage）id，如有多个“，”用逗号隔开
        /// </summary>

        public string passageid { get; set; }
    
        /// <summary>
        /// 默认通道
        /// </summary>

        public int defaultpgid { get; set; }
    
        /// <summary>
        /// 上级代理id
        /// </summary>

        public int parentid { get; set; }
    }
}
