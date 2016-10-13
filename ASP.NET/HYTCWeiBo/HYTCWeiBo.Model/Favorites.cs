using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYTCWeiBo.Model
{
    public class Favorites
    {

        /// <summary>
        /// favoriteId
        /// </summary>		
        private int _favoriteid;
        public int favoriteId
        {
            get { return _favoriteid; }
            set { _favoriteid = value; }
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
        /// favPersonId
        /// </summary>		
        private int _favPersonId;
        public int favPersonId
        {
            get { return _favPersonId; }
            set { _favPersonId = value; }
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
