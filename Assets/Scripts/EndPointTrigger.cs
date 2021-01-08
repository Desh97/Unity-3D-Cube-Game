using UnityEngine;

public class EndPointTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
