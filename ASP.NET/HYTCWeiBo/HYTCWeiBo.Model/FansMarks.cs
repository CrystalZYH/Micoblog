using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYTCWeiBo.Model
{
    public class FansMarks
    {

        /// <summary>
        /// markId
        /// </summary>		
        private int _markid;
        public int markId
        {
            get { return _markid; }
            set { _markid = value; }
        }
        /// <summary>
        /// onselfId
        /// </summary>		
        private int _onselfId;
        public int onselfId
        {
            get { return _onselfId; }
            set { _onselfId = value; }
        }
        /// <summary>
        /// otherId
        /// </summary>		
        private int _otherId;
        public int otherId
        {
            get { return _otherId; }
            set { _otherId = value; }
        }
        /// <summary>
        /// createTime
        /// </summary>		
        private DateTime _createtime;
        public DateTime createTime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }

    }

}
