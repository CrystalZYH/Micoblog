using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYTCWeiBo.DAL;
using HYTCWeiBo.Model;

namespace HYTCWeiBo.BLL
{
   public  class WeiBoBLL
    {
       WeiBoDAL dll = new WeiBoDAL();
       public IList<WeiBo> findall()
       {
           return dll.findall();
       }
       //根据authorId查询微博
       public IList<WeiBo> findWeiboByauthorId(int id)
       {
           return dll.findWeiboByauthorId(id);
       }
       //根据weiboId查询微博
       public WeiBo findWeiboByweiboId(int id)
       {
           return dll.findWeiboByweiboId(id);
       }
       //根据weiboId更新微博(Zan)
       public bool updateZanFavsReviewTrans(WeiBo wb)
       {
           return dll.updateZanFavsReviewTrans(wb);
       }
       public bool save(WeiBo WeiBo)
       {
           return dll.save(WeiBo);
       }
        //根据本人onselfid查询关注的人的微博
       public IList<WeiBo> findfocusWeiBosByonselfId(int id)
       {
           return dll.findfocusWeiBosByonselfId(id);
       }
    }

}
