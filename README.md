# parcial
## introduccion
Parcial Programación Distribuida
Usted ha sido contratado para hacer un aplicativo para que los vigilantes del estadio Atanasio Girardot controlen las entradas a un concierto. Para esto usted debe crear una base de datos con la siguiente tabla:

ID Boleta
Fecha de uso
Fue usada
Porteria por la que entro la persona (Norte, Sur, Oriental, Occidental)

El alimentardor de la base de datos debe crear 50,000 registros, con la fecha de uso en nulo, el fue usada en falso y la porteria en nulo. Y debe crear una interfaz gráfica que permita validar las boletas y de esta forma controlar la entrada al evento

Reglas de negocio:
Si el ID de la boleta no existe, debe sacar un mensaje de “Boleta no válida” ya que este es un posible fraude.
Si el ID es válido y la boleta no fue usada, el vigilante de una lista desplegable puede seleccionar la porteria y registrar el uso de la boleta, marcando la fecha y hora y la porteria donde fue usada.
Si el ID es válido y la boleta ya fue usada, debe mostrar un mensaje diciendo a que horas fue usada y por cual porteria ya que este es un posible fraude.
