# Guía Técnica para la Aplicación de Cálculo de Contaminación en Ríos

## 1. Introducción

Esta guía técnica proporciona una visión general de la arquitectura del sistema, las tecnologías utilizadas y la interacción entre los componentes de la aplicación "CalculadoraContaminacionRios". La aplicación tiene como objetivo calcular la carga contaminante en tramos de ríos utilizando métodos numéricos.

## 2. Arquitectura del Sistema

La aplicación está estructurada siguiendo el patrón Modelo-Vista-Controlador (MVC), que separa la lógica de negocio, la presentación y el manejo de datos. A continuación se describen los componentes principales:

### 2.1. Modelo

- **ContaminacionModel**: Representa los datos necesarios para realizar los cálculos, incluyendo propiedades como concentración, velocidad y límites.

### 2.2. Controlador

- **HomeController**: Maneja las solicitudes HTTP y coordina la lógica de negocio. Contiene métodos como `Index()` para mostrar la vista principal y `Resultados()` para mostrar los resultados de los cálculos.

### 2.3. Vista

- **Vistas**: Utiliza Razor para renderizar la interfaz de usuario. Las vistas principales incluyen:
  - `Index.cshtml`: Formulario para ingresar datos de entrada.
  - `Resultados.cshtml`: Muestra los resultados de los cálculos.

### 2.4. Servicios

- **IntegracionService**: Proporciona métodos para realizar la integración numérica.
- **TrapecioSimpsonService**: Implementa los métodos del trapecio y Simpson para calcular integrales.

## 3. Tecnologías Utilizadas

- **ASP.NET Core**: Framework utilizado para desarrollar la aplicación web.
- **C#**: Lenguaje de programación utilizado para la lógica de negocio.
- **Razor**: Motor de plantillas utilizado para generar las vistas.
- **Bootstrap**: Framework CSS utilizado para el diseño responsivo de la interfaz de usuario.
- **xUnit/NUnit**: Frameworks utilizados para realizar pruebas unitarias e integración.

## 4. Interacción entre Componentes

1. El usuario ingresa los datos en la vista `Index.cshtml`.
2. Al enviar el formulario, se realiza una solicitud HTTP al `HomeController`.
3. El controlador procesa los datos y llama a los métodos del servicio correspondiente para realizar los cálculos.
4. Los resultados se envían a la vista `Resultados.cshtml`, donde se muestran al usuario.

## 5. Conclusiones

La aplicación "CalculadoraContaminacionRios" está diseñada para ser modular y escalable, facilitando futuras mejoras y mantenimiento. La separación de responsabilidades entre modelos, controladores y vistas asegura una buena organización del código y una fácil comprensión del flujo de la aplicación.