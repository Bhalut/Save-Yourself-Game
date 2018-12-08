using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] enemyes;
    [SerializeField]
    GameObject nextObject;
    int countEnemy;

    // Use this for initialization
    void Start()
    {
        nextObject.SetActive(false);
        countEnemy = enemyes.Length + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (countEnemy == 0)
        {
            nextObject.SetActive(true);
        }
    }
}
