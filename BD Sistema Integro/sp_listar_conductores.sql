CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_conductores`(tabinicio int, tabfinal int)
BEGIN
/*Creacion de tabla personal paginada*/
drop temporary table if exists tblconductores;
create temporary  table if not exists tblconductores(select * from vistaconductores limit tabinicio, tabfinal);

/*Total de registros*/
select count(*) as cantidad from vistaconductores;

/*Seleccion de tabla personal*/
select * from tblconductores;
END