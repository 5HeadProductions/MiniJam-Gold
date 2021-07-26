using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    private GameObject button;
    private GameObject text;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu"){
            button = GameObject.Find("PlayButton");
            text = GameObject.Find("Title");
            animator = GameObject.Find("Pig").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Play(){
        text.SetActive(false);
      //
        StartCoroutine(LoadPlayScene());


    }

    public void Replay(){
        SceneManager.LoadScene("PlayScene");

    }
    IEnumerator LoadPlayScene(){
         button.transform.localScale = new Vector2(0f,0f);
        animator.SetBool("Play", true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1.3f);

        SceneManager.LoadScene("PlayScene");

    }
}
