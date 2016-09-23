USE [Purchase_SaleLedger]
GO
/****** Object:  StoredProcedure [dbo].[CRM_Temp_ImportOrders]    Script Date: 29/07/2016 20:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[CRM_Temp_ImportOrders]
AS BEGIN

Delete from Purchase_SaleLedger.dbo.SaleLedger where [Type] = 'CRM Sales Order' or [Type] = 'OpenCRM Sales Order'

--Import valid data from the temporary table into the main table
Insert into Purchase_SaleLedger.dbo.SaleLedger (Date, CustRef, CustName, DueDate, Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, [Type], SiteName, Currency,  CustOrderNo,ImportType)
	Select Date,CustRef, CustName, Nullif(DueDate,''), Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, 'OpenCRM Sales Order', SiteName, Currency,  CustOrderNo,'CRM' from Temp_OrderLedger
	where Date is not null
	and Date > '2015/01/01'

--Delete from Temp_OrderLedger
END
GO

Print 'Adding MiniPack to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'MiniPack' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD MiniPack smallint null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'MiniPack' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add MiniPack smallint null
GO

Print 'Adding SiteSurveyDate to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'SiteSurveyDate' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD SiteSurveyDate varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'SiteSurveyDate' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add SiteSurveyDate varchar (255) null
GO

Print 'Adding SiteSurveyDate to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'SiteSurveyDate' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD SiteSurveyDate varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'SiteSurveyDate' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add SiteSurveyDate varchar (255) null
GO

Print 'Adding BacklogComments to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'BacklogComments' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD BacklogComments varchar (max) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'BacklogComments' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add BacklogComments varchar (max) null
GO

Print 'Adding Deposit to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'Deposit' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD Deposit varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'Deposit' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add Deposit varchar (255) null
GO

Print 'Adding AssignedTo to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'AssignedTo' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD AssignedTo varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'AssignedTo' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add AssignedTo varchar (255) null
GO

Print 'Adding MegJobNo to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'MegJobNo' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD MegJobNo varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'MegJobNo' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add MegJobNo varchar (255) null
GO

Print 'Adding DirectDebit to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'DirectDebit' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD DirectDebit smallint null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'DirectDebit' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add DirectDebit smallint null
GO
Print 'Adding Spare1 to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'Spare1' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD Spare1 varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'Spare1' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add Spare1 varchar (255) null
GO

Print 'Adding Spare2 to Temp and Main Table'
IF NOT EXISTS (Select * from sys.columns where name = N'Spare2' and Object_ID = Object_ID(N'Temp_OrderLedger'))
ALTER TABLE Temp_OrderLedger ADD Spare2 varchar (255) null
GO
IF NOT EXISTS (Select * from sys.columns where name = N'Spare2' and Object_ID = Object_ID(N'SaleLedger'))
ALTER TABLE SaleLedger Add Spare2 varchar (255) null
GO

USE [Purchase_SaleLedger]
GO

Print 'Create Advanced Table Type for OpenCRM Import'
IF NOT EXISTS (SELECT * FROM sys.types WHERE is_table_type = 1 AND name = 'CustomTypeSaleOrderImport_CRM_Adv')
/****** Object:  UserDefinedTableType [dbo].[CustomTypeSaleOrderImport_CRM]    Script Date: 29/07/2016 21:59:02 ******/
CREATE TYPE [dbo].[CustomTypeSaleOrderImport_CRM_Adv] AS TABLE(
	[Date] [datetime] NULL,
	[CustName] [varchar](100) NULL,
	[SiteName] [nvarchar](255) NULL,
	[CustRef] [varchar](30) NULL,
	[DueDate] [datetime] NULL,
	[Category] [nvarchar](255) NULL,
	[ItemDescription] [nvarchar](max) NULL,
	[Qty] [numeric](16, 6) NULL,
	[Net] [money] NULL,
	[Tax] [money] NULL,
	[Gross] [money] NULL,
	[Profit] [money] NULL,
	[Currency] [nvarchar](3) NULL,
	[CustOrderNo] [nvarchar](30) NULL,
	[MiniPack] [smallint] NULL,
	[SiteSurveyDate] [varchar](255) NULL,
	[BacklogComments] [varchar](max) NULL,
	[Deposit] [varchar](255) NULL,
	[AssignedTo] [varchar](255) NULL,
	[MegJobNo] [varchar](255) NULL,
	[DirectDebit] [smallint]  NULL
)
GO


