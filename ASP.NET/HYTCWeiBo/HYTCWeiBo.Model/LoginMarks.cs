using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYTCWeiBo.Model
{
    public class LoginMarks
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
        /// userId
        /// </summary>		
        private int _userid;
        public int userId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// loginTime
        /// </summary>		
        private DateTime _logintime;
        public DateTime loginTime
        {
            get { return _logintime; }
            set { _logintime = value; }
        }
        /// <summary>
        /// userName
        /// </summary>		
        private string _username;
        public string userName
        {
            get { return _username; }
            set { _username = value; }
        }

    }
}
