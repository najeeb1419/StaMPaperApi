if exists (select * from sys.objects where type='p' and name='SP_GetLeadStatusCount')
drop procedure SP_GetLeadStatusCount
go
create procedure [dbo].[SP_GetLeadStatusCount]
(@TenantId int)
as 
begin
select 
ls.Id,
ls.[Name],
[dbo].[fn_LeadStatusCount](ls.id,@TenantId) as Leadcounts
from
LeadStatuses ls
END

