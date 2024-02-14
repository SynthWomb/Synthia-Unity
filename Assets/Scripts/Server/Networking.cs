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
    int maxRetries = 3;         
    float retryDelay = 1.0f;        

    void Start()
    {
        generatedText.text = "";
    }

    public void StartWebRequest()
    {
        string prompt = promptInput.text;
        StartCoroutine(MakeWebRequestWithRetries(prompt));
    }

    IEnumerator MakeWebRequestWithRetries(string prompt)
    {
        Submit.enabled = false;
        generatedText.text = "Generating";

        for (int attempt = 1; attempt <= maxRetries; attempt++)
        {
            if (attempt > 1)
            {
                Debug.Log($"Retrying web request (Attempt {attempt}/{maxRetries})");
                yield return new WaitForSeconds(retryDelay);
            }

            WWWForm form = new WWWForm();
            form.AddField("prompt", prompt);

            UnityWebRequest www = UnityWebRequest.Post(url + "generate", form);
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log($"UnityWebRequest successful! Response: {www.downloadHandler.text}");
                generatedText.text = www.downloadHandler.text;
                break;         
            }
            else
            {
                Debug.LogWarning($"UnityWebRequest failed (Attempt {attempt}/{maxRetries}): {www.error}");
            }
        }

        Submit.enabled = true;
    }
}

