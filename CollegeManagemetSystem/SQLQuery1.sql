CREATE TABLE [dbo].[Staff]
(
	[StaffId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [StaffName] VARCHAR(50) NOT NULL, 
    [StaffGender] VARCHAR(50) NOT NULL, 
    [StaffShift] VARCHAR(50) NOT NULL
)
