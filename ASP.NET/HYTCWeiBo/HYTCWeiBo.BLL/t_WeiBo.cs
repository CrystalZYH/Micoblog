using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//t_WeiBo
		public partial class t_WeiBo
	{
   		     
		private readonly Maticsoft.DAL.t_WeiBo dal=new Maticsoft.DAL.t_WeiBo();
		public t_WeiBo()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int weiboId)
		{
			return dal.Exists(weiboId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Maticsoft.Model.t_WeiBo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.t_WeiBo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int weiboId)
		{
			
			return dal.Delete(weiboId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.t_WeiBo GetModel(int weiboId)
		{
			
			return dal.GetModel(weiboId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.t_WeiBo GetModelByCache(int weiboId)
		{
			
			string CacheKey = "t_WeiBoModel-" + weiboId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(weiboId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.t_WeiBo)objModel;
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
		public List<Maticsoft.Model.t_WeiBo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_WeiBo> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.t_WeiBo> modelList = new List<Maticsoft.Model.t_WeiBo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.t_WeiBo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.t_WeiBo();					
													if(dt.Rows[n]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(dt.Rows[n]["weiboId"].ToString());
				}
																																				model.authorName= dt.Rows[n]["authorName"].ToString();
																																model.content= dt.Rows[n]["content"].ToString();
																												if(dt.Rows[n]["flagOnself"].ToString()!="")
				{
					model.flagOnself=int.Parse(dt.Rows[n]["flagOnself"].ToString());
				}
																																				model.trReview= dt.Rows[n]["trReview"].ToString();
																																model.trAuthor= dt.Rows[n]["trAuthor"].ToString();
																												if(dt.Rows[n]["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(dt.Rows[n]["createTime"].ToString());
				}
																																if(dt.Rows[n]["zanNumber"].ToString()!="")
				{
					model.zanNumber=int.Parse(dt.Rows[n]["zanNumber"].ToString());
				}
																																if(dt.Rows[n]["reviewNumber"].ToString()!="")
				{
					model.reviewNumber=int.Parse(dt.Rows[n]["reviewNumber"].ToString());
				}
																																if(dt.Rows[n]["transmitNumber"].ToString()!="")
				{
					model.transmitNumber=int.Parse(dt.Rows[n]["transmitNumber"].ToString());
				}
																																if(dt.Rows[n]["farsNumber"].ToString()!="")
				{
					model.farsNumber=int.Parse(dt.Rows[n]["farsNumber"].ToString());
				}
																																if(dt.Rows[n]["authorId"].ToString()!="")
				{
					model.authorId=int.Parse(dt.Rows[n]["authorId"].ToString());
				}
																										
				
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