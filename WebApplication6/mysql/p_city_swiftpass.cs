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
    /// p_city_swiftpass Entity Model
    /// </summary>    
   
    public class p_city_swiftpass
    {
        /// <summary>
        /// 威富通城市地区代码
        /// </summary>

        public int id { get; set; }
    
        /// <summary>
        /// 威富通市名称
        /// </summary>

        public string name { get; set; }
    
        /// <summary>
        /// 
        /// </summary>

        public string code { get; set; }
    
        /// <summary>
        /// 富友市 名称
        /// </summary>

        public string fy_code { get; set; }
    
        /// <summary>
        /// 
        /// </summary>

        public int province_id { get; set; }
    }
}
