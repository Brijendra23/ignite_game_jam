using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float dialogueSpeed;
    public Animator anim;
    private bool startDialogue=true;

    // Start is called before the first frame update
    void Start()
    {
        if (startDialogue)
        {
            anim.SetTrigger("entry");
            startDialogue = false;
        }
        NextSentence();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
    }
    void NextSentence()
    {
        if(Index<=Sentences.Length-1)
        {
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
        else
        {
            dialogueText.text = "";
            anim.SetTrigger("exit");
            SceneManager.LoadScene("SampleScene");
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
    }
}
