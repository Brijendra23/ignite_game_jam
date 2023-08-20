using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AftermathDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float dialogueSpeed;
    private bool startDialogue=true;
    private bool isWriting = false;


    // Start is called before the first frame update
    void Start()
    {
        isWriting = true;
        NextSentence();

    }

    // Update is called once per frame
    void Update()
    {
        if (!isWriting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isWriting = true;
                NextSentence();
            }
        }
    }
    void NextSentence()
    {
        if(Index<=Sentences.Length-1)
        {
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
    }
    IEnumerator WriteSentence()
    {
        foreach (char character in Sentences[Index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(dialogueSpeed);
        }
        Index++;
        isWriting = false;

    }
}
