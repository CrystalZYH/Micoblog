using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//LoginMarks
		public partial class LoginMarks
	{
   		     
		public bool Exists(int markId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LoginMarks");
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
		public void Add(HYTCWeiBo.Model.LoginMarks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LoginMarks(");			
            strSql.Append("markId,userId,loginTime,userName");
			strSql.Append(") values (");
            strSql.Append("@markId,@userId,@loginTime,@userName");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@markId", SqlDbType.Int,4) ,            
                        new SqlParameter("@userId", SqlDbType.Int,4) ,            
                        new SqlParameter("@loginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@userName", SqlDbType.VarChar,20)             
              
            };
			            
            parameters[0].Value = model.markId;                        
            parameters[1].Value = model.userId;                        
            parameters[2].Value = model.loginTime;                        
            parameters[3].Value = model.userName;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.LoginMarks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LoginMarks set ");
			                        
            strSql.Append(" markId = @markId , ");                                    
            strSql.Append(" userId = @userId , ");                                    
            strSql.Append(" loginTime = @loginTime , ");                                    
            strSql.Append(" userName = @userName  ");            			
			strSql.Append(" where markId=@markId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@markId", SqlDbType.Int,4) ,            
                        new SqlParameter("@userId", SqlDbType.Int,4) ,            
                        new SqlParameter("@loginTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@userName", SqlDbType.VarChar,20)             
              
            };
						            
            parameters[0].Value = model.markId;                        
            parameters[1].Value = model.userId;                        
            parameters[2].Value = model.loginTime;                        
            parameters[3].Value = model.userName;                        
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
			strSql.Append("delete from LoginMarks ");
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
		public HYTCWeiBo.Model.LoginMarks GetModel(int markId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select markId, userId, loginTime, userName  ");			
			strSql.Append("  from LoginMarks ");
			strSql.Append(" where markId=@markId ");
						SqlParameter[] parameters = {
					new SqlParameter("@markId", SqlDbType.Int,4)			};
			parameters[0].Value = markId;

			
			HYTCWeiBo.Model.LoginMarks model=new HYTCWeiBo.Model.LoginMarks();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["markId"].ToString()!="")
				{
					model.markId=int.Parse(ds.Tables[0].Rows[0]["markId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["loginTime"].ToString()!="")
				{
					model.loginTime=DateTime.Parse(ds.Tables[0].Rows[0]["loginTime"].ToString());
				}
																																				model.userName= ds.Tables[0].Rows[0]["userName"].ToString();
																										
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
			strSql.Append(" FROM LoginMarks ");
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
			strSql.Append(" FROM LoginMarks ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

