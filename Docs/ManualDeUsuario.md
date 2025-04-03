# Manual de Usuario

## Introducción

Este manual proporciona instrucciones sobre cómo utilizar la aplicación **Calculadora de Contaminación de Ríos**. La aplicación permite a los usuarios calcular la carga contaminante en un tramo de río utilizando diferentes métodos de integración numérica.

## Requisitos Previos

Antes de utilizar la aplicación, asegúrese de tener acceso a un navegador web moderno y conexión a Internet.

## Acceso a la Aplicación

1. Abra su navegador web.
2. Ingrese la URL donde está alojada la aplicación (por ejemplo, `http://localhost:5000` si se está ejecutando localmente).
3. Se mostrará la página de inicio de la aplicación.

## Uso de la Aplicación

### 1. Ingreso de Datos

- En la página de inicio, encontrará un formulario para ingresar los datos necesarios para el cálculo:
  - **Concentración (C)**: Ingrese el valor de concentración del contaminante en el río.
  - **Velocidad (v)**: Ingrese la velocidad del flujo del río.
  - **Límite Inferior (a)**: Ingrese el límite inferior del tramo a calcular.
  - **Límite Superior (b)**: Ingrese el límite superior del tramo a calcular.
  - **Número de Particiones (n)**: Ingrese el número de particiones para el método de integración.

### 2. Selección del Método de Integración

- Seleccione el método de integración que desea utilizar:
  - **Método del Trapecio**
  - **Método de Simpson**

### 3. Ejecución del Cálculo

- Haga clic en el botón **Calcular** para ejecutar el cálculo.
- La aplicación procesará los datos y mostrará los resultados en la página de resultados.

### 4. Visualización de Resultados

- Después de realizar el cálculo, será redirigido a la página de resultados donde podrá ver:
  - El valor calculado de la carga contaminante.
  - Gráficos que representan la concentración y la velocidad a lo largo del tramo del río (si se han integrado librerías gráficas).

## Ejemplo de Uso

1. Ingrese los siguientes valores en el formulario:
   - Concentración (C): 5
   - Velocidad (v): 2
   - Límite Inferior (a): 0
   - Límite Superior (b): 10
   - Número de Particiones (n): 100
2. Seleccione el **Método de Simpson**.
3. Haga clic en **Calcular**.
4. Revise los resultados en la página de resultados.

## Soporte

Si encuentra problemas o tiene preguntas sobre el uso de la aplicación, consulte la sección de soporte en la página principal o contacte al desarrollador a través del correo electrónico proporcionado en la documentación del proyecto.

## Conclusión

La **Calculadora de Contaminación de Ríos** es una herramienta útil para realizar cálculos de carga contaminante de manera eficiente. Siga este manual para aprovechar al máximo las funcionalidades de la aplicación.