
CREATE TABLE [TblJob] (
	[JobId] int PRIMARY KEY Identity(1,1) not null,
    [StartDate] VARCHAR(255) not null,
    [EndDate] VARCHAR(255) not null,
    [BookingMethod] VARCHAR(255)  not null,
    [VehicleId] INTEGER  not null,
    [JobTypeId] INTEGER  not null,
	[StaffId] int not null,
	FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[TblVehicle] ([VehicleId]),
	FOREIGN KEY ([JobTypeId]) REFERENCES [dbo].[TblJobType] ([JobTypeId]),
	FOREIGN KEY ([StaffId]) REFERENCES [dbo].[TblStaff] ([StaffId])


);



