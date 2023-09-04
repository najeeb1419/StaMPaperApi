if exists (select * from sys.objects where type='p' and name='SP_GetLeadProfile')
drop procedure SP_GetLeadProfile
go
create procedure [dbo].[SP_GetLeadProfile]
(@TenantId int)
as 
begin
select 
pl.Id,
pl.[Name] as LeadProfileName,
pl.Company,
pl.EmailAddress,
pl.PhoneNo,
bt.[Name] as BusinessTypeName,
ls.[Name] as leadStatusName
from 
LeadsProfiles pl 
left join BusinessTypes bt on bt.Id=pl.BusinessTypeId
left join LeadStatuses ls on ls.Id=pl.LeadStatusId
where pl.TenantId=@TenantId
order by pl.Id Desc
END

