using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent;
    [SerializeField] UnityEvent triggerExitEvent;

    void OnTriggerEnter(Collider col)
    {
        // Controleer of de collider die de trigger binnenkomt de tag "Player" heeft
        if (col.CompareTag("Player"))
        {
            // Roep het triggerEvent aan
            triggerEvent.Invoke();
            // Haal de lokale MeshRenderer op van het object waar dit script zich op bevindt
            GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0, 0.5f); // Zet de kleur op groen
        }
    }

    void OnTriggerExit(Collider col)
    {
        // Controleer of de collider die de trigger verlaat de tag "Player" heeft
        if (col.CompareTag("Player"))
        {
            // Roep het triggerEvent aan
            triggerExitEvent.Invoke();
            // Haal de lokale MeshRenderer op van het object waar dit script zich op bevindt
            GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0.5f); // Zet de kleur op rood
        }
    }
}