if exists (select * from sys.objects where type='p' and name='SP_GetLeadNote')
drop procedure SP_GetLeadNote
go
create procedure [dbo].[SP_GetLeadNote]
(@LeadProfileId int,
@TenantId int

)
as 
begin
  select 
  nt.[Description],
  nt.Id as NoteID,
  usr.FirstName,
  usr.LastName,
  nt.CreationTime,
  nt.LeadProfileId,
  nt.Userid,
  'Attachments/'+ nt.[FileName] as [FileName],
  nt.FileExtension,
  nt.FilePath

  from Notes nt 
  left join Users usr on usr.Id=nt.Userid
  Where nt.LeadProfileId=@LeadProfileId and nt.TenantId=@TenantId and nt.IsActive=1
  Order by nt.Id desc
  END