Print 'Create Advanced Table 2 Type for OpenCRM Import'
IF NOT EXISTS (SELECT * FROM sys.types WHERE is_table_type = 1 AND name = 'CustomTypeSaleOrderImport_CRM_Adv2')
/****** Object:  UserDefinedTableType [dbo].[CustomTypeSaleOrderImport_CRM]    Script Date: 29/07/2016 21:59:02 ******/
CREATE TYPE [dbo].[CustomTypeSaleOrderImport_CRM_Adv2] AS TABLE(
	[Date] [date] NULL,
	[CustName] [varchar](100) NULL,
	[CustRef] [varchar](30) NULL,
	[DueDate] [date] NULL,
	[Category] [nvarchar](255) NULL,
	[ItemDescription] [nvarchar](max) NULL,
	[Qty] [numeric](16, 6) NULL,
	[Net] [money] NULL,
	[Tax] [money] NULL,
	[Gross] [money] NULL,
	[Profit] [money] NULL,
	[SiteName] [nvarchar](255) NULL,
	[Currency] [nvarchar](3) NULL,
	[CustOrderNo] [nvarchar](20) NULL,
	[MiniPack] [smallint] NULL,
	[SiteSurveyDate] [varchar](255) NULL,
	[BacklogComments] [varchar](max) NULL,
	[Deposit] [varchar](255) NULL,
	[AssignedTo] [varchar](255) NULL,
	[MegJobNo] [varchar](255) NULL,
	[DirectDebit] [smallint] NULL,
	[Spare1] varchar(255) NULL
)
GO

Print 'Create Advanced Import Procedure for OpenCRM Import'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Grid_ImportOrders_Adv]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv]
END
GO
CREATE PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv]
	@Date DateTime NULL,
	@CustName varchar(100) NULL,
	@SiteName nvarchar(255) NULL,
	@CustRef varchar(30) NULL,
	@DueDate date NULL,
	@Category nvarchar(255) NULL,
	@ItemDescription nvarchar(max) NULL,
	@Qty numeric(16, 6) NULL,
	@Net money NULL,
	@Tax money NULL,
	@Gross money NULL,
	@Profit money NULL,
	@Currency nvarchar(3) NULL,
	@CustOrderNo nvarchar(20) NULL,
	@MiniPack smallint NULL,
	@SiteSurveyDate varchar(255) NULL,
	@BacklogComments varchar(max) NULL,
	@Deposit varchar(255) NULL,
	@AssignedTo varchar(255) NULL,
	@MegJobNo varchar(255) NULL,
	@DirectDebit smallint NULL

AS BEGIN
SET NOCOUNT ON;

Declare @TempResult int
Declare @FinalResult int

Insert into Temp_OrderLedger (Date, CustName, SiteName, CustRef, DueDate, Category, ItemDescription, Qty, Net, Tax, Gross, Profit, Currency, CustOrderNo, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit)
Values (@Date, @SiteName, @CustName, @CustRef, @DueDate, @Category, @ItemDescription, @Qty, @Net, @Tax, @Gross, @Profit, @Currency, @CustOrderNo, @MiniPack, @SiteSurveyDate, @BacklogComments, @Deposit, @AssignedTo, @MegJobNo, @DirectDebit)
End

GO

Print 'Create Advanced Import Procedure 2 for OpenCRM Import'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Grid_ImportOrders_Adv2]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv2]
END
GO
CREATE PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv2]
	@Date DateTime NULL,
	@CustName varchar(100) NULL,
	@SiteName nvarchar(255) NULL,
	@CustRef varchar(30) NULL,
	@DueDate date NULL,
	@Category nvarchar(255) NULL,
	@ItemDescription nvarchar(max) NULL,
	@Qty numeric(16, 6) NULL,
	@Net money NULL,
	@Tax money NULL,
	@Gross money NULL,
	@Profit money NULL,
	@Currency nvarchar(3) NULL,
	@CustOrderNo nvarchar(20) NULL,
	@MiniPack smallint NULL,
	@SiteSurveyDate varchar(255) NULL,
	@BacklogComments varchar(max) NULL,
	@Deposit varchar(255) NULL,
	@AssignedTo varchar(255) NULL,
	@MegJobNo varchar(255) NULL,
	@DirectDebit smallint NULL,
	@Spare1 varchar(255) NULL
AS BEGIN

SET NOCOUNT ON;

Declare @TempResult int
Declare @FinalResult int



