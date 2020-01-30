using UnityEngine;

public class PopupSpawner : MonoBehaviour
{

    public Popup popup;

    public void SpawnPopup()
    {
        Instantiate(popup, transform);
    }
}
