# Laboratorio06
Tarea: Crear un ejemplo usando grupos con xamarin forms

Caso: Crear grupos de estudiantes separados por Secciones (A, B y C)

ListView con Grupos en Xamarin.Forms
Este es un ejemplo de cómo utilizar un ListView con grupos en una aplicación Xamarin.Forms. En este ejemplo, se muestra una lista de personas agrupadas por secciones utilizando un ListView con la capacidad de agrupamiento habilitada. Cada grupo tiene un encabezado que muestra el título de la sección.

Archivo XAML (ListViewGroup.xaml)
El archivo XAML define la estructura de la página, incluyendo la configuración del ListView con la capacidad de agrupamiento. Aquí se establece el formato de los elementos individuales y los encabezados de grupo.

ListView:

IsGroupingEnabled="True": Habilita la agrupación en el ListView.
GroupDisplayBinding="{Binding Title}": Indica que el título de cada grupo se basará en la propiedad Title de la clase Tecsup.
HasUnevenRows="True": Permite filas de altura variable en la lista.
ListView.GroupHeaderTemplate: Define la apariencia de los encabezados de grupo.

ListView.ItemTemplate: Define la apariencia de los elementos individuales en la lista.

Clase ListViewGroup
La clase ListViewGroup es la página principal de la aplicación. Aquí se realiza la inicialización de los datos y se asignan al ListView.

ObservableCollection<Tecsup> Tecsupx: Almacena la lista de grupos y personas a mostrar en el ListView.
ListViewGroup(): El constructor inicializa los datos y los asigna al ListView.
Clases Person y Tecsup
Person: Representa a una persona con propiedades como nombre, apellido, edad y código.
Tecsup: Extiende la lista de personas y representa un grupo. Tiene una propiedad Title para almacenar el título del grupo.
Funcionamiento
En este ejemplo, se crean tres grupos (Sección A, Sección B y Sección C), y cada grupo contiene una lista de personas. El ListView agrupa automáticamente las personas en función de la propiedad Title de la clase Tecsup. Los encabezados de grupo muestran el título de cada sección, y los elementos individuales muestran detalles de cada persona.

El resultado es una lista de personas organizadas en grupos, lo que facilita la visualización y la navegación en la interfaz de la aplicación.

Este ejemplo muestra cómo usar la agrupación en un ListView en Xamarin.Forms para crear una interfaz de usuario organizada y legible. Puedes personalizar aún más la apariencia y el comportamiento según tus necesidades.

