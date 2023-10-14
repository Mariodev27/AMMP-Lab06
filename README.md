# Laboratorio06
Tarea: Crear un ejemplo usando grupos con xamarin forms

Caso: Crear grupos de estudiantes separados por Secciones (A, B y C)

ListView con Grupos en Xamarin.Forms
Este es un ejemplo de cómo utilizar un ListView con grupos en una aplicación Xamarin.Forms. En este ejemplo, se muestra una lista de personas agrupadas por secciones utilizando un ListView con la capacidad de agrupamiento habilitada. Cada grupo tiene un encabezado que muestra el título de la sección.

Clase ListViewGroup
La clase ListViewGroup es la página principal de la aplicación. Aquí se realiza la inicialización de los datos y se asignan al ListView.

ObservableCollection<Tecsup> Tecsupx: Almacena la lista de grupos y personas a mostrar en el ListView.
ListViewGroup(): El constructor inicializa los datos y los asigna al ListView.

Clases Person y Tecsup
Person: Representa a una persona con propiedades como nombre, apellido, edad y código.
Tecsup: Extiende la lista de personas y representa un grupo. Tiene una propiedad Title para almacenar el título del grupo.

El resultado es una lista de personas organizadas en grupos, lo que facilita la visualización y la navegación en la interfaz de la aplicación.

