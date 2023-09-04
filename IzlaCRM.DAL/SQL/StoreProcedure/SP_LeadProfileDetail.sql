if exists (select * from sys.objects where type='p' and name='SP_LeadProfileDetail')
drop procedure SP_LeadProfileDetail
go
create procedure [dbo].[SP_LeadProfileDetail]
(@LeadProfileId int)
as 
begin
    select 
  pl.BusinessNo,
  pl.[Name],
  pl.EmailAddress,
  pl.Id as LeadProfileId,
  pl.BusinessNo,
  pl.Position,
  pl.PhoneNo,
  pl.[State],
  pl.Company,
  pl.[Description],
  pl.ZipCode,
  c.[Name] as CountryName,
  ct.[Name] as CityName,
  ptcb.[Name] as PreferTimeCallBack,
  lsrc.[Name] as LeadSourceName,
  lst.[Name] as LeadStatusName,
  bt.[Name] as BusinessTypeName,
  pl.Website,
  pl.[address],
  pl.IBOBussinessType,
  pl.BusinessNo,
  pl.id,
  pl.id as LeadNo,
  pl.[Address],
  pl.PublicLead,
  usr.FirstName,
 lg.[Name] as languageName,
 pl.IBOEmailAddress,
 pl.confirmRequestAuthorization as Declaration,
 pl.SecondayPhoneNo,
 pl.ReferredBy
  from LeadsProfiles pl
  left join Countries c on c.Id= pl.CountryId
  left join Cities ct on ct.Id=pl.CityId
  left join preferredTimeCallBacks ptcb on ptcb.Id=pl.PreferTimeToCallId
  left join LeadSources lsrc on lsrc.Id=pl.LeadSourceId
  left join LeadStatuses lst on lst.Id=pl.LeadStatusId
  left join BusinessTypes bt on bt.Id=pl.BusinessTypeId
  left join Users  usr on usr.Id=pl.CreatorUserId
  left join Languages lg on lg.Id=pl.LanguageId
  where pl.Id=@LeadProfileId

END