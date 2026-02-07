# EXPLICACIÓN EJERCICIO 1 DEL REPASO

## PRIMERO: SERIE DE FIBONACCI:

Con el ejercicio de la serie de Fibonacci, hice la función de Fibonacci primos para sacar la serie hasta la cantidad de términos que yo quiero, en este caso fueron 10 que llame con FibonacciPimros(10), ósea que el programas solo calcula los primeros 10 números de Fibonacci.

Use unas variables a y b para ir armando la serie sin complicarme demasiado, en cada vuelta del ciclo for que cree saco el numero actual y actualizo las variables para poder continuar con el siguiente. Antes de imprimirlo hay que revisar si es primo o no, porque el ejercicio solo pide mostrar los primos, si un numero no es primo directamente lo salta.

Ahora, para resolver lo anterior hice la función de EsPrimo. Ahí saco los números que son menores que 2 y después reviso si el numero se puede dividir por otro y usamos la raíz cuadrada para no recorrer números de mas, por asi decirlo, es de una manera mas sencilla.

## SEGUNDO: SEGUNDOS A FORMATO HH:MM:SS

Con el ejercicio de los segundos cree la función SegundosAHora, que recibe una cantidad de segundos y los pasa al formato que pide el ejercicio sin usar el DateTime. Esto se ve en el main cuando pedimos que se escriban la cantidad de segundos para hacer el cambio de formato

Para esto sacamos las horas dividiendo entre 3600 (cantidad de segundos de una hora), después los minutos con el residuo (gracias a %) y al final los segundos que sobran. Al final se devuelve todo con un string, cuidando que siempre se devuelvan con 2 dígitos (usando D2 para que siempre se tengan 2 dígitos) 

## RESULTADO

<img width="1101" height="618" alt="image" src="https://github.com/user-attachments/assets/b43cefee-ef39-485e-8de3-d14f1e71b8b8" />


