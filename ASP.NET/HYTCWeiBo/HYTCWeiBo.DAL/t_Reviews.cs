using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//Reviews
		public partial class Reviews
	{
   		     
		public bool Exists(int reviewId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Reviews");
			strSql.Append(" where ");
			                                       strSql.Append(" reviewId = @reviewId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@reviewId", SqlDbType.Int,4)			};
			parameters[0].Value = reviewId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(HYTCWeiBo.Model.Reviews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Reviews(");			
            strSql.Append("reviewId,weiboId,reAuthorName,returnContent");
			strSql.Append(") values (");
            strSql.Append("@reviewId,@weiboId,@reAuthorName,@returnContent");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@reviewId", SqlDbType.Int,4) ,            
                        new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@reAuthorName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@returnContent", SqlDbType.VarChar,500)             
              
            };
			            
            parameters[0].Value = model.reviewId;                        
            parameters[1].Value = model.weiboId;                        
            parameters[2].Value = model.reAuthorName;                        
            parameters[3].Value = model.returnContent;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.Reviews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Reviews set ");
			                        
            strSql.Append(" reviewId = @reviewId , ");                                    
            strSql.Append(" weiboId = @weiboId , ");                                    
            strSql.Append(" reAuthorName = @reAuthorName , ");                                    
            strSql.Append(" returnContent = @returnContent  ");            			
			strSql.Append(" where reviewId=@reviewId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@reviewId", SqlDbType.Int,4) ,            
                        new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@reAuthorName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@returnContent", SqlDbType.VarChar,500)             
              
            };
						            
            parameters[0].Value = model.reviewId;                        
            parameters[1].Value = model.weiboId;                        
            parameters[2].Value = model.reAuthorName;                        
            parameters[3].Value = model.returnContent;                        
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
		public bool Delete(int reviewId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reviews ");
			strSql.Append(" where reviewId=@reviewId ");
						SqlParameter[] parameters = {
					new SqlParameter("@reviewId", SqlDbType.Int,4)			};
			parameters[0].Value = reviewId;


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
		public HYTCWeiBo.Model.Reviews GetModel(int reviewId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select reviewId, weiboId, reAuthorName, returnContent  ");			
			strSql.Append("  from Reviews ");
			strSql.Append(" where reviewId=@reviewId ");
						SqlParameter[] parameters = {
					new SqlParameter("@reviewId", SqlDbType.Int,4)			};
			parameters[0].Value = reviewId;

			
			HYTCWeiBo.Model.Reviews model=new HYTCWeiBo.Model.Reviews();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["reviewId"].ToString()!="")
				{
					model.reviewId=int.Parse(ds.Tables[0].Rows[0]["reviewId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(ds.Tables[0].Rows[0]["weiboId"].ToString());
				}
																																				model.reAuthorName= ds.Tables[0].Rows[0]["reAuthorName"].ToString();
																																model.returnContent= ds.Tables[0].Rows[0]["returnContent"].ToString();
																										
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
			strSql.Append(" FROM Reviews ");
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
			strSql.Append(" FROM Reviews ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

