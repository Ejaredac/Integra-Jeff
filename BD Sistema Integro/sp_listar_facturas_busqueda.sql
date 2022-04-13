CREATE PROCEDURE `sp_listar_facturas` (tabinicio int, tabfinal int, _id varchar(16), _nombre varchar(200),
_numero varchar(45),_fechafactura datetime, _dolares varchar(20),_tipocambio varchar(20),_subtotalpesos varchar(20),
_iva varchar(20),_retencion varchar(20), _totalpesos varchar(20),
_fechapago datetime, _fechavencimiento datetime, _estatuscobro bool)
BEGIN
/*Declarar variables*/
set @id = concat('%',_id,'%');
set @nom = concat('%',_nombre,'%');
set @num = concat('%',_numero,'%');
set @ffact = _fechafactura;
set @dol = concat('%',_dolares,'%');
set @tcam = concat('%',_tipocambio,'%');
set @stp = concat('%',_subtotalpesos,'%');
set @iva = concat('%',_iva,'%');
set @ret = concat('%',_retencion,'%');
set @tot = concat('%',_totalpesos,'%');
set @fpag = _fechapago;
set @fven = _fechavencimiento;
set @est = _estatuscobro;
/*Crear tabla temporal de busqueda*/
drop temporary table if exists tblfactbusq;
create temporary table tblfactbusq (select * from vistaremisionesfacturas
where `ID-Remisiones y Facturas` like @id and `Nombre del cliente` like @nom and `Numero de factura` like @num and `Fecha de la factura` >= @ffact
and `Dolares` like @dol and `Tipo de cambio (Dolares)` like @tcam and `Subtotal en Pesos` like @stp and `IVA` like @iva and `Retencion` like @ret
and `Total en pesos` like @tot and `Fecha de pago` >= @fpag and `Fecha de vencimiento` >= @fven and `Estatus de cobro` like @est);

/*Crear tabla paginada*/
drop temporary table if exists
END
