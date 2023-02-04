using UnityEngine;

namespace CodeBase.Serializator.Scripts
{
    /// <summary>
    /// Сериализаци в инспекторе, ввод текста Json
    /// </summary>
    public class InspectorArraySerializer : MonoBehaviour
    {
        [SerializeField] 
        private string _keyPrefs = default;

        [SerializeField]
        private string _typeNameObject = default;

        
    }
}