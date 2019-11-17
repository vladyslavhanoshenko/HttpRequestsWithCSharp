using System;
using System.Collections.Generic;
using System.Text;

namespace HttpRequestsWithCSharp.Helpers
{
    public static class DataTransformationHelper
    {
        public static string CreateStringForPostRequest(BaseLoginModel model)
        {
            return $"usr={model.UserName}&pwd={model.Password}";
        }
    }
}
