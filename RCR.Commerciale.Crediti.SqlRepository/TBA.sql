CREATE DATABASE Crediti;
USE [Crediti]
GO


CREATE TABLE Cliente (
        IdCliente int,
        Nome varchar(50),
        Cognome varchar(50),
        TipoDocumento char(3),
        NumeroDocumento varchar(11),
        Sesso char(1),
        DataNascita DateTime,
        Indirizzo  varchar(200),
        Cap int,
        StatoCivile char(1)
);

USE [Crediti]
GO

CREATE PROCEDURE dbo.sp_get_cliente
(
@IdCliente int
)
AS
BEGIN
SELECT [IdCliente]
      ,[Nome]
      ,[Cognome]
      ,[TipoDocumento]
      ,[NumeroDocumento]
      ,[Sesso]
      ,[DataNascita]
      ,[Indirizzo]
      ,[Cap]
      ,[StatoCivile]
  FROM [dbo].[Cliente]
  WHERE IdCliente = @IdCliente
END

USE [Crediti] 
CREATE PROCEDURE dbo.sp_get_list_clienti 
AS
BEGIN
SELECT [IdCliente]
      ,[Nome]
      ,[Cognome]
      ,[TipoDocumento]
      ,[NumeroDocumento]
      ,[Sesso]
      ,[DataNascita]
      ,[Indirizzo]
      ,[Cap]
      ,[StatoCivile]
  FROM [dbo].[Cliente] 
END

------------------------------------------------------------------------------------------------

USE [Crediti];
CREATE TABLE Credito (
         IdCredito int IDENTITY(1,1) PRIMARY KEY,
        TipoCredito int,
        IdCliente int,
        Data DateTime,
        Ammontare decimal(18,2),
        GiornoPago DateTime,
        TassaInteresse decimal(18,2),
        Commissioni decimal(18,2) 
);

USE [Crediti]
GO

CREATE PROCEDURE dbo.sp_get_credito
(
@IdCredito int
)
AS
BEGIN
SELECT [IdCredito]
      ,[TipoCredito]
      ,[IdCliente]
      ,[Data]
      ,[Ammontare]
      ,[GiornoPago]
      ,[TassaInteresse]
      ,[Commissioni]
  FROM [dbo].[Credito]
  WHERE IdCredito = @IdCredito
END
   
CREATE PROCEDURE dbo.sp_get_list_crediti 
AS
BEGIN
SELECT [IdCliente]
      ,[Nome]
      ,[Cognome]
      ,[TipoDocumento]
      ,[NumeroDocumento]
      ,[Sesso]
      ,[DataNascita]
      ,[Indirizzo]
      ,[Cap]
      ,[StatoCivile]
  FROM [dbo].[Cliente] 
END


USE [Crediti]
GO

CREATE PROCEDURE dbo.sp_save_credito 
( 
        @TipoCredito int,
        @IdCliente int,
        @Data DateTime,
        @Ammontare decimal(18,2),
        @GiornoPago DateTime,
        @TassaInteresse decimal(18,2),
        @Commissioni decimal(18,2),
		@IdCredito int  OUTPUT
)
AS
BEGIN
INSERT INTO [dbo].[Credito]
           ([TipoCredito]
           ,[IdCliente]
           ,[Data]
           ,[Ammontare]
           ,[GiornoPago]
           ,[TassaInteresse]
           ,[Commissioni])
     VALUES
           (@TipoCredito,
            @IdCliente, 
            @Data,
            @Ammontare, 
            @GiornoPago,
            @TassaInteresse, 
            @Commissioni)
SET @IdCredito = SCOPE_IDENTITY()
RETURN @IdCredito 
END
GO

USE [Crediti]
GO

CREATE PROCEDURE dbo.sp_update_credito 
( 
		@IdCredito int,
        @TipoCredito int,
        @IdCliente int,
        @Data DateTime,
        @Ammontare decimal(18,2),
        @GiornoPago DateTime,
        @TassaInteresse decimal(18,2),
        @Commissioni decimal(18,2) 
)
AS
BEGIN
UPDATE [dbo].[Credito]
            SET TipoCredito = @TipoCredito
           ,    IdCliente = @IdCliente
           ,    Data = @Data
           ,    Ammontare = @Ammontare
           ,    GiornoPago = @GiornoPago
           ,    TassaInteresse = @TassaInteresse
           ,    Commissioni = @Commissioni
    WHERE IdCredito = @IdCredito
END
GO



USE [Crediti]
GO

CREATE PROCEDURE dbo.sp_delete_credito 
( 
		@IdCredito int 
)
AS
BEGIN
DELETE [dbo].[Credito] 
    WHERE IdCredito = @IdCredito
END
GO