USE [TaskModule]
GO
/****** Object:  StoredProcedure [dbo].[usp_LoadUserDetails]    Script Date: 13/12/2023 5:36:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LoadUserDetails]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        SELECT UserID,[UserFirstName],[UserLastName] 
		FROM Users U With(NoLock);

    END TRY
    BEGIN CATCH
        
    END CATCH;
END;
GO
