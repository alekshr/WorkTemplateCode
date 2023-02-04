using UnityEngine;
using UnityEngine.UI;
using WorkTemplateCode.ServiceLocator.ProviderProject;

namespace WorkTemplateCode.ServiceLocator.Example
{
    public class ServiceProviderProjectController : MonoBehaviour
    {

        [SerializeField] private Text _valueProjectProvider;
        [SerializeField] private Text _nameTextProjectProvider;
        [SerializeField] private Text _valueSceneProvider;
        [SerializeField] private Text _nameTextSceneProvider;
        
        private IServiceExample _serviceExampleProjectProvider;
        private IServiceExample _serviceExampleSceneProvider;

        private void Start()
        {
            _serviceExampleProjectProvider = AbstractProjectProviderService<IServiceExample>.Instance.Get<ServiceExample>();
            _serviceExampleSceneProvider = AbstractProviderService<IServiceExample>.Instance?.Get<ServiceExample>();


            _valueProjectProvider.text += _serviceExampleProjectProvider.Value.ToString();
            _nameTextProjectProvider.text += _serviceExampleProjectProvider.Name;

            if (_serviceExampleSceneProvider == null)
            {
                Debug.LogError("Scene Provider is null");
            }
            else
            {
                _valueSceneProvider.text += _serviceExampleSceneProvider.Value.ToString();
                _nameTextSceneProvider.text += _serviceExampleSceneProvider.Name;
            }
        }
    }
}