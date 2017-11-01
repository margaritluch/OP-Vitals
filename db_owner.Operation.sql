CREATE TABLE [db_owner].[Operation] (
    [OperationID]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [OPNurseFirstName]       NVARCHAR (20)  NOT NULL,
    [OPNurseLastName]        NVARCHAR (20)  NOT NULL,
    [OPNurseIDNumber]        NCHAR (6)      NOT NULL,
    [NumberOFAlarms]         INT            NULL,
    [Komments]               VARBINARY(MAX) NULL,
    [DurationOperation_hour] FLOAT (53)     NULL,
    [DurationOperation_min]  FLOAT (53)     NULL,
    [DurationOperation_sec]  BIGINT         NOT NULL,
    [PatientCPR]             NVARCHAR (MAX) NULL,
    [Complikations]          CHAR (1)       NULL,
    CONSTRAINT [pk_Operation] PRIMARY KEY CLUSTERED ([OperationID] ASC)
);

