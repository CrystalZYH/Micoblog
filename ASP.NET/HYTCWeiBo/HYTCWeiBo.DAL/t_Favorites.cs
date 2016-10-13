using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//Favorites
		public partial class Favorites
	{
   		     
		public bool Exists(int favoriteId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Favorites");
			strSql.Append(" where ");
			                                       strSql.Append(" favoriteId = @favoriteId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@favoriteId", SqlDbType.Int,4)			};
			parameters[0].Value = favoriteId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(HYTCWeiBo.Model.Favorites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Favorites(");			
            strSql.Append("favoriteId,weiboId,authorName");
			strSql.Append(") values (");
            strSql.Append("@favoriteId,@weiboId,@authorName");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@favoriteId", SqlDbType.Int,4) ,            
                        new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorName", SqlDbType.VarChar,20)             
              
            };
			            
            parameters[0].Value = model.favoriteId;                        
            parameters[1].Value = model.weiboId;                        
            parameters[2].Value = model.authorName;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.Favorites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Favorites set ");
			                        
            strSql.Append(" favoriteId = @favoriteId , ");                                    
            strSql.Append(" weiboId = @weiboId , ");                                    
            strSql.Append(" authorName = @authorName  ");            			
			strSql.Append(" where favoriteId=@favoriteId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@favoriteId", SqlDbType.Int,4) ,            
                        new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorName", SqlDbType.VarChar,20)             
              
            };
						            
            parameters[0].Value = model.favoriteId;                        
            parameters[1].Value = model.weiboId;                        
            parameters[2].Value = model.authorName;                        
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int favoriteId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Favorites ");
			strSql.Append(" where favoriteId=@favoriteId ");
						SqlParameter[] parameters = {
					new SqlParameter("@favoriteId", SqlDbType.Int,4)			};
			parameters[0].Value = favoriteId;


			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HYTCWeiBo.Model.Favorites GetModel(int favoriteId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select favoriteId, weiboId, authorName  ");			
			strSql.Append("  from Favorites ");
			strSql.Append(" where favoriteId=@favoriteId ");
						SqlParameter[] parameters = {
					new SqlParameter("@favoriteId", SqlDbType.Int,4)			};
			parameters[0].Value = favoriteId;

			
			HYTCWeiBo.Model.Favorites model=new HYTCWeiBo.Model.Favorites();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["favoriteId"].ToString()!="")
				{
					model.favoriteId=int.Parse(ds.Tables[0].Rows[0]["favoriteId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(ds.Tables[0].Rows[0]["weiboId"].ToString());
				}
																																				model.authorName= ds.Tables[0].Rows[0]["authorName"].ToString();
																										
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM Favorites ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM Favorites ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

