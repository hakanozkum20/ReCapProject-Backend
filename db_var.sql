
INSERT INTO dbo.Brands (Id,BrandName) VALUES (1,'Volvo')
INSERT INTO dbo.Brands (Id,BrandName) VALUES (3,'Renaoult')
INSERT INTO dbo.Brands (Id,BrandName) VALUES (2,'BMW')
INSERT INTO dbo.Colors (Id,ColorName) VALUES (1,'Kırmızı')
INSERT INTO dbo.Colors (Id,ColorName) VALUES (2,'Sarı')
INSERT INTO dbo.Colors (Id,ColorName) VALUES (3,'Yeşil')
INSERT INTO [dbo].[Cars] (Id,BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (2,1,1,2010,1000,'volvo temiz arac')