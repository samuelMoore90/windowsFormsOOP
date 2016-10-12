

CREATE TABLE [TblVehicle] (
	[VehicleId] int NOT NULL IDENTITY(1,1),
    [Make] VARCHAR(255) NOT NULL,
    [Model] VARCHAR(255) NOT NULL,
    [Registration] VARCHAR(100) NOT NULL,
    [CustomerId] VARCHAR(100) NOT NULL,
	CONSTRAINT PK_Vehicles PRIMARY KEY (VehicleId)	
);
GO

INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Mercedes', N'G9', N'12-Dl-84545', 1)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Vauxall', N'Astra', N'05-cn-7845', 1)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'VW', N'mkmwdk', N'05-dl-97325', 3)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES( N'Porche', N'Ireland', N'06-D-64318', 5)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Fiat', N'Cocos (Keeling) Islands', N'01-kk-4545', 15)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES( N'Nissan', N'Denmark', N'12-ww-55484', 19)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'VW', N'Reunion', N'14-wx-21211', 24)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Nissan', N'350z', N'15-kl-0000', 23)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Mercedes', N'C class', N'12-w-111', 18)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Jeep', N'Explorer', N'99-g-545', 14)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Alpha', N'kjsfs', N'06-D-6', 17)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'VW', N'Golf', N'09-D-878787', 9)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Nissan', N'Almera', N'11-cn-54455', 7)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Nissan', N'Almera', N'11-cww-54455', 7)
INSERT INTO TblVehicle ([Make], [Model], [Registration], [CustomerId]) VALUES ( N'Nissan', N'Almera', N'11-l-54455', 7)

