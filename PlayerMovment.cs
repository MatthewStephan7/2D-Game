using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    [SerializeField] bool isAlive = true;

    private Rigidbody2D body;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatisGrounded;
    public GameObject gameOverText;
    public GameObject restartButton;
    public GameObject mainMenu;
    public Text ScoreText;
    float score;
    



    private void Start()
    {
        
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        mainMenu.SetActive(false);
        score = 0;

    }
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, body.velocity.y);

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatisGrounded);
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            
            SoundManagerScript.PlaySound("jump");
            body.velocity = Vector2.up * jump;
        }
      
        
        
       
        
        
        if (isAlive)
        {
            score += Time.deltaTime * 6;
            ScoreText.text = "Score: " + score.ToString("0");
        }


        {

        }
        


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("spike"))
        {
            isAlive = false;
            
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            mainMenu.SetActive(true);
            gameObject.SetActive(false);
            SoundManagerScript.PlaySound("hit");
        }
    }
}
