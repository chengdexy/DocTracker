using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTracker.Model
{
    /// <summary>
    /// official document
    /// </summary>
    class Doc
    {
        public int ID { get; set; }
        //文件名
        public string Title { get; set; }
        //文号
        public string DocNumber { get; set; }
        //来文时间
        public DateTime ReceiveDate { get; set; }
        //发文时间
        public DateTime SendDate { get; set; }
        //年号
        public int YearNumber { get; set; }
        //密级
        public SecretLevel SecretLv { get; set; }
        //份数
        public int Copies { get; set; }
        //分发范围
        public string Scope { get; set; }
        //备注
        public string Remark { get; set; }

        //对应此doc的所有流转操作
        public List<Oper> Opers { get; set; }
    }

    enum SecretLevel
    {
        /// <summary>
        /// 无密级
        /// </summary>
        NoSecret = 0,
        /// <summary>
        /// 秘密
        /// </summary>
        LowSecret = 1,
        /// <summary>
        /// 机密
        /// </summary>
        NormalSecret = 2,
        /// <summary>
        /// 绝密
        /// </summary>
        HighSecret = 3
    }
}
