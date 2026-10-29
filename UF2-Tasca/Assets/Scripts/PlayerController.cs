// Nom de l'alumne: Marco de Haro
// Data: 29/10/2026
// UF2 - T2.3: Controlador de jugador amb RequireComponent

using UnityEngine;

// Gracies a aquest atribut, Unity s'assegura que sempre hi hagi un Rigidbody al GameObject.
// Si no en te, l'afegeix automaticament. Si intentem esborrar el Rigidbody, no ens deixara.
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Configuracio")]
    public float velocitat = 6f;

    private Rigidbody rb;

    void Start()
    {
        // Sabem segur que no sera null perque RequireComponent garanteix que existeix
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3(h, 0f, v).normalized * velocitat;
        moviment.y = rb.linearVelocity.y;

        rb.linearVelocity = moviment;
    }
}
