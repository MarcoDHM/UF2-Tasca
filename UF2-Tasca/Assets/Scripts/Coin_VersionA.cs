// Nom de l'alumne: Marco de Haro
// Data: 29/10/2026
// UF2 - T2.4: Deteccio de colisio amb nom de GameObject (Versio A)

using UnityEngine;

public class Coin_VersionA : MonoBehaviour
{
    public int punts = 1;

    private void OnTriggerEnter(Collider other)
    {
        // VERSIO A: Comprovacio directa per nom de l'objecte
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Moneda recollida (Versio A - Nom)!");
            Destroy(gameObject);
        }
    }
}
