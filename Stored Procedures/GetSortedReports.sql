
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetSortedReports
@Criteria varchar(50),
@asc varchar(10)
AS
BEGIN
	DECLARE @QUERY  varchar(300)
	SET NOCOUNT ON;
	SELECT @QUERY='SELECT * FROM dbo.[REPORT] ORDER BY '+@Criteria+' ' +@asc
    EXEC(@QUERY)
END
GO