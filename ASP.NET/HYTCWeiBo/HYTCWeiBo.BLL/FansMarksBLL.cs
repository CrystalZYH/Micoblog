using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
   public  class FansMarksBLL
    {
       FansMarksDAL dll = new FansMarksDAL();
        //插入 关注记录
        public bool save(FansMarks f)
        {
            return dll.save(f);
        }

        //删除关注记录(根据markId)
        public bool deleteBymarkId(int id)
        {
            return dll.deleteBymarkId(id);
        }
        //删除关注记录(根据onselfId)--删除用户时一起操作
        public bool deleteByonselfId(int id)
        {
            return dll.deleteByonselfId(id);
        }
        //删除粉丝记录(根据otherId)--删除用户时一起操作
        public bool deleteByotherId(int id)
        {
            return dll.deleteByotherId(id);
        }

        //根据onselfId，otherId查询是否存在关注记录
        public FansMarks findFansMarksByonselfIdandotherId(int onselfid, int otherid)
        {
            return dll.findFansMarksByonselfIdandotherId(onselfid, otherid);
        }

        //根据id=onselfId查询粉丝记录
        public IList<FansMarks> findfocusFansMarksByonselfId(int id)
        {
            return dll.findfocusFansMarksByonselfId(id);
        }
        //根据id=otherId查询关注记录
        public IList<FansMarks> findfansFansMarksByotherId(int id)
        {
            return dll.findfansFansMarksByotherId(id);
        }



        //查询所有人的关注记录(默认onselfId 分组)
        public IList<FansMarks> findall()
        {
            return dll.findall();
        }
    }
}
