using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//FansMarks
		public partial class FansMarks
	{
   		     
		public bool Exists(int markId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FansMarks");
			strSql.Append(" where ");
			                                       strSql.Append(" markId = @markId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@markId", SqlDbType.Int,4)			};
			parameters[0].Value = markId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(HYTCWeiBo.Model.FansMarks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FansMarks(");			
            strSql.Append("markId,onselfName,otherName,createTime");
			strSql.Append(") values (");
            strSql.Append("@markId,@onselfName,@otherName,@createTime");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@markId", SqlDbType.Int,4) ,            
                        new SqlParameter("@onselfName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@otherName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@createTime", SqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.markId;                        
            parameters[1].Value = model.onselfName;                        
            parameters[2].Value = model.otherName;                        
            parameters[3].Value = model.createTime;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.FansMarks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FansMarks set ");
			                        
            strSql.Append(" markId = @markId , ");                                    
            strSql.Append(" onselfName = @onselfName , ");                                    
            strSql.Append(" otherName = @otherName , ");                                    
            strSql.Append(" createTime = @createTime  ");            			
			strSql.Append(" where markId=@markId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@markId", SqlDbType.Int,4) ,            
                        new SqlParameter("@onselfName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@otherName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@createTime", SqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.markId;                        
            parameters[1].Value = model.onselfName;                        
            parameters[2].Value = model.otherName;                        
            parameters[3].Value = model.createTime;                        
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
		public bool Delete(int markId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FansMarks ");
			strSql.Append(" where markId=@markId ");
						SqlParameter[] parameters = {
					new SqlParameter("@markId", SqlDbType.Int,4)			};
			parameters[0].Value = markId;


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
		public HYTCWeiBo.Model.FansMarks GetModel(int markId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select markId, onselfName, otherName, createTime  ");			
			strSql.Append("  from FansMarks ");
			strSql.Append(" where markId=@markId ");
						SqlParameter[] parameters = {
					new SqlParameter("@markId", SqlDbType.Int,4)			};
			parameters[0].Value = markId;

			
			HYTCWeiBo.Model.FansMarks model=new HYTCWeiBo.Model.FansMarks();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["markId"].ToString()!="")
				{
					model.markId=int.Parse(ds.Tables[0].Rows[0]["markId"].ToString());
				}
																																				model.onselfName= ds.Tables[0].Rows[0]["onselfName"].ToString();
																																model.otherName= ds.Tables[0].Rows[0]["otherName"].ToString();
																												if(ds.Tables[0].Rows[0]["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
				}
																														
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
			strSql.Append(" FROM FansMarks ");
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
			strSql.Append(" FROM FansMarks ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