Insert into Temp_OrderLedger (Date, CustName, SiteName, CustRef, DueDate, Category, ItemDescription, Qty, Net, Tax, Gross, Profit, Currency, CustOrderNo, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1)
VALUES (@Date, @SiteName, @CustName, @CustRef, @DueDate, @Category, @ItemDescription, @Qty, @Net, @Tax, @Gross, @Profit, @Currency, @CustOrderNo, @MiniPack, @SiteSurveyDate, @BacklogComments, @Deposit, @AssignedTo, @MegJobNo, @DirectDebit, @Spare1)


End

GO

Print 'Create Advanced Import Procedure 3 for OpenCRM Import'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Grid_ImportOrders_Adv3]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv3]
END
GO
CREATE PROCEDURE [dbo].[CRM_Grid_ImportOrders_Adv3]
	@Date DateTime NULL,
	@CustName varchar(100) NULL,
	@SiteName nvarchar(255) NULL,
	@CustRef varchar(30) NULL,
	@DueDate date NULL,
	@Category nvarchar(255) NULL,
	@ItemDescription nvarchar(max) NULL,
	@Qty numeric(16, 6) NULL,
	@Net money NULL,
	@Tax money NULL,
	@Gross money NULL,
	@Profit money NULL,
	@Currency nvarchar(3) NULL,
	@CustOrderNo nvarchar(20) NULL,
	@MiniPack smallint NULL,
	@SiteSurveyDate varchar(255) NULL,
	@BacklogComments varchar(max) NULL,
	@Deposit varchar(255) NULL,
	@AssignedTo varchar(255) NULL,
	@MegJobNo varchar(255) NULL,
	@DirectDebit smallint NULL,
	@Spare1 varchar(255) NULL,
	@Spare2 varchar(255) NULL

AS BEGIN

SET NOCOUNT ON;

Declare @TempResult int
Declare @FinalResult int



Insert into Temp_OrderLedger (Date, CustName, SiteName, CustRef, DueDate, Category, ItemDescription, Qty, Net, Tax, Gross, Profit, Currency, CustOrderNo, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1, Spare2)
VALUES (@Date, @SiteName, @CustName, @CustRef, @DueDate, @Category, @ItemDescription, @Qty, @Net, @Tax, @Gross, @Profit, @Currency, @CustOrderNo, @MiniPack, @SiteSurveyDate, @BacklogComments, @Deposit, @AssignedTo, @MegJobNo, @DirectDebit, @Spare1, @Spare2)


End

GO

Print 'Alter Import Procedure for CRM from Temporary Table to Main Ledger Table'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Temp_ImportOrders]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Temp_ImportOrders]
END
GO
CREATE PROCEDURE [dbo].[CRM_Temp_ImportOrders]
AS BEGIN
Delete from Purchase_SaleLedger.dbo.SaleLedger where [Type] = 'OpenCRM' and ImportType = 'OpenCRM Sales Order'

--Import valid data from the temporary table into the main table
Insert into Purchase_SaleLedger.dbo.SaleLedger (Date, CustRef, CustName, DueDate, Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, [Type], SiteName, Currency,  CustOrderNo,ImportType)
	Select Date,CustRef, CustName, Nullif(DueDate,''), Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, 'OpenCRM', SiteName, Currency,  CustOrderNo,'OpenCRM Sales Order' from Temp_OrderLedger
	where Date is not null
	and Date > '2015/01/01'

Delete from Temp_OrderLedger
END
GO

Print 'Add Import Procedure for CRM from Temporary Table to Main Ledger Table (Adv 21 columns)'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Temp_ImportOrders_Adv]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv]
END
GO
CREATE PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv]
AS BEGIN

Delete from Purchase_SaleLedger.dbo.SaleLedger where [Type] = 'OpenCRM' and ImportType = 'OpenCRM Sales Order'

--Import valid data from the temporary table into the main table
Insert into Purchase_SaleLedger.dbo.SaleLedger (Date, CustRef, CustName, DueDate, Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, [Type], SiteName, Currency,  CustOrderNo,ImportType, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit)
	Select Date,CustRef, CustName, Nullif(DueDate,''), Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, 'OpenCRM', SiteName, Currency,  CustOrderNo,'OpenCRM Sales Order', MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit from Temp_OrderLedger
	where Date is not null
	and Date > '2015/01/01'

Delete from Temp_OrderLedger
END
GO

