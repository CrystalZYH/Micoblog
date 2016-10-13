using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//t_User
		public partial class t_User
	{
   		     
		private readonly Maticsoft.DAL.t_User dal=new Maticsoft.DAL.t_User();
		public t_User()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			return dal.Exists(userId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Maticsoft.Model.t_User model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.t_User model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userId)
		{
			
			return dal.Delete(userId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.t_User GetModel(int userId)
		{
			
			return dal.GetModel(userId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.t_User GetModelByCache(int userId)
		{
			
			string CacheKey = "t_UserModel-" + userId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(userId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.t_User)objModel;
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
		public List<Maticsoft.Model.t_User> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_User> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.t_User> modelList = new List<Maticsoft.Model.t_User>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.t_User model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.t_User();					
													if(dt.Rows[n]["userId"].ToString()!="")
				{
					model.userId=int.Parse(dt.Rows[n]["userId"].ToString());
				}
																																				model.userName= dt.Rows[n]["userName"].ToString();
																																model.pwd= dt.Rows[n]["pwd"].ToString();
																																model.email= dt.Rows[n]["email"].ToString();
																																model.sex= dt.Rows[n]["sex"].ToString();
																																model.colloge= dt.Rows[n]["colloge"].ToString();
																																model.personalwords= dt.Rows[n]["personalwords"].ToString();
																												if(dt.Rows[n]["inCollogeYear"].ToString()!="")
				{
					model.inCollogeYear=int.Parse(dt.Rows[n]["inCollogeYear"].ToString());
				}
																																if(dt.Rows[n]["registerTime"].ToString()!="")
				{
					model.registerTime=DateTime.Parse(dt.Rows[n]["registerTime"].ToString());
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