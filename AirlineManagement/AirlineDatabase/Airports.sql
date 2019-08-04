CREATE TABLE [dbo].[Airports]
(
	[Name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [City] VARCHAR(50) NULL, 
    [Country] VARCHAR(50) NULL, 
    [IATA3] VARCHAR(3) NULL, 
    [Latitude] DECIMAL NULL, 
    [Longitude] DECIMAL NULL
)
