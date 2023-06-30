CREATE TABLE [dbo].[ventas] (
    [ID]        INT        IDENTITY (1, 1) NOT NULL,
    [IDCliente] INT        NOT NULL,
    [Fecha]     DATETIME   NULL,
    [Total]     FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC), 
    CONSTRAINT [FK_IDCliente] FOREIGN KEY (IDCliente) REFERENCES [dbo].[clientes](ID)
);