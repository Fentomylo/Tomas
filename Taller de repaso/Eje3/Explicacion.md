# EXPLICACION EJERCICIO 3 DEL REPASO
Primero cree la clase astract sample que va a ser la base de todo, es decir no se usa directamente, esta es el padre de las otras clases que hay en el código para que puedan servir, además definí un atributo privado llamado message que es donde se guarda el texto, también hay un método abstracto printmessage(string msg) que obliga a las hijas a implementar su manera de imprimir el mensaje

También esta el método virtual invertmessage(string msg) que recibe el string, lo guarda y convierte en un arreglo y después lo invierte con array.reverse y luego lo pasa otra vez a string para imprimirlo invertido. Además ahí métodos setmessage y getmessage que son protected para poder modificar y obtener el mensaje desde las clases hijas sin tener que acceder al atributo privado.

Después viene la primera subclase o hija, NormalMessage que hereda de abstract sample donde se implementa el método print message y guarda el mensaje usando el set messahe y se imprime tal cual como esta, ósea que imprime el mensaje normal.

Luego viene la otra hija, invertedCaseMessage que implementa print message, se convierte en arreglo y después recorre cada letra con un for, esto es para revisar si las letras están mayúsculas o minúsculas con el char.IsUpper y se cambian al contrario, las mayúsculas a minúsculas y las minúsculas a mayúsculas, también sobrescribí el invert message para invertir los mensajes de la clase padre que están normales como para invertir después el mensaje que esta clase suelta.

Ya para finalizar esta MessageManager que usa los objetos, donde los instanciamos los objetos de tipo abstract sample, uno normal y otro inverted para llamar a los métodos de print e invert para que escriba el mensaje tal como lo pide en el enunciado. Ya después llamamos a esta clase en el Main de program para que ejecute todo el ejercicio.

## RESULTADO

<img width="1101" height="456" alt="image" src="https://github.com/user-attachments/assets/fdf59fd8-e6b8-437b-a57e-c2bac9a207d3" />


