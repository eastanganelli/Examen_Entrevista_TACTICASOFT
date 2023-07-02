DROP VIEW IF EXISTS SellsXClients
GO
CREATE VIEW SellsXClients
	AS 
		SELECT v.ID as 'Venta', v.IDCliente as 'Cliente', v.Fecha, vi.IDProducto, vi.PrecioUnitario, vi.Cantidad, vi.PrecioTotal
		FROM ventasitems as vi
		JOIN ventas as v ON v.ID = vi.IDVenta
		--GROUP BY v.ID