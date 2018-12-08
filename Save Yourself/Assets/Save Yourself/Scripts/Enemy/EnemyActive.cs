using UnityEngine;

public class EnemyActive : MonoBehaviour
{
    [SerializeField]
    GameObject[] enemyes;

    private void Start()
    {
        foreach (var item in enemyes)
        {
            item.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var item in enemyes)
        {
            item.SetActive(true);
        }
    }
}
