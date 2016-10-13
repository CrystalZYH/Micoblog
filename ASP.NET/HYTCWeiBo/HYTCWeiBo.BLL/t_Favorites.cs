using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//t_Favorites
		public partial class t_Favorites
	{
   		     
		private readonly Maticsoft.DAL.t_Favorites dal=new Maticsoft.DAL.t_Favorites();
		public t_Favorites()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int favoriteId)
		{
			return dal.Exists(favoriteId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Maticsoft.Model.t_Favorites model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.t_Favorites model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int favoriteId)
		{
			
			return dal.Delete(favoriteId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.t_Favorites GetModel(int favoriteId)
		{
			
			return dal.GetModel(favoriteId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.t_Favorites GetModelByCache(int favoriteId)
		{
			
			string CacheKey = "t_FavoritesModel-" + favoriteId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(favoriteId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.t_Favorites)objModel;
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
		public List<Maticsoft.Model.t_Favorites> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_Favorites> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.t_Favorites> modelList = new List<Maticsoft.Model.t_Favorites>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.t_Favorites model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.t_Favorites();					
													if(dt.Rows[n]["favoriteId"].ToString()!="")
				{
					model.favoriteId=int.Parse(dt.Rows[n]["favoriteId"].ToString());
				}
																																if(dt.Rows[n]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(dt.Rows[n]["weiboId"].ToString());
				}
																																				model.authorName= dt.Rows[n]["authorName"].ToString();
																						
				
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