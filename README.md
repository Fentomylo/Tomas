# Hola profe, aca en el readme como en las carpetas de cada ejercicio estan las explicaciones de cada uno, que fueron hechos con mi conocimiento muy basico de POO y tambien con la ayuda de chatgpt :) -> Tomás Vélez Duque


<img width="2048" height="2048" alt="image" src="https://github.com/user-attachments/assets/a04ff89e-d06c-4339-ad81-3bd641d0892d" />

## EXPLICACIÓN EJERCICIO 1 DEL REPASO

### PRIMERO: SERIE DE FIBONACCI:

Con el ejercicio de la serie de Fibonacci, hice la función de Fibonacci primos para sacar la serie hasta la cantidad de términos que yo quiero, en este caso fueron 10 que llame con FibonacciPimros(10), ósea que el programas solo calcula los primeros 10 números de Fibonacci.

Use unas variables a y b para ir armando la serie sin complicarme demasiado, en cada vuelta del ciclo for que cree saco el numero actual y actualizo las variables para poder continuar con el siguiente. Antes de imprimirlo hay que revisar si es primo o no, porque el ejercicio solo pide mostrar los primos, si un numero no es primo directamente lo salta.

Ahora, para resolver lo anterior hice la función de EsPrimo. Ahí saco los números que son menores que 2 y después reviso si el numero se puede dividir por otro y usamos la raíz cuadrada para no recorrer números de mas, por asi decirlo, es de una manera mas sencilla.

### SEGUNDO: SEGUNDOS A FORMATO HH:MM:SS

Con el ejercicio de los segundos cree la función SegundosAHora, que recibe una cantidad de segundos y los pasa al formato que pide el ejercicio sin usar el DateTime. Esto se ve en el main cuando pedimos que se escriban la cantidad de segundos para hacer el cambio de formato

Para esto sacamos las horas dividiendo entre 3600 (cantidad de segundos de una hora), después los minutos con el residuo (gracias a %) y al final los segundos que sobran. Al final se devuelve todo con un string, cuidando que siempre se devuelvan con 2 dígitos (usando D2 para que siempre se tengan 2 dígitos) 

### RESULTADO

<img width="1101" height="618" alt="image" src="https://github.com/user-attachments/assets/b43cefee-ef39-485e-8de3-d14f1e71b8b8" />

## EXPLICACIÓN EJERCICIO 2 DEL REPASO

Bueno este ejemplo es básicamente la lotería, el jugador apuesta a un numero de 4 cifras y se compara con el ganador del sorteo, para esto en el Main definí el numero apostado (num), el numero ganador (resultado) y el valor de la apuesta que es de $1000, use strings para los números y así compararlos mas fácil.

La parte del código que esta comentada es que en vez de yo definir el numero ganador, mediante los Random podemos sacar un numero aleatorio, es decir funciona como una lotería de verdad, igual solo lo hice por probar mas abajo hay fotos de los resultados de los 2. 

ya con esto claro, llamamos a la función calcularpremio que recibe el numero apostado, el ganador y el valor de la apuesta y devuelve el premio que se gano, primero hay que comparar si el num es igual al resultado que seria acertar las 4 cifras en orden y se paga $45000 por cada peso

Luego usamos la funcion EsDesorden(num, resultado) para verificar si las cuatro cifras son las mismas pero en diferente orden, lo que pada $200 por cada peso, despues se compara para revisar si coinciden las ultimas 3 cifras, las ultimas 2 o solo la ultima devolviendo el premio como lo dice el enunciado, si no acierta, no gana ni el dia, la funcion retorna el 0. Basicamente esta función EsDesorden tienen las mismas es para saber si tienen las mismas cifras en diferente orden, ahi convertimos los numeros en arreglos de caracteres y se ordenan con el array.sort y se compara, si quedan iguales es que el numero fue acertado en desorden.

### RESULTADO CON EL NUMERO QUE YO PONGO

<img width="1155" height="670" alt="image" src="https://github.com/user-attachments/assets/57db4de9-4efe-4c0f-9ad6-63cd7dea5934" />

### RESULTADOS CON EL NUMERO GANADOR EN ALEATORIO

<img width="1123" height="603" alt="image" src="https://github.com/user-attachments/assets/c39d7de5-f556-43f3-9358-b4946a08b6af" />

<img width="1105" height="618" alt="image" src="https://github.com/user-attachments/assets/23022343-8d97-47c5-aa4e-9413724b7106" />

## EXPLICACION EJERCICIO 3 DEL REPASO
Primero cree la clase astract sample que va a ser la base de todo, es decir no se usa directamente, esta es el padre de las otras clases que hay en el código para que puedan servir, además definí un atributo privado llamado message que es donde se guarda el texto, también hay un método abstracto printmessage(string msg) que obliga a las hijas a implementar su manera de imprimir el mensaje

También esta el método virtual invertmessage(string msg) que recibe el string, lo guarda y convierte en un arreglo y después lo invierte con array.reverse y luego lo pasa otra vez a string para imprimirlo invertido. Además ahí métodos setmessage y getmessage que son protected para poder modificar y obtener el mensaje desde las clases hijas sin tener que acceder al atributo privado.

Después viene la primera subclase o hija, NormalMessage que hereda de abstract sample donde se implementa el método print message y guarda el mensaje usando el set messahe y se imprime tal cual como esta, ósea que imprime el mensaje normal.

Luego viene la otra hija, invertedCaseMessage que implementa print message, se convierte en arreglo y después recorre cada letra con un for, esto es para revisar si las letras están mayúsculas o minúsculas con el char.IsUpper y se cambian al contrario, las mayúsculas a minúsculas y las minúsculas a mayúsculas, también sobrescribí el invert message para invertir los mensajes de la clase padre que están normales como para invertir después el mensaje que esta clase suelta.

Ya para finalizar esta MessageManager que usa los objetos, donde los instanciamos los objetos de tipo abstract sample, uno normal y otro inverted para llamar a los métodos de print e invert para que escriba el mensaje tal como lo pide en el enunciado. Ya después llamamos a esta clase en el Main de program para que ejecute todo el ejercicio.

### RESULTADO

<img width="1101" height="456" alt="image" src="https://github.com/user-attachments/assets/fdf59fd8-e6b8-437b-a57e-c2bac9a207d3" />


