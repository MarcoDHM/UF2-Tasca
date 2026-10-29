// Nom de l'alumne: Marco de Haro
// Data: 29/10/2026
// UF2 - T2.2: Moviment 3D amb inercia usant Vector3.Lerp

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover3D_Inertia : MonoBehaviour
{
    [Header("Parametres de moviment")]
    public float velocitatMaxima = 8f;
    public float factorInercia = 0.08f; // Factor per al Lerp (com mes baix, mes inercia)

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 1. Llegim els eixos d'entrada
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. Calculem la velocitat objectiu en el pla horitzontal (X i Z)
        Vector3 direccio = new Vector3(h, 0f, v).normalized;
        Vector3 targetVel = direccio * velocitatMaxima;

        // Mantenim la velocitat vertical existent (per gravetat o caigudes)
        targetVel.y = rb.linearVelocity.y;

        // 3. Apliquem el suavitzat entre la velocitat actual i la desitjada
        // Aixi aconseguim que el personatge trigui una mica a arrencar i a frenar
        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVel, factorInercia);
    }
}
