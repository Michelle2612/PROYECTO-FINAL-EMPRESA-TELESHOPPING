#PROYECTO-FINAL-EMPRESA-TELESHOPPING.

#SISTEMA DE TELESHOPPING.

Construcción de Software 6-2 #sistema de ventas por catalogo de celulares.

El sistema te permite crear un usuario sea cliente, proveedor o como entidad de empresa de transporte. Una vez creado tu usuario de tipo cliente te permite modificar tus datos personales o incluso eliminar tu registro. Una vez ingresado al sistema podras ir a la opcion de catalogo de productos y elegir tus productos y al proveedor que vende los productos, tienes opcion de ver todo el catalogo de cada preveedor registrado y podra ser agregado a tu carro de compras donde se generara la orden de compra con todos los productos escogidos por el cliente y el total a pagar, y en ese momento puede escoger la empresa de transporte para traer su envio, y finalmente genera tu factura y la puedes guardar en formato pdf.

El usuario registardo como proveedor tiene la opcion de modificar y eliminar su usuario tambien te permite registrar productos al catalogo del sistema tambien como modificar o eliminar los productos.

El usuario registrado como empresa de transporte, tiene la opcion de modificar y eliminar su usuario tambien te permite que el cliente tenga la opcion de escoger un transporte para que sea entregado en su hogar o sitio de trabajo.

Proceso interno:

-Creamos la clase para para realizar la conexion con la base de datos con sus respectivas tablas. 

-En la clase de conexion creamos metodos con su respectiva funcionalidad. 

-En cada proyecto se llamara a la clase de conexion para incoorporar su funcion donde sea necesaria la ejecucion. 

-Cuenta con 2 tablas una de usuarios y otra de productos ya que tienen una relacion entre si.

-Se crea procedimientos almacenado para que guarde la informacion ingresada por el usuario.

-Para evitar errores creamos metodos de validaciones y sus respectivas excepciones. 

-Se crean pruebas unitarias para verificar su funcionalidad correcta.

