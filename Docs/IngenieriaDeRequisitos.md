# Ingeniería de Requisitos

## Introducción
Este documento describe los requisitos del sistema para la aplicación "Calculadora de Contaminación de Ríos". La aplicación tiene como objetivo proporcionar a los usuarios una herramienta para calcular la carga contaminante en un tramo de río utilizando diferentes métodos de integración numérica.

## Casos de Uso

### Caso de Uso 1: Cálculo de Carga Contaminante
- **Actor Principal**: Usuario
- **Descripción**: El usuario ingresa los datos necesarios para calcular la carga contaminante y selecciona el método de integración.
- **Precondiciones**: El usuario debe tener acceso a la aplicación.
- **Flujo Principal**:
  1. El usuario accede a la página principal.
  2. El usuario ingresa los valores de concentración, velocidad y límites.
  3. El usuario selecciona el método de integración (Trapecio o Simpson).
  4. El usuario envía el formulario.
  5. La aplicación calcula la carga contaminante y muestra los resultados.

### Caso de Uso 2: Visualización de Resultados
- **Actor Principal**: Usuario
- **Descripción**: El usuario visualiza los resultados del cálculo de carga contaminante.
- **Precondiciones**: El usuario debe haber realizado un cálculo previamente.
- **Flujo Principal**:
  1. El usuario accede a la página de resultados.
  2. La aplicación muestra los resultados del cálculo, incluyendo gráficos interactivos.

## Requerimientos Funcionales
1. La aplicación debe permitir al usuario ingresar datos de concentración y velocidad del río.
2. La aplicación debe ofrecer al usuario la opción de seleccionar entre los métodos de integración Trapecio y Simpson.
3. La aplicación debe calcular la carga contaminante y mostrar los resultados en una interfaz amigable.
4. La aplicación debe incluir gráficos interactivos que representen los resultados.

## Requerimientos No Funcionales
1. La aplicación debe ser responsiva y accesible desde dispositivos móviles y de escritorio.
2. La aplicación debe tener un tiempo de respuesta de menos de 2 segundos para cálculos.
3. La aplicación debe ser segura y proteger los datos del usuario.
4. La aplicación debe ser fácil de usar, con una interfaz intuitiva.

## Diagramas
- **Diagrama de Casos de Uso**: Se incluirá un diagrama que represente los casos de uso mencionados.
- **Diagrama de Flujo de Datos**: Se incluirá un diagrama que muestre el flujo de datos entre el usuario y la aplicación.
- **Diagrama de Arquitectura**: Se incluirá un diagrama que represente la arquitectura del sistema, incluyendo los componentes principales y su interacción.

## Conclusión
Este documento establece los requisitos necesarios para el desarrollo de la aplicación "Calculadora de Contaminación de Ríos". Se utilizará como base para el diseño y desarrollo del sistema, asegurando que se cumplan las expectativas del usuario y los objetivos del proyecto.