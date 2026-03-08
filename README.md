Plataforma e-Commerce en C# (POO) 📌 Descripción del Proyecto

Este proyecto consiste en el desarrollo de una plataforma básica de comercio electrónico de escritorio desarrollada en C# utilizando Windows Forms y aplicando los principios de Programación Orientada a Objetos (POO).

El sistema permite gestionar productos, usuarios y un carrito de compras, además de implementar conceptos avanzados de POO como herencia, polimorfismo, abstracción, interfaces, sobrecarga y sobrescritura de métodos.

También se integra una base de datos SQL Server para almacenar y consultar los productos disponibles en el sistema.

🎯 Objetivos del Proyecto

Aplicar los principios fundamentales de Programación Orientada a Objetos.

Implementar herencia y polimorfismo en la gestión de productos y usuarios.

Utilizar clases abstractas para la gestión del inventario.

Implementar interfaces para manejar diferentes procesos de pago.

Conectar la aplicación con una base de datos SQL Server.

Desarrollar una interfaz gráfica de usuario (GUI) utilizando Windows Forms.

🧱 Tecnologías Utilizadas

Lenguaje: C#

Framework: .NET / Windows Forms

Base de Datos: SQL Server

IDE: Visual Studio

Control de Versiones: Git

Repositorio: GitHub

🏗️ Arquitectura del Proyecto

El proyecto está organizado en diferentes carpetas para mantener una estructura clara:

EcommercePOO │ ├── Modelos │ ├── Producto.cs │ ├── ProductoDigital.cs │ ├── ProductoFisico.cs │ ├── Usuario.cs │ ├── Cliente.cs │ ├── Administrador.cs │ ├── Carrito.cs │ ├── Interfaces │ ├── IGestorInventario.cs │ ├── IProcesoPago.cs │ ├── Inventario │ ├── GestorInventario.cs │ ├── InventarioFisico.cs │ ├── InventarioDigital.cs │ ├── Pagos │ ├── PagoTarjeta.cs │ ├── PagoPayPal.cs │ ├── Database │ ├── ConexionDB.cs │ ├── ProductoDAO.cs │ ├── UI │ ├── FormTienda.cs │ └── Program.cs 📦 Implementación de Clases Clase Producto

La clase Producto representa un producto general dentro del sistema e incluye atributos como:

id

nombre

descripción

precio

stock

También define un método virtual MostrarDetalle() que puede ser sobrescrito por clases derivadas.

Herencia de Productos

Se implementaron dos tipos de productos:

ProductoDigital

Hereda de Producto y agrega atributos como:

formatoArchivo

tamañoMB

Sobrescribe el método:

MostrarDetalle()

para mostrar información específica del producto digital.

ProductoFisico

Hereda de Producto y agrega atributos como:

peso

dimensiones

También sobrescribe el método:

MostrarDetalle() 👤 Gestión de Usuarios

Se creó una clase base Usuario con atributos como:

id

nombre

correo

contraseña

A partir de esta clase se derivan:

Cliente

Incluye funcionalidades como:

historial de compras

Administrador

Permite realizar acciones administrativas como:

gestión de inventario

control de productos

🛒 Carrito de Compras

La clase Carrito permite gestionar los productos que el cliente desea comprar.

Funciones principales:

Agregar productos

Eliminar productos

Calcular total de la compra

También se implementó sobrecarga de métodos para agregar productos al carrito de diferentes formas:

AgregarProducto(Producto producto) AgregarProducto(string nombre, double precio) AgregarProducto(int id, List inventario) 🔁 Polimorfismo

Se implementa polimorfismo permitiendo tratar objetos de diferentes clases derivadas como objetos de su clase base.

Ejemplo:

Producto p1 = new ProductoDigital(...); Producto p2 = new ProductoFisico(...);

Ambos son tratados como tipo Producto.

🧩 Abstracción

Se creó la clase abstracta:

GestorInventario

Esta define los métodos abstractos:

AñadirProducto()

EliminarProducto()

ActualizarStock()

Las implementaciones concretas son:

InventarioFisico

InventarioDigital

🔗 Interfaces Interfaz de Inventario

Se definió la interfaz:

IGestorInventario

que establece el contrato para gestionar productos en el inventario.

Interfaz de Pago

Se creó la interfaz:

IProcesoPago

que define los métodos necesarios para procesar pagos:

IniciarPago()

VerificarPago()

ConfirmarPago()

💳 Implementación de Métodos de Pago

Se implementaron dos métodos de pago:

PagoTarjeta

Permite simular pagos realizados con tarjeta de crédito o débito.

PagoPayPal

Simula pagos realizados mediante la plataforma PayPal.

Ambos implementan la interfaz:

IProcesoPago 🗄️ Integración con Base de Datos

El sistema utiliza SQL Server para almacenar información de los productos.

Base de datos EcommerceDB Tabla productos

Contiene los siguientes campos:

Id

Nombre

Descripción

Precio

Stock

🔌 Conexión a la Base de Datos

Se creó la clase:

ConexionDB

que establece la conexión con SQL Server utilizando:

SqlConnection 📊 Visualización de Productos

Los productos almacenados en la base de datos se cargan en un DataGridView dentro del formulario principal.

Esto permite al usuario:

visualizar productos

agregarlos al carrito

calcular el total de compra

🖥️ Interfaz de Usuario

La aplicación cuenta con un formulario principal que incluye:

Lista de productos

Carrito de compras

Botón agregar producto

Botón eliminar producto

Cálculo del total

<img width="713" height="284" alt="image" src="https://github.com/user-attachments/assets/4866c488-040d-4206-9384-9f8150408946" />

<img width="588" height="252" alt="image" src="https://github.com/user-attachments/assets/4e855780-ff6e-4ae5-80b3-dc1ee56786ca" />
<img width="278" height="485" alt="image" src="https://github.com/user-attachments/assets/ef9abefd-f6e4-45a5-85a1-df4ae752a225" />


⚠️ Desafíos Encontrados

Durante el desarrollo del proyecto se presentaron algunos desafíos:

Implementación correcta de herencia entre productos

Uso de interfaces para definir contratos de pago

Conexión y consulta de datos desde SQL Server

Visualización dinámica de productos en el DataGridView

Estos problemas fueron solucionados mediante la correcta organización del código y el uso adecuado de los principios de POO.

🚀 Autor

Eutiquio González

Proyecto académico de Programación Orientada a Objetos en C#
