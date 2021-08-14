CREATE PROCEDURE CreateUser
@name char(50),
@email char(50),
@userId int,
@accountNumber int,
@balance decimal(38,2) output
AS
INSERT INTO Users (Name, Email) VALUES (@name, @email);

Go

CREATE PROCEDURE GetId
@name char(50),
@id int output
AS
SELECT @id = Id from Users where Name = @name;

Go

CREATE PROCEDURE CreateAccount
@userId int,
@accountNumber int,
@balance decimal(38, 2) output
AS
INSERT INTO Accounts (UserId, Account_Number, Balance) VALUES (@userId, @accountNumber, @decimal);
