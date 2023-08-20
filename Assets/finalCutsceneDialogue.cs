using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalCutsceneDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] Sentences;
    private int Index;
    public float speed;
    public Animator dialogueAnim;
    public Animator enemyAnim;
    private bool startDialogue = true;
    private bool isWriting = false;
    public GameObject grenade;
    private float bulletSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        if (startDialogue)
        {
            dialogueAnim.SetTrigger("entry");
            startDialogue = false;
        }
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
        if (Index <= Sentences.Length - 1)
        {
            dialogueText.text = "";
            StartCoroutine(WriteSentences());
        }
        else
        {
            dialogueText.text = "";
            dialogueAnim.SetTrigger("exit");
            enemyAnim.SetInteger("WeaponType_int", 10);
            StartCoroutine(Grenade());
        }
    }
    IEnumerator WriteSentences()
    {
        foreach (char character in Sentences[Index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(speed);
        }
        Index++;
        isWriting = false;
    }
    IEnumerator Grenade()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject clone = Instantiate(grenade);
        clone.transform.position = new Vector3(-109, 7, 213);
        clone.AddComponent<grenade>();
    }
}
