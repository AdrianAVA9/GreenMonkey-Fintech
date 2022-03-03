
-- Create suscriptor
CREATE PROCEDURE CRE_SUSCRIPTOR_PR(
	@P_CODE nvarchar(4),
	@P_NAME nvarchar(50),
	@P_DESCRIPTION nvarchar(250),
	@P_OWNER nvarchar(50),
	@P_BASE_URL nvarchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO TBL_Suscriptor(Code, Name, Description, Owner, BaseUrl, Active)
	VALUES
		(@P_CODE, @P_NAME, @P_DESCRIPTION, @P_OWNER, @P_BASE_URL, 'S')
END

-- Retrieve all suscriptors
CREATE PROCEDURE RET_ALL_SUSCRIPTOR_PR
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Code AS CODE
		,Name AS NAME
		,Description AS DESCRIPTION
		,Owner AS OWNER
		,BaseUrl AS BASE_URL
	FROM TBL_Suscriptor WHERE Active = 'S'
END

-- Retrieve suscriptor by code
CREATE PROCEDURE RET_SUSCRIPTOR_PR(
	@P_CODE NVARCHAR(4)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Code AS CODE
		,Name AS NAME
		,Description AS DESCRIPTION
		,Owner AS OWNER
		,BaseUrl AS BASE_URL
	FROM TBL_Suscriptor WHERE Code = @P_CODE AND Active = 'S'
END

-- Update suscriptor
CREATE PROCEDURE UPD_SUSCRIPTOR_PR(
	@P_CODE nvarchar(4),
	@P_NAME nvarchar(50),
	@P_DESCRIPTION nvarchar(250),
	@P_OWNER nvarchar(50),
	@P_BASE_URL nvarchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TBL_Suscriptor
	SET Name = @P_NAME, Description = @P_DESCRIPTION, Owner = @P_OWNER, BaseUrl = @P_BASE_URL
	WHERE Code = @P_CODE;
END

-- Delete suscriptor
CREATE PROCEDURE DEL_SUSCRIPTOR_PR(
	@P_CODE nvarchar(4)
)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TBL_Suscriptor
	SET Active = 'N'
	WHERE Code = @P_CODE;
END

EXEC CRE_SUSCRIPTOR_PR '1028', 'GreenMonkey - Bank', 'Banco Green Monkey', 'Adrian Vega', 'https://green-monkeybank.azurewebsites.net'
EXEC RET_ALL_SUSCRIPTOR_PR
EXEC RET_SUSCRIPTOR_PR '1028'
EXEC UPD_SUSCRIPTOR_PR '1028', 'GreenMonkey - Bank', 'Banco Green Monkey', 'Adrian Vega', 'https://green-monkeybank.azurewebsites.net'
EXEC DEL_SUSCRIPTOR_PR '1028'




------------------------------------------- STORE PROCEDURE OF SUSCRIPTOR STATUS --------------------------------------------------

CREATE PROCEDURE CRE_SUSCRIPTOR_STATUS_PR(
	@P_CODE nvarchar(4),
	@P_STATUS nvarchar(10),
	@P_UPDATED_DATE DATETIME
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO TBL_Suscriptor_Status(Code, Status, UpdatedDate)
	VALUES
		(@P_CODE, @P_STATUS, @P_UPDATED_DATE)
END

CREATE PROCEDURE RET_SUSCRIPTOR_STATUS_BY_SUSCRIPTOR_PR(
	@P_CODE nvarchar(4)
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id AS ID,
		Code AS CODE,
		Status AS STATUS,
		UpdatedDate AS UPDATED_DATE
	FROM TBL_Suscriptor_Status
	WHERE Code = @P_CODE
	ORDER BY UpdatedDate
END

EXEC RET_SUSCRIPTOR_STATUS_BY_SUSCRIPTOR_PR '1028'
EXEC CRE_SUSCRIPTOR_STATUS_PR '1028', 'Offline', '2022-02-24 15:21:03'




------------------------------------------- STORE PROCEDURE OF CUSTOMER --------------------------------------------------

-- Create customer
CREATE PROCEDURE CRE_CUSTOMER_PR(
	@P_ID nvarchar(15),
	@P_NAME nvarchar(50),
	@P_LASTNAME nvarchar(50),
	@P_NICKNAME nvarchar(30),
	@P_STATUS nvarchar(15),
	@P_BIRTHDATE DATETIME
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO TBL_Customer(Id, Name, Lastname, Nickname, Status, Birthdate, RegisteredAt, Active)
	VALUES
		(@P_ID, @P_NAME, @P_LASTNAME, @P_NICKNAME, @P_STATUS, @P_BIRTHDATE, GETDATE(), 'S')
END


-- Retrieve customer by Id
CREATE PROCEDURE RET_CUSTOMER_PR(
	@P_ID NVARCHAR(15)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id AS ID
		,Name AS NAME
		,Lastname AS LASTNAME
		,Nickname AS NICKNAME
		,Status AS STATUS
		,Birthdate AS BIRTHDATE
		,RegisteredAt AS REGISTERED_AT
	FROM TBL_Customer WHERE Id = @P_ID AND Active = 'S'
END


-- Retrieve all customers
CREATE PROCEDURE RET_ALL_CUSTOMER_PR
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id AS ID
		,Name AS NAME
		,Lastname AS LASTNAME
		,Nickname AS NICKNAME
		,Status AS STATUS
		,Birthdate AS BIRTHDATE
		,RegisteredAt AS REGISTERED_AT
	FROM TBL_Customer WHERE Active = 'S'
END

CREATE PROCEDURE UPD_CUSTOMER_PR(
	@P_ID nvarchar(15),
	@P_NAME nvarchar(50),
	@P_LASTNAME nvarchar(50),
	@P_NICKNAME nvarchar(30),
	@P_STATUS nvarchar(15),
	@P_BIRTHDATE DATETIME
)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE TBL_Customer
	SET Name = @P_NAME, Lastname = @P_LASTNAME, Nickname = @P_NICKNAME, Status = @P_STATUS, Birthdate = @P_BIRTHDATE
	WHERE Id = @P_ID
END

-- Delete customer
CREATE PROCEDURE DEL_CUSTOMER_PR(
	@P_ID nvarchar(15)
)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE TBL_Customer
	SET Active = 'N'
	WHERE Id = @P_ID
END

EXEC CRE_CUSTOMER_PR '116410260', 'Adrián Antonio', 'Vega Acevedo', 'My Nick', 'Soltero', '1996-05-05'
EXEC UPD_CUSTOMER_PR '116410260', 'Adrián Antonio', 'Vega Acevedo', 'Adrián', 'Soltero', '1996-05-10'
EXEC DEL_CUSTOMER_PR '116410260'
EXEC RET_CUSTOMER_PR '116410260'
EXEC RET_ALL_CUSTOMER_PR



------------------------------------------- STORE PROCEDURE OF COIN --------------------------------------------------

-- Create customer
CREATE PROCEDURE CRE_COIN_PR(
	@P_FINTECH_CODE NVARCHAR(4),
	@P_NAME NVARCHAR(50)
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO TBL_Coin(Name, FintechCode) VALUES(@P_NAME, @P_FINTECH_CODE)
END

-- Retrieve all coins
CREATE PROCEDURE RET_ALL_COIN_PR
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Code AS CODE
		,Name AS NAME
		,FintechCode AS FINTECH_CODE
	FROM TBL_Coin
END

-- Retrieve coin by code
CREATE PROCEDURE RET_COIN_PR(
	@P_CODE INT
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Code AS CODE
		,Name AS NAME
		,FintechCode AS FINTECH_CODE
	FROM TBL_Coin
	WHERE Code = @P_CODE
END

-- Retrieve coin by fintech
CREATE PROCEDURE RET_COIN_BY_FINTECH_PR(
	@P_FINTECH_CODE NVARCHAR(4)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Code AS CODE
		,Name AS NAME
		,FintechCode AS FINTECH_CODE
	FROM TBL_Coin
	WHERE FintechCode = @P_FINTECH_CODE
END

EXEC CRE_COIN_PR '1028', 'MonkeyCoin'
EXEC RET_COIN_BY_FINTECH_PR '1028'
EXEC RET_ALL_COIN_PR
EXEC RET_COIN_PR 1



------------------------------------------- STORE PROCEDURE OF COIN --------------------------------------------------
CREATE PROCEDURE CRE_ACCOUNT_PR(
	@P_NAME NVARCHAR(50),
	@P_STATUS NVARCHAR(15),
	@P_CUSTOMER_ID NVARCHAR(15),
	@P_COIN_CODE INT
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ACCOUNT_ID INT;
	DECLARE @ACCOUNT_NUMBER NVARCHAR(14);
	DECLARE @MONKEY_CODE NVARCHAR(4) = '1028';

	SELECT @ACCOUNT_ID = ISNULL(MAX(Consecutive), 0) + 1
	FROM TBL_Account
	
	SET @ACCOUNT_NUMBER = CONCAT('CR_' , @MONKEY_CODE , '_' , RIGHT('000000' + CAST(@ACCOUNT_ID AS NVARCHAR(6)) , 6))

	INSERT INTO TBL_Account(Number, Consecutive, Name, Status, CustomerId, CoinCode, RegisteredAt)
	VALUES (@ACCOUNT_NUMBER, @ACCOUNT_ID, @P_NAME, @P_STATUS, @P_CUSTOMER_ID, @P_COIN_CODE, GETDATE())
END