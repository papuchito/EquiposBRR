
Requerimientos Sistema de manejo de equipos
===========================================

El banco de reservas actualmente usa Microsoft Dinamics para el segimiento de los activos, sin embargo entiendo que hay un espacio para hacer un sistema que permita manejar los pormenores del manejo de equipos, un sistema con mucha más información al que tengan acceso los propios usuarios que usan los equipos. Este sistema serviría para administrar la información de todos los equipos su localización el área a la que pertenecen, cuando se adquirieron, cuando se les dio de baja, pero también detalles como que sistema operativo tienen, cuando se llevaron al taller a darle un mantenimiento, incluso solicitar esos mantenimientos, cuando fueron asignados a otro empleado, etc. que creo que también son detalles útiles.

La idea es que todo el personal que use un equipo de algún tipo desde una calculadora hasta un vehículo, tenga acceso a este sistema y lo alimente, de manera que el sistema sirva para rastrear los equipos en todo momento, incluso para solicitar equipos que se necesiten.

Este documento está escrito usando [markdown](https://www.markdownguide.org/), que vendría a ser un protocolo ligero para formatear documentos de texto plano, como poner links, y negritas. En caso de que se necesiten funcinoalidades de formato adicionales se usarán las que propone [doxygen](https://www.doxygen.nl/manual/markdown.html).


Requerimientos
--------------

En esta sección se encuentran los requerimientos funcionales. Cada requerimiento es una funcionalidad o un aspecto del sistema que se espera que tenga la solución final. No todos los requerimientos tienen que ser contestados en la implementación inmediata, pero se espera que eventualmente sean implementados. Las funcionalidades deberían irse implementando poco a poco.

El objetivo es que los requerimientos estén ordenados de lo básico y más prioritario, necesario y útil, a lo más difícil, complejo y casos más específicos que resuelven situaciones más aisladas.

Los requerimientos están agrupados en subsecciones de acuerdo con el tipo de funcinalidad que proponen y están númerados para que se haga referencia entre ellos, entre los requerimientos relacionados y desde otros documentos y los fuentes de la aplicación cuando estén siendo implementados.

Estos son los requerimientos:


### Lo básico ###

RF1 - La información principal que maneja el sistema de un equipo son tipo, marca, modelo, color, condicion, número de activo del banco, Número serial de fábrica, fecha de fabricación, Fecha de adquisición, fecha de expiración de garantía 1, fecha de expriración de garantía 2, fecha final vida útil, fecha de descarte, precio.

RF2 - Un equipo siempre tiene que estar asignado a un área. La persona responsable de los equipos en el área siempre es responsable por el equipo.

RF3 - Se le puede asignar un equipo a un empleado, como responsable directo de ese equipo o quien lo está usando. Un equipo se puede asignar aunque no siempre tiene que estar asignado a un empleado. Esté o no asignado a un empleado siempre tiene un responsable superior que es el encargado de equipos del área.

RF4 - El sistema tiene que tener 1 registro por cada equipo existente. Cada eqipo manejado de forma individual con su propia información e historial, contrario a agruparlos y tener en alguna tabla un solo identificador y un campo de cantidad "Monitores X 10".

RF5 - El sistema debe llevar la información del historial del equipo, eventos de movimiento del equipo entre áreas, asignación a un empleado, mantenimiento, instalación de un software o actualización, daño por choque o un accidente, reparación, modificación, etc.

RF6 - Como los equipos van a moverse entre las áreas del banco, el sistema va a tener que manejar el organigrama del banco, empresas, áreas administrativas, sub-áreas, cada localización con su código usado internamente.

RF7 - El sistema tiene una seguridad y unos niveles de acceso. Hay restricciones de las acciones de acuerdo con el rol de la persona en el sistema, al área a la que pertenece, si el equipo está asignado a él o no.


### Acciones ###

RF8 - Que se puedan crear nuevos tipos de equipos.

RF9 - Que se puedan crear nuevas marcas para esos tipos de equipos.

RF10 - Que se puedan crear modelos para tipos de equipos de esas marcas.

[comment]: <> (RF11 - Se pueden crear nuevas áreas.)

[comment]: <> (RF12 - Se puede modificar la información de un área.)

[comment]: <> (RF13 - A un área se le puede designar una área padre.)

[comment]: <> (RF14 - Se pueden registrar nuevos empleados.)

RF15 - En un área se puede seleccionar cual es el empleado que es "encargado de los equipos del área".

RF16 - Que se puedan hacer solicitudes de equipos especificando tipos, marca, modelo y características.

RF17 - Que las solicitudes puedan ser contestadas o quedar pendientes, o rechazadas.

RF18 - Que se puedan registrar equipos que compra el banco. Una compra no está obligada a estar asociada con una solicitud, pero podría estarlo.

RF19 - Que se pueda transferir un equipo de un área a otra.

RF20 - Ques se puedan descartar equipos, que dejan de ser del banco, pero que su historial mientras existieron en la institución permanezca en el sistema.

RF21 - Cuando se descarta un equipo hay que establecer una razón para descartarlo.

RF22 - Que se puedan agregar propiedades de forma dinámica a los tipos de equipo. Ej. Un aire acondicionado tiene capatidad de enfriamiento, un monitor tiene una resolución y unas capacidades específicas.

RF23 - Que se puedan agregar propiedades dinámicas a los modelos. Algunos modelos de un equipo tienen características especiales "este modelo de teléfono soporta 2 chips", "este modelo de monitor tiene conexiones USB", etc.

RF24 - Propiedades dinámicas para equipos específicos.


### Pantallas ###

RF25 - Tiene que haber una pantalla de detalle del equipo que se use tanto para ingresar un equipo nuevo, como para ver los detalles del equipo, como para modificar los datos de un equipo existente.

RF26 - Tiene que haber una pantalla de lista de equipos en la que se pueda filtrar por diferentes criterios y combinaciones de esos criterios, área, asginado, tipo, marca, modelo.

RF27 - Formulario de traslado SU-VAR-203, pantalla para mostrar información de traslado de mobiliario.

RF28 - La pantalla del formulario SU-VAR-203, tiene que tener, la información del área que envía los equipos, la información del área que está supuesto a recibirlos, la fecha, un teléfono de contacto, el código del empleado que envía los equipos, el código del empleado que debería recibirlos, una causa para el traslado, campos para firmas, campos para la información del empleado que recibe los equipos, nombre, código, puesto, fecha, hora y para cada uno de los equipos trasladados tiene que poderse poner su número de activo, descripción, modelo, marca, número serie, color, condición y observaciones.

RF29 - Tiene que haber una pantalla de la lista de las solicitudes donde se puden consultar las solicitudes existentes y desde esta agregar solcitudes nuevas.

RF30 - Tiene que haber una pantalla de detalles de solicitudes donde se vean los detalles de las solicitudes y se puedan modificar los detalles de solicitudes existentes.


### Consultas ###

RF31 - Que se pueda hacer una consulta para saber cuantos equípos tiene un área específica.

RF32 - Que se pueda hacer una consulta para saber cuales equipos ha usado un empleado, a nivel de historia que equipos han pasado por sus manos.

RF33 - Que se pueda hacer un consulta para saber el historial de un equipo, todas las áreas y personas a las que ha sido asignado, todos los eventos relacionados, reparaciones, mantenimientos, etc.

RF34 - Que se pueda hacer una consulta para saber cuantos equipos hay con un sistema operativo específico.


### Reportes ###

RF35 - Tiene que poder imprimir un formulario SU-VAR-203 de la pantalla en el requerimiento RF27, RF28.


### Seguridad ###

RF36 - Hay una persona designada "encargado de un área", solo esta persona puede manipular a todos los equipos de un área.

RF37 - El "encargado de un área" en cuanto a equipos se refiere es designado por el supervisor del área o alguna persona con la autoridad para hacerlo en el sistema.

RF38 - Una persona encargada de equipos del área o el empleado al que se le asignó el equipo puede solicitar que se repare un equipo.


Casos de uso propuestos
-----------------------

Los casos de uso son las interacciones entre el sistema y los diferentes actores y sub-sistemas con un fin específico.


### Solicitud de un equipo ###

Un área necesita una laptop para un empleado nuevo que van a contratar para una posición.

- El encargado de equipos del área entra a la pantalla de solicitudes y hace click en "nueva solicitud" (RF29).
- El sistema le muestra un formulario en blanco para llenar la solicitud.
- El usuario introduce los datos que desearía que tuviera esa laptop, tipo de equipo "laptop", propiedad dinámica "procesador" "AMD Rizen 7", propiedad dinámica "memoria ram" "8GB", propiedad dinámica "disco duro" "1 TB" (RF22, RF23).
- El usuario guarda la solicitud haciendo click en el botón guardar.
- El sistema guarda la solicicutd y lo devuelve a la pantalla de solicitudes donde se ve que hay una nueva solicitud registrada.
- Fin del caso.


### Adquisición de un equipo nuevo ###

- Se adquirió un equipo nuevo, un usuario entra a la lista de equipos y le da al botón de agregar nuevo equipo.
- El equipo nuevo se puede asociar o no a una solicitud de equipo que haya en el sistema.
- Si el equipo tenía una solicitud que viene desde un área se traslada a esa área.
- Si no hay solicitud para ese equipo queda guardado en el almacen.
- Se registra en el historial del equipo la fecha en la que ingreso (RF5).
- Fin del caso

### Traslado, movimiento de un equipo de un área a otra ###

- El encargado de equipo de un área necesita que se traslade un equipo a otra área.
- Entra al sistema y va a la pantalla de traslado.
- El sistema le muestra los campos que debe llenar para ese traslado.
- El usuario los llena, imprime el formulario SU-VAR-203 correspondiente y le pega el papel impreso al equipo.
- El equipo es recibido primero por el área de mensajería que lo va a trasladar.
- Se registra en el historial que el equipo está en transito.
- El equipo es recibido por el área destino.
- El usuario que está puesto como receptor del equipo entra al sistema y confirma que recibió el equipo en cuestión.
- Se registra en el historial que el equipo fue recibido (RF5).
- Fin del caso

### Asignación de un equipo a un empleado ###

- Se necesita asignarle un equipo que está en el poder de un área a un empleado.
- El empleado encargado de los equipos del área entra al sistema a la pantalla de asignación.
- Le asgina el equipo a un empleado independientemente de si este equipo ya estaba asignado a otro empleado o si no estaba asignado a nadie.
- Se registra en el historia que el equipo fue asignado a un empleado (RF5).
- Fin del caso.

### Descarte de un equipo ###

Este caso de uso se corresponde con el requerimiento RF20 que pide que se puedan descartar equipos.

- El empleado encargado de los equipos quiere hacer un descarte de un equipo.
- Entra al sistema va al detalle del equipo y la da al botón de descartar.
- El sistema empieza el flujo de descarte del equipo.
- Primero se traslada el equipo al área de soporte paar una evaluación del estado del equipo antes de descartarlo.
- El sistema organiza este traslado.
- El empleado puede imprimir el formulario SU-VAR-203 correspondiente.
- El empleado recibe la confirmación de que el equipo fue evaluado.
- El sistema prepara ahora otro traslado ahora al almacen
- El empleado que tiene el equipo en su poder (soporte), imprime el SU-VAR-203 del otro traslado hacia el almacen.
- Se registra en el historial que se descartó el equipo y se registran las razones para este descarte (RF5).
- Fin del caso.
