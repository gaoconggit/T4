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
    /// sys_merchant_shop Entity Model
    /// </summary>    
   
    public class sys_merchant_shop
    {
        /// <summary>
        /// 自动编号
        /// </summary>

        public long Id { get; set; }
    
        /// <summary>
        /// 0 正常  99删除
        /// </summary>

        public int status { get; set; }
    
        /// <summary>
        /// 商户id
        /// </summary>

        public int merchant_id { get; set; }
    
        /// <summary>
        /// 门店编号
        /// </summary>

        public string shop_no { get; set; }
    
        /// <summary>
        /// 门店名称
        /// </summary>

        public string shop_name { get; set; }
    
        /// <summary>
        /// 门店电话
        /// </summary>

        public string shop_tel { get; set; }
    
        /// <summary>
        /// 门店地址
        /// </summary>

        public string shop_address { get; set; }
    
        /// <summary>
        /// 店长姓名
        /// </summary>

        public string manager_name { get; set; }
    
        /// <summary>
        /// 店长手机
        /// </summary>

        public string manager_mobile { get; set; }
    
        /// <summary>
        /// 店长支付宝
        /// </summary>

        public string manager_alipay { get; set; }
    
        /// <summary>
        /// 设为主门店
        /// </summary>

        public int is_current { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime create_time { get; set; }
    }
}
