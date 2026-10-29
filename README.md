# UF2-Tasca

## T2.1 Inventario de funciones de Input

| Función | Qué devuelve | Cuándo usarla | Ejemplo de una línea |
|---------|--------------|---------------|---------------------|
| `Input.GetKey(KeyCode)` | `bool` | Cuando hay que comprobar si una tecla se mantiene presionada de forma continua (ej: correr, acelerar). | `bool corriendo = Input.GetKey(KeyCode.LeftShift);` |
| `Input.GetKeyDown(KeyCode)` | `bool` | Solo en el primer frame exacto en que se presiona la tecla (ej: saltar, abrir inventario, pausar). | `if (Input.GetKeyDown(KeyCode.Space)) Saltar();` |
| `Input.GetKeyUp(KeyCode)` | `bool` | Solo en el frame exacto en que se suelta la tecla (ej: disparar una flecha cargada). | `if (Input.GetKeyUp(KeyCode.E)) SoltarObjeto();` |
| `Input.GetButton(string)` | `bool` | Mientras se mantiene presionado un botón virtual definido en el Input Manager (permite soporte tanto de teclado como de mando). | `bool disparando = Input.GetButton("Fire1");` |
| `Input.GetButtonDown(string)` | `bool` | En el frame que se presiona un botón virtual configurado (ej: acción de salto universal para teclado o mando). | `if (Input.GetButtonDown("Jump")) HacerSalto();` |
| `Input.GetButtonUp(string)` | `bool` | En el frame que se suelta el botón virtual configurado. | `if (Input.GetButtonUp("Fire2")) CancelarApuntar();` |
| `Input.GetAxis(string)` | `float (-1.0 a 1.0)` | Para obtener movimiento con aceleración y suavizado gradual (smoothing). Ideal para movimiento analógico o coches. | `float h = Input.GetAxis("Horizontal");` |
| `Input.GetAxisRaw(string)` | `float (-1, 0 o 1)` | Cuando se quiere respuesta inmediata sin ningún suavizado artificial (útil en juegos 2D o control arcade reactivo). | `float v = Input.GetAxisRaw("Vertical");` |
| `Input.GetMouseButton(int)` | `bool` | Mientras se mantiene presionado un botón del ratón (0: izquierdo, 1: derecho, 2: central). | `if (Input.GetMouseButton(0)) DispararAmetralladora();` |
| `Input.GetMouseButtonDown(int)` | `bool` | En el primer frame de hacer clic con el ratón (ej: disparar una bala individual o hacer clic en un botón). | `if (Input.GetMouseButtonDown(0)) Atacar();` |
| `Input.GetMouseButtonUp(int)` | `bool` | En el frame que se suelta el botón del ratón (ej: soltar un elemento arrastrado). | `if (Input.GetMouseButtonUp(0)) SoltarElemento();` |
| `Input.mousePosition` | `Vector3` | Para saber la posición actual del cursor en la pantalla en píxeles (útil para apuntar o raycasts desde la cámara). | `Vector3 posRaton = Input.mousePosition;` |
