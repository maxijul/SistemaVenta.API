# Sistema Ventas API

Este es un sistema de gestion de ventas desarrollado y pensado para hacer la entrega del proyecto final de la tecnicatura universitaria en programación dictada por la Universidad Tecnólogica Nacional - **UTN**.

# API
En este repositorio estará toda la API desarrollada para el sistema y los scripts iniciales de la base de datos para poder levantar el sistema de forma local. Quedara a disposicion de la persona que quiera hacer uso del mismo si quiere deployar este web service para hacer uso del mismo.

# Consideraciones
Esta API se desarrollo en ASP.NET 7 es recomendable descargar el IDE de [Visual Studio 2022](https://visualstudio.microsoft.com/es/vs/).
También se recomienda descargar [SQL SERVER y SQL SERVER MANAGEMENT STUDIO](https://www.microsoft.com/es-es/sql-server/sql-server-downloads).

# Librerias usadas

- ### Microsoft.EntityFrameworkCore.SqlServer v7.0.1
- ### Microsoft.EntityFrameworkCore.Tools v7.0.1 

# Pasos para levantar el proyecto de forma local
1. hacer git clone de este repositorio en el directorio de su preferencia.
2. Ejecutar los scripts de sql en **SQL SERVER MANAGEMENT STUDIO**.
3. Ejecutar la solución del proyecto.
4. Copiar todo el contenido de `appsettings.json`.
5. Crear un archivo en la misma ruta de `appsettings.json` con el siguiente nombre `appsettings.development.json`.
6. Pegar todo el contenido copiado de `appsettings.json` en `appsettings.development.json`.
7. Configurar la cadena de conexión con sus credenciales propias.
8. Ejecutar el proyecto.
9. Se abrira swagger que es un documentador de apis. Aqui usted puede probar directamente la API.

