using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class TranslateManager : MonoBehaviour
{
    public static TranslateManager inst;
    private Dictionary<string, string> translate = new Dictionary<string, string>();

    [SerializeField] private TextAsset[] textAssets;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        inst = this;
    }

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        if (Application.systemLanguage == SystemLanguage.Russian)
            Fill(textAssets[0]);
        else
            Fill(textAssets[1]);
    }

    private void Fill(TextAsset txt)
    {
        Regex regex = new Regex(":|;\r?\n?");
        var arr = regex.Split(txt.text);

        for (int i = 0; i < arr.Length - 1; i+=2)
        {
            translate[arr[i]] = arr[i + 1];
        }
    }

    public string GetText(string text)
    {
        return translate[text];
    }
}
