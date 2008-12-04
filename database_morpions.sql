/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     06/11/2008 20:50:47                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SCORE_HISTORIQUE') and o.name = 'FK_SCORE_HI_REFERENCE_USER')
alter table SCORE_HISTORIQUE
   drop constraint FK_SCORE_HI_REFERENCE_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SCORE_HISTORIQUE')
            and   type = 'U')
   drop table SCORE_HISTORIQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: SCORE_HISTORIQUE                                      */
/*==============================================================*/
create table SCORE_HISTORIQUE (
   USER_ID              int                  not null,
   HISTO_DATE           datetime             not null,
   HISTO_WIN_PLAYER     int                  null,
   HISTO_WIN_COMPUTER   int                  null,
   HISTO_DRAW_PLAYER    int                  null,
   HISTO_DRAW_COMPUTER  int                  null,
   HISTO_LOSE_PLAYER    int                  null,
   HISTO_LOSE_COMPUTER  int                  null,
   HISTO_XP             int                  null,
   constraint PK_SCORE_HISTORIQUE primary key (USER_ID, HISTO_DATE)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USER_ID              int                  not null,
   USER_LOGIN           varchar(20)          null,
   USER_PASSWORD        varchar(40)          null,
   USER_EMAIL           varchar(50)          null,
   USER_NAME            varchar(20)          null,
   USER_SURNAME         varchar(20)          null,
   USER_IP              varchar(15)          null,
   USER_WIN_PLAYER      int                  null,
   USER_WIN_COMPUTER    int                  null,
   USER_DRAW_PLAYER     int                  null,
   USER_DRAW_COMPUTER   int                  null,
   USER_LOSE_PLAYER     int                  null,
   USER_LOSE_COMPUTER   int                  null,
   USER_XP              int                  null,
   constraint PK_USER primary key (USER_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Table décrivant un utilsateur',
   'user', @CurrentUser, 'table', 'USER'
go

alter table SCORE_HISTORIQUE
   add constraint FK_SCORE_HI_REFERENCE_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