Print 'Add Import Procedure for CRM from Temporary Table to Main Ledger Table (Adv 22 columns)'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Temp_ImportOrders_Adv2]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv2]
END
GO
CREATE PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv2]
AS BEGIN

Delete from Purchase_SaleLedger.dbo.SaleLedger where [Type] = 'OpenCRM' and ImportType = 'OpenCRM'

--Import valid data from the temporary table into the main table
Insert into Purchase_SaleLedger.dbo.SaleLedger (Date, CustRef, CustName, DueDate, Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, [Type], SiteName, Currency,  CustOrderNo,ImportType, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1)
	Select Date,CustRef, CustName, Nullif(DueDate,''), Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, 'OpenCRM', SiteName, Currency,  CustOrderNo,'OpenCRM Sales Order', MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1 from Temp_OrderLedger
	where Date is not null
	and Date > '2015/01/01'

Delete from Temp_OrderLedger
END
GO

Print 'Add Import Procedure for CRM from Temporary Table to Main Ledger Table (Adv 23 columns)'
IF EXISTS ( SELECT * FROM   sysobjects WHERE  id = object_id(N'[dbo].[CRM_Temp_ImportOrders_Adv3]')  and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv3]
END
GO
CREATE PROCEDURE [dbo].[CRM_Temp_ImportOrders_Adv3]
AS BEGIN

Delete from Purchase_SaleLedger.dbo.SaleLedger where [Type] = 'OpenCRM' and ImportType = 'OpenCRM Sales Order'

--Import valid data from the temporary table into the main table
Insert into Purchase_SaleLedger.dbo.SaleLedger (Date, CustRef, CustName, DueDate, Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, [Type], SiteName, Currency,  CustOrderNo,ImportType, MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1, Spare2)
	Select Date,CustRef, CustName, Nullif(DueDate,''), Category,  ItemDescription, Qty, Net, Tax, Gross, Profit, 'OpenCRM', SiteName, Currency,  CustOrderNo,'OpenCRM Sales Order', MiniPack, SiteSurveyDate, BacklogComments, Deposit, AssignedTo, MegJobNo, DirectDebit, Spare1, Spare2 from Temp_OrderLedger
	where Date is not null
	and Date > '2015/01/01'

Delete from Temp_OrderLedger
END


Print 'Altering SaleLedgerExtended view to add new columns'
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 ALTER View [dbo].[SaleLedgerExtended] as 
 

Select 
	UniqueID,
	CustRef,
	CustName,
	SiteName,
	GL,
	GLDescription,
	Date,
	DueDate,
	DATEPART(yyyy,Date) as Year,
	DATEPART(mm,Date) as Month,
	DATEPART(dd,Date) as Day,
	InvoiceNo,
	ItemDescription,
	MaintenanceTypes.JonasGroup,
	JonasGroups.GroupName as JonasGroupName,
	MaintenanceGLBridge.MaintenanceType,
	MaintenanceTypes.MaintTypeDescription,
	MaintenanceTypes.ReportingDescription,
	Type as EntryType,
	Qty as QtyValue,
	Net as NetValue,
	Tax as TaxValue,
	Gross as GrossValue,
	Profit as ProfitValue,
	CustOrderNo,
	ImportType,
	Category,
	RAND(CAST(NEWID() AS varbinary)) as UniqueID2,
	MiniPack,
	SiteSurveyDate,
	BacklogComments,
	Deposit,
	AssignedTo,
	MegJobNo,
	DirectDebit,
	Spare1,
	Spare2
from 
	SaleLedger
Left Join GLTypes on SaleLedger.GL = GLTypes.GLNo
Left Join MaintenanceGLBridge on SaleLedger.GL = MaintenanceGLBridge.GLNumber
Left Join MaintenanceTypes on MaintenanceGLBridge.MaintenanceType = MaintenanceTypes.MaintenanceType or MaintenanceTypes.MaintTypeDescription = SaleLedger.Category

Left Join JonasGroups on MaintenanceTypes.JonasGroup = JonasGroups.GroupNo

GO


--This should always be at the bottom
Print ''
Declare @Version varchar(3) = (Select top 1 ConfigSetting from Configuration where Label = 'DbVersion')
Print 'Updating Database Version from ' + @Version + ' to 2.1' 
Update Configuration set ConfigSetting = '2.1' where Label = 'DbVersion'






select case when count(*) = 0 then 0 else 1 end as marker from saleledgerextended where Spare1 !=null
select case when count(*) = 0 then 0 else 1 end as marker from saleledgerextended where Spare2 !=null