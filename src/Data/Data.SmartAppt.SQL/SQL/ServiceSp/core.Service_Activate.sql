create procedure core.Service_Activate
	@ServiceId INT
as

Begin
	set nocount on;

	update core.Service
	set IsActive = 1
	where ServiceId = @ServiceId

End