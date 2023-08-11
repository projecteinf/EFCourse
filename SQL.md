# Obtenir les taules de la base de dades:
```sql
select * from EFCourse.INFORMATION_SCHEMA.TABLES;
go
```
# Obtenir totes les bases de dades del sistema
```sql
select * from sys.databases;
go
```
# Selecció de totes les files de la taula
```sql
use EFCourse;
select * from Categories;
go
```
# Veure totes les migracions
```sql
use EFCourse;
select * from __EFMigrationsHistory
go
```
# Describe table
```sql
use EFCourse;
:setvar SQLCMDMAXVARTYPEWIDTH 30
:setvar SQLCMDMAXFIXEDTYPEWIDTH 30
exec sp_columns Genres
go
```
