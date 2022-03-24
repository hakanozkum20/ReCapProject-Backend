CREATE TABLE [dbo].[Cars]
(
	[Id] INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	[Description]	NVARCHAR (40) NOT NULL,
	[BrandId]	INT NULL,
	[ColorId]	INT NULL,
	[ModelYear]	SMALLINT NULL,
	[DailyPrice]	MONEY	NULL,

	CONSTRAINT [PK_CarsId] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Cars_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([Id]),
	CONSTRAINT [FK_Cars_Colors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [Description]
    ON [dbo].[Cars]([Description] ASC);


GO
CREATE NONCLUSTERED INDEX [BrandId]
    ON [dbo].[Cars]([BrandId] ASC);


GO
CREATE NONCLUSTERED INDEX [ColorId]
    ON [dbo].[Cars]([ColorId] ASC);

GO
CREATE NONCLUSTERED INDEX [ModelYear]
    ON [dbo].[Cars]([ModelYear] ASC);

GO
CREATE NONCLUSTERED INDEX [DailyPrice]
    ON [dbo].[Cars]([DailyPrice] ASC);


