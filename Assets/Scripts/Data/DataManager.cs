using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public Data data { get; private set; }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);

        LoadData();
    }

    private void LoadData()
    {
        if (!PlayerPrefs.HasKey("save"))
        {
            data = new Data();
            return;
        }

        data = JsonUtility.FromJson<Data>(PlayerPrefs.GetString("save"));
    }

    private void SaveData()
    {
        PlayerPrefs.SetString("save", JsonUtility.ToJson(data));
    }

    public class Data
    {
        
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus) SaveData();
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }
}
