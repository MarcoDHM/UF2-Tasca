// Nom de l'alumne: Marco de Haro
// Data: 29/10/2026
// UF2 - T2.5: Plataforma unidireccional (One-Way) amb Physics.IgnoreCollision

using UnityEngine;

[RequireComponent(typeof(Collider))]
public class OneWayPlatform : MonoBehaviour
{
    private Collider platformCollider;
    private GameObject player;
    private Collider playerCollider;

    void Start()
    {
        platformCollider = GetComponent<Collider>();
        TrobarJugador();
    }

    void Update()
    {
        if (playerCollider == null)
        {
            TrobarJugador();
            return;
        }

        float partSuperiorPlataforma = platformCollider.bounds.max.y;
        float peusJugador = playerCollider.bounds.min.y;

        if (peusJugador < partSuperiorPlataforma - 0.05f)
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, true);
        }
        else
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, false);
        }
    }

    private void TrobarJugador()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerCollider = player.GetComponent<Collider>();
        }
    }
}
