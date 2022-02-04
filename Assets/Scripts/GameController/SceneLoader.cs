using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public enum Scene
    {
        Tutorial,
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
