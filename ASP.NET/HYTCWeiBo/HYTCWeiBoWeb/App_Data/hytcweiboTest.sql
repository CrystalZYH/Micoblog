/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 11                       */
/* Created on:     2014/1/21 22:06:08                           */
/*==============================================================*/



/*==============================================================*/
/* Table: t_FansMarks                                           */
/*==============================================================*/
create table t_FansMarks 
(
   markId               int                            not null,
   onselfId             int                            not null,
   otherId              int                            not null,
   createTime           datetime                       null,
   constraint PK_T_FANSMARKS primary key clustered (markId)
);
select * from t_FansMarks

/*==============================================================*/
/* Table: t_Favorites                                           */
/*==============================================================*/
create table t_Favorites 
(
   favoriteId           int                            not null,
   weiboId              int                             not null,
   favPersonId          int                             not null,
   createTime           datetime                        not null,
   constraint PK_T_FAVORITES primary key clustered (favoriteId)
);
select * from t_Favorites,t_WeiBo where t_Favorites.weiboId=t_WeiBo.weiboId and favPersonId=7
/*==============================================================*/
/* Table: t_LoginMarks                                          */
/*==============================================================*/
create table t_LoginMarks 
(
   markId               int                            not null,
   userId               int                            not null,
   userName             varchar(40)                    null,
   loginTime            datetime                       null,
   leftTime             datetime                       null,
   constraint PK_T_LOGINMARKS primary key clustered (markId)
);
select * from t_LoginMarks
/*==============================================================*/
/* Table: t_UserState                                          */
/*==============================================================*/


/*==============================================================*/
/* Table: t_Reviews                                             */
/*==============================================================*/
create table t_Reviews 
(
   reviewId             int                            not null,
   weiboId              int                            not null,
   reAuthorId           int						       not null,
   reAuthorName         varchar(40)                    not null,
   returnContent        varchar(500)                   not null,
   reTime				datetime					   not null,
   constraint PK_T_REVIEWS primary key clustered (reviewId)
); 
select * from t_Reviews
/*==============================================================*/
/* Table: t_User                                                */
/*==============================================================*/
create table t_User 
(
   userId               int                            not null,
   userName             varchar(40)                    not null,
   pwd                  varchar(12)                    not null,
   email                varchar(50)                    null,
   sex                  varchar(2)                     null,
   colloge              varchar(60)                    null,
   inCollogeYear        varchar(4)                     null,
   realName             varchar(40)                    null,
   home                 varchar(50)                    null,
   birthday             varchar(10)                    null,
   boodtype             varchar(10)                    null,
   personalwords        varchar(50)                    null,
   registerTime         datetime                       null,
   phone				varchar(11)                    null,
   QQ                   varchar(50)                    null,
   MSN                  varchar(50)                    null,
   prinmarySchool       varchar(100)                   null,
   seccondSchool        varchar(100)                   null,
   hobbies              varchar(200)                   null,
   sports               varchar(100)                   null,
   bestBook             varchar(50)                    null,
   bestFilm             varchar(50)                    null,
   bestSong             varchar(50)                    null,
   bestFood             varchar(50)                    null,
   bestStars            varchar(40)                    null,
   bestGames            varchar(100)                   null,
   bestPlaces           varchar(200)                   null,
   constraint PK_T_USER primary key clustered (userId)
);
Insert into t_User(userName,pwd,email,sex,colloge,inCollogeYear,realName, home,birthday,boodtype,personalwords,registerTime,
phone,QQ,MSN, prinmarySchool,seccondSchool,hobbies,sports, bestBook ,bestFilm ,bestSong ,bestFood ,bestStars,bestGames,bestPlaces) 
values('Alice111','123111','lingoes1230@163.com','女','计算机科学与技术学院','2010','朱银花','江苏无锡','1991-12-30','A型','我是敲键盘的人','2014-3-1',
'18762555837','1120068461','211011046','无锡市鸿山镇泰伯实验小学','无锡市杨尖高级中学',
'读书、敲键盘','羽毛球',
'','','','','','','')
Insert into t_User(userName,pwd,email,sex,colloge,inCollogeYear,realName, home,birthday,boodtype,personalwords,registerTime,
phone,QQ,MSN, prinmarySchool,seccondSchool,hobbies,sports, bestBook ,bestFilm ,bestSong ,bestFood ,bestStars,bestGames,bestPlaces) 
values('zhang111','123111','lingoes1230@163.com','女','计算机科学与技术学院','2010','张三','江苏无锡','1991-12-30','A型','我是敲键盘的人','2014-3-1',
'','1120068461','211011046','无锡市鸿山镇泰伯实验小学','无锡市杨尖高级中学',
'读书、敲键盘','羽毛球',
'','','','','','','')
Insert into t_User(userName,pwd,email,sex,colloge,inCollogeYear,realName, home,birthday,boodtype,personalwords,registerTime,
phone,QQ,MSN, prinmarySchool,seccondSchool,hobbies,sports, bestBook ,bestFilm ,bestSong ,bestFood ,bestStars,bestGames,bestPlaces) 
values('Wang111','123111','lingoes1230@163.com','女','计算机科学与技术学院','2010','王五','江苏无锡','1991-12-30','A型','我是敲键盘的人','2014-3-1',
'18762555837','1120068461','211011046','无锡市鸿山镇泰伯实验小学','无锡市杨尖高级中学',
'读书、敲键盘','羽毛球',
'','','','','','','')
select * from t_User

