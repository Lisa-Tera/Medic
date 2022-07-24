using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drug2.Models
{
    public class DrugBasic    {
        //name = [x.findtext("ITEM_NAME") for x in item]
        //doc = [x.findtext("ETC_OTC_CODE") for x in item]
        //valid = [x.findtext("VALID_TERM")for x in item]
        //effect = [x.findtext("EE_DOC_DATA") for x in item]
        //dosage = [x.find("UD_DOC_DATA")for x in item]
        /// <summary>
        /// 품목명
        /// </summary>
        public string ITEM_NAME { get; set; }
        /// <summary>
        /// 전문일반
        /// </summary>
        public string ETC_OTC_CODE { get; set; }
        /// <summary>
        /// 유효기간
        /// </summary>
        public string VALID_TERM { get; set; }

        public string STORE { get; set; }
        /// <summary>
        /// 저장방법
        /// </summary>
        
        public string PROPERTIES { get; set; }
        /// <summary>
        /// 성상
        /// </summary>

        /// <summary>
        /// 효능효과 문서 데이터
        /// </summary>
        public string EE_DOC_DATA { get; set; }
        /// <summary>
        /// 용법용량 문서 데이터
        /// </summary>
        public string UD_DOC_DATA { get; set; }
        /// <summary>
        /// 주의사항(일반) 문서 데이터
        /// </summary>
        public string NB_DOC_DATA { get; set; }

    }
}