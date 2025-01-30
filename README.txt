Nombre del sistema: Sistema para Gestion de Vacaciones

1. Tecnologias

Programado en C# con Visual Visual Studio 2022 como IDE y SQL Server Management Studio 20 como motor de base de datos. 
** La carpeta cuenta con otra carpeta llamada Back Up Data Base la cual contiene el back up de la base de datos llamada VACACIONES

2. Ingreso al sistema:

Rol Jefe/ usuario: 801430360 password:123
Rol Empleado/ usuario: 120220686 password:123

3. Módulos
*** Login 
- El sistema cuenta con un módulo login el cual permite un acceso al sistema segun sea el rol lo redirecciona al modulo correspondiente
jefe o empleado. 

*** En el módulo de jefatura, el jefe 
- podrá visualizar desde un datagridview un listado de todos los empleados registrados en la base de datos.
- Podrá vizualizar las solicitudes realizadas por los funcionarios tanto de dias de vacaciones como de reversion de dias.
- aprobar o rechazar solicitudes.

una vez el jefe aprueba o rechaza solicitudes se verán reflejados los cambios en la base de datos, (suma o resta de dias de vacaciones)


*** En el módulo Empleado podra ver información como nombre completo, fecha de ingreso, jefe, fecha de proximas vacaciones y 
cantidad de dias disponibles de vacaciones. 

- podrá solicitar a jefatura dias de vacaciones seleccionando una fecha de inicio y una fecha final, la cual una vez enviada estará pendiente
de aprobación por jefatura.

- También podrá solicitar reversión de dias de vacaciones a jefatura 