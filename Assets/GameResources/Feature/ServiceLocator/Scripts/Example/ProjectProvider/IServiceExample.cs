using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkTemplateCode.ServiceLocator.Example
{

    public interface IServiceExample
    {
        int Value { get; }

        string Name { get; }
    }
}