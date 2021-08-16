CREATE PROCEDURE CreateUser
@name char(50),
@email char(50)
AS
BEGIN
	INSERT INTO Users (Name, Email) VALUES (@name, @email);
END;

Go

CREATE PROCEDURE GetUserId
@name char(50),
@id INT OUTPUT
AS
BEGIN
	SELECT @id = Id FROM Users WHERE Name = @name;
END;

Go

CREATE PROCEDURE CreateAccount
@userId int,
@accountNumber int,
@balance decimal(38, 2)
AS
BEGIN
	INSERT INTO Accounts (UserId, Account_Number, Balance) VALUES (@userId, @accountNumber, @balance);
END;