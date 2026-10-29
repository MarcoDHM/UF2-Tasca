# UF2-Tasca

## T2.1 Inventari de funcions d'Input

| Funció | Què retorna | Quan usar-la | Exemple d'una línia |
|--------|-------------|--------------|---------------------|
| `Input.GetKey(KeyCode)` | `bool` | Quan cal comprovar si una tecla es manté premuda de forma contínua (ex: córrer, accelerar). | `bool corrent = Input.GetKey(KeyCode.LeftShift);` |
| `Input.GetKeyDown(KeyCode)` | `bool` | Només en el primer frame exacte en què es prem la tecla (ex: saltar, obrir inventari, pausar). | `if (Input.GetKeyDown(KeyCode.Space)) Saltar();` |
| `Input.GetKeyUp(KeyCode)` | `bool` | Només en el frame exacte en què es deixa anar la tecla (ex: disparar una fletxa carregada). | `if (Input.GetKeyUp(KeyCode.E)) DeixarAnarObjecte();` |
| `Input.GetButton(string)` | `bool` | Mentre es manté premut un botó virtual definit a l'Input Manager (permet suport tant de teclat com de comandament). | `bool disparant = Input.GetButton("Fire1");` |
| `Input.GetButtonDown(string)` | `bool` | En el frame que es prem un botó virtual configurat (ex: acció de salt universal per a teclat o comandament). | `if (Input.GetButtonDown("Jump")) FerSalt();` |
| `Input.GetButtonUp(string)` | `bool` | En el frame que es deixa anar el botó virtual configurat. | `if (Input.GetButtonUp("Fire2")) CancelarApuntat();` |
| `Input.GetAxis(string)` | `float (-1.0 a 1.0)` | Per obtenir moviment amb acceleració i suavitzat gradual (smoothing). Ideal per a moviment analògic o cotxes. | `float h = Input.GetAxis("Horizontal");` |
| `Input.GetAxisRaw(string)` | `float (-1, 0 o 1)` | Quan es vol resposta immediata sense cap suavitzat artificial (útil en jocs 2D o control arcade reactiu). | `float v = Input.GetAxisRaw("Vertical");` |
| `Input.GetMouseButton(int)` | `bool` | Mentre es manté premut un botó del ratolí (0: esquerre, 1: dret, 2: central). | `if (Input.GetMouseButton(0)) DispararMetralladora();` |
| `Input.GetMouseButtonDown(int)` | `bool` | En el primer frame de fer clic amb el ratolí (ex: disparar una bala individual o clicar un botó). | `if (Input.GetMouseButtonDown(0)) Atacar();` |
| `Input.GetMouseButtonUp(int)` | `bool` | En el frame que es deixa anar el botó del ratolí (ex: soltar un element arrossegat). | `if (Input.GetMouseButtonUp(0)) DeixarItem();` |
| `Input.mousePosition` | `Vector3` | Per saber la posició actual del cursor a la pantalla en píxels (útil per apuntar o raycasts des de la càmera). | `Vector3 posRato = Input.mousePosition;` |
