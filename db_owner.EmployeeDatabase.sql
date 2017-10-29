CREATE TABLE [db_owner].[EmployeeDatabase] (
    [EmployeeID]        NCHAR (6)     NOT NULL,
    [PassWord]          NVARCHAR (10) NOT NULL,
    [EmployeeFirstName] NVARCHAR (10) NOT NULL,
    [EmployeeLastName]  NVARCHAR (10) NOT NULL,
    [Profession]        NVARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

