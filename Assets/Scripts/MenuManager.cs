using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject PausaPanel;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause ()
    {
        PausaPanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
        {
        PausaPanel.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
    }

    public void Quit()
    {
        Time.timeScale = 1f;

        Application.Quit();
    }
  
    
}
