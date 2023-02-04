namespace WorkTemplateCode.Serializator
{
    /// <summary>
    /// Конвертирует объекты в json
    /// </summary>
    public interface IJsonConverter
    {
        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="value">Значение</param>
        /// <typeparam name="T">Тип</typeparam>
        /// <returns>Возвращает строку json</returns>
        string Serialize<T>(T value) where T : class;

        T Deserialize<T>(string json) where T : class;
    }
}