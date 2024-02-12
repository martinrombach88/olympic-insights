USE DotNetCourseDatabase
GO

--on * press fn, ctrl, space to autogenerate
SELECT [Users].[UserId],
-- field alias
[Users].[FirstName] + ' ' + [Users].[LastName] AS FullName,
[Users].[Email],
[Users].[Gender],
--table alias
[Users].[Active],
[UserJobInfo].[JobTitle],
[UserJobInfo].[Department]
FROM TutorialAppSchema.Users AS Users
    JOIN TutorialAppSchema.UserJobInfo AS UserJobInfo
        ON UserJobInfo.UserId = Users.UserId
WHERE Users.Active = 1
ORDER BY Users.UserId DESC