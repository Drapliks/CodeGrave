using DG.Tweening;
using UnityEngine;

public class formbasmtostree : MonoBehaviour
{
    [SerializeField] private GameObject basment;
    [SerializeField] private GameObject street;
    [SerializeField] private GameObject PlayerCamera;
    [SerializeField] private GameObject Player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        street.SetActive(true);
        Player.transform.DOMove(new Vector3(0, 5.93f, 0), 1f);
        PlayerCamera.transform.DOMove(new Vector3(0, 10, -10), 1f);
        Invoke("disablebasment", 1f);
    }
    private void disablebasment()
    {
        basment.SetActive(false);
    }
}
