
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
	SELECT * FROM TBL_Suscriptor WHERE Active = 'S'
END

-- Retrieve suscriptor by code
CREATE PROCEDURE RET_SUSCRIPTOR_PR(
	@P_CODE NVARCHAR(4)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM TBL_Suscriptor WHERE Code = @P_CODE AND Active = 'S'
END