using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//User
		public partial class User
	{
   		     
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from User");
			strSql.Append(" where ");
			                                       strSql.Append(" userId = @userId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(HYTCWeiBo.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into User(");			
            strSql.Append("userId,userName,pwd,email,sex,colloge,personalwords,inCollogeYear,registerTime");
			strSql.Append(") values (");
            strSql.Append("@userId,@userName,@pwd,@email,@sex,@colloge,@personalwords,@inCollogeYear,@registerTime");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@userId", SqlDbType.Int,4) ,            
                        new SqlParameter("@userName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,12) ,            
                        new SqlParameter("@email", SqlDbType.VarChar,1) ,            
                        new SqlParameter("@sex", SqlDbType.VarChar,2) ,            
                        new SqlParameter("@colloge", SqlDbType.VarChar,60) ,            
                        new SqlParameter("@personalwords", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@inCollogeYear", SqlDbType.Int,4) ,            
                        new SqlParameter("@registerTime", SqlDbType.DateTime)             
              
            };
			            
            parameters[0].Value = model.userId;                        
            parameters[1].Value = model.userName;                        
            parameters[2].Value = model.pwd;                        
            parameters[3].Value = model.email;                        
            parameters[4].Value = model.sex;                        
            parameters[5].Value = model.colloge;                        
            parameters[6].Value = model.personalwords;                        
            parameters[7].Value = model.inCollogeYear;                        
            parameters[8].Value = model.registerTime;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update User set ");
			                        
            strSql.Append(" userId = @userId , ");                                    
            strSql.Append(" userName = @userName , ");                                    
            strSql.Append(" pwd = @pwd , ");                                    
            strSql.Append(" email = @email , ");                                    
            strSql.Append(" sex = @sex , ");                                    
            strSql.Append(" colloge = @colloge , ");                                    
            strSql.Append(" personalwords = @personalwords , ");                                    
            strSql.Append(" inCollogeYear = @inCollogeYear , ");                                    
            strSql.Append(" registerTime = @registerTime  ");            			
			strSql.Append(" where userId=@userId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@userId", SqlDbType.Int,4) ,            
                        new SqlParameter("@userName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@pwd", SqlDbType.VarChar,12) ,            
                        new SqlParameter("@email", SqlDbType.VarChar,1) ,            
                        new SqlParameter("@sex", SqlDbType.VarChar,2) ,            
                        new SqlParameter("@colloge", SqlDbType.VarChar,60) ,            
                        new SqlParameter("@personalwords", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@inCollogeYear", SqlDbType.Int,4) ,            
                        new SqlParameter("@registerTime", SqlDbType.DateTime)             
              
            };
						            
            parameters[0].Value = model.userId;                        
            parameters[1].Value = model.userName;                        
            parameters[2].Value = model.pwd;                        
            parameters[3].Value = model.email;                        
            parameters[4].Value = model.sex;                        
            parameters[5].Value = model.colloge;                        
            parameters[6].Value = model.personalwords;                        
            parameters[7].Value = model.inCollogeYear;                        
            parameters[8].Value = model.registerTime;                        
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
		public bool Delete(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where userId=@userId ");
						SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
			parameters[0].Value = userId;


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
		public HYTCWeiBo.Model.User GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select userId, userName, pwd, email, sex, colloge, personalwords, inCollogeYear, registerTime  ");			
			strSql.Append("  from User ");
			strSql.Append(" where userId=@userId ");
						SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
			parameters[0].Value = userId;

			
			HYTCWeiBo.Model.User model=new HYTCWeiBo.Model.User();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
																																				model.userName= ds.Tables[0].Rows[0]["userName"].ToString();
																																model.pwd= ds.Tables[0].Rows[0]["pwd"].ToString();
																																model.email= ds.Tables[0].Rows[0]["email"].ToString();
																																model.sex= ds.Tables[0].Rows[0]["sex"].ToString();
																																model.colloge= ds.Tables[0].Rows[0]["colloge"].ToString();
																																model.personalwords= ds.Tables[0].Rows[0]["personalwords"].ToString();
																												if(ds.Tables[0].Rows[0]["inCollogeYear"].ToString()!="")
				{
					model.inCollogeYear=int.Parse(ds.Tables[0].Rows[0]["inCollogeYear"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["registerTime"].ToString()!="")
				{
					model.registerTime=DateTime.Parse(ds.Tables[0].Rows[0]["registerTime"].ToString());
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
			strSql.Append(" FROM User ");
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
			strSql.Append(" FROM User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

