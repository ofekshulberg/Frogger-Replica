using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Car carScript;

    void OnTriggerEnter2D()
    {
        Debug.Log("WE WON!");
        Score.CurrentScore += 100;
        carScript.AdjustSpeed(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
