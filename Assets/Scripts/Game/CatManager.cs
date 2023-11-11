using UnityEngine;

public class CatManager : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;

    private Sprite[] availableSprites;

    private void Awake()
    {
        availableSprites = new Sprite[] { sprites[0] };
    }

    public Sprite GetSprite()
    {
        return availableSprites[Random.Range(0, availableSprites.Length)];
    }

    public Sprite GetSprite(int index)
    {
        return availableSprites[index];
    }

    public void UnlockNextSlot()
    {
        availableSprites = new Sprite[availableSprites.Length + 1];

        for (int i = 0; i < availableSprites.Length; i++) 
        {
            availableSprites[i] = sprites[i];
        }
    }    
}
