using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject catPrefab;

    [SerializeField] private Transform parent;

    [SerializeField] private float timeToSpawn;

    private float leftTime;

    private CatManager catManager;

    private void Awake()
    {
        leftTime = timeToSpawn;

        catManager = GameObject.FindGameObjectWithTag("Managers").GetComponent<CatManager>();
    }

    private void Update()
    {
        leftTime -= Time.deltaTime;

        if (leftTime > 0) return;

        leftTime = timeToSpawn;

        Instantiate(catPrefab, parent, false).GetComponent<SpriteRenderer>().sprite = 
            catManager.GetSprite();
    }

}
