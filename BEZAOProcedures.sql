ALTER PROCEDURE CreateUser
@name char(50),
@email char(50)
AS
INSERT INTO Users (Name, Email) VALUES (@name, @email);

Go

ALTER PROCEDURE GetUserId
@name NVARCHAR(50),
@id INT OUTPUT
AS
SELECT @id = Id FROM Users WHERE Name = @name;

Go

ALTER PROCEDURE CreateAccount
@userId int,
@accountNumber int,
@balance decimal(38, 2)
AS
INSERT INTO Accounts (UserId, Account_Number, Balance) VALUES (@userId, @accountNumber, @balance);