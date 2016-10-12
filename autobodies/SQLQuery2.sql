CREATE TABLE [dbo].[TblVehicle] (
    [VehicleId]    INT   PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [Make]         VARCHAR (255) NOT NULL,
    [Model]        VARCHAR (255) NOT NULL,
    [Registration] VARCHAR (100) NOT NULL,
    [CustomerId]   INT           NOT NULL
  
);