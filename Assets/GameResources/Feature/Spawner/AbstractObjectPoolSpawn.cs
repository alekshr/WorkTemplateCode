using UnityEngine;
using UnityEngine.Pool;


namespace WorkTemplateCode.Spawner
{
    /// <summary>
    /// Абстарктынй пул объектов
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    public abstract class AbstractObjectPoolSpawn<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] protected T _obj = default;

        [SerializeField] protected Transform[] _pointSpawns = default;
        
        protected IObjectPool<T> _poolObject;

        protected virtual void Awake() =>
            _poolObject = new ObjectPool<T>(OnCreateObject, OnGetObject, OnReleasedObject);


        protected abstract T OnCreateObject();
        protected abstract void OnGetObject(T obj);
        protected abstract void OnReleasedObject(T obj);
    }
}
