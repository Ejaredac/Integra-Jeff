CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_clientes_buscar`(tabinicio int, tabfinal int,idcli varchar(6), nombrevar varchar(100), direcciontext text)
BEGIN
/*Declaracion de variables*/
set @id=idcli;
set @nom=nombrevar;
set @dir=direcciontext;

/*Creacion de busqueda*/
drop temporary table if exists tblclientes;
create temporary table tblclientes
(select * from vistaclientes where `ID-Clientes` like concat('%',@id,'%') and `Nombre` like concat('%',@nom,'%') and `Direccion` like concat('%',@dir,'%'));

/*Creacion de busqueda paginada*/
drop temporary table if exists tblclientesbuscar;
create temporary table tblclientesbuscar (select * from tblclientes limit tabinicio,tabfinal);

/*Contar registros de busqueda*/
SELECT 
    COUNT(*) AS cantidad
FROM
    tblclientes;

/*Seleccionar paginado*/
SELECT 
    *
FROM
    tblclientesbuscar;
END