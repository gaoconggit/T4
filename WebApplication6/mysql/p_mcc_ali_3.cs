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
    /// p_mcc_ali_3 Entity Model
    /// </summary>    
   
    public class p_mcc_ali_3
    {
        /// <summary>
        /// 
        /// </summary>

        public int id { get; set; }
    
        /// <summary>
        /// 一级类目
        /// </summary>

        public string firstname { get; set; }
    
        /// <summary>
        /// 二级类目
        /// </summary>

        public string secondname { get; set; }
    
        /// <summary>
        /// 三级类目
        /// </summary>

        public string thirdname { get; set; }
    
        /// <summary>
        /// 证照类型
        /// </summary>

        public string licensetype { get; set; }
    
        /// <summary>
        /// 品类id
        /// </summary>

        public string code { get; set; }
    
        /// <summary>
        /// 外链微信2级类目
        /// </summary>

        public int ali2_id { get; set; }
    }
}