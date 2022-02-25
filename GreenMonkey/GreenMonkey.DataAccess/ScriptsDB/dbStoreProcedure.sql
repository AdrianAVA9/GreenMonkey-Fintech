
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

	SELECT * 
	FROM TBL_Suscriptor_Status
	WHERE Code = @P_CODE
END

EXEC RET_SUSCRIPTOR_STATUS_BY_SUSCRIPTOR_PR '1028'
EXEC CRE_SUSCRIPTOR_STATUS_PR '1028', 'Offline', '2022-02-24 15:21:03'