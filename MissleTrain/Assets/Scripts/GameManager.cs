using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Image healthBar;

    public static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null) instance = GameManager.FindObjectOfType<GameManager>();
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
