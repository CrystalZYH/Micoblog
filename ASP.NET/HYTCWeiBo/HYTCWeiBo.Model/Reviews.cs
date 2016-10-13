using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYTCWeiBo.Model
{
    public class Reviews
    {

        /// <summary>
        /// reviewId
        /// </summary>		
        private int _reviewid;
        public int reviewId
        {
            get { return _reviewid; }
            set { _reviewid = value; }
        }
        /// <summary>
        /// weiboId
        /// </summary>		
        private int _weiboid;
        public int weiboId
        {
            get { return _weiboid; }
            set { _weiboid = value; }
        }
        /// <summary>
        /// reAuthorId
        /// </summary>		
        private int _reAuthorid;
        public int reAuthorId
        {
            get { return _reAuthorid; }
            set { _reAuthorid = value; }
        }
        /// <summary>
        /// reAuthorName
        /// </summary>		
        private string _reauthorname;
        public string reAuthorName
        {
            get { return _reauthorname; }
            set { _reauthorname = value; }
        }
        /// <summary>
        /// returnContent
        /// </summary>		
        private string _returncontent;
        public string returnContent
        {
            get { return _returncontent; }
            set { _returncontent = value; }
        }
        /// <summary>
        /// reTime
        /// </summary>		
        private DateTime _reTime;
        public DateTime reTime
        {
            get { return _reTime; }
            set { _reTime = value; }
        }


    }
}
