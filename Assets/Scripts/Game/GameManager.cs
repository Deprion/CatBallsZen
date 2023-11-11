using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnerPrefab;

    [SerializeField] private GameObject[] levels;

    private GameObject level;

    private void Awake()
    {
        level = Instantiate(levels[0]);

        level.transform.localPosition = new Vector2(0, -5);
    }
}
