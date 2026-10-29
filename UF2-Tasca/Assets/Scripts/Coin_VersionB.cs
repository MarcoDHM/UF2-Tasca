// Nom de l'alumne: Marco de Haro
// Data: 29/10/2026
// UF2 - T2.4: Deteccio de colisio amb CompareTag (Versio B)

using UnityEngine;

public class Coin_VersionB : MonoBehaviour
{
    public int punts = 1;

    private void OnTriggerEnter(Collider other)
    {
        // VERSIO B: Comprovacio amb CompareTag
        // Aquesta versio es clarament millor per dos motius:
        // 1. Rendiment: CompareTag es una crida nativa interna a C++ que no genera
        //    residus a la memoria Heap (evita Garbage Collection).
        // 2. Fiabilitat: Si tenim clones com "Player(Clone)" o instancies dinamiques,
        //    el Tag es mante intacte mentre que el nom canvia i trencaria la condicio de la Versio A.
        //    A mes, si ens equivoquem escrivint el tag, Unity avisa amb un error a la consola.
        if (other.CompareTag("Player"))
        {
            Debug.Log("Moneda recollida (Versio B - Tag)!");
            Destroy(gameObject);
        }
    }
}
