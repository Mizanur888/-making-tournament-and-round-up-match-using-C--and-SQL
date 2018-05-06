CREATE TABLE dbo.samplePrices  
(   Id int null,
	PlaceNumber int not null,
	Placename nvarchar(50),
	PriceAmount money,
	PricePercentage float
	
);  
 
INSERT INTO dbo.samplePrices  
    SELECT *
    FROM [Tournament].[dbo].[Price];