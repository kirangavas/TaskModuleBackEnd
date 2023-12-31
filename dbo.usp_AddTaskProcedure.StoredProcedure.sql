USE [TaskModule]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddTaskProcedure]    Script Date: 13/12/2023 5:36:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddTaskProcedure]
    @taskname NVARCHAR(255),
    @taskdescription NVARCHAR(MAX),
    @assignto INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO TaskTable (taskname, taskdescription, assignto)
        VALUES (@taskname, @taskdescription, @assignto);

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO
