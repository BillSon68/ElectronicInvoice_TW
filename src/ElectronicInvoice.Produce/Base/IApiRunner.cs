namespace ElectronicInvoice.Service.Base
{
    /// <summary>
    /// ����api������
    /// </summary>
    public interface IApiRunner
    {
        /// <summary>
        /// ����api
        /// </summary>
        /// <param name="model">�ǤJ���Ѽ�</param>
        /// <returns>�^�Ǹ��</returns>
        string ExcuteApi(object model);
    }
}