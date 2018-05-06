

CREATE PROCEDURE dbo.spPrizes
           @PlaceNumber int,
		   @PlaceName nvarchar(50),
		   @PrizeAmount money,
		   @PrizePercentage float,
		   @Id int  = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    Insert into [dbo].[Price] ([PlaceNumber],[Placename], [PriceAmount],[PricePercentage] )
	Values( @PlaceNumber,
		   @PlaceName ,
		   @PrizeAmount,
		   @PrizePercentage);

	select @Id = SCOPE_IDENTITY();
END
GO
