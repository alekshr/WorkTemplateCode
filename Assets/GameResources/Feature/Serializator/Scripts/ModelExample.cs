using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace WorkTemplateCode.Serializator
{
    public class ModelExample : AbstractClassExample, InterfaceExample
    {
        public string Color;

        public string Name;
    
        public float Height { get; set; }
    
        public ModelExample(string Color, string Name, float Height, int Age)
        {
            this.Color = Color;
            this.Name = Name;
            this.Height = Height;
            this.Age = Age;
        }
    }

    public class ModelExampleSecond : ModelExample
    {
        public string AdditionalData = string.Empty;
    
        public ModelExampleSecond(string Color, string Name, float Height, int Age) : base(Color, Name, Height, Age)
        {
        
        }
    }
}