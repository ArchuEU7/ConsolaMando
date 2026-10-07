using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{

    [SerializeField] GameObject PaussaPanel;
    [SerializeField] GameObject resumeButton;
    private bool isPaused = false;

    public void OnPause(InputValue value)
    {
        if (!value.isPressed)
            return; 
        if (isPaused)
            Resume();
        else
            Pause();
    }
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
        PaussaPanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        EventSystem.current.SetSelectedGameObject(resumeButton);
    }

    public void Resume()
        {
        PaussaPanel.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void Quit()
    {
        Time.timeScale = 1f;

        Application.Quit();
    }
  
    
}
