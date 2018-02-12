using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeItemorderQueryResponse.
    /// </summary>
    public class KoubeiTradeItemorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务产品
        /// </summary>
        [JsonProperty("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 买家支付宝账户
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("item_order_vo")]
        public List<ItemOrderVO> ItemOrderVo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝账号
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonProperty("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单状态, INIT（初始状态）,WAIT_PAY (待支付)，PAID（已支付），SUCCESS（订单成功-已打款给商户），FINISH（订单完成-全额退款）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
