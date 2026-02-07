# EXPLICACIÓN SEGUNDO EJERCICIO TALLER DE REPASO

Bueno este ejemplo es básicamente la lotería, el jugador apuesta a un numero de 4 cifras y se compara con el ganador del sorteo, para esto en el Main definí el numero apostado (num), el numero ganador (resultado) y el valor de la apuesta que es de $1000, use strings para los números y así compararlos mas fácil.

La parte del código que esta comentada es que en vez de yo definir el numero ganador, mediante los Random podemos sacar un numero aleatorio, es decir funciona como una lotería de verdad, igual solo lo hice por probar mas abajo hay fotos de los resultados de los 2. 

ya con esto claro, llamamos a la función calcularpremio que recibe el numero apostado, el ganador y el valor de la apuesta y devuelve el premio que se gano, primero hay que comparar si el num es igual al resultado que seria acertar las 4 cifras en orden y se paga $45000 por cada peso

Luego usamos la funcion EsDesorden(num, resultado) para verificar si las cuatro cifras son las mismas pero en diferente orden, lo que pada $200 por cada peso, despues se compara para revisar si coinciden las ultimas 3 cifras, las ultimas 2 o solo la ultima devolviendo el premio como lo dice el enunciado, si no acierta, no gana ni el dia, la funcion retorna el 0. Basicamente esta función EsDesorden tienen las mismas es para saber si tienen las mismas cifras en diferente orden, ahi convertimos los numeros en arreglos de caracteres y se ordenan con el array.sort y se compara, si quedan iguales es que el numero fue acertado en desorden.

## RESULTADO CON EL NUMERO QUE YO PONGO

<img width="1155" height="670" alt="image" src="https://github.com/user-attachments/assets/57db4de9-4efe-4c0f-9ad6-63cd7dea5934" />

## RESULTADOS CON EL NUMERO GANADOR EN ALEATORIO

<img width="1123" height="603" alt="image" src="https://github.com/user-attachments/assets/c39d7de5-f556-43f3-9358-b4946a08b6af" />

<img width="1105" height="618" alt="image" src="https://github.com/user-attachments/assets/23022343-8d97-47c5-aa4e-9413724b7106" />



