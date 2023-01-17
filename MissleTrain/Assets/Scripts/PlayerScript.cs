using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : PhysicsObject
{
    [SerializeField] private float maxSpeed = 1f;
    [SerializeField] private float jumpPower = 10f;
    private Vector2 healthBarOrigSize;

    public int currentHealth = 100;
    private int maxHealth = 100;

    public static PlayerScript instance;

    public static PlayerScript Instance
    {
        get
        {
            if (instance == null) instance = PlayerScript.FindObjectOfType<PlayerScript>();
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        healthBarOrigSize = GameManager.Instance.healthBar.rectTransform.sizeDelta;

        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, 0);   
        
        if(Input.GetButtonDown("Jump") &&  grounded)
        {
            velocity.y = jumpPower;
        }

        if(targetVelocity.x < -0.1)
        {
            transform.localScale = new Vector2((float)-0.6,(float)0.6);
        }
        
        if (targetVelocity.x > 0.1)
        {
            transform.localScale = new Vector2((float)0.6,(float)0.6);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            
        }
    }

   

    public void UpdateUI()
    {
        GameManager.Instance.healthBar.rectTransform.sizeDelta = new Vector2(healthBarOrigSize.x * ((float)currentHealth / (float) maxHealth), GameManager.Instance.healthBar.rectTransform.sizeDelta.y);
    }
}
