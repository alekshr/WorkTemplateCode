
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WorkTemplateCode.ServiceLocator.Example
{
    [RequireComponent(typeof(Button))]
    public class SceneButton : MonoBehaviour
    {
        [SerializeField] private string nameScene;
        
        private Button nextSceneButton;

        private void Awake()
        {
            nextSceneButton = GetComponent<Button>();
            nextSceneButton.onClick.AddListener(NextScene);
        }

        private void OnDestroy()
        {
            nextSceneButton.onClick.RemoveListener(NextScene);
        }

        private void NextScene()
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}