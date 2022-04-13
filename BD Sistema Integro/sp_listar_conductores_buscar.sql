CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_conductores_buscar`(tabinicio int, tabfinal int,id varchar(5), nombre varchar(256))
BEGIN
/*Declaracion de variables*/
set @id=id;
set @nom = nombre;
/*Creacion de busqueda*/
drop temporary table if exists tblconductores;
create temporary table if not exists tblconductores (
select * from vistaconductores where 
`ID-Conductores` like concat('%',id,'%') and `Nombre` like concat('%',nom,'%')
);
/*Uso de la tabla paginada*/
drop temporary table if exists tblcondpag;
create temporary table if not exists tblcondpag (select * from tblconductores limit tabinicio, tabfinal);


/*------------------------------------------------------------------*/
/*Contar registros*/
select count(*) as cantidad from tblconductores;
/*Seleccion los registros de tabla temporal*/
select * from tblcondpag;
END