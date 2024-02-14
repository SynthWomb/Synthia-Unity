using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Networking : MonoBehaviour
{
    public TMPro.TMP_InputField promptInput;
    public TMPro.TMP_Text generatedText;
    public Button Submit;

    string url = "http://127.0.0.1:5000/";

    void Start()
    {
        generatedText.text = "";
    }

    public void StartWebRequest()
    {
        string prompt = promptInput.text;
        StartCoroutine(MakeWebRequest(prompt));
    }

    IEnumerator MakeWebRequest(string prompt)
    {
        Submit.enabled = false;
        generatedText.text = "Generating";

        WWWForm form = new WWWForm();
        form.AddField("prompt", prompt);

        UnityWebRequest www = UnityWebRequest.Post(url + "generate", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError($"UnityWebRequest failed: {www.error}");
        }
        else
        {
            Debug.Log($"UnityWebRequest successful! Response: {www.downloadHandler.text}");
            generatedText.text = www.downloadHandler.text;
        }

        Submit.enabled = true;
    }
}
