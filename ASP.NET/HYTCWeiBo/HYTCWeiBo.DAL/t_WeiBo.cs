using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using HYTCWeiBo.DBUtility;
namespace HYTCWeiBo.DAL  
{
	 	//WeiBo
		public partial class WeiBo
	{
   		     
		public bool Exists(int weiboId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WeiBo");
			strSql.Append(" where ");
			                                       strSql.Append(" weiboId = @weiboId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@weiboId", SqlDbType.Int,4)			};
			parameters[0].Value = weiboId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(HYTCWeiBo.Model.WeiBo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WeiBo(");			
            strSql.Append("weiboId,authorName,content,flagOnself,trReview,trAuthor,createTime,zanNumber,reviewNumber,transmitNumber,farsNumber,authorId");
			strSql.Append(") values (");
            strSql.Append("@weiboId,@authorName,@content,@flagOnself,@trReview,@trAuthor,@createTime,@zanNumber,@reviewNumber,@transmitNumber,@farsNumber,@authorId");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@content", SqlDbType.VarChar,280) ,            
                        new SqlParameter("@flagOnself", SqlDbType.Int,4) ,            
                        new SqlParameter("@trReview", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@trAuthor", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@createTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@zanNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@reviewNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@transmitNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@farsNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorId", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.weiboId;                        
            parameters[1].Value = model.authorName;                        
            parameters[2].Value = model.content;                        
            parameters[3].Value = model.flagOnself;                        
            parameters[4].Value = model.trReview;                        
            parameters[5].Value = model.trAuthor;                        
            parameters[6].Value = model.createTime;                        
            parameters[7].Value = model.zanNumber;                        
            parameters[8].Value = model.reviewNumber;                        
            parameters[9].Value = model.transmitNumber;                        
            parameters[10].Value = model.farsNumber;                        
            parameters[11].Value = model.authorId;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HYTCWeiBo.Model.WeiBo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WeiBo set ");
			                        
            strSql.Append(" weiboId = @weiboId , ");                                    
            strSql.Append(" authorName = @authorName , ");                                    
            strSql.Append(" content = @content , ");                                    
            strSql.Append(" flagOnself = @flagOnself , ");                                    
            strSql.Append(" trReview = @trReview , ");                                    
            strSql.Append(" trAuthor = @trAuthor , ");                                    
            strSql.Append(" createTime = @createTime , ");                                    
            strSql.Append(" zanNumber = @zanNumber , ");                                    
            strSql.Append(" reviewNumber = @reviewNumber , ");                                    
            strSql.Append(" transmitNumber = @transmitNumber , ");                                    
            strSql.Append(" farsNumber = @farsNumber , ");                                    
            strSql.Append(" authorId = @authorId  ");            			
			strSql.Append(" where weiboId=@weiboId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@weiboId", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorName", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@content", SqlDbType.VarChar,280) ,            
                        new SqlParameter("@flagOnself", SqlDbType.Int,4) ,            
                        new SqlParameter("@trReview", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@trAuthor", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@createTime", SqlDbType.DateTime) ,            
                        new SqlParameter("@zanNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@reviewNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@transmitNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@farsNumber", SqlDbType.Int,4) ,            
                        new SqlParameter("@authorId", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.weiboId;                        
            parameters[1].Value = model.authorName;                        
            parameters[2].Value = model.content;                        
            parameters[3].Value = model.flagOnself;                        
            parameters[4].Value = model.trReview;                        
            parameters[5].Value = model.trAuthor;                        
            parameters[6].Value = model.createTime;                        
            parameters[7].Value = model.zanNumber;                        
            parameters[8].Value = model.reviewNumber;                        
            parameters[9].Value = model.transmitNumber;                        
            parameters[10].Value = model.farsNumber;                        
            parameters[11].Value = model.authorId;                        
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
		public bool Delete(int weiboId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WeiBo ");
			strSql.Append(" where weiboId=@weiboId ");
						SqlParameter[] parameters = {
					new SqlParameter("@weiboId", SqlDbType.Int,4)			};
			parameters[0].Value = weiboId;


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
		public HYTCWeiBo.Model.WeiBo GetModel(int weiboId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select weiboId, authorName, content, flagOnself, trReview, trAuthor, createTime, zanNumber, reviewNumber, transmitNumber, farsNumber, authorId  ");			
			strSql.Append("  from WeiBo ");
			strSql.Append(" where weiboId=@weiboId ");
						SqlParameter[] parameters = {
					new SqlParameter("@weiboId", SqlDbType.Int,4)			};
			parameters[0].Value = weiboId;

			
			HYTCWeiBo.Model.WeiBo model=new HYTCWeiBo.Model.WeiBo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["weiboId"].ToString()!="")
				{
					model.weiboId=int.Parse(ds.Tables[0].Rows[0]["weiboId"].ToString());
				}
																																				model.authorName= ds.Tables[0].Rows[0]["authorName"].ToString();
																																model.content= ds.Tables[0].Rows[0]["content"].ToString();
																												if(ds.Tables[0].Rows[0]["flagOnself"].ToString()!="")
				{
					model.flagOnself=int.Parse(ds.Tables[0].Rows[0]["flagOnself"].ToString());
				}
																																				model.trReview= ds.Tables[0].Rows[0]["trReview"].ToString();
																																model.trAuthor= ds.Tables[0].Rows[0]["trAuthor"].ToString();
																												if(ds.Tables[0].Rows[0]["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["zanNumber"].ToString()!="")
				{
					model.zanNumber=int.Parse(ds.Tables[0].Rows[0]["zanNumber"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["reviewNumber"].ToString()!="")
				{
					model.reviewNumber=int.Parse(ds.Tables[0].Rows[0]["reviewNumber"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["transmitNumber"].ToString()!="")
				{
					model.transmitNumber=int.Parse(ds.Tables[0].Rows[0]["transmitNumber"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["farsNumber"].ToString()!="")
				{
					model.farsNumber=int.Parse(ds.Tables[0].Rows[0]["farsNumber"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["authorId"].ToString()!="")
				{
					model.authorId=int.Parse(ds.Tables[0].Rows[0]["authorId"].ToString());
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
			strSql.Append(" FROM WeiBo ");
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
			strSql.Append(" FROM WeiBo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

