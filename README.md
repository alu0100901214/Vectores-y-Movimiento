# Vectores-y-Movimiento


## Ejercicio 1

En un ejemplo donde la coordenada del Vector en el eje Y es 1 (0,1,0) el objeto se impulsa hacia arriba pero cae debido a la gravedad que le otorga el componente "Rigidbody":

![gif](./GIF/conGravedad.GIF)

Para lograr que el objeto salga volando, podemos desactivar la gravedad desde el Rigidbody, dando lugar al siguiente resultado:

![gif](./GIF/sinGravedad.GIF)


## Ejercicio 2

Duplicando los valores del Vector en X, Y, Z hacemos que la esfera se mueva el doble de rapido:

Valor original:

![gif](./GIF/conGravedad.GIF)

Valor con los vectores duplicados:

![gif](./GIF/conGravedad.GIF)

Sin embargo, al usar desde el script el vector normalizado (goal.normalized) solo nos quedamos con la información referente a la dirección del vector sin que afecte el hecho de haber duplicado sus valores de forma que conserva la misma velocidad que el original.

 A su vez, debemos usar Time.deltaTime para evitar la inconsistencia del Update(), ya que el tiempo que pasa entre un frame y otro dentro de este no es siempre el mismo.
 
 El translate quedaría como:
 
 ```
 t.Translate(goal.normalized * Time.deltaTime * speed);
 ```
 
 ## Ejercicio 8
 
 
