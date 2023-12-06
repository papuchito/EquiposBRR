
/* Creando un login en la base de datos para que la aplicación acceda solo a lo mínimo. */

use master
go

if not exists (select name from master.sys.server_principals
    where name = 'EquiposBRRApl')
begin
    create login EquiposBRRApl with password = 'Equip0BRR&+Data(8)', default_database = gestionbrr, check_expiration = off, check_policy = off;
end
go

/* Creando un usuario para la base de datos, los usuarios son por instancias de la base de datos.*/ 
use gestionbrr
go

if not exists (select name from master.sys.database_principals
    where (type = 'S') and (name = 'EquiposBRRApl'))
begin
    create user EquiposBRRApl from login EquiposBRRApl

    exec sp_addrolemember @rolename = 'db_datareader', @membername = 'EquiposBRRApl'
    exec sp_addrolemember @rolename = 'db_datawriter', @membername = 'EquiposBRRApl'

    grant select, insert, update on SCHEMA::dbo to EquiposBRRApl;
end
go
