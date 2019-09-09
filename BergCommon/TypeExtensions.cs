using System.Management;

namespace BergCommon
{
    public static class TypeExtensions
    {
        #region GetFieldValue
        public static string GetFieldValue(this ManagementBaseObject systemItem, string fieldName)
        {
            string Result = string.Empty;

            try
            {
                Result = systemItem.GetPropertyValue(fieldName).ToString();
                //Result = systemItem[fieldName].ToString();
            }
            catch { }

            return Result;
        }
        #endregion GetFieldValue
    }
}
