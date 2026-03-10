using UnityEngine;
using TMPro;
using System.Collections;

public class FadeAwayMessage : MonoBehaviour
{
    public float fadeTime;
    private TextMeshProUGUI fadeAwayText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeAwayText = GetComponent<TextMeshProUGUI>();

        Color c = fadeAwayText.color;
        fadeAwayText.color = new Color(c.r, c.g, c.b, 0f);
    }

    public void startFade()
    {
        StopAllCoroutines();
        StartCoroutine(fadeText());
    }

    IEnumerator fadeText()
    {
        Color c = fadeAwayText.color;
        fadeAwayText.color = new Color(c.r, c.g, c.b, 1f);

        float timer = fadeTime;

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            float alpha = timer / fadeTime;
            fadeAwayText.color = new Color(c.r, c.g, c.b, alpha);
            yield return null;
        }

        fadeAwayText.color = new Color(c.r, c.g, c.b, 0f);
    }
}
