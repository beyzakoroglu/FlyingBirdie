using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    BirdieScript birdie;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    [ContextMenu("Increase Score")]
    public void updateScore(int point)
    {
        birdie = GameObject.FindGameObjectWithTag("Birdie").GetComponent<BirdieScript>();
        
        if(birdie.getIsBirdieAlive())
        {
            playerScore = playerScore + point;
            scoreText.text = playerScore.ToString();            
            audioManager.PlaySFX(audioManager.getPoint1);
        }
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        audioManager.PlaySFX(audioManager.dead);
        Invoke("StopGame", 0.02f);
        gameOverScreen.SetActive(true);
    }

    private void StopGame(){
        Time.timeScale = 0;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
