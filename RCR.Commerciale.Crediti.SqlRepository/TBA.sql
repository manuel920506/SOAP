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
