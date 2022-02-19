
-- Create suscriptor
CREATE PROCEDURE CRE_SUSCRIPTOR_PR(
	@CODE nvarchar(4),
	@NAME nvarchar(50),
	@DESCRIPTION nvarchar(250),
	@OWNER nvarchar(50),
	@BASE_URL nvarchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO TBL_Suscriptor(Code, Name, Description, Owner, BaseUrl, Active)
	VALUES
		(@CODE, @NAME, @DESCRIPTION, @OWNER, @BASE_URL, 'S')
END

-- Retrieve all suscriptors
CREATE PROCEDURE RET_ALL_SUSCRIPTOR_PR
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM TBL_Suscriptor WHERE Active = 'S'
END