using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    public GameObject DialoguePanel;
    // Start is called before the first frame update
    void Start()
    {
        DialoguePanel.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == PlayerScript.Instance.gameObject )
        {
           DialoguePanel.SetActive(true);
        }
    }
}
