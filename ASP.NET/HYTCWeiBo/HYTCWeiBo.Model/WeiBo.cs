using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYTCWeiBo.Model
{
    //t_WeiBo
    [Serializable]
    public class WeiBo
    {

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
        /// authorId
        /// </summary>		
        private int _authorid;
        public int authorId
        {
            get { return _authorid; }
            set { _authorid = value; }
        }
        /// <summary>
        /// authorName
        /// </summary>		
        private string _authorname;
        public string authorName
        {
            get { return _authorname; }
            set { _authorname = value; }
        }
        /// <summary>
        /// content
        /// </summary>		
        private string _content;
        public string content
        {
            get { return _content; }
            set { _content = value; }
        }
        /// <summary>
        /// isOriginal
        /// </summary>		
        private string _isOriginal;
        public string isOriginal
        {
            get { return _isOriginal; }
            set { _isOriginal = value; }
        }

        /// <summary>
        /// orAuthorId
        /// </summary>		
        private int _orAuthorId;
        public int orAuthorId
        {
            get { return _orAuthorId; }
            set { _orAuthorId = value; }
        }
        /// <summary>
        /// orAuthorName
        /// </summary>		
        private string _orAuthorName;
        public string orAuthorName
        {
            get { return _orAuthorName; }
            set { _orAuthorName = value; }
        }
        /// <summary>
        /// orContent
        /// </summary>		
        private string _orContent;
        public string orContent
        {
            get { return _orContent; }
            set { _orContent = value; }
        }
        /// <summary>
        /// orTime
        /// </summary>		
        private DateTime _orTime;
        public DateTime orTime
        {
            get { return _orTime; }
            set { _orTime = value; }
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
        /// <summary>
        /// zanNumber
        /// </summary>		
        private int _zannumber;
        public int zanNumber
        {
            get { return _zannumber; }
            set { _zannumber = value; }
        }
        /// <summary>
        /// reviewNumber
        /// </summary>		
        private int _reviewnumber;
        public int reviewNumber
        {
            get { return _reviewnumber; }
            set { _reviewnumber = value; }
        }
        /// <summary>
        /// transmitNumber
        /// </summary>		
        private int _transmitnumber;
        public int transmitNumber
        {
            get { return _transmitnumber; }
            set { _transmitnumber = value; }
        }
        /// <summary>
        /// favsNumber
        /// </summary>		
        private int _favsnumber;
        public int favsNumber
        {
            get { return _favsnumber; }
            set { _favsnumber = value; }
        }

    }
}
