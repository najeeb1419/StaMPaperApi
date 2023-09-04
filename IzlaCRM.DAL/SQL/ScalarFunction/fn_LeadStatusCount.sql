IF EXISTS (SELECT *
           FROM   sys.objects
           WHERE  object_id = OBJECT_ID(N'[dbo].[fn_LeadStatusCount]')
                  AND type IN ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
  DROP FUNCTION [dbo].[fn_LeadStatusCount]
GO

CREATE FUNCTION [dbo].[fn_LeadStatusCount](
  @LeadStatusId INT,
  @TenantId INT
)
RETURNS INT
AS 
BEGIN
  DECLARE @TotalCount INT;

  SELECT @TotalCount = COUNT(lp.Id)
  FROM LeadsProfiles lp 
  WHERE lp.TenantId = @TenantId AND lp.LeadStatusId = @LeadStatusId;

  RETURN @TotalCount;
END;