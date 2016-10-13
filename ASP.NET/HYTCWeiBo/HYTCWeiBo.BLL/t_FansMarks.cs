using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//t_FansMarks
		public partial class t_FansMarks
	{
   		     
		private readonly Maticsoft.DAL.t_FansMarks dal=new Maticsoft.DAL.t_FansMarks();
		public t_FansMarks()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int markId)
		{
			return dal.Exists(markId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(Maticsoft.Model.t_FansMarks model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.t_FansMarks model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int markId)
		{
			
			return dal.Delete(markId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.t_FansMarks GetModel(int markId)
		{
			
			return dal.GetModel(markId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.t_FansMarks GetModelByCache(int markId)
		{
			
			string CacheKey = "t_FansMarksModel-" + markId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(markId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.t_FansMarks)objModel;
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
		public List<Maticsoft.Model.t_FansMarks> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.t_FansMarks> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.t_FansMarks> modelList = new List<Maticsoft.Model.t_FansMarks>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.t_FansMarks model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.t_FansMarks();					
													if(dt.Rows[n]["markId"].ToString()!="")
				{
					model.markId=int.Parse(dt.Rows[n]["markId"].ToString());
				}
																																				model.onselfName= dt.Rows[n]["onselfName"].ToString();
																																model.otherName= dt.Rows[n]["otherName"].ToString();
																												if(dt.Rows[n]["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(dt.Rows[n]["createTime"].ToString());
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