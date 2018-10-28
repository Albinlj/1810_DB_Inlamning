
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/27/2018 13:10:36
-- Generated from EDMX file: E:\Dropbox\projects\Csharp\1810_DB_Inlamning\02_Hotel\HotelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HotelDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BookingCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_BookingCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingPayment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payments] DROP CONSTRAINT [FK_BookingPayment];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_RoomBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomExtraBed]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExtraBeds] DROP CONSTRAINT [FK_RoomExtraBed];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[ExtraBeds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExtraBeds];
GO
IF OBJECT_ID(N'[dbo].[Payments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payments];
GO
IF OBJECT_ID(N'[dbo].[Rooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rooms];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [PostalCode] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Test] nchar(10)  NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Beds] int  NOT NULL,
    [MaxExtraBeds] int  NOT NULL,
    [RoomNumber] int  NOT NULL
);
GO

-- Creating table 'Extrabeds1'
CREATE TABLE [dbo].[Extrabeds1] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Bookings'
CREATE TABLE [dbo].[Bookings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateFrom] datetime  NOT NULL,
    [DateTo] datetime  NOT NULL,
    [DateBooked] datetime  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Room_Id] int  NOT NULL,
    [Customers_Id] int  NOT NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DatePaid] datetime  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [Booking_Id] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'ExtrabedBookings'
CREATE TABLE [dbo].[ExtrabedBookings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Extrabed_Id] int  NOT NULL,
    [Bookings_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Extrabeds1'
ALTER TABLE [dbo].[Extrabeds1]
ADD CONSTRAINT [PK_Extrabeds1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [PK_Bookings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'ExtrabedBookings'
ALTER TABLE [dbo].[ExtrabedBookings]
ADD CONSTRAINT [PK_ExtrabedBookings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Room_Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_RoomBooking]
    FOREIGN KEY ([Room_Id])
    REFERENCES [dbo].[Rooms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomBooking'
CREATE INDEX [IX_FK_RoomBooking]
ON [dbo].[Bookings]
    ([Room_Id]);
GO

-- Creating foreign key on [Booking_Id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_BookingPayment]
    FOREIGN KEY ([Booking_Id])
    REFERENCES [dbo].[Bookings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingPayment'
CREATE INDEX [IX_FK_BookingPayment]
ON [dbo].[Payments]
    ([Booking_Id]);
GO

-- Creating foreign key on [Customers_Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_BookingCustomer]
    FOREIGN KEY ([Customers_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingCustomer'
CREATE INDEX [IX_FK_BookingCustomer]
ON [dbo].[Bookings]
    ([Customers_Id]);
GO

-- Creating foreign key on [Extrabed_Id] in table 'ExtrabedBookings'
ALTER TABLE [dbo].[ExtrabedBookings]
ADD CONSTRAINT [FK_ExtrabedExtrabedBooking]
    FOREIGN KEY ([Extrabed_Id])
    REFERENCES [dbo].[Extrabeds1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExtrabedExtrabedBooking'
CREATE INDEX [IX_FK_ExtrabedExtrabedBooking]
ON [dbo].[ExtrabedBookings]
    ([Extrabed_Id]);
GO

-- Creating foreign key on [Bookings_Id] in table 'ExtrabedBookings'
ALTER TABLE [dbo].[ExtrabedBookings]
ADD CONSTRAINT [FK_ExtrabedBookingBooking]
    FOREIGN KEY ([Bookings_Id])
    REFERENCES [dbo].[Bookings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExtrabedBookingBooking'
CREATE INDEX [IX_FK_ExtrabedBookingBooking]
ON [dbo].[ExtrabedBookings]
    ([Bookings_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------