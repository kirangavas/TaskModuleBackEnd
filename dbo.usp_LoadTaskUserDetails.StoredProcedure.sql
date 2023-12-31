USE [TaskModule]
GO
/****** Object:  StoredProcedure [dbo].[usp_LoadTaskUserDetails]    Script Date: 13/12/2023 5:36:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LoadTaskUserDetails]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        SELECT taskname, taskdescription, CONCAT([UserFirstName],' ',[UserLastName]) AS UserFirstNameLastName
		FROM TaskTable TT With(NoLock)
		INNER JOIN Users U With(NoLock)
		ON TT.assignto=U.userid;
    END TRY
    BEGIN CATCH
        
    END CATCH;
END;
GO
