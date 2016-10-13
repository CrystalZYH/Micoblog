using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//t_Reviews
		public partial class t_Reviews
	{
   		     
		private readonly Maticsoft.DAL.t_Reviews dal=new Maticsoft.DAL.t_Reviews();
		public t_Reviews()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int reviewId)
		{
			return dal.Exists(reviewId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Maticsoft.Model.t_Reviews model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.t_Reviews model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int reviewId)
		{
			
			return dal.Delete(reviewId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.t_Reviews GetModel(int reviewId)
		{
			
			return dal.GetModel(reviewId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.t_Reviews GetModelByCache(int reviewId)
		{
			
			string CacheKey = "t_ReviewsModel-" + reviewId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(reviewId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.t_Reviews)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_Reviews> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_Reviews> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.t_Reviews> modelList = new List<Maticsoft.Model.t_Reviews>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.t_Reviews model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.t_Reviews();					
													if(dt.Rows[n]["reviewId"].ToString()!="")
				{
					model.reviewId=int.Parse(dt.Rows[n]["reviewId"].ToString());
				}
																																if(dt.Rows[n]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(dt.Rows[n]["weiboId"].ToString());
				}
																																				model.reAuthorName= dt.Rows[n]["reAuthorName"].ToString();
																																model.returnContent= dt.Rows[n]["returnContent"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}