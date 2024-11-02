using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    private bool isWhite;
    public float fadeDuration;
    public GameObject Player;
    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        isWhite = false;
        StartCoroutine(fadeColor());
        Player = GameObject.Find("Player");
        sr = Player.GetComponent<SpriteRenderer>();
        sr.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator fadeColor()
{

    while (true){
        Color startColor = isWhite ? Color.white : Color.black;
        Color endColor = isWhite ? Color.black : Color.white;

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            Camera.main.backgroundColor = Color.Lerp(startColor, endColor, elapsedTime / fadeDuration);
            sr.color = Color.Lerp(endColor, startColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Camera.main.backgroundColor = endColor; //Ensure it reaches the final color
        isWhite = !isWhite; //Toggle the color direction
        yield return new WaitForSeconds(1f); //Optional pause between frames    

    }


}

}

