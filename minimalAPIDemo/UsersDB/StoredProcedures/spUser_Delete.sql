﻿CREATE PROCEDURE [dbo].[spUser_Delete]
@Id int
AS
begin
	Delete from dbo.[User]
		where Id = @Id
end


