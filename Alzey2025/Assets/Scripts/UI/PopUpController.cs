using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public GameObject popupPanel;   // Assign in the Inspector
    public float popupDuration = 2f; // How long the popup stays

    private bool collected = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;
            ShowPopup();
            // Optionally destroy the item
            Destroy(gameObject);
        }
    }

    void ShowPopup()
    {
        popupPanel.SetActive(true);
        // Hide popup after a few seconds
        Invoke(nameof(HidePopup), popupDuration);
    }

    void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}