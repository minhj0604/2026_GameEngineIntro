using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManagerScript : MonoBehaviour
{
    public GameObject helpPanel;
   /* public void ButtonLog()
    {
        Debug.Log("버튼 눌림!");
    }
   */

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }
    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelp()
    {
       helpPanel.SetActive(false);
    }
}
