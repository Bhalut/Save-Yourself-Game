using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Resources;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// A public Text function is created for an Array where the names are saved.
    /// A method called myAddEntryButton is done to call the playerInfo and the HighScores to instantiate the methods for the Score and the name and initialize the UpdateScores.
    /// /// A method called UpdateScores is created in which a forw is placed so that when the Score table is less than 10 it does not stop filling the spaces of the Array FinalPosition.
    /// In the Start method, the Load method of the DataManager class is requested and the UpdateScores method is added.
    /// </summary>


    /// <summary>
    /// A method is created that will change the scene.
    /// </summary>
    /// <param name="i">
    /// An int is created that will be the scene to be loaded.
    /// </param>
    public void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    /// <summary>
    /// A method  to activate the canvas assigned in the inspector  
    /// </summary>
    /// <param name="canvasToActivate">
    ///This parameter creates a GameObject for the canvas to be activated.
    /// </param>
    public void ActivateCanvas(GameObject canvasToActivate)
    {
        canvasToActivate.SetActive(true);
    }

    /// <summary>
    /// Method to deactivate the canvas assigned in the inspector.
    /// </summary>
    /// <param name="canvasToDeactivate">
    /// This parameter is the GameObject of the canvas to be deactivated.
    /// </param>
    public void DeactivateCanvas(GameObject canvasToDeactivate)
    {
        canvasToDeactivate.SetActive(false);
    }

    /// <summary>
    /// And one method of exiting the game.
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// Depending on the scene loaded, activate or deactivate some UI elements
    /// </summary>
    /// <param name="scene"></param>
    /// A Scene function is created to search for the scenes in unity.
    /// <param name="mode"></param>
    /// A LoadSceneMode type function is created to load the scene I'm looking for in unity.
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // TODO Depending on the scene loaded, activate or deactivate some panels
        Debug.Log(scene.name);
    }
    /// <summary>
    /// When the scene is loaded add the OnSceneLoaded method from the beginning.
    /// </summary>
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    /// <summary>
    /// When the scene is loaded, the OnSceneLoaded method is removed.
    /// </summary>
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
