# Labo2 Parcial1 2022

## Login

![image](https://user-images.githubusercontent.com/70229188/168859858-6a2bdb22-2370-4883-b6c5-45b3857c51ce.png)

El primer formulario que se abre en el medio de la pantalla al iniciar el programa es el Login. Al cargarse el formulario tambien se cargan los datos hardoceados, los botones Admin y Empleado auto-rellenan los textbox de nombre y contraseña con datos de un usuario administrador o empleado. Si manualmente se ingresan datos incorrectos o se intenta ingresar sin haber rellenado los textbox, se volvera visible un label que dice que nombre o contraseña son incorrectos. El boton salir abre un meesagebox que nos pregunta si deseamos salir, si se clickea la cruz de la esquina superior derecha se cierra el formulario sin preguntar. Si los datos son correctos el usuario podra loguearse y sonara un sonido de confirmacion del logueo.

## Menu Principal

Menu para usuario empleado ![image](https://user-images.githubusercontent.com/70229188/168860947-740142d8-0aa0-4bf9-8064-9007e7ca9af5.png)

Menu para usuario administrador ![image](https://user-images.githubusercontent.com/70229188/168861565-accc9339-6fed-4a33-92ab-c17b1f3bcb78.png)

Lo primero que ve un usuario a loguearse es su perfil donde puede cambiar su nombre y/o su contraseñna. El menu principal tiene distintas secciones. Del lado superior derecho del formulario hay dos botones, el mas cercano al borde es para cerrar la aplicacion, el otro es para desloguear la sesion iniciada.

## Secciones

#### Bar

En la seccion bar se encuentran los botones con los numeros de mesa. Al presionar uno de esos botones se abre un nuevo formulario con un menu para ordenar comida que quedara registrada en el textbox. Si se presiona cancelar orden se puede elegir cerrar la orden sin cobrar, lo que quedo en el textbox si no se quito no se agragara al inventario. Hasta que se cierre la orden sea cobrandola o cancelandola, el label asociado al boton de la mesa cambiara de libre a ocupado

![image](https://user-images.githubusercontent.com/70229188/168862148-ad489542-3042-4b4b-ac36-679bcd0a2b55.png) ![image](https://user-images.githubusercontent.com/70229188/168862265-2e2e16aa-0259-4fc0-9ac9-8c2bee93f583.png) ![image](https://user-images.githubusercontent.com/70229188/168875133-f9f30d29-6049-4b05-9eec-534f2401a88d.png)
 ![image](https://user-images.githubusercontent.com/70229188/168863299-1882ce68-eb49-4f53-9499-b4ef3a81bc0a.png)

### Stock

En cuanto a la seccion stock, el usuario empleado solo puede acceder para ver que productos estan cerca de acabarse. El usuario admin es el unico que puede agregar nuevos productos o refillear los productos que ya hay en stock
![image](https://user-images.githubusercontent.com/70229188/168863742-f7ab55ae-50d8-4318-a43f-261402e23c49.png) ![image](https://user-images.githubusercontent.com/70229188/168863849-aa2dcd9f-6835-45c2-b81f-425d1093cb52.png)

### Tickets
En la seccion tickets todos pueden acceder para ver los cobros realizados, nadie los puede editar, pero se pueden guardar en un archivo.txt presionando en el boton guardar facturaciones 
![image](https://user-images.githubusercontent.com/70229188/168863033-271a27e3-5500-4e4c-ba2d-d31b7328dd80.png)

### Usuarios
La seccion usuarios es una seccion unica para el usuario Admin para que pueda agregar o eliminar otros usuarios o modificar sus datos
![image](https://user-images.githubusercontent.com/70229188/168882530-ec142e84-3c0a-4d6a-84ff-8f5b97174b9c.png)

## Sobre los temas pedidos

### Herencia


### Sobrecargas
Se sobrecargaron metodos, se sobrecargaron operadores y constructores

### Propiedades
Se utilizaron constructores

### Colecciones
Se utilizaron por lo menos dos colecciones distintas

### Enumerados
no hubo enumerados :(

### Formularios Modal
Se uso un formulario modal

### Clases estaticas
Se utilizaron clases estaticas, muy util ya que la podia usar en todos los formularios

### Polimorfismo



