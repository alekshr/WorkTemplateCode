using System.Collections.Generic;
using UnityEngine;

namespace WorkTemplateCode.Serializator
{
    public class ArrayModelExample : MonoBehaviour
    {
        public List<ModelExample> ModeExamples;

        public ArrayModelExample() =>
            ModeExamples = new List<ModelExample>();
    }
}
