# Calculadora de Contaminación de Ríos

Este proyecto es una aplicación web que permite calcular la carga contaminante en un tramo de río utilizando métodos numéricos. La aplicación está diseñada para ser intuitiva y fácil de usar, proporcionando a los usuarios la capacidad de ingresar datos relevantes y obtener resultados precisos.

## Estructura del Proyecto

El proyecto está organizado en varias carpetas que contienen diferentes componentes de la aplicación:

- **Controllers**: Contiene los controladores que gestionan las solicitudes HTTP y la lógica de negocio.
- **Models**: Define las estructuras de datos utilizadas en la aplicación.
- **Services**: Implementa la lógica de cálculo y los métodos numéricos.
- **Views**: Contiene las vistas Razor que renderizan la interfaz de usuario.
- **Tests**: Incluye pruebas unitarias e integración para asegurar la funcionalidad del código.
- **Docs**: Documentación del proyecto, incluyendo requisitos, guía técnica, manual de usuario y bitácora de desarrollo.

## Instalación

Para ejecutar la aplicación, siga estos pasos:

1. Clone el repositorio en su máquina local.
2. Abra el proyecto en su entorno de desarrollo.
3. Restaure los paquetes NuGet necesarios.
4. Ejecute la aplicación utilizando el servidor web integrado.

## Uso

La aplicación permite a los usuarios:

1. Ingresar datos sobre la concentración y velocidad del río.
2. Seleccionar el método de integración (Trapecio o Simpson).
3. Visualizar los resultados de los cálculos, incluyendo gráficos interactivos.

## Pruebas

El proyecto incluye pruebas unitarias e integración para asegurar la precisión de los métodos de cálculo y la correcta interacción entre los componentes de la aplicación.

## Contribuciones

Las contribuciones son bienvenidas. Si desea colaborar, por favor envíe un pull request o abra un issue para discutir cambios propuestos.

## Licencia

Este proyecto está bajo la licencia MIT. Consulte el archivo LICENSE para más detalles.