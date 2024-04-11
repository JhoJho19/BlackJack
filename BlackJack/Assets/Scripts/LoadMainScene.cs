using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.SearchService;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName()
    {
        SceneManager.LoadScene("BJScene");
    }
}
