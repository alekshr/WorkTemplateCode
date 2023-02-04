using System.Collections.Generic;
using UnityEngine;

namespace WorkTemplateCode.Serializator
{
    public class ExampleWorkSerializator : MonoBehaviour
    {

        private const string EXAMPLE_PREFS_KEY = "ExamplePrefsKey";

        private List<ModelExample> _modelExamples;

        private IJsonConverter _jsonConverter = new ObjectJsonConverter();
        private void Start()
        {
        
            if (PlayerPrefs.HasKey(EXAMPLE_PREFS_KEY))
            {       
                _modelExamples = _jsonConverter.Deserialize<List<ModelExample>>(EXAMPLE_PREFS_KEY);
                foreach (var modelExample in _modelExamples)
                {
                    Debug.Log($"{modelExample.Color}; {modelExample.Name} {modelExample.Age} {modelExample.Age}");
                }
            }
            else
            {
                _modelExamples = new List<ModelExample>();
                _modelExamples.Add(new ModelExample("Red", "Aleks", 150.5f, 15));
                _modelExamples.Add(new ModelExample("Yellow", "Tom", 120.5f, 27));
                _modelExamples.Add(new ModelExample("Blue", "Harry", 200.5f, 40));
            }
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            if (!hasFocus)
            {
                //_jsonConverter.Serialize(_modelExamples, EXAMPLE_PREFS_KEY);
            }
        }
    }
}