create table t_UserState 
(
   userId               int                            not null,
   userName             varchar(40)                    not null,
   userState            varchar(10)                      null,
   constraint PK_T_UserState primary key clustered (userId)
);
insert into t_UserState(userId,userName,userState) values(4,'Alice111','在线')
insert into t_UserState(userId,userName,userState) values(5,'zhang111','离线')
insert into t_UserState(userId,userName,userState) values(6,'Wang111','离线')
insert into t_UserState(userId,userName,userState) values(7,'Alice222','离线')
insert into t_UserState(userId,userName,userState) values(8,'1111','离线')

/*==============================================================*/
/* Table: t_userlogo                                              */
/*==============================================================*/
create table t_Userlogo(
   userId               int                            not null,
   logoURL              varchar(300)                   not null,
   topbgURL				varchar(300)                   not null,
   constraint PK_T_USERLOGO primary key clustered (userId)
);
/*==============================================================*/
/* Table: t_photoAlbum                                             */
/*==============================================================*/
create table t_PhotoAlbum(
   albumId              int							   not null,
   userId               int                            not null,
   albumName            varchar(50)                    not null,
   createtime          datetime                        null,
   constraint PK_T_PHOTOAlbum primary key clustered (albumId)
);
/*==============================================================*/
/* Table: t_photo                                            */
/*==============================================================*/
create table t_Photo(
   photoId              int							   not null,
   userId               int                            not null,
   albumId              int							   not null,
   photpName            varchar(300)                   not null,
   createtime          datetime                        null,
   constraint PK_T_PHOTO primary key clustered (photoId)
);


/*==============================================================*/
/* Table: t_WeiBo                                               */
/*==============================================================*/
create table t_WeiBo 
(
   weiboId              int                            not null,
   authorId             int                            not null,
   authorName           varchar(40)                    null,
   content              varchar(280)                   null,
   isOriginal           varchar(10)                    null,  
   orAuthorId           int                            null,
   orAuthorName         varchar(40)                    null,
   orContent            varchar(100)                   null,
   orTime				datetime					   null,
   createTime           datetime                       null,
   zanNumber            int                            null,
   reviewNumber         int                            null,
   transmitNumber       int                            null,
   favsNumber           int                            null,
   constraint PK_T_WEIBO primary key clustered (weiboId)
);
  
Insert into t_WeiBo(authorId,authorName,content,flagOnself,trReview,trAuthor,createTime,zanNumber,
					reviewNumber,transmitNumber,favsNumber) 
values(5,'Alice',' 数据访问层DAL（用于实现与数据库的交互与访问，从数据库获取数据或保存数据到数据库的部分）业务逻辑层BLL（业务逻辑层承上启下，用于对上下交互的数据进行逻辑处理，实现业务目标）','原创','0','0','2012-3-3',34,56,78,90)
Insert into t_WeiBo(authorId,authorName,content,flagOnselfW,trReview,trAuthor,createTime,zanNumber,
					reviewNumber,transmitNumber,favsNumber) 
values(5,'Alice',' Today is a good day!','原创','0','0','2012-3-3',34,56,78,90)
select * from t_WeiBo order by createTime DESC
update  t_WeiBo set AuthorName ='zhang111' where authorId=5
update t_WeiBo set zanNumber=zanNumber+1 where weiboId=200
delete t_WeiBo where weiboId=215
delete t_Reviews where weiboId=204
select  weiboId,reAuthorId,reAuthorName,returnContent,reTime from t_Reviews group by weiboId
select * from t_Reviews
select * from t_FansMarks
select t1.weiboId
from t_WeiBo t1,t_FansMarks 
 where t1.authorId=t_FansMarks.otherId and t_FansMarks.onselfId=4
 
 update t_User 
 set pwd='123111',bestBook='傲慢与偏见' where userId=4
 
 select * from t_User