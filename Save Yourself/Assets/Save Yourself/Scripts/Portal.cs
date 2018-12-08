using UnityEngine;

public class Portal : MonoBehaviour
{
    UIManager uIManager;
    [SerializeField]
    int nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uIManager.ChangeScene(nextLevel);
        }
    }
}
